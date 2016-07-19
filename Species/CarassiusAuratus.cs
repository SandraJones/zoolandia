using System;

namespace zoolandia.Species
{
    //this is a goldfish; can the public class be two separate words?no
    public class CarassiusAuratus: Animal
    {
        public CarassiusAuratus(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = true;
            this.Vertebrate = true;
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