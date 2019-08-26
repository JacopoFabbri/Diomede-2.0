using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class ListaCommesse : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazioniAmministrazione op;
        private Boolean flag = false;

        public ListaCommesse(string dbName, Dashboard frm)
        {
            formPrecente = frm;
            db = dbName;
            InitializeComponent();
        }

        private void ListaCommesse_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazioniAmministrazione(db);
                if(op.CercaCommessa() != null)
                {
                    dataGridView1.DataSource = op.CercaCommessa();
                    var col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Preventivo";
                    dataGridView1.Columns.Add(col);
                    foreach(DataGridViewRow r in dataGridView1.Rows)
                    {
                        
                    }

                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!", "Attenzione:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
