using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class VisualizzatoreDitte : Form
    {
        private readonly DataGridViewCell data;
        private readonly string db;
        private readonly int id;
        private List<Cliente> lista;
        private OperazionePraticheEdili op;

        public VisualizzatoreDitte(string dbName, int id, DataGridViewCell dc)
        {
            data = dc;
            this.id = id;
            db = dbName;
            InitializeComponent();
        }
        private void VisualizzatoreDitte_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaClienti();
            foreach (var c in lista) comboBox1.Items.Add(c.Nome);
            comboBox1.SelectedItem = op.CercaClientiId(id).Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                data.Value = lista[comboBox1.SelectedIndex].Id;


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}