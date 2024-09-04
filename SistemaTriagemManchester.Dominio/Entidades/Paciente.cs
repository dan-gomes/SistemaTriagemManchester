using System.Collections.Generic;

namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdAtendimento { get; set; }
        public DateTime DataTriagem { get; set; }
        public string Status { get; set; }

        // Propriedade de navegação
        public Pessoa Pessoa { get; set; }
        public ICollection<Triagem> Triagens { get; set; } // Nova propriedade de navegação
        public ICollection<Atendimento> Atendimentos { get; set; }

    }
}
