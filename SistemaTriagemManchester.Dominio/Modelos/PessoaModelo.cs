using SistemaTriagemManchester.Dominio.Enums;

namespace SistemaTriagemManchester.Dominio.Modelos
{
    public class PessoaModelo
    {
        public PessoaModelo(string nomeCompleto,
                            string sexo,
                            DateTime? dataNascimento,
                            string cPF,
                            string estadoCivil,
                            string celular,
                            string email,
                            TipoPessoa tipo)
        {
            NomeCompleto = nomeCompleto;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            CPF = cPF;
            EstadoCivil = estadoCivil;
            Celular = celular;
            Email = email;
            Tipo = tipo;
        }

        public PessoaModelo()
        {

        }

        public string NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string CPF { get; set; }
        public string EstadoCivil { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public TipoPessoa Tipo { get; set; }
        public int Id { get; set; }
    }
}
