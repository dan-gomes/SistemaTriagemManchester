using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Entidades.Atendimentos;

namespace SistemaTriagemManchester.Dominio
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string QueixaPrincipal { get; set; }
        public string InicioSintomas { get; set; }
        public string SintomasRelatados { get; set; }

        public Paciente Paciente { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
        public ICollection<Diagnostico> Diagnosticos { get; set; }
        public ICollection<HistoricoMedico> HistoricoMedico { get; set; }
        public ICollection<Procedimento> Procedimentos { get; set; }
        public ICollection<Acompanhamento> Acompanhamentos { get; set; }
    }
}
