using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades.Pacientes;
using SistemaTriagemManchester.Infra.Repositorios;

namespace SistemaTriagemManchester.Infra
{
    public class DoencaPreExistenteRepositorio : Repository<DoencaPreExistente>, IDoencaPreExistenteRepositorio
    {
        public DoencaPreExistenteRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }
    }
}
