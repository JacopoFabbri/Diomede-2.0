using Diomede2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpenterieMetallicheDiomede
{
    public partial class InserisciAcconto : Form
    {
        private readonly string db;
        private int id;
        private OperazionePraticheEdili op;
        public InserisciAcconto(string dbName, int idCommessa)
        {
            id = idCommessa;
            db = dbName;
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoAcconti(Convert.ToDouble(textBox3.Text), textBox2.Text, textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox3.Text, Convert.ToInt32(textBox5.Text));
                MessageBox.Show("Bozza Inserita", "Inserita:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }
        private void InserisciAcconto_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            textBox4.Text = "" + id;
            textBox3.Text = "" + 0;
        }
    }
}
