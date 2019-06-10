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
        readonly InserimentoBozza formPrecedente;
        public ListaPacchetto(String dbName, InserimentoBozza ib)
        {
            formPrecedente = ib;
            db = dbName;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InserisciPacchetto iP = new InserisciPacchetto(db);
            iP.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ListaLavorazioni ll = new ListaLavorazioni(this, db);
            ll.Show();
        }

        private void ListaPacchetto_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecedente.Show();
        }
    }
}
