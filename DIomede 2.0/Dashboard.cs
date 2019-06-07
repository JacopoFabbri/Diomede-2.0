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
            op = new OperazionePraticheEdili(settore);
            lista = op.CercaClienti();
            if (lista != null) {
                foreach (Cliente c in lista)
                {
                    listView1.Items.Add(c.Nome);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListaClienti frm = new ListaClienti(settore, this);
            frm.Show();
            this.Hide();
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
    }
}
