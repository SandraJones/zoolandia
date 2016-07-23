using System;

namespace zoolandia.Species
{
    //chimpanzee
    public class PanTroglodytes: Genus
    {
        public PanTroglodytes(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}

