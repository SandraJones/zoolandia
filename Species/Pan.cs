using System;
//Pan is genus for species Troglodytes;  chimpanzees
namespace zoolandia.Genus
{
    public class Pan : Animal, IAmbulatory
    {
        public Pan(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;} 
        public void run()
        {
            Console.WriteLine("Pan Genus is running!");
        }
        public void walk()
        {
            Console.WriteLine("Pan Genus is walking.");
        }       
    }
}