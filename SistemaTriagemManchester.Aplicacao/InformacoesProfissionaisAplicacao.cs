using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao
{
    public class InformacoesProfissionaisAplicacao : IInformacoesProfissionaisAplicacao
    {
        private readonly ICargoRepositorio _cargoRepositorio;
        private readonly IEspecialidadeRepositorio _especialidadeRepositorio;
        private readonly IInformacoesProfissionaisRepositorio _informacoesProfissionaisRepositorio;

        public InformacoesProfissionaisAplicacao(ICargoRepositorio cargoRepositorio, IEspecialidadeRepositorio especialidadeRepositorio, IInformacoesProfissionaisRepositorio informacoesProfissionaisRepositorio)
        {
            _cargoRepositorio = cargoRepositorio;
            _especialidadeRepositorio = especialidadeRepositorio;
            _informacoesProfissionaisRepositorio = informacoesProfissionaisRepositorio;
        }

        public int Gravar(InformacoesProfissionaisModelo informacoesProfissionaisModelo)
        {
            var cargo = ObterCargoPorCodigo(informacoesProfissionaisModelo.Cargo.Codigo);
            var especialidade = ObterEspecialidadePorCodigo(informacoesProfissionaisModelo.Especialidade.Codigo);

            var endereco = new InformacoesProfissionais(informacoesProfissionaisModelo, cargo, especialidade);
            _informacoesProfissionaisRepositorio.Add(endereco);
            return endereco.Id;
        }

        public Cargo ObterCargoPorCodigo(short codigo)
        {
            return _cargoRepositorio.ObterPorCodigo(codigo);
        }

        public Especialidade ObterEspecialidadePorCodigo(short codigo)
        {
            return _especialidadeRepositorio.ObterPorCodigo(codigo);
        }
    }
}
