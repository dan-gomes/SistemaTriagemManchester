using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Usuario
{
    public class PessoaMapeamento : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoas");
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id");

            builder.Property(p => p.NomeCompleto)
                   .IsRequired()
                   .HasColumnName("nomecompleto")
                   .HasColumnType("varchar(150)");

            builder.Property(p => p.Sexo)
                   .HasColumnName("sexo")
                   .HasColumnType("varchar(20)");

            builder.Property(p => p.DataNascimento)
                   .HasColumnName("datanascimento")
                   .HasColumnType("date");

            builder.Property(p => p.CPF)
                   .HasColumnName("cpf")
                   .HasColumnType("varchar(14)");

            builder.Property(p => p.EstadoCivil)
                   .HasColumnName("estadocivil")
                   .HasColumnType("varchar(20)");

            builder.Property(p => p.Celular)
                   .HasColumnName("celular")
                   .HasColumnType("varchar(15)");

            builder.Property(p => p.Email)
                    .HasColumnName("email")
                   .HasColumnType("varchar(100)");

            builder.Property(p => p.DataCadastro)
                   .HasColumnType("timestamp")
                   .HasColumnName("datacadastro")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(p => p.Tipo)
                    .HasColumnName("tipo")
                   .HasColumnType("int2");

            builder.HasOne(e => e.Endereco)
                   .WithOne()
                   .HasForeignKey<Endereco>(a => a.IdPessoa);
        }
    }
}
