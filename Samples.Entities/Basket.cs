using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Entities
{
    public class Basket
    {
        public int LocationId { get; set; }
        public DateTime TimeWanted { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public IEnumerable<BasketProduct> Products { get; set; }
        public string SpecialInstructions { get; set; }

        public BasketPayment Payment { get; set; }

        public int Status { get; set; }
    }
}
