using Guna.UI2.WinForms;
using KittensSports.View;

namespace KittensSports
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        public int Cont { get; set; }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroUsuario().ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            InicioLabel1.Text = "Screen User";
            InicioLabel2.Visible = false;
            guna2Panel3.Visible = false;
            guna2GradientPanel1.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible= false;
            InicioLabel1.Text = "Hi {Nome},";
            InicioLabel2.Visible = true;
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
            if(Cont == 1)
            {
                guna2NotificationPaint1.Text = "1";
            }
            else if(Cont == 2)
            {
                guna2NotificationPaint1.Text = "2";
            }
            else
            {
                guna2NotificationPaint1.Text = "3";
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
    }
}