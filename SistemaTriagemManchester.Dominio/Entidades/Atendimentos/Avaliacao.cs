namespace SistemaTriagemManchester.Dominio.Entidades.Atendimentos
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int IdAtendimento { get; set; }
        public string PressaoArterial { get; set; }
        public string FrequenciaCardiaca { get; set; }
        public string TemperaturaCorporal { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string AvaliacaoFisica { get; set; }
        public string OutrasObservacoes { get; set; }

        public Atendimento Atendimento { get; set; }
    }
}
