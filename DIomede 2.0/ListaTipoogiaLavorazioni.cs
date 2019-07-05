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
    public partial class ListaTipoogiaLavorazioni : Form
    {
        readonly String db;
        OperazionePraticheEdili op;
        public ListaTipoogiaLavorazioni(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InserisciTipologiaLavorazione iL = new InserisciTipologiaLavorazione(db);
            iL.Show();
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
                            op.UpdateTipologiaLavorazione((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["DESCRIZIONE"].Value + "", (double)riga.Cells["PREZZO"].Value, riga.Cells["SCADENZE"].Value + "", (int)riga.Cells["MACROLAVORAZIONE"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaTipologiaLavorazione();
            dataGridView1.Columns[0].Visible = false;
        }
        private void TIpologialavorazioni_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                dataGridView1.DataSource = op.CercaTipologiaLavorazione();
                dataGridView1.Columns[0].Visible = false;

            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        TipologiaLavorazione clienti = op.CercaTipologiaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaTipologiaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Tipologia Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                dataGridView1.DataSource = op.CercaTipologiaLavorazione();
                dataGridView1.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex != -1)
                {
                    VisualizzatoreMacrolavorazioni frm = new VisualizzatoreMacrolavorazioni(db, dataGridView1, e.RowIndex);
                    frm.Show();
                }
            }
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
                            op.UpdateTipologiaLavorazione((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["DESCRIZIONE"].Value + "", (double)riga.Cells["PREZZO"].Value, riga.Cells["SCADENZE"].Value + "", (int)riga.Cells["MACROLAVORAZIONE"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaTipologiaLavorazione();
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserisciTipologiaLavorazione iL = new InserisciTipologiaLavorazione(db);
            iL.Show();
        }

        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        TipologiaLavorazione clienti = op.CercaTipologiaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaTipologiaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Tipologia Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                dataGridView1.DataSource = op.CercaTipologiaLavorazione();
                dataGridView1.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
