using KittensSports.DAO;
using KittensSports.Model;
using KittensSports.View;
using System.Data;

namespace KittensSports.Controller
{
    public class UsuarioController
    {
        public bool Gravar(Usuario obj)
        {
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"insert into usuario (username, senha, fullName, email)
                        values (@un, @senha, @nome, @mail)",
                    "@un", obj.Username, "@senha", obj.Password,
                    "@nome", obj.NomeCompleto, "@mail", obj.Email);
            }
        }
        public DataTable BuscarUsuarios()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from usuario", out dt);
                return dt;
            }
        }

        public DataTable BuscaLogin(string user, string senha)
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from usuario where 
                    username = @user and senha = @senha", out dt,
                    "@user", user, "@senha", senha);
                return dt;
            };
        }
        public DataTable BuscarUsuariosinfo(string x)
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select @tipo from usuario where username = @user", out dt, "@tipo", x, "@user", TelaLogin.UsuarioLogado);
                return dt;
            }
        }

        public bool Alterar(Usuario obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"update usuario set Senha=@senha, fullName=@ncp, email=@email where username=@nik",
                    "@nik", obj.Username, "@senha", obj.Password, "@ncp", obj.NomeCompleto, "@email", obj.Email);
            }
        }
        public bool Excluir(string id)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(@"delete from Usuario where username = @param",
                    "@param", id);
            }
        }


    }
}
