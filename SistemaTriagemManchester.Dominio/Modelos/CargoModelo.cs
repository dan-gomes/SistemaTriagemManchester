using SistemaTriagemManchester.Dominio.Entidades;

namespace SistemaTriagemManchester.Dominio.Modelos
{
    public class CargoModelo
    {
        public short Codigo { get; set; }
        public string Nome { get; set; }


        public static explicit operator CargoModelo(Cargo cargo)
        {
            return new CargoModelo
            {
                Codigo = cargo.Codigo,
                Nome = cargo.Nome
            };
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nome}";
        }
    }
}
