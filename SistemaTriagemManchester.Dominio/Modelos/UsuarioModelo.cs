namespace SistemaTriagemManchester.Dominio.Modelos
{
    public class UsuarioModelo
    {
        public PessoaModelo PessoaModelo { get; set; }
        public InformacoesProfissionaisModelo InformacoesProfissionaisModelo { get; set; }
        public EnderecoModelo EnderecoModelo { get; set; }

        public UsuarioModelo()
        {

        }
    }
}
