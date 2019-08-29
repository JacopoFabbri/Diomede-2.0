using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class FiltroBozze : Form
    {
        private readonly DataGridView dataTable;
        private readonly string db;
        private List<Preventivo> lista;
        private readonly List<Cliente> listaClienti = new List<Cliente>();
        private OperazioniAmministrazione op;
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
                op = new OperazioniAmministrazione(db);
                comboBox1.Items.Add("ACCETTAZIONE");
                comboBox1.Items.Add("ANNO");
                comboBox1.Items.Add("CANTIERE");
                comboBox1.Items.Add("CLIENTE");
                comboBox1.Items.Add("COMMESSA");
                comboBox1.Items.Add("COMMESSA COMPLETA");
                comboBox1.Items.Add("DATA ACCETTAZIONE");
                comboBox1.Items.Add("DATA INSERIMENTO");
                comboBox1.Items.Add("DATA INVIO");
                comboBox1.Items.Add("IMPORTO");
                comboBox1.Items.Add("INVIATO");
                comboBox1.Items.Add("NOTE");
                comboBox1.Items.Add("NUMERO");
                comboBox1.Items.Add("SETTORE");
                comboBox1.Items.Add("SETTORE INTERO");
                lista = op.CercaPreventivo();
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
                dataTable.DataSource = op.FiltraPreventivo("" + comboBox1.SelectedItem,
                    "" + listaClienti[comboBox2.SelectedIndex].Id);
            else
                dataTable.DataSource = op.FiltraPreventivo("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
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
            else if (comboBox1.SelectedItem.Equals("COMMESSA COMPLETA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Commessa_Completa.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Commessa_Completa);
                }
            else if (comboBox1.SelectedItem.Equals("DATA ACCETTAZIONE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data_Accettazione.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data_Accettazione);
                }
            else if (comboBox1.SelectedItem.Equals("DATA INVIO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data_Invio.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data_Invio);
                }
            else if (comboBox1.SelectedItem.Equals("INVIATO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Inviato.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Inviato);
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
        }

    }
}