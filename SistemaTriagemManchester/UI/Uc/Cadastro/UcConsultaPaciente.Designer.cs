namespace SistemaTriagemManchester.UI.Uc
{
    partial class UcConsultaPaciente
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
            materialMaskedTextBoxCPF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxId = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxNome = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            dataGridViewConsultaPessoa = new DataGridView();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultaPessoa).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialMaskedTextBoxCPF);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialTextBoxId);
            materialCard1.Controls.Add(materialTextBoxNome);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1270, 142);
            materialCard1.TabIndex = 0;
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
            materialMaskedTextBoxCPF.Location = new Point(683, 54);
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
            materialMaskedTextBoxCPF.TabIndex = 6;
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
            materialLabel3.Location = new Point(683, 32);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(30, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "CPF";
            materialLabel3.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 32);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(90, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Identificador";
            materialLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialTextBoxId
            // 
            materialTextBoxId.AnimateReadOnly = false;
            materialTextBoxId.BorderStyle = BorderStyle.None;
            materialTextBoxId.Depth = 0;
            materialTextBoxId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxId.LeadingIcon = null;
            materialTextBoxId.Location = new Point(17, 54);
            materialTextBoxId.MaxLength = 50;
            materialTextBoxId.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxId.Multiline = false;
            materialTextBoxId.Name = "materialTextBoxId";
            materialTextBoxId.Size = new Size(137, 50);
            materialTextBoxId.TabIndex = 2;
            materialTextBoxId.Text = "";
            materialTextBoxId.TrailingIcon = null;
            // 
            // materialTextBoxNome
            // 
            materialTextBoxNome.AnimateReadOnly = false;
            materialTextBoxNome.BorderStyle = BorderStyle.None;
            materialTextBoxNome.Depth = 0;
            materialTextBoxNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxNome.LeadingIcon = null;
            materialTextBoxNome.Location = new Point(193, 54);
            materialTextBoxNome.MaxLength = 50;
            materialTextBoxNome.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxNome.Multiline = false;
            materialTextBoxNome.Name = "materialTextBoxNome";
            materialTextBoxNome.Size = new Size(449, 50);
            materialTextBoxNome.TabIndex = 1;
            materialTextBoxNome.Text = "";
            materialTextBoxNome.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(193, 32);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(108, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Nome Paciente";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(601, 644);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(105, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "CONSULTAR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // dataGridViewConsultaPessoa
            // 
            dataGridViewConsultaPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultaPessoa.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewConsultaPessoa.Location = new Point(14, 159);
            dataGridViewConsultaPessoa.Name = "dataGridViewConsultaPessoa";
            dataGridViewConsultaPessoa.Size = new Size(1270, 476);
            dataGridViewConsultaPessoa.TabIndex = 1;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(516, 644);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(77, 36);
            materialButton2.TabIndex = 85;
            materialButton2.Text = "VOLTAR";
            materialButton2.TextAlign = ContentAlignment.MiddleRight;
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // UcConsultaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialButton1);
            Controls.Add(materialButton2);
            Controls.Add(dataGridViewConsultaPessoa);
            Controls.Add(materialCard1);
            Name = "UcConsultaPaciente";
            Size = new Size(1298, 704);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultaPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxId;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DataGridView dataGridViewConsultaPessoa;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxCPF;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}
