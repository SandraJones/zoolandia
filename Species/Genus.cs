using System;

namespace zoolandia.Species
{
    public class Genus: Animal
    {
         public Genus(string name): base(name)
         {
             this.Name = name;
         }
         public int NoOfToes{get; set;}
         public bool ClimbsTrees{get; set;}
         public bool HasEars{get; set;}
    }
}