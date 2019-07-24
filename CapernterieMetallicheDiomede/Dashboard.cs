using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Dashboard : Form
    {
        private readonly string settore;
        private List<Cliente> lista;
        private List<Bozza> listaBozze;
        private List<Commessa> listaCommesse;
        private OperazionePraticheEdili op;
        public Dashboard(string s)
        {
            settore = s;
            InitializeComponent();
        }
        public void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                listView1.Clear();
                listView2.Clear();
                listView3.Clear();
                op = new OperazionePraticheEdili(settore);
                lista = op.CercaClienti();
                if (lista != null)
                    foreach (var c in lista)
                        listView1.Items.Add(c.Nome);
                listaBozze = op.CercaBozza();
                if (listaBozze != null)
                    foreach (var c in listaBozze)
                        listView2.Items.Add(c.IdentificativoPreventivo);
                listaCommesse = op.CercaCommessa();
                if (listaCommesse != null)
                    foreach (var c in listaCommesse)
                        listView3.Items.Add(c.NumeroCommessa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore Imprevisto Contattare i gestori del servizio");
            }

        }
        private void ListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Errore imprevisto contattare l'assistenza");
            }
        }
        private void AggiungiClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Errore imprevisto contattare l'assistenza");
            }
        }
        private void MostraListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
        }
        private void NascondiListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
        }
        private void ListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void InserisciBozzaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void VisualizzaListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard_Load(sender, e);
            listView2.Visible = true;
        }
        private void NascondiListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
        }

        private void MostraListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard_Load(sender, e);
            listView2.Visible = true;
        }
        private void NascondiListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contatti c = new Contatti(lista[listView1.SelectedIndices[0]], settore, this);
            c.Show();
        }
    }
}