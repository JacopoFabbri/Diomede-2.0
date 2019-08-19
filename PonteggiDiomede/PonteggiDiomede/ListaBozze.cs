using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaBozze : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazionePraticheEdili op;
        private Boolean flag = false;
        public ListaBozze(string dbName, Dashboard frm)
        {
            formPrecente = frm;
            db = dbName;
            InitializeComponent();
        }
        private void ListaBozze_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                var lista = op.CercaBozza();
                if (op.CercaBozza() != null)
                {
                    dataGridView1.DataSource = lista;
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "CLIENTE";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[5].Value);
                        r.Cells[7].Value = c.Nome;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[7].ReadOnly = true;
                    flag = true;
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

            formPrecente.Hide();
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
        private void ListaBozze_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecente.Show();
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateBozza((int)riga.Cells["ID"].Value, (DateTime)riga.Cells["DATA"].Value, (double)riga.Cells["IMPORTO"].Value, (String)riga.Cells["FASEPROGETTO"].Value,
                                riga.Cells["IDENTIFICATIVOPREVENTIVO"].Value + "", (int)riga.Cells["CLIENTE"].Value, (bool)riga.Cells["ACCETTAZIONE"].Value);
                            if ((bool)riga.Cells["ACCETTAZIONE"].Value)
                            {
                                if (op.FiltraCommessa("BOZZA", "" + (int)riga.Cells["ID"].Value).Count == 0)
                                {

                                    var op1 = new OperazioneAmministrazione("Amministrazione");
                                    var c = op.CercaClientiId((int)riga.Cells["CLIENTE"].Value);
                                    var listaAmministrazione = op1.FiltraCliente("NOME", c.Nome);
                                    List<ClienteAmministrazione> listaCliente = null;
                                    string commessa;
                                    if (listaAmministrazione.Count > 0)
                                    {
                                        op1.InserimentoCliente(c.Nome, c.Tel, c.Email, c.Iva, c.Sdi);
                                        listaCliente = op1.CercaCliente();
                                        commessa = op1.GeneraCommessa("PO", listaCliente[listaCliente.Count - 1],
                                            "Ponteggi", false);
                                    }
                                    else
                                    {
                                        commessa = op1.GeneraCommessa("PO", listaAmministrazione[1], "Ponteggi",
                                            false);
                                    }

                                    op.InserimentoCommessa((int)riga.Cells["CLIENTE"].Value, commessa,
                                        (DateTime)riga.Cells["DATA"].Value, "", "", "", "", (int)riga.Cells["ID"].Value, "NULL", "NULL", "", "NULL", "");
                                }
                            }
                            else
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore:",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            }
            flag = false;
            dataGridView1.DataSource = op.CercaBozza();
            dataGridView1.Columns.Remove("CLIENTE");
            DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "CLIENTE";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Cliente c = op.CercaClientiId((int)r.Cells[5].Value);
                r.Cells[7].Value = c.Nome;
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].ReadOnly = true;
            flag = true;
        }
        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new InserimentoBozza(db, this);
            ib.Show();
        }
        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaBozzaId((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaBozza((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Bozza Eliminata", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            dataGridView1.DataSource = op.CercaBozza();
            dataGridView1.Columns[0].Visible = false;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
                    cella.Style.ForeColor = Color.Red;
                if ((bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == true)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
            }
        }
        private void FiltraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FiltroBozze(dataGridView1, db);
            f.Show();
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int)dataGridView1.Rows[e.RowIndex].Cells[5].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[5]);
                    v.Show();
                }
            }
        }
    }
}