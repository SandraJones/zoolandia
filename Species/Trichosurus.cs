//genus Trichosurus for possum  species Caninus
using System;

namespace zoolandia.Genus
{
    public class Trichosurus : Animal, IAmbulatory
    {
        public Trichosurus(string name): base(name)
        {
        this.Name =name;
        }
    
    public bool LowPredation{get; set;}
    public string FoodLocation{get; set;}
    public void run()
    {
        Console.WriteLine("Trichorsurus Genus is running!");
    }
    public void walk()
    {
        Console.WriteLine("Trichorsurus Genus is walking.");
    }
    }  
}
