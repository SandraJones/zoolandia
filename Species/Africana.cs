using System;
using zoolandia.Genus;

namespace zoolandia.Species
{
    public class Africana : Loxodonta
    {
        //have to have a basic constructor string name is Joe or Steve, and calls base constructor
        public Africana(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
    }   
}