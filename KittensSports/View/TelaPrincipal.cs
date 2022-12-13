using Guna.UI2.WinForms;
using KittensSports.Controller;
using KittensSports.DAO;
using KittensSports.View;

namespace KittensSports
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            guna2ComboBox1.SelectedItem = "Todos Treinos";

        }
        public int Cont { get; set; }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroEditUsuario(false).ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            guna2Panel17.Visible = false;
            guna2HtmlLabel8.Visible = false;
            guna2Panel5.Location = new Point(253, 127);
            guna2Panel5.Size = new Size(571, 387);
            guna2DateTimePicker1.Value = DateTime.Now;
            guna2Panel5.Visible = true;
            InicioLabel1.Text = "Screen User";
            InicioLabel2.Text = " Tela Usuário";
            guna2Panel3.Visible = false;
            guna2GradientPanel1.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel17.Visible = false;
            Cont = 0;
            guna2HtmlLabel8.Visible = false;
            guna2Panel5.Visible= false;
            InicioLabel1.Text = "Hi {Nome},";
            InicioLabel2.Text = " Welcome Back";
            //--------------painel principal------
            guna2Panel3.Visible = true;
            guna2Panel3.Location = new Point(253, 132);
            guna2Panel3.Size = new Size(565, 204);

            //segundo painel
            guna2GradientPanel1.Visible = true;
            guna2GradientPanel1.Location = new Point(253, 360);
            guna2GradientPanel1.Size = new Size(338, 158);

            //terceiro painel
            guna2Panel4.Visible = true;
            guna2Panel4.Location = new Point(606, 360);
            guna2Panel4.Size = new Size(206, 157);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = false;
            guna2GradientPanel1.Location = new Point(253, 137);
            guna2Panel4.Location = new Point(606, 137);
            Cont += 1;
            AcrescentaConta();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Visible = false;
            Cont += 1;
            AcrescentaConta();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = false;
            Cont += 1;
            AcrescentaConta();
        }
        public void AcrescentaConta()
        {
            if(Cont == 0)
            {
                guna2NotificationPaint1.Visible= false;
            }
            else
            {
                guna2NotificationPaint1.Visible = true;
            }
            
                guna2NotificationPaint1.Text = Cont.ToString();
            
            if(Cont == 3)
            {
                guna2HtmlLabel8.Visible= true;
            }
            else
            {
                guna2HtmlLabel8.Visible = false;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Cont = 0;
            AcrescentaConta();
            guna2Panel3.Visible = true;
            guna2GradientPanel1.Visible = true;
            guna2Panel4.Visible = true;
            guna2GradientPanel1.Location = new Point(253, 360);
            guna2Panel4.Location = new Point(606, 360);
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            new TelaCadastroEditUsuario(false).ShowDialog();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            new TelaCadastroEditUsuario(true).ShowDialog();  
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            UsuarioController usuario = new UsuarioController();
            try {
                DialogResult opc = MessageBox.Show("Atenção, ao confirmar seu Usuário será apagado, tem certeza que deseja fazer isso?", "Atenção -> Excluir Usuário", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (opc == DialogResult.OK)
                {
                    usuario.Excluir(TelaLogin.UsuarioLogado);
                    MessageBox.Show("Usuario Excluido com sucesso");
                }
            }
            catch
            {
                MessageBox.Show("Error ao Excluir Usuario");
            }
            this.Close();

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = false;
            guna2Panel17.Visible = true;
            InicioLabel1.Text = "Screen Treino";
            InicioLabel2.Text = " Tela Treino";
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            bool Excluir(int id)
            {
                BancoInstance banco;
                using (banco = new BancoInstance())
                {
                    return banco.Banco.ExecuteNonQuery(@"delete from Treino where Id = @param",
                        "@param", id);
                }
            }
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            new TelaCadastroTreinos(false).ShowDialog();
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            new TelaCadastroTreinos(true).ShowDialog();
        }
    }
}