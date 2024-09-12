namespace SistemaTriagemManchester.Apresentacao.UI.Uc.Acolhimento
{
    partial class UcAcolhimento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelButtons = new Panel();
            materialButtonTriagem = new MaterialSkin.Controls.MaterialButton();
            materialButtonAtendimento = new MaterialSkin.Controls.MaterialButton();
            panelAcolhimento = new Panel();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(materialButtonTriagem);
            panelButtons.Controls.Add(materialButtonAtendimento);
            panelButtons.Location = new Point(399, 256);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(436, 114);
            panelButtons.TabIndex = 7;
            // 
            // materialButtonTriagem
            // 
            materialButtonTriagem.AutoSize = false;
            materialButtonTriagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonTriagem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonTriagem.Depth = 0;
            materialButtonTriagem.HighEmphasis = true;
            materialButtonTriagem.Icon = null;
            materialButtonTriagem.Location = new Point(4, 6);
            materialButtonTriagem.Margin = new Padding(4, 6, 4, 6);
            materialButtonTriagem.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonTriagem.Name = "materialButtonTriagem";
            materialButtonTriagem.NoAccentTextColor = Color.Empty;
            materialButtonTriagem.Size = new Size(200, 100);
            materialButtonTriagem.TabIndex = 5;
            materialButtonTriagem.TabStop = false;
            materialButtonTriagem.Text = "TRIAGEM";
            materialButtonTriagem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButtonTriagem.UseAccentColor = false;
            materialButtonTriagem.UseVisualStyleBackColor = true;
            materialButtonTriagem.Click += materialButtonTriagem_Click;
            // 
            // materialButtonAtendimento
            // 
            materialButtonAtendimento.AutoSize = false;
            materialButtonAtendimento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonAtendimento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAtendimento.Depth = 0;
            materialButtonAtendimento.HighEmphasis = true;
            materialButtonAtendimento.Icon = null;
            materialButtonAtendimento.Location = new Point(229, 6);
            materialButtonAtendimento.Margin = new Padding(4, 6, 4, 6);
            materialButtonAtendimento.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAtendimento.Name = "materialButtonAtendimento";
            materialButtonAtendimento.NoAccentTextColor = Color.Empty;
            materialButtonAtendimento.Size = new Size(200, 100);
            materialButtonAtendimento.TabIndex = 4;
            materialButtonAtendimento.TabStop = false;
            materialButtonAtendimento.Text = "ATENDIMENTO";
            materialButtonAtendimento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAtendimento.UseAccentColor = false;
            materialButtonAtendimento.UseVisualStyleBackColor = true;
            materialButtonAtendimento.Click += materialButtonAtendimento_Click;
            // 
            // panelAcolhimento
            // 
            panelAcolhimento.Location = new Point(3, 0);
            panelAcolhimento.Name = "panelAcolhimento";
            panelAcolhimento.Size = new Size(1286, 695);
            panelAcolhimento.TabIndex = 8;
            // 
            // UcAcolhimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelButtons);
            Controls.Add(panelAcolhimento);
            Name = "UcAcolhimento";
            Size = new Size(1292, 698);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private MaterialSkin.Controls.MaterialButton materialButtonTriagem;
        private MaterialSkin.Controls.MaterialButton materialButtonAtendimento;
        private Panel panelAcolhimento;
    }
}
