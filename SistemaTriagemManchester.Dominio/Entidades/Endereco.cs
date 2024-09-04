using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public DateTime DataCadastro { get; set; }

        public int IdPessoa { get; set; }  // Chave estrangeira


        public static explicit operator Endereco(EnderecoModelo enderecoModelo)
        {
            return new Endereco
            {
                Bairro = enderecoModelo.Bairro,
                Cep = enderecoModelo.Cep,
                Cidade = enderecoModelo.Cidade,
                DataCadastro = DateTime.Now,
                Estado = enderecoModelo.Estado,
                Logradouro = enderecoModelo.Logradouro,
                Numero = enderecoModelo.Numero,
                IdPessoa = enderecoModelo.IdPessoa
            };
        }
    }
}
