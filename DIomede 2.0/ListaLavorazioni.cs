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
    public partial class ListaLavorazioni : Form
    {
        readonly ListaPacchetto formPrecedente;
        readonly String db;
        readonly int idPacchetto;
        public ListaLavorazioni(ListaPacchetto lp, String dbName, int id)
        {
            idPacchetto = id;
            formPrecedente = lp;
            db = dbName;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InserisciLavorazione iL = new InserisciLavorazione(db, this);
            iL.Show();
        }
    }
}
