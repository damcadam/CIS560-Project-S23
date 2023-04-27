using CIS_560_Project_Team_16.Controllers;
using CIS_560_Project_Team_16.Views;

namespace CIS_560_Project_Team_16
{
    public delegate void ClearALToolStripMessageDEL();
    public delegate void UpdateALToolStripMessageDEL(string message);
    public delegate void ClearACToolStripMessageDEL();
    public delegate void UpdateACToolStripMessageDEL(string message);
    public delegate bool ValidateALCredentialsDEL(string username, string user_password);
    public delegate bool CheckACDBForUsernameDEL(string username);
    public delegate bool CompareACPasswordsDEL(string password1, string password2);
    public delegate void ShowACWindowDEL();
    public delegate void NotifyControllerShowACWindowDEL();
    public delegate void ShowALWindowDEL();
    public delegate void NotifyControllerShowALWindowDEL();

    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Creates controller
            WindowController controller = new WindowController();

            // Create the different forms
            AccountLogin logInWindow = new(controller.ValidateCredentials_AL,
                controller.ShowACWindowController);
            AccountCreation accCreateWindow = new(controller.CheckDBForUsername_AC,
                controller.ComparePasswords_AC,
                controller.ShowALWindowController);

            controller.RegisterClearALMessageDel(logInWindow.ClearALToolStripMessage);
            controller.RegisterUpdateALMessageDel(logInWindow.UpdateToolStripMessage);
            controller.RegisterClearACMessageDel(accCreateWindow.ClearACToolStripMessage);
            controller.RegisterUpdateACMessageDel(accCreateWindow.UpdateACToolStripMessage);
            controller.RegisterShowACWindowDel(accCreateWindow.ShowACWindow);
            controller.RegisterShowALWindowDel(logInWindow.ShowALWindow);

            // Run the application
            Application.Run(logInWindow);
        }
    }
}