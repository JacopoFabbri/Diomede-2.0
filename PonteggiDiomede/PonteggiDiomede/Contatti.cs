using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Contatti : Form
    {
        private readonly Cliente cliente;
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazionePraticheEdili op;
        public Contatti(Cliente c, string dbName, Dashboard frm)
        {
            formPrecente = frm;
            cliente = c;
            db = dbName;
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (cliente == null)
                {
                    var lista = op.CercaContatti();
                    if (lista != null)
                    {
                        dataGridView1.DataSource = lista;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[8].ReadOnly = true;
                        dataGridView1.Columns[11].ReadOnly = true;
                    }
                }
                else
                {
                    var lista = op.FiltraContratto("DITTA", "" + cliente.Id);
                    if (lista != null)
                    {
                        dataGridView1.DataSource = lista;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[8].ReadOnly = true;
                        dataGridView1.Columns[11].ReadOnly = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!","Attenzione:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }

            formPrecente.Hide();
            dataGridView1.Focus();
        }
        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrecente.Show();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                if (e.RowIndex != -1)
                {
                    var v = new visualizzatore(db, (int) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    v.Show();
                }
            }
            else if (e.ColumnIndex == 8)
            {
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    v.Show();
                }
            }
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateContatto((int) riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "",
                                riga.Cells["INDIRIZZO"].Value + "", riga.Cells["CAP"].Value + "",
                                riga.Cells["CITTA"].Value + "", riga.Cells["PEC"].Value + "",
                                riga.Cells["EMAIL"].Value + "", riga.Cells["Iva"].Value + "",
                                (int) riga.Cells["DITTA"].Value, riga.Cells["CELLULARE"].Value + "",
                                riga.Cells["TEL"].Value + "", riga.Cells["RUOLO"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore:",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.FiltraContratto("DITTA", "" + cliente.Id);
            dataGridView1.Columns[0].Visible = false;
        }
        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new InserimentoContatto(cliente, db);
            frm.Show();
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
                        var clienti = op.CercaContattoId((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CacellaContatto((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma:", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            Form7_Load(sender, e);
        }
    }
}