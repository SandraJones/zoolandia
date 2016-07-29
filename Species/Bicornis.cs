using System;
using zoolandia.Genus;
//Diceros Bicornis
namespace zoolandia.Species
{
    //black rhino
    public class Bicornis: Diceros
    {
        public Bicornis(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
         public bool HasAHorn = true;
         public bool RoughHide = true;
         public string color(string color)
         {
             return "black";
         }
    }
}
