using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class EspecialidadeRepositorio : Repository<Especialidade>, IEspecialidadeRepositorio
    {
        public EspecialidadeRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }

        public Especialidade ObterPorCodigo(short codigo)
        {
            return Set.FirstOrDefault(a => a.Codigo == codigo);
        }

        public List<Especialidade> ObterTodas()
        {
            return Set.ToList();
        }
    }
}
