using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades.MachineLearning;
using SistemaTriagemManchester.Dominio.Enums;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;
using SistemaTriagemManchester.Dominio.Modelos;

namespace SistemaTriagemManchester.Aplicacao
{
    public class TriagemAplicacao : ITriagemAplicacao
    {
        private readonly IClassificacaoAplicacao _classificacaoAplicacao;
        private readonly ITriagemRepositorio _triagemRepositorio;
        private readonly IPessoaAplicacao _pessoaAplicacao;
        private readonly IPacienteAplicacao _pacienteAplicacao;

        public TriagemAplicacao(IClassificacaoAplicacao classificacaoAplicacao, ITriagemRepositorio triagemRepositorio, IPessoaAplicacao pessoaAplicacao, IPacienteAplicacao pacienteAplicacao)
        {
            _classificacaoAplicacao = classificacaoAplicacao;
            _triagemRepositorio = triagemRepositorio;
            _pessoaAplicacao = pessoaAplicacao;
            _pacienteAplicacao = pacienteAplicacao;
        }

        public Grau ClassificarPaciente(string sintomas)
        {
            return _classificacaoAplicacao.CompararClassificacoes(Sintomas(sintomas));
        }

        public bool Gravar(TriagemModelo triagemModelo, PacienteModelo pacienteModelo)
        {

            var pessoa = _pessoaAplicacao.Obter(new PessoaModelo { CPF = triagemModelo.CPF });

            if (pessoa == null)
                return false;

            var idPaciente = _pacienteAplicacao.SalvarPaciente(pacienteModelo);

            if (idPaciente == 0)
                return false;

            triagemModelo.IdPaciente = idPaciente;
            if (_triagemRepositorio.Add((Triagem)triagemModelo) != 0)
                return true;

            return false;
        }

        public int[] Sintomas(string sintomasPaciente)
        {
            var sintomasList = new List<int>();

            var sintomas = sintomasPaciente.Split(';').ToArray();

            // Verifica a presença de cada sintoma na string e adiciona 1 ou 0 na lista
            sintomasList.Add(sintomas.Contains("Febre") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("Tosse") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("DorCabeca") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("Fadiga") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("SedeExcessiva") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("MiccaoFrequente") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("VisaoEmbacada") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("Tremores") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("ConfusaoMental") ? 1 : 0);
            sintomasList.Add(sintomas.Contains("SuorExcessivo") ? 1 : 0);

            return sintomasList.ToArray();
        }
    }
}
