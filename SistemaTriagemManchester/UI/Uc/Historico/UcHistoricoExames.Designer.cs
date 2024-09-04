namespace SistemaTriagemManchester.UI.Uc.Historico
{
    partial class UcHistoricoExames
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
            TipoExame = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            MedicoSolicitante = new DataGridViewTextBoxColumn();
            InterpretacaoResultados = new DataGridViewTextBoxColumn();
            ucHistoricoIdentificacaoPaciente1 = new Apresentacao.UI.Uc.Historico.UcHistoricoIdentificacaoPaciente();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TipoExame, Data, Resultado, MedicoSolicitante, InterpretacaoResultados });
            dataGridView1.Location = new Point(311, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(684, 492);
            dataGridView1.TabIndex = 0;
            // 
            // TipoExame
            // 
            TipoExame.HeaderText = "Tipo de exame";
            TipoExame.Name = "TipoExame";
            TipoExame.Width = 130;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Resultado
            // 
            Resultado.HeaderText = "Resultado";
            Resultado.Name = "Resultado";
            // 
            // MedicoSolicitante
            // 
            MedicoSolicitante.HeaderText = "Médico solicitante";
            MedicoSolicitante.Name = "MedicoSolicitante";
            MedicoSolicitante.Width = 130;
            // 
            // InterpretacaoResultados
            // 
            InterpretacaoResultados.HeaderText = "Interpretação dos resultados";
            InterpretacaoResultados.Name = "InterpretacaoResultados";
            InterpretacaoResultados.Width = 180;
            // 
            // ucHistoricoIdentificacaoPaciente1
            // 
            ucHistoricoIdentificacaoPaciente1.Location = new Point(24, 3);
            ucHistoricoIdentificacaoPaciente1.Name = "ucHistoricoIdentificacaoPaciente1";
            ucHistoricoIdentificacaoPaciente1.Size = new Size(1261, 178);
            ucHistoricoIdentificacaoPaciente1.TabIndex = 1;
            // 
            // UcHistoricoExames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(ucHistoricoIdentificacaoPaciente1);
            Name = "UcHistoricoExames";
            Size = new Size(1298, 704);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TipoExame;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Resultado;
        private DataGridViewTextBoxColumn MedicoSolicitante;
        private DataGridViewTextBoxColumn InterpretacaoResultados;
        private Apresentacao.UI.Uc.Historico.UcHistoricoIdentificacaoPaciente ucHistoricoIdentificacaoPaciente1;
    }
}
