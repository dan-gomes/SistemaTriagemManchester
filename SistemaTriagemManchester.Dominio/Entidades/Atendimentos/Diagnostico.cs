namespace SistemaTriagemManchester.Dominio.Entidades.Atendimentos
{
    public class Diagnostico
    {
        public int Id { get; set; }
        public int IdAtendimento { get; set; }
        public string DiagnosticoPreliminar { get; set; }
        public string ExamesComplementares { get; set; }
        public string HipotesesDiagnosticas { get; set; }

        public Atendimento Atendimento { get; set; }
    }
}
