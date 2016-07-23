using System;

namespace zoolandia.Species
{
    //hammerhead shark
    public class SphyrnaZygaena: Genus
    {
        public SphyrnaZygaena(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = true;
            this.Vertebrate = true;
        }
    }
}

