using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Usuario
{
    public class EspecialidadeMapeamento : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("especialidades");
            builder.HasKey(e => e.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id");

            builder.Property(e => e.Nome)
                   .IsRequired()
                   .HasColumnName("nome")
                   .HasColumnType("varchar(100)");

            builder.Property(e => e.Codigo)
                   .IsRequired()
                   .HasColumnName("codigo")
                   .HasColumnType("int2");

            builder.HasMany(e => e.InformacoesProfissionais)
                   .WithOne(ip => ip.Especialidade)
                   .HasForeignKey(ip => ip.IdEspecialidade);
        }
    }
}
