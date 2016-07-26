using System;
using zoolandia.Genus;
//is in the genus Trichosurus
namespace zoolandia.Species
{
    //possum
    public class Caninus: Trichosurus
    {
        public Caninus(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}


