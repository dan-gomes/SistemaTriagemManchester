using Microsoft.EntityFrameworkCore;
using SistemaTriagemManchester.Infra.Mapeamentos;
using SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos;
using SistemaTriagemManchester.Infra.Mapeamentos.Paciente;
using SistemaTriagemManchester.Infra.Mapeamentos.Usuario;

namespace SistemaTriagemManchester.Infra
{
    public class SistemaTriagemManchesterContext : DbContext
    {
        public SistemaTriagemManchesterContext(DbContextOptions<SistemaTriagemManchesterContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoencaPreExistenteMapeamento());
            modelBuilder.ApplyConfiguration(new PessoaDoencaPreExistenteMapeamento());
            modelBuilder.ApplyConfiguration(new PacienteMapeamento());
            modelBuilder.ApplyConfiguration(new CargoMapeamento());
            modelBuilder.ApplyConfiguration(new EspecialidadeMapeamento());
            modelBuilder.ApplyConfiguration(new InformacoesProfissionaisMapeamento());
            modelBuilder.ApplyConfiguration(new PessoaMapeamento());
            modelBuilder.ApplyConfiguration(new EnderecoMapeamento());
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());
            modelBuilder.ApplyConfiguration(new AtendimentoMapeamento());
            modelBuilder.ApplyConfiguration(new AvaliacaoMapeamento());
            modelBuilder.ApplyConfiguration(new DiagnosticoMapeamento());
            modelBuilder.ApplyConfiguration(new HistoricoMedicoMapeamento());
            modelBuilder.ApplyConfiguration(new ProcedimentoMapeamento());
            modelBuilder.ApplyConfiguration(new AcompanhamentoMapeamento());
            modelBuilder.ApplyConfiguration(new TriagemMapeamento());
            modelBuilder.ApplyConfiguration(new SintomaMapeamento());
            modelBuilder.ApplyConfiguration(new UrgenciaMapeamento());

        }
    }
}
