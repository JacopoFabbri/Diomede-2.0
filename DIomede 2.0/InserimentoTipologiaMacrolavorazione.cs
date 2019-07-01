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
    public partial class InserimentoTipologiaMacrolavorazione : Form
    {
        readonly String db;
        public InserimentoTipologiaMacrolavorazione(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperazionePraticheEdili op = new OperazionePraticheEdili(db);
                op.InserimentoTipologiaMacrolavorazione(textBox1.Text, textBox2.Text);
                MessageBox.Show("Tipologia di macrolavorazione Inserita", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
