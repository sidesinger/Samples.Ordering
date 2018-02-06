using System.Collections.Generic;

namespace Samples.SimpleOrdering.Models
{
    public class Location
    {
        public IEnumerable<Category> Menu { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string Zip { get; set; }
    }
}