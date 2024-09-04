namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public short Codigo { get; set; }

        // Relacionamento com InformacoesProfissionais
        public ICollection<InformacoesProfissionais> InformacoesProfissionais { get; set; }
    }
}
