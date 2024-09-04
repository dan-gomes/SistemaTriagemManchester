using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class CargoRepositorio : Repository<Cargo>, ICargoRepositorio
    {
        public CargoRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }

        public Cargo ObterPorCodigo(short codigo)
        {
            return Set.FirstOrDefault(a => a.Codigo == codigo);
        }

        public List<Cargo> ObterCargos()
        {
            return Set.ToList();
        }
    }
}
