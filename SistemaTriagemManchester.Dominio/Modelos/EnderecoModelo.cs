namespace SistemaTriagemManchester.Dominio.Modelos
{
    public class EnderecoModelo
    {
        public EnderecoModelo(string cep,
                              string logradouro,
                              string bairro,
                              string cidade,
                              string estado,
                              string numero)
        {
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Numero = numero;
        }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
