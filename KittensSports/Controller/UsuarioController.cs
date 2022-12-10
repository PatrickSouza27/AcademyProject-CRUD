﻿using KittensSports.DAO;
using KittensSports.Model;
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

        public bool Alterar(Usuario obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"update Pessoa set username=@nik, Senha=@senha, fullName=@ncp, email=@email where ",
                    "@nik", obj.Username, "@senha", obj.Password, "@ncp", obj.NomeCompleto, "@email", obj.Email);
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


    }
}