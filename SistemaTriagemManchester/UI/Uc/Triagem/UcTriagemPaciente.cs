using SistemaTriagemManchester.Aplicacao;
using SistemaTriagemManchester.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTriagemManchester.UI.Uc
{
    public partial class UcTriagemPaciente : UserControl
    {
        private readonly ITriagemAplicacao _triagemAplicacao;

        public UcTriagemPaciente(ITriagemAplicacao triagemAplicacao)
        {
            _triagemAplicacao = triagemAplicacao;
            InitializeComponent();
            textBoxChegada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            materialMultiLineTextBoxSequencial.Text = GerarIdentificadorPaciente();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        static string GerarIdentificadorPaciente()
        {
            DateTime agora = DateTime.Now;
            string diaDoAno = agora.DayOfYear.ToString("D3");
            string ano = agora.ToString("yy");
            string hora = agora.Hour.ToString("D2");
            string minuto = agora.Minute.ToString("D2");

            return $"{diaDoAno}{ano}{hora}{minuto}";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            _triagemAplicacao.Gravar(new Dominio.Modelos.TriagemModelo
            {
                CPF = materialMultiLineTextBoxPaciente.Text,
                DataHora = DateTime.Parse(textBoxChegada.Text),
                Sequencial = materialMultiLineTextBoxSequencial.Text,
                FrequenciaCardiaca = materialTextBoxFC.Text,
                PAS = materialTextBoxPAS.Text,
                Glicemia = materialTextBoxGlicemia.Text,
                FrequenciaRespiratoria = materialTextBoxFR.Text,
                HistoricoAlergico = materialMultiLineTextBoxAlergico.Text,
                Imunizacao = materialMultiLineTextBoxImunizacao.Text,
                SaturacaoOxigenio = materialTextBoxSAT02.Text,
                HistoricoCirurgico = materialMultiLineTextBoxCirurgico.Text,
                HistoricoClinico = materialMultiLineTextBoxClinico.Text,
                Sinais = materialMultiLineTextBoxSinais.Text,
                Sintomas = materialMultiLineTextBoxSintomas.Text,
                Temperatura = materialTextBoxT.Text
            }, new Dominio.PacienteModelo { DataTriagem = DateTime.Parse(textBoxChegada.Text), Status = "Triagem" });
        }
    }
}
