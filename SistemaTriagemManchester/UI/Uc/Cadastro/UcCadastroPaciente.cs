using MaterialSkin.Controls;
using SistemaTriagemManchester.Aplicacao;
using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;
using SistemaTriagemManchester.Dominio.Enums;
using SistemaTriagemManchester.Dominio.Modelos;
using System.Windows.Forms;

namespace SistemaTriagemManchester.UI.Uc
{
    public partial class UcCadastroPaciente : UserControl
    {
        private readonly INavigationManager _navigationManager;
        private readonly IPessoaAplicacao _pessoaAplicacao;

        public UcCadastroPaciente(INavigationManager navigationManager, IPessoaAplicacao pessoaAplicacao)
        {
            _navigationManager = navigationManager;
            _pessoaAplicacao = pessoaAplicacao;
            InitializeComponent();
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            var pessoa = new PessoaModelo(materialTextBoxNome.Text,
                                         comboSexo.Text,
                                         DateTime.Parse(materialMaskedTextBoxDataNascimento.Text),
                                         materialMaskedTextBoxCPF.Text,
                                         materialComboBoxEstadoCivil.Text,
                                         materialMaskedTextBoxCelular.Text,
                                         materialTextBoxEmail.Text,
                                         TipoPessoa.Paciente);

            var endereco = new EnderecoModelo(materialMaskedTextBoxCep.Text,
                                              materialTextLogradouro.Text,
                                              materialTextBoxBairro.Text,
                                              materialTextBoxCidade.Text,
                                              materialComboBoxEstado.Text,
                                              materialMaskedTextBoxNumero.Text);

            var doencas = materialMultiLineTextBoxDoencas.Text.Split(';');
            var observacoes = materialMultiLineTextBoxDoencas.Text.Split(';');

            List<DoencaPreExistenteModelo> doencasPreExistenteModelo = [];

            for (int i = 0; i < doencas.Length; i++)
            {
                doencasPreExistenteModelo.Add(new DoencaPreExistenteModelo
                {
                    Nome = doencas[i].Trim(),
                    Observacao = observacoes[i].Trim()
                });
            }

            if (_pessoaAplicacao.GravaPessoaCompleta(pessoa, endereco, doencasPreExistenteModelo))
            {
                MessageBox.Show("Pessoa cadastrada com sucesso!");
                _navigationManager.NavigateBack();
            }
            else
            {
                MessageBox.Show("Falha ao gravar pessoa, tente novamente!");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            _navigationManager.NavigateBack();
        }
    }
}
