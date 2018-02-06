using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Samples.Data;
using Samples.SimpleOrdering.Models;
using StructureMap;

namespace Samples.SimpleOrdering.Controllers
{
    public class BasketController : BaseController
    {
        private readonly IBasketRepository _basketRepo;
        private readonly IPaymentRepository _paymentRepo;
        private readonly IOrderRepository _orderRepo;

        public BasketController()
        {
            _basketRepo = Construct<IBasketRepository>();
            _paymentRepo = Construct<IPaymentRepository>();
            _orderRepo = Construct<IOrderRepository>();
        }

        [Route("basket/")]
        [HttpPost]
        public int Post([FromBody] NewBasket basket)
        {
            var basketId = _basketRepo.Create(basket.TimeWanted, basket.LocationId, basket.CustomerName, basket.CustomerEmail);
            return basketId;
        }

        [Route("basket/{basketId}")]
        [HttpGet]
        public Basket Get(int basketId)
        {
            var basket = _basketRepo.Get(basketId);
            return Map<Entities.Basket, Models.Basket>(basket);
        }

        [Route("basket/{basketId}/product")]
        [HttpPost]
        public void PostProduct(int basketId, [FromBody] BasketProduct product)
        {
            if (product.Quantity > 100)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _basketRepo.AddProduct(basketId, product.ProductId, product.Quantity);
        }

        [Route("basket/{basketId}/payment")]
        [HttpPost]
        public void PostPayment(int basketId, [FromBody] BasketPayment payment)
        {
            if (!_paymentRepo.Validate(payment.CardName, payment.CardNumber, payment.ExpireMonth, payment.ExpireYear, payment.BillingZip))
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _basketRepo.AddPayment(basketId, payment.CardName, payment.CardNumber, payment.ExpireMonth, payment.ExpireYear, payment.BillingZip);
        }

        [Route("basket/{basketId}/submit")]
        [HttpPost]
        public int PostSubmit(int basketId)
        {
            var basket = _basketRepo.Get(basketId);

            if (basket.Payment == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var submitResult = _orderRepo.Sumbit(basket);
            if (!submitResult.Success)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            return submitResult.OrderId;
        }
    }
}
