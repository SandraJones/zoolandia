using System;

namespace zoolandia.Species
{
    //black rhino
    public class DicerosBicornis: Genus
    {
        public DicerosBicornis(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}
