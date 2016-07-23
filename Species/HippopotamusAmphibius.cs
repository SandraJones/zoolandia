using System;

namespace zoolandia.Species
{
    //hippo
    public class HippopotamusAmphibius: Genus
    {
        public HippopotamusAmphibius(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }

}
