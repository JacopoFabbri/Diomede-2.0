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

namespace CarpenterieMetallicheDiomede
{
    public partial class InserimentoCommessa : Form
    {
        private readonly string db;
        private readonly ListaBozze formPrecedente;
        private List<Cliente> lista = new List<Cliente>();
        private OperazionePraticheEdili op;

        public InserimentoCommessa(string dbName, ListaBozze lb)
        {
            formPrecedente = lb;
            db = dbName;
            InitializeComponent();
        }

        public InserimentoCommessa(string dbName)
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
                    commessa = op1.GeneraCommessa("CM", listaCliente[listaCliente.Count - 1], "CarpenteriaMetallica", true);
                }
                else
                {
                    commessa = op1.GeneraCommessa("CM", listaAmministrazione[1], "CarpenteriaMetallica", true);
                }

                op.InserimentoCommessa(lista[comboBox1.SelectedIndex].Id, commessa, dateTimePicker1.Value, comboBox2.SelectedItem.ToString(), textBox2.Text, textBox3.Text, textBox5.Text);
                MessageBox.Show("Bozza Inserita", "Inserita:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }

        private void InserimentoBozza_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaClienti();
            foreach (var c in lista) comboBox1.Items.Add(c.Nome);
            comboBox2.Items.Add("Alma");
            comboBox2.Items.Add("Calogero");

        }
    }
}
