//genus for cheetah which is species of Jubatus
using System;

namespace zoolandia.Genus
{
    public class Acinonyx : Animal, IAmbulatory
    {
        public Acinonyx(string name): base(name)
        {
            this.Name = name;
        }
        public bool RunsFast{get; set;}
        public string HasCamoColoring{get; set;}
        public void run()
        {
            Console.WriteLine("Animal is running!");
        }
        public void walk()
        {
            Console.WriteLine("Animal is now walking.");
        }
    }
}