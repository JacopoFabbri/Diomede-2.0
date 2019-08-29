using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class ListaCommesse : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazioniAmministrazione op;
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
                op = new OperazioniAmministrazione(db);
                if (op.CercaCommessa() != null)
                {
                    dataGridView1.DataSource = op.CercaCommessa();
                    var col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Preventivo";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Preventivo p = op.CercaPreventivo((int)r.Cells[6].Value);
                        r.Cells[18].Value = p.Commessa_Completa;

                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Cliente";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente p = op.CercaClientiId((int)r.Cells[7].Value);
                        r.Cells[19].Value = p.Nome;

                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Acconti";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Acconto p = op.CercaAcconti((int)r.Cells[14].Value);
                        r.Cells[20].Value = p.Note;

                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[14].Visible = false;
                    dataGridView1.Columns[18].ReadOnly = true;
                    dataGridView1.Columns[19].ReadOnly = true;
                    dataGridView1.Columns[20].ReadOnly = true;
                    flag = true;
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateCommessa((int)riga.Cells["ID"].Value, (int)riga.Cells["NUMERO"].Value, (int)riga.Cells["ANNO"].Value, "" + riga.Cells["SETTORE"].Value, "" + riga.Cells["COMMESSA"].Value, (int)riga.Cells["PREVENTIVO"].Value, (int)riga.Cells["CLIENTE"].Value, "" + riga.Cells["SETTOREINTERO"].Value, "" + riga.Cells["CANTIERE"].Value, "" + riga.Cells["NOTE"].Value, (bool)riga.Cells["CHIUSA"].Value, (DateTime)riga.Cells["DATACHIUSURA"].Value, (bool)riga.Cells["FATTURATA"].Value, (DateTime)riga.Cells["DATAFATTURA"].Value, (int)riga.Cells["ACCONTI"].Value, (int)riga.Cells["PAGAMENTI"].Value, (DateTime)riga.Cells["DATAINSERIMENTO"].Value, (double)riga.Cells["IMPORTO"].Value);

                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            try
            {
                flag = false;
                dataGridView1.Columns.Remove("Cliente");
                dataGridView1.Columns.Remove("Preventivo");
                dataGridView1.DataSource = op.CercaCommessa();
                var col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                col.Name = "Preventivo";
                dataGridView1.Columns.Add(col);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    Preventivo p = op.CercaPreventivo((int)r.Cells[6].Value);
                    r.Cells[18].Value = p.Commessa_Completa;

                }
                col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                col.Name = "Cliente";
                dataGridView1.Columns.Add(col);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    Cliente p = op.CercaClientiId((int)r.Cells[7].Value);
                    r.Cells[19].Value = p.Nome;

                }
                col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                col.Name = "Acconti";
                dataGridView1.Columns.Add(col);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    Acconto p = op.CercaAcconti((int)r.Cells[14].Value);
                    r.Cells[20].Value = p.Note;

                }
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[18].ReadOnly = true;
                dataGridView1.Columns[19].ReadOnly = true;
                dataGridView1.Columns[20].ReadOnly = true;
                flag = true;
            }
            catch
            {
                MessageBox.Show("errore");
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }

        private void FiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = false;
            var f = new FiltroCommessa(dataGridView1, db, flag);
            f.Show();
        }
    }
}
