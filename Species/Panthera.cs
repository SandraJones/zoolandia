//genus Panthera  is for jaguar Panthera Onca
using System;

namespace zoolandia.Genus
{
    public class Panthera : Animal, IAmbulatory
    {
        public Panthera(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
        public void run()
        {
            Console.WriteLine("Panthera Genus is running!");
        }
        public void walk()
        {
            Console.WriteLine("Panthera Genus is walking.");
        }
    }
}