using System;
using zoolandia.Genus;
//genus Panthera
namespace zoolandia.Species
{
    //jaguar
    public class Onca: Panthera
    {
        public Onca(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}