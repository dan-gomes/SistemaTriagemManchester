using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Enums;

namespace SistemaTriagemManchester.Dominio.Modelos.Dto
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string CPF { get; set; }
        public string EstadoCivil { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public TipoPessoa Tipo { get; set; }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public DateTime DataCadastroEndereco { get; set; }


        public static explicit operator PessoaDto(Pessoa pessoa)
        {
            return new PessoaDto
            {
                Id = pessoa.Id,
                Celular = pessoa.Celular,
                CPF = pessoa.CPF,
                DataCadastro = pessoa.DataCadastro,
                Email = pessoa.Email,
                DataNascimento = pessoa.DataNascimento,
                EstadoCivil = pessoa.EstadoCivil,
                NomeCompleto = pessoa.NomeCompleto,
                Sexo = pessoa.Sexo,
                Tipo = pessoa.Tipo,
                Cep = pessoa.Endereco?.Cep,
                Logradouro = pessoa.Endereco?.Logradouro,
                Bairro = pessoa.Endereco?.Bairro,
                Cidade = pessoa.Endereco?.Cidade,
                Estado = pessoa.Endereco?.Estado,
                Numero = pessoa.Endereco?.Numero,
                DataCadastroEndereco = pessoa.Endereco == null ? DateTime.MinValue : pessoa.Endereco.DataCadastro
            };
        }
    }
}
