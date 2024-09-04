namespace SistemaTriagemManchester
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPageInicio = new TabPage();
            tabPageAcolhimento = new TabPage();
            tabPageCadastro = new TabPage();
            tabHistoricoPaciente = new TabPage();
            tabPageDashboard = new TabPage();
            tabRelatorios = new TabPage();
            tabConfiguracoes = new TabPage();
            tabePageSair = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPageInicio);
            materialTabControl1.Controls.Add(tabPageAcolhimento);
            materialTabControl1.Controls.Add(tabPageCadastro);
            materialTabControl1.Controls.Add(tabHistoricoPaciente);
            materialTabControl1.Controls.Add(tabPageDashboard);
            materialTabControl1.Controls.Add(tabRelatorios);
            materialTabControl1.Controls.Add(tabConfiguracoes);
            materialTabControl1.Controls.Add(tabePageSair);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1360, 701);
            materialTabControl1.TabIndex = 1;
            materialTabControl1.Selected += MaterialTabControl1_Selected;
            // 
            // tabPageInicio
            // 
            tabPageInicio.BackColor = Color.White;
            tabPageInicio.ImageKey = "home.png";
            tabPageInicio.Location = new Point(4, 39);
            tabPageInicio.Name = "tabPageInicio";
            tabPageInicio.Padding = new Padding(3);
            tabPageInicio.Size = new Size(1352, 658);
            tabPageInicio.TabIndex = 0;
            tabPageInicio.Text = "Inicio";
            tabPageInicio.Click += TabPageInicio_Click;
            // 
            // tabPageAcolhimento
            // 
            tabPageAcolhimento.BackColor = Color.White;
            tabPageAcolhimento.ImageKey = "triagem.png";
            tabPageAcolhimento.Location = new Point(4, 39);
            tabPageAcolhimento.Name = "tabPageAcolhimento";
            tabPageAcolhimento.Padding = new Padding(3);
            tabPageAcolhimento.Size = new Size(1352, 658);
            tabPageAcolhimento.TabIndex = 1;
            tabPageAcolhimento.Text = "Acolhimento";
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.BackColor = Color.White;
            tabPageCadastro.ImageKey = "usuario-confirmado.png";
            tabPageCadastro.Location = new Point(4, 39);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Size = new Size(1352, 658);
            tabPageCadastro.TabIndex = 2;
            tabPageCadastro.Text = "Cadastro";
            // 
            // tabHistoricoPaciente
            // 
            tabHistoricoPaciente.ImageKey = "historico.png";
            tabHistoricoPaciente.Location = new Point(4, 39);
            tabHistoricoPaciente.Name = "tabHistoricoPaciente";
            tabHistoricoPaciente.Size = new Size(1352, 658);
            tabHistoricoPaciente.TabIndex = 4;
            tabHistoricoPaciente.Text = "Histórico";
            tabHistoricoPaciente.UseVisualStyleBackColor = true;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.ImageKey = "dashboard.png";
            tabPageDashboard.Location = new Point(4, 39);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Size = new Size(1352, 658);
            tabPageDashboard.TabIndex = 7;
            tabPageDashboard.Text = "Dashboard";
            tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // tabRelatorios
            // 
            tabRelatorios.ImageKey = "realtorios.png";
            tabRelatorios.Location = new Point(4, 39);
            tabRelatorios.Name = "tabRelatorios";
            tabRelatorios.Size = new Size(1352, 658);
            tabRelatorios.TabIndex = 5;
            tabRelatorios.Text = "Relatórios";
            tabRelatorios.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracoes
            // 
            tabConfiguracoes.ImageKey = "configuracoes.png";
            tabConfiguracoes.Location = new Point(4, 39);
            tabConfiguracoes.Name = "tabConfiguracoes";
            tabConfiguracoes.Size = new Size(1352, 658);
            tabConfiguracoes.TabIndex = 6;
            tabConfiguracoes.Text = "Configurações";
            tabConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // tabePageSair
            // 
            tabePageSair.BackColor = Color.White;
            tabePageSair.ImageKey = "sair.png";
            tabePageSair.Location = new Point(4, 39);
            tabePageSair.Name = "tabePageSair";
            tabePageSair.Size = new Size(1352, 658);
            tabePageSair.TabIndex = 3;
            tabePageSair.Text = "Sair";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "triagem.png");
            imageList1.Images.SetKeyName(2, "usuario-confirmado.png");
            imageList1.Images.SetKeyName(3, "mais.png");
            imageList1.Images.SetKeyName(4, "sair.png");
            imageList1.Images.SetKeyName(5, "aviso.png");
            imageList1.Images.SetKeyName(6, "configuracoes.png");
            imageList1.Images.SetKeyName(7, "dashboard.png");
            imageList1.Images.SetKeyName(8, "historico.png");
            imageList1.Images.SetKeyName(9, "realtorios.png");
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1366, 768);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Triagem Manchester";
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }








        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabHistoricoPaciente;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ImageList imageList1;
        private TabPage tabPageAcolhimento;
        private TabPage tabPageCadastro;
        private TabPage tabePageSair;
        private TabPage tabPageInicio;
        private TabPage tabPageDashboard;
        private TabPage tabRelatorios;
        private TabPage tabConfiguracoes;
    }
}