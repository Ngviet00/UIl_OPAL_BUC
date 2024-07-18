using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIL_OPAL
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, "{b74f4e7a-7326-4b84-8d33-2f2d56bdf1f302052000}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("The program is running!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
