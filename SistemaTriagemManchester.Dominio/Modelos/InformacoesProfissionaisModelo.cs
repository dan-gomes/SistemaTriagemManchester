namespace SistemaTriagemManchester.Dominio.Modelos
{
    public class InformacoesProfissionaisModelo
    {
        public InformacoesProfissionaisModelo(string registroProfissional,
                                              string experienciaProfissional,
                                              string idiomasFalados,
                                              string disponibilidade,
                                              string referenciasProfissionais)
        {
            RegistroProfissional = registroProfissional;
            ExperienciaProfissional = experienciaProfissional;
            IdiomasFalados = idiomasFalados;
            Disponibilidade = MapToShort(disponibilidade);
            ReferenciasProfissionais = referenciasProfissionais;
        }

        public string RegistroProfissional { get; set; }
        public string ExperienciaProfissional { get; set; }
        public DateTime DataCriacao { get; set; }

        public string IdiomasFalados { get; set; }
        public short Disponibilidade { get; set; }
        public string ReferenciasProfissionais { get; set; }
        public int Id { get; set; }

        public CargoModelo Cargo { get; set; }
        public EspecialidadeModelo Especialidade { get; set; }


        private short MapToShort(string period)
        {
            switch (period.ToLower())
            {
                case "matutino":
                    return 1;
                case "vespertino":
                    return 2;
                case "noturno":
                    return 2;
                default:
                    throw new ArgumentException("Valor desconhecido: " + period);
            }
        }
    }
}
