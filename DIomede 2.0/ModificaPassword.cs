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
    public partial class ModificaPassword : Form
    {
        Utente utente;
        public ModificaPassword(Utente u)
        {
            utente = u;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Operaziones op = new Operaziones("Utenza");
                utente = op.CercaUtente(utente.Username);
                if (textBox1.Text != null)
                {
                    op.ModificaDatiUtente(utente.Id, utente.Username, textBox1.Text);
                    MessageBox.Show("Inserito con successo", "Login:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossibile registrare la password!", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
