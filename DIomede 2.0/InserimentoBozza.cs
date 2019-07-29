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

        private void TextBox2_Click(object sender, EventArgs e)
        {
            try
            {
                var lp = new ListaPacchetto(db, this, textBox2);
                lp.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                    commessa = op1.GeneraCommessa("PE/B", listaCliente[listaCliente.Count - 1], "PraticheEdili", true);
                }
                else
                {
                    commessa = op1.GeneraCommessa("PE/B", listaAmministrazione[1], "PraticheEdili", true);
                }

                op.InserimentoBozza(dateTimePicker1.Value, textBox2.Text, double.Parse(textBox3.Text), commessa,
                    lista[comboBox1.SelectedIndex].Id, false);
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
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}