namespace Lecture8
{
    public class GeographicalTerritory // public fields are hinerited by child classes
    {
        public string Name { get; }  // if a field cannot be changed, i should initialized it (constructor)
        public long Population { get; set; }
        public double Happiness { get; set; }

        public GeographicalTerritory(string name)
        {
            this.Name = name;
        }
    }

    public class Country : GeographicalTerritory
    {
        // i have to give a constructor since base class has 1 parameter constructor
        public Country(string name) : base(name) 
        {

        }
    }

    public class Region : GeographicalTerritory
    {
        public Region() : base("A Region")
        {

        }
    }
}
