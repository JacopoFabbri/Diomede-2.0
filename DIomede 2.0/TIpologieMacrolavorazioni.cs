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
    public partial class TipologieMacrolavorazioni : Form
    {
        readonly String db;
        OperazionePraticheEdili op;
        public TipologieMacrolavorazioni(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InserimentoTipologiaMacrolavorazione iL = new InserimentoTipologiaMacrolavorazione(db);
            iL.Show();
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
                            op.UpdateTipologiaMacroLavorazione((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["DESC"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaTipologiaMacroLavorazione();
            dataGridView1.Columns[0].Visible = false;
        }
        private void TIpologieMacrolavorazioni_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                dataGridView1.DataSource = op.CercaTipologiaMacroLavorazione();
                dataGridView1.Columns[0].Visible = false;

            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        TipologiaMacroLavorazione clienti = op.CercaTipologiaMacroLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaTipologiaMacroLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Tipologia Eliminata", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                dataGridView1.DataSource = op.CercaTipologiaMacroLavorazione();
                dataGridView1.Columns[0].Visible = false;
            }catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }
    }
}
