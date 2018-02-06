namespace Samples.Data
{
    public interface IPaymentRepository
    {
        bool Validate(string paymentCardName, int paymentCardNumber, int paymentExpireMonth, int paymentExpireYear,
            string paymentBillingZip);
    }

}
