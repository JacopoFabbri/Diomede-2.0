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
        public InserisciLavorazione(String dbName, ListaLavorazioni ll)
        {
            db = dbName;
            formPrecedente = ll;
            InitializeComponent();
        }

    }
}
