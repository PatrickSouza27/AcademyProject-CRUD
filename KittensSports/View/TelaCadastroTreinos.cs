using Guna.UI2.WinForms;
using KittensSports.Controller;
using KittensSports.DAO;
using KittensSports.Model;


namespace KittensSports.View
{
    public partial class TelaCadastroTreinos : Form
    {
        public TelaCadastroTreinos()
        {
            InitializeComponent();
            guna2ComboBox1.SelectedItem = "Segunda-Feira";
            guna2ComboBox1.Items.RemoveAt(0);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaConsulta().ShowDialog();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (TemEntradasValidas())
            {
   
                Treino objTreino = new Treino(ttbTreino.Text, ttbTempo.Text, ttbVelocidade.Text, ttbInclinacao.Text, ttbBPM.Text);
                ControllerTreino teste = new ControllerTreino();
                bool ok = teste.Gravar(objTreino);

                if (ok)
                {
                    MessageBox.Show("Registro inserido com sucesso!");
                }
                else
                MessageBox.Show("Erro ao gravar registro no banco de dados! Tente novamente!");

            }
            return;
        }

        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();
            if (string.IsNullOrEmpty(ttbTreino.Text))
                listaErros.Add("\nO campo Nome do Treino precisa ser preenchido!");
           
            //TEMPO
            if (string.IsNullOrEmpty(ttbTempo.Text))
                listaErros.Add("\nO campo Tempo precisa ser preenchido!");
            if (!int.TryParse(ttbTempo.Text, out int valor1) || valor1 < 0)
                listaErros.Add("\nO Campo tempo deve ser preenchido em Numero");
           
            //VELOCIDADE
            if (string.IsNullOrEmpty(ttbVelocidade.Text))
                listaErros.Add("\nO campo Velocidade precisa ser preenchido!");
            if (!int.TryParse(ttbTempo.Text, out int valor5) || valor5 < 0)
                listaErros.Add("\nO Campo Velocidade deve ser preenchido em Numero");
            
            //BPM
            if (string.IsNullOrEmpty(ttbBPM.Text))
                listaErros.Add("\nO campo BPM precisa ser preenchido!");
            if (!int.TryParse(ttbBPM.Text, out int valor3) || valor3 < 0)
                listaErros.Add("\nO Campo BPM deve ser preenchido em Numero");
            
            //Inclinação
            if (string.IsNullOrEmpty(ttbInclinacao.Text))
                listaErros.Add("\nO campo Inclinação precisa ser preenchido!");
            if (!int.TryParse(ttbInclinacao.Text, out int valor4) || valor4 < 0)
                listaErros.Add("\nO Campo Inclinação deve ser preenchido em Numero");




            if (listaErros.Count > 0)
            {
                MostraErros(listaErros);
                return false;
            }
            return true;
        }

        private void MostraErros(List<string> erros)
        {
            string mensagens = "";
            foreach (var item in erros)
                mensagens = mensagens + item;

            MessageBox.Show(mensagens, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

/*        private void LimpaTela()
        {
            ttbTempo.Clear();
            ttbVelocidade.Clear();
            ttbTreino.Clear();
            ttbBPM.Clear();
            ttbInclinacao.Clear();
        }
*/

        public void btnExcluir_Click(object sender, EventArgs e)
        {
          bool Excluir(int id)
            {
                BancoInstance banco;
                using (banco = new BancoInstance())
                {
                    return banco.Banco.ExecuteNonQuery(@"delete from Usuario where Id = @param",
                        "@param", id);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool Alterar(Treino obj)
            {
                BancoInstance banco;
                using (banco = new BancoInstance())
                {
                    return banco.Banco.ExecuteNonQuery(
                        @"update Treino set Nome_Treino=@tcp, Tempo=@temp, Velocidade=@velo, BPM=@bpm, Inclinação=@incli where ",
                        "@tcp", obj.NomeTreino, "@temp", obj.Tempo, "@velo", obj.Velocidade, "@bpm", obj.BPM, "@incli", obj.Inclinacao);
                }
            }
        }

    }
}
