using MaterialSkin.Controls;
using Microsoft.Win32;
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

        public MainForm()
        {
            InitializeComponent();

            textBoxTime.TextChanged += TextBoxTimeTextChanged;
            textBoxTime.KeyDown += TextBoxTimeKeyEnter;
            textBoxCount.TextChanged += TextBoxCountTextChanged;
            textBoxCount.KeyDown += TextBoxCountKeyEnter;
            checkSwitchAutorun.CheckedChanged += CheckSwitchCheckedChanged;
            labelLogo.MouseDown += LabelLogoMouseDown;

            notifyIcon.MouseDoubleClick += new MouseEventHandler(NotifyIconMouseDoubleClick);
            this.Resize += new EventHandler(this.FormResize);
            ReadSettings();
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

        private void CheckSwitchCheckedChanged(object? sender, EventArgs e)
        {
            if (checkSwitchAutorun.Checked)
            {
                AutorunOn();
            }
            else
            {
                AutorunOff();
            }
        }

        private void ButtonBrowseFolderClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _path = dialog.SelectedPath;
                buttonStart.Enabled = true;
            }
        }


        private void ButtonStartBackupClick(object sender, EventArgs e)
        {
            FileSystemWatcher watcher = new(_path);
            watcher.EnableRaisingEvents = true;
            watcher.SynchronizingObject = this;
            watcher.NotifyFilter = NotifyFilters.FileName
                                 | NotifyFilters.LastWrite;

            watcher.Changed += new FileSystemEventHandler(WatcherChange);
            watcher.Created += new FileSystemEventHandler(WatcherChange);
            watcher.Deleted += new FileSystemEventHandler(WatcherChange);
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
            _copyTimer.Elapsed += (sender, e) => CopyFolder();
        }

        private void CopyFolder()
        {
            string destinationFolderPath = _path + $" {DateTime.Now.ToString("dd.MM.yy HH.mm.ss")} back";
            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            string[] files = Directory.GetFiles(_path);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationFilePath = Path.Combine(destinationFolderPath, fileName);
                File.Copy(file, destinationFilePath, true);
            }

            string[] subdirectories = Directory.GetDirectories(_path);
            foreach (string subdirectory in subdirectories)
            {
                string subdirectoryName = Path.GetFileName(subdirectory);
                string destinationSubdirectoryPath = Path.Combine(destinationFolderPath, subdirectoryName);
                CopyFolder();
            }
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
                _time = int.Parse(textBoxTime.Text);
            }
        }

        private void TextBoxTimeKeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _time = int.Parse(textBoxTime.Text);
            }
        }

        private void TextBoxCountKeyEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _editLimit = int.Parse(textBoxTime.Text);
            }
        }

        private void TextBoxCountTextChanged(object? sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxTime.Text, "[^0-9]"))
            {
                textBoxTime.Text = textBoxTime.Text.Remove(textBoxTime.TextLength - 1);
                textBoxTime.SelectionStart = textBoxTime.Text.Length;
            }
            else
            {
                _editLimit = int.Parse(textBoxTime.Text);
            }
        }

        private void ReadSettings()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
            string autorun = key.GetValue("MiniBackuper")?.ToString();

            if (autorun != null)
            {
                checkSwitchAutorun.Checked = true;
            }
            else
            {
                checkSwitchAutorun.Checked = false;
            }
        }

        private void AutorunOn()
        {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);

            Key.SetValue("MiniBackuper", $"{Environment.CurrentDirectory}\\MiniBackuper.exe");
            Key.Close();
        }

        private void AutorunOff()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.DeleteValue("MiniBackuper", false);
            key.Close();
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

        public GraphicsPath RoundedRect(Rectangle baseRect, int radius)
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