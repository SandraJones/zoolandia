//cheetah  Jubatus is the species for the genus Acinonyx
using zoolandia.Genus;

namespace zoolandia.Species
{
    public class Jubatus: Acinonyx
    {
        public Acinonyx(string name): base(name)
        {
            this.Name = name;
        }
    }
}