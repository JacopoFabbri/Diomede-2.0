using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class visualizzatore : Form
    {
        private readonly DataGridViewCell data;
        private readonly string db;
        private readonly int id;
        private OperazioniAmministrazione op;
        public visualizzatore(string s, int id, DataGridViewCell dg)
        {
            this.id = id;
            data = dg;
            db = s;
            InitializeComponent();
        }
        private void Visualizzatore_Load(object sender, EventArgs e)
        {
            op = new OperazioniAmministrazione(db);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}