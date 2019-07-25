using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaMacroLavorazioni : Form
    {
        private readonly string db;
        private readonly int idMacroLavorazione;
        private OperazionePraticheEdili op;

        public ListaMacroLavorazioni(string dbName, int id)
        {
            idMacroLavorazione = id;
            db = dbName;
            InitializeComponent();
        }

        public ListaMacroLavorazioni(string dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }

        public void ListaMacroLavorazioni_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (idMacroLavorazione > 0)
                {
                    dataGridView1.DataSource = op.FiltraMacroLavorazione("COMMESSA", idMacroLavorazione + "");
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = op.CercaMacroLavorazione();
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
                            op.UpdateMacroLavorazione((int) riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "",
                                (DateTime) riga.Cells["DATAINIZIO"].Value, (DateTime) riga.Cells["DATAFINE"].Value,
                                (double) riga.Cells["PREZZO"].Value, riga.Cells["NUMEROCOMMESSA"].Value + "",
                                (int) riga.Cells["TIPOLOGIA"].Value, riga.Cells["DESC"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.FiltraMacroLavorazione("COMMESSA", idMacroLavorazione + "");
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var iP = new InserimentoMacroLavorazione(db, idMacroLavorazione);
            iP.Show();
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
                        var clienti =
                            op.CercaMacroLavorazione((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                                .Cells[0].Value);
                        op.CancellaMacroLavorazione((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            dataGridView1.DataSource = op.FiltraMacroLavorazione("COMMESSA", idMacroLavorazione + "");
            dataGridView1.Columns[0].Visible = false;
        }

        private void SelezionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var ll = new ListaLavorazione(db, (int) dataGridView1.SelectedRows[0].Cells[0].Value);
                ll.Show();
            }
            catch
            {
                MessageBox.Show("Controlla il valore del prezzo e riprova");
            }
        }
    }
}