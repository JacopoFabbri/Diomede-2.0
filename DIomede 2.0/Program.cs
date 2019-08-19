using System;
using System.Windows.Forms;

namespace Diomede2
{
    internal static class Program
    {
        /// <summary>
        ///     Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                if (Convert.ToInt32(args[0]) == 1)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Dashboard("PraticheEdili"));
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("NON SI FA !!!!");
            }
        }
    }
}