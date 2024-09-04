using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Modelos;
using SistemaTriagemManchester.Dominio.Modelos.Dto;

namespace SistemaTriagemManchester.Dominio.Interfaces.Repositorios
{
    public interface IPessoaRepositorio : IRepository<Pessoa>
    {
        PessoaDto ObterPorDadosIdentificacao(PessoaModelo pessoaModelo);
        List<PessoaDto> ObterTodos();
    }
}
