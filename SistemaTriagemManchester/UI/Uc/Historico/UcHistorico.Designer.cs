namespace SistemaTriagemManchester.UI.Uc
{
    partial class UcHistorico
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
            BtnConsultas = new MaterialSkin.Controls.MaterialButton();
            BtnTriagens = new MaterialSkin.Controls.MaterialButton();
            BtnExames = new MaterialSkin.Controls.MaterialButton();
            panelButtons = new Panel();
            panelHistorico = new Panel();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // BtnConsultas
            // 
            BtnConsultas.AutoSize = false;
            BtnConsultas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnConsultas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnConsultas.Depth = 0;
            BtnConsultas.HighEmphasis = true;
            BtnConsultas.Icon = null;
            BtnConsultas.Location = new Point(4, 6);
            BtnConsultas.Margin = new Padding(4, 6, 4, 6);
            BtnConsultas.MouseState = MaterialSkin.MouseState.HOVER;
            BtnConsultas.Name = "BtnConsultas";
            BtnConsultas.NoAccentTextColor = Color.Empty;
            BtnConsultas.Size = new Size(200, 100);
            BtnConsultas.TabIndex = 0;
            BtnConsultas.TabStop = false;
            BtnConsultas.Text = "CONSULTAS";
            BtnConsultas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnConsultas.UseAccentColor = false;
            BtnConsultas.UseVisualStyleBackColor = true;
            BtnConsultas.Click += BtnConsultas_Click;
            // 
            // BtnTriagens
            // 
            BtnTriagens.AutoSize = false;
            BtnTriagens.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnTriagens.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnTriagens.Depth = 0;
            BtnTriagens.HighEmphasis = true;
            BtnTriagens.Icon = null;
            BtnTriagens.Location = new Point(454, 6);
            BtnTriagens.Margin = new Padding(4, 6, 4, 6);
            BtnTriagens.MouseState = MaterialSkin.MouseState.HOVER;
            BtnTriagens.Name = "BtnTriagens";
            BtnTriagens.NoAccentTextColor = Color.Empty;
            BtnTriagens.Size = new Size(200, 100);
            BtnTriagens.TabIndex = 1;
            BtnTriagens.TabStop = false;
            BtnTriagens.Text = "TRIAGENS";
            BtnTriagens.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnTriagens.UseAccentColor = false;
            BtnTriagens.UseVisualStyleBackColor = true;
            BtnTriagens.Click += BtnTriagens_Click;
            // 
            // BtnExames
            // 
            BtnExames.AutoSize = false;
            BtnExames.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnExames.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnExames.Depth = 0;
            BtnExames.HighEmphasis = true;
            BtnExames.Icon = null;
            BtnExames.Location = new Point(229, 6);
            BtnExames.Margin = new Padding(4, 6, 4, 6);
            BtnExames.MouseState = MaterialSkin.MouseState.HOVER;
            BtnExames.Name = "BtnExames";
            BtnExames.NoAccentTextColor = Color.Empty;
            BtnExames.Size = new Size(200, 100);
            BtnExames.TabIndex = 2;
            BtnExames.TabStop = false;
            BtnExames.Text = "EXAMES";
            BtnExames.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnExames.UseAccentColor = false;
            BtnExames.UseVisualStyleBackColor = true;
            BtnExames.Click += BtnExames_Click;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(BtnExames);
            panelButtons.Controls.Add(BtnConsultas);
            panelButtons.Controls.Add(BtnTriagens);
            panelButtons.Location = new Point(236, 238);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(661, 114);
            panelButtons.TabIndex = 3;
            // 
            // panelHistorico
            // 
            panelHistorico.Location = new Point(3, 3);
            panelHistorico.Name = "panelHistorico";
            panelHistorico.Size = new Size(1292, 698);
            panelHistorico.TabIndex = 4;
            // 
            // UcHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelButtons);
            Controls.Add(panelHistorico);
            Name = "UcHistorico";
            Size = new Size(1298, 704);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BtnConsultas;
        private MaterialSkin.Controls.MaterialButton BtnTriagens;
        private MaterialSkin.Controls.MaterialButton BtnExames;
        private Panel panelButtons;
        private Panel panelHistorico;
    }
}
