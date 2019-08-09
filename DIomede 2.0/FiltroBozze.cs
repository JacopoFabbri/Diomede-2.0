using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class FiltroBozze : Form
    {
        private readonly DataGridView dataGridView1;
        private readonly string db;
        private List<Bozza> lista;
        private readonly List<Cliente> listaClienti = new List<Cliente>();
        private readonly List<Pacchetto> listaPacchetti = new List<Pacchetto>();
        private OperazionePraticheEdili op;
        private Boolean flag;

        public FiltroBozze(DataGridView d, string dbName, Boolean f)
        {
            flag = f;
            db = dbName;
            dataGridView1 = d;
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
                comboBox1.Items.Add("IDENTIFICATIVOPREVENTIVO");
                comboBox1.Items.Add("CLIENTE");
                comboBox1.Items.Add("ACCETAZIONE");
                lista = op.CercaBozza();
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area!!!", "Errore:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox1.SelectedItem != null)
                if (comboBox1.SelectedItem.ToString().Equals("CLIENTE"))
                {
                    dataGridView1.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem,
                        "" + listaClienti[comboBox2.SelectedIndex].Id);
                    dataGridView1.Columns.Remove("TITOLOPACCHETTO");
                    dataGridView1.Columns.Remove("CLIENTE");
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "TITOLOPACCHETTO";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Pacchetto c = op.CercaPacchetto((int)r.Cells[2].Value);
                        r.Cells[7].Value = c.Nome;
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "CLIENTE";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[5].Value);
                        r.Cells[8].Value = c.Nome;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[7].ReadOnly = true;
                    dataGridView1.Columns[8].ReadOnly = true;
                }
                else if (comboBox1.SelectedItem.ToString().Equals("PACCHETTO"))
                {
                    dataGridView1.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem,
                        "" + listaPacchetti[comboBox2.SelectedIndex].Id);
                    dataGridView1.Columns.Remove("TITOLOPACCHETTO");
                    dataGridView1.Columns.Remove("CLIENTE");
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "TITOLOPACCHETTO";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Pacchetto c = op.CercaPacchetto((int)r.Cells[2].Value);
                        r.Cells[7].Value = c.Nome;
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "CLIENTE";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[5].Value);
                        r.Cells[8].Value = c.Nome;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[7].ReadOnly = true;
                    dataGridView1.Columns[8].ReadOnly = true;
                }
                else if (comboBox1.SelectedItem.ToString().Equals("IDENTIFICATIVOPREVENTIVO"))
                {
                    dataGridView1.DataSource =
                        op.FiltraBozza("NUMEROCOMMESSA", "" + listaPacchetti[comboBox2.SelectedIndex].Id);
                    dataGridView1.Columns.Remove("TITOLOPACCHETTO");
                    dataGridView1.Columns.Remove("CLIENTE");
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "TITOLOPACCHETTO";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Pacchetto c = op.CercaPacchetto((int)r.Cells[2].Value);
                        r.Cells[7].Value = c.Nome;
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "CLIENTE";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[5].Value);
                        r.Cells[8].Value = c.Nome;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[7].ReadOnly = true;
                    dataGridView1.Columns[8].ReadOnly = true;
                }
                else
                {
                    dataGridView1.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
                    dataGridView1.Columns.Remove("TITOLOPACCHETTO");
                    dataGridView1.Columns.Remove("CLIENTE");
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "TITOLOPACCHETTO";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Pacchetto c = op.CercaPacchetto((int)r.Cells[2].Value);
                        r.Cells[7].Value = c.Nome;
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "CLIENTE";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[5].Value);
                        r.Cells[8].Value = c.Nome;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[7].ReadOnly = true;
                    dataGridView1.Columns[8].ReadOnly = true;
                }
            flag = true;
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
            else if (comboBox1.SelectedItem.Equals("PACCHETTO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Pacchetto.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag)
                    {
                        listaPacchetti.Add(op.CercaPacchetto(c.Pacchetto));
                        comboBox2.Items.Add(op.CercaPacchetto(c.Pacchetto).Nome);
                    }
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
            else if (comboBox1.SelectedItem.Equals("IDENTIFICATIVOPREVENTIVO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.IdentificativoPreventivo.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.IdentificativoPreventivo);
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
    }
}