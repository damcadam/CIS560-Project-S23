namespace CIS_560_Project_Team_16
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create the different forms
            AccountLogin accountLogin = new();
            MainWindow mainWindow = new();
            UserSelection userSelection = new();

            // Give GUIs objects to the others so they can show and hide each other
            accountLogin.SetUserWindow(userSelection);

            // Run the application
            Application.Run(new AccountLogin());
        }
    }
}