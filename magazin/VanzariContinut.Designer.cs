
namespace magazin
{
    partial class VanzariContinut
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
            this.vanzareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanzari = new magazin.Vanzari();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vanzareContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdVanzare = new System.Windows.Forms.TextBox();
            this.btnVanzareNoua = new System.Windows.Forms.Button();
            this.btnModificaVanzare = new System.Windows.Forms.Button();
            this.btnStergeVanzare = new System.Windows.Forms.Button();
            this.vanzareTableAdapter = new magazin.VanzariTableAdapters.VanzareTableAdapter();
            this.vanzareContinutTableAdapter = new magazin.VanzariTableAdapters.VanzareContinutTableAdapter();
            this.idVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVanzareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanzareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanzari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanzareContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVanzareDataGridViewTextBoxColumn,
            this.dataVanzareDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dClientDataGridViewTextBoxColumn,
            this.nrVanzareDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vanzareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // vanzareBindingSource
            // 
            this.vanzareBindingSource.DataMember = "Vanzare";
            this.vanzareBindingSource.DataSource = this.vanzari;
            this.vanzareBindingSource.PositionChanged += new System.EventHandler(this.vanzareBindingSource_PositionChanged);
            // 
            // vanzari
            // 
            this.vanzari.DataSetName = "Vanzari";
            this.vanzari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVanzareDataGridViewTextBoxColumn1,
            this.idProdusDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretVanzareDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.nrCrtDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vanzareContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(32, 469);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1205, 232);
            this.dataGridView2.TabIndex = 1;
            // 
            // vanzareContinutBindingSource
            // 
            this.vanzareContinutBindingSource.DataMember = "VanzareContinut";
            this.vanzareContinutBindingSource.DataSource = this.vanzari;
            // 
            // txtIdVanzare
            // 
            this.txtIdVanzare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanzareBindingSource, "IdVanzare", true));
            this.txtIdVanzare.Location = new System.Drawing.Point(1077, 57);
            this.txtIdVanzare.Name = "txtIdVanzare";
            this.txtIdVanzare.Size = new System.Drawing.Size(160, 22);
            this.txtIdVanzare.TabIndex = 2;
            // 
            // btnVanzareNoua
            // 
            this.btnVanzareNoua.Location = new System.Drawing.Point(1077, 134);
            this.btnVanzareNoua.Name = "btnVanzareNoua";
            this.btnVanzareNoua.Size = new System.Drawing.Size(160, 23);
            this.btnVanzareNoua.TabIndex = 3;
            this.btnVanzareNoua.Text = "Vanzare noua";
            this.btnVanzareNoua.UseVisualStyleBackColor = true;
            this.btnVanzareNoua.Click += new System.EventHandler(this.btnVanzareNoua_Click);
            // 
            // btnModificaVanzare
            // 
            this.btnModificaVanzare.Location = new System.Drawing.Point(1077, 216);
            this.btnModificaVanzare.Name = "btnModificaVanzare";
            this.btnModificaVanzare.Size = new System.Drawing.Size(160, 23);
            this.btnModificaVanzare.TabIndex = 4;
            this.btnModificaVanzare.Text = "Modifica vanzare";
            this.btnModificaVanzare.UseVisualStyleBackColor = true;
            this.btnModificaVanzare.Click += new System.EventHandler(this.btnModificaVanzare_Click);
            // 
            // btnStergeVanzare
            // 
            this.btnStergeVanzare.Location = new System.Drawing.Point(1077, 324);
            this.btnStergeVanzare.Name = "btnStergeVanzare";
            this.btnStergeVanzare.Size = new System.Drawing.Size(160, 23);
            this.btnStergeVanzare.TabIndex = 5;
            this.btnStergeVanzare.Text = "Sterge vanzare";
            this.btnStergeVanzare.UseVisualStyleBackColor = true;
            this.btnStergeVanzare.Click += new System.EventHandler(this.btnStergeVanzare_Click);
            // 
            // vanzareTableAdapter
            // 
            this.vanzareTableAdapter.ClearBeforeFill = true;
            // 
            // vanzareContinutTableAdapter
            // 
            this.vanzareContinutTableAdapter.ClearBeforeFill = true;
            // 
            // idVanzareDataGridViewTextBoxColumn
            // 
            this.idVanzareDataGridViewTextBoxColumn.DataPropertyName = "IdVanzare";
            this.idVanzareDataGridViewTextBoxColumn.HeaderText = "IdVanzare";
            this.idVanzareDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idVanzareDataGridViewTextBoxColumn.Name = "idVanzareDataGridViewTextBoxColumn";
            this.idVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVanzareDataGridViewTextBoxColumn.Width = 2;
            // 
            // dataVanzareDataGridViewTextBoxColumn
            // 
            this.dataVanzareDataGridViewTextBoxColumn.DataPropertyName = "DataVanzare";
            this.dataVanzareDataGridViewTextBoxColumn.HeaderText = "DataVanzare";
            this.dataVanzareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataVanzareDataGridViewTextBoxColumn.Name = "dataVanzareDataGridViewTextBoxColumn";
            this.dataVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVanzareDataGridViewTextBoxColumn.Width = 125;
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
            // dClientDataGridViewTextBoxColumn
            // 
            this.dClientDataGridViewTextBoxColumn.DataPropertyName = "DClient";
            this.dClientDataGridViewTextBoxColumn.HeaderText = "DClient";
            this.dClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dClientDataGridViewTextBoxColumn.Name = "dClientDataGridViewTextBoxColumn";
            this.dClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.dClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrVanzareDataGridViewTextBoxColumn
            // 
            this.nrVanzareDataGridViewTextBoxColumn.DataPropertyName = "NrVanzare";
            this.nrVanzareDataGridViewTextBoxColumn.HeaderText = "NrVanzare";
            this.nrVanzareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrVanzareDataGridViewTextBoxColumn.Name = "nrVanzareDataGridViewTextBoxColumn";
            this.nrVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrVanzareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Width = 2;
            // 
            // idVanzareDataGridViewTextBoxColumn1
            // 
            this.idVanzareDataGridViewTextBoxColumn1.DataPropertyName = "IdVanzare";
            this.idVanzareDataGridViewTextBoxColumn1.HeaderText = "IdVanzare";
            this.idVanzareDataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.idVanzareDataGridViewTextBoxColumn1.Name = "idVanzareDataGridViewTextBoxColumn1";
            this.idVanzareDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idVanzareDataGridViewTextBoxColumn1.Width = 2;
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
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrCrtDataGridViewTextBoxColumn.Width = 125;
            // 
            // VanzariContinut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 770);
            this.Controls.Add(this.btnStergeVanzare);
            this.Controls.Add(this.btnModificaVanzare);
            this.Controls.Add(this.btnVanzareNoua);
            this.Controls.Add(this.txtIdVanzare);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VanzariContinut";
            this.Text = "VanzariContinut";
            this.Load += new System.EventHandler(this.VanzariContinut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanzareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanzari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanzareContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdVanzare;
        private System.Windows.Forms.Button btnVanzareNoua;
        private System.Windows.Forms.Button btnModificaVanzare;
        private System.Windows.Forms.Button btnStergeVanzare;
        private Vanzari vanzari;
        private System.Windows.Forms.BindingSource vanzareBindingSource;
        private VanzariTableAdapters.VanzareTableAdapter vanzareTableAdapter;
        private System.Windows.Forms.BindingSource vanzareContinutBindingSource;
        private VanzariTableAdapters.VanzareContinutTableAdapter vanzareContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVanzareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
    }
}