using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class ListaBozze : Form
    {

        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazioniAmministrazione op;
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

                op = new OperazioniAmministrazione(db);
                if (op.CercaPreventivo() != null)
                {
                    dataGridView1.DataSource = op.CercaPreventivo();
                    var col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Commessa";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Commessa c = op.CercaCommessa((int)r.Cells[4].Value);
                        r.Cells[17].Value = c.commessa;
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Preventivo";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Preventivo c = op.CercaPreventivo((int)r.Cells[5].Value);
                        r.Cells[18].Value = c.commessaCompleta;
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Cliente";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[6].Value);
                        r.Cells[19].Value = c.Nome;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[17].ReadOnly = true;
                    dataGridView1.Columns[18].ReadOnly = true;
                    dataGridView1.Columns[19].ReadOnly = true;
                    flag = true;
                }

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
            if (flag)
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
        private void ListaBozze_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecente.Show();
        }
        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == 6)
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
            }*/
        }
        private void FiltraToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        }
    }
}