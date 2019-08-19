using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (Convert.ToInt32(args[0]) == 1)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Dashboard("CarpenteriaMetallica"));
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
