using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTriagemManchester.Apresentacao.UI
{
    public partial class FormLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public FormLogin()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool isValidUser = ValidateUser(usuario.Text, senha.Text);

            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            // Coloque aqui a lógica de validação
            return username == "admin" && password == "senha";
        }
    }
}
