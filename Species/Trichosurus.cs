//genus Trichosurus for possum  species Caninus
using System;

namespace zoolandia.Genus
{
    public class Trichosurus : Animal
    {
        public Trichosurus(string name): base(name)
        {
        this.Name =name;
        }
    
    public bool LowPredation{get; set;}
    public string FoodLocation{get; set;}
    }  
}
