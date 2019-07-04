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
    public partial class FiltroLavorazioni : Form
    {
        DataGridView dataTable;
        List<Lavorazione> lista;
        OperazionePraticheEdili op;
        String db;
        public FiltroLavorazioni(DataGridView d, String dbName)
        {
            db = dbName;
            dataTable = d;
            InitializeComponent();
        }

        private void FiltroLavorazioni_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                comboBox1.Items.Add("OPERAZIONE");
                comboBox1.Items.Add("PACCHETTO");
                comboBox1.Items.Add("IMPORTO");
                comboBox1.Items.Add("DESC");
                lista = op.CercaLavorazione();
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

                dataTable.DataSource = op.FiltraLavorazione("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
            
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("OPERAZIONE"))
            {
                foreach (Lavorazione c in lista)
                {
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (c.Operazione.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        comboBox2.Items.Add(c.Operazione.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.Equals("PACCHETTO"))
            {
                foreach (Lavorazione c in lista)
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
                foreach (Lavorazione c in lista)
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
                        comboBox2.Items.Add(c.Importo.ToString());
                    }
                }
            }
            else if (comboBox1.SelectedItem.Equals("DESC"))
            {
                foreach (Lavorazione c in lista)
                {
                    Boolean flag = true;
                    foreach (Object o in comboBox2.Items)
                    {
                        if (c.Desc.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        comboBox2.Items.Add(c.Desc);
                    }
                }
            }
        }

        private void FiltoLavorazione_Load(object sender, EventArgs e)
        {

        }
    }
}
