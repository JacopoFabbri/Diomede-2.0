using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoLavorazioni : Form
    {
        readonly ListaLavorazione formPrecedente;
        readonly String db;
        List<MacroLavorazione> lista;
        OperazionePraticheEdili op;
        int id;
        public InserimentoLavorazioni(String dbName, ListaLavorazione ll, int idMacroLavorazione)
        {
            id = idMacroLavorazione;
            db = dbName;
            formPrecedente = ll;
            InitializeComponent();
        }
        public InserimentoLavorazioni(String dbName, int idMacroLavorazione)
        {
            id = idMacroLavorazione;
            db = dbName;
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
                op.InserimentoLavorazioni(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text),Convert.ToDouble(textBox5.Text));
                MessageBox.Show("Lavorazione Inserita", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (formPrecedente != null)
                {
                    formPrecedente.ListaLavorazione_Load(sender, e);
                }
                }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }


    }
}
