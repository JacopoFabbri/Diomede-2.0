using System;
using System.Windows.Forms;
using Database;

namespace Diomede2
{
    public partial class ModificaPassword : Form
    {
        private Utente utente;

        public ModificaPassword(Utente u)
        {
            utente = u;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new Operaziones("Utenza");
                utente = op.CercaUtente(utente.Username);
                if (textBox1.Text != null)
                {
                    op.ModificaDatiUtente(utente.Id, utente.Username, textBox1.Text);
                    MessageBox.Show("Inserito con successo", "Login:", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossibile registrare la password!", "Attenzione:", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}