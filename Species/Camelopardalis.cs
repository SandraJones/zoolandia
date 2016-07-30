//genus giraffa and species Camelopardalis
using zoolandia.Genus;

namespace zoolandia.Species
{
    public class Camelopardalis: Giraffa
    {
        public Camelopardalis(string name): base(name)
        {
            this.Herbivore = true;
            this.GillPossession = false;
            this.Vertebrate = true;
        }
    }
}
