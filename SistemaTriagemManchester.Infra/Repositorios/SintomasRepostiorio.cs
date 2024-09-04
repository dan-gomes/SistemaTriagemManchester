using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Entidades.MachineLearning;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class SintomaRepostiorio : Repository<Sintomas>, ISintomaRepositorio
    {
        public SintomaRepostiorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }

        public List<Sintomas> ObterSintomasParaTreinamento()
        {
            return Set.ToList();
        }
    }
}
