//genus for Diceros Bicornis, or black rhino


namespace zoolandia.Genus
{
    public class Diceros: Animal
    {
        public Diceros(string name): base(name)
        {
            this.Name = name;
        }
        public bool HasAHorn{get; set;}
        public bool RoughHide{get; set;}
    }
}