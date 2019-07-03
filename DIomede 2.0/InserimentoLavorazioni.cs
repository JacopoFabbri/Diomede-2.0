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
    public partial class InserimentoLavorazioni : Form
    {
        readonly ListaLavorazione formPrecedente;
        readonly String db;
        List<MacroLavorazione> lista;
        OperazionePraticheEdili op;
        public InserimentoLavorazioni(String dbName, ListaLavorazione ll)
        {
            db = dbName;
            formPrecedente = ll;
            InitializeComponent();
        }
        private void InserimentoLavorazioni_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaMacroLavorazione();
            foreach(MacroLavorazione m in lista)
            {
                comboBox1.Items.Add(m.Nome);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoLavorazioni(textBox1.Text, textBox2.Text, textBox3.Text, lista[comboBox1.SelectedIndex].Id,Convert.ToDouble(textBox4.Text));
                MessageBox.Show("Lavorazione Inserita", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                formPrecedente.ListaLavorazione_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }

        private void InserimentoLavorazioni_Load_1(object sender, EventArgs e)
        {

        }
    }
}
