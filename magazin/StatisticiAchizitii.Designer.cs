
namespace magazin
{
    partial class StatisticiAchizitii
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticiFurnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new magazin.DataSet1();
            this.statisticiFurnizoriTableAdapter = new magazin.DataSet1TableAdapters.StatisticiFurnizoriTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticiFurnizoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAchizitii = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiFurnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiFurnizoriBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dFurnizorDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.procentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statisticiFurnizoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(501, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // dFurnizorDataGridViewTextBoxColumn
            // 
            this.dFurnizorDataGridViewTextBoxColumn.DataPropertyName = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.HeaderText = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dFurnizorDataGridViewTextBoxColumn.Name = "dFurnizorDataGridViewTextBoxColumn";
            this.dFurnizorDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            this.procentDataGridViewTextBoxColumn.DataPropertyName = "Procent";
            this.procentDataGridViewTextBoxColumn.HeaderText = "Procent";
            this.procentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            this.procentDataGridViewTextBoxColumn.Width = 125;
            // 
            // statisticiFurnizoriBindingSource
            // 
            this.statisticiFurnizoriBindingSource.DataMember = "StatisticiFurnizori";
            this.statisticiFurnizoriBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statisticiFurnizoriTableAdapter
            // 
            this.statisticiFurnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total achizitii";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.statisticiFurnizoriBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(620, 125);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Achizitii";
            series1.XValueMember = "DFurnizor";
            series1.YValueMembers = "Total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(734, 423);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // statisticiFurnizoriBindingSource1
            // 
            this.statisticiFurnizoriBindingSource1.DataMember = "StatisticiFurnizori";
            this.statisticiFurnizoriBindingSource1.DataSource = this.dataSet1;
            // 
            // txtAchizitii
            // 
            this.txtAchizitii.Location = new System.Drawing.Point(221, 48);
            this.txtAchizitii.Name = "txtAchizitii";
            this.txtAchizitii.Size = new System.Drawing.Size(100, 22);
            this.txtAchizitii.TabIndex = 3;
            // 
            // StatisticiAchizitii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 698);
            this.Controls.Add(this.txtAchizitii);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StatisticiAchizitii";
            this.Text = "StatisticiAchizitii";
            this.Load += new System.EventHandler(this.StatisticiFurnizori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiFurnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiFurnizoriBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource statisticiFurnizoriBindingSource;
        private DataSet1TableAdapters.StatisticiFurnizoriTableAdapter statisticiFurnizoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource statisticiFurnizoriBindingSource1;
        private System.Windows.Forms.TextBox txtAchizitii;
    }
}