using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaPacchetto : Form
    {
        private readonly string db;
        private readonly InserimentoBozza formPrecedente;
        private readonly TextBox tb;
        private OperazionePraticheEdili op;

        public ListaPacchetto(string dbName, InserimentoBozza ib, TextBox textBox2)
        {
            tb = textBox2;
            formPrecedente = ib;
            db = dbName;
            InitializeComponent();
        }

        public ListaPacchetto(string dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void ListaPacchetto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formPrecedente != null)
                formPrecedente.Show();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
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

        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdatePacchetto((int) riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "",
                                riga.Cells["NOTE"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaPacchetto();
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var iP = new InserisciPacchetto(db);
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
                        var clienti = op.CercaPacchetto((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaPacchetto((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            dataGridView1.DataSource = op.CercaPacchetto();
            dataGridView1.Columns[0].Visible = false;
        }

        private void GestioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    var ll = new ListaLavorazioni(db, (int) dataGridView1.SelectedRows[0].Cells[0].Value);
                    ll.Show();
                }
            }
            catch
            {
                MessageBox.Show("Nessuna riga selezionata \nSeleziona una riga prima di riprovare");
            }
        }

        private void SelezionaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tb == null)
            {
                Close();
            }
            else
            {
                if (dataGridView1.SelectedRows != null) tb.Text = "" + dataGridView1.SelectedRows[0].Cells[0].Value;
                Close();
            }
        }
    }
}