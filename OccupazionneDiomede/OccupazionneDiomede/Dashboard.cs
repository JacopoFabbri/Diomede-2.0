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
        public void Form2_Load(object sender, EventArgs e)
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
        private void ListView1_Click(object sender, EventArgs e)
        {
            var cliente = lista[listView1.SelectedItems[0].Index];
            var frm1 = new Contatti(cliente, settore, this);
            frm1.Show();
        }
        private void ListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListaClienti(settore, this);
            frm.Show();
            Hide();
        }
        private void AggiungiClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new InserimentoCliente(settore);
            frm.Show();
        }
        private void MostraListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
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
       private void ListaContattiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Contatti(null, settore, this);
            frm.Show();
        }
        private void VisualizzaListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
            listView2.Visible = true;
        }
        private void NascondiListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
        }
        private void MostraListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
            listView3.Visible = true;
        }
        private void NascondiListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView3.Visible = false;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = path + "/LoginGenerale.exe";
            proc.Start();
        }
    }
}