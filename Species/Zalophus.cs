using System;
//genus of sea lion otariidae species
namespace zoolandia.Genus
{
    public class Zalophus: Animal
    {
        public Zalophus(string name): base(name)
        {
            this.Name = name;
        }
        public bool HighPredation = true;
        public bool HatesToLieInSun = false; 
    }
}