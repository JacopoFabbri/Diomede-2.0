using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Ruoli : Form
    {
        private readonly string db;
        private readonly InserimentoContatto c;
        private OperazionePraticheEdili op;

        public Ruoli(string dbNAme, InserimentoContatto c)
        {
            this.c = c;
            db = dbNAme;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                var lista = op.CercaRuolo();
                if (lista != null)
                {
                    dataGridView1.DataSource = lista;
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    var frm = new InserimentoRuolo(db, c);
                    frm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!","Attenzione:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }

        }

        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateRuolo((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "",
                                riga.Cells["DESC"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaRuolo();
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new InserimentoRuolo(db, c);
            frm.Show();
        }

        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaRuoloId((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaRuolo((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Ruolo Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            dataGridView1.DataSource = op.CercaRuolo();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}