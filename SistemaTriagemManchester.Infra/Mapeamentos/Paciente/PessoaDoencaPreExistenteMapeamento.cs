using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades;
using System.Reflection.Emit;


namespace SistemaTriagemManchester.Infra.Mapeamentos.Paciente
{
    public class PessoaDoencaPreExistenteMapeamento : IEntityTypeConfiguration<PessoaDoencaPreexistente>
    {
        public void Configure(EntityTypeBuilder<PessoaDoencaPreexistente> builder)
        {
            builder.ToTable("pessoadoencapreexistente");
            builder.HasKey(pd => pd.Id);
            builder.Property(a => a.Id).HasColumnName("id");

            builder.Property(a => a.IdPessoa).HasColumnName("idpessoa");
            builder.Property(a => a.IdDoencaPreexistente).HasColumnName("iddoencapreexistente");

            builder.HasOne(pd => pd.Pessoa)
                   .WithMany(p => p.PessoasDoencasPreexistentes)
                   .HasForeignKey(pd => pd.IdPessoa)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pd => pd.DoencaPreexistente)
                   .WithMany(d => d.PessoasDoencasPreexistentes)
                   .HasForeignKey(pd => pd.IdDoencaPreexistente)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
