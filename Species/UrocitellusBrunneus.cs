using System;

namespace zoolandia.Species
{
    //squirrel
    public class UroceitellusBrunneus: Animal
    {
        public UroceitellusBrunneus(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}

