﻿namespace Diomede2
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contattiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiContattoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneTipologieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneEconomicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciBozzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciPacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(131, 389);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Visible = false;
            this.listView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lista Bozze";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(151, 238);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(131, 178);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.Click += new System.EventHandler(this.ListView2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lista Tipologie Macrolavorazioni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Lista Tipologie Lavorazioni";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(504, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Lista Commesse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(504, 288);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Lista MacroLavorazioni";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(288, 361);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Lista Pagamenti";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.gestioneBozzeToolStripMenuItem,
            this.gestioneTipologieToolStripMenuItem,
            this.gestioneCommesseToolStripMenuItem,
            this.gestioneEconomicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.contattiToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.toolStripMenuItem1.Text = "Gestione Clienti";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientiToolStripMenuItem,
            this.aggiungiClienteToolStripMenuItem,
            this.mostraListaClientiToolStripMenuItem,
            this.nascondiListaClientiToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Ditta";
            // 
            // listaClientiToolStripMenuItem
            // 
            this.listaClientiToolStripMenuItem.Name = "listaClientiToolStripMenuItem";
            this.listaClientiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listaClientiToolStripMenuItem.Text = "Lista Clienti";
            this.listaClientiToolStripMenuItem.Click += new System.EventHandler(this.ListaClientiToolStripMenuItem_Click);
            // 
            // aggiungiClienteToolStripMenuItem
            // 
            this.aggiungiClienteToolStripMenuItem.Name = "aggiungiClienteToolStripMenuItem";
            this.aggiungiClienteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aggiungiClienteToolStripMenuItem.Text = "Aggiungi Cliente";
            this.aggiungiClienteToolStripMenuItem.Click += new System.EventHandler(this.AggiungiClienteToolStripMenuItem_Click);
            // 
            // mostraListaClientiToolStripMenuItem
            // 
            this.mostraListaClientiToolStripMenuItem.Name = "mostraListaClientiToolStripMenuItem";
            this.mostraListaClientiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.mostraListaClientiToolStripMenuItem.Text = "Mostra Lista Clienti";
            this.mostraListaClientiToolStripMenuItem.Click += new System.EventHandler(this.MostraListaClientiToolStripMenuItem_Click);
            // 
            // nascondiListaClientiToolStripMenuItem
            // 
            this.nascondiListaClientiToolStripMenuItem.Name = "nascondiListaClientiToolStripMenuItem";
            this.nascondiListaClientiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nascondiListaClientiToolStripMenuItem.Text = "Nascondi Lista Clienti";
            this.nascondiListaClientiToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaClientiToolStripMenuItem_Click);
            // 
            // contattiToolStripMenuItem
            // 
            this.contattiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiContattoToolStripMenuItem});
            this.contattiToolStripMenuItem.Name = "contattiToolStripMenuItem";
            this.contattiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contattiToolStripMenuItem.Text = "Contatti";
            // 
            // aggiungiContattoToolStripMenuItem
            // 
            this.aggiungiContattoToolStripMenuItem.Name = "aggiungiContattoToolStripMenuItem";
            this.aggiungiContattoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aggiungiContattoToolStripMenuItem.Text = "Aggiungi Contatto";
            // 
            // gestioneBozzeToolStripMenuItem
            // 
            this.gestioneBozzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.pacchettoToolStripMenuItem});
            this.gestioneBozzeToolStripMenuItem.Name = "gestioneBozzeToolStripMenuItem";
            this.gestioneBozzeToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestioneBozzeToolStripMenuItem.Text = "Gestione Bozze";
            // 
            // gestioneTipologieToolStripMenuItem
            // 
            this.gestioneTipologieToolStripMenuItem.Name = "gestioneTipologieToolStripMenuItem";
            this.gestioneTipologieToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.gestioneTipologieToolStripMenuItem.Text = "Gestione Tipologie";
            // 
            // gestioneCommesseToolStripMenuItem
            // 
            this.gestioneCommesseToolStripMenuItem.Name = "gestioneCommesseToolStripMenuItem";
            this.gestioneCommesseToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gestioneCommesseToolStripMenuItem.Text = "Gestione Commesse";
            // 
            // gestioneEconomicaToolStripMenuItem
            // 
            this.gestioneEconomicaToolStripMenuItem.Name = "gestioneEconomicaToolStripMenuItem";
            this.gestioneEconomicaToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gestioneEconomicaToolStripMenuItem.Text = "Gestione Economica";
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaBozzeToolStripMenuItem,
            this.inserisciBozzaToolStripMenuItem,
            this.visualizzaListaBozzeToolStripMenuItem,
            this.nascondiListaBozzeToolStripMenuItem});
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aggiungiToolStripMenuItem.Text = "Bozze";
            this.aggiungiToolStripMenuItem.Click += new System.EventHandler(this.AggiungiToolStripMenuItem_Click);
            // 
            // listaBozzeToolStripMenuItem
            // 
            this.listaBozzeToolStripMenuItem.Name = "listaBozzeToolStripMenuItem";
            this.listaBozzeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.listaBozzeToolStripMenuItem.Text = "Lista Bozze";
            this.listaBozzeToolStripMenuItem.Click += new System.EventHandler(this.ListaBozzeToolStripMenuItem_Click);
            // 
            // inserisciBozzaToolStripMenuItem
            // 
            this.inserisciBozzaToolStripMenuItem.Name = "inserisciBozzaToolStripMenuItem";
            this.inserisciBozzaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.inserisciBozzaToolStripMenuItem.Text = "Inserisci Bozza";
            this.inserisciBozzaToolStripMenuItem.Click += new System.EventHandler(this.InserisciBozzaToolStripMenuItem_Click);
            // 
            // visualizzaListaBozzeToolStripMenuItem
            // 
            this.visualizzaListaBozzeToolStripMenuItem.Name = "visualizzaListaBozzeToolStripMenuItem";
            this.visualizzaListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.visualizzaListaBozzeToolStripMenuItem.Text = "Visualizza Lista Bozze";
            // 
            // nascondiListaBozzeToolStripMenuItem
            // 
            this.nascondiListaBozzeToolStripMenuItem.Name = "nascondiListaBozzeToolStripMenuItem";
            this.nascondiListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.nascondiListaBozzeToolStripMenuItem.Text = "Nascondi Lista Bozze";
            // 
            // pacchettoToolStripMenuItem
            // 
            this.pacchettoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPacchettoToolStripMenuItem,
            this.inserisciPacchettoToolStripMenuItem});
            this.pacchettoToolStripMenuItem.Name = "pacchettoToolStripMenuItem";
            this.pacchettoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pacchettoToolStripMenuItem.Text = "Pacchetto";
            // 
            // listaPacchettoToolStripMenuItem
            // 
            this.listaPacchettoToolStripMenuItem.Name = "listaPacchettoToolStripMenuItem";
            this.listaPacchettoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaPacchettoToolStripMenuItem.Text = "Lista Pacchetto";
            this.listaPacchettoToolStripMenuItem.Click += new System.EventHandler(this.ListaPacchettoToolStripMenuItem_Click);
            // 
            // inserisciPacchettoToolStripMenuItem
            // 
            this.inserisciPacchettoToolStripMenuItem.Name = "inserisciPacchettoToolStripMenuItem";
            this.inserisciPacchettoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserisciPacchettoToolStripMenuItem.Text = "Inserisci Pacchetto";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 428);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contattiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiContattoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraListaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneTipologieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneEconomicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciBozzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaListaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacchettoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPacchettoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciPacchettoToolStripMenuItem;
    }
}