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
    public partial class VisualizzatoreDitte : Form
    {
        String db;
        List<Cliente> lista;
        OperazionePraticheEdili op;
        DataGridViewCell data;
        int id;
        public VisualizzatoreDitte(String dbName, int id, DataGridViewCell dc)
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
            foreach(Cliente c in lista)
            {
                comboBox1.Items.Add(c.Nome);
            }
            comboBox1.SelectedItem = op.CercaClientiId(id).Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            data.Value = lista[comboBox1.SelectedIndex].Id;
            this.Close();
        }
    }
}
