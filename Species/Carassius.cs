//Carassius is the genus and species of goldfish is Auratus
using System;

namespace zoolandia.Genus
{
    public class Carassius : Animal
    {
        public Carassius(string name): base(name)
        {
        this.Name =name;
        }
    
    public bool LowPredation{get; set;}
    public string FoodLocation{get; set;}
    }
}
