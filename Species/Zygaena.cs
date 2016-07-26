using System;
using zoolandia.Genus;

namespace zoolandia.Species
{
    //hammerhead shark
    public class Zygaena: Sphyrna
    {
        public Zygaena(string name): base(name)
        {
            this.Name = name;
            this.CanSwim = true;
            this.GillPossession = true;
            this.Vertebrate = true;
        }
        public bool LowPredation = false;
     }
        
}

