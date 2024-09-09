using SistemaTriagemManchester.Dominio.Enums;

namespace SistemaTriagemManchester.Dominio
{
    public interface IClassificacaoAplicacao
    {
        Grau CompararClassificacoes(int[] sintomas);
    }
}
