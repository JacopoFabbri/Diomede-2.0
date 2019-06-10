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
    public partial class ListaLavorazioni : Form
    {
        readonly ListaPacchetto formPrecedente;
        readonly String db;
        readonly int idPacchetto;
        OperazionePraticheEdili op;
        public ListaLavorazioni(ListaPacchetto lp, String dbName, int id)
        {
            idPacchetto = id;
            formPrecedente = lp;
            db = dbName;
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            InserisciLavorazione iL = new InserisciLavorazione(db, this, idPacchetto);
            iL.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                if (riga.Cells[0].Value != null)
                {
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                    {
                        try
                        {
                            op.UpdateLavorazione((int)riga.Cells["ID"].Value, riga.Cells["OPERAZIONE"].Value + "", (int)riga.Cells["PACCHETTO"].Value , (double)riga.Cells["IMPORTO"].Value, riga.Cells["DESC"].Value + "");
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            dataGridView1.DataSource = op.CercaLavorazione();
            dataGridView1.Columns[0].Visible = false;
        }
        private void ListaLavorazioni_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
        }
    }
}
