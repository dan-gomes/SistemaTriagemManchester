using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.MachineLearning;

namespace SistemaTriagemManchester.Infra.Mapeamentos
{
    public class UrgenciaMapeamento : IEntityTypeConfiguration<Urgencias>
    {
        public void Configure(EntityTypeBuilder<Urgencias> builder)
        {
            builder.ToTable("urgencias");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(e => e.Grau).IsRequired().HasColumnName("Grau");
        }
    }
}
