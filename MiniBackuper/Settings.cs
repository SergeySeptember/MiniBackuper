using Microsoft.Win32;

namespace MiniBackuper
{
    public class Settings
    {
        public static void SetSettings(int editLimit, int time, string path, bool startBack)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\MiniBackuper\\", true);
            key.SetValue("Time", time.ToString());
            key.SetValue("Edit Limit", editLimit.ToString());
            key.SetValue("Path", path);
            key.SetValue("Start", startBack.ToString());
            key.Close();
        }

        public static (int, int, string, string, bool) ReadSettings()
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\MiniBackuper\\", true);
            int editLimit = Convert.ToInt32(key.GetValue("Time"));
            int time = Convert.ToInt32(key.GetValue("Edit Limit"));
            string path = key.GetValue("Path")?.ToString();
            bool start = Convert.ToBoolean(key.GetValue("Start"));

            RegistryKey keyAutorun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
            string autorun = keyAutorun.GetValue("MiniBackuper")?.ToString();
            return (editLimit, time, path, autorun, start);
        }

        public static void AutorunOn()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);

            key.SetValue("MiniBackuper", $"{Environment.CurrentDirectory}\\MiniBackuper.exe");
            key.Close();
        }

        public static void AutorunOff()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.DeleteValue("MiniBackuper", false);
            key.Close();
        }
    }
}
