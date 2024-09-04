namespace SistemaTriagemManchester.Apresentacao.UI.Uc.Historico
{
    partial class UcHistoricoIdentificacaoPaciente
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialMaskedTextBoxCPF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(materialMaskedTextBoxCPF);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialTextBox2);
            materialCard1.Controls.Add(materialTextBox1);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1234, 151);
            materialCard1.TabIndex = 3;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1072, 58);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(145, 57);
            materialButton1.TabIndex = 14;
            materialButton1.Text = "CONSULTAR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialMaskedTextBoxCPF
            // 
            materialMaskedTextBoxCPF.AllowPromptAsInput = true;
            materialMaskedTextBoxCPF.AnimateReadOnly = false;
            materialMaskedTextBoxCPF.AsciiOnly = false;
            materialMaskedTextBoxCPF.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBoxCPF.BeepOnError = false;
            materialMaskedTextBoxCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxCPF.Depth = 0;
            materialMaskedTextBoxCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBoxCPF.HidePromptOnLeave = false;
            materialMaskedTextBoxCPF.HideSelection = true;
            materialMaskedTextBoxCPF.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBoxCPF.LeadingIcon = null;
            materialMaskedTextBoxCPF.Location = new Point(684, 58);
            materialMaskedTextBoxCPF.Mask = "000.000.000-00";
            materialMaskedTextBoxCPF.MaxLength = 32767;
            materialMaskedTextBoxCPF.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBoxCPF.Name = "materialMaskedTextBoxCPF";
            materialMaskedTextBoxCPF.PasswordChar = '\0';
            materialMaskedTextBoxCPF.PrefixSuffixText = null;
            materialMaskedTextBoxCPF.PromptChar = '_';
            materialMaskedTextBoxCPF.ReadOnly = false;
            materialMaskedTextBoxCPF.RejectInputOnFirstFailure = false;
            materialMaskedTextBoxCPF.ResetOnPrompt = true;
            materialMaskedTextBoxCPF.ResetOnSpace = true;
            materialMaskedTextBoxCPF.RightToLeft = RightToLeft.No;
            materialMaskedTextBoxCPF.SelectedText = "";
            materialMaskedTextBoxCPF.SelectionLength = 0;
            materialMaskedTextBoxCPF.SelectionStart = 0;
            materialMaskedTextBoxCPF.ShortcutsEnabled = true;
            materialMaskedTextBoxCPF.Size = new Size(250, 48);
            materialMaskedTextBoxCPF.SkipLiterals = true;
            materialMaskedTextBoxCPF.TabIndex = 13;
            materialMaskedTextBoxCPF.TabStop = false;
            materialMaskedTextBoxCPF.Text = "   ,   ,   -";
            materialMaskedTextBoxCPF.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBoxCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxCPF.TrailingIcon = null;
            materialMaskedTextBoxCPF.UseSystemPasswordChar = false;
            materialMaskedTextBoxCPF.ValidatingType = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(684, 36);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(30, 19);
            materialLabel3.TabIndex = 12;
            materialLabel3.Text = "CPF";
            materialLabel3.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(18, 36);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(51, 19);
            materialLabel2.TabIndex = 11;
            materialLabel2.Text = "Código";
            materialLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(18, 58);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(137, 50);
            materialTextBox2.TabIndex = 10;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(194, 58);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(449, 50);
            materialTextBox1.TabIndex = 9;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(194, 36);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(108, 19);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Nome Paciente";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UcHistoricoIdentificacaoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "UcHistoricoIdentificacaoPaciente";
            Size = new Size(1261, 178);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxCPF;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
