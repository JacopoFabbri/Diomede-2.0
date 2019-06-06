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
    public partial class Form4 : Form
    {
        String db;
        OperazionePraticheEdili op;
        public Form4(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                dataGridView1.DataSource = op.cercaClienti();
                dataGridView1.Columns[0].Visible = false;

            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
                {
                    cella.Style.BackColor = Color.Bisque;
                }
            }
        }
        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (e.Row.Index >= 0 && dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[e.Row.Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Cliente clienti = op.cercaClientiId((int)dataGridView1.Rows[e.Row.Index].Cells[1].Value);
                        op.cancellaCliente((int)dataGridView1.Rows[e.Row.Index].Cells[0].Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                            op.updateCliente((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["INDIRIZZO"].Value + "", riga.Cells["CAP"].Value + "", riga.Cells["CITTA"].Value + "", riga.Cells["PEC"].Value + "", riga.Cells["EMAIL"].Value + "", riga.Cells["Iva"].Value + "", riga.Cells["Tel"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.cercaClienti();
            dataGridView1.Columns[0].Visible = false;

        }
    }
}
