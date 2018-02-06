using System.Collections.Generic;

namespace Samples.Entities
{
    public class Location : LocationSummary
    {
        public IEnumerable<Category> Menu { get; set; }
    }
}