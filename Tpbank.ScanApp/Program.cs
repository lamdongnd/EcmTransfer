using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tpbank.ScanApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Splash());
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
