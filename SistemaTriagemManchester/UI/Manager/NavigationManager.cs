using SistemaTriagemManchester.Apresentacao.UI.Interfaces;

namespace SistemaTriagemManchester.Apresentacao.UI.Manager
{
    public class NavigationManager : INavigationManager
    {
        private readonly IUserControlManager _userControlManager;

        private UserControl _currentControl;
        private UserControl _previousControl;
        private Panel _mainPanel;
        private UserControl _userControlMain;

        public NavigationManager(IUserControlManager userControlManager)
        {
            _userControlManager = userControlManager;
        }

        public void DefinirUserControlAtual(UserControl userControl)
        {
            _currentControl = userControl;
            _userControlMain = userControl;
        }


        // Navega para um novo UserControl e descarta o anterior
        public void NavigateTo(UserControlEnum userControlEnumNovo, Panel mainPanel = null)
        {
            if (mainPanel != null)
                _mainPanel = mainPanel;

            if (_mainPanel == null)
                return;

            var newControl = _userControlManager.GetUserControl(userControlEnumNovo);

            // Limpa o painel atual
            _mainPanel.Controls.Clear();

            // Descartar o controle anterior, se houver
            if (_previousControl != null && _previousControl.Name != _userControlMain.Name)
            {
                _previousControl.Dispose();
                _previousControl = null; // Libera a referência
            }

            // Define o controle atual como o controle anterior
            if (_currentControl != null)
            {
                _previousControl = _currentControl;
            }

            // Define o novo controle como o controle atual
            _currentControl = newControl;

            // Adiciona o novo controle ao painel
            _mainPanel.Controls.Add(_currentControl);
        }

        // Navega de volta para o UserControl anterior
        public void NavigateBack()
        {
            // Limpa o painel atual
            _mainPanel.Controls.Clear();

            // Se não houver controle anterior, simplesmente retorna
            if (_previousControl == null)
            {
                return;
            }

            // Descartar o controle atual, já que estamos voltando ao anterior
            _currentControl?.Dispose();

            // Define o controle anterior como o controle atual
            _currentControl = _previousControl;
            _previousControl = null; // Liberar a referência ao controle anterior


            if (_currentControl.Controls.Contains(_mainPanel))
            {
                _currentControl.Refresh();
                return;
            }

            // Adiciona o controle atual ao painel
            _mainPanel.Controls.Add(_currentControl);
        }

        public Panel ObterPaienl() => _mainPanel;
    }
}
