using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao
{
    public class EspecialidadeAplicacao : IEspecialidadeAplicacao
    {
        private readonly IEspecialidadeRepositorio _especialidadeRepositorio;

        public EspecialidadeAplicacao(IEspecialidadeRepositorio especialidadeRepositorio)
        {
            _especialidadeRepositorio = especialidadeRepositorio;
        }

        public List<EspecialidadeModelo> ObterEspecialidades()
        {
            return _especialidadeRepositorio.ObterTodas().Select(a => (EspecialidadeModelo)a).ToList();
        }
    }
}
