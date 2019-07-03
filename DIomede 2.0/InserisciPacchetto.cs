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
    public partial class InserisciPacchetto : Form
    {
        readonly String db;
        OperazionePraticheEdili op;
        List<TipologiaMacroLavorazione> lista;
        public InserisciPacchetto(String dBName)
        {
            db = dBName;
            InitializeComponent();
            op = new OperazionePraticheEdili(db);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            op.InserimentoTipologiaMacrolavorazione(textBox1.Text, textBox2.Text);
            lista = op.CercaTipologiaMacroLavorazione();
            op.InserimentoPacchetto(textBox1.Text, textBox2.Text, lista[lista.Count - 1].Id);


            MessageBox.Show("Pacchetto Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InserisciPacchetto_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void InserisciPacchetto_Load(object sender, EventArgs e)
        {

        }
    }
}
