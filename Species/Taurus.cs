using System;
using zoolandia.Genus;
//genus bos of species taurus 
namespace zoolandia.Species
{
    //dairy cow
    public class Taurus : Bos
    {
        public Taurus(string name) : base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
            this.LowPredation = true;
            this.FoodLocation = "ground";
        }
        // public bool CanGiveMilk(bool)
        // {
        //     return true;
        // }
    }
}