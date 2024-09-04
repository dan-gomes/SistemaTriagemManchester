using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Dominio.Entidades.Pacientes
{
    public class DoencaPreExistente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public ICollection<PessoaDoencaPreexistente> PessoasDoencasPreexistentes { get; set; }


        public static explicit operator DoencaPreExistente(DoencaPreExistenteModelo doencaPreExistenteModelo)
        {
            return new DoencaPreExistente
            {
                Descricao = doencaPreExistenteModelo.Observacao,
                Nome = doencaPreExistenteModelo.Nome
            };
        }
    }
}
