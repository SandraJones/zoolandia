using System;

namespace zoolandia.Species
{
    //this is a sea lion
    public class Otariinae : Animal
    {
               public Otariinae(string name): base(name)
        {   
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