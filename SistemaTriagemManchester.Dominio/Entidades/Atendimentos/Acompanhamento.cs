namespace SistemaTriagemManchester.Dominio.Entidades.Atendimentos
{
    public class Acompanhamento
    {
        public int Id { get; set; }
        public int IdAtendimento { get; set; }
        public string Anotacoes { get; set; }
        public string Resumo { get; set; }
        public DateTime? DataProximaConsulta { get; set; }

        public Atendimento Atendimento { get; set; }
    }
}
