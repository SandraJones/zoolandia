using System;

namespace zoolandia.Species
{
    //dolphins
    public class Cephalorhynchus: Animal
    {
        public Cephalorhynchus(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }

}

