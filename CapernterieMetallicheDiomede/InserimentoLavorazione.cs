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

namespace Diomede2
{
    public partial class InserimentoLavorazione : Form
    {
        int id;
        Commessa c;
        OperazionePraticheEdili op;
        public InserimentoLavorazione(int idCommessa)
        {
            id = idCommessa;
            op = new OperazionePraticheEdili("CarpenteriaMetallica");
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                op.InserimentoLavorazioni(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), c.Id, dateTimePicker1.Value, textBox5.Text);

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
                textBox3.Text = "" + 0;
            }
            catch 
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }

        }
    }
}
