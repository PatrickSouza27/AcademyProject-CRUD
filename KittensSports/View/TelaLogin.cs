using KittensSports.Controller;
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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        public static string UsuarioLogado { get; set; }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Validando a digitação dos campos usuário e senha
            if (string.IsNullOrEmpty(ttbUsuario.Text)
                && string.IsNullOrEmpty(ttbSenha.Text))
            {
                MessageBox.Show("Digite o usuário e senha!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //Validação de usuário e senha
            if (TemUsuarioValido())
            {
                this.Hide();
                new TelaPrincipal().ShowDialog();
                this.Close();
            }
            MessageBox.Show("Login rejeitado. Verifique seu usuário e senha!");
        }
        private bool TemUsuarioValido()
        {
            DataTable dtResultado = new UsuarioController().BuscarUsuarios();
            //Verificar se tem registros na base
            if (dtResultado.Rows.Count > 0)
            {
                //Validar usuário e senha com a base de dados
                DataTable dt = new UsuarioController().BuscaLogin(ttbUsuario.Text, ttbSenha.Text);
                UsuarioLogado = ttbUsuario.Text;
                if (dt.Rows.Count > 0)
                    return true;
            }
            else
            {
                //Validar usuário e senha como primeiro acesso
                if (ttbUsuario.Text == "admin" && ttbSenha.Text == "1234")
                {
                   
                    return true;
                }
            }
            return false;
        }

    }
}
