using KittensSports.DAO;
using KittensSports.Model;
using System.Data;
using KittensSports.View;

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
                    @"insert into Treino (Nome_Treino, Tempo, Velocidade, BPM,Inclinação, FK_usuario, DiaGrupo) 
                        values (@tcp, @temp, @velo, @bpm, @incli, @user, @day)",
                    "tcp", obj.NomeTreino, "@temp", obj.Tempo,
                    "@velo", obj.Velocidade, "@bpm", obj.BPM,"@incli",obj.Inclinacao, "@user", TelaLogin.UsuarioLogado, "@day", obj.DiaTreino);
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
        public DataTable BuscarTreino()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select Nome_treino, Tempo, Velocidade, Bpm, Inclinação from Treino where FK_usuario = @user",out retorno, "@user", TelaLogin.UsuarioLogado);
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
