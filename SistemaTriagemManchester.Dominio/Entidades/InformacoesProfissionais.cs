using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class InformacoesProfissionais
    {
        public InformacoesProfissionais()
        {

        }

        public InformacoesProfissionais(InformacoesProfissionaisModelo informacoesProfissionaisModelo, Cargo cargo, Especialidade especialidade)
        {
            RegistroProfissional = informacoesProfissionaisModelo.RegistroProfissional;
            ExperienciaProfissional = informacoesProfissionaisModelo.ExperienciaProfissional;
            RegistroProfissional = informacoesProfissionaisModelo.RegistroProfissional;
            DataCadastro = DateTime.Now;
            IdiomasFalados = informacoesProfissionaisModelo.IdiomasFalados;
            Disponibilidade = informacoesProfissionaisModelo.Disponibilidade;
            ReferenciasProfissionais = informacoesProfissionaisModelo.ReferenciasProfissionais;
            Cargo = cargo;
            Especialidade = especialidade;
        }

        public int Id { get; set; }
        public int IdCargo { get; set; }
        public int IdEspecialidade { get; set; }
        public string RegistroProfissional { get; set; }
        public string ExperienciaProfissional { get; set; }
        public DateTime DataCadastro { get; set; }

        public string IdiomasFalados { get; set; }
        public short Disponibilidade { get; set; }
        public string ReferenciasProfissionais { get; set; }

        // Propriedades de navegação
        public Cargo Cargo { get; set; }
        public Especialidade Especialidade { get; set; }

    }
}
