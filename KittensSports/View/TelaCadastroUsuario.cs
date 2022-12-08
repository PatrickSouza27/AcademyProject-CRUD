using KittensSports.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittensSports.View
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(ttbSenha.UseSystemPasswordChar==true)
            {
                ttbSenha.UseSystemPasswordChar=false;
                btnVer.Text = "Ocultar";
            }
            else
            {
                ttbSenha.UseSystemPasswordChar=true;
                btnVer.Text = "Ver";
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string email = ttbEmail.Text;

            bool valor = email.Contains("@") && email.Contains(".com");

            if (valor == true)
            {
              
            }

            else
            {
                MessageBox.Show("Digite um E-mail valido ");
            }

            if (TemEntradasValidas())
                return;

            //Montar o objeto para gravação
            Usuario objUsuario = new Usuario(ttbUsername.Text,
                ttbSenha.Text, ttbNome.Text, ttbEmail.Text);

            //Gravar objeto no banco
            if (objUsuario.Gravar())
                MessageBox.Show("Registro inserido com sucesso!");
            else
                MessageBox.Show("Erro ao gravar usuário. Tente novamente!");
            this.Close();
        }

        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(ttbNome.Text))
                listaErros.Add("\nPreencha o campo Nome!");
            if (string.IsNullOrEmpty(ttbEmail.Text))
                listaErros.Add("\nPreencha o campo E-Mail!");
            if (string.IsNullOrEmpty(ttbSenha.Text))
                listaErros.Add("\nPreencha o campo Senha!");
            if(string.IsNullOrEmpty(ttbUsername.Text))
                listaErros.Add("\nPreencha o campo Username!");

            if(listaErros.Count > 0)
            {
                string erros = "";
                foreach (var item in listaErros)
                    erros = erros + item;
                MessageBox.Show(erros, "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
