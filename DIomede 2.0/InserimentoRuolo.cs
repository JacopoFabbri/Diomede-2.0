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
        public InserimentoRuolo(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Form8_Close(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperazionePraticheEdili op = new OperazionePraticheEdili(db);
                op.InserimentoRuolo(textBox1.Text, textBox2.Text);
                MessageBox.Show("Ruolo Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }
    }
}
