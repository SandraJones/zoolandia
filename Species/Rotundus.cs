using System;
using zoolandia.Genus;
//genus Desmodus and species Rotundis 
namespace zoolandia.Species
{
    //vampire bat
    public class Rotundis: Desmodus
    {
        public Rotundis(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
            this.FeedsInDaytime = false;
            // this.NoOfWings = 2;
        }
    }
}
