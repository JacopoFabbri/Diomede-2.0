using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaBozze : Form
    {
        readonly String db;
        OperazionePraticheEdili op;
        readonly Dashboard formPrecente;
        public ListaBozze(String dbName, Dashboard frm)
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
                if (op.CercaBozza() != null)
                {
                    dataGridView1.DataSource = op.CercaBozza();
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = op.CercaBozza();

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
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                if (riga.Cells[0].Value != null)
                {
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                    {
                        try
                        {
                            op.UpdateBozza((int)riga.Cells["ID"].Value, (DateTime)riga.Cells["DATA"].Value, riga.Cells["PACCHETTO"].Value + "", riga.Cells["IMPORTO"].Value + "", riga.Cells["NUMEROCOMMESSA"].Value + "", (int)riga.Cells["CLIENTE"].Value, (Boolean)riga.Cells["ACCETTAZIONE"].Value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaBozza();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InserimentoBozza ib = new InserimentoBozza(db, this);
            ib.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void ListaBozze_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecente.Show();
        }
    }
}
