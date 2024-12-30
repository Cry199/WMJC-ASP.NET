namespace WMJC.Models.Game.Historico
{
    public class GameContadorModel
    {
        public int Id { get; set; }
        public int IdJogo { get; set; }
        public int Contador { get; set; }

        public GameContadorModel() { }

        public GameContadorModel(int id, int idJogo, int contador)
        {
            Id = id;
            IdJogo = idJogo;
            Contador = contador;
        }

        public override string ToString()
        {
            return $"GameContadorModel {{ Id={Id}, IdJogo={IdJogo}, Contador={Contador} }}";
        }
    }
}
