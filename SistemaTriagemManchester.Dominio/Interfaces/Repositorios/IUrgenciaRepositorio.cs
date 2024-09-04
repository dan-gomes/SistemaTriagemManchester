using SistemaTriagemManchester.Dominio.Entidades.MachineLearning;

namespace SistemaTriagemManchester.Dominio.Interfaces.Repositorios
{
    public interface IUrgenciaRepositorio : IRepository<Urgencias>
    {
        List<Urgencias> ObterUrgenciasParaTreinamento();

    }
}
