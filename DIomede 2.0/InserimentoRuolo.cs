using System;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoRuolo : Form
    {
        private readonly string db;
        private readonly InserimentoContatto c;

        public InserimentoRuolo(string dbName, InserimentoContatto c)
        {
            this.c = c;
            db = dbName;
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new OperazionePraticheEdili(db);
                op.InserimentoRuolo(textBox1.Text, textBox2.Text);
                MessageBox.Show("Operazione effettuata", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                c.Form5_Load(sender, e);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione","Errore:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}