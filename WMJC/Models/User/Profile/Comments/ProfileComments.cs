using System.Numerics;

namespace WMJC.Models.User.Profile.Comments
{
    public class ProfileComments
    {
        public long Id { get; set; }
        public string Comment { get; set; }
        public int IdPerfil { get; set; }
        public int IdUser { get; set; }

        public ProfileComments() { }

        public ProfileComments(long id, int idUser, int idPerfil, string comment)
        {
            Id = id;
            IdUser = idUser;
            IdPerfil = idPerfil;
            Comment = comment;
        }

        public ProfileComments(int idUser, int idPerfil, string comment)
        {
            IdUser = idUser;
            IdPerfil = idPerfil;
            Comment = comment;
        }

        public override string ToString()
        {
            return $"ProfileComments {{ Id={Id}, IdUser={IdUser}, IdPerfil={IdPerfil}, Comment={Comment} }}";
        }
    }
}
