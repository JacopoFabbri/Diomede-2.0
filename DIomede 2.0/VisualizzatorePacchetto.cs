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
    public partial class VisualizzatorePacchetto : Form
    {
        String db;
        List<Pacchetto> lista;
        OperazionePraticheEdili op;
        DataGridViewCell data;
        int id;
        public VisualizzatorePacchetto(String dbName, int id, DataGridViewCell dc)
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
            foreach (Pacchetto c in lista)
            {
                comboBox1.Items.Add(c.Nome);
            }
            comboBox1.SelectedItem = op.CercaPacchetto(id).Nome;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            data.Value = lista[comboBox1.SelectedIndex].Id;
            this.Close();
        }
        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
    }
}
