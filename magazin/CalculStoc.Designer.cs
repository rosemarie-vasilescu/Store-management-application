
namespace magazin
{
    partial class CalculStoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculStocDS = new magazin.CalculStocDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.stocProduseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStocInitial = new System.Windows.Forms.Button();
            this.btnAchizitii = new System.Windows.Forms.Button();
            this.btnVanzari = new System.Windows.Forms.Button();
            this.btnStocFinal = new System.Windows.Forms.Button();
            this.txtFiltru = new System.Windows.Forms.TextBox();
            this.calculStocTableAdapter = new magazin.CalculStocDSTableAdapters.CalculStocTableAdapter();
            this.stocProduseTableAdapter = new magazin.CalculStocDSTableAdapters.StocProduseTableAdapter();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocProduseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.dOperatieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculStocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 685);
            this.dataGridView1.TabIndex = 0;
            // 
            // calculStocBindingSource
            // 
            this.calculStocBindingSource.DataMember = "CalculStoc";
            this.calculStocBindingSource.DataSource = this.calculStocDS;
            // 
            // calculStocDS
            // 
            this.calculStocDS.DataSetName = "CalculStocDS";
            this.calculStocDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdusDataGridViewTextBoxColumn1,
            this.dProdusDataGridViewTextBoxColumn1,
            this.uMDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.stocProduseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1106, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(584, 629);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // stocProduseBindingSource
            // 
            this.stocProduseBindingSource.DataMember = "StocProduse";
            this.stocProduseBindingSource.DataSource = this.calculStocDS;
            this.stocProduseBindingSource.CurrentChanged += new System.EventHandler(this.stocProduseBindingSource_CurrentChanged);
            // 
            // btnStocInitial
            // 
            this.btnStocInitial.Location = new System.Drawing.Point(931, 101);
            this.btnStocInitial.Name = "btnStocInitial";
            this.btnStocInitial.Size = new System.Drawing.Size(150, 23);
            this.btnStocInitial.TabIndex = 2;
            this.btnStocInitial.Text = "Stoc Initial";
            this.btnStocInitial.UseVisualStyleBackColor = true;
            this.btnStocInitial.Click += new System.EventHandler(this.btnStocInitial_Click);
            // 
            // btnAchizitii
            // 
            this.btnAchizitii.Location = new System.Drawing.Point(931, 157);
            this.btnAchizitii.Name = "btnAchizitii";
            this.btnAchizitii.Size = new System.Drawing.Size(150, 23);
            this.btnAchizitii.TabIndex = 3;
            this.btnAchizitii.Text = "Achizitii";
            this.btnAchizitii.UseVisualStyleBackColor = true;
            this.btnAchizitii.Click += new System.EventHandler(this.btnAchizitii_Click);
            // 
            // btnVanzari
            // 
            this.btnVanzari.Location = new System.Drawing.Point(931, 228);
            this.btnVanzari.Name = "btnVanzari";
            this.btnVanzari.Size = new System.Drawing.Size(150, 23);
            this.btnVanzari.TabIndex = 4;
            this.btnVanzari.Text = "Vanzari";
            this.btnVanzari.UseVisualStyleBackColor = true;
            this.btnVanzari.Click += new System.EventHandler(this.btnVanzari_Click);
            // 
            // btnStocFinal
            // 
            this.btnStocFinal.Location = new System.Drawing.Point(931, 295);
            this.btnStocFinal.Name = "btnStocFinal";
            this.btnStocFinal.Size = new System.Drawing.Size(150, 23);
            this.btnStocFinal.TabIndex = 5;
            this.btnStocFinal.Text = "Stoc final";
            this.btnStocFinal.UseVisualStyleBackColor = true;
            this.btnStocFinal.Click += new System.EventHandler(this.btnStocFinal_Click);
            // 
            // txtFiltru
            // 
            this.txtFiltru.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocProduseBindingSource, "IdProdus", true));
            this.txtFiltru.Location = new System.Drawing.Point(1106, 13);
            this.txtFiltru.Name = "txtFiltru";
            this.txtFiltru.Size = new System.Drawing.Size(100, 22);
            this.txtFiltru.TabIndex = 6;
            this.txtFiltru.TextChanged += new System.EventHandler(this.txtFiltru_TextChanged);
            // 
            // calculStocTableAdapter
            // 
            this.calculStocTableAdapter.ClearBeforeFill = true;
            // 
            // stocProduseTableAdapter
            // 
            this.stocProduseTableAdapter.ClearBeforeFill = true;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            this.idOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn.Width = 2;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            this.dProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.dProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOperatieDataGridViewTextBoxColumn
            // 
            this.dOperatieDataGridViewTextBoxColumn.DataPropertyName = "DOperatie";
            this.dOperatieDataGridViewTextBoxColumn.HeaderText = "DOperatie";
            this.dOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOperatieDataGridViewTextBoxColumn.Name = "dOperatieDataGridViewTextBoxColumn";
            this.dOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOperatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProdusDataGridViewTextBoxColumn1
            // 
            this.idProdusDataGridViewTextBoxColumn1.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.idProdusDataGridViewTextBoxColumn1.Name = "idProdusDataGridViewTextBoxColumn1";
            this.idProdusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn1.Width = 2;
            // 
            // dProdusDataGridViewTextBoxColumn1
            // 
            this.dProdusDataGridViewTextBoxColumn1.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn1.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dProdusDataGridViewTextBoxColumn1.Name = "dProdusDataGridViewTextBoxColumn1";
            this.dProdusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dProdusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            this.uMDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitateDataGridViewTextBoxColumn1
            // 
            this.cantitateDataGridViewTextBoxColumn1.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn1.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn1.Name = "cantitateDataGridViewTextBoxColumn1";
            this.cantitateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // CalculStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 766);
            this.Controls.Add(this.txtFiltru);
            this.Controls.Add(this.btnStocFinal);
            this.Controls.Add(this.btnVanzari);
            this.Controls.Add(this.btnAchizitii);
            this.Controls.Add(this.btnStocInitial);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CalculStoc";
            this.Text = "CalculStoc";
            this.Load += new System.EventHandler(this.CalculStoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocProduseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CalculStocDS calculStocDS;
        private System.Windows.Forms.BindingSource calculStocBindingSource;
        private CalculStocDSTableAdapters.CalculStocTableAdapter calculStocTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stocProduseBindingSource;
        private CalculStocDSTableAdapters.StocProduseTableAdapter stocProduseTableAdapter;
        private System.Windows.Forms.Button btnStocInitial;
        private System.Windows.Forms.Button btnAchizitii;
        private System.Windows.Forms.Button btnVanzari;
        private System.Windows.Forms.Button btnStocFinal;
        private System.Windows.Forms.TextBox txtFiltru;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn1;
    }
}