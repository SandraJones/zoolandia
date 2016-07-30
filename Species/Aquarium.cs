using System;
using zoolandia;
using zoolandia.Species;

namespace zoolandia.Aquarium
{
    public class Aquarium: Habitat, IAquariumHabitat
    {
    
        public Aquarium (string name, float temperature)
        {
        }
        public string feeding()
        {
            return "Plankton flakes";
        }
        public float measureWaterTemperature()
        {
            return 86.5F;
        }
        //add feeding info here
        public void AquariumInhabitants(Auratus x)
        {
            this.inhabitants.Add(x);
        }
    }
}