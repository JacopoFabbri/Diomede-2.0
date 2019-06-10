using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserisciPacchetto : Form
    {
        readonly String db;
        OperazionePraticheEdili op;
        public InserisciPacchetto(String dBName)
        {
            db = dBName;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);

        }
    }
}
