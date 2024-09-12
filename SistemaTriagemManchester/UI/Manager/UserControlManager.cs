using Microsoft.Extensions.DependencyInjection;
using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Uc.Acolhimento;
using SistemaTriagemManchester.Apresentacao.UI.Uc.Configuracoes;
using SistemaTriagemManchester.UI.Uc;
using SistemaTriagemManchester.UI.Uc.Atendimento;
using SistemaTriagemManchester.UI.Uc.Configuracoes;
using SistemaTriagemManchester.UI.Uc.Dashboard;
using SistemaTriagemManchester.UI.Uc.Historico;
using SistemaTriagemManchester.UI.Uc.Relatorios;

namespace SistemaTriagemManchester.Apresentacao.UI.Manager
{
    public class UserControlManager : IUserControlManager
    {
        private readonly IServiceProvider _serviceProvider;

        public UserControlManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public UserControl GetUserControl(UserControlEnum nome)
        {
            switch (nome)
            {
                case UserControlEnum.UcCadastroSenhaUsuario:
                    return _serviceProvider.GetRequiredService<UcCadastroSenhaUsuario>();
                case UserControlEnum.UcCadastroUsuario:
                    return _serviceProvider.GetRequiredService<UcCadastroUsuario>();
                case UserControlEnum.UcCadastro:
                    return _serviceProvider.GetRequiredService<UcCadastro>();
                case UserControlEnum.UcCadastroPaciente:
                    return _serviceProvider.GetRequiredService<UcCadastroPaciente>();
                case UserControlEnum.UcConsultaPaciente:
                    return _serviceProvider.GetRequiredService<UcConsultaPaciente>();
                case UserControlEnum.UcAtendimentoDiagnostico:
                    return _serviceProvider.GetRequiredService<UcAtendimentoDiagnostico>();
                case UserControlEnum.UcAtendimentoExameFisico:
                    return _serviceProvider.GetRequiredService<UcAtendimentoExameFisico>();
                case UserControlEnum.UcAtendimentoPaciente:
                    return _serviceProvider.GetRequiredService<UcAtendimentoPaciente>();
                case UserControlEnum.UcAtendimentoPacienteHistorico:
                    return _serviceProvider.GetRequiredService<UcAtendimentoPacienteHistorico>();
                case UserControlEnum.UcAtendimentoPlanoTratamento:
                    return _serviceProvider.GetRequiredService<UcAtendimentoPlanoTratamento>();
                case UserControlEnum.UcConclusaoAtendimento:
                    return _serviceProvider.GetRequiredService<UcConclusaoAtendimento>();
                case UserControlEnum.UcFilaAtendimentoPaciente:
                    return _serviceProvider.GetRequiredService<UcFilaAtendimentoPaciente>();
                case UserControlEnum.UcDashboard:
                    return _serviceProvider.GetRequiredService<UcDashboard>();
                case UserControlEnum.UcHistorico:
                    return _serviceProvider.GetRequiredService<UcHistorico>();
                case UserControlEnum.UcHistoricoConsultas:
                    return _serviceProvider.GetRequiredService<UcHistoricoConsultas>();
                case UserControlEnum.UcHistoricoExames:
                    return _serviceProvider.GetRequiredService<UcHistoricoExames>();
                case UserControlEnum.UcHistoricoTriagens:
                    return _serviceProvider.GetRequiredService<UcHistoricoTriagens>();
                case UserControlEnum.UcRelatorio:
                    return _serviceProvider.GetRequiredService<UcRelatorio>();
                case UserControlEnum.UcTriagemPaciente:
                    return _serviceProvider.GetRequiredService<UcTriagemPaciente>();
                case UserControlEnum.UcConfiguracao:
                    return _serviceProvider.GetRequiredService<UcConfiguracao>();
                case UserControlEnum.UcAcolhimento:
                    return _serviceProvider.GetRequiredService<UcAcolhimento>();
                default:
                    throw new ArgumentException("Chave inválida para UserControl", nameof(nome));
            }
        }
    }
}
