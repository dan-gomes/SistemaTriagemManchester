using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class EnderecoRepositorio : Repository<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }
    }
}
