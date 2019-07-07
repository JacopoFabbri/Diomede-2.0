using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class VisualizzatorePacchetto : Form
    {
        private readonly DataGridViewCell data;
        private readonly string db;
        private readonly int id;
        private List<Pacchetto> lista;
        private OperazionePraticheEdili op;

        public VisualizzatorePacchetto(string dbName, int id, DataGridViewCell dc)
        {
            data = dc;
            this.id = id;
            db = dbName;
            InitializeComponent();
        }

        private void VisualizzatorePacchetto_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaPacchetto();
            foreach (var c in lista) comboBox1.Items.Add(c.Nome);
            comboBox1.SelectedItem = op.CercaPacchetto(id).Nome;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            data.Value = lista[comboBox1.SelectedIndex].Id;
            Close();
        }

        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}