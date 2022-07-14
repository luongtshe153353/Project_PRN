using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET_SHOP_MANAGER
{
    internal static class Program
    {
        static ApplicationContext MainContent = new ApplicationContext();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainContent.MainForm = new Login();
            Application.Run(MainContent);
        }
        public static void SetMainContent(Form MainForm)
        {
            MainContent.MainForm = MainForm;
        }
        public static void ShowMainContent()
        {
            MainContent.MainForm.Show();
        }
    }
}
