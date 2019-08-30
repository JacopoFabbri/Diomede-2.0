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
                        if (op.CercaCommessa((int)r.Cells[5].Value) == null)
                        {

                        }
                        else
                        {
                            Commessa c = op.CercaCommessa((int)r.Cells[5].Value);
                            r.Cells[16].Value = c.ID_Commessa;
                        }
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Cliente";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[5].Value);
                        r.Cells[17].Value = c.Nome;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[16].ReadOnly = true;
                    dataGridView1.Columns[17].ReadOnly = true;
                    flag = true;
                }

            }
            catch (Exception ex)
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
            flag = false;
            var f = new FiltroBozze(dataGridView1, db,flag);
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
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdatePreventivo((int)riga.Cells["ID"].Value,(int)riga.Cells["NUMERO"].Value,(int)riga.Cells["ANNO"].Value,"" + 
                                riga.Cells["SETTORE"].Value,(int)riga.Cells["COMMESSA"].Value, (int)riga.Cells["CLIENTE"].Value,
                                "" + riga.Cells["SETTOREINTERO"].Value,(DateTime)riga.Cells["DATAINSERIMENTO"].Value,"" + riga.Cells["CANTIERE"].Value,
                                "" + riga.Cells["NOTE"].Value,(Double)riga.Cells["IMPORTO"].Value,(bool)riga.Cells["INVIATO"].Value,(DateTime)riga.Cells["DATAINVIO"].Value,
                                (bool)riga.Cells["ACCETTAZIONE"].Value,(DateTime) riga.Cells["DATAACCETTAZIONE"].Value,"" + riga.Cells["COMMESSACOMPLETA"].Value);
                            
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            }
            flag = false;
            dataGridView1.Columns.Remove("Commessa");
            dataGridView1.Columns.Remove("Cliente");
            dataGridView1.DataSource = op.CercaPreventivo();
            var col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "Commessa";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (op.CercaCommessa((int)r.Cells[5].Value) == null)
                {

                }
                else
                {
                    Commessa c = op.CercaCommessa((int)r.Cells[5].Value);
                    r.Cells[17].Value = c.ID_Commessa;
                }
            }
            col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "Cliente";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Cliente c = op.CercaClientiId((int)r.Cells[6].Value);
                r.Cells[18].Value = c.Nome;
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[16].ReadOnly = true;
            dataGridView1.Columns[17].ReadOnly = true;
            flag = true;
        }
    }
}
