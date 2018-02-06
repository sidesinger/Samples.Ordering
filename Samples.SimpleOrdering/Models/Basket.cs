using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samples.SimpleOrdering.Models
{
    public class Basket : NewBasket
    {
        public IEnumerable<BasketProduct> Products { get; set; }

    }
}