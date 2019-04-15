namespace FlowerShop
{
    public class Hydrangea : IBirthday
    {
        public string Name {get; set;}
        public string Color {get; set;}
        public int MaxHeight {get; set;}
        public override string ToString() {
            return "A lovely hydrangea";
        }
    }
}