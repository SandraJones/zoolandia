//genus of Desmodus for the Desmodus Rotundus or vampire bat
using System;

namespace zoolandia.Genus
{
    public class Desmodus: Animal
    {
        public Desmodus(string name): base(name)
        {
            this.Name = name;   
        }
        public bool FeedsInDaytime = false;
        public int NoOfWings{get; set;}
        
    }
}