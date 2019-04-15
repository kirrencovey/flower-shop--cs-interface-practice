namespace FlowerShop
{
    public class Daffodil : IMothersDay
    {
        public string Name {get; set;}
        public string Color {get; set;}
        public string SecondaryColor {get; set;}
        public int Size {get; set;}
        public override string ToString() {
            return "A joyful daffodil";
        }
    }
}