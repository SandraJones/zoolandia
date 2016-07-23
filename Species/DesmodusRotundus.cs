using System;

namespace zoolandia.Species
{
    //vampire bat
    public class DesmodusRotundis: Animal
    {
        public DesmodusRotundis(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}
