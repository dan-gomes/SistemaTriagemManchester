using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao.Interfaces
{
    public interface IUsuarioAplicacao
    {
        public bool Validar(string documento, string senha);
        bool GravarNovoUsuario(UsuarioModelo usuario);
        bool GravarSenhaUsuario(UsuarioSenhaModelo usuario);
    }
}
