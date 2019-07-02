using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoBozza : Form
    {
        readonly String db;
        readonly ListaBozze formPrecedente;
        OperazionePraticheEdili op;
        List<Cliente> lista = new List<Cliente>();
        public InserimentoBozza(String dbName, ListaBozze lb)
        {
            formPrecedente = lb;
            db = dbName;
            InitializeComponent();
        }
        public InserimentoBozza(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }
        private void TextBox2_Click(object sender, EventArgs e)
        {
            ListaPacchetto lp = new ListaPacchetto(db, this, textBox2);
            lp.Show();
        }
        private void InserimentoBozza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formPrecedente != null)
            {
                formPrecedente.Show();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperazioneAmministrazione op1 = new OperazioneAmministrazione("Amministrazione");
                Cliente c = lista[comboBox1.SelectedIndex];
                List<ClienteAmministrazione> listaAmministrazione = op1.FiltraCliente("NOME", c.Nome);
                if (listaAmministrazione.Count <=  0)
                    op1.InserimentoCliente(c.Nome, c.Tel, c.Email, c.Iva, c.Sdi);
                List<ClienteAmministrazione> listaCliente = op1.CercaCliente();
                String commessa  = op1.GeneraCommessa("PE", listaCliente[listaCliente.Count - 1], "PraticheEdili");

                op.InserimentoBozza(dateTimePicker1.Value, textBox2.Text, Double.Parse(textBox3.Text), commessa, lista[comboBox1.SelectedIndex].Id, false);
                MessageBox.Show("Bozza Inserita", "Inserita:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
            foreach(Cliente c in lista)
            {
                comboBox1.Items.Add(c.Nome);
            }
        }

    }
}
