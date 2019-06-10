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
    public partial class InserisciLavorazione : Form
    {
        readonly ListaLavorazioni formPrecedente;
        readonly String db;
        int id;
        public InserisciLavorazione(String dbName, ListaLavorazioni ll, int idPacchetto)
        {
            id = idPacchetto;
            db = dbName;
            formPrecedente = ll;
            InitializeComponent();
        }

        private void InserisciLavorazione_Load(object sender, EventArgs e)
        {
            textBox2.Text = "" + id;
        }
    }
}
