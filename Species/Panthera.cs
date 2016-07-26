//genus Panthera  is for jaguar Panthera Onca
using System;

namespace zoolandia.Genus
{
    public class Panthera : Animal
    {
        public Panthera(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
    }
}