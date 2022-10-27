using System;
using System.Windows.Forms;
using Project2.Forms;

namespace Project2
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
            //Application.Run(new ManagementForm());
            Application.Run(new LoginForm());
            //Application.Run(new CheckoutForm());
        }
    }
}
