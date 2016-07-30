//genus for giraffa and species Camelopardalis
using System;

namespace zoolandia.Genus
{
    public class Giraffa: Animal
    {
        public Giraffa(string name): base(name)
        {
            this.Name = name;
        }
        public bool Herbivore{get; set;}
        public bool SpottedHide{get; set;}
    }
}