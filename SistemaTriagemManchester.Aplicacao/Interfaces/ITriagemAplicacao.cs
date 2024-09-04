using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao.Interfaces
{
    public interface ITriagemAplicacao
    {
        bool Gravar(TriagemModelo triagemModelo, PacienteModelo pacienteModelo);
    }
}
