namespace MiniBackuper
{
    public class BackupFolder
    {
        public static void CopyFolder(string path)
        {
            string destinationFolderPath = path + $" {DateTime.Now:dd.MM.yy HH.mm.ss} back";
            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationFilePath = Path.Combine(destinationFolderPath, fileName);
                File.Copy(file, destinationFilePath, true);
            }

            string[] subdirectories = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectories)
            {
                string subdirectoryName = Path.GetFileName(subdirectory);
                string destinationSubdirectoryPath = Path.Combine(destinationFolderPath, subdirectoryName);
            }
        }
    }
}
