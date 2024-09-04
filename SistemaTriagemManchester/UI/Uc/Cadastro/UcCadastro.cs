using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;

namespace SistemaTriagemManchester.UI.Uc
{
    public partial class UcCadastro : UserControl
    {
        private readonly INavigationManager _navigationManager;
        public UcCadastro(INavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            InitializeComponent();
            navigationManager.DefinirUserControlAtual(this);
        }
        public override void Refresh()
        {
            base.Refresh();
            panelpaciente.Visible = true;
        }

        private void materialButtonCadastrar_Click(object sender, EventArgs e)
        {
            panelpaciente.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcCadastroPaciente, panelcadastro);
        }

        private void materialButtonConsultar_Click(object sender, EventArgs e)
        {
            panelpaciente.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcConsultaPaciente, panelcadastro);
        }

        private void UcCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
