using System.Numerics;

namespace WMJC.Models.Game
{
    public class GameModel
    {
        public long Id { get; set; }
        public long IdUser { get; set; }
        public string NameGame { get; set; }
        public string NameTable { get; set; }
        public string DescGame { get; set; }
        public string BannerGamer { get; set; }

        public GameModel() { }

        public GameModel(long id, long idUser, string nameGame, string nameTable, string descGame, string bannerGamer)
        {
            Id = id;
            IdUser = idUser;
            NameGame = nameGame;
            NameTable = nameTable;
            DescGame = descGame;
            BannerGamer = bannerGamer;
        }

        public override string ToString()
        {
            return $"GameModel {{ Id={Id}, IdUser={IdUser}, NameGame={NameGame}, NameTable={NameTable}, DescGame={DescGame}, BannerGamer={BannerGamer} }}";
        }
    }
}
