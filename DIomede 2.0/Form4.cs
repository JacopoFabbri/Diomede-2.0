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
    public partial class Form4 : Form
    {
        String db;
        OperazionePraticheEdili op;
        public Form4(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            dataGridView1.DataSource = op.cercaClienti();

        }
    }
}
