namespace Amministrazione
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
            this.bozzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bozzaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciBozzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView3 = new System.Windows.Forms.ListView();
            this.preventivoPraticheDiomedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciPreventivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Location = new System.Drawing.Point(8, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(131, 391);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView2.Location = new System.Drawing.Point(145, 30);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(131, 391);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.bozzaToolStripMenuItem,
            this.gestioneCommesseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(806, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 25);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 26);
            this.toolStripMenuItem2.Text = "Ditta";
            // 
            // listaClientiToolStripMenuItem
            // 
            this.listaClientiToolStripMenuItem.Name = "listaClientiToolStripMenuItem";
            this.listaClientiToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listaClientiToolStripMenuItem.Text = "Lista Clienti";
            this.listaClientiToolStripMenuItem.Click += new System.EventHandler(this.ListaClientiToolStripMenuItem_Click);
            // 
            // aggiungiClienteToolStripMenuItem
            // 
            this.aggiungiClienteToolStripMenuItem.Name = "aggiungiClienteToolStripMenuItem";
            this.aggiungiClienteToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aggiungiClienteToolStripMenuItem.Text = "Aggiungi Cliente";
            this.aggiungiClienteToolStripMenuItem.Click += new System.EventHandler(this.AggiungiClienteToolStripMenuItem_Click);
            // 
            // mostraListaClientiToolStripMenuItem
            // 
            this.mostraListaClientiToolStripMenuItem.Name = "mostraListaClientiToolStripMenuItem";
            this.mostraListaClientiToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.mostraListaClientiToolStripMenuItem.Text = "Mostra Lista Clienti";
            this.mostraListaClientiToolStripMenuItem.Click += new System.EventHandler(this.MostraListaClientiToolStripMenuItem_Click);
            // 
            // nascondiListaClientiToolStripMenuItem
            // 
            this.nascondiListaClientiToolStripMenuItem.Name = "nascondiListaClientiToolStripMenuItem";
            this.nascondiListaClientiToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.nascondiListaClientiToolStripMenuItem.Text = "Nascondi Lista Clienti";
            this.nascondiListaClientiToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaClientiToolStripMenuItem_Click);
            // 
            // bozzaToolStripMenuItem
            // 
            this.bozzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bozzaToolStripMenuItem1,
            this.preventivoPraticheDiomedeToolStripMenuItem});
            this.bozzaToolStripMenuItem.Name = "bozzaToolStripMenuItem";
            this.bozzaToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.bozzaToolStripMenuItem.Text = "Gestione Preventivi";
            // 
            // bozzaToolStripMenuItem1
            // 
            this.bozzaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaBozzeToolStripMenuItem,
            this.inserisciBozzaToolStripMenuItem,
            this.mostraListaBozzeToolStripMenuItem,
            this.nascondiListaBozzeToolStripMenuItem});
            this.bozzaToolStripMenuItem1.Name = "bozzaToolStripMenuItem1";
            this.bozzaToolStripMenuItem1.Size = new System.Drawing.Size(281, 26);
            this.bozzaToolStripMenuItem1.Text = "Preventivo";
            // 
            // listaBozzeToolStripMenuItem
            // 
            this.listaBozzeToolStripMenuItem.Name = "listaBozzeToolStripMenuItem";
            this.listaBozzeToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.listaBozzeToolStripMenuItem.Text = "Lista Preventivi";
            // 
            // inserisciBozzaToolStripMenuItem
            // 
            this.inserisciBozzaToolStripMenuItem.Name = "inserisciBozzaToolStripMenuItem";
            this.inserisciBozzaToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.inserisciBozzaToolStripMenuItem.Text = "Inserisci Preventivo";
            // 
            // mostraListaBozzeToolStripMenuItem
            // 
            this.mostraListaBozzeToolStripMenuItem.Name = "mostraListaBozzeToolStripMenuItem";
            this.mostraListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.mostraListaBozzeToolStripMenuItem.Text = "Mostra lista Preventivi";
            this.mostraListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.VisualizzaListaBozzeToolStripMenuItem_Click);
            // 
            // nascondiListaBozzeToolStripMenuItem
            // 
            this.nascondiListaBozzeToolStripMenuItem.Name = "nascondiListaBozzeToolStripMenuItem";
            this.nascondiListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.nascondiListaBozzeToolStripMenuItem.Text = "Nascondi lista Preventivi";
            this.nascondiListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaBozzeToolStripMenuItem_Click);
            // 
            // gestioneCommesseToolStripMenuItem
            // 
            this.gestioneCommesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commesseToolStripMenuItem});
            this.gestioneCommesseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioneCommesseToolStripMenuItem.Name = "gestioneCommesseToolStripMenuItem";
            this.gestioneCommesseToolStripMenuItem.Size = new System.Drawing.Size(164, 25);
            this.gestioneCommesseToolStripMenuItem.Text = "Gestione Commesse";
            // 
            // commesseToolStripMenuItem
            // 
            this.commesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCommesseToolStripMenuItem,
            this.mostraListaCommesseToolStripMenuItem,
            this.nascondiListaCommesseToolStripMenuItem});
            this.commesseToolStripMenuItem.Name = "commesseToolStripMenuItem";
            this.commesseToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.commesseToolStripMenuItem.Text = "Commesse";
            // 
            // listaCommesseToolStripMenuItem
            // 
            this.listaCommesseToolStripMenuItem.Name = "listaCommesseToolStripMenuItem";
            this.listaCommesseToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.listaCommesseToolStripMenuItem.Text = "Lista Commesse";
            // 
            // mostraListaCommesseToolStripMenuItem
            // 
            this.mostraListaCommesseToolStripMenuItem.Name = "mostraListaCommesseToolStripMenuItem";
            this.mostraListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.mostraListaCommesseToolStripMenuItem.Text = "Mostra Lista Commesse";
            this.mostraListaCommesseToolStripMenuItem.Click += new System.EventHandler(this.MostraListaCommesseToolStripMenuItem_Click);
            // 
            // nascondiListaCommesseToolStripMenuItem
            // 
            this.nascondiListaCommesseToolStripMenuItem.Name = "nascondiListaCommesseToolStripMenuItem";
            this.nascondiListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.nascondiListaCommesseToolStripMenuItem.Text = "Nascondi Lista Commesse";
            this.nascondiListaCommesseToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaCommesseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView3.Location = new System.Drawing.Point(282, 30);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(131, 391);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.Visible = false;
            // 
            // preventivoPraticheDiomedeToolStripMenuItem
            // 
            this.preventivoPraticheDiomedeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciPreventivoToolStripMenuItem});
            this.preventivoPraticheDiomedeToolStripMenuItem.Name = "preventivoPraticheDiomedeToolStripMenuItem";
            this.preventivoPraticheDiomedeToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.preventivoPraticheDiomedeToolStripMenuItem.Text = "Preventivo Pratiche Diomede";
            // 
            // inserisciPreventivoToolStripMenuItem
            // 
            this.inserisciPreventivoToolStripMenuItem.Name = "inserisciPreventivoToolStripMenuItem";
            this.inserisciPreventivoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.inserisciPreventivoToolStripMenuItem.Text = "Inserisci Preventivo";
            this.inserisciPreventivoToolStripMenuItem.Click += new System.EventHandler(this.InserisciPreventivoToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 427);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
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
        private System.Windows.Forms.ToolStripMenuItem gestioneCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ToolStripMenuItem bozzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bozzaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciBozzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraListaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preventivoPraticheDiomedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciPreventivoToolStripMenuItem;
    }
}