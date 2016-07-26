using System;
// genus is urocitellus and species is brunneus
namespace zoolandia.Genus
{
    public class Urocitellus: Animal
    {
        public Urocitellus(string name): base(name)
        {
            this.Name = name;
        }
        public bool CanJumpFly{get; set;}
        public bool LivesInTrees{get; set;}
    }
}