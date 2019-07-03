using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class FiltroBozze : Form
    {
        DataGridView dataTable;
        List<Bozza> lista;
        OperazionePraticheEdili op;
        String db;
        List<Cliente> listaClienti = new List<Cliente>();
        public FiltroBozze(DataGridView d, String dbName)
        {
            db = dbName;
            dataTable = d;
            InitializeComponent();
        }

        private void FiltroBozze_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                comboBox1.Items.Add("DATA");
                comboBox1.Items.Add("PACCHETTO");
                comboBox1.Items.Add("IMPORTO");
                comboBox1.Items.Add("NUMEROCOMMESSA");
                comboBox1.Items.Add("CLIENTE");
                comboBox1.Items.Add("ACCETAZIONE");
                lista = op.CercaBozza();
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("CLIENTE"))
            {
                dataTable.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem, "" + listaClienti[comboBox2.SelectedIndex].Id);
            }
            else
            {
                dataTable.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("DATA"))
            {
                foreach (Bozza c in lista)
                {
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (c.Data.ToString("yyyy-MM-dd").Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        comboBox2.Items.Add(c.Data.ToString("yyyy-MM-dd"));
                    }
                }
            }
            else if (comboBox1.SelectedItem.Equals("PACCHETTO"))
            {
                foreach (Bozza c in lista)
                {
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (c.Pacchetto.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        comboBox2.Items.Add(c.Pacchetto);
                    }
                }
            }
            else if (comboBox1.SelectedItem.Equals("IMPORTO"))
            {
                foreach (Bozza c in lista)
                {
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (c.Importo.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        comboBox2.Items.Add(c.Importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                    }
                }
            }
            else if (comboBox1.SelectedItem.Equals("NUMEROCOMMESSA"))
            {
                foreach (Bozza c in lista)
                {
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (c.NumeroCommessa.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        comboBox2.Items.Add(c.NumeroCommessa);
                    }
                }
            }
            else if (comboBox1.SelectedItem.Equals("CLIENTE"))
            {
                foreach (Bozza c in lista)
                {
                    Cliente cliente;
                    cliente = op.CercaClientiId(c.Cliente);
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (cliente.Nome.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        listaClienti.Add(cliente);
                        comboBox2.Items.Add(cliente.Nome);
                    }
                }
            }
            else if (comboBox1.SelectedItem.Equals("ACCETTAZIONE"))
            {
                foreach (Bozza c in lista)
                {
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (c.Accettazione.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        comboBox2.Items.Add(c.Accettazione);
                    }
                }
            }
        }
    }
}
