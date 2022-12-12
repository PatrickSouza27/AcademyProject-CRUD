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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KittensSports.View
{
    public partial class TelaCadastroEditUsuario : Form
    {
        bool Edit;
        public TelaCadastroEditUsuario(bool edit)
        {
            Edit = edit;
            InitializeComponent();
            if (edit)
            {
                xxx.Text = "Edit {User} screen";
                guna2Button4.Visible = true;
                btnGravar.Visible = false;
                ttbUsername.Text = TelaLogin.UsuarioLogado;
                ttbUsername.Enabled = false;
            }
            else
            {
                ttbUsername.Text = null;
                ttbUsername.Enabled = true;
                xxx.Text =  "Register {User}";
                guna2Button4.Visible = false;
                btnGravar.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
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
        private void LimpaCampos()
        {
            ttbUsername.Text = Edit ? ttbUsername.Text : null;
            ttbNome.Clear();
            ttbSenha.Clear();
            ttbEmail.Clear();
        }
        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();
            bool valor = ttbEmail.Text.Contains("@") && ttbEmail.Text.Contains(".com");

            if (string.IsNullOrEmpty(ttbNome.Text))
                listaErros.Add("\nPreencha o campo Nome!");
            if (string.IsNullOrEmpty(ttbEmail.Text) || valor == false)
                listaErros.Add("\nEmail Invalido!!");
            if (string.IsNullOrEmpty(ttbSenha.Text))
                listaErros.Add("\nPreencha o campo Senha!");
            if (string.IsNullOrEmpty(ttbUsername.Text))
                listaErros.Add("\nPreencha o campo Username!");

            if (listaErros.Count > 0)
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(ttbUsername.Text,
                ttbSenha.Text, ttbNome.Text, ttbEmail.Text);
            try
            {
                usuario.Alterar();
                MessageBox.Show("Usuário Alterado com sucesso");
                this.Close();
                LimpaCampos();
            }
            catch
            {
                MessageBox.Show("Usuário Não gravado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
