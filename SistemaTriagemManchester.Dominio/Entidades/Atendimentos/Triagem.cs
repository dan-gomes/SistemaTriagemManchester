using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Dominio
{
    public class Triagem
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
        public string Classificacao { get; set; }

        // Propriedade de navegação
        public Paciente Paciente { get; set; }

        public static explicit operator Triagem(TriagemModelo triagemModelo)
        {
            return new Triagem
            {
                IdPaciente = triagemModelo.IdPaciente,
                DataHora = triagemModelo.DataHora,
                Classificacao = triagemModelo.Classificacao,
                FrequenciaCardiaca = triagemModelo.FrequenciaCardiaca,
                FrequenciaRespiratoria = triagemModelo.FrequenciaRespiratoria,
                Glicemia = triagemModelo.Glicemia,
                HistoricoAlergico = triagemModelo.HistoricoAlergico,
                HistoricoCirurgico = triagemModelo.HistoricoCirurgico,
                HistoricoClinico = triagemModelo.HistoricoClinico,
                Imunizacao = triagemModelo.Imunizacao,
                PAS = triagemModelo.PAS,
                SaturacaoOxigenio = triagemModelo.SaturacaoOxigenio,
                Sinais = triagemModelo.Sinais,
                Sintomas = triagemModelo.Sintomas,
                Temperatura = triagemModelo.Temperatura
            };
        }
    }
}
