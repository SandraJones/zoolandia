//genus for cheetah which is species of Jubatus
using System;

namespace zoolandia.Genus
{
    public class Acinonyx : Animal
    {
        public Acinonyx(string name): base(name)
        {
            this.Name = name;
        }
        public bool RunsFast{get; set;}
        public string HasCamoColoring{get; set;}
    }
}