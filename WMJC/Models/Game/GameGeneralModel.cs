namespace WMJC.Models.Game
{
    public class GameGeneralModel
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string Op1 { get; set; }
        public string Ref1 { get; set; }
        public string Op2 { get; set; }
        public string Ref2 { get; set; }
        public string Op3 { get; set; }
        public string Ref3 { get; set; }
        public string Image { get; set; }

        public GameGeneralModel(){ }

        public GameGeneralModel(int id, string texto, string op1, string ref1, string op2, string ref2, string op3, string ref3, string image)
        {
            Id = id;
            Texto = texto;
            Op1 = op1;
            Ref1 = ref1;
            Op2 = op2;
            Ref2 = ref2;
            Op3 = op3;
            Ref3 = ref3;
            Image = image;
        }

        public GameGeneralModel(string texto, string op1, string ref1, string op2, string ref2, string op3, string ref3, string image)
        {
            Texto = texto;
            Op1 = op1;
            Ref1 = ref1;
            Op2 = op2;
            Ref2 = ref2;
            Op3 = op3;
            Ref3 = ref3;
            Image = image;
        }

        public override string ToString()
        {
            return $"GameGeneralModel {{ Id={Id}, Texto={Texto}, Op1={Op1}, Ref1={Ref1}, Op2={Op2}, Ref2={Ref2}, Op3={Op3}, Ref3={Ref3}, Image={Image} }}";
        }
    }
}
