using SistemaTriagemManchester.Dominio.Entidades.MachineLearning;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class UrgenciaRepositorio : Repository<Urgencias>, IUrgenciaRepositorio
    {
        public UrgenciaRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }

        public List<Urgencias> ObterUrgenciasParaTreinamento()
        {
            return Set.ToList();
        }
    }
}
