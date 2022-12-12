using KittensSports.Controller;

namespace KittensSports.Model
{
    public class Usuario
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Email { get; private set;  }

        public Usuario()
        {

        }

        public Usuario(string username, string password, string nomeCompleto, string email)
        {
            Username = username;
            Password = password;
            NomeCompleto = nomeCompleto;
            Email = email;
        }
        public bool Alterar()
        {
            return new UsuarioController().Alterar(this);
        }
        public bool Gravar()
        {
            return new UsuarioController().Gravar(this);
        }
    }
}
