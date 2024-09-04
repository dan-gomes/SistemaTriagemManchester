using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class InformacoesProfissionaisRepositorio : Repository<InformacoesProfissionais>, IInformacoesProfissionaisRepositorio
    {
        public InformacoesProfissionaisRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }
    }
}
