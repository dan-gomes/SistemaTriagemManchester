using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;
using SistemaTriagemManchester.Infra.Repositorios;

namespace SistemaTriagemManchester.Aplicacao
{
    public class EnderecoAplicacao : IEnderecoAplicacao
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;

        public EnderecoAplicacao(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        public bool Gravar(EnderecoModelo enderecoModelo)
        {
            var resultado = _enderecoRepositorio.Add((Endereco)enderecoModelo);
            return resultado != 0;
        }
    }
}
