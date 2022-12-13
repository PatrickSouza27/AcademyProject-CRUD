using KittensSports.DAO;
using KittensSports.Model;
using System.Data;

namespace KittensSports.Controller
{
    public class ControllerTreino
    {
        public bool Gravar(Treino obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"insert into Treino (Nome_Treino, Tempo, Velocidade, BPM,Inclinação) 
                        values (@tcp, @temp, @velo, @bpm, @incli)",
                    "tcp", obj.NomeTreino, "@temp", obj.Tempo,
                    "@velo", obj.Velocidade, "@bpm", obj.BPM,"@incli",obj.Inclinacao);
            }
        }
        public bool Alterar(Treino obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"update Treino set Nome_Treino=@tcp, Tempo=@temp, Velocidade=@velo, BPM=@bpm, Inclinação=@incli where ",
                    "@tcp", obj.NomeTreino, "@temp", obj.Tempo, "@velo", obj.Velocidade, "@bpm", obj.BPM, "@incli",obj.Inclinacao);
            }
        }

        public bool Excluir(int id)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(@"delete from Usuario where Id = @param",
                    "@param", id);
            }
        }
        public DataTable BuscarTreino(string chave)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Treino",out retorno);
                return retorno;
            }
        }
        public DataTable BuscarTreinoEspecifico(string chave)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Treino where fk_treino = @user", out retorno);
                return retorno;
            }
        }
    }
}
