using KittensSports.View;

namespace KittensSports
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroUsuario().ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {          
            InicioLabel1.Visible = false;
            InicioLabel2.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            InicioLabel1.Visible = true;
            InicioLabel2.Visible = true;
        }
    }
}