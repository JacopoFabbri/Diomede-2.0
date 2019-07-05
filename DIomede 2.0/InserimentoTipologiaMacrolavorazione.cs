using System;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoTipologiaMacrolavorazione : Form
    {
        private readonly string db;

        public InserimentoTipologiaMacrolavorazione(string dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new OperazionePraticheEdili(db);
                op.InserimentoTipologiaMacrolavorazione(textBox1.Text, textBox2.Text);
                MessageBox.Show("Tipologia di macrolavorazione Inserita", "Inserito", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }

        private void InserimentoTipologiaMacrolavorazione_Load(object sender, EventArgs e)
        {
        }
    }
}