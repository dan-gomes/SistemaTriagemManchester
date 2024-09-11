using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Entidades.Pacientes;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;
using SistemaTriagemManchester.Dominio.Modelos.Dto;
using SistemaTriagemManchester.Infra;

namespace SistemaTriagemManchester.Aplicacao
{
    public class PessoaAplicacao : IPessoaAplicacao
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IPessoaDoencaPreExistenteRepositorio _pessoaDoencaPreExistenteRepositorio;
        private readonly IDoencaPreExistenteRepositorio _doencaPreExistenteRepositorio;
        private readonly IEnderecoAplicacao _enderecoAplicacao;

        public PessoaAplicacao(IPessoaRepositorio pessoaRepositorio, IPessoaDoencaPreExistenteRepositorio pessoaDoencaPreExistenteRepositorio, IDoencaPreExistenteRepositorio doencaPreExistenteRepositorio, IEnderecoAplicacao enderecoAplicacao)
        {
            _pessoaRepositorio = pessoaRepositorio;
            _pessoaDoencaPreExistenteRepositorio = pessoaDoencaPreExistenteRepositorio;
            _doencaPreExistenteRepositorio = doencaPreExistenteRepositorio;
            _enderecoAplicacao = enderecoAplicacao;
        }

        public int Gravar(PessoaModelo pessoaModelo)
        {
            var pessoa = (Pessoa)pessoaModelo;
            var resultado = _pessoaRepositorio.Add(pessoa);
            return pessoa.Id;
        }

        public bool GravaPessoaCompleta(PessoaModelo pessoaModelo, EnderecoModelo enderecoModelo, List<DoencaPreExistenteModelo> doencaPreExistenteModelo)
        {
            var pessoa = (Pessoa)pessoaModelo;
            var resultado = _pessoaRepositorio.Add(pessoa);

            if (resultado == 0)
                return false;

            enderecoModelo.IdPessoa = pessoa.Id;

            if (!_enderecoAplicacao.Gravar(enderecoModelo))
                return false;

            foreach (var item in doencaPreExistenteModelo)
            {
                var doencaPreexistente = (DoencaPreExistente)item;

                if (_doencaPreExistenteRepositorio.Add(doencaPreexistente) == 0)
                {
                    return false;
                };

                if (_pessoaDoencaPreExistenteRepositorio.Add(new PessoaDoencaPreexistente { IdDoencaPreexistente = doencaPreexistente.Id, IdPessoa = pessoa.Id }) == 0)
                {
                    return false;
                };
            }

            return true;
        }

        public PessoaDto Obter(PessoaModelo pessoaModelo)
        {
            return _pessoaRepositorio.ObterPorDadosIdentificacao(pessoaModelo);
        }

        public List<PessoaDto> ObterTodos()
        {
            return _pessoaRepositorio.ObterTodos();
        }

        public List<DoencaPreExistenteModelo> ObterDoencasPreExistentesPorDocumentoPessoa(string documento)
        {
            return _pessoaRepositorio.ObterPorDocumento(documento).DoencasPreExistentes.ToList();
        }
    }
}
