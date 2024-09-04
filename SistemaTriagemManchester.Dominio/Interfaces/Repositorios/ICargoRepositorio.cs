using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Dominio.Interfaces.Repositorios
{
    public interface ICargoRepositorio : IRepository<Cargo>
    {
        Cargo ObterPorCodigo(short codigo);
        List<Cargo> ObterCargos();
    }
}
