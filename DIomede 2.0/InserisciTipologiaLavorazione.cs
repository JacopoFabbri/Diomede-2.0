using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserisciTipologiaLavorazione : Form
    {
        private readonly string db;
        private readonly OperazionePraticheEdili op;
        private List<TipologiaMacroLavorazione> lista;

        public InserisciTipologiaLavorazione(string dbName)
        {
            db = dbName;
            InitializeComponent();
            op = new OperazionePraticheEdili(db);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoTipologialavorazione(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text),
                    textBox4.Text, lista[comboBox1.SelectedIndex].Id);
                MessageBox.Show("Tipologia di Lavorazione Inserita", "Inserito", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

        private void InserisciTipologiaLavorazione_Load(object sender, EventArgs e)
        {
            lista = op.CercaTipologiaMacroLavorazione();
            foreach (var t in lista) comboBox1.Items.Add(t.Nome);
        }
    }
}