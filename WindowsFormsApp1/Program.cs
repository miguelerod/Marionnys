using System;
using System.Threading;
using System.Windows.Forms;

namespace Trabajo_Diseno_Sistemas
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
            Thread main = new Thread(() =>
            {
                Application.Run(new Universidad());
            });
            
            Thread turnsScreen = new Thread(() =>
            {
                Application.Run(new Turnos());
            });

            main.Start();
            turnsScreen.Start();
        }
    }
}
