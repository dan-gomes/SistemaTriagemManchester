﻿using SistemaTriagemManchester.Apresentacao.UI.Interfaces;
using SistemaTriagemManchester.Apresentacao.UI.Manager;
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
    public partial class UcHistorico : UserControl
    {
        private readonly INavigationManager _navigationManager;
        public UcHistorico(INavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            InitializeComponent();
            navigationManager.DefinirUserControlAtual(this);
        }

        public override void Refresh()
        {
            base.Refresh();
            panelButtons.Visible = true;
        }
        
        private void BtnTriagens_Click(object sender, EventArgs e)
        {
            panelButtons.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcHistoricoTriagens, panelHistorico);
        }

        private void BtnExames_Click(object sender, EventArgs e)
        {
            panelButtons.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcHistoricoExames, panelHistorico);
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            panelButtons.Visible = false;
            _navigationManager.NavigateTo(UserControlEnum.UcHistoricoConsultas, panelHistorico);
        }
    }
}
