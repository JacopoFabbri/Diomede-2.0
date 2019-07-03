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
    public partial class ListaLavorazione : Form
    {
        readonly String db;
        readonly int idMacroLavorazione;
        OperazionePraticheEdili op;
        public ListaLavorazione(String dbName, int id)
        {
            idMacroLavorazione = id;
            db = dbName;
            InitializeComponent();
        }
        public void ListaLavorazione_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (op.FiltraLavorazioni("MACROLAVORAZIONE", idMacroLavorazione + "").Count > 0)
                {
                    dataGridView1.DataSource = op.FiltraLavorazioni("MACROLAVORAZIONE", idMacroLavorazione + "");
                    dataGridView1.Columns[0].Visible = false;
                }

            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
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
                            op.UpdateLavorazioni((int)riga.Cells["ID"].Value, riga.Cells["NOMME"].Value + "", "" + riga.Cells["DESC"].Value, "" + riga.Cells["SCADENZE"].Value, (int)riga.Cells["MACROLAVORAZIONE"].Value, (double)riga.Cells["PREZZO"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaLavorazioni();
            dataGridView1.Columns[0].Visible = false;
        }
        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoLavorazioni iL = new InserimentoLavorazioni(db, this, idMacroLavorazione);
            iL.Show();
        }
        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Lavorazione clienti = op.CercaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            dataGridView1.DataSource = op.CercaLavorazioni();
            dataGridView1.Columns[0].Visible = false;
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }


    }
}
