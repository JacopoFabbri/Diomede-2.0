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
        public Form2(String s, Utente u)
        {
            settore = s;
            user = u;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(settore);
            List<Cliente> lista = op.cercaClienti();
            if (lista != null) {
                foreach (Cliente c in lista)
                {
                    listView1.Items.Add(c.Nome);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(settore);
            frm.Show();
        }
    }
}
