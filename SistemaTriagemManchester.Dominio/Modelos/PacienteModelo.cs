namespace SistemaTriagemManchester.Dominio
{
    public class PacienteModelo
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdAtendimento { get; set; }
        public DateTime DataTriagem { get; set; }
        public string Status { get; set; }
    }
}
