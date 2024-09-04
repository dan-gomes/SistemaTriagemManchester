using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Dominio.Interfaces.Repositorios
{
    public interface IEspecialidadeRepositorio : IRepository<Especialidade>
    {
        Especialidade ObterPorCodigo(short codigo);
        List<Especialidade> ObterTodas();
    }
}
