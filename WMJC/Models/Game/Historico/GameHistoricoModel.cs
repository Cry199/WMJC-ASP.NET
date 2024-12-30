using System;

namespace WMJC.Models.Game.Historico
{
    public class GameHistoricoModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdGame { get; set; }
        public DateTime Data { get; set; }

        public GameHistoricoModel() { }

        public GameHistoricoModel(int idUser, int idGame)
        {
            IdUser = idUser;
            IdGame = idGame;
        }

        public GameHistoricoModel(int id, int idUser, int idGame, DateTime data)
        {
            Id = id;
            IdUser = idUser;
            IdGame = idGame;
            Data = data;
        }
        public override string ToString()
        {
            return $"GameHistoricoModel {{ Id={Id}, IdUser={IdUser}, IdGame={IdGame}, Data={Data} }}";
        }
    }
}
