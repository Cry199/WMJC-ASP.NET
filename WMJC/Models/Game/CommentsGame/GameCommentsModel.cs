using System.Numerics;

namespace WMJC.Models.Game.CommentsGame
{
    public class GameCommentsModel
    {
        public long Id { get; set; }
        public long IdUser { get; set; }
        public long IdGame { get; set; }
        public string CommentGame { get; set; }

        public GameCommentsModel() { }

        public GameCommentsModel(long idUser, long idGame, string commentGame)
        {
            IdUser = idUser;
            IdGame = idGame;
            CommentGame = commentGame;
        }

        public GameCommentsModel(long id, long idUser, long idGame, string commentGame)
        {
            Id = id;
            IdUser = idUser;
            IdGame = idGame;
            CommentGame = commentGame;
        }

        public override string ToString()
        {
            return $"GameCommentsModel {{ Id={Id}, IdUser={IdUser}, IdGame={IdGame}, CommentGame={CommentGame} }}";
        }
    }
}
