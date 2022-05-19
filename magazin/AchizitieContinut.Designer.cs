
namespace magazin
{
    partial class AchizitieContinut
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
            this.achizitiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.achizitiiDS = new magazin.AchizitiiDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.achizitieContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdAchizitie = new System.Windows.Forms.TextBox();
            this.btnAchizitieNoua = new System.Windows.Forms.Button();
            this.btnModificaAchizitie = new System.Windows.Forms.Button();
            this.btnStergeAchizitie = new System.Windows.Forms.Button();
            this.achizitiiTableAdapter = new magazin.AchizitiiDSTableAdapters.AchizitiiTableAdapter();
            this.achizitieContinutTableAdapter = new magazin.AchizitiiDSTableAdapters.AchizitieContinutTableAdapter();
            this.idAchizitieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAchizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrAchizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAchizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitieContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAchizitieDataGridViewTextBoxColumn,
            this.nrAchizitieDataGridViewTextBoxColumn,
            this.dataAchizitieDataGridViewTextBoxColumn,
            this.idFurnizorDataGridViewTextBoxColumn,
            this.dFurnizorDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.achizitiiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // achizitiiBindingSource
            // 
            this.achizitiiBindingSource.DataMember = "Achizitii";
            this.achizitiiBindingSource.DataSource = this.achizitiiDS;
            this.achizitiiBindingSource.PositionChanged += new System.EventHandler(this.achizitiiBindingSource_PositionChanged);
            // 
            // achizitiiDS
            // 
            this.achizitiiDS.DataSetName = "AchizitiiDS";
            this.achizitiiDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAchizitieDataGridViewTextBoxColumn1,
            this.nrcDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretVanzareDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.achizitieContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(57, 443);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1097, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // achizitieContinutBindingSource
            // 
            this.achizitieContinutBindingSource.DataMember = "AchizitieContinut";
            this.achizitieContinutBindingSource.DataSource = this.achizitiiDS;
            // 
            // txtIdAchizitie
            // 
            this.txtIdAchizitie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.achizitiiBindingSource, "IdAchizitie", true));
            this.txtIdAchizitie.Location = new System.Drawing.Point(953, 86);
            this.txtIdAchizitie.Name = "txtIdAchizitie";
            this.txtIdAchizitie.Size = new System.Drawing.Size(173, 22);
            this.txtIdAchizitie.TabIndex = 2;
            // 
            // btnAchizitieNoua
            // 
            this.btnAchizitieNoua.Location = new System.Drawing.Point(953, 147);
            this.btnAchizitieNoua.Name = "btnAchizitieNoua";
            this.btnAchizitieNoua.Size = new System.Drawing.Size(176, 23);
            this.btnAchizitieNoua.TabIndex = 3;
            this.btnAchizitieNoua.Text = "Achizitie noua";
            this.btnAchizitieNoua.UseVisualStyleBackColor = true;
            this.btnAchizitieNoua.Click += new System.EventHandler(this.btnAchizitieNoua_Click);
            // 
            // btnModificaAchizitie
            // 
            this.btnModificaAchizitie.Location = new System.Drawing.Point(953, 213);
            this.btnModificaAchizitie.Name = "btnModificaAchizitie";
            this.btnModificaAchizitie.Size = new System.Drawing.Size(179, 23);
            this.btnModificaAchizitie.TabIndex = 4;
            this.btnModificaAchizitie.Text = "Modifica achizitie";
            this.btnModificaAchizitie.UseVisualStyleBackColor = true;
            this.btnModificaAchizitie.Click += new System.EventHandler(this.btnModificaAchizitie_Click);
            // 
            // btnStergeAchizitie
            // 
            this.btnStergeAchizitie.Location = new System.Drawing.Point(956, 284);
            this.btnStergeAchizitie.Name = "btnStergeAchizitie";
            this.btnStergeAchizitie.Size = new System.Drawing.Size(176, 23);
            this.btnStergeAchizitie.TabIndex = 5;
            this.btnStergeAchizitie.Text = "Sterge achizitie";
            this.btnStergeAchizitie.UseVisualStyleBackColor = true;
            this.btnStergeAchizitie.Click += new System.EventHandler(this.btnStergeAchizitie_Click);
            // 
            // achizitiiTableAdapter
            // 
            this.achizitiiTableAdapter.ClearBeforeFill = true;
            // 
            // achizitieContinutTableAdapter
            // 
            this.achizitieContinutTableAdapter.ClearBeforeFill = true;
            // 
            // idAchizitieDataGridViewTextBoxColumn1
            // 
            this.idAchizitieDataGridViewTextBoxColumn1.DataPropertyName = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn1.HeaderText = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.idAchizitieDataGridViewTextBoxColumn1.Name = "idAchizitieDataGridViewTextBoxColumn1";
            this.idAchizitieDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAchizitieDataGridViewTextBoxColumn1.Width = 2;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrcDataGridViewTextBoxColumn.Width = 125;
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
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            this.dProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.dProdusDataGridViewTextBoxColumn.Width = 125;
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
            // pretVanzareDataGridViewTextBoxColumn
            // 
            this.pretVanzareDataGridViewTextBoxColumn.DataPropertyName = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.HeaderText = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretVanzareDataGridViewTextBoxColumn.Name = "pretVanzareDataGridViewTextBoxColumn";
            this.pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretVanzareDataGridViewTextBoxColumn.Width = 125;
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
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idAchizitieDataGridViewTextBoxColumn
            // 
            this.idAchizitieDataGridViewTextBoxColumn.DataPropertyName = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn.HeaderText = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idAchizitieDataGridViewTextBoxColumn.Name = "idAchizitieDataGridViewTextBoxColumn";
            this.idAchizitieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAchizitieDataGridViewTextBoxColumn.Width = 2;
            // 
            // nrAchizitieDataGridViewTextBoxColumn
            // 
            this.nrAchizitieDataGridViewTextBoxColumn.DataPropertyName = "NrAchizitie";
            this.nrAchizitieDataGridViewTextBoxColumn.HeaderText = "NrAchizitie";
            this.nrAchizitieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrAchizitieDataGridViewTextBoxColumn.Name = "nrAchizitieDataGridViewTextBoxColumn";
            this.nrAchizitieDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrAchizitieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataAchizitieDataGridViewTextBoxColumn
            // 
            this.dataAchizitieDataGridViewTextBoxColumn.DataPropertyName = "DataAchizitie";
            this.dataAchizitieDataGridViewTextBoxColumn.HeaderText = "DataAchizitie";
            this.dataAchizitieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAchizitieDataGridViewTextBoxColumn.Name = "dataAchizitieDataGridViewTextBoxColumn";
            this.dataAchizitieDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAchizitieDataGridViewTextBoxColumn.Width = 125;
            // 
            // idFurnizorDataGridViewTextBoxColumn
            // 
            this.idFurnizorDataGridViewTextBoxColumn.DataPropertyName = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.HeaderText = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idFurnizorDataGridViewTextBoxColumn.Name = "idFurnizorDataGridViewTextBoxColumn";
            this.idFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFurnizorDataGridViewTextBoxColumn.Width = 2;
            // 
            // dFurnizorDataGridViewTextBoxColumn
            // 
            this.dFurnizorDataGridViewTextBoxColumn.DataPropertyName = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.HeaderText = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dFurnizorDataGridViewTextBoxColumn.Name = "dFurnizorDataGridViewTextBoxColumn";
            this.dFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.dFurnizorDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // AchizitieContinut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 679);
            this.Controls.Add(this.btnStergeAchizitie);
            this.Controls.Add(this.btnModificaAchizitie);
            this.Controls.Add(this.btnAchizitieNoua);
            this.Controls.Add(this.txtIdAchizitie);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AchizitieContinut";
            this.Text = "AchizitieContinut";
            this.Load += new System.EventHandler(this.AchizitieContinut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitieContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdAchizitie;
        private System.Windows.Forms.Button btnAchizitieNoua;
        private System.Windows.Forms.Button btnModificaAchizitie;
        private System.Windows.Forms.Button btnStergeAchizitie;
        private AchizitiiDS achizitiiDS;
        private System.Windows.Forms.BindingSource achizitiiBindingSource;
        private AchizitiiDSTableAdapters.AchizitiiTableAdapter achizitiiTableAdapter;
        private System.Windows.Forms.BindingSource achizitieContinutBindingSource;
        private AchizitiiDSTableAdapters.AchizitieContinutTableAdapter achizitieContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchizitieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrAchizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAchizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}