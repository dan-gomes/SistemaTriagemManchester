using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.Atendimentos;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos
{
    public class ProcedimentoMapeamento : IEntityTypeConfiguration<Procedimento>
    {
        public void Configure(EntityTypeBuilder<Procedimento> builder)
        {
            builder.ToTable("procedimentos");
            builder.HasKey(p => p.Id);

            builder.Property(d => d.Id)
                   .HasColumnName("id");

            builder.Property(d => d.IdAtendimento)
                   .HasColumnName("idatendimento");

            builder.Property(p => p.PrescricaoMedica)
                   .HasColumnName("prescricaomedica")
                   .HasColumnType("text");

            builder.Property(p => p.Encaminhamentos)
                   .HasColumnName("encaminhamentos")
                   .HasColumnType("text");

            builder.Property(p => p.ProcedimentosRealizados)
                   .HasColumnName("procedimentosrealizados")
                   .HasColumnType("text");

            builder.Property(p => p.OrientacoesAoPaciente)
                   .HasColumnName("orientacoesaopaciente")
                   .HasColumnType("text");

            builder.HasOne(p => p.Atendimento)
                   .WithMany(a => a.Procedimentos)
                   .HasForeignKey(p => p.IdAtendimento);
        }
    }
}
