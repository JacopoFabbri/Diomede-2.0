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
    public partial class InserimentoCliente : Form
    {
        readonly String db;
        ListaClienti form;
        public InserimentoCliente(String dbName, ListaClienti frm)
        {
            form = frm;
            db = dbName;
            InitializeComponent();
        }
        public InserimentoCliente(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperazionePraticheEdili op = new OperazionePraticheEdili(db);
                op.InserimentoCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
                MessageBox.Show("Cliente Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (form == null)
                {
                    this.Close();
                }
                else
                {
                    form.Form4_Load(sender, e);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

        private void InserimentoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
