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
        public int Weight{get; set;}
        
        //this is a property or something desccribing it
        public int Height{get; set;}
        // public int PlaysWFriends(int, NoOfFriends);
        public virtual string Move()
        {
            return null;
        }
        public bool CanSwim{get; set;}
        //since this is uninitialized in land animals that can't swim, then it will default to false
        public bool Vertebrate{get; set;}

        public bool GillPossession{get; set;}
        
        public int Appendages(int numberOfAppendages)
        {
            return numberOfAppendages;
        }
    }
}