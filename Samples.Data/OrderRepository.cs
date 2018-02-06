using Samples.Entities;

namespace Samples.Data
{
    public interface IOrderRepository
    {
        OrderSumbitResult Sumbit(Basket basket);
        Order GetOrder(int orderId);
    }

    public class OrderSumbitResult
    {
        public bool Success { get; set; }
        public int OrderId { get; set; }
    }
}