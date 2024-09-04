namespace SistemaTriagemManchester.UI.Uc.Relatorios
{
    partial class UcRelatorio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker2.Location = new Point(290, 54);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(248, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Emergência", "Urgência", "Consultas" });
            materialComboBox1.Location = new Point(812, 54);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(234, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 5;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1071, 54);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(145, 57);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Gerar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(940, 207);
            dataGridView1.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(134, 395);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(940, 300);
            chart1.TabIndex = 8;
            chart1.Text = "chart1";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 32);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(81, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Data Inicial";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialComboBox2);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(materialComboBox1);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(dateTimePicker2);
            materialCard1.Controls.Add(dateTimePicker1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1234, 151);
            materialCard1.TabIndex = 10;
            // 
            // materialComboBox2
            // 
            materialComboBox2.AutoResize = false;
            materialComboBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox2.Depth = 0;
            materialComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox2.DropDownHeight = 174;
            materialComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox2.DropDownWidth = 121;
            materialComboBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox2.FormattingEnabled = true;
            materialComboBox2.IntegralHeight = false;
            materialComboBox2.ItemHeight = 43;
            materialComboBox2.Items.AddRange(new object[] { "Classificação de Risco", "Pacientes Atendidos", "Sinais Vitais" });
            materialComboBox2.Location = new Point(561, 54);
            materialComboBox2.MaxDropDownItems = 4;
            materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox2.Name = "materialComboBox2";
            materialComboBox2.Size = new Size(234, 49);
            materialComboBox2.StartIndex = 0;
            materialComboBox2.TabIndex = 13;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(812, 32);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(100, 19);
            materialLabel4.TabIndex = 12;
            materialLabel4.Text = "Tipo Relatório";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(571, 32);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(127, 19);
            materialLabel3.TabIndex = 11;
            materialLabel3.Text = "Tipo Atendimento";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(290, 32);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(74, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Data Final";
            // 
            // UcRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(materialCard1);
            Name = "UcRelatorio";
            Size = new Size(1298, 704);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}
