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
                foreach (Cliente c in listaCLienti) comboBox1.Items.Add(c.Nome);
                textBox5.Text = "" + op.CercaBozzaId(commessa.Bozza).Importo;
                List<Lavorazioni> listaLavorazione = op.FiltraLavorazioni("COMMESSA", "" + idCommessa);
                dataGridView1.DataSource = listaLavorazione;
                textBox6.Text = commessa.Note;
                dataGridView1.Columns[0].Visible = false;
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
                List<Lavorazioni> listaLavorazione = op.FiltraLavorazioni("COMMESSA", "" + idCommessa);
                dataGridView1.DataSource = listaLavorazione;
                dataGridView1.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("ciao");
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
            InserimentoLavorazione l = new InserimentoLavorazione(idCommessa);
            l.Show();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            InserimentoPagamento p = new InserimentoPagamento(db, commessa.Id);
            p.Show();
        }
    }
}
