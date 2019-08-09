using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaCommesse : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazionePraticheEdili op;
        private Boolean flag = false;

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
                DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                col.Name = "NUMEROPREVENTIVO";
                dataGridView1.Columns.Add(col);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    Bozza c = op.CercaBozzaId((int)r.Cells[5].Value);
                    r.Cells[9].Value = c.IdentificativoPreventivo;
                }
                col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                col.Name = "CLIENTE";
                dataGridView1.Columns.Add(col);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    Cliente c = op.CercaClientiId((int)r.Cells[1].Value);
                    r.Cells[10].Value = c.Nome;
                }
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[9].ReadOnly = true;
                dataGridView1.Columns[10].ReadOnly = true;
                flag = true;
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            formPrecente.Hide();
            dataGridView1.Focus();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
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
                                "" + riga.Cells["TECNICOINTERNO"].Value, "" + riga.Cells["NOTE"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            flag = false;
            dataGridView1.Columns.Remove("NUMEROPREVENTIVO");
            dataGridView1.Columns.Remove("CLIENTE");
            DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "NUMEROPREVENTIVO";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Bozza c = op.CercaBozzaId((int)r.Cells[5].Value);
                r.Cells[9].Value = c.IdentificativoPreventivo;
            }
            col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "CLIENTE";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Cliente c = op.CercaClientiId((int)r.Cells[1].Value);
                r.Cells[10].Value = c.Nome;
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[9].ReadOnly = true;
            dataGridView1.Columns[10].ReadOnly = true;
            flag = true;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                formPrecente.Show();
                formPrecente.Form2_Load(sender, e);
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
                            op.UpdateCommessa((int)riga.Cells["ID"].Value, (int)riga.Cells["DITTA"].Value,
                                riga.Cells["NUMEROCOMMESSA"].Value + "", (DateTime)riga.Cells["DATA"].Value,
                                riga.Cells["REFERENTE"].Value + "", "" + riga.Cells["INDIRIZZOCANTIERE"].Value,
                                "" + riga.Cells["TECNICOINTERNO"].Value, "" + riga.Cells["NOTE"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            flag = false;
            dataGridView1.Columns.Remove("NUMEROPREVENTIVO");
            dataGridView1.Columns.Remove("CLIENTE");
            DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "NUMEROPREVENTIVO";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Bozza c = op.CercaBozzaId((int)r.Cells[5].Value);
                r.Cells[9].Value = c.IdentificativoPreventivo;
            }
            col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "CLIENTE";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Cliente c = op.CercaClientiId((int)r.Cells[1].Value);
                r.Cells[10].Value = c.Nome;
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[9].ReadOnly = true;
            dataGridView1.Columns[10].ReadOnly = true;
            flag = true;
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

        private void MacroLavorazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lm = new ListaMacroLavorazioni(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
            lm.Show();
        }

        private void SelezionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = new Recap(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
            r.Show();
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*if (e.ColumnIndex == 1)
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    v.Show();
                }*/
        }
    }
}