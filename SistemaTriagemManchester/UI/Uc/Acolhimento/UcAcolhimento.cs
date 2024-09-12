using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTriagemManchester.Apresentacao.UI.Uc.Acolhimento
{
    public partial class UcAcolhimento : UserControl
    {
        private readonly INavigationManager _navigationManager;
        public UcAcolhimento(INavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            InitializeComponent();
            navigationManager.DefinirUserControlAtual(this);
        }

        public override void Refresh()
        {
            base.Refresh();
            panelButtons.Visible = true;
        }

        private void UcCadastro_Load(object sender, EventArgs e)
        {

        }

        private void materialButtonTriagem_Click(object sender, EventArgs e)
        {
            panelButtons.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcTriagemPaciente, panelAcolhimento);
        }

        private void materialButtonAtendimento_Click(object sender, EventArgs e)
        {
            panelButtons.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcAtendimentoPaciente, panelAcolhimento);
        }
    }
}
