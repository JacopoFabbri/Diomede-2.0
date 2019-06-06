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
    public partial class Form6 : Form
    {
        private String db;
        OperazionePraticheEdili op;
        public Form6(String dbNAme)
        {
            db = dbNAme;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                List<Ruolo> lista = op.cercaRuolo();
                if (lista != null)
                {
                    dataGridView1.DataSource = lista;
                    dataGridView1.Columns[0].Visible = false;

                }
                else
                {
                    Form8 frm = new Form8(db);
                    frm.Show();
                }

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
                            op.updateRuolo((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", riga.Cells["DESC"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.cercaRuolo();
            dataGridView1.Columns[0].Visible = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Stai per eliminare " + (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Ruolo clienti = op.cercaRuoloId((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.cancellaRuolo((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            dataGridView1.DataSource = op.cercaRuolo();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8(db);
            frm.Show();
        }

    }
}
