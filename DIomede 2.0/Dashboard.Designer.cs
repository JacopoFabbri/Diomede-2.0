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
            this.components = new System.ComponentModel.Container();
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
            this.gestioneTipologieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macrolavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMacroLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciMacroLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciBozzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciPacchettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMacroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneEconomicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPagamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView3 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Location = new System.Drawing.Point(8, 31);
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
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView2.Location = new System.Drawing.Point(291, 31);
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
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.gestioneTipologieToolStripMenuItem,
            this.gestioneBozzeToolStripMenuItem,
            this.gestioneCommesseToolStripMenuItem,
            this.gestioneEconomicaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(785, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripMenuItem1.Image = global::Diomede2.Properties.Resources.icons8_azienda_64;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 23);
            this.toolStripMenuItem1.Text = "Gestione Clienti";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientiToolStripMenuItem,
            this.aggiungiClienteToolStripMenuItem,
            this.mostraListaClientiToolStripMenuItem,
            this.nascondiListaClientiToolStripMenuItem});
            this.toolStripMenuItem2.Image = global::Diomede2.Properties.Resources.icons8_aggiungere_il_contatto_alla_società_481;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem2.Text = "Ditta";
            // 
            // listaClientiToolStripMenuItem
            // 
            this.listaClientiToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaClientiToolStripMenuItem.Name = "listaClientiToolStripMenuItem";
            this.listaClientiToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.listaClientiToolStripMenuItem.Text = "Lista Clienti";
            this.listaClientiToolStripMenuItem.Click += new System.EventHandler(this.ListaClientiToolStripMenuItem_Click);
            // 
            // aggiungiClienteToolStripMenuItem
            // 
            this.aggiungiClienteToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_modifica_utente_uomo_16;
            this.aggiungiClienteToolStripMenuItem.Name = "aggiungiClienteToolStripMenuItem";
            this.aggiungiClienteToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.aggiungiClienteToolStripMenuItem.Text = "Aggiungi Cliente";
            this.aggiungiClienteToolStripMenuItem.Click += new System.EventHandler(this.AggiungiClienteToolStripMenuItem_Click);
            // 
            // mostraListaClientiToolStripMenuItem
            // 
            this.mostraListaClientiToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_apri_libro_64;
            this.mostraListaClientiToolStripMenuItem.Name = "mostraListaClientiToolStripMenuItem";
            this.mostraListaClientiToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.mostraListaClientiToolStripMenuItem.Text = "Mostra Lista Clienti";
            this.mostraListaClientiToolStripMenuItem.Click += new System.EventHandler(this.MostraListaClientiToolStripMenuItem_Click);
            // 
            // nascondiListaClientiToolStripMenuItem
            // 
            this.nascondiListaClientiToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_rimuovi_immagine_48;
            this.nascondiListaClientiToolStripMenuItem.Name = "nascondiListaClientiToolStripMenuItem";
            this.nascondiListaClientiToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.nascondiListaClientiToolStripMenuItem.Text = "Nascondi Lista Clienti";
            this.nascondiListaClientiToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaClientiToolStripMenuItem_Click);
            // 
            // gestioneTipologieToolStripMenuItem
            // 
            this.gestioneTipologieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macrolavorazioniToolStripMenuItem,
            this.lavorazioniToolStripMenuItem});
            this.gestioneTipologieToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestioneTipologieToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_elenco_numerato_64;
            this.gestioneTipologieToolStripMenuItem.Name = "gestioneTipologieToolStripMenuItem";
            this.gestioneTipologieToolStripMenuItem.Size = new System.Drawing.Size(150, 23);
            this.gestioneTipologieToolStripMenuItem.Text = "Gestione Tipologie";
            // 
            // macrolavorazioniToolStripMenuItem
            // 
            this.macrolavorazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMacroLavorazioniToolStripMenuItem,
            this.inserisciMacroLavorazioniToolStripMenuItem});
            this.macrolavorazioniToolStripMenuItem.Name = "macrolavorazioniToolStripMenuItem";
            this.macrolavorazioniToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.macrolavorazioniToolStripMenuItem.Text = "Macro Lavorazioni";
            // 
            // listaMacroLavorazioniToolStripMenuItem
            // 
            this.listaMacroLavorazioniToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaMacroLavorazioniToolStripMenuItem.Name = "listaMacroLavorazioniToolStripMenuItem";
            this.listaMacroLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.listaMacroLavorazioniToolStripMenuItem.Text = "Lista Macro Lavorazioni";
            this.listaMacroLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.ListaMacroLavorazioniToolStripMenuItem_Click);
            // 
            // inserisciMacroLavorazioniToolStripMenuItem
            // 
            this.inserisciMacroLavorazioniToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_inserisci_una_riga_sopra_48;
            this.inserisciMacroLavorazioniToolStripMenuItem.Name = "inserisciMacroLavorazioniToolStripMenuItem";
            this.inserisciMacroLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.inserisciMacroLavorazioniToolStripMenuItem.Text = "Inserisci Macro Lavorazioni";
            this.inserisciMacroLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.InserisciMacroLavorazioniToolStripMenuItem_Click);
            // 
            // lavorazioniToolStripMenuItem
            // 
            this.lavorazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaLavorazioniToolStripMenuItem,
            this.inserisciLavorazioniToolStripMenuItem});
            this.lavorazioniToolStripMenuItem.Name = "lavorazioniToolStripMenuItem";
            this.lavorazioniToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.lavorazioniToolStripMenuItem.Text = "Lavorazioni";
            // 
            // listaLavorazioniToolStripMenuItem
            // 
            this.listaLavorazioniToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaLavorazioniToolStripMenuItem.Name = "listaLavorazioniToolStripMenuItem";
            this.listaLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.listaLavorazioniToolStripMenuItem.Text = "Lista Lavorazioni";
            this.listaLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.ListaLavorazioniToolStripMenuItem_Click);
            // 
            // inserisciLavorazioniToolStripMenuItem
            // 
            this.inserisciLavorazioniToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_pin_3_48;
            this.inserisciLavorazioniToolStripMenuItem.Name = "inserisciLavorazioniToolStripMenuItem";
            this.inserisciLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.inserisciLavorazioniToolStripMenuItem.Text = "Inserisci Lavorazioni";
            this.inserisciLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.InserisciLavorazioniToolStripMenuItem_Click);
            // 
            // gestioneBozzeToolStripMenuItem
            // 
            this.gestioneBozzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.pacchettoToolStripMenuItem});
            this.gestioneBozzeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestioneBozzeToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_modifica_file_48;
            this.gestioneBozzeToolStripMenuItem.Name = "gestioneBozzeToolStripMenuItem";
            this.gestioneBozzeToolStripMenuItem.Size = new System.Drawing.Size(130, 23);
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
            this.aggiungiToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_nessuna_modifica_48;
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.aggiungiToolStripMenuItem.Text = "Bozze";
            // 
            // listaBozzeToolStripMenuItem
            // 
            this.listaBozzeToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaBozzeToolStripMenuItem.Name = "listaBozzeToolStripMenuItem";
            this.listaBozzeToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.listaBozzeToolStripMenuItem.Text = "Lista Bozze";
            this.listaBozzeToolStripMenuItem.Click += new System.EventHandler(this.ListaBozzeToolStripMenuItem_Click);
            // 
            // inserisciBozzaToolStripMenuItem
            // 
            this.inserisciBozzaToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_inserisci_tabella_48;
            this.inserisciBozzaToolStripMenuItem.Name = "inserisciBozzaToolStripMenuItem";
            this.inserisciBozzaToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.inserisciBozzaToolStripMenuItem.Text = "Inserisci Bozza";
            this.inserisciBozzaToolStripMenuItem.Click += new System.EventHandler(this.InserisciBozzaToolStripMenuItem_Click);
            // 
            // visualizzaListaBozzeToolStripMenuItem
            // 
            this.visualizzaListaBozzeToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_apri_libro_64;
            this.visualizzaListaBozzeToolStripMenuItem.Name = "visualizzaListaBozzeToolStripMenuItem";
            this.visualizzaListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.visualizzaListaBozzeToolStripMenuItem.Text = "Visualizza Lista Bozze";
            this.visualizzaListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.VisualizzaListaBozzeToolStripMenuItem_Click);
            // 
            // nascondiListaBozzeToolStripMenuItem
            // 
            this.nascondiListaBozzeToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_rimuovi_immagine_48;
            this.nascondiListaBozzeToolStripMenuItem.Name = "nascondiListaBozzeToolStripMenuItem";
            this.nascondiListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.nascondiListaBozzeToolStripMenuItem.Text = "Nascondi Lista Bozze";
            this.nascondiListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaBozzeToolStripMenuItem_Click);
            // 
            // pacchettoToolStripMenuItem
            // 
            this.pacchettoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPacchettoToolStripMenuItem,
            this.inserisciPacchettoToolStripMenuItem});
            this.pacchettoToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_modifica_casella_100;
            this.pacchettoToolStripMenuItem.Name = "pacchettoToolStripMenuItem";
            this.pacchettoToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.pacchettoToolStripMenuItem.Text = "Pacchetto";
            // 
            // listaPacchettoToolStripMenuItem
            // 
            this.listaPacchettoToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaPacchettoToolStripMenuItem.Name = "listaPacchettoToolStripMenuItem";
            this.listaPacchettoToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.listaPacchettoToolStripMenuItem.Text = "Lista Pacchetto";
            this.listaPacchettoToolStripMenuItem.Click += new System.EventHandler(this.ListaPacchettoToolStripMenuItem_Click);
            // 
            // inserisciPacchettoToolStripMenuItem
            // 
            this.inserisciPacchettoToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_scatola_di_cartone_48;
            this.inserisciPacchettoToolStripMenuItem.Name = "inserisciPacchettoToolStripMenuItem";
            this.inserisciPacchettoToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.inserisciPacchettoToolStripMenuItem.Text = "Inserisci Pacchetto";
            this.inserisciPacchettoToolStripMenuItem.Click += new System.EventHandler(this.InserisciPacchettoToolStripMenuItem_Click);
            // 
            // gestioneCommesseToolStripMenuItem
            // 
            this.gestioneCommesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commesseToolStripMenuItem,
            this.macroLavorazioniToolStripMenuItem1});
            this.gestioneCommesseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestioneCommesseToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_quaderno_48;
            this.gestioneCommesseToolStripMenuItem.Name = "gestioneCommesseToolStripMenuItem";
            this.gestioneCommesseToolStripMenuItem.Size = new System.Drawing.Size(162, 23);
            this.gestioneCommesseToolStripMenuItem.Text = "Gestione Commesse";
            // 
            // commesseToolStripMenuItem
            // 
            this.commesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCommesseToolStripMenuItem,
            this.mostraListaCommesseToolStripMenuItem,
            this.nascondiListaCommesseToolStripMenuItem});
            this.commesseToolStripMenuItem.Name = "commesseToolStripMenuItem";
            this.commesseToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.commesseToolStripMenuItem.Text = "Commesse";
            // 
            // listaCommesseToolStripMenuItem
            // 
            this.listaCommesseToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaCommesseToolStripMenuItem.Name = "listaCommesseToolStripMenuItem";
            this.listaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.listaCommesseToolStripMenuItem.Text = "Lista Commesse";
            this.listaCommesseToolStripMenuItem.Click += new System.EventHandler(this.ListaCommesseToolStripMenuItem_Click);
            // 
            // mostraListaCommesseToolStripMenuItem
            // 
            this.mostraListaCommesseToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_apri_libro_64;
            this.mostraListaCommesseToolStripMenuItem.Name = "mostraListaCommesseToolStripMenuItem";
            this.mostraListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.mostraListaCommesseToolStripMenuItem.Text = "Mostra Lista Commesse";
            this.mostraListaCommesseToolStripMenuItem.Click += new System.EventHandler(this.MostraListaCommesseToolStripMenuItem_Click);
            // 
            // nascondiListaCommesseToolStripMenuItem
            // 
            this.nascondiListaCommesseToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_rimuovi_immagine_48;
            this.nascondiListaCommesseToolStripMenuItem.Name = "nascondiListaCommesseToolStripMenuItem";
            this.nascondiListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.nascondiListaCommesseToolStripMenuItem.Text = "Nascondi Lista Commesse";
            this.nascondiListaCommesseToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaCommesseToolStripMenuItem_Click);
            // 
            // macroLavorazioniToolStripMenuItem1
            // 
            this.macroLavorazioniToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMacroLavorazioniToolStripMenuItem1});
            this.macroLavorazioniToolStripMenuItem1.Name = "macroLavorazioniToolStripMenuItem1";
            this.macroLavorazioniToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.macroLavorazioniToolStripMenuItem1.Text = "Macro Lavorazioni";
            // 
            // listaMacroLavorazioniToolStripMenuItem1
            // 
            this.listaMacroLavorazioniToolStripMenuItem1.Image = global::Diomede2.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaMacroLavorazioniToolStripMenuItem1.Name = "listaMacroLavorazioniToolStripMenuItem1";
            this.listaMacroLavorazioniToolStripMenuItem1.Size = new System.Drawing.Size(222, 24);
            this.listaMacroLavorazioniToolStripMenuItem1.Text = "Lista Macro Lavorazioni";
            this.listaMacroLavorazioniToolStripMenuItem1.Click += new System.EventHandler(this.ListaMacroLavorazioniToolStripMenuItem1_Click);
            // 
            // gestioneEconomicaToolStripMenuItem
            // 
            this.gestioneEconomicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagamentiToolStripMenuItem});
            this.gestioneEconomicaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestioneEconomicaToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_gestione_aziendale_64;
            this.gestioneEconomicaToolStripMenuItem.Name = "gestioneEconomicaToolStripMenuItem";
            this.gestioneEconomicaToolStripMenuItem.Size = new System.Drawing.Size(160, 23);
            this.gestioneEconomicaToolStripMenuItem.Text = "Gestione Economica";
            // 
            // pagamentiToolStripMenuItem
            // 
            this.pagamentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPagamentiToolStripMenuItem});
            this.pagamentiToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_sacco_dei_soldi_16;
            this.pagamentiToolStripMenuItem.Name = "pagamentiToolStripMenuItem";
            this.pagamentiToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.pagamentiToolStripMenuItem.Text = "Pagamenti";
            // 
            // listaPagamentiToolStripMenuItem
            // 
            this.listaPagamentiToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_storico_dei_pagamenti_64;
            this.listaPagamentiToolStripMenuItem.Name = "listaPagamentiToolStripMenuItem";
            this.listaPagamentiToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.listaPagamentiToolStripMenuItem.Text = "Lista Pagamenti";
            this.listaPagamentiToolStripMenuItem.Click += new System.EventHandler(this.ListaPagamentiToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exitToolStripMenuItem.Image = global::Diomede2.Properties.Resources.icons8_eliminare_48;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView3.Location = new System.Drawing.Point(428, 31);
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
            this.ClientSize = new System.Drawing.Size(785, 425);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem mostraListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}