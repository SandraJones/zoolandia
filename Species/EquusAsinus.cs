using System;

namespace zoolandia.Species
{
    public class EquusAsinus : Animal
    {
        //have to have a basic constructor string name is Joe or Steve, and calls base constructor
        public EquusAsinus(string name): base(name)
        {
        }
        //we have access to name and Eat is a virutal program
        //parameters below have to have a type, with int  below
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3); //when you use base it calls the parent class as well
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