//genus Bos  is for dairy cow, species Taurus
using System;

namespace zoolandia.Genus
{
    public class Bos : Animal
    {
        public Bos(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
    }
}