namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class SintomasPaciente
    {
        public long Id { get; set; }
        public long IdPaciente { get; set; }
        public long IdAtendimento { get; set; }
        public string Sintoma { get; set; }
        public byte Gravidade { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
