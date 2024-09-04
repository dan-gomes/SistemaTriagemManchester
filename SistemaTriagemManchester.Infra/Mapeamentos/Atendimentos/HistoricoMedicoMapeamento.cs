using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaTriagemManchester.Dominio.Entidades.Atendimentos;

namespace SistemaTriagemManchester.Infra.Mapeamentos.Atendimentos
{
    public class HistoricoMedicoMapeamento : IEntityTypeConfiguration<HistoricoMedico>
    {
        public void Configure(EntityTypeBuilder<HistoricoMedico> builder)
        {
            builder.ToTable("historicomedico");
            builder.HasKey(hm => hm.Id);

            builder.Property(d => d.Id)
                   .HasColumnName("id");

            builder.Property(d => d.IdAtendimento)
                   .HasColumnName("idatendimento");

            builder.Property(hm => hm.HistoricoDoencas)
                .HasColumnName("historicodoencas")
                   .HasColumnType("text");

            builder.Property(hm => hm.Alergias)
                .HasColumnName("alergias")
                   .HasColumnType("text");

            builder.Property(hm => hm.HistoricoFamiliar)
                .HasColumnName("historicofamiliar")
                   .HasColumnType("text");

            builder.Property(hm => hm.CirurgiasAnteriores)
                .HasColumnName("cirurgiasanteriores")
                   .HasColumnType("text");

            builder.Property(hm => hm.MedicacoesEmUso)
                .HasColumnName("medicacoesemuso")
                   .HasColumnType("text");

            builder.HasOne(hm => hm.Atendimento)
                   .WithMany(a => a.HistoricoMedico)
                   .HasForeignKey(hm => hm.IdAtendimento);
        }
    }
}
