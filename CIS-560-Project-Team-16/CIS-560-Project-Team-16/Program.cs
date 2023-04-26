namespace CIS_560_Project_Team_16
{
    public delegate void CheckDatabaseForUsername();

    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create the different forms
            AccountLogin logInWindow = new();
            MainWindow mainWindow = new();



            // Run the application
            Application.Run(new AccountLogin());
        }
    }
}