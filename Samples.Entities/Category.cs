using System.Collections.Generic;

namespace Samples.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}