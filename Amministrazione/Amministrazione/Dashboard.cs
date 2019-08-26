using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class Dashboard : Form
    {
        private readonly string settore;
        private List<Cliente> lista;
        private List<Commessa> listaCommesse;
        private OperazioniAmministrazione op;
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
                op = new OperazioniAmministrazione(settore);
                lista = op.CercaClienti();
                if (lista != null)
                    foreach (var c in lista)
                        listView1.Items.Add(c.Nome);
                listaCommesse = op.CercaCommessa();
                if (listaCommesse != null)
                    foreach (var c in listaCommesse)
                        listView3.Items.Add(c.commessa);
            }
            catch
            {
                MessageBox.Show("Errore Imprevisto Contattare i gestori del servizio");
            }

        }
        private void ListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListaClienti listaClienti = new ListaClienti(settore, this);
                listaClienti.Show();
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

                InserimentoCliente cliente = new InserimentoCliente(settore);
                cliente.Show();
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
            listView1.Visible = false;
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
            listView3.Visible = true;
        }
        private void NascondiListaCommesseToolStripMenuItem_Click(object sender, EventArgs e) => listView3.Visible = false;
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contatti c = new Contatti(lista[listView1.SelectedIndices[0]], settore, this);
            c.Show();
        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var path = Directory.GetCurrentDirectory();
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = path + "/LoginGenerale.exe";
                proc.Start();
            }
            catch
            {
                MessageBox.Show("Login non identificato");
            }
        }

        private void PonteggiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diomede3.InserimentoBozza i = new Diomede3.InserimentoBozza("Ponteggi");
            i.Show();
        }

        private void PraticheEdiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diomede4.InserimentoBozza i = new Diomede4.InserimentoBozza("PraticheEdili");
            i.Show();
        }

        private void CarpenterieMetallicheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diomede5.InserimentoBozza i = new Diomede5.InserimentoBozza("CarpenteriaMetallica");
            i.Show();
        }

        private void PonteggiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Diomede3.InserimentoCliente i = new Diomede3.InserimentoCliente("Ponteggi");
            i.Show();
        }

        private void CarpenteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diomede5.InserimentoCliente i = new Diomede5.InserimentoCliente("CarpenteriaMetallica");
            i.Show();
        }

        private void PraticheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diomede4.InserimentoCliente i = new Diomede4.InserimentoCliente("PraticheEdili");
            i.Show();
        }
    }
}