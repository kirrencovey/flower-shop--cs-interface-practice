using System.Collections.Generic;

namespace FlowerShop
{
    public class FlowerShop
    {
        public string Name {get; set;}
        public string Address {get; set;}
        public List<Daffodil> Daffodils = new List<Daffodil>();
        public List<Hydrangea> Hydrangeas = new List<Hydrangea>();
        public List<Rose> Roses = new List<Rose>();
        public List<Tulip> Tulips = new List<Tulip>();
        public List<IMothersDay> MakeMothersDayArrangement () {
            List<IMothersDay> arrangement = new List<IMothersDay>() {
                new Tulip() { Size = 2 },
                new Tulip() { Size = 2 },
                new Tulip() { Size = 2 },
                new Daffodil() { Size = 1 },
                new Daffodil() { Size = 1 },
            };
            return arrangement;
        }
        public List<IBirthday> MakeBirthdayArrangement () {
            List<IBirthday> arrangement = new List<IBirthday>() {
                new Hydrangea(),
                new Hydrangea(),
                new Rose(),
                new Rose(),
                new Rose(),
                new Rose(),
                new Rose(),
            };
            return arrangement;
        }
    }
}