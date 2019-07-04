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
    public partial class visualizzatore : Form
    {
        readonly String db;
        DataGridViewCell data;
        OperazionePraticheEdili op;
        List<Ruolo> lista;
        int id;
        public visualizzatore(String s,int id, DataGridViewCell dg)
        {
            this.id = id;
            data = dg;
            this.db = s;
            InitializeComponent();
        }
        private void Visualizzatore_Load(object sender, EventArgs e)
        {

            op = new OperazionePraticheEdili(db);
            lista = op.CercaRuolo();
            foreach(Ruolo r in lista)
            {
                comboBox1.Items.Add(r.Nome);
            }
            comboBox1.SelectedItem = op.CercaRuoloId(id);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            data.Value = lista[comboBox1.SelectedIndex].Id;
            this.Close();
        }
        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
