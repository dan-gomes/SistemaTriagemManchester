using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdInformacoesProfissionais { get; set; }
        public string CPF { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCriacao { get; set; }

        // Propriedade de navegação
        public Pessoa Pessoa { get; set; }
        public InformacoesProfissionais InformacoesProfissionais { get; set; }

        public static explicit operator Usuario(UsuarioModelo usuario)
        {
            return new Usuario
            {
                CPF = usuario.PessoaModelo.CPF,
                DataCriacao = DateTime.Now
            };
        }
    }
}
