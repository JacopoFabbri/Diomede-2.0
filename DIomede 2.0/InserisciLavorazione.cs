using System;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserisciLavorazione : Form
    {
        private readonly string db;
        private readonly ListaLavorazioni formPrecedente;
        private readonly int id;
        private OperazionePraticheEdili op;

        public InserisciLavorazione(string dbName, ListaLavorazioni ll, int idPacchetto)
        {
            id = idPacchetto;
            db = dbName;
            formPrecedente = ll;
            InitializeComponent();
        }

        private void InserisciLavorazione_Load(object sender, EventArgs e)
        {
            textBox2.Text = "" + id;
            op = new OperazionePraticheEdili(db);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoLavorazione(textBox1.Text, int.Parse(textBox2.Text), double.Parse(textBox3.Text),
                    textBox5.Text);
                MessageBox.Show("Lavorazione Inserita", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                formPrecedente.ListaLavorazioni_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }
    }
}