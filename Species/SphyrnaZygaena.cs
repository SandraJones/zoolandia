using System;

namespace zoolandia.Species
{
    //hammerhead shark
    public class SphyrnaZygaena: Animal
    {
        public SphyrnaZygaena(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = true;
            this.Vertebrate = true;
        }
    }
}

