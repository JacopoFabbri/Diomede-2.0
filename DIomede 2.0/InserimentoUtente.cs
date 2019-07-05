using Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoUtente : Form
    {
        private List<Database.Ruolo> lista;
        private Operaziones o;

        public InserimentoUtente()
        {
            InitializeComponent();
        }

        private void InserimentoUtente_Load(object sender, EventArgs e)
        {
            o = new Operaziones("Utenza");
            lista = o.CercaRuolo();
            foreach (var r in lista)
            {
                if (r.ID != 1)
                    comboBox1.Items.Add(r.Nome);

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                o.inserisciUtente(textBox1.Text, textBox2.Text, lista[comboBox1.SelectedIndex].ID);
                MessageBox.Show("Utente Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}