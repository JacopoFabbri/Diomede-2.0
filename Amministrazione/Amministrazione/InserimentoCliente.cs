using System;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class InserimentoCliente : Form
    {
        private readonly string db;
        private readonly ListaClienti form;

        public InserimentoCliente(string dbName, ListaClienti frm)
        {
            form = frm;
            db = dbName;
            InitializeComponent();
        }

        public InserimentoCliente(string dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new OperazioniAmministrazione(db);
                op.InserimentoCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
                    textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
                MessageBox.Show("Cliente Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (form == null)
                {
                    Close();
                }
                else
                {
                    form.Form4_Load(sender, e);
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

    }
}