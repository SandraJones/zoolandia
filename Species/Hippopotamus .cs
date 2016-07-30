//genus Hippopotamus species Amphibius
using System;

namespace zoolandia.Genus
{
    public class Hippopotamus: Animal, IAmbulatory
    {
        public Hippopotamus(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
        public void run()
        {
            Console.WriteLine("Hippopotamus is now running!");
        }
        public void walk()
        {
            Console.WriteLine("Hippopotamus is now walking.");
        }
    }
}
