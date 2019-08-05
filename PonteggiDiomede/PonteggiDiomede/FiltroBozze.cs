using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class FiltroBozze : Form
    {
        private readonly DataGridView dataTable;
        private readonly string db;
        private List<Bozza> lista;
        private readonly List<Cliente> listaClienti = new List<Cliente>();
        private OperazionePraticheEdili op;
        public FiltroBozze(DataGridView d, string dbName)
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
                comboBox1.Items.Add("IMPORTO");
                comboBox1.Items.Add("FASEPROGETTO");
                comboBox1.Items.Add("IDENTIFICATIVOPREVENTIVO");
                comboBox1.Items.Add("CLIENTE");
                comboBox1.Items.Add("ACCETTAZIONE");
                lista = op.CercaBozza();
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("CLIENTE"))
                dataTable.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem,
                    "" + listaClienti[comboBox2.SelectedIndex].Id);
            else
                dataTable.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("DATA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data.ToString("yyyy-MM-dd").Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data.ToString("yyyy-MM-dd"));
                }
            else if (comboBox1.SelectedItem.Equals("IMPORTO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Importo.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                }
            else if (comboBox1.SelectedItem.Equals("FASEPROGETTO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.FaseProgetto.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.FaseProgetto);
                }
            else if (comboBox1.SelectedItem.Equals("CLIENTE"))
                foreach (var c in lista)
                {
                    Cliente cliente;
                    cliente = op.CercaClientiId(c.Cliente);
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (cliente.Nome.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag)
                    {
                        listaClienti.Add(cliente);
                        comboBox2.Items.Add(cliente.Nome);
                    }
                }
            else if (comboBox1.SelectedItem.Equals("ACCETTAZIONE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Accettazione.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Accettazione);
                }
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}