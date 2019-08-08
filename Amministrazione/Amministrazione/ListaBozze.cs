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
           
        }
        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new InserimentoBozza(db, this);
            ib.Show();
        }
        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
                    cella.Style.ForeColor = Color.Red;
                if((bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == true)
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