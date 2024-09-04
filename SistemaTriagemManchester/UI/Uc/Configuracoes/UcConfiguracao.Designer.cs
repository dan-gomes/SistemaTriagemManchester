namespace SistemaTriagemManchester.Apresentacao.UI.Uc.Configuracoes
{
    partial class UcConfiguracao
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
            materialButtonCadastrar = new MaterialSkin.Controls.MaterialButton();
            materialButtonAlterarSenha = new MaterialSkin.Controls.MaterialButton();
            panelConfiguracao = new Panel();
            panelButtonsConfiguracao = new Panel();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            panelButtonsConfiguracao.SuspendLayout();
            SuspendLayout();
            // 
            // materialButtonCadastrar
            // 
            materialButtonCadastrar.AutoSize = false;
            materialButtonCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCadastrar.Depth = 0;
            materialButtonCadastrar.HighEmphasis = true;
            materialButtonCadastrar.Icon = null;
            materialButtonCadastrar.Location = new Point(4, 6);
            materialButtonCadastrar.Margin = new Padding(4, 6, 4, 6);
            materialButtonCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCadastrar.Name = "materialButtonCadastrar";
            materialButtonCadastrar.NoAccentTextColor = Color.Empty;
            materialButtonCadastrar.Size = new Size(200, 100);
            materialButtonCadastrar.TabIndex = 7;
            materialButtonCadastrar.TabStop = false;
            materialButtonCadastrar.Text = "CADASTRAR USUARIO";
            materialButtonCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButtonCadastrar.UseAccentColor = false;
            materialButtonCadastrar.UseVisualStyleBackColor = true;
            materialButtonCadastrar.Click += materialButtonCadastrar_Click;
            // 
            // materialButtonAlterarSenha
            // 
            materialButtonAlterarSenha.AutoSize = false;
            materialButtonAlterarSenha.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonAlterarSenha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAlterarSenha.Depth = 0;
            materialButtonAlterarSenha.HighEmphasis = true;
            materialButtonAlterarSenha.Icon = null;
            materialButtonAlterarSenha.Location = new Point(231, 6);
            materialButtonAlterarSenha.Margin = new Padding(4, 6, 4, 6);
            materialButtonAlterarSenha.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAlterarSenha.Name = "materialButtonAlterarSenha";
            materialButtonAlterarSenha.NoAccentTextColor = Color.Empty;
            materialButtonAlterarSenha.Size = new Size(200, 100);
            materialButtonAlterarSenha.TabIndex = 6;
            materialButtonAlterarSenha.TabStop = false;
            materialButtonAlterarSenha.Text = "ALTERAR SENHA";
            materialButtonAlterarSenha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAlterarSenha.UseAccentColor = false;
            materialButtonAlterarSenha.UseVisualStyleBackColor = true;
            materialButtonAlterarSenha.Click += materialButtonAlterarSenha_Click;
            // 
            // panelConfiguracao
            // 
            panelConfiguracao.Location = new Point(3, 3);
            panelConfiguracao.Name = "panelConfiguracao";
            panelConfiguracao.Size = new Size(1292, 698);
            panelConfiguracao.TabIndex = 8;
            // 
            // panelButtonsConfiguracao
            // 
            panelButtonsConfiguracao.Controls.Add(materialButtonCadastrar);
            panelButtonsConfiguracao.Controls.Add(materialButtonAlterarSenha);
            panelButtonsConfiguracao.Location = new Point(390, 274);
            panelButtonsConfiguracao.Name = "panelButtonsConfiguracao";
            panelButtonsConfiguracao.Size = new Size(435, 113);
            panelButtonsConfiguracao.TabIndex = 8;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(8, 8);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(200, 100);
            materialButton3.TabIndex = 8;
            materialButton3.TabStop = false;
            materialButton3.Text = "CADASTRAR USUARIO";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // UcConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelButtonsConfiguracao);
            Controls.Add(panelConfiguracao);
            Name = "UcConfiguracao";
            Size = new Size(1298, 704);
            panelButtonsConfiguracao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonCadastrar;
        private MaterialSkin.Controls.MaterialButton materialButtonAlterarSenha;
        private Panel panelConfiguracao;
        private Panel panelButtonsConfiguracao;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}
