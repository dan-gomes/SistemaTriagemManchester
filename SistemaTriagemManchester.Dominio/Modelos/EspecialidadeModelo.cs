using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Dominio.Modelos
{
    public class EspecialidadeModelo
    {
        public short Codigo { get; set; }
        public string Nome { get; set; }

        public static explicit operator EspecialidadeModelo(Especialidade especialidade)
        {
            return new EspecialidadeModelo
            {
                Codigo = especialidade.Codigo,
                Nome = especialidade.Nome
            };
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nome}";
        }
    }
}
