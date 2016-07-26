//genus for Equus Asinus or Donkey

namespace zoolandia.Genus
{
    public class Equus : Animal
    {
        public Equus(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
    }
}