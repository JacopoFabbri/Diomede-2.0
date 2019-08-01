﻿using Diomede2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpenterieMetallicheDiomede
{
    public partial class InserimentoAcconto : Form
    {
        int id;
        OperazionePraticheEdili op;
        public InserimentoAcconto(int idCommessa)
        {
            id = idCommessa;
            op = new OperazionePraticheEdili("CarpenteriaMetallica");
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoAcconti(Convert.ToDouble(textBox3.Text), textBox1.Text, textBox2.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox4.Text, id);
            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento Riprovare");
            }
        }
    }
}