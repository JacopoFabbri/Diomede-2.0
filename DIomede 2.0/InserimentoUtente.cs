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
    public partial class InserimentoUtente : Form
    {
        List<Database.Ruolo> lista;
        Operaziones o;
        public InserimentoUtente()
        {
            InitializeComponent();
        }

        private void InserimentoUtente_Load(object sender, EventArgs e)
        {
            o = new Operaziones("Utenza");
            lista = o.CercaRuolo();
            foreach(Database.Ruolo r in lista)
            {
                comboBox1.Items.Add(r.Nome);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            o = new Operaziones("Utenza");
            try
            {
                o.inserisciUtente(textBox1.Text, textBox2.Text, lista[comboBox1.SelectedIndex].ID);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
    }
}
