﻿using System;
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
    public partial class TIpologieMacrolavorazioni : Form
    {
        readonly String db;
        public TIpologieMacrolavorazioni(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void TIpologieMacrolavorazioni_Load(object sender, EventArgs e)
        {

        }
    }
}
