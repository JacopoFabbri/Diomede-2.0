using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Dashboard : Form
    {
        private readonly Login formPrecedente;
        private readonly string settore;
        private List<Cliente> lista;
        private List<Bozza> listaBozze;
        private List<Commessa> listaCommesse;
        private OperazionePraticheEdili op;
        public Dashboard(string s, Login f)
        {
            formPrecedente = f;
            settore = s;
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
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
                MessageBox.Show("Errore Imprevisto Contattare i gestori del servizio");
            }

        }
    }
}