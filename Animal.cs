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

        // public string Name {
        //     get
        //     {
        //             return _name;
        //        }          
        // // } {return "haha you can't get your name";}

        // //     set
        //         {
        //             _name = value;
        //         }
        //     }     
        //      //these are getters and setters
        private string _name;     
        public string Name {get; set;}
        public virtual string Eat(int numberOfFoods)    
        {
            return "YUM!";  //if we don't want to return anything then in front of public would be void
        }
    }
}