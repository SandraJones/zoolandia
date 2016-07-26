using System;
using zoolandia.Genus;
//genus is urocitellus and species is brunneus
namespace zoolandia.Species
{
    //squirrel
    public class Brunneus: Urocitellus
    {
        public Brunneus(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
            this.CanJumpFly = true;
            this.LivesInTrees = true;
        }
    }
}