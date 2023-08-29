using System.Timers;

namespace MiniBackuper
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer copyTimer = new System.Timers.Timer();
        private string _path;
        private int _time = 5;
        private int _counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _path = dialog.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(_path);
            watcher.EnableRaisingEvents = true;
            watcher.SynchronizingObject = this;
            watcher.NotifyFilter = NotifyFilters.FileName
                                 | NotifyFilters.LastWrite;

            watcher.Changed += new FileSystemEventHandler(Watcher_Change);
            watcher.Created += new FileSystemEventHandler(Watcher_Change);
            watcher.Deleted += new FileSystemEventHandler(Watcher_Change);
        }

        private void Watcher_Change(object sender, FileSystemEventArgs e)
        {
            _counter++;

            if (_counter >= 3)
            {
                copyTimer.Stop();
                InitializeTimer(_time);
                _counter = 0;
            }
            
        }
        private void InitializeTimer(int time)
        {
            copyTimer.Interval = TimeSpan.FromSeconds(time).TotalMilliseconds;
            copyTimer.AutoReset = false;
            copyTimer.Start();
            copyTimer.Elapsed += (sender, e) => CopyFolder();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _time = int.Parse(textBox1.Text);
        }
    }
}