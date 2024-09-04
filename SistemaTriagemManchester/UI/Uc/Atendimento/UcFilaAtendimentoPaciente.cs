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
    public partial class UcFilaAtendimentoPaciente : UserControl
    {
        public UcFilaAtendimentoPaciente()
        {
            InitializeComponent();
        }

        public void AdicionarItem(string posicao, string nome, string horaChegada, string status)
        {
            dataGridView1.Rows.Add(posicao, nome, horaChegada, status);
        }

        public void LimparFila()
        {
            dataGridView1.Rows.Clear();
        }

        public DataGridViewRowCollection ObterFilas()
        {
            return dataGridView1.Rows;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
