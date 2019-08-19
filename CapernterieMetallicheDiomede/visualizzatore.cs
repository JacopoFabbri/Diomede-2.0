using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class visualizzatore : Form
    {
        private readonly DataGridViewCell data;
        private readonly string db;
        private readonly int id;
        private List<Ruolo> lista;
        private OperazionePraticheEdili op;

        public visualizzatore(string s, int id, DataGridViewCell dg)
        {
            this.id = id;
            data = dg;
            db = s;
            InitializeComponent();
        }

        private void Visualizzatore_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaRuolo();
            foreach (var r in lista) comboBox1.Items.Add(r.Nome);
            comboBox1.SelectedItem = op.CercaRuoloId(id).Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
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