using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class FiltroLavorazioni : Form
    {
        private readonly DataGridView dataTable;
        private readonly string db;
        private List<Lavorazione> lista;
        private OperazionePraticheEdili op;

        public FiltroLavorazioni(DataGridView d, string dbName)
        {
            db = dbName;
            dataTable = d;
            InitializeComponent();
        }

        private void FiltroLavorazioni_Load_1(object sender, EventArgs e)
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
                MessageBox.Show("Impossibile accedere a quest'area !!!","Errore:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dataTable.DataSource = op.FiltraLavorazione("" + comboBox1.SelectedItem, "" + comboBox2.SelectedItem);
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("OPERAZIONE"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Operazione.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Operazione);
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

                    if (flag) comboBox2.Items.Add(c.Pacchetto);
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

                    if (flag) comboBox2.Items.Add(c.Importo.ToString());
                }
            else if (comboBox1.SelectedItem.Equals("DESC"))
                foreach (var c in lista)
                {
                    var flag = true;
                    foreach (var o in comboBox2.Items)
                        if (c.Desc.Equals(o.ToString()))
                        {
                            flag = false;
                            break;
                        }

                    if (flag) comboBox2.Items.Add(c.Desc);
                }
        }
    }
}