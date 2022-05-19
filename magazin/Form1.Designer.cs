
namespace magazin
{
    partial class FStart
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achizitieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arhivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_clienti = new System.Windows.Forms.ToolStripMenuItem();
            this.item_vanzari = new System.Windows.Forms.ToolStripMenuItem();
            this.item_achizitii = new System.Windows.Forms.ToolStripMenuItem();
            this.item_furnizori = new System.Windows.Forms.ToolStripMenuItem();
            this.ietm_calcul_stoc = new System.Windows.Forms.ToolStripMenuItem();
            this.item_balanta_stoc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.furnizorToolStripMenuItem,
            this.achizitieToolStripMenuItem,
            this.vanzareToolStripMenuItem,
            this.arhivaToolStripMenuItem,
            this.operatiiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produsToolStripMenuItem
            // 
            this.produsToolStripMenuItem.Name = "produsToolStripMenuItem";
            this.produsToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.produsToolStripMenuItem.Text = "Produs";
            this.produsToolStripMenuItem.Click += new System.EventHandler(this.produsToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // furnizorToolStripMenuItem
            // 
            this.furnizorToolStripMenuItem.Name = "furnizorToolStripMenuItem";
            this.furnizorToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.furnizorToolStripMenuItem.Text = "Furnizor";
            this.furnizorToolStripMenuItem.Click += new System.EventHandler(this.furnizorToolStripMenuItem_Click);
            // 
            // achizitieToolStripMenuItem
            // 
            this.achizitieToolStripMenuItem.Name = "achizitieToolStripMenuItem";
            this.achizitieToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.achizitieToolStripMenuItem.Text = "Achizitie";
            this.achizitieToolStripMenuItem.Click += new System.EventHandler(this.achizitieToolStripMenuItem_Click);
            // 
            // vanzareToolStripMenuItem
            // 
            this.vanzareToolStripMenuItem.Name = "vanzareToolStripMenuItem";
            this.vanzareToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.vanzareToolStripMenuItem.Text = "Vanzare";
            this.vanzareToolStripMenuItem.Click += new System.EventHandler(this.vanzareToolStripMenuItem_Click);
            // 
            // arhivaToolStripMenuItem
            // 
            this.arhivaToolStripMenuItem.Name = "arhivaToolStripMenuItem";
            this.arhivaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.arhivaToolStripMenuItem.Text = "Arhiva";
            this.arhivaToolStripMenuItem.Click += new System.EventHandler(this.arhivaToolStripMenuItem_Click);
            // 
            // operatiiToolStripMenuItem
            // 
            this.operatiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_clienti,
            this.item_vanzari,
            this.item_achizitii,
            this.item_furnizori,
            this.ietm_calcul_stoc,
            this.item_balanta_stoc});
            this.operatiiToolStripMenuItem.Name = "operatiiToolStripMenuItem";
            this.operatiiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.operatiiToolStripMenuItem.Text = "Operatii";
            // 
            // item_clienti
            // 
            this.item_clienti.Name = "item_clienti";
            this.item_clienti.Size = new System.Drawing.Size(224, 26);
            this.item_clienti.Text = "Statistici Vanzari";
            this.item_clienti.Click += new System.EventHandler(this.item_clienti_Click);
            // 
            // item_vanzari
            // 
            this.item_vanzari.Name = "item_vanzari";
            this.item_vanzari.Size = new System.Drawing.Size(224, 26);
            this.item_vanzari.Text = "Raport vanzari";
            this.item_vanzari.Click += new System.EventHandler(this.item_vanzari_Click);
            // 
            // item_achizitii
            // 
            this.item_achizitii.Name = "item_achizitii";
            this.item_achizitii.Size = new System.Drawing.Size(224, 26);
            this.item_achizitii.Text = "Raport Achitii";
            this.item_achizitii.Click += new System.EventHandler(this.item_achizitii_Click);
            // 
            // item_furnizori
            // 
            this.item_furnizori.Name = "item_furnizori";
            this.item_furnizori.Size = new System.Drawing.Size(224, 26);
            this.item_furnizori.Text = "Statistici achizitii";
            this.item_furnizori.Click += new System.EventHandler(this.item_furnizori_Click);
            // 
            // ietm_calcul_stoc
            // 
            this.ietm_calcul_stoc.Name = "ietm_calcul_stoc";
            this.ietm_calcul_stoc.Size = new System.Drawing.Size(224, 26);
            this.ietm_calcul_stoc.Text = "Calcul stoc";
            this.ietm_calcul_stoc.Click += new System.EventHandler(this.ietm_calcul_stoc_Click);
            // 
            // item_balanta_stoc
            // 
            this.item_balanta_stoc.Name = "item_balanta_stoc";
            this.item_balanta_stoc.Size = new System.Drawing.Size(224, 26);
            this.item_balanta_stoc.Text = "Balanta stoc";
            this.item_balanta_stoc.Click += new System.EventHandler(this.item_balanta_stoc_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(385, 329);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(155, 80);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(452, 20);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Aplicatie pentru evidenta marfurilor dintr-un magazin";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(253, 117);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(182, 17);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor: Vasilescu Rosemarie";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(291, 190);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(63, 17);
            this.lblUtilizator.TabIndex = 4;
            this.lblUtilizator.Text = "Utilizator";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(303, 234);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(49, 17);
            this.lblParola.TabIndex = 5;
            this.lblParola.Text = "Parola";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(385, 190);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(100, 22);
            this.txtUtilizator.TabIndex = 6;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(385, 234);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 22);
            this.txtParola.TabIndex = 7;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FStart";
            this.Text = "FStart";
            this.Load += new System.EventHandler(this.FStart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achizitieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arhivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_clienti;
        private System.Windows.Forms.ToolStripMenuItem item_vanzari;
        private System.Windows.Forms.ToolStripMenuItem item_achizitii;
        private System.Windows.Forms.ToolStripMenuItem item_furnizori;
        private System.Windows.Forms.ToolStripMenuItem ietm_calcul_stoc;
        private System.Windows.Forms.ToolStripMenuItem item_balanta_stoc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
    }
}

