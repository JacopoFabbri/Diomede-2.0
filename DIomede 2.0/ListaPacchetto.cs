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
        OperazionePraticheEdili op;
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

        private void ListaPacchetto_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (op.CercaPacchetto() != null)
                {
                    dataGridView1.DataSource = op.CercaPacchetto();
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = op.CercaPacchetto();

                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            formPrecedente.
        }
    }
}
