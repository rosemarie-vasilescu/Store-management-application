
namespace magazin
{
    partial class Balanta
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
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balDS = new magazin.BalDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iesiriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balantaStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculStocTableAdapter = new magazin.BalDSTableAdapters.CalculStocTableAdapter();
            this.balantaStocTableAdapter = new magazin.BalDSTableAdapters.BalantaStocTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaStocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculStocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 605);
            this.dataGridView1.TabIndex = 0;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            this.idOperatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // calculStocBindingSource
            // 
            this.calculStocBindingSource.DataMember = "CalculStoc";
            this.calculStocBindingSource.DataSource = this.balDS;
            // 
            // balDS
            // 
            this.balDS.DataSetName = "BalDS";
            this.balDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdusDataGridViewTextBoxColumn1,
            this.stocInitialDataGridViewTextBoxColumn,
            this.intrariDataGridViewTextBoxColumn,
            this.iesiriDataGridViewTextBoxColumn,
            this.stocFinalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.balantaStocBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(721, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(841, 605);
            this.dataGridView2.TabIndex = 1;
            // 
            // idProdusDataGridViewTextBoxColumn1
            // 
            this.idProdusDataGridViewTextBoxColumn1.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idProdusDataGridViewTextBoxColumn1.Name = "idProdusDataGridViewTextBoxColumn1";
            this.idProdusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stocInitialDataGridViewTextBoxColumn
            // 
            this.stocInitialDataGridViewTextBoxColumn.DataPropertyName = "StocInitial";
            this.stocInitialDataGridViewTextBoxColumn.HeaderText = "StocInitial";
            this.stocInitialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stocInitialDataGridViewTextBoxColumn.Name = "stocInitialDataGridViewTextBoxColumn";
            this.stocInitialDataGridViewTextBoxColumn.Width = 125;
            // 
            // intrariDataGridViewTextBoxColumn
            // 
            this.intrariDataGridViewTextBoxColumn.DataPropertyName = "Intrari";
            this.intrariDataGridViewTextBoxColumn.HeaderText = "Intrari";
            this.intrariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intrariDataGridViewTextBoxColumn.Name = "intrariDataGridViewTextBoxColumn";
            this.intrariDataGridViewTextBoxColumn.Width = 125;
            // 
            // iesiriDataGridViewTextBoxColumn
            // 
            this.iesiriDataGridViewTextBoxColumn.DataPropertyName = "Iesiri";
            this.iesiriDataGridViewTextBoxColumn.HeaderText = "Iesiri";
            this.iesiriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iesiriDataGridViewTextBoxColumn.Name = "iesiriDataGridViewTextBoxColumn";
            this.iesiriDataGridViewTextBoxColumn.Width = 125;
            // 
            // stocFinalDataGridViewTextBoxColumn
            // 
            this.stocFinalDataGridViewTextBoxColumn.DataPropertyName = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.HeaderText = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stocFinalDataGridViewTextBoxColumn.Name = "stocFinalDataGridViewTextBoxColumn";
            this.stocFinalDataGridViewTextBoxColumn.Width = 125;
            // 
            // balantaStocBindingSource
            // 
            this.balantaStocBindingSource.DataMember = "BalantaStoc";
            this.balantaStocBindingSource.DataSource = this.balDS;
            // 
            // calculStocTableAdapter
            // 
            this.calculStocTableAdapter.ClearBeforeFill = true;
            // 
            // balantaStocTableAdapter
            // 
            this.balantaStocTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calcul stoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Balanta stoc";
            // 
            // Balanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 766);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Balanta";
            this.Text = "Balanta";
            this.Load += new System.EventHandler(this.Balanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaStocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BalDS balDS;
        private System.Windows.Forms.BindingSource calculStocBindingSource;
        private BalDSTableAdapters.CalculStocTableAdapter calculStocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource balantaStocBindingSource;
        private BalDSTableAdapters.BalantaStocTableAdapter balantaStocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intrariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iesiriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}