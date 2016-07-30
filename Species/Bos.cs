//genus Bos  is for dairy cow, species Taurus
using System;

namespace zoolandia.Genus
{
    public class Bos : Animal, IAmbulatory, IHerbivore
    {
        public Bos(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
        public void run()
        {
            Console.WriteLine("Bos Genus is now running!");
        }
        public void walk()
        {
            Console.WriteLine("Bos Genus is now walking.");
        }
        public void eatsPlants()
        {
            Console.WriteLine("Bos Genus eats plants for food.");
        }
    }
}