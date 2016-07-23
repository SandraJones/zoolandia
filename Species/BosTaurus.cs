using System;

namespace zoolandia.Species
{
    //dairy cow
    public class BosTaurus : Animal
    {
        public BosTaurus(string name) : base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}