namespace FlowerShop
{
    public class Rose : IBirthday
    {
        public string Name {get; set;}
        public string Color {get; set;}
        public bool Thorns {get; set;}
        public override string ToString() {
            return "A beautiful rose";
        }
    }
}