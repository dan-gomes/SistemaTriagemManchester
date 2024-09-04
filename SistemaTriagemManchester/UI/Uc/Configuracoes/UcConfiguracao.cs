using MaterialSkin.Controls;
using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;
using SistemaTriagemManchester.UI.Uc.Configuracoes;

namespace SistemaTriagemManchester.Apresentacao.UI.Uc.Configuracoes
{
    public partial class UcConfiguracao : UserControl
    {

        private readonly INavigationManager _navigationManager;

        public UcConfiguracao(IUserControlManager userControlManager, INavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            navigationManager.DefinirUserControlAtual(this);
            InitializeComponent();
        }

        public override void Refresh()
        {
            base.Refresh();
            panelButtonsConfiguracao.Visible = true;
        }

        private void materialButtonCadastrar_Click(object sender, EventArgs e)
        {
            CarregarCadastroUsuario();
        }

        private void CarregarCadastroUsuario()
        {
            panelButtonsConfiguracao.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcCadastroUsuario, panelConfiguracao);
        }

        private void materialButtonAlterarSenha_Click(object sender, EventArgs e)
        {
            GravarSenhaUsuario();
        }

        private void GravarSenhaUsuario()
        {
            panelButtonsConfiguracao.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcCadastroSenhaUsuario, panelConfiguracao);
        }
    }
}
