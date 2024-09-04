using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos
{
    public class TriagemMapeamento : IEntityTypeConfiguration<Triagem>
    {
        public void Configure(EntityTypeBuilder<Triagem> builder)
        {
            builder.ToTable("triagens");
            builder.HasKey(t => t.Id);

            builder.Property(d => d.Id)
                   .HasColumnName("id");

            builder.Property(d => d.IdPaciente)
                  .HasColumnName("idpaciente");

            builder.Property(t => t.DataHora)
                .HasColumnName("datahora")
                   .IsRequired()
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Sinais).HasColumnName("sinais")
                   .HasColumnType("text");

            builder.Property(t => t.Sintomas).HasColumnName("sintomas")
                   .HasColumnType("text");

            builder.Property(t => t.Imunizacao).HasColumnName("imunizacao")
                   .HasColumnType("text");

            builder.Property(t => t.HistoricoCirurgico).HasColumnName("historicocirurgico")
                   .HasColumnType("text");

            builder.Property(t => t.HistoricoClinico).HasColumnName("historicoclinico")
                   .HasColumnType("text");

            builder.Property(t => t.HistoricoAlergico).HasColumnName("historicoalergico")
                   .HasColumnType("text");

            builder.Property(t => t.PAS).HasColumnName("pas")
                   .HasColumnType("varchar(20)");

            builder.Property(t => t.Temperatura).HasColumnName("temperatura")
                   .HasColumnType("varchar(20)");

            builder.Property(t => t.FrequenciaRespiratoria).HasColumnName("frequenciarespiratoria")
                   .HasColumnType("varchar(20)");

            builder.Property(t => t.FrequenciaCardiaca).HasColumnName("frequenciacardiaca")
                   .HasColumnType("varchar(20)");

            builder.Property(t => t.SaturacaoOxigenio).HasColumnName("saturacaooxigenio")
                   .HasColumnType("varchar(20)");

            builder.Property(t => t.Glicemia).HasColumnName("glicemia")
                   .HasColumnType("varchar(20)");

            builder.Property(t => t.Classificacao).HasColumnName("classificacao")
                   .HasColumnType("varchar(20)");

            builder.HasOne(t => t.Paciente)
                   .WithMany(p => p.Triagens)
                   .HasForeignKey(t => t.IdPaciente)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
