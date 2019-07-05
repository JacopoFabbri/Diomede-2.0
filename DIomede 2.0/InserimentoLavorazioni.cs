using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoLavorazioni : Form
    {
        private readonly string db;
        private readonly ListaLavorazione formPrecedente;
        private readonly int id;
        private List<MacroLavorazione> lista;
        private OperazionePraticheEdili op;

        public InserimentoLavorazioni(string dbName, ListaLavorazione ll, int idMacroLavorazione)
        {
            id = idMacroLavorazione;
            db = dbName;
            formPrecedente = ll;
            InitializeComponent();
        }

        private void InserimentoLavorazioni_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaMacroLavorazione();
            textBox4.Text = "" + id;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoLavorazioni(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text),
                    Convert.ToDouble(textBox5.Text));
                MessageBox.Show("Lavorazione Inserita", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                formPrecedente.ListaLavorazione_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }
    }
}