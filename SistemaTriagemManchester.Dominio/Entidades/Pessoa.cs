using SistemaTriagemManchester.Dominio.Enums;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class Pessoa
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

        public virtual Endereco Endereco { get; set; } // Propriedade de navegação
        public virtual ICollection<PessoaDoencaPreexistente> PessoasDoencasPreexistentes { get; set; }

        public static explicit operator Pessoa(PessoaModelo pessoaModelo)
        {
            return new Pessoa
            {
                Celular = pessoaModelo.Celular,
                CPF = pessoaModelo.CPF,
                DataCadastro = DateTime.Now,
                DataNascimento = pessoaModelo.DataNascimento,
                Email = pessoaModelo.Email,
                EstadoCivil = pessoaModelo.EstadoCivil,
                NomeCompleto = pessoaModelo.NomeCompleto,
                Sexo = pessoaModelo.Sexo,
                Tipo = pessoaModelo.Tipo
            };
        }
    }
}
