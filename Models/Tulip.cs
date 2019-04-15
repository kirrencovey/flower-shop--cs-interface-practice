namespace FlowerShop
{
    public class Tulip : IMothersDay
    {
        public string Name {get; set;}
        public string Color {get; set;}
        public int PetalCount {get; set;}
        public int Size {get; set;}
        public override string ToString() {
            return "A colorful tulip";
        }
    }
}