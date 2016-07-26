using System;
//Pan is genus for species Troglodytes;  chimpanzees
namespace zoolandia.Genus
{
    public class Pan : Animal
    {
        public Pan(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;} 
    }
}