using System;

namespace zoolandia.Genus
{
    //dolphins
    public class Cephalorhynchus: Animal
    {
        public Cephalorhynchus(string name): base(name)
        {
            this.Name = name;
        }
        public bool IsSocial{get; set;}
        public bool BreathesAir{get; set;}
        
    }

}

