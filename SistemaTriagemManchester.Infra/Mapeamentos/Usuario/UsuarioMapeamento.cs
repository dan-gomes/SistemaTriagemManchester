using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Infra.Mapeamentos
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Dominio.Entidades.Usuario>
    {
        public void Configure(EntityTypeBuilder<Dominio.Entidades.Usuario> builder)
        {
            builder.ToTable("usuarios");
            builder.HasKey(l => l.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id");

            builder.Property(c => c.IdInformacoesProfissionais)
                   .HasColumnName("idinformacoesprofissionais");

            builder.Property(c => c.IdPessoa)
                   .HasColumnName("idpessoa");

            builder.Property(l => l.CPF)
                   .IsRequired()
                   .HasColumnName("cpf")
                   .HasColumnType("varchar(14)");

            builder.Property(l => l.Senha)
                   .HasColumnName("senha")
                   .HasColumnType("varchar(255)");

            builder.Property(l => l.DataCriacao)
                   .HasColumnType("timestamp")
                   .HasColumnName("datacadastro")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne(l => l.Pessoa)
                   .WithMany()
                   .HasForeignKey(l => l.IdPessoa);

            builder.HasOne(l => l.InformacoesProfissionais)
                   .WithMany()
                   .HasForeignKey(l => l.IdInformacoesProfissionais);

        }
    }
}

