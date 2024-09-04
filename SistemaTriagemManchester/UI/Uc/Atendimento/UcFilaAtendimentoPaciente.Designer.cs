namespace SistemaTriagemManchester.UI.Uc
{
    partial class UcFilaAtendimentoPaciente
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
            dataGridView1 = new DataGridView();
            Posicao = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Chegada = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Posicao, Nome, Chegada, Status });
            dataGridView1.Location = new Point(14, 11);
            dataGridView1.Margin = new Padding(0, 6, 0, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(617, 198);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Posicao
            // 
            Posicao.HeaderText = "Posicao";
            Posicao.Name = "Posicao";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 250;
            // 
            // Chegada
            // 
            Chegada.HeaderText = "Chegada";
            Chegada.Name = "Chegada";
            Chegada.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 50;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(549, 197);
            materialLabel1.Margin = new Padding(0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(142, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Fila de Atendimento";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dataGridView1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(315, 233);
            materialCard1.Margin = new Padding(14, 17, 14, 17);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 17, 14, 17);
            materialCard1.Size = new Size(635, 232);
            materialCard1.TabIndex = 2;
            // 
            // UcFilaAtendimentoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabel1);
            Controls.Add(materialCard1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(0, 6, 0, 6);
            Name = "UcFilaAtendimentoPaciente";
            Size = new Size(1298, 704);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private DataGridViewTextBoxColumn Posicao;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Chegada;
        private DataGridViewTextBoxColumn Status;
    }
}
