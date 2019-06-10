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
                op = new OperazionePraticheEdili(db);
                op.InserimentoBozza(dateTimePicker1.Value, textBox2.Text, textBox3.Text, textBox4.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }
    }
}
