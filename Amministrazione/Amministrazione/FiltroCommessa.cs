using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class FiltroCommessa : Form
    {
        private readonly DataGridView dataTable;
        private readonly string db;
        private List<Commessa> lista;
        private readonly List<Cliente> listaClienti = new List<Cliente>();
        private OperazioniAmministrazione op;
        private bool flag;
        public FiltroCommessa(DataGridView d, string dbName,bool f)
        {
            flag = f;
            db = dbName;
            dataTable = d;
            InitializeComponent();
        }
        private void FiltroCommessa_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazioniAmministrazione(db);
                comboBox1.Items.Add("ACCONTI");
                comboBox1.Items.Add("ANNO");
                comboBox1.Items.Add("CANTIERE");
                comboBox1.Items.Add("CHIUSA");
                comboBox1.Items.Add("CLIENTE");
                comboBox1.Items.Add("COMMESSA");
                comboBox1.Items.Add("DATA CHIUSURA");
                comboBox1.Items.Add("DATA FATTURA");
                comboBox1.Items.Add("DATA INSERIMENTO");
                comboBox1.Items.Add("FATTURATA");
                comboBox1.Items.Add("IMPORTO");
                comboBox1.Items.Add("NOTE");
                comboBox1.Items.Add("NUMERO");
                comboBox1.Items.Add("PAGAMENTI");
                comboBox1.Items.Add("PREVENTIVO");
                comboBox1.Items.Add("SETTORE INTERO");
                comboBox1.Items.Add("SETTORE");
                lista = op.CercaCommessa();
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            dataTable.Columns.Remove("ID_Commessa");
            dataTable.Columns.Remove("Cliente");
            if (comboBox1.SelectedItem.ToString().Equals("CLIENTE"))
                dataTable.DataSource = op.FiltraCommessa("" + comboBox1.SelectedItem,
                    "" + listaClienti[comboBox2.SelectedIndex].Id);
            else
                dataTable.DataSource = op.FiltraCommessa("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);

            var col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "Commessa";
            dataTable.Columns.Add(col);
            foreach (DataGridViewRow r in dataTable.Rows)
            {
                if (op.CercaCommessa((int)r.Cells[5].Value) == null)
                {

                }
                else
                {
                    Commessa c = op.CercaCommessa((int)r.Cells[5].Value);
                    r.Cells[17].Value = c.ID_Commessa;
                }
            }
            col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "Cliente";
            dataTable.Columns.Add(col);
            foreach (DataGridViewRow r in dataTable.Rows)
            {
                Cliente c = op.CercaClientiId((int)r.Cells[6].Value);
                r.Cells[18].Value = c.Nome;
            }
            dataTable.Columns[0].Visible = false;
            dataTable.Columns[5].Visible = false;
            dataTable.Columns[6].Visible = false;
            dataTable.Columns[16].ReadOnly = true;
            dataTable.Columns[17].ReadOnly = true;
            flag = true;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("DATA INSERIMENTO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data_Inserimento.ToString("yyyy-MM-dd").Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data_Inserimento.ToString("yyyy-MM-dd"));
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
            else if (comboBox1.SelectedItem.Equals("NUMERO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Numero.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Importo);
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
            else if (comboBox1.SelectedItem.Equals("ACCONTI"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Acconti.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Acconti);
                }
            else if (comboBox1.SelectedItem.Equals("ANNO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Anno.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Anno);
                }
            else if (comboBox1.SelectedItem.Equals("CANTIERE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Cantiere.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Cantiere);
                }
            else if (comboBox1.SelectedItem.Equals("COMMESSA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.ID_Commessa.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.ID_Commessa);
                }
            else if (comboBox1.SelectedItem.Equals("PREVENTIVO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Preventivo.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Preventivo);
                }
            else if (comboBox1.SelectedItem.Equals("DATA CHIUSURA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data_Chiusura.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data_Chiusura);
                }
            else if (comboBox1.SelectedItem.Equals("DATA FATTURA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data_Fattura.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data_Fattura);
                }
            else if (comboBox1.SelectedItem.Equals("CHIUSA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Chiusa.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Chiusa);
                }
            else if (comboBox1.SelectedItem.Equals("NOTE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Note.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Note);
                }
            else if (comboBox1.SelectedItem.Equals("SETTORE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Settore.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Settore);
                }
            else if (comboBox1.SelectedItem.Equals("SETTORE INTERO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Settore_Intero.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Settore_Intero);
                }
            else if (comboBox1.SelectedItem.Equals("FATTURATA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Fatturata.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Fatturata);
                }
            else if (comboBox1.SelectedItem.Equals("PAGAMENTI"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Pagamenti.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Pagamenti);
                }
        }

    }
}