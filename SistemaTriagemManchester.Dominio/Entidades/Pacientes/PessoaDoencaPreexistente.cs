
using SistemaTriagemManchester.Dominio.Entidades.Pacientes;

namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class PessoaDoencaPreexistente
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdDoencaPreexistente { get; set; }

        // Propriedades de navegação
        public Pessoa Pessoa { get; set; }
        public DoencaPreExistente DoencaPreexistente { get; set; }
    }
}

