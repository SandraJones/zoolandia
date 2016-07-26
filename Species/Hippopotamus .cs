//genus Hippopotamus species Amphibius
using System;

namespace zoolandia.Genus
{
    public class Hippopotamus: Animal
    {
        public Hippopotamus(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
    }
}
