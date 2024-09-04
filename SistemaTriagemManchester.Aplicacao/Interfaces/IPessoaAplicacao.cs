using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Modelos;
using SistemaTriagemManchester.Dominio.Modelos.Dto;

namespace SistemaTriagemManchester.Aplicacao.Interfaces
{
    public interface IPessoaAplicacao
    {
        int Gravar(PessoaModelo pessoaModelo);
        bool GravaPessoaCompleta(PessoaModelo pessoaModelo, EnderecoModelo enderecoModelo, List<DoencaPreExistenteModelo> doencaPreExistenteModelo);
        List<PessoaDto> ObterTodos();
        PessoaDto Obter(PessoaModelo pessoaModelo);
    }
}
