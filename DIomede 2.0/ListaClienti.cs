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
    public partial class ListaClienti : Form
    {
        readonly String db;
        OperazionePraticheEdili op;
        readonly Dashboard formPrecente;
        public ListaClienti(String dbName, Dashboard frm)
        {
            formPrecente = frm;
            db = dbName;
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                dataGridView1.DataSource = op.CercaClienti();
                dataGridView1.Columns[0].Visible = false;

            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
            formPrecente.Hide();
            dataGridView1.Focus();
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
                            op.UpdateCliente((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["INDIRIZZO"].Value + "", riga.Cells["CAP"].Value + "", riga.Cells["CITTA"].Value + "", riga.Cells["PEC"].Value + "", riga.Cells["EMAIL"].Value + "", riga.Cells["Iva"].Value + "", riga.Cells["Tel"].Value + "", riga.Cells["SDI"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaClienti();
            dataGridView1.Columns[0].Visible = false;

        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                formPrecente.Show();
                formPrecente.Form2_Load(sender, e);
            }
            catch
            {

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            InserimentoCliente frm = new InserimentoCliente(db);
            frm.Show();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Cliente clienti = op.CercaClientiId((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaCliente((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            dataGridView1.DataSource = op.CercaClienti();
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                if (riga.Cells[0].Value != null)
                {
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                    {
                        try
                        {
                            op.UpdateCliente((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["INDIRIZZO"].Value + "", riga.Cells["CAP"].Value + "", riga.Cells["CITTA"].Value + "", riga.Cells["PEC"].Value + "", riga.Cells["EMAIL"].Value + "", riga.Cells["Iva"].Value + "", riga.Cells["Tel"].Value + "", riga.Cells["SDI"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaClienti();
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoCliente frm = new InserimentoCliente(db);
            frm.Show();
        }

        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Cliente clienti = op.CercaClientiId((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaCliente((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            dataGridView1.DataSource = op.CercaClienti();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
