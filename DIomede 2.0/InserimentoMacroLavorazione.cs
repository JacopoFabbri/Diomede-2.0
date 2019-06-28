using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diomede2
{
    public partial class InserimentoMacroLavorazione : Form
    {
        readonly String db;
        List<TipologiaMacroLavorazione> lista;
        OperazionePraticheEdili op;
        private readonly int idB;

        public InserimentoMacroLavorazione(String dbName, int idBozza)
        {
            idB = idBozza;
            db = dbName;
            InitializeComponent();
        }
        private void InserimentoMacroLavorazione_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            textBox3.Text = op.FiltraCommessa("BOZZA", idB + "")[0].NumeroCommessa;
            textBox5.Text = op.FiltraCommessa("BOZZA", idB + "")[0].Id + "";
            lista = op.CercaTipologiaMacroLavorazione();
            foreach(TipologiaMacroLavorazione t in lista)
            {
                comboBox1.Items.Add(t.Nome);
            }
            this.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoMacrolavorazione(textBox1.Text,dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToDouble(textBox2.Text), textBox3.Text,lista[comboBox1.SelectedIndex].Id, textBox4.Text, Convert.ToInt32(textBox5.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = lista[comboBox1.SelectedIndex].Nome + "";
            textBox4.Text = lista[comboBox1.SelectedIndex].Desc + "";
        }
    }
}
