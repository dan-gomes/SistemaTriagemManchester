namespace SistemaTriagemManchester.UI.Uc.Historico
{
    partial class UcHistoricoConsultas
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
            DataConsulta = new DataGridViewTextBoxColumn();
            MedicoResponsavel = new DataGridViewTextBoxColumn();
            Diagnostico = new DataGridViewTextBoxColumn();
            Tratamento = new DataGridViewTextBoxColumn();
            Observacoes = new DataGridViewTextBoxColumn();
            ucHistoricoIdentificacaoPaciente1 = new Apresentacao.UI.Uc.Historico.UcHistoricoIdentificacaoPaciente();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataConsulta, MedicoResponsavel, Diagnostico, Tratamento, Observacoes });
            dataGridView1.Location = new Point(311, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(625, 499);
            dataGridView1.TabIndex = 0;
            // 
            // DataConsulta
            // 
            DataConsulta.HeaderText = "Data da consulta";
            DataConsulta.Name = "DataConsulta";
            DataConsulta.Width = 130;
            // 
            // MedicoResponsavel
            // 
            MedicoResponsavel.HeaderText = "Médico responsável";
            MedicoResponsavel.Name = "MedicoResponsavel";
            MedicoResponsavel.Width = 150;
            // 
            // Diagnostico
            // 
            Diagnostico.HeaderText = "Diagnóstico";
            Diagnostico.Name = "Diagnostico";
            // 
            // Tratamento
            // 
            Tratamento.HeaderText = "Tratamento";
            Tratamento.Name = "Tratamento";
            // 
            // Observacoes
            // 
            Observacoes.HeaderText = "Observações";
            Observacoes.Name = "Observacoes";
            // 
            // ucHistoricoIdentificacaoPaciente1
            // 
            ucHistoricoIdentificacaoPaciente1.Location = new Point(24, 3);
            ucHistoricoIdentificacaoPaciente1.Name = "ucHistoricoIdentificacaoPaciente1";
            ucHistoricoIdentificacaoPaciente1.Size = new Size(1261, 178);
            ucHistoricoIdentificacaoPaciente1.TabIndex = 1;
            // 
            // UcHistoricoConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(ucHistoricoIdentificacaoPaciente1);
            Name = "UcHistoricoConsultas";
            Size = new Size(1298, 704);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataConsulta;
        private DataGridViewTextBoxColumn MedicoResponsavel;
        private DataGridViewTextBoxColumn Diagnostico;
        private DataGridViewTextBoxColumn Tratamento;
        private DataGridViewTextBoxColumn Observacoes;
        private Apresentacao.UI.Uc.Historico.UcHistoricoIdentificacaoPaciente ucHistoricoIdentificacaoPaciente1;
    }
}
