//Pan Troglodytes is a genus and species of chimpanzee
using zoolandia.Genus;

namespace zoolandia.Species
{
    
    //chimpanzee
    public class Troglodytes: Pan
    {
        //below is showing inheritance of behavior from Pan class
        public Troglodytes(string name): base(name)
        {
            
        }
        public bool LowPredation = true;
        public string FoodLocation = "in trees";
        
    } 
    
}