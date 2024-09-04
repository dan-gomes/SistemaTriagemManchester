namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public short Codigo { get; set; }
        public ICollection<InformacoesProfissionais> InformacoesProfissionais { get; set; }

    }
}
