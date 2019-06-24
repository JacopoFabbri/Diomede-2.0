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
    public partial class InserisciTipologiaLavorazione : Form
    {
        List<TipologiaMacroLavorazione> lista;
        readonly String db;

        OperazionePraticheEdili op;
        public InserisciTipologiaLavorazione(String dbName)
        {
            db = dbName;
            InitializeComponent();
            op = new OperazionePraticheEdili(db);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoTipologialavorazione(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), textBox4.Text,lista[comboBox1.SelectedIndex].Id);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }
        private void InserisciTipologiaLavorazione_Load(object sender, EventArgs e)
        {
            lista = op.CercaTipologiaMacroLavorazione();
            foreach (TipologiaMacroLavorazione t in lista)
            {
                comboBox1.Items.Add(t.Nome);
            }
        }
    }
}
