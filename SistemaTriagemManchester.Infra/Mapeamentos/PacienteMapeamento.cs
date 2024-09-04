using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Infra
{
    public class PacienteMapeamento : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("pacientes");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataTriagem)
                   .IsRequired()
                   .HasColumnName("datatriagem")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(p => p.Status)
                   .HasColumnType("varchar(20)")
                   .HasColumnName("status")
                   .HasDefaultValue("Em Triagem");

            builder.HasOne(p => p.Pessoa)
                   .WithMany()
                   .HasForeignKey(p => p.IdPessoa);
        }
    }
}

