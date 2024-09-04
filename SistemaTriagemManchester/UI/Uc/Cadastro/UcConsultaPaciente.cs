using SistemaTriagemManchester.Aplicacao;
using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.UI.Uc
{
    public partial class UcConsultaPaciente : UserControl
    {
        private readonly INavigationManager _navigationManager;
        private readonly IPessoaAplicacao _pessoaAplicacao;

        public UcConsultaPaciente(INavigationManager navigationManager, IPessoaAplicacao pessoaAplicacao)
        {
            _navigationManager = navigationManager;
            _pessoaAplicacao = pessoaAplicacao;
            InitializeComponent();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            _navigationManager.NavigateBack();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialTextBoxId.Text) && string.IsNullOrEmpty(materialMaskedTextBoxCPF.Text) && string.IsNullOrEmpty(materialTextBoxNome.Text))
            {
                dataGridViewConsultaPessoa.DataSource = _pessoaAplicacao.ObterTodos();
            }
            else
            {
                dataGridViewConsultaPessoa.DataSource = _pessoaAplicacao.Obter(new PessoaModelo { Id = int.Parse(materialTextBoxId.Text), CPF = materialMaskedTextBoxCPF.Text, NomeCompleto = materialTextBoxNome.Text });
            }
        }
    }
}
