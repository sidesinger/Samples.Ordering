using System;
using Samples.Entities;

namespace Samples.Data
{
    public interface IBasketRepository
    {
        int Create(DateTime? basketTimeWanted, int basketLocationId, string basketCustomerName, string basketCustomerEmail);
        void AddProduct(int basketId, int productProductId, int productQuantity);
        void AddPayment(int basketId, string cardName, int cardNumber, int expireMonth, int expireYear, string billingZip);
        Basket Get(int basketId);
    }
}