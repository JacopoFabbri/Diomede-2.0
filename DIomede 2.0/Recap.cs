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
    public partial class Recap : Form
    {
        String db;
        int idCommessa;
        OperazionePraticheEdili op;
        List<Cliente> lista;
        Commessa commessa;
        public Recap(String dbName, int id)
        {
            db = dbName;
            idCommessa = id;
            InitializeComponent();
        }

        private void Recap_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            commessa = op.CercaCommessa(idCommessa);
            textBox1.Text = "" + commessa.Id;
            textBox2.Text = op.CercaClientiId(commessa.Ditta).Nome;
            List<MacroLavorazione> listaMacrolavorazione = op.FiltraMacroLavorazione("COMMESSA","" + commessa.Id);
            String s = "";
            foreach(MacroLavorazione m in listaMacrolavorazione)
            {
                s += m.Nome + "\n";
            }
            textBox3.Text = s;
        }
    }
}
