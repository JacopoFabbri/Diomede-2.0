using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class InserimentoContatto : Form
    {
        private readonly Cliente cliente;
        private readonly string db;

        public InserimentoContatto(Cliente c, string dbName)
        {
            cliente = c;
            db = dbName;
            InitializeComponent();
        }

        public void Form5_Load(object sender, EventArgs e)
        {
            textBox8.Text = "" + cliente.Id;
            var op = new OperazioniAmministrazione(db);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new OperazioniAmministrazione(db);
                if (!textBox11.Text.Equals("Ruolo"))
                {
                    op.InserimentoContatto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
                        textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text);
                    MessageBox.Show("Contatto Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

    }
}