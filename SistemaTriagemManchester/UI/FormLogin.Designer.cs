namespace SistemaTriagemManchester.Apresentacao.UI
{
    partial class FormLogin
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
            panelLogin = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label2 = new Label();
            label1 = new Label();
            senha = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            usuario = new MaterialSkin.Controls.MaterialTextBox();
            btnEntrar = new MaterialSkin.Controls.MaterialButton();
            panelLogin.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(materialCard1);
            panelLogin.Location = new Point(6, 67);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1354, 695);
            panelLogin.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(senha);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(usuario);
            materialCard1.Controls.Add(btnEntrar);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(443, 110);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(469, 474);
            materialCard1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(79, 94);
            label2.Name = "label2";
            label2.Size = new Size(362, 21);
            label2.TabIndex = 6;
            label2.Text = "Digite os seus dados de acesso nos campos abaixo.";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(26, 14);
            label1.Name = "label1";
            label1.Size = new Size(123, 53);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // senha
            // 
            senha.AllowPromptAsInput = true;
            senha.AnimateReadOnly = false;
            senha.AsciiOnly = false;
            senha.BackgroundImageLayout = ImageLayout.None;
            senha.BeepOnError = false;
            senha.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            senha.Depth = 0;
            senha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            senha.HidePromptOnLeave = false;
            senha.HideSelection = true;
            senha.InsertKeyMode = InsertKeyMode.Default;
            senha.LeadingIcon = null;
            senha.Location = new Point(35, 257);
            senha.Mask = "";
            senha.MaxLength = 32767;
            senha.MouseState = MaterialSkin.MouseState.OUT;
            senha.Name = "senha";
            senha.PasswordChar = '\0';
            senha.PrefixSuffixText = null;
            senha.PromptChar = '_';
            senha.ReadOnly = false;
            senha.RejectInputOnFirstFailure = false;
            senha.ResetOnPrompt = true;
            senha.ResetOnSpace = true;
            senha.RightToLeft = RightToLeft.No;
            senha.SelectedText = "";
            senha.SelectionLength = 0;
            senha.SelectionStart = 0;
            senha.ShortcutsEnabled = true;
            senha.Size = new Size(406, 48);
            senha.SkipLiterals = true;
            senha.TabIndex = 4;
            senha.TabStop = false;
            senha.TextAlign = HorizontalAlignment.Left;
            senha.TextMaskFormat = MaskFormat.IncludeLiterals;
            senha.TrailingIcon = null;
            senha.UseSystemPasswordChar = false;
            senha.ValidatingType = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(35, 235);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Senha";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(35, 141);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(55, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Usuário";
            // 
            // usuario
            // 
            usuario.AnimateReadOnly = false;
            usuario.BorderStyle = BorderStyle.None;
            usuario.Depth = 0;
            usuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usuario.LeadingIcon = null;
            usuario.Location = new Point(35, 163);
            usuario.MaxLength = 50;
            usuario.MouseState = MaterialSkin.MouseState.OUT;
            usuario.Multiline = false;
            usuario.Name = "usuario";
            usuario.Size = new Size(406, 50);
            usuario.TabIndex = 1;
            usuario.Text = "";
            usuario.TrailingIcon = null;
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSize = false;
            btnEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEntrar.Depth = 0;
            btnEntrar.HighEmphasis = true;
            btnEntrar.Icon = null;
            btnEntrar.Location = new Point(35, 343);
            btnEntrar.Margin = new Padding(4, 6, 4, 6);
            btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEntrar.Name = "btnEntrar";
            btnEntrar.NoAccentTextColor = Color.Empty;
            btnEntrar.Size = new Size(406, 63);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEntrar.UseAccentColor = false;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(panelLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            panelLogin.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialMaskedTextBox senha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox usuario;
        private MaterialSkin.Controls.MaterialButton btnEntrar;
    }
}