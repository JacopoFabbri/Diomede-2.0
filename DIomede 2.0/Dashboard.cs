using Database;
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
    public partial class Dashboard : Form
    {
        private readonly String settore;
        private OperazionePraticheEdili op;
        private List<Cliente> lista;
        private List<Bozza> listaBozze;
        private List<Commessa> listaCommesse;
        private readonly Login formPrecedente;
        public Dashboard(String s, Login f)
        {
            formPrecedente = f;
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
            {
                foreach (Cliente c in lista)
                {
                    listView1.Items.Add(c.Nome);
                }
            }
            listaBozze = op.CercaBozza();
            if (listaBozze != null)
            {
                foreach (Bozza c in listaBozze)
                {
                    listView2.Items.Add(c.NumeroCommessa);
                }
            }
            listaCommesse = op.CercaCommessa();
            if (listaCommesse != null)
            {
                foreach (Commessa c in listaCommesse)
                {
                    listView3.Items.Add(c.NumeroCommessa);
                }
            }
        }
        private void ListView1_Click(object sender, EventArgs e)
        {
            Cliente cliente = lista[listView1.SelectedItems[0].Index];
            Contatti frm1 = new Contatti(cliente, settore, this);
            frm1.Show();

        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrecedente.Show();
        }

        private void ListView2_Click(object sender, EventArgs e)
        {
            Bozza bozza = listaBozze[listView2.SelectedItems[0].Index];
            ListaLavorazioni frm1 = new ListaLavorazioni(settore, bozza.Pacchetto);
            frm1.Show();

        }

        private void ListaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClienti frm = new ListaClienti(settore, this);
            frm.Show();
            this.Hide();
        }

        private void AggiungiClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoCliente frm = new InserimentoCliente(settore);
            frm.Show();
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
            ListaBozze lB = new ListaBozze(settore, this);
            lB.Show();
        }

        private void InserisciBozzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoBozza ib = new InserimentoBozza(settore);
            ib.Show();
        }

        private void ListaPacchettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPacchetto lp = new ListaPacchetto(settore);
            lp.Show();
        }

        private void InserisciPacchettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserisciPacchetto iP = new InserisciPacchetto(settore);
            iP.Show();
        }

        private void ListaLavorazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTipoogiaLavorazioni frm = new ListaTipoogiaLavorazioni(settore);
            frm.Show();
        }

        private void InserisciLavorazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserisciTipologiaLavorazione iL = new InserisciTipologiaLavorazione(settore);
            iL.Show();
        }

        private void ListaMacroLavorazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipologieMacrolavorazioni frm = new TipologieMacrolavorazioni(settore);
            frm.Show();
        }
        private void InserisciMacroLavorazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoTipologiaMacrolavorazione frm = new InserimentoTipologiaMacrolavorazione(settore);
            frm.Show();
        }

        private void ListaContattiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contatti frm = new Contatti(null, settore, this);
            frm.Show();
        }

        private void VisualizzaListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
        }

        private void NascondiListaBozzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
        }

        private void ListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCommesse frm = new ListaCommesse(settore, this);
            frm.Show();
        }

        private void ListaMacroLavorazioniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaMacroLavorazioni frm = new ListaMacroLavorazioni(settore);
            frm.Show();
        }

        private void ListaPagamentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPagamenti frm = new ListaPagamenti(settore);
            frm.Show();
        }

        private void MostraListaCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
