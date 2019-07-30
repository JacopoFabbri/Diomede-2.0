using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Recap : Form
    {
        String db;
        int idCommessa;
        OperazionePraticheEdili op;
        Commessa commessa;
        List<Cliente> listaCLienti;
        List<Acconti> listaAcconti;
        public Recap(String dbName, int id)
        {
            db = dbName;
            idCommessa = id;
            InitializeComponent();
        }
        private void Recap_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                commessa = op.CercaCommessa(idCommessa);
                textBox1.Text = "" + commessa.NumeroCommessa;
                listaCLienti = op.CercaClienti();
                foreach (Cliente c in listaCLienti)
                {
                    comboBox1.Items.Add(c.Nome);
                    if (commessa.Ditta == c.Id)
                    {
                        comboBox1.SelectedItem = comboBox1.Items[comboBox1.Items.Count - 1];
                    }
                }
                if (commessa.Bozza != 0)
                {
                    textBox5.Text = "" + op.CercaBozzaId(commessa.Bozza).Importo;
                }
                else
                {
                    textBox5.Visible = false;
                }
                List<Lavorazioni> listaLavorazione = op.FiltraLavorazioni("COMMESSA", "" + idCommessa);
                dataGridView1.DataSource = listaLavorazione;
                textBox6.Text = commessa.Note;
                listaAcconti = op.FiltraAcconti("COMMESSA", "" + idCommessa);
                dataGridView2.DataSource = listaAcconti;
                dataGridView1.Columns[0].Visible = false;
                textBox5.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("ciao");
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
            try
            {
                foreach (DataGridViewRow riga in dataGridView1.Rows)
                    if (riga.Cells[0].Value != null)
                        if (riga.Cells[0].Style.ForeColor == Color.Red)

                            op.UpdateLavorazioni((int)riga.Cells["ID"].Value, "" + riga.Cells["NOME"].Value, riga.Cells["DESC"].Value + "",
                                (double)riga.Cells["PREZZO"].Value, (int)riga.Cells["COMMESSA"].Value,
                                (DateTime)riga.Cells["DATA"].Value, riga.Cells["ASSEGNAMENTO"].Value + "");

                dataGridView1.DataSource = op.FiltraLavorazioni("COMMESSA", "" + idCommessa);
                dataGridView1.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                op.UpdateCommessa(commessa.Id, textBox6.Text, listaCLienti[comboBox1.SelectedIndex].Id);
                op.UpdateBozza(commessa.Bozza, Convert.ToDouble(textBox5.Text));

            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            InserimentoPagamento p = new InserimentoPagamento(db, commessa.Id);
            p.Show();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow riga in dataGridView2.Rows)
                    if (riga.Cells[0].Value != null)
                        if (riga.Cells[0].Style.ForeColor == Color.Red)

                            op.UpdateAcconti((int)riga.Cells["ID"].Value, "" + riga.Cells["NOME"].Value, (double)riga.Cells["IMPORTO"].Value, riga.Cells["NOTE"].Value + "",
                                riga.Cells["DESC"].Value + "", (DateTime)riga.Cells["DATAINSERIMENTO"].Value,
                                (DateTime)riga.Cells["DATAFATTURA"].Value, riga.Cells["NOTEFATTURA"].Value + "",
                                (int)riga.Cells["COMMESSA"].Value);

                dataGridView1.DataSource = op.FiltraAcconti("COMMESSA", "" + idCommessa);
                dataGridView1.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {

        }
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows != null)
                    if (MessageBox.Show("Stai per eliminare " + (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var clienti = op.CercaAcconti((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaAcconti((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
            }
            catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = op.FiltraAcconti("COMMESSA", "" + idCommessa);
            dataGridView1.Columns[0].Visible = false;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                    if (MessageBox.Show("Stai per eliminare " + (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var clienti = op.CercaLavorazioni((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        op.CancellaLavorazioni((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
            }
            catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = op.FiltraLavorazioni("COMMESSA", "" + idCommessa);
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
