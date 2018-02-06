using System.Collections.Generic;
using Samples.SimpleOrdering.Models;

namespace Samples.SimpleOrdering.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}