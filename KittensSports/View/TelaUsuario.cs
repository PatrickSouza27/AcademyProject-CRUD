namespace KittensSports.View
{
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void cadastrarTreinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroTreinos().ShowDialog();
        }

        private void rankingKittensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaRanking().ShowDialog();
        }
    }
}
