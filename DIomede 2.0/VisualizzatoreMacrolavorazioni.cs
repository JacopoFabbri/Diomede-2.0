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
        public VisualizzatoreMacrolavorazioni(String settore)
        {
            InitializeComponent();
            op = new OperazionePraticheEdili(settore);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {

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
