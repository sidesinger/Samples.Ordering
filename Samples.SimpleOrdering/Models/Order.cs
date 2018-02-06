using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.SimpleOrdering.Models
{
    public class Order : Basket
    {
        public DateTime SubmitDateTime { get; set; }
        public bool IsClosed { get; set; }
    }
}
