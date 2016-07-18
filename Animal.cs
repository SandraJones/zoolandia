using System;

namespace zoolandia
{
    public class Animal
    {
        public Animal(string name) 
        {
            //this is a constuctor
            this.Name = name;
        }
        private string _name;     
        public string Name {get; set;}
        public virtual string Eat(int numberOfFoods)    
        {
            return "YUM!";  
        }
        public int Weight(int weightInPounds)
        {
            return weightInPounds;
        }
        public int Height(int heightInInches)
        {
            return heightInInches;
        }
        public string MyTypeOfFood(string Food)
        {
            return Food;
        }
        public string LandOrWater(string Habitat)
        {
            return "Do I live on land or under water?";
        }
        public string VertebrateInvertrebrate(string Vetebrate)
        {
            return "Do I have a vertbrae?"; 
        }
        public int Appendages(int numberOfAppendages)
        {
            return numberOfAppendages;
        }
    }
}