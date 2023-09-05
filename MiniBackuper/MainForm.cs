using MaterialSkin.Controls;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MiniBackuper
{
    public partial class MainForm : MaterialForm
    {
        private System.Timers.Timer _copyTimer = new();
        private string _path;
        private int _time = 5;
        private int _counter = 0;
        private int _editLimit = 3;
        private bool _startBackWithOS = false;

        public int Time
        {
            get { return _time; }
            set { _time = value; Settings.SetSettings(_editLimit, _time, _path, _startBackWithOS); }
        }

        public int EditLimit
        {
            get { return _editLimit; }
            set { _editLimit = value; Settings.SetSettings(_editLimit, _time, _path, _startBackWithOS); }
        }

        public string PathFolder
        {
            get { return _path; }
            set { _path = value; Settings.SetSettings(_editLimit, _time, _path, _startBackWithOS); }
        }

        public MainForm()
        {
            InitializeComponent();
            ApplySettings();

            textBoxTime.TextChanged += TextBoxTimeTextChanged;
            textBoxTime.KeyDown += TextBoxTimeKeyEnter;
            textBoxCount.TextChanged += TextBoxCountTextChanged;
            textBoxCount.KeyDown += TextBoxCountKeyEnter;
            checkBoxAutorun.CheckedChanged += CheckBoxAutoranCheckedChanged;
            checkBoxStart.CheckedChanged += CheckBoxStartCheckedChanged;
            labelLogo.MouseDown += LabelLogoMouseDown;
            notifyIcon.MouseDoubleClick += new MouseEventHandler(NotifyIconMouseDoubleClick);
            this.Resize += new EventHandler(this.FormResize);
        }

        private void CheckBoxStartCheckedChanged(object? sender, EventArgs e)
        {
            if (checkBoxStart.Checked)
                _startBackWithOS = true;
            else
                _startBackWithOS = false;

            Settings.SetSettings(_editLimit, _time, _path, _startBackWithOS);
        }

        private void ApplySettings()
        {
            var tuple = Settings.ReadSettings();
            _editLimit = tuple.Item1;
            _time = tuple.Item2;
            _path = tuple.Item3;
            string autorun = tuple.Item4;
            _startBackWithOS = tuple.Item5;

            if (autorun != null && _startBackWithOS)
            {
                checkBoxAutorun.Checked = true;
                checkBoxStart.Checked = true;
                ButtonStartBackupClick(null, null);
                buttonStart.Text = "Launched";
                buttonStart.Enabled = true;
            }
            else if (autorun != null)
            {
                checkBoxAutorun.Checked = true;
                buttonStart.Enabled = true;
            }
            else
                checkBoxAutorun.Checked = false;
        }

        private void FormResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void NotifyIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            textBoxTime.Text = $"{_time}";
            textBoxCount.Text = $"{_editLimit}";
            this.Region = new Region(RoundedRect(new Rectangle(0, 0, this.Width, this.Height), 5));
            buttonStart.Enabled = false;

        }

        private void CheckBoxAutoranCheckedChanged(object? sender, EventArgs e)
        {
            if (checkBoxAutorun.Checked)
                Settings.AutorunOn();
            else
                Settings.AutorunOff();
        }

        private void ButtonBrowseFolderClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PathFolder = dialog.SelectedPath;
                buttonStart.Enabled = true;
            }
        }

        private void ButtonStartBackupClick(object sender, EventArgs e)
        {
            Settings.SetSettings(_editLimit, _time, _path, _startBackWithOS);

            FileSystemWatcher watcher = new(_path);
            watcher.EnableRaisingEvents = true;
            watcher.SynchronizingObject = this;
            watcher.NotifyFilter = NotifyFilters.FileName
                     | NotifyFilters.DirectoryName
                     | NotifyFilters.LastWrite
                     | NotifyFilters.CreationTime;
            watcher.Changed += new FileSystemEventHandler(WatcherChange);
            watcher.Created += new FileSystemEventHandler(WatcherChange);
            watcher.Deleted += new FileSystemEventHandler(WatcherChange);
            watcher.Renamed += new RenamedEventHandler(WatcherChange);
        }

        private void WatcherChange(object sender, FileSystemEventArgs e)
        {
            _counter++;

            if (_counter >= _editLimit)
            {
                _copyTimer.Stop();
                InitializeTimer(_time);
                _counter = 0;
            }
        }
        private void InitializeTimer(int time)
        {
            _copyTimer.Interval = TimeSpan.FromSeconds(time).TotalMilliseconds;
            _copyTimer.AutoReset = false;
            _copyTimer.Start();
            _copyTimer.Elapsed += (sender, e) => BackupFolder.CopyFolder(_path);
        }

        private void TextBoxTimeTextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxTime.Text, "[^0-9]"))
            {
                textBoxTime.Text = textBoxTime.Text.Remove(textBoxTime.TextLength - 1);
                textBoxTime.SelectionStart = textBoxTime.Text.Length;
            }
            else
            {
                if (int.TryParse(textBoxTime.Text, out int parsedTime))
                    Time = parsedTime;
            }
        }

        private void TextBoxTimeKeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Time = int.Parse(textBoxTime.Text);
        }

        private void TextBoxCountKeyEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EditLimit = int.Parse(textBoxCount.Text);
        }

        private void TextBoxCountTextChanged(object? sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxCount.Text, "[^0-9]"))
            {
                textBoxCount.Text = textBoxCount.Text.Remove(textBoxCount.TextLength - 1);
                textBoxCount.SelectionStart = textBoxCount.Text.Length;
            }
            else
            {
                if (int.TryParse(textBoxCount.Text, out int parsedCount))
                    EditLimit = parsedCount;
            }
        }

        private void PictureBoxCloseClick(object sender, EventArgs e) => Application.Exit();

        private void MainFormMouseDown(object sender, MouseEventArgs e) => MoveForm();

        private void LabelLogoMouseDown(object? sender, MouseEventArgs e) => MoveForm();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoveForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBoxMinClick(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();

            path.AddArc(arc, 180, 90);

            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}