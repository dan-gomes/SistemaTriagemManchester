using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao
{
    public class CargoAplicacao : ICargoAplicacao
    {
        private readonly ICargoRepositorio _cargoRepositorio;

        public CargoAplicacao(ICargoRepositorio cargoRepositorio)
        {
            _cargoRepositorio = cargoRepositorio;
        }

        public List<CargoModelo> ObterCargos()
        {
            return _cargoRepositorio.ObterCargos().Select(a => (CargoModelo)a).ToList();
        }
    }
}
