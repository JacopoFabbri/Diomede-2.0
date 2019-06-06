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
    public partial class Form2 : Form
    {
        private String settore;
        private Utente user;
        private OperazionePraticheEdili op;
        private List<Cliente> lista;
        private Form1 formPrecedente;
        public Form2(String s, Utente u, Form1 f)
        {
            formPrecedente = f;
            settore = s;
            user = u;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(settore);
            lista = op.cercaClienti();
            if (lista != null) {
                foreach (Cliente c in lista)
                {
                    listView1.Items.Add(c.Nome);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(settore, this);
            frm.Show();
            this.Hide();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            Cliente cliente = lista[listView1.SelectedItems[0].Index];
            Form7 frm1 = new Form7(cliente, settore, this);
            frm1.Show();
            Form5 frm = new Form5(cliente, settore);
            frm.Show();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrecedente.Show();
        }
    }
}
