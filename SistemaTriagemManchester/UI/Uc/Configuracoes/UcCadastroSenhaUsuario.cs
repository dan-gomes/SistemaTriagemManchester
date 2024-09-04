using SistemaTriagemManchester.Aplicacao;
using SistemaTriagemManchester.Aplicacao.Interfaces;
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

namespace SistemaTriagemManchester.UI.Uc.Configuracoes
{
    public partial class UcCadastroSenhaUsuario : UserControl
    {
        private readonly IUsuarioAplicacao _usuarioAplicacao;
        private readonly INavigationManager _navigationManager;
        private Panel _parentPanel;

        public UcCadastroSenhaUsuario(IUsuarioAplicacao usuarioAplicacao, INavigationManager navigationManager)
        {
            _usuarioAplicacao = usuarioAplicacao;
            _navigationManager = navigationManager;
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialMaskedTextBoxConfirmacaoSenha.Text != materialMaskedTextBoxSenha.Text)
            {
                MessageBox.Show("Senha não corresponde!");
                return;
            }

            if (_usuarioAplicacao.GravarSenhaUsuario(new Dominio.Modelos.UsuarioSenhaModelo { Senha = materialMaskedTextBoxSenha.Text, CPF = materialTextBoxCPF.Text }))
            {
                MessageBox.Show("Senha gravada com sucesso!");
                _navigationManager.NavigateBack();
            }
        }
    }
}
