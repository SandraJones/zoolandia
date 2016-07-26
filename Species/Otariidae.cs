using System;
using zoolandia.Genus;

namespace zoolandia.Species
{
    //this is a sea lion
    public class Otariidae : Zalophus
    {
        public Otariidae(string name): base(name)
        {   
            this.Vertebrate = true;
            this.HighPredation = true;
            this.HatesToLieInSun = false;
            this.CanSwim = true;
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(2); //when you use base it calls the parent class as well
            return animalEat +  "Nom nom nom";
        }
        //this one below doesn't pass in a number of foods
        public string Eat()
        {
            return "I don't know what I ate.";
        }
        public override string Move()
        {
            return "Flop or Swim";
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