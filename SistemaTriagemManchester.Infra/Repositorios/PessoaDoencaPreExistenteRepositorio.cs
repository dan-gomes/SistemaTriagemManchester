using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Infra.Repositorios;

namespace SistemaTriagemManchester.Infra
{
    public class PessoaDoencaPreExistenteRepositorio : Repository<PessoaDoencaPreexistente>, IPessoaDoencaPreExistenteRepositorio
    {
        public PessoaDoencaPreExistenteRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }
    }
}
