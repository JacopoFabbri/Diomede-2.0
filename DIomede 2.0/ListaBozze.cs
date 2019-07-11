using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaBozze : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        //private List<Bozza> lista;
        private OperazionePraticheEdili op;
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
                /*
                this.Controls.Add(dataGridView1);

                dataGridView1.ColumnCount = 7;

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                    new Font(dataGridView1.Font, FontStyle.Bold);

                dataGridView1.Location = new Point(8, 8);
                dataGridView1.Size = new Size(500, 250);
                dataGridView1.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridView1.ColumnHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.Single;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dataGridView1.GridColor = Color.Black;
                dataGridView1.RowHeadersVisible = false;

                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "DATA";
                dataGridView1.Columns[2].Name = "PACCHETTO";
                dataGridView1.Columns[3].Name = "IMPORTO";
                dataGridView1.Columns[4].Name = "NUMEROCOMMESSA";
                dataGridView1.Columns[5].Name = "CLIENTE";
                dataGridView1.Columns[6].Name = "ACCETTAZIONE";

                dataGridView1.Columns[4].DefaultCellStyle.Font =
                    new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Italic);

                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.Dock = DockStyle.Fill;
                
                if (op.CercaBozza() != null)
                {
                    lista = op.CercaBozza();
                    int riga = 1;

                    foreach (Bozza b in lista)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[riga].Cells[0].Value = b.Id;
                        dataGridView1.Rows[riga].Cells[1].Value = b.Data;
                        dataGridView1.Rows[riga].Cells[2].Value = op.FiltraPacchetto("ID", "" + b.Pacchetto)[0].Nome;
                        dataGridView1.Rows[riga].Cells[3].Value = b.Importo;
                        dataGridView1.Rows[riga].Cells[4].Value = b.IdentificativoPreventivo;
                        dataGridView1.Rows[riga].Cells[5].Value = op.FiltraClienti("ID", "" + b.Cliente)[0].Nome;
                        dataGridView1.Rows[riga].Cells[6].Value = b.Accettazione;

                    }
                }
                */
                op.CercaBozza();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].ReadOnly = true;

            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }

            formPrecente.Hide();
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
        private void ListaBozze_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecente.Show();
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateBozza((int)riga.Cells["ID"].Value, (DateTime)riga.Cells["DATA"].Value,
                                riga.Cells["PACCHETTO"].Value + "", (double)riga.Cells["IMPORTO"].Value,
                                riga.Cells["IDENTIFICATIVOPREVENTIVO"].Value + "", (int)riga.Cells["CLIENTE"].Value,
                                (bool)riga.Cells["ACCETTAZIONE"].Value);
                            if ((bool)riga.Cells["ACCETTAZIONE"].Value)
                            {
                                var op1 = new OperazioneAmministrazione("Amministrazione");
                                var c = op.CercaClientiId((int)riga.Cells["CLIENTE"].Value);
                                var listaAmministrazione = op1.FiltraCliente("NOME", c.Nome);
                                List<ClienteAmministrazione> listaCliente = null;
                                string commessa;
                                if (listaAmministrazione.Count <= 0)
                                {
                                    op1.InserimentoCliente(c.Nome, c.Tel, c.Email, c.Iva, c.Sdi);
                                    listaCliente = op1.CercaCliente();
                                    commessa = op1.GeneraCommessa("PE", listaCliente[listaCliente.Count - 1],
                                        "PraticheEdili", false);
                                }
                                else
                                {
                                    commessa = op1.GeneraCommessa("PE", listaAmministrazione[1], "PraticheEdili",
                                        false);
                                }

                                op.InserimentoCommessa((int)riga.Cells["CLIENTE"].Value, commessa,
                                    (DateTime)riga.Cells["DATA"].Value, "", (int)riga.Cells["ID"].Value, "", "", "");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaBozza();
            dataGridView1.Columns[0].Visible = false;
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
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
            }
        }
        private void FiltraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FiltroBozze(dataGridView1, db);
            f.Show();
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    v.Show();
                }
            }
            else if (e.ColumnIndex == 2)
            {
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatorePacchetto(db, (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[2]);
                    v.Show();
                }
            }
        }
    }
}