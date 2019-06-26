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
    public partial class ListaMacroLavorazioni : Form
    {
        readonly String db;
        readonly int idMacroLavorazione;
        OperazionePraticheEdili op;
        public ListaMacroLavorazioni(String dbName, int id)
        {
            idMacroLavorazione = id;
            db = dbName;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

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
                            op.UpdateMacroLavorazione((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", (DateTime)riga.Cells["DATAINIZIO"].Value, (DateTime)riga.Cells["DATAFINE"].Value, (double)riga.Cells["PREZZO"].Value , riga.Cells["NUMEROCOMMESSA"].Value + "", (int)riga.Cells["TIPOLOGIA"].Value, riga.Cells["DESC"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaLavorazione();
            dataGridView1.Columns[0].Visible = false;
        }
        public void ListaLavorazioni_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (op.FiltraMacroLavorazione("COMMESSA",idMacroLavorazione + "").Count > 0)
                    dataGridView1.DataSource = op.FiltraMacroLavorazione("COMMESSA", idMacroLavorazione + "");
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
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Lavorazione clienti = op.CercaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            dataGridView1.DataSource = op.CercaLavorazione();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
