//species for dolphin
// Cephalorhynchus is genus for this dolphin

using zoolandia.Genus;

namespace zoolandia.Species
{
    //dolphins
    public class Heavisidii: Cephalorhynchus
    {
        public Heavisidii(string name): base(name)
        {
            this.CanSwim = true;
            this.GillPossession = false;
            this.Vertebrate = true;
            this.IsSocial = true;
            this.BreathesAir = true;
        }
    }

}

