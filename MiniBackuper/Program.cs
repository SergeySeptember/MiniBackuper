namespace MiniBackuper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ThreadException += new ThreadExceptionEventHandler(Exception);
            Application.Run(new MainForm());

            static void Exception(object sender, ThreadExceptionEventArgs e)
            {
                MessageBox.Show("Если видишь это окно, сделай скрин и скниь горе-разрабу\n" + e.Exception.ToString());
            }
        }
    }
}