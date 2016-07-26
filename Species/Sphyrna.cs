//genus for hammerhead sharks 
//goes with species Zygaena

namespace zoolandia.Genus
{
    public class Sphyrna : Animal
    {
        public Sphyrna(string name): base(name)
        {
            this.Name = name;
        }
        public bool LowPredation{get; set;}
        public string FoodLocation{get; set;}
    }
}