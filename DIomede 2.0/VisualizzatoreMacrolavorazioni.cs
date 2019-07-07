using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class VisualizzatoreMacrolavorazioni : Form
    {
        private readonly DataGridView data;
        private List<TipologiaMacroLavorazione> lista;
        private readonly OperazionePraticheEdili op;
        private readonly int riga;

        public VisualizzatoreMacrolavorazioni(string settore, DataGridView dg, int x)
        {
            InitializeComponent();
            op = new OperazionePraticheEdili(settore);
            data = dg;
            riga = x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                data.Rows[riga].Cells[5].Value = lista[listView1.SelectedItems[0].Index].Id;
                Close();
            }
            else
            {
                Close();
            }
        }

        private void VisualizzatoreMacrolavorazioni_Load(object sender, EventArgs e)
        {
            lista = op.CercaTipologiaMacroLavorazione();
            if (lista.Count > 0)
                foreach (var t in lista)
                    listView1.Items.Add(t.Nome);
        }

        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}