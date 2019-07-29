using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserisciPacchetto : Form
    {
        private readonly string db;
        private readonly OperazionePraticheEdili op;

        public InserisciPacchetto(string dBName)
        {
            db = dBName;
            InitializeComponent();
            op = new OperazionePraticheEdili(db);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            op.InserimentoPacchetto(textBox1.Text, textBox2.Text);


            MessageBox.Show("Pacchetto Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void InserisciPacchetto_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void InserisciPacchetto_Load(object sender, EventArgs e)
        {
        }
    }
}