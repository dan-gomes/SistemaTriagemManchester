using SistemaTriagemManchester.Dominio;

namespace SistemaTriagemManchester.Aplicacao
{
    public class DoencaPreExistenteAplicacao : IDoencaPreExistenteAplicacao
    {
        private readonly IDoencaPreExistenteRepositorio _doencaPreExistenteRepositorio;
        private readonly IPessoaDoencaPreExistenteRepositorio _pacienteDoencaPreExistenteRepositorio;

        public DoencaPreExistenteAplicacao(IPessoaDoencaPreExistenteRepositorio pacienteDoencaPreExistenteRepositorio, IDoencaPreExistenteRepositorio doencaPreExistenteRepositorio)
        {
            _pacienteDoencaPreExistenteRepositorio = pacienteDoencaPreExistenteRepositorio;
            _doencaPreExistenteRepositorio = doencaPreExistenteRepositorio;
        }
    }
}
