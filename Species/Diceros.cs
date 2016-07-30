//genus for Diceros Bicornis, or black rhino
using System;

namespace zoolandia.Genus
{
    public class Diceros: Animal, IAmbulatory, IHerbivore
    {
        public Diceros(string name): base(name)
        {
            this.Name = name;
        }
        public bool HasAHorn{get; set;}
        public bool RoughHide{get; set;}
        public void run()
        {
            Console.WriteLine("Diceros is now running!");
        }
        public void walk()
        {
            Console.WriteLine("Diceros is now walking.");
        }
        public void eatsPlants()
        {
            Console.WriteLine("Diceros Genus loves to eat plants!");
        }
    }
}