using MaterialSkin;
using MaterialSkin.Controls;
using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;
using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.UI.Uc;
using SistemaTriagemManchester.UI.Uc.Configuracoes;

namespace SistemaTriagemManchester
{
    public partial class FormPrincipal : MaterialForm
    {
        private readonly IPacienteAplicacao _pacienteAplicacao;
        private readonly IUserControlManager _userControlManage;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public FormPrincipal(IPacienteAplicacao pacienteAplicacao, IUserControlManager userControlManager)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            _pacienteAplicacao = pacienteAplicacao;
            _userControlManage = userControlManager;
        }

        private void TabPageInicio_Click(object sender, EventArgs e)
        {

        }

        private void MaterialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == tabPageInicio.Name)
            {
                tabPageInicio.Controls.Clear();
                tabPageInicio.Controls.Add(_userControlManage.GetUserControl(UserControlEnum.UcFilaAtendimentoPaciente));
            }
            else if (e.TabPage.Name == tabPageCadastro.Name)
            {
                tabPageCadastro.Controls.Clear();
                tabPageCadastro.Controls.Add(_userControlManage.GetUserControl(UserControlEnum.UcCadastro));
            }
            else if (e.TabPage.Name == tabPageAcolhimento.Name)
            {
                tabPageAcolhimento.Controls.Clear();
                tabPageAcolhimento.Controls.Add(_userControlManage.GetUserControl(UserControlEnum.UcTriagemPaciente));
            }
            else if (e.TabPage.Name == tabPageDashboard.Name)
            {
                tabPageDashboard.Controls.Clear();
                tabPageDashboard.Controls.Add(_userControlManage.GetUserControl(UserControlEnum.UcDashboard));
            }
            else if (e.TabPage.Name == tabConfiguracoes.Name)
            {
                tabConfiguracoes.Controls.Clear();
                tabConfiguracoes.Controls.Add(_userControlManage.GetUserControl(UserControlEnum.UcConfiguracao));
            }
            else if (e.TabPage.Name == tabRelatorios.Name)
            {
                tabRelatorios.Controls.Clear();
                tabRelatorios.Controls.Add(_userControlManage.GetUserControl(UserControlEnum.UcRelatorio));
            }
            else if (e.TabPage.Name == tabHistoricoPaciente.Name)
            {
                tabHistoricoPaciente.Controls.Clear();
                tabHistoricoPaciente.Controls.Add(_userControlManage.GetUserControl(UserControlEnum.UcHistorico));
            }
            else if (e.TabPage.Name == tabePageSair.Name)
            {
                Application.Exit();
            }
        }
    }
}
