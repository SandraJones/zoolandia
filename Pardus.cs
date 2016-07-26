//panthera pardus is the leopard
using zoolandia.Genus;

namespace zoolandia.Species
{
    public class Pardus: Panthera
    {
        public Pardus(string name): base(name)
        {
            this.Name = name;
            this.CanSwim = true;
            this.Vertebrate = true;
            this.LowPredation = false;
            this.FoodLocation = "ground";
        }
    }
}