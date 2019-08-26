using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede4
{
    public partial class ListaLavorazioni : Form
    {
        private readonly string db;
        private readonly int idPacchetto;
        private OperazionePraticheEdili op;

        public ListaLavorazioni(string dbName, int id)
        {
            idPacchetto = id;
            db = dbName;
            InitializeComponent();
        }

        public void ListaLavorazioni_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (op.FiltraLavorazione("PACCHETTO", idPacchetto + "").Count > 0)
                {
                    dataGridView1.DataSource = op.FiltraLavorazione("PACCHETTO", idPacchetto + "");
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
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateLavorazione((int) riga.Cells["ID"].Value, riga.Cells["OPERAZIONE"].Value + "",
                                (int) riga.Cells["PACCHETTO"].Value, (double) riga.Cells["IMPORTO"].Value,
                                riga.Cells["DESC"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaLavorazione();
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var iL = new InserisciLavorazione(db, this, idPacchetto);
            iL.Show();
        }

        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaLavorazione((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaLavorazione((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            if (op.FiltraLavorazione("PACCHETTO", idPacchetto + "").Count > 0)
            {
                dataGridView1.DataSource = op.FiltraLavorazione("PACCHETTO", idPacchetto + "");
                dataGridView1.Columns[0].Visible = false;
            }

            dataGridView1.Columns[0].Visible = false;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
    }
}