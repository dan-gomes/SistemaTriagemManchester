namespace SistemaTriagemManchester.Dominio.Entidades.MachineLearning
{
    public class Sintomas
    {
        public int Id { get; set; }
        public bool Febre { get; set; }
        public bool Tosse { get; set; }
        public bool DorCabeca { get; set; }
        public bool Fadiga { get; set; }
        public bool SedeExcessiva { get; set; }
        public bool MiccaoFrequente { get; set; }
        public bool VisaoEmbacada { get; set; }
        public bool Tremores { get; set; }
        public bool ConfusaoMental { get; set; }
        public bool SuorExcessivo { get; set; }
    }
}
