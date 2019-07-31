using CarpenterieMetallicheDiomede;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaCommesse : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazionePraticheEdili op;

        public ListaCommesse(string dbName, Dashboard frm)
        {
            formPrecente = frm;
            db = dbName;
            InitializeComponent();
        }
        private void ListaCommesse_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                dataGridView1.DataSource = op.CercaCommessa();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[8].Visible = false;
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
            }

            formPrecente.Hide();
            dataGridView1.Focus();
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateCommessa((int)riga.Cells["ID"].Value, (int)riga.Cells["DITTA"].Value,
                                riga.Cells["NUMEROCOMMESSA"].Value + "", (DateTime)riga.Cells["DATA"].Value,
                                riga.Cells["REFERENTE"].Value + "", "" + riga.Cells["INDIRIZZOCANTIERE"].Value,
                                "" + riga.Cells["TECNICOINTERNO"].Value, "" + riga.Cells["NOTE"].Value, (int)riga.Cells["BOZZA"].Value, (DateTime)riga.Cells["DATAESECUZIONE"].Value, (DateTime)riga.Cells["DATARICHIESTACONSEGNA"].Value, (String)riga.Cells["INVIO"].Value, (DateTime)riga.Cells["DATAORAINVIO"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            dataGridView1.Columns[0].Visible = false;
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                formPrecente.Show();
                formPrecente.Dashboard_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                for (var i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    if (MessageBox.Show(
                            "Stai per eliminare " +
                            (string)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[2].Value +
                            " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        try
                        {
                            var clienti = op.CercaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index]
                                .Cells[0].Value);
                            op.CancellaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0]
                                .Value);
                            MessageBox.Show("Commessa Eliminata", "Conferma", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            dataGridView1.Columns[0].Visible = false;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            var frm = new InserimentoPagamento(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
            frm.Show();
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateCommessa((int)riga.Cells["Id"].Value, (int)riga.Cells["Ditta"].Value,
                                riga.Cells["NumeroCommessa"].Value + "", (DateTime)riga.Cells["Data"].Value,
                                riga.Cells["Referente"].Value + "", "" + riga.Cells["IndirizzoCantiere"].Value,
                                "" + riga.Cells["TecnicoInterno"].Value, "" + riga.Cells["Note"].Value,
                                (int)riga.Cells["Bozza"].Value, (DateTime)riga.Cells["DataEsecuzione"].Value,
                                (DateTime)riga.Cells["DataRichestaConsegna"].Value, "" + riga.Cells["Invio"].Value,
                                (DateTime)riga.Cells["DataOraInvio"].Value);

                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            dataGridView1.Columns[0].Visible = false;
        }
        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                for (var i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    if (MessageBox.Show(
                            "Stai per eliminare " +
                            (string)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[2].Value +
                            " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        try
                        {
                            var clienti = op.CercaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index]
                                .Cells[0].Value);
                            op.CancellaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0]
                                .Value);
                            MessageBox.Show("Commessa Eliminata", "Conferma", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            dataGridView1.Columns[0].Visible = false;
        }
        private void PagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new InserimentoPagamento(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
            frm.Show();
        }
        private void SelezionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var r = new Recap(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                r.Show();
            }
            catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    v.Show();
                }
        }

        private void InserimentoCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoCommessa i = new InserimentoCommessa("CarpenteriaMetallica");
            i.Show();
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}