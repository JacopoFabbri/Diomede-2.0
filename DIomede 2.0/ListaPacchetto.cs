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
        readonly TextBox tb;
        public ListaPacchetto(String dbName, InserimentoBozza ib, TextBox textBox2)
        {
            tb = textBox2;
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
            if (dataGridView1.SelectedRows != null)
            {
                ListaLavorazioni ll = new ListaLavorazioni(this, db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                ll.Show();
            }
        }

        private void ListaPacchetto_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecedente.Show();
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                if (riga.Cells[0].Value != null)
                {
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                    {
                        try
                        {
                            op.UpdateBozza((int)riga.Cells["ID"].Value, (DateTime)riga.Cells["DATA"].Value, riga.Cells["PACCHETTO"].Value + "", (double)riga.Cells["IMPORTO"].Value, riga.Cells["NUMEROCOMMESSA"].Value + "", (int)riga.Cells["CLIENTE"].Value, (Boolean)riga.Cells["ACCETTAZIONE"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaBozza();
            dataGridView1.Columns[0].Visible = false;
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
            if (dataGridView1.SelectedRows != null)
            {
                tb.Text = "" + dataGridView1.SelectedRows[0].Cells[0].Value;
            }
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                if (riga.Cells[0].Value != null)
                {
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                    {
                        try
                        {
                            op.UpdatePacchetto((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["NOTE"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaPacchetto();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
