namespace SistemaTriagemManchester.UI.Uc
{
    partial class UcCadastro
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
            panelcadastro = new Panel();
            materialButtonCadastrar = new MaterialSkin.Controls.MaterialButton();
            materialButtonConsultar = new MaterialSkin.Controls.MaterialButton();
            panelpaciente = new Panel();
            panelpaciente.SuspendLayout();
            SuspendLayout();
            // 
            // panelcadastro
            // 
            panelcadastro.Location = new Point(3, 3);
            panelcadastro.Name = "panelcadastro";
            panelcadastro.Size = new Size(1292, 698);
            panelcadastro.TabIndex = 2;
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
            materialButtonCadastrar.TabIndex = 5;
            materialButtonCadastrar.TabStop = false;
            materialButtonCadastrar.Text = "CADASTRAR";
            materialButtonCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButtonCadastrar.UseAccentColor = false;
            materialButtonCadastrar.UseVisualStyleBackColor = true;
            materialButtonCadastrar.Click += materialButtonCadastrar_Click;
            // 
            // materialButtonConsultar
            // 
            materialButtonConsultar.AutoSize = false;
            materialButtonConsultar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonConsultar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonConsultar.Depth = 0;
            materialButtonConsultar.HighEmphasis = true;
            materialButtonConsultar.Icon = null;
            materialButtonConsultar.Location = new Point(229, 6);
            materialButtonConsultar.Margin = new Padding(4, 6, 4, 6);
            materialButtonConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonConsultar.Name = "materialButtonConsultar";
            materialButtonConsultar.NoAccentTextColor = Color.Empty;
            materialButtonConsultar.Size = new Size(200, 100);
            materialButtonConsultar.TabIndex = 4;
            materialButtonConsultar.TabStop = false;
            materialButtonConsultar.Text = "CONSULTAR";
            materialButtonConsultar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonConsultar.UseAccentColor = false;
            materialButtonConsultar.UseVisualStyleBackColor = true;
            materialButtonConsultar.Click += materialButtonConsultar_Click;
            // 
            // panelpaciente
            // 
            panelpaciente.Controls.Add(materialButtonCadastrar);
            panelpaciente.Controls.Add(materialButtonConsultar);
            panelpaciente.Location = new Point(399, 256);
            panelpaciente.Name = "panelpaciente";
            panelpaciente.Size = new Size(436, 114);
            panelpaciente.TabIndex = 6;
            // 
            // UcCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelpaciente);
            Controls.Add(panelcadastro);
            Name = "UcCadastro";
            Size = new Size(1298, 704);
            Load += UcCadastro_Load;
            panelpaciente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelcadastro;
        private MaterialSkin.Controls.MaterialButton materialButtonConsultar;
        private MaterialSkin.Controls.MaterialButton materialButtonCadastrar;
        private Panel panelpaciente;
    }
}
