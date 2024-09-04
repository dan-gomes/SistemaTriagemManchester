namespace SistemaTriagemManchester.UI.Uc.Dashboard
{
    partial class UcDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(48, 39);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(228, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Número Total de Pacientes Hoje";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(chart1, 0, 1);
            tableLayoutPanel1.Controls.Add(chart4, 1, 2);
            tableLayoutPanel1.Controls.Add(materialLabel2, 0, 0);
            tableLayoutPanel1.Controls.Add(materialListBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(chart2, 1, 1);
            tableLayoutPanel1.Location = new Point(48, 74);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.1964741F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.80353F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 242F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1188, 603);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // chart4
            // 
            chartArea2.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart4.Legends.Add(legend2);
            chart4.Location = new Point(597, 363);
            chart4.Name = "chart4";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart4.Series.Add(series2);
            chart4.Size = new Size(588, 237);
            chart4.TabIndex = 3;
            chart4.Text = "chart4";
            // 
            // materialLabel2
            // 
            tableLayoutPanel1.SetColumnSpan(materialLabel2, 2);
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Fill;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(3, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(1182, 94);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Pacientes Atendidos Hoje: 120";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            materialLabel2.Click += materialLabel2_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(3, 97);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(588, 260);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Dock = DockStyle.Fill;
            materialListBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "\"Paciente em espera prolongada: João da Silva\"";
            materialListBox1.Items.Add(materialListBoxItem1);
            materialListBox1.Location = new Point(3, 363);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(588, 237);
            materialListBox1.TabIndex = 5;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart2.Legends.Add(legend3);
            chart2.Location = new Point(597, 97);
            chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart2.Series.Add(series3);
            chart2.Size = new Size(588, 260);
            chart2.TabIndex = 6;
            chart2.Text = "chart2";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(materialLabel1);
            Name = "UcDashboard";
            Size = new Size(1298, 704);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
