using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao.Interfaces
{
    public interface IEnderecoAplicacao
    {
        bool Gravar(EnderecoModelo enderecoModelo);
    }
}
