using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Enums;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao.Interfaces
{
    public interface ITriagemAplicacao
    {
        Grau ClassificarPaciente(string sintomas);
        bool Gravar(TriagemModelo triagemModelo, PacienteModelo pacienteModelo);
    }
}
