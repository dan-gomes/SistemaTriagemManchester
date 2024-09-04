using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Usuario
{
    public class CargoMapeamento : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("cargos");
            builder.HasKey(cargo => cargo.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id");

            builder.Property(c => c.Nome)
                   .IsRequired()
                   .HasColumnName("nome")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Codigo)
                   .IsRequired()
                   .HasColumnName("codigo")
                   .HasColumnType("int2");

            builder.HasMany(c => c.InformacoesProfissionais)
                   .WithOne(ip => ip.Cargo)
                   .HasForeignKey(ip => ip.IdCargo);
        }
    }
}
