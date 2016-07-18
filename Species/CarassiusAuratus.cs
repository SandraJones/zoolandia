using System;

namespace zoolandia.Species
{
    //this is a goldfish; can the public class be two separate words?
    public class CarassiusAuratus: Animal
    {
        public CarassiusAuratus(string name): base(name)
        {
        }
        //was trying to use a boolean, but couldn't quite figure it out
        public string Swim(string Yes)      
        {
            return "Yes, I can swim.";
        }
        public string GillPossession(string Yes)
        {
            return "I need gills to 'breathe'.";
        }
        public string Tail(string Yes)
        {
            return "My tail helps me to swim.";
        }
    }

}