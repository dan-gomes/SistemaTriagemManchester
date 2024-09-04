using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class UsuarioRepositorio : Repository<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SistemaTriagemManchesterContext context) : base(context)
        {
        }

        public bool GravarSenhaUsuario(UsuarioSenhaModelo usuario)
        {
            var entidade = Set.FirstOrDefault(a => a.CPF == usuario.CPF);

            if (entidade == null)
            {
                return false;
            }

            entidade.Senha = usuario.Senha;
            Update(entidade);
            return true;
        }

        public Usuario ObterUsuarioPorCodigoESenha(string codigo, string senha)
        {
            return Set.FirstOrDefault(a => a.CPF == codigo && a.Senha == senha);
        }
    }
}
