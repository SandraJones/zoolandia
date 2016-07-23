using System;

namespace zoolandia.Species
{
    //jaguar
    public class PantheraOnca: Animal
    {
        public PantheraOnca(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}
