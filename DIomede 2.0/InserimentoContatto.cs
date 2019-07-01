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
    public partial class InserimentoContatto : Form
    {
        readonly String db;
        readonly Cliente cliente;
        List<Ruolo> lista;
        public InserimentoContatto(Cliente c, String dbName)
        {
            cliente = c;
            db = dbName;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox8.Text = "" + cliente.Id;
            OperazionePraticheEdili op = new OperazionePraticheEdili(db);
            lista = op.CercaRuolo();
            if (lista != null)
            {
                foreach (Ruolo r in lista)
                {
                    comboBox1.Items.Add(r.Nome);
                }
            }
            else
            {
                MessageBox.Show("Inserire almeno un ruolo!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperazionePraticheEdili op = new OperazionePraticheEdili(db);
                if (!comboBox1.Text.Equals("Ruolo"))
                {
                    op.InserimentoContatto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text,"" + lista[comboBox1.SelectedIndex].Id);
                    MessageBox.Show("Contatto Inserito","Inserito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ruoli frm = new Ruoli(db);
            frm.Show();
        }
    }
}
