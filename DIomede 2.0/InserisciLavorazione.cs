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
    public partial class InserisciLavorazione : Form
    {
        readonly ListaLavorazioni formPrecedente;
        readonly String db;
        int id;
        OperazionePraticheEdili op;
        public InserisciLavorazione(String dbName, ListaLavorazioni ll, int idPacchetto)
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
                op.InserimentoLavorazione(textBox1.Text,int.Parse(textBox2.Text),double.Parse(textBox3.Text),textBox5.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Errore nella compilazione campi \nriprovare ad inserire tutti i dati");
            }
        }
    }
}