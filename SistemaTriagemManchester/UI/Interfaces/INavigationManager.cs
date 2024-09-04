using SistemaTriagemManchester.Apresentacao.UI.Manager;

namespace SistemaTriagemManchester.Apresentacao.UI.Interfaces
{
    public interface INavigationManager
    {
        void NavigateTo(UserControlEnum userControlEnum, Panel mainPanel = null);
        void NavigateBack();
        void DefinirUserControlAtual(UserControl userControl);
    }
}
