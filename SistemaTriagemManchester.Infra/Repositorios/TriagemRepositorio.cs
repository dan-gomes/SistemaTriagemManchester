using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class TriagemRepositorio : Repository<Triagem>, ITriagemRepositorio
    {
        public TriagemRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }
    }
}
