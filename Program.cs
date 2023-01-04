using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20UMLQuestion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // run Form1 in full screen mode
            loginPage form1 = new loginPage();
            form1.WindowState = FormWindowState.Maximized;
            Application.Run(form1);

            //Application.Run(new Form1());
            
        }
    }
}
