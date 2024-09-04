namespace SistemaTriagemManchester.Dominio.Entidades.Atendimentos
{
    public class HistoricoMedico
    {
        public int Id { get; set; }
        public int IdAtendimento { get; set; }
        public string HistoricoDoencas { get; set; }
        public string Alergias { get; set; }
        public string HistoricoFamiliar { get; set; }
        public string CirurgiasAnteriores { get; set; }
        public string MedicacoesEmUso { get; set; }

        public Atendimento Atendimento { get; set; }
    }
}
