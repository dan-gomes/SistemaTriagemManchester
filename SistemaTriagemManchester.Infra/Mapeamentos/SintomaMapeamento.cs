using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.MachineLearning;

namespace SistemaTriagemManchester.Infra.Mapeamentos
{
    public class SintomaMapeamento : IEntityTypeConfiguration<Sintomas>
    {
        public void Configure(EntityTypeBuilder<Sintomas> builder)
        {
            builder.ToTable("sintomas");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Id");

            builder.Property(e => e.Febre).IsRequired().HasColumnName("Febre");
            builder.Property(e => e.Tosse).IsRequired().HasColumnName("Tosse");
            builder.Property(e => e.DorCabeca).IsRequired().HasColumnName("DorCabeca");
            builder.Property(e => e.Fadiga).IsRequired().HasColumnName("Fadiga");
            builder.Property(e => e.SedeExcessiva).IsRequired().HasColumnName("SedeExcessiva");
            builder.Property(e => e.MiccaoFrequente).IsRequired().HasColumnName("MiccaoFrequente");
            builder.Property(e => e.VisaoEmbacada).IsRequired().HasColumnName("VisaoEmbacada");
            builder.Property(e => e.Tremores).IsRequired().HasColumnName("Tremores");
            builder.Property(e => e.ConfusaoMental).IsRequired().HasColumnName("ConfusaoMental");
            builder.Property(e => e.SuorExcessivo).IsRequired().HasColumnName("SuorExcessivo");
        }
    }
}
