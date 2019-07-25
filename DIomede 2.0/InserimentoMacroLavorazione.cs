using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoMacroLavorazione : Form
    {
        private readonly string db;
        private readonly int idB;
        private List<TipologiaMacroLavorazione> lista;
        private OperazionePraticheEdili op;

        public InserimentoMacroLavorazione(string dbName, int idBozza)
        {
            idB = idBozza;
            db = dbName;
            InitializeComponent();
        }

        private void InserimentoMacroLavorazioni_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (idB != 0)
                {
                    textBox3.Text = op.CercaCommessa(idB).NumeroCommessa;
                    textBox5.Text = op.CercaCommessa(idB).Id + "";
                }

                lista = op.CercaTipologiaMacroLavorazione();
                foreach (var m in lista) comboBox1.Items.Add(m.Nome);
            }
            catch
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoMacrolavorazione(textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value,
                    Convert.ToDouble(textBox2.Text), textBox3.Text, lista[comboBox1.SelectedIndex].Id, textBox4.Text,
                    Convert.ToInt32(textBox5.Text));
                MessageBox.Show("Macrolavorazione inserita", "Inserita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch
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