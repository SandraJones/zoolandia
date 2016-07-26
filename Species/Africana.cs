using System;

namespace zoolandia.Species
{
    public class Africana : Loxodonta
    {
        //have to have a basic constructor string name is Joe or Steve, and calls base constructor
        public Africana(string name): base(name)
        {
            //don't need to do this.name here becasue we are calling the base constructor or parent class we are inheriting from
            //need to 
        }
        //we have access to name and Eat is a virutal program
        //parameters below have to have a type, with int  below
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(5); //when you use base it calls the parent class as well
            return animalEat +  "Crunch crunch crunch";
        }
        //this one below doesn't pass in a number of foods
        public string Eat()
        {
            return "I really like leafy green stuff!";
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

        public override string Move()
        {
            return "walk on four legs";
        }
    }
}