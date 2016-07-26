using System;
//genus Hippopotamus species Amphibius
using zoolandia.Genus;

namespace zoolandia.Species
{
    //hippo
    public class Amphibius: Hippopotamus
    {
        public Amphibius(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = false;
            this.Vertebrate = true;
            this.LowPredation = false;
            this.FoodLocation = "ground";
        }
    }

}
