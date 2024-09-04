
using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Entidades;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Aplicacao
{
    public class PacienteAplicacao : IPacienteAplicacao
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;
        private readonly IPessoaAplicacao _pessoaAplicacao;
        private readonly IEnderecoAplicacao _enderecoAplicacao;

        public PacienteAplicacao(IPacienteRepositorio pacienteRepositorio, IPessoaAplicacao pessoaRepositorio, IEnderecoAplicacao enderecoAplicacao)
        {
            _pacienteRepositorio = pacienteRepositorio;
            _pessoaAplicacao = pessoaRepositorio;
            _enderecoAplicacao = enderecoAplicacao;
        }

        public int SalvarPaciente(PacienteModelo pacienteModelo)
        {
            var paciente = new Dominio.Entidades.Paciente
            {
                Status = pacienteModelo.Status,
                IdPessoa = pacienteModelo.IdPessoa,
                DataTriagem = DateTime.Now
            };
            var resultado = _pacienteRepositorio.Add(paciente);

            if (resultado != 0)
            {
                return paciente.Id;
            }

            return 0;

        }
    }
}
