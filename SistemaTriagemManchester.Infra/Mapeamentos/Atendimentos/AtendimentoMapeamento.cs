using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades.Atendimentos;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos
{
    public class AtendimentoMapeamento : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.ToTable("atendimentos");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                   .HasColumnName("id");

            builder.Property(a => a.DataHora)
                   .HasColumnName("datahora")
                   .IsRequired();

            builder.Property(a => a.QueixaPrincipal)
                   .HasColumnName("queixaprincpal")
                   .HasColumnType("text");

            builder.Property(a => a.InicioSintomas)

                .HasColumnName("iniciosintomas")
                   .HasColumnType("text");

            builder.Property(a => a.SintomasRelatados)
                   .HasColumnName("sintomasrelatados")
                   .HasColumnType("text");

            builder.HasOne(a => a.Paciente)
                   .WithMany(p => p.Atendimentos)
                   .HasForeignKey(a => a.Id);

            builder.HasMany(a => a.Avaliacoes)
                   .WithOne(av => av.Atendimento)
                   .HasForeignKey(av => av.IdAtendimento)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.Diagnosticos)
                   .WithOne(d => d.Atendimento)
                   .HasForeignKey(d => d.IdAtendimento)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.HistoricoMedico)
                   .WithOne(hm => hm.Atendimento)
                   .HasForeignKey(hm => hm.IdAtendimento)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.Procedimentos)
                   .WithOne(pr => pr.Atendimento)
                   .HasForeignKey(pr => pr.IdAtendimento)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.Acompanhamentos)
                   .WithOne(ac => ac.Atendimento)
                   .HasForeignKey(ac => ac.IdAtendimento)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
