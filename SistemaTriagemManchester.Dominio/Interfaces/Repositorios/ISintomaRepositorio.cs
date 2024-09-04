using SistemaTriagemManchester.Dominio.Entidades.MachineLearning;

namespace SistemaTriagemManchester.Dominio.Interfaces.Repositorios
{
    public interface ISintomaRepositorio : IRepository<Sintomas>
    {
        List<Sintomas> ObterSintomasParaTreinamento();
    }
}
