namespace SistemaTriagemManchester.UI.Uc.Historico
{
    partial class UcHistoricoTriagens
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
            DataTriagem = new DataGridViewTextBoxColumn();
            SintomasRelatados = new DataGridViewTextBoxColumn();
            GrauUrgencia = new DataGridViewTextBoxColumn();
            CondicoesPreExistentesRelacionadas = new DataGridViewTextBoxColumn();
            ProfissionalTriagem = new DataGridViewTextBoxColumn();
            ucHistoricoIdentificacaoPaciente1 = new Apresentacao.UI.Uc.Historico.UcHistoricoIdentificacaoPaciente();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataTriagem, SintomasRelatados, GrauUrgencia, CondicoesPreExistentesRelacionadas, ProfissionalTriagem });
            dataGridView1.Location = new Point(157, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(946, 503);
            dataGridView1.TabIndex = 0;
            // 
            // DataTriagem
            // 
            DataTriagem.HeaderText = "Data da triagem";
            DataTriagem.Name = "DataTriagem";
            DataTriagem.Width = 120;
            // 
            // SintomasRelatados
            // 
            SintomasRelatados.HeaderText = "Sintomas relatados";
            SintomasRelatados.Name = "SintomasRelatados";
            SintomasRelatados.Width = 150;
            // 
            // GrauUrgencia
            // 
            GrauUrgencia.HeaderText = "Grau de urgência";
            GrauUrgencia.Name = "GrauUrgencia";
            GrauUrgencia.Width = 150;
            // 
            // CondicoesPreExistentesRelacionadas
            // 
            CondicoesPreExistentesRelacionadas.HeaderText = "Condições pré-existentes relacionadas";
            CondicoesPreExistentesRelacionadas.Name = "CondicoesPreExistentesRelacionadas";
            CondicoesPreExistentesRelacionadas.Width = 250;
            // 
            // ProfissionalTriagem
            // 
            ProfissionalTriagem.HeaderText = "Profissional que realizou a triagem";
            ProfissionalTriagem.Name = "ProfissionalTriagem";
            ProfissionalTriagem.Width = 230;
            // 
            // ucHistoricoIdentificacaoPaciente1
            // 
            ucHistoricoIdentificacaoPaciente1.Location = new Point(24, 3);
            ucHistoricoIdentificacaoPaciente1.Name = "ucHistoricoIdentificacaoPaciente1";
            ucHistoricoIdentificacaoPaciente1.Size = new Size(1261, 178);
            ucHistoricoIdentificacaoPaciente1.TabIndex = 1;
            // 
            // UcHistoricoTriagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(ucHistoricoIdentificacaoPaciente1);
            Name = "UcHistoricoTriagens";
            Size = new Size(1298, 704);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataTriagem;
        private DataGridViewTextBoxColumn SintomasRelatados;
        private DataGridViewTextBoxColumn GrauUrgencia;
        private DataGridViewTextBoxColumn CondicoesPreExistentesRelacionadas;
        private DataGridViewTextBoxColumn ProfissionalTriagem;
        private Apresentacao.UI.Uc.Historico.UcHistoricoIdentificacaoPaciente ucHistoricoIdentificacaoPaciente1;
    }
}
