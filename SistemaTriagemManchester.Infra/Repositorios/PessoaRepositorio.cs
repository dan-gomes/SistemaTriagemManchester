using Microsoft.EntityFrameworkCore;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;
using SistemaTriagemManchester.Dominio.Modelos.Dto;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class PessoaRepositorio : Repository<Pessoa>, IPessoaRepositorio
    {
        public PessoaRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }

        public PessoaDto ObterPorDadosIdentificacao(PessoaModelo pessoaModelo)
        {
            Pessoa pessoa;
            var query = Set.AsQueryable();


            if (pessoaModelo.Id != 0)
            {
                pessoa = Set.FirstOrDefault(a => a.Id == pessoaModelo.Id);
                return (PessoaDto)pessoa;
            }

            if (!string.IsNullOrWhiteSpace(pessoaModelo.NomeCompleto))
            {
                query = query.Where(a => a.NomeCompleto == pessoaModelo.NomeCompleto);
            }

            if (!string.IsNullOrWhiteSpace(pessoaModelo.CPF))
            {
                query = query.Where(a => a.CPF == pessoaModelo.CPF);
            }

            return (PessoaDto)query.FirstOrDefault();
        }

        public PessoaDto ObterPorDocumento(string documento)
        {
            return (PessoaDto)Set.Include(a=>a.PessoasDoencasPreexistentes).ThenInclude(a=>a.DoencaPreexistente).FirstOrDefault(a => a.CPF == documento);
        }

        public List<PessoaDto> ObterTodos()
        {
            return Set.Include(a => a.Endereco).ToList().Select(a => (PessoaDto)a).ToList();
        }
    }
}
