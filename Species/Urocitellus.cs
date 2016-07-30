using System;
// genus is urocitellus and species is squirrel
namespace zoolandia.Genus
{
    public class Urocitellus: Animal, IAmbulatory, IHerbivore
    {
        public Urocitellus(string name): base(name)
        {
            this.Name = name;
        }
        public bool CanJumpFly{get; set;}
        public bool LivesInTrees{get; set;}
        public void run()
        {
            Console.WriteLine("Urocitellus Genus is running!");
        }
        public void walk()
        {
            Console.WriteLine("Urocitellus Genus is walking.");
        }
        public void eatsPlants()
        {
            Console.WriteLine("Urocitellus Genus likes to eat plants!");
        }
    }
}