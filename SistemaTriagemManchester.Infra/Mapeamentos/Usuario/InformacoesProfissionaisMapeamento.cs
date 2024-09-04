using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Usuario
{
    public class InformacoesProfissionaisMapeamento : IEntityTypeConfiguration<InformacoesProfissionais>
    {
        public void Configure(EntityTypeBuilder<InformacoesProfissionais> builder)
        {
            builder.ToTable("informacoesprofissionais");
            builder.HasKey(ip => ip.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id");

            builder.Property(c => c.IdCargo)
                   .HasColumnName("idcargo");

            builder.Property(c => c.IdEspecialidade)
                   .HasColumnName("idespecialidade");

            builder.Property(ip => ip.RegistroProfissional)
                   .HasColumnName("registroprofissional")
                   .HasColumnType("varchar(50)");

            builder.Property(ip => ip.ExperienciaProfissional)
                   .HasColumnName("experienciaprofissional")
                   .HasColumnType("text");

            builder.Property(ip => ip.DataCadastro)
                   .HasColumnName("datacadastro")
                   .HasColumnType("timestamp")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(ip => ip.IdiomasFalados)
                   .HasColumnName("idiomas")
                   .HasColumnType("text");

            builder.Property(ip => ip.Disponibilidade)
                   .HasColumnName("disponibilidade")
                   .HasColumnType("int2");

            builder.Property(ip => ip.ReferenciasProfissionais)
                   .HasColumnName("referenciasprofissionais")
                   .HasColumnType("text");
        }
    }
}
