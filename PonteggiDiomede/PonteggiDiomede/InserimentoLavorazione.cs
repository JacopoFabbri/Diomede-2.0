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

                op.InserimentoLavorazioni(textBox1.Text, textBox2.Text, 0, c.Id, dateTimePicker1.Value, comboBox1.SelectedItem.ToString());

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
                comboBox1.Items.Add("Andrea");
                comboBox1.Items.Add("James");
                comboBox1.Items.Add("Nicolas");
                comboBox1.Items.Add("Fabio");
                comboBox1.Items.Add("Rossana");
                comboBox1.Items.Add("Marco");
                comboBox1.Items.Add("Maverick");

            }
            catch 
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }

        }
    }
}
