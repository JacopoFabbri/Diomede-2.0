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
    public partial class FiltroClienti : Form
    {
        DataGridView dataTable;
        List<Cliente> lista;
        OperazionePraticheEdili op;
        String db;
        public FiltroClienti(DataGridView d, String dbName)
        {
            db = dbName;
            dataTable = d;
            InitializeComponent();
        }

        private void FiltroClienti_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                comboBox1.Items.Add("NOME");
                comboBox1.Items.Add("INDIRIZZO");
                comboBox1.Items.Add("CAP");
                comboBox1.Items.Add("CITTA");
                comboBox1.Items.Add("PEC");
                comboBox1.Items.Add("EMAIL");
                comboBox1.Items.Add("PARTITAIVA");
                comboBox1.Items.Add("TELEFONOFISSO");
                comboBox1.Items.Add("SDI");
                lista = op.CercaClienti();
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("NOME"))
            {
                foreach(Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Nome);
                }
            }
            else if (comboBox1.SelectedItem.Equals("INDIRIZZO"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Indirizzo);
                }
            }
            else if (comboBox1.SelectedItem.Equals("CAP"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Cap);
                }
            }
            else if (comboBox1.SelectedItem.Equals("CITTA"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Citta);
                }
            }
            else if (comboBox1.SelectedItem.Equals("PEC"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Pec);
                }
            }
            else if (comboBox1.SelectedItem.Equals("EMAIL"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Email);
                }
            }
            else if (comboBox1.SelectedItem.Equals("PARTITAIVA"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Iva);
                }
            }
            else if (comboBox1.SelectedItem.Equals("TELEFONOFISSO"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Tel);
                }
            }
            else if (comboBox1.SelectedItem.Equals("SDI"))
            {
                foreach (Cliente c in lista)
                {
                    comboBox2.Items.Add(c.Sdi);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataTable.DataSource = op.FiltraClienti("" + comboBox1.SelectedItem,"" + comboBox2.SelectedItem);
        }
    }
}
