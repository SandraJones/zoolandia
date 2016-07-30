//this is genus Loxodonta for Loxodonta Africana African Elephont
using System;

namespace zoolandia.Genus
{
    public class Loxodonta : Animal, IAmbulatory, IHerbivore
    {
        public Loxodonta(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
        public void run()
        {
            Console.WriteLine("Loxodonta Genus is running!");
        }
        public void walk()
        {
            Console.WriteLine("Loxodonta Genus is now walking.");
        }
        public void eatsPlants()
        {
            Console.WriteLine("Loxodonta Genus loves to eat plants!");
        }
    }
}
