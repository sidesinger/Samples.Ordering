using System;

namespace Samples.Entities
{
    public class BasketProduct
    {
        public BasketProduct(int productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}