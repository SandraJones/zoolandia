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
        public string Weight(int weightInPounds)
        {
            return "Weigh Me!";
        }
        public string Height(int heightInInches)
        {
            return "Measure My Height!";
        }
        public string MyTypeOfFood(string Food)
        {
            return "What do I eat?";
        }
        public string LandOrWater(string Habitat)
        {
            return "Do I live on land or under water?";
        }
        public string VertebrateInvertrebrate(string Vetebrate)
        {
            return "Do I have a vertbrae?"; 
        }
        public string Appendages(int numberOfAppendages)
        {
            return "How many appendages do I have?";
        }
    }
}