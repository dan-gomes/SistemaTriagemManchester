using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.Atendimentos;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos
{
    public class AcompanhamentoMapeamento : IEntityTypeConfiguration<Acompanhamento>
    {
        public void Configure(EntityTypeBuilder<Acompanhamento> builder)
        {
            builder.ToTable("acompanhamentos");
            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Id)
                   .HasColumnName("id");

            builder.Property(d => d.IdAtendimento)
                   .HasColumnName("idatendimento");

            builder.Property(ac => ac.Anotacoes)
                   .HasColumnName("anotacoes")
                   .HasColumnType("text");

            builder.Property(ac => ac.IdAtendimento)
                   .HasColumnName("idatendimento");

            builder.Property(ac => ac.Resumo)
                   .HasColumnName("resumo")
                   .HasColumnType("text");

            builder.Property(ac => ac.DataProximaConsulta)
                 .HasColumnName("DataProximaConsulta")
                   .HasColumnType("date");

            builder.HasOne(ac => ac.Atendimento)
                   .WithMany(a => a.Acompanhamentos)
                   .HasForeignKey(ac => ac.IdAtendimento);
        }
    }
}

