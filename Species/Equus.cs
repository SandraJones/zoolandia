//genus for Equus Asinus or Donkey
using System;

namespace zoolandia.Genus
{
    public class Equus : Animal, IAmbulatory
    {
        public Equus(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
        public void run()
        {
            Console.WriteLine("Animal is now running!");
        }
        public void walk()
        {
            Console.WriteLine("Animal is now walking.");
        }
    }
}