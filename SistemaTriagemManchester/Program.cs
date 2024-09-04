using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SistemaTriagemManchester.Aplicacao;
using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI;
using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;
using SistemaTriagemManchester.Apresentacao.UI.Uc.Atendimento;
using SistemaTriagemManchester.Apresentacao.UI.Uc.Configuracoes;
using SistemaTriagemManchester.Apresentacao.UI.Uc.Historico;
using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Infra;
using SistemaTriagemManchester.Infra.Repositorios;
using SistemaTriagemManchester.UI.Uc;
using SistemaTriagemManchester.UI.Uc.Atendimento;
using SistemaTriagemManchester.UI.Uc.Configuracoes;
using SistemaTriagemManchester.UI.Uc.Dashboard;
using SistemaTriagemManchester.UI.Uc.Historico;
using SistemaTriagemManchester.UI.Uc.Relatorios;
using System.Windows.Forms;

namespace SistemaTriagemManchester
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();

            // Usar o host para criar um escopo de serviços
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                // Recuperar a instância principal do formulário e iniciar a aplicação
                var loginForm = services.GetRequiredService<FormLogin>();
                var mainForm = services.GetRequiredService<FormPrincipal>();
                Application.Run(mainForm);
            }
        }

        static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<SistemaTriagemManchesterContext>(options =>
                    options.UseNpgsql("Host=localhost;Database=triagemmanchester;Username=postgres;Password=admin"));

                services.AddTransient<IDoencaPreExistenteAplicacao, DoencaPreExistenteAplicacao>();
                services.AddTransient<IClassificacaoAplicacao, ClassificacaoAplicacao>();
                services.AddTransient<IPacienteAplicacao, PacienteAplicacao>();
                services.AddTransient<IEspecialidadeAplicacao, EspecialidadeAplicacao>();
                services.AddTransient<ICargoAplicacao, CargoAplicacao>();
                services.AddTransient<ICargoRepositorio, CargoRepositorio>();

                AddServicesApresentacao(services);

                services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

                services.AddTransient<IDoencaPreExistenteRepositorio, DoencaPreExistenteRepositorio>();
                services.AddTransient<IPacienteRepositorio, PacienteRepositorio>();
                services.AddTransient<IEspecialidadeRepositorio, EspecialidadeRepositorio>();
                services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
                services.AddTransient<IUrgenciaRepositorio, UrgenciaRepositorio>();
                services.AddTransient<ITriagemRepositorio, TriagemRepositorio>();
                services.AddTransient<ISintomaRepositorio, SintomaRepostiorio>();
                services.AddTransient<IEnderecoRepositorio, EnderecoRepositorio>();
                services.AddTransient<IPessoaRepositorio, PessoaRepositorio>();
                services.AddTransient<IPessoaDoencaPreExistenteRepositorio, PessoaDoencaPreExistenteRepositorio>();
                services.AddTransient<IDoencaPreExistenteRepositorio, DoencaPreExistenteRepositorio>();
                services.AddTransient<IInformacoesProfissionaisRepositorio, InformacoesProfissionaisRepositorio>();

                services.AddScoped<IUsuarioAplicacao, UsuarioAplicacao>();
                services.AddScoped<IEnderecoAplicacao, EnderecoAplicacao>();
                services.AddScoped<IPessoaAplicacao, PessoaAplicacao>();
                services.AddScoped<IInformacoesProfissionaisAplicacao, InformacoesProfissionaisAplicacao>();
                services.AddScoped<ITriagemAplicacao, TriagemAplicacao>();
                services.AddScoped<IPacienteAplicacao, PacienteAplicacao>();

            });

        private static void AddServicesApresentacao(IServiceCollection services)
        {
            services.AddSingleton<IUserControlManager, UserControlManager>();
            services.AddSingleton<INavigationManager, NavigationManager>();
            services.AddTransient<FormPrincipal>();
            services.AddTransient<FormLogin>();

            AddServicesTriagem(services);
            AddServicesUsuario(services);
            AddServicesPaciente(services);
            AddServicesAtendimento(services);
            AddServicesHistorico(services);
            AddServicesDashboard(services);
            AddServicesRelatorio(services);
        }

        private static void AddServicesTriagem(IServiceCollection services)
        {
            services.AddTransient<UcTriagemPaciente>();
        }

        private static void AddServicesDashboard(IServiceCollection services)
        {
            services.AddTransient<UcDashboard>();
        }

        private static void AddServicesRelatorio(IServiceCollection services)
        {
            services.AddTransient<UcRelatorio>();
        }

        private static void AddServicesUsuario(IServiceCollection services)
        {
            services.AddTransient<UcCadastroSenhaUsuario>();
            services.AddTransient<UcCadastroUsuario>();
            services.AddTransient<UcConfiguracao>();
        }

        private static void AddServicesPaciente(IServiceCollection services)
        {
            services.AddTransient<UcCadastro>();
            services.AddTransient<UcCadastroPaciente>();
            services.AddTransient<UcConsultaPaciente>();
        }

        private static void AddServicesAtendimento(IServiceCollection services)
        {
            services.AddTransient<UcAtendimentoDiagnostico>();
            services.AddTransient<UcAtendimentoPaciente>();
            services.AddTransient<UcAtendimentoPacienteHistorico>();
            services.AddTransient<UcAtendimentoPlanoTratamento>();
            services.AddTransient<UcAtendimentoIdentificacaoPaciente>();
            services.AddTransient<UcConclusaoAtendimento>();
            services.AddTransient<UcFilaAtendimentoPaciente>();
            services.AddTransient<UcAtendimentoExameFisico>();
        }

        private static void AddServicesHistorico(IServiceCollection services)
        {
            services.AddTransient<UcHistorico>();
            services.AddTransient<UcHistoricoConsultas>();
            services.AddTransient<UcHistoricoExames>();
            services.AddTransient<UcHistoricoIdentificacaoPaciente>();
            services.AddTransient<UcHistoricoTriagens>();
        }
    }
}