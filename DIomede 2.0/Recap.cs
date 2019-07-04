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
            op = new OperazionePraticheEdili(db);
            commessa = op.CercaCommessa(idCommessa);
            textBox1.Text = "" + commessa.NumeroCommessa;
            textBox2.Text = op.CercaClientiId(commessa.Ditta).Nome;
            listaMacrolavorazione = op.FiltraMacroLavorazione("COMMESSA", "" + commessa.Id);
            String s = "";
            foreach (MacroLavorazione m in listaMacrolavorazione)
            {
                s += m.Nome + "\n";
            }
            textBox3.Text = s;
            textBox4.Text = op.CercaBozzaId(commessa.Bozza).IdentificativoPreventivo;
            textBox5.Text = "" + op.CercaBozzaId(commessa.Bozza).Importo;
            List<Lavorazioni> listaLavorazioni = new List<Lavorazioni>();
            foreach (MacroLavorazione m in listaMacrolavorazione)
            {
                List<Lavorazioni> list = op.FiltraLavorazioni("MACROLAVORAZIONE", "" + m.Id);
                foreach(Lavorazioni l in list)
                {
                    listaLavorazioni.Add(l);
                }
            }
            dataGridView1.DataSource = listaLavorazioni;
            List<Pagamento> listaPagamenti = op.FiltraPagamento("COMMESSA", "" + commessa.Id);
            dataGridView2.DataSource = listaPagamenti;
            textBox6.Text = commessa.Note;
            dataGridView1.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;
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
                            op.UpdateLavorazioni((int)riga.Cells["ID"].Value, riga.Cells["NOMME"].Value + "", "" + riga.Cells["DESC"].Value, "" + riga.Cells["SCADENZE"].Value, (int)riga.Cells["MACROLAVORAZIONE"].Value, (double)riga.Cells["PREZZO"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            List<Lavorazioni> listaLavorazioni = new List<Lavorazioni>();
            foreach (MacroLavorazione m in listaMacrolavorazione)
            {
                List<Lavorazioni> list = op.FiltraLavorazioni("MACROLAVORAZIONE", "" + m.Id);
                foreach (Lavorazioni l in list)
                {
                    listaLavorazioni.Add(l);
                }
            }
            dataGridView1.DataSource = listaLavorazioni;
            dataGridView2.Columns[0].Visible = false;
        }

            private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
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
            dataGridView1.DataSource = listaPagamenti;
            dataGridView1.Columns[0].Visible = false;
        }

        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView2.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }
    }
}
