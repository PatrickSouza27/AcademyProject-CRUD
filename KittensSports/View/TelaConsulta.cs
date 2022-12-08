namespace KittensSports.View
{
    public partial class TelaConsulta : Form
    {
        public TelaConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<string> listaErros = new List<string>();
            if (string.IsNullOrEmpty(textBox1.Text))
                listaErros.Add("\nO campop palavra-chae precisa ser preenchido!");


        }

        private void MostraErros(List<string> erros)
        {
            string mensagens = "";
            foreach (var item in erros)
                mensagens = mensagens + item;

            MessageBox.Show(mensagens, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ttbPalavraChave.Clear();
        }
    }
}
