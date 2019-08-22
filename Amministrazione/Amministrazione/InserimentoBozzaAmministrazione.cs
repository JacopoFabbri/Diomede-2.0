using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class InserimentoBozzaAmministrazione : Form
    {
        private readonly string db;
        private readonly ListaBozze formPrecedente;
        private List<Cliente> lista = new List<Cliente>();
        private OperazioniAmministrazione op;
        public InserimentoBozzaAmministrazione(string dbName, ListaBozze lb)
        {
            formPrecedente = lb;
            db = dbName;
            InitializeComponent();
        }
        public InserimentoBozzaAmministrazione(string dbName)
        {
            db = dbName;
            InitializeComponent();
        }
        private void InserimentoBozza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formPrecedente != null) formPrecedente.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
        }
        private void InserimentoBozza_Load(object sender, EventArgs e)
        {
            op = new OperazioniAmministrazione(db);
            lista = op.CercaClienti();
            foreach (var c in lista) comboBox1.Items.Add(c.Nome);
            comboBox2.Items.Add("Nuovo");
            comboBox2.Items.Add("Agg-");
            for (int i = 1; i < 30; i++)
            {
                comboBox3.Items.Add(i + "");
            }
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString().Equals("Agg-"))
            {
                comboBox3.Visible = true;
            }
            else
            {
                comboBox3.Visible = false;
            }
        }
    }
}