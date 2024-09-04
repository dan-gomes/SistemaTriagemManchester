using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao
{
    public class UsuarioAplicacao : IUsuarioAplicacao
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IPessoaAplicacao _pessoaAplicacao;
        private readonly IEnderecoAplicacao _enderecoAplicacao;
        private readonly IInformacoesProfissionaisAplicacao _informacoesProfissionaisAplicacao;

        public UsuarioAplicacao(IUsuarioRepositorio usuarioRepositorio, IPessoaAplicacao pessoaAplicacao, IEnderecoAplicacao enderecoAplicacao, IInformacoesProfissionaisAplicacao informacoesProfissionaisAplicacao)
        {
            _pessoaAplicacao = pessoaAplicacao;
            _enderecoAplicacao = enderecoAplicacao;
            _usuarioRepositorio = usuarioRepositorio;
            _informacoesProfissionaisAplicacao = informacoesProfissionaisAplicacao;
        }

        public bool Validar(string documento, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuarioPorCodigoESenha(documento, senha);

            if (usuario != null)
                return true;

            return false;
        }

        public bool GravarNovoUsuario(UsuarioModelo usuario)
        {

            try
            {
                var pessoa = _pessoaAplicacao.Gravar(usuario.PessoaModelo);

                if (pessoa == 0)
                    return false;

                usuario.EnderecoModelo.IdPessoa = pessoa;
                var usuarioEntidade = (Usuario)usuario;
                usuarioEntidade.IdPessoa = pessoa;

                if (!_enderecoAplicacao.Gravar(usuario.EnderecoModelo))
                    return false;

                var endereco = _informacoesProfissionaisAplicacao.Gravar(usuario.InformacoesProfissionaisModelo);

                if (endereco == 0)
                    return false;

                usuarioEntidade.IdInformacoesProfissionais = endereco;

                if (_usuarioRepositorio.Add(usuarioEntidade) != 0)
                    return true;

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool GravarSenhaUsuario(UsuarioSenhaModelo usuario)
        {
            if (_usuarioRepositorio.GravarSenhaUsuario(usuario))
                return true;

            return false;
        }
    }
}
