using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;
using SistemaTriagemManchester.Dominio.Enums;
using SistemaTriagemManchester.Dominio.Modelos;
using System.Windows.Forms;

namespace SistemaTriagemManchester.UI.Uc.Configuracoes
{
    public partial class UcCadastroUsuario : UserControl
    {
        private readonly IUsuarioAplicacao _usuarioAplicacao;
        private readonly INavigationManager _navigationManager;
        private Panel _parentPanel;

        public UcCadastroUsuario(IUsuarioAplicacao usuarioAplicacao, ICargoAplicacao cargoAplicacao, IEspecialidadeAplicacao especialidade, INavigationManager navigationManager)
        {
            _usuarioAplicacao = usuarioAplicacao;
            _navigationManager = navigationManager;

            InitializeComponent();

            materialComboBoxCargo.DataSource = cargoAplicacao.ObterCargos();
            materialComboBoxEspecialidade.DataSource = especialidade.ObterEspecialidades();
        }

        public bool GravarUsuario()
        {
            var pessoa = new PessoaModelo(materialTextBoxNome.Text,
                                          comboSexo.Text,
                                          DateTime.Parse(materialMaskedTextBoxDataNascimento.Text),
                                          materialMaskedTextBoxCPF.Text,
                                          materialComboBoxEstadoCivil.Text,
                                          materialMaskedTextBoxCelular.Text,
                                          materialTextBoxEmail.Text,
                                          TipoPessoa.Funcionario);

            var endereco = new EnderecoModelo(materialMaskedTextBoxCep.Text,
                                              materialTextLogradouro.Text,
                                              materialTextBoxBairro.Text,
                                              materialTextBoxCidade.Text,
                                              materialComboBoxEstado.Text,
                                              materialMaskedTextBoxNumero.Text);

            var informacoesAdicionais = new InformacoesProfissionaisModelo(materialTextBoxRegistroProfissional.Text,
                                                                           materialMultiLineTextBoxExperienciaProfissional.Text,
                                                                           materialMultiLineTextBoxIdomasFalado.Text,
                                                                           materialComboBoxHorario.Text,
                                                                           materialMultiLineTextBoxReferenciaProfissionais.Text);
            informacoesAdicionais.Cargo = (CargoModelo)materialComboBoxCargo.SelectedItem;
            informacoesAdicionais.Especialidade = (EspecialidadeModelo)materialComboBoxEspecialidade.SelectedItem;

            if (_usuarioAplicacao.GravarNovoUsuario(new UsuarioModelo
            {
                EnderecoModelo = endereco,
                InformacoesProfissionaisModelo = informacoesAdicionais,
                PessoaModelo = pessoa
            }))
            {
                MessageBox.Show("Novo usuário inserido, agora informe a senha para concluir");
                return true;
            }

            MessageBox.Show("Falha ao gravar usuário, tente novamente!");
            return false;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            _navigationManager.NavigateBack();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (GravarUsuario())
                _navigationManager.NavigateTo(UserControlEnum.UcCadastroSenhaUsuario);
        }
    }
}
