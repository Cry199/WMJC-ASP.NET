using System.Numerics;

namespace WMJC.Models.User
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string TipoUser { get; set; }
        public string Username { get; set; }

        public UserModel() { }

        public UserModel(string username, string password, string tipoUser)
        {
            Email = username;
            Senha = password;
            TipoUser = tipoUser;
        }

        public UserModel(long id, string email, string senha, string tipoUser, string username)
        {
            Id = id;
            Email = email;
            Senha = senha;
            TipoUser = tipoUser;
            Username = username;
        }

        public override string ToString()
        {
            return $"UserModel {{ Id={Id}, Nome={Nome}, Sobrenome={Sobrenome}, Email={Email}, Senha={Senha}, TipoUser={TipoUser}, Username={Username} }}";
        }
    }
}
