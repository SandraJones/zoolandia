//this is genus Loxodonta for Loxodonta Africana African Elephont
using System;

namespace zoolandia.Genus
{
    public class Loxodonta : Animal
    {
        public Loxodonta(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
    }
}