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
    public partial class InserimentoRuolo : Form
    {
        readonly String db;
        InserimentoContatto c;
        public InserimentoRuolo(String dbName, InserimentoContatto c)
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
                OperazionePraticheEdili op = new OperazionePraticheEdili(db);
                op.InserimentoRuolo(textBox1.Text, textBox2.Text);
                MessageBox.Show("Operazione effettuata", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                c.Form5_Load(sender, e);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }
    }
}
