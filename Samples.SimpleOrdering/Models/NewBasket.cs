using System;

namespace Samples.SimpleOrdering.Models
{
    public class NewBasket
    {
        public int LocationId { get; set; }
        public DateTime? TimeWanted { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
    }
}