using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Dominio.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio : IRepository<Usuario>
    {
        bool GravarSenhaUsuario(UsuarioSenhaModelo usuario);
        Usuario ObterUsuarioPorCodigoESenha(string codigo, string senha);
    }
}
