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
    public partial class Form3 : Form
    {
        String db;
        Form2 formPrecendente;
        public Form3(String dbName, Form2 frm)
        {
            formPrecendente = frm;
            db = dbName;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm1 = new Form4(db, this);
            frm1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperazionePraticheEdili op = new OperazionePraticheEdili(db);
                op.inserimentoCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecendente.Show();
        }
    }
}
