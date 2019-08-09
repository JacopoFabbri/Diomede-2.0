using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoPagamento : Form
    {
        private readonly string db;
        private readonly int idB;
        private OperazionePraticheEdili op;

        public InserimentoPagamento(string dbName, int idCommessa)
        {
            idB = idCommessa;
            db = dbName;
            InitializeComponent();
        }

        private void InserimentoPagamento_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            if (idB != 0)
            {
                textBox1.Text = op.CercaCommessa(idB).NumeroCommessa;
                textBox5.Text = op.CercaCommessa(idB).Ditta + "";
                textBox6.Text = idB + "";
                textBox2.Text = "" + 0;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoPagamento(textBox1.Text, Convert.ToDouble(textBox2.Text), textBox3.Text, textBox4.Text,
                    dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(textBox5.Text),
                    Convert.ToInt32(textBox6.Text));
                MessageBox.Show("Pagamento inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }
    }
}