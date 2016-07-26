using System;
using zoolandia.Genus;
//of the Genus Carassius
namespace zoolandia.Species
{
    //this is a goldfish; can the public class be two separate words?no
    public class Auratus: Carassius
    {
        public Auratus(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = true;
            this.Vertebrate = true;
            this.LowPredation = true;
            this.FoodLocation = "floats on top of water";
        }
        public override string Move()
        {
            return "Swim";
        }
        public string Welcome(string name)
        {
            this.Name = name;
            return Welcome();
        }
        public string Welcome()
        {
            return this.Name;
        }

    }
}