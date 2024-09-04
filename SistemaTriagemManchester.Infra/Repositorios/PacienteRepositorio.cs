using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Infra.Repositorios;

namespace SistemaTriagemManchester.Infra
{
    public class PacienteRepositorio : Repository<Paciente>, IPacienteRepositorio
    {
        public PacienteRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }
    }
}
