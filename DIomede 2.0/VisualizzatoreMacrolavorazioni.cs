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
    public partial class VisualizzatoreMacrolavorazioni : Form
    {
        List<TipologiaMacroLavorazione> lista;
        OperazionePraticheEdili op;
        DataGridView data;
        int riga;
        public VisualizzatoreMacrolavorazioni(String settore, DataGridView dg, int x)
        {
            InitializeComponent();
            op = new OperazionePraticheEdili(settore);
            data = dg;
            riga = x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                data.Rows[riga].Cells[5].Value = lista[listView1.SelectedItems[0].Index].Id;
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void VisualizzatoreMacrolavorazioni_Load(object sender, EventArgs e)
        {
            lista = op.CercaTipologiaMacroLavorazione();
            if(lista.Count > 0)
            {
                foreach(TipologiaMacroLavorazione t in lista)
                {
                    listView1.Items.Add(t.Nome);
                }
            }
        }
    }
}
