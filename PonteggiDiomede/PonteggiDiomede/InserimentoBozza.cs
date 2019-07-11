using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoBozza : Form
    {
        private readonly string db;
        private readonly ListaBozze formPrecedente;
        private List<Cliente> lista = new List<Cliente>();
        private OperazionePraticheEdili op;

        public InserimentoBozza(string dbName, ListaBozze lb)
        {
            formPrecedente = lb;
            db = dbName;
            InitializeComponent();
        }

        public InserimentoBozza(string dbName)
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
            try
            {
                var op1 = new OperazioneAmministrazione("Amministrazione");
                var c = lista[comboBox1.SelectedIndex];
                var listaAmministrazione = op1.FiltraCliente("NOME", c.Nome);
                if (listaAmministrazione.Count <= 0)
                    op1.InserimentoCliente(c.Nome, c.Tel, c.Email, c.Iva, c.Sdi);
                var listaCliente = op1.CercaCliente();
                string commessa;
                if (listaAmministrazione.Count <= 0)
                {
                    op1.InserimentoCliente(c.Nome, c.Tel, c.Email, c.Iva, c.Sdi);
                    listaCliente = op1.CercaCliente();
                    commessa = op1.GeneraCommessa("PO/B", listaCliente[listaCliente.Count - 1], "PraticheEdili", true);
                }
                else
                {
                    commessa = op1.GeneraCommessa("PO/B", listaAmministrazione[1], "PraticheEdili", true);
                }

                op.InserimentoBozza(dateTimePicker1.Value, double.Parse(textBox1.Text), comboBox2.SelectedItem.ToString() + comboBox3.SelectedItem.ToString(), commessa,
                    lista[comboBox1.SelectedIndex].Id, false); ;
                MessageBox.Show("Bozza Inserita", "Inserita:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }

        private void InserimentoBozza_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaClienti();
            foreach (var c in lista) comboBox1.Items.Add(c.Nome);
            comboBox2.Items.Add("Nuovo");
            comboBox2.Items.Add("Agg-");
            for(int i = 1; i < 30; i++)
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