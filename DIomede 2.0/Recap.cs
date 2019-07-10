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
        List<MacroLavorazione> listaMacrolavorazione;
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
                textBox2.Text = op.CercaClientiId(commessa.Ditta).Nome;
                listaMacrolavorazione = op.FiltraMacroLavorazione("COMMESSA", "" + commessa.Id);
                String s = "";
                foreach (MacroLavorazione m in listaMacrolavorazione)
                {
                    s += m.Nome + "\n";
                    comboBox1.Items.Add(m.Nome);
                }
                textBox3.Text = s;
                textBox4.Text = op.CercaBozzaId(commessa.Bozza).IdentificativoPreventivo;
                textBox5.Text = "" + op.CercaBozzaId(commessa.Bozza).Importo;
                List<Lavorazioni> listaLavorazione = new List<Lavorazioni>();
                foreach (MacroLavorazione m in listaMacrolavorazione)
                {
                    List<Lavorazioni> list = op.FiltraLavorazioni("MACROLAVORAZIONE", "" + m.Id);
                    foreach (Lavorazioni l in list)
                    {
                        listaLavorazione.Add(l);
                    }
                }
                dataGridView1.DataSource = listaLavorazione;
                List<Pagamento> listaPagamenti = op.FiltraPagamento("COMMESSA", "" + commessa.Id);
                dataGridView2.DataSource = listaPagamenti;
                textBox6.Text = commessa.Note;
                dataGridView1.Columns[0].Visible = false;
                dataGridView2.Columns[0].Visible = false;
            }catch
            {
                MessageBox.Show("ciao");
            }

        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow riga in dataGridView1.Rows)
                {
                    if (riga.Cells[0].Value != null)
                    {
                        if (riga.Cells[0].Style.ForeColor == Color.Red)
                        {
                            try
                            {
                                op.UpdateLavorazioni((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "", "" + riga.Cells["DESC"].Value, "" + riga.Cells["SCADENZE"].Value, (int)riga.Cells["MACROLAVORAZIONE"].Value, (double)riga.Cells["PREZZO"].Value);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
                List<Lavorazioni> listaLavorazione = new List<Lavorazioni>();
                foreach (MacroLavorazione m in listaMacrolavorazione)
                {
                    List<Lavorazioni> list = op.FiltraLavorazioni("MACROLAVORAZIONE", "" + m.Id);
                    foreach (Lavorazioni l in list)
                    {
                        listaLavorazione.Add(l);
                    }
                }
                dataGridView1.DataSource = listaLavorazione;
                dataGridView1.Columns[0].Visible = false;
            }catch(Exception ex)
            {
                MessageBox.Show("sistemami");
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView2.Rows)
            {
                if (riga.Cells[0].Value != null)
                {
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                    {
                        try
                        {
                            op.UpdatePagamento((int)riga.Cells["ID"].Value, riga.Cells["NUMEROCOMMESSA"].Value + "", (double)riga.Cells["IMPORTO"].Value, riga.Cells["NOTE"].Value + "", riga.Cells["FATTURA"].Value + "", (DateTime)riga.Cells["DATAFATTURA"].Value, (DateTime)riga.Cells["DATA"].Value, (int)riga.Cells["CLIENTE"].Value, (int)riga.Cells["COMMESSA"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            List<Pagamento> listaPagamenti = op.FiltraPagamento("COMMESSA", "" + commessa.Id);
            dataGridView2.DataSource = listaPagamenti;
            dataGridView2.Columns[0].Visible = false;
        }
        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView2.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                op.UpdateCommessa(commessa.Id, textBox6.Text);
                op.UpdateBozza(commessa.Bozza, Convert.ToDouble(textBox5.Text));
                Cliente c = op.CercaClientiId(commessa.Ditta);
                op.UpdateCliente(c.Id, textBox2.Text, c.Indirizzo, c.Cap, c.Citta, c.Pec, c.Email, c.Iva, c.Tel, c.Sdi);
            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            InserimentoLavorazioni ciao = new InserimentoLavorazioni(db, listaMacrolavorazione[comboBox1.SelectedIndex].Id);
            ciao.Show();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            InserimentoPagamento p = new InserimentoPagamento(db, commessa.Id);
            p.Show();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaLavorazione((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string)dataGridView1.Rows[dataGridView2.SelectedRows[0].Index].Cells[1].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaPagamento((int)dataGridView2.Rows[dataGridView2.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaPagamento((int)dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
        }


    }
}
