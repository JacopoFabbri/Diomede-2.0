using Diomede2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PonteggiDiomede
{
    public partial class InserimentoLavorazione : Form
    {
        int id;
        Commessa c;
        OperazionePraticheEdili op;
        public InserimentoLavorazione(int idCommessa)
        {
            id = idCommessa;
            op = new OperazionePraticheEdili("Ponteggi");
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                Double d = Convert.ToDouble(textBox3.Text);

                op.InserimentoLavorazioni(textBox1.Text, textBox2.Text, d, c.Id, dateTimePicker1.Value, textBox5.Text);

            }
            catch
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

        private void InserimentoLavorazione_Load(object sender, EventArgs e)
        {
            try
            {
                c = op.CercaCommessa(id);
                textBox4.Text = c.NumeroCommessa;

            }
            catch 
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }

        }
    }
}
