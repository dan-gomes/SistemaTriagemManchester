using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.Atendimentos;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos
{
    public class DiagnosticoMapeamento : IEntityTypeConfiguration<Diagnostico>
    {
        public void Configure(EntityTypeBuilder<Diagnostico> builder)
        {
            builder.ToTable("diagnosticos");
            builder.HasKey(d => d.Id);


            builder.Property(d => d.Id)
                   .HasColumnName("id");

            builder.Property(d => d.IdAtendimento)
                   .HasColumnName("idatendimento");

            builder.Property(d => d.DiagnosticoPreliminar)
                   .HasColumnName("frequenciacardiaca")
                   .HasColumnType("text");

            builder.Property(d => d.ExamesComplementares)
                   .HasColumnName("examescomplementares")
                   .HasColumnType("text");

            builder.Property(d => d.HipotesesDiagnosticas)
                   .HasColumnName("hipotesesdiagnosticas")
                   .HasColumnType("text");

            builder.HasOne(d => d.Atendimento)
                   .WithMany(a => a.Diagnosticos)
                   .HasForeignKey(d => d.IdAtendimento);
        }
    }
}
