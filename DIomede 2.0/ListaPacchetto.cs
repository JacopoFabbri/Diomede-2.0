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
    public partial class ListaPacchetto : Form
    {
        readonly String db;
        public ListaPacchetto(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InserisciPacchetto iP = new InserisciPacchetto(db);
            iP.Show();
        }
    }
}
