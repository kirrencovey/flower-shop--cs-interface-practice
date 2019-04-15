using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop GoldenrodFlowers = new FlowerShop();

            GoldenrodFlowers.MakeMothersDayArrangement()
                .ForEach(flower => Console.WriteLine(flower));

            GoldenrodFlowers.MakeBirthdayArrangement()
                .ForEach(flower => Console.WriteLine(flower));
        }
    }
}
