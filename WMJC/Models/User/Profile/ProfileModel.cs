using System.Numerics;

namespace WMJC.Models.User.Profile
{
    public class ProfileModel
    {
        public long Id { get; set; }
        public long IdDoUser { get; set; }
        public string ProfileName { get; set; }
        public string PicProfile { get; set; }
        public string TypeUser { get; set; }

        public ProfileModel() { }

        public ProfileModel(string profileName, string picProfile)
        {
            ProfileName = profileName;
            PicProfile = picProfile;
        }

        public ProfileModel(long id, long idDoUser, string profileName, string picProfile, string typeUser)
        {
            Id = id;
            IdDoUser = idDoUser;
            ProfileName = profileName;
            PicProfile = picProfile;
            TypeUser = typeUser;
        }

        public override string ToString()
        {
            return $"ProfileModel {{ IdProfile={Id}, IdDoUser={IdDoUser}, ProfileName={ProfileName}, PicProfile={PicProfile}, TypeUser={TypeUser} }}";
        }
    }
}
