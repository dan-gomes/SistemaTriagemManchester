namespace SistemaTriagemManchester.Apresentacao.UI.Uc
{
    partial class UcButtons
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
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(4, 6);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(96, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "CANCELAR";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(108, 6);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(105, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "CONFIRMAR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // UcButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Name = "UcButtons";
            Size = new Size(221, 49);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
