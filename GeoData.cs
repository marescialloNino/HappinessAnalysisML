namespace Lecture8
{
    public class GeographicalTerritory
    {
        public string Name { get; }
        public long Population { get; set; }
        public double Happiness { get; set; }

        public GeographicalTerritory(string name)
        {
            this.Name = name;
        }
    }

    public class Country : GeographicalTerritory
    {
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
