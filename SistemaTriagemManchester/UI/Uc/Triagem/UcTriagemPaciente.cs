using SistemaTriagemManchester.Aplicacao;
using SistemaTriagemManchester.Aplicacao.Interfaces;
using SistemaTriagemManchester.Dominio.Enums;
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
            var grau = _triagemAplicacao.ClassificarPaciente(materialMultiLineTextBoxSintomas.Text, materialMultiLineTextBoxPaciente.Text);

            DialogResult resultado = MessageBox.Show("Deseja utilizar a classificação de atendimento sistémica?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

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
                Temperatura = materialTextBoxT.Text,
                Classificacao = resultado == DialogResult.Yes ? grau : (Grau)materialComboBoxUrgencia.SelectedIndex
            }, new Dominio.PacienteModelo { DataTriagem = DateTime.Parse(textBoxChegada.Text), Status = "Triagem" });
        }       

        private void materialLabel19_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel17_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
