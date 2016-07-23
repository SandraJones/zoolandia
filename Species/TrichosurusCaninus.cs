using System;

namespace zoolandia.Species
{
    //possum
    public class TrichosurusCaninus: Animal
    {
        public TrichosurusCaninus(string name): base(name)
        {
            this.CanSwim = false;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}


