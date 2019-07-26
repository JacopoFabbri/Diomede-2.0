using Diomede2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PonteggiDiomede
{
    public partial class FiltroCommesse : Form
    {
        private readonly DataGridView dataTable;
        private readonly string db;
        private List<Commessa> lista;
        private readonly List<Cliente> listaClienti = new List<Cliente>();
        private OperazionePraticheEdili op;
        private readonly List<Bozza> listaBozze = new List<Bozza>();
        public FiltroCommesse(DataGridView d, String s)
        {
            dataTable = d;
            db = s;
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("DITTA"))
                dataTable.DataSource = op.FiltraCommessa("" + comboBox1.SelectedItem,
                    "" + listaClienti[comboBox2.SelectedIndex].Id);
            else if (comboBox1.SelectedItem.ToString().Equals("BOZZA"))
            {
                dataTable.DataSource = op.FiltraCommessa("" + comboBox1.SelectedItem,
                    "" + listaBozze[comboBox2.SelectedIndex].Id);
            }
            else
                dataTable.DataSource = op.FiltraBozza("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
            foreach (DataGridViewRow r in dataTable.Rows)
            {
                String s = "" + r.Cells["DataOraInvio"].Value;
                if (!((DateTime)r.Cells["DataOraInvio"].Value).ToString("yyyy/MM/dd hh:mm").Equals("0001-01-01 12:00:00") && !r.Cells["DataOraInvio"].Value.ToString().Equals("01/01/0001 00:00:00"))
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        c.Style.BackColor = Color.Green;
                    }
                }
                else if (((DateTime)r.Cells["DATAESECUZIONE"].Value).ToString("yyyy/MM/dd").Equals(DateTime.Now.ToString("yyyy/MM/dd")))
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        c.Style.BackColor = Color.Yellow;
                    }
                }

            }
        }
        private void FiltroCommesse_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                comboBox1.Items.Add("DITTA");
                comboBox1.Items.Add("NUMEROCOMMESSA");
                comboBox1.Items.Add("DATA");
                comboBox1.Items.Add("REFERENTE");
                comboBox1.Items.Add("INDIRIZZOCANTIERE");
                comboBox1.Items.Add("TECNICOINTERNO");
                comboBox1.Items.Add("NOTE");
                comboBox1.Items.Add("BOZZA");
                comboBox1.Items.Add("DATAESECUZIONE");
                comboBox1.Items.Add("DATARICHIESTACONSEGNA");
                comboBox1.Items.Add("INVIO");
                comboBox1.Items.Add("DATAINVIO");
                comboBox1.Items.Add("NOTEGENERICHE");
                lista = op.CercaCommessa();
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
            if (comboBox1.SelectedItem.Equals("DITTA"))
                foreach (var c in lista)
                {
                    Cliente cliente;
                    cliente = op.CercaClientiId(c.Ditta);
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Ditta.ToString().Equals(o.ToString()))
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
            else if (comboBox1.SelectedItem.Equals("DATA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data.ToString("yyyy/MM/dd").Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data.ToString("yyyy/MM/dd"));
                }
            else if (comboBox1.SelectedItem.Equals("REFERENTE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Referente.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Referente);
                }
            else if (comboBox1.SelectedItem.Equals("INDIRIZZOCANTIERE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.IndirizzoCantiere.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag)
                    {
                        comboBox2.Items.Add(c.IndirizzoCantiere);
                    }
                }
            else if (comboBox1.SelectedItem.Equals("TECNICOINTERNO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.TecnicoInterno.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.TecnicoInterno);
                }
            else if (comboBox1.SelectedItem.Equals("NOTE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Note.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Note);
                }
            else if (comboBox1.SelectedItem.Equals("BOZZA"))
                foreach (var c in lista)
                {
                    Bozza bozza;
                    bozza = op.CercaBozzaId(c.Bozza);
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Bozza.ToString().Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag)
                    {
                        listaBozze.Add(bozza);
                        comboBox2.Items.Add(c.Note);
                    }
                }
            else if (comboBox1.SelectedItem.Equals("DATAESECUZIONE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.DataEsecuzione.ToString("yyyy/MM/dd").Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.DataEsecuzione.ToString("yyyy/MM/dd"));
                }
            else if (comboBox1.SelectedItem.Equals("DATARICHIESTACONSEGNA"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.DataEsecuzione.ToString("yyyy/MM/dd").Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.DataEsecuzione.ToString("yyyy/MM/dd"));
                }
            else if (comboBox1.SelectedItem.Equals("INVIO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Invio.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Invio);
                }
            else if (comboBox1.SelectedItem.Equals("DATAINVIO"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Data.ToString("yyyy/MM/dd hh:mm").Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Data.ToString("yyyy/MM/dd hh:mm"));
                }
            else if (comboBox1.SelectedItem.Equals("NOTEGENERICHE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.NoteGeneriche.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.NoteGeneriche);
                }
        }
    }
}
