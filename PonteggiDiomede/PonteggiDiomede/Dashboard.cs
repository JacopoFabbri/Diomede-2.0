using System;
using System.Collections.Generic;
using System.IO;
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
            catch
            {
                MessageBox.Show("Errore Imprevisto Contattare i gestori del servizio.", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void ListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListaClienti l = new ListaClienti(settore, this);
                l.Show();
            }
            catch
            {
                MessageBox.Show("Errore imprevisto contattare l'assistenza.", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AggiungiClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InserimentoCliente i = new InserimentoCliente(settore);
                i.Show();
            }
            catch
            {
                MessageBox.Show("Errore imprevisto contattare l'assistenza.", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void ListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lB = new ListaBozze(settore, this);
            lB.Show();
        }
        private void InserisciBozzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new InserimentoBozza(settore);
            ib.Show();
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
        private void ListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListaCommesse(settore, this);
            frm.Show();
        }
        private void MostraListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard_Load(sender, e);
            listView3.Visible = true;
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
            if (listView1.SelectedIndices.Count > 0)
            {
                Contatti c = new Contatti(lista[listView1.SelectedIndices[0]], settore, this);
                c.Show();
            }
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
                MessageBox.Show("NON sono riuscito a trovare il file di login","Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}