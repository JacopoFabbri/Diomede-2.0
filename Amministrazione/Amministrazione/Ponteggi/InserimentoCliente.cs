using System;
using System.Windows.Forms;

namespace Diomede3
{
    public partial class InserimentoCliente : Form
    {
        private readonly string db;

        public InserimentoCliente(string dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new OperazionePraticheEdili(db);
                op.InserimentoCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
                    textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
                MessageBox.Show("Cliente Inserito", "Inserito:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione","Errore:",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}