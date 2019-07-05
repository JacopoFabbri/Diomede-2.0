using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Recap : Form
    {
        private Commessa commessa;
        private readonly string db;
        private readonly int idCommessa;
        private List<MacroLavorazione> listaMacrolavorazione;
        private OperazionePraticheEdili op;

        public Recap(string dbName, int id)
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
            var s = "";
            foreach (var m in listaMacrolavorazione) s += m.Nome + "\n";
            textBox3.Text = s;
            textBox4.Text = op.CercaBozzaId(commessa.Bozza).IdentificativoPreventivo;
            textBox5.Text = "" + op.CercaBozzaId(commessa.Bozza).Importo;
            var listaLavorazioni = new List<Lavorazioni>();
            foreach (var m in listaMacrolavorazione)
            {
                var list = op.FiltraLavorazioni("MACROLAVORAZIONE", "" + m.Id);
                foreach (var l in list) listaLavorazioni.Add(l);
            }

            dataGridView1.DataSource = listaLavorazioni;
            var listaPagamenti = op.FiltraPagamento("COMMESSA", "" + commessa.Id);
            dataGridView2.DataSource = listaPagamenti;
            textBox6.Text = commessa.Note;
            dataGridView1.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateLavorazioni((int) riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "",
                                "" + riga.Cells["DESC"].Value, "" + riga.Cells["SCADENZE"].Value,
                                (int) riga.Cells["MACROLAVORAZIONE"].Value, (double) riga.Cells["PREZZO"].Value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            var listaLavorazioni = new List<Lavorazioni>();
            foreach (var m in listaMacrolavorazione)
            {
                var list = op.FiltraLavorazioni("MACROLAVORAZIONE", "" + m.Id);
                foreach (var l in list) listaLavorazioni.Add(l);
            }

            dataGridView1.DataSource = listaLavorazioni;
            dataGridView2.Columns[0].Visible = false;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdatePagamento((int) riga.Cells["ID"].Value, riga.Cells["NUMEROCOMMESSA"].Value + "",
                                (double) riga.Cells["IMPORTO"].Value, riga.Cells["NOTE"].Value + "",
                                riga.Cells["FATTURA"].Value + "", (DateTime) riga.Cells["DATAFATTURA"].Value,
                                (DateTime) riga.Cells["DATA"].Value, (int) riga.Cells["CLIENTE"].Value,
                                (int) riga.Cells["COMMESSA"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            var listaPagamenti = op.FiltraPagamento("COMMESSA", "" + commessa.Id);
            dataGridView1.DataSource = listaPagamenti;
            dataGridView1.Columns[0].Visible = false;
        }

        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView2.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                op.UpdateCommessa(commessa.Id, textBox6.Text);
                op.UpdateBozza(commessa.Bozza, Convert.ToDouble(textBox5.Text));
            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}