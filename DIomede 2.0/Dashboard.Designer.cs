namespace Diomede2
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciBozzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciPacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneTipologieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macrolavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMacroLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciMacroLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMacroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneEconomicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPagamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView3 = new System.Windows.Forms.ListView();
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
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(151, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(131, 389);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.Visible = false;
            this.listView2.Click += new System.EventHandler(this.ListView2_Click);
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
            this.toolStripMenuItem2});
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
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
            // gestioneBozzeToolStripMenuItem
            // 
            this.gestioneBozzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.pacchettoToolStripMenuItem});
            this.gestioneBozzeToolStripMenuItem.Name = "gestioneBozzeToolStripMenuItem";
            this.gestioneBozzeToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestioneBozzeToolStripMenuItem.Text = "Gestione Bozze";
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaBozzeToolStripMenuItem,
            this.inserisciBozzaToolStripMenuItem,
            this.visualizzaListaBozzeToolStripMenuItem,
            this.nascondiListaBozzeToolStripMenuItem});
            this.aggiungiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
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
            this.visualizzaListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.VisualizzaListaBozzeToolStripMenuItem_Click);
            // 
            // nascondiListaBozzeToolStripMenuItem
            // 
            this.nascondiListaBozzeToolStripMenuItem.Name = "nascondiListaBozzeToolStripMenuItem";
            this.nascondiListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.nascondiListaBozzeToolStripMenuItem.Text = "Nascondi Lista Bozze";
            this.nascondiListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaBozzeToolStripMenuItem_Click);
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
            this.listaPacchettoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaPacchettoToolStripMenuItem.Text = "Lista Pacchetto";
            this.listaPacchettoToolStripMenuItem.Click += new System.EventHandler(this.ListaPacchettoToolStripMenuItem_Click);
            // 
            // inserisciPacchettoToolStripMenuItem
            // 
            this.inserisciPacchettoToolStripMenuItem.Name = "inserisciPacchettoToolStripMenuItem";
            this.inserisciPacchettoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.inserisciPacchettoToolStripMenuItem.Text = "Inserisci Pacchetto";
            this.inserisciPacchettoToolStripMenuItem.Click += new System.EventHandler(this.InserisciPacchettoToolStripMenuItem_Click);
            // 
            // gestioneTipologieToolStripMenuItem
            // 
            this.gestioneTipologieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lavorazioniToolStripMenuItem,
            this.macrolavorazioniToolStripMenuItem});
            this.gestioneTipologieToolStripMenuItem.Name = "gestioneTipologieToolStripMenuItem";
            this.gestioneTipologieToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.gestioneTipologieToolStripMenuItem.Text = "Gestione Tipologie";
            // 
            // lavorazioniToolStripMenuItem
            // 
            this.lavorazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaLavorazioniToolStripMenuItem,
            this.inserisciLavorazioniToolStripMenuItem});
            this.lavorazioniToolStripMenuItem.Name = "lavorazioniToolStripMenuItem";
            this.lavorazioniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lavorazioniToolStripMenuItem.Text = "Lavorazioni";
            // 
            // listaLavorazioniToolStripMenuItem
            // 
            this.listaLavorazioniToolStripMenuItem.Name = "listaLavorazioniToolStripMenuItem";
            this.listaLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listaLavorazioniToolStripMenuItem.Text = "Lista Lavorazioni";
            this.listaLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.ListaLavorazioniToolStripMenuItem_Click);
            // 
            // inserisciLavorazioniToolStripMenuItem
            // 
            this.inserisciLavorazioniToolStripMenuItem.Name = "inserisciLavorazioniToolStripMenuItem";
            this.inserisciLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.inserisciLavorazioniToolStripMenuItem.Text = "Inserisci Lavorazioni";
            this.inserisciLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.InserisciLavorazioniToolStripMenuItem_Click);
            // 
            // macrolavorazioniToolStripMenuItem
            // 
            this.macrolavorazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMacroLavorazioniToolStripMenuItem,
            this.inserisciMacroLavorazioniToolStripMenuItem});
            this.macrolavorazioniToolStripMenuItem.Name = "macrolavorazioniToolStripMenuItem";
            this.macrolavorazioniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.macrolavorazioniToolStripMenuItem.Text = "Macro Lavorazioni";
            // 
            // listaMacroLavorazioniToolStripMenuItem
            // 
            this.listaMacroLavorazioniToolStripMenuItem.Name = "listaMacroLavorazioniToolStripMenuItem";
            this.listaMacroLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.listaMacroLavorazioniToolStripMenuItem.Text = "Lista Macro Lavorazioni";
            this.listaMacroLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.ListaMacroLavorazioniToolStripMenuItem_Click);
            // 
            // inserisciMacroLavorazioniToolStripMenuItem
            // 
            this.inserisciMacroLavorazioniToolStripMenuItem.Name = "inserisciMacroLavorazioniToolStripMenuItem";
            this.inserisciMacroLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.inserisciMacroLavorazioniToolStripMenuItem.Text = "Inserisci Macro Lavorazioni";
            this.inserisciMacroLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.InserisciMacroLavorazioniToolStripMenuItem_Click);
            // 
            // gestioneCommesseToolStripMenuItem
            // 
            this.gestioneCommesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commesseToolStripMenuItem,
            this.macroLavorazioniToolStripMenuItem1});
            this.gestioneCommesseToolStripMenuItem.Name = "gestioneCommesseToolStripMenuItem";
            this.gestioneCommesseToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gestioneCommesseToolStripMenuItem.Text = "Gestione Commesse";
            // 
            // commesseToolStripMenuItem
            // 
            this.commesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCommesseToolStripMenuItem});
            this.commesseToolStripMenuItem.Name = "commesseToolStripMenuItem";
            this.commesseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.commesseToolStripMenuItem.Text = "Commesse";
            // 
            // listaCommesseToolStripMenuItem
            // 
            this.listaCommesseToolStripMenuItem.Name = "listaCommesseToolStripMenuItem";
            this.listaCommesseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listaCommesseToolStripMenuItem.Text = "Lista Commesse";
            this.listaCommesseToolStripMenuItem.Click += new System.EventHandler(this.ListaCommesseToolStripMenuItem_Click);
            // 
            // macroLavorazioniToolStripMenuItem1
            // 
            this.macroLavorazioniToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMacroLavorazioniToolStripMenuItem1});
            this.macroLavorazioniToolStripMenuItem1.Name = "macroLavorazioniToolStripMenuItem1";
            this.macroLavorazioniToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.macroLavorazioniToolStripMenuItem1.Text = "Macro Lavorazioni";
            // 
            // listaMacroLavorazioniToolStripMenuItem1
            // 
            this.listaMacroLavorazioniToolStripMenuItem1.Name = "listaMacroLavorazioniToolStripMenuItem1";
            this.listaMacroLavorazioniToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.listaMacroLavorazioniToolStripMenuItem1.Text = "Lista Macro Lavorazioni";
            this.listaMacroLavorazioniToolStripMenuItem1.Click += new System.EventHandler(this.ListaMacroLavorazioniToolStripMenuItem1_Click);
            // 
            // gestioneEconomicaToolStripMenuItem
            // 
            this.gestioneEconomicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagamentiToolStripMenuItem});
            this.gestioneEconomicaToolStripMenuItem.Name = "gestioneEconomicaToolStripMenuItem";
            this.gestioneEconomicaToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gestioneEconomicaToolStripMenuItem.Text = "Gestione Economica";
            // 
            // pagamentiToolStripMenuItem
            // 
            this.pagamentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPagamentiToolStripMenuItem});
            this.pagamentiToolStripMenuItem.Name = "pagamentiToolStripMenuItem";
            this.pagamentiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pagamentiToolStripMenuItem.Text = "Pagamenti";
            // 
            // listaPagamentiToolStripMenuItem
            // 
            this.listaPagamentiToolStripMenuItem.Name = "listaPagamentiToolStripMenuItem";
            this.listaPagamentiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.listaPagamentiToolStripMenuItem.Text = "Lista Pagamenti";
            this.listaPagamentiToolStripMenuItem.Click += new System.EventHandler(this.ListaPagamentiToolStripMenuItem_Click);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(288, 27);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(131, 389);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 428);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
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
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiClienteToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem lavorazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaLavorazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciLavorazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macrolavorazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaMacroLavorazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciMacroLavorazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macroLavorazioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaMacroLavorazioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagamentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPagamentiToolStripMenuItem;
        private System.Windows.Forms.ListView listView3;
    }
}