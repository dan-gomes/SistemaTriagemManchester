using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.Atendimentos;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos
{
    public class AvaliacaoMapeamento : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("avaliacoes");
            builder.HasKey(av => av.Id);

            builder.Property(av => av.Id)
                   .HasColumnName("id");

            builder.Property(d => d.IdAtendimento)
                   .HasColumnName("idatendimento");

            builder.Property(av => av.PressaoArterial)
                   .HasColumnName("pressaoarterial")
                   .HasColumnType("varchar(20)");

            builder.Property(av => av.FrequenciaCardiaca)
                   .HasColumnName("frequenciacardiaca")
                   .HasColumnType("varchar(20)");

            builder.Property(av => av.TemperaturaCorporal)
                   .HasColumnName("temperaturacorporal")
                   .HasColumnType("varchar(20)");

            builder.Property(av => av.FrequenciaRespiratoria)
                   .HasColumnName("frequenciarespiratoria")
                   .HasColumnType("varchar(20)");

            builder.Property(av => av.AvaliacaoFisica)
                   .HasColumnName("avaliacaofisica")
                   .HasColumnType("text");

            builder.Property(av => av.OutrasObservacoes)
                   .HasColumnName("outrasobservacoes")
                   .HasColumnType("text");

            builder.HasOne(av => av.Atendimento)
                   .WithMany(a => a.Avaliacoes)
                   .HasForeignKey(av => av.IdAtendimento);
        }
    }
}
