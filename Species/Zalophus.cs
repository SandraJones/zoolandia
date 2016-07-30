using System;
//genus of sea lion otariidae species
namespace zoolandia.Genus
{
    public class Zalophus: Animal, IAmbulatory
    {
        public Zalophus(string name): base(name)
        {
            this.Name = name;
        }
        public bool HighPredation = true;
        public bool HatesToLieInSun = false; 
        public void run()
        {
            Console.WriteLine("Zalophus Genus is running!");
        }
        public void walk()
        {
            Console.WriteLine("Zalophus Genus is walking.");
        }
    }
}