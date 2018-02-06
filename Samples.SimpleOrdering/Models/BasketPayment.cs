namespace Samples.SimpleOrdering.Models
{
    public class BasketPayment
    {
        public string CardName { get; set; }
        public int CardNumber { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public string BillingZip { get; set; }
    }
}