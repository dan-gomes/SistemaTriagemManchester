using SistemaTriagemManchester.Dominio.Enums;

namespace SistemaTriagemManchester.Dominio.Modelos
{
    public class TriagemModelo
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public DateTime DataHora { get; set; }
        public string Sinais { get; set; }
        public string Sintomas { get; set; }
        public string Imunizacao { get; set; }
        public string HistoricoCirurgico { get; set; }
        public string HistoricoClinico { get; set; }
        public string HistoricoAlergico { get; set; }
        public string PAS { get; set; } // Pressão Arterial Sistólica
        public string Temperatura { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string FrequenciaCardiaca { get; set; }
        public string SaturacaoOxigenio { get; set; }
        public string Glicemia { get; set; }
        public Grau Classificacao { get; set; }
        public string CPF { get; set; }
        public string Sequencial { get; set; }
    }
}
