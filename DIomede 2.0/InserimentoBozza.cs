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
    public partial class InserimentoBozza : Form
    {
        readonly String db;
        readonly ListaBozze formPrecedente;
        OperazionePraticheEdili op;
        List<Cliente> lista = new List<Cliente>();
        public InserimentoBozza(String dbName, ListaBozze lb)
        {
            formPrecedente = lb;
            db = dbName;
            InitializeComponent();
        }
        private void TextBox2_Click(object sender, EventArgs e)
        {
            ListaPacchetto lp = new ListaPacchetto(db, this, textBox2);
            lp.Show();
        }
        private void InserimentoBozza_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecedente.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                op.InserimentoBozza(dateTimePicker1.Value, textBox2.Text, Double.Parse(textBox3.Text), textBox4.Text, lista[comboBox1.SelectedIndex].Id, false);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }
        private void InserimentoBozza_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaClienti();
            foreach(Cliente c in lista)
            {
                comboBox1.Items.Add(c.Nome);
            }
        }
    }
}
