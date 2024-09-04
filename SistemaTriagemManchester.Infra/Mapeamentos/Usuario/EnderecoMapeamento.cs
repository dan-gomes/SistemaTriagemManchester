using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Usuario
{
    public class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("enderecos");
            builder.HasKey(e => e.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id");

            builder.Property(c => c.IdPessoa)
                   .HasColumnName("idpessoa");

            builder.Property(e => e.Cep)
                   .IsRequired()
                   .HasColumnName("cep")
                   .HasColumnType("varchar(9)");

            builder.Property(e => e.Logradouro)
                   .IsRequired()
                   .HasColumnName("logradouro")
                   .HasColumnType("varchar(150)");

            builder.Property(e => e.Bairro)
                .HasColumnName("bairro")
                   .HasColumnType("varchar(100)");

            builder.Property(e => e.Cidade)
                .HasColumnName("cidade")
                   .HasColumnType("varchar(100)");

            builder.Property(e => e.Estado)
                .HasColumnName("estado")
                   .HasColumnType("char(2)");

            builder.Property(e => e.Numero)
                .HasColumnName("numero")
                   .HasColumnType("varchar(10)");

            builder.Property(e => e.DataCadastro)
                   .HasColumnType("timestamp")
                   .HasColumnName("datacadastro")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}