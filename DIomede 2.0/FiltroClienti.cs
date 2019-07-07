using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class FiltroClienti : Form
    {
        private readonly DataGridView dataTable;
        private readonly string db;
        private List<Cliente> lista;
        private OperazionePraticheEdili op;

        public FiltroClienti(DataGridView d, string dbName)
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
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("NOME"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Nome.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Nome);
                }
            else if (comboBox1.SelectedItem.Equals("INDIRIZZO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Indirizzo.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Indirizzo);
                }
            else if (comboBox1.SelectedItem.Equals("CAP"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Cap.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Cap);
                }
            else if (comboBox1.SelectedItem.Equals("CITTA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Citta.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Citta);
                }
            else if (comboBox1.SelectedItem.Equals("PEC"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Pec.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Pec);
                }
            else if (comboBox1.SelectedItem.Equals("EMAIL"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Email.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Email);
                }
            else if (comboBox1.SelectedItem.Equals("PARTITAIVA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Iva.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Iva);
                }
            else if (comboBox1.SelectedItem.Equals("TELEFONOFISSO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Tel.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Tel);
                }
            else if (comboBox1.SelectedItem.Equals("SDI"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Sdi.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Sdi);
                }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataTable.DataSource = op.FiltraClienti("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
        }
    }
}