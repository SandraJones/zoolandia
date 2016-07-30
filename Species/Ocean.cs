using System;
using zoolandia;
using zoolandia.Species;

namespace zoolandia.Ocean
{
    public class Ocean: Habitat, IOceanHabitat
    {
        public Ocean (string name)
        {
        }
        public string feeding()
        {
            return "Eats other smaller and slower fish.";
        }
        public bool swimsFreelyInOcean()
        {
            return true;
        }
        public void OceanInhabitants(Heavisidii x, Otariidae y, Zygaena z)
        {
            this.inhabitants.Add(x);
            this.inhabitants.Add(y);
            this.inhabitants.Add(z);
        }
    }
}