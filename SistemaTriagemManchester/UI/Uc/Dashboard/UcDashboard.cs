using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Devices;
using SistemaTriagemManchester.Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace SistemaTriagemManchester.UI.Uc.Dashboard
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        //        1. Visão Geral
        //Número Total de Pacientes Hoje: Um indicador numérico grande e centralizado, que mostra quantos pacientes foram atendidos no dia.
        //Distribuição por Tipo de Atendimento:
        //Gráfico de barras ou pizza mostrando quantos pacientes foram atendidos em cada tipo de serviço(consultas, triagens, urgências).
        //2. Seção de Atendimentos
        //        Indicadores Chave:
        //Total de Atendimentos: Número total de atendimentos realizados hoje ou em um período selecionado.
        //Médico com Mais Atendimentos: Nome do médico que realizou o maior número de atendimentos.
        //Tempo Médio de Atendimento: Mostra o tempo médio que os médicos levaram para atender cada paciente.
        //Gráfico: Um gráfico de linha ou barra que mostra a evolução dos atendimentos ao longo do dia ou do período selecionado.
        //3. Seção de Triagens
        //Indicadores Chave:
        //Total de Triagens Realizadas: Quantidade de triagens realizadas hoje.
        //        Tempo Médio de Triagem: Tempo médio gasto para completar cada triagem.
        //Sintoma Mais Comum: O sintoma mais frequentemente relatado pelos pacientes triados.
        //Distribuição por Grau de Urgência:
        //Gráfico de pizza mostrando a proporção de triagens por grau de urgência (vermelho, laranja, amarelo, verde, azul).
        //4. Seção de Urgências
        //        Indicadores Chave:
        //Pacientes com Alta Urgência (Vermelho/Laranja): Número de pacientes classificados como alta urgência.
        //        Tempo de Resposta para Urgências: Tempo médio que levou para esses pacientes críticos serem atendidos.
        //Casos Críticos Atendidos: Número de casos críticos atendidos com sucesso (por exemplo, urgências que resultaram em internação imediata).
        //Gráfico: Gráfico de barras mostrando a distribuição dos casos de urgência ao longo do dia ou período selecionado.
        //5. Alertas e Notificações
        //Pacientes em Espera Prolongada: Indicador ou lista que destaca pacientes que estão aguardando atendimento além do tempo ideal.
        //Alertas de Sistema: Notificações de eventos críticos, como sobrecarga de filas, problemas técnicos, ou outras questões urgentes.
        //6. Resumo Gráfico
        //Gráfico de Ocupação: Mostra a ocupação das salas de atendimento e triagem, visualizando quantas estão em uso e quantas estão disponíveis.
        //Tendências: Um gráfico de linha ou área que mostra as tendências de atendimento ao longo do tempo (por exemplo, comparando o dia atual com os dias anteriores).
        //Layout do Dashboard
        //Layout em Grade

        //Organize o Dashboard em uma grade de 2x2 ou 3x2, dependendo do espaço disponível e da quantidade de informações que deseja mostrar.
        //Coloque os indicadores mais importantes no topo, seguidos pelos gráficos e outras informações detalhadas.
        //Seção Superior: Indicadores Chave

        //Coloque os indicadores chave (como número total de pacientes, atendimentos, triagens, etc.) no topo, com ícones e números grandes para fácil visualização.
        //Seção Central: Gráficos

        //Utilize a seção central do Dashboard para gráficos de barras, pizza, ou linhas que mostram as distribuições de dados e tendências importantes.
        //Seção Inferior: Alertas e Notificações

        //A seção inferior pode ser reservada para alertas, notificações, e listas de pacientes em estado crítico ou com espera prolongada.
    }
}
