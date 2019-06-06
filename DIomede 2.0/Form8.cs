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
    public partial class Form8 : Form
    {
        String db;
        public Form8(String dbName)
        {
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
                op.inserimentoRuolo(textBox1.Text, textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }
    }
}
