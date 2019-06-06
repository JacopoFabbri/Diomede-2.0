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
    public partial class Form5 : Form
    {
        String db;
        Cliente cliente;
        public Form5(Cliente c, String dbName)
        {
            cliente = c;
            db = dbName;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Form6 frm = new Form6(db);
            frm.Show();
            OperazionePraticheEdili op = new OperazionePraticheEdili(db);
            List<Ruolo> lista = op.cercaRuolo();
            if (lista != null)
            {
                foreach (Ruolo r in lista)
                {
                    comboBox1.Items.Add(r.Nome);
                }
            }
            else
            {
                MessageBox.Show("Inserire almeno un ruolo!");
            }
        }
    }
}
