namespace SistemaTriagemManchester.Dominio.Entidades.Atendimentos
{
    public class Procedimento
    {
        public int Id { get; set; }
        public int IdAtendimento { get; set; }
        public string PrescricaoMedica { get; set; }
        public string Encaminhamentos { get; set; }
        public string ProcedimentosRealizados { get; set; }
        public string OrientacoesAoPaciente { get; set; }

        public Atendimento Atendimento { get; set; }
    }
}
