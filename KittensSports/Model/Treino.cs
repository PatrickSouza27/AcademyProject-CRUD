using KittensSports.Controller;

namespace KittensSports.Model
{
    public class Treino
    {
        public string NomeTreino { get; private set; }
        public string Tempo { get; private set; }
        public string Velocidade { get; private set; }
        public string BPM { get; private set; }

        public string Inclinacao { get; private set; }

        public Treino()
        {

        }

        public Treino(string nomecp, string tempo, string velocidade, string bpm, string inclinacao)
        {
            NomeTreino = nomecp;
            Tempo = tempo;
            Velocidade = velocidade;
            BPM = bpm;
            Inclinacao = inclinacao;
        }

      
    }

}
