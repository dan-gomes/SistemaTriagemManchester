using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.Pacientes;


namespace SistemaTriagemManchester.Infra.Mapeamentos.Paciente
{
    public class DoencaPreExistenteMapeamento : IEntityTypeConfiguration<DoencaPreExistente>
    {
        public void Configure(EntityTypeBuilder<DoencaPreExistente> builder)
        {
            builder.ToTable("doencaspreexistentes");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                   .HasColumnName("id");

            builder.Property(d => d.Nome).HasColumnName("nome")
                   .IsRequired()
                   .HasColumnType("varchar(150)");

            builder.Property(d => d.Descricao).HasColumnName("descricao")
                   .HasColumnType("text");

            builder.HasMany(d => d.PessoasDoencasPreexistentes)
                   .WithOne(pd => pd.DoencaPreexistente)
                   .HasForeignKey(pd => pd.IdDoencaPreexistente)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
