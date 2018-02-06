using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samples.Entities;

namespace Samples.Data
{
    public class LocationRepository : ILocationRepository
    {
        public LocationRepository()
        {
            
        }

        public IEnumerable<LocationSummary> GetAll()
        {
            return Make(100);
        }

        public Location Get(int id)
        {
            return new Location
            {
                Id = 1,
                Menu = GetMenu(),
                Name = "Burger Shack - Main St.",
                Zip = "10004"
            };
        }

        public IEnumerable<LocationSummary> Find(string name, string zip)
        {
            return Make(5);
        }

        private IEnumerable<LocationSummary> Make(int count)
        {
            var locations = new List<LocationSummary>(count);
            for (int i = 0; i < count; i++)
                locations.Add(new LocationSummary { Id = i, Name = $"Burger Shack #{i}" });
            return locations;
        }

        private IEnumerable<Category> GetMenu()
        {
            return new[]
            {
                new Category
                {
                    Id = 1,
                    Sort = 1,
                    Name = "Burgers",
                    Products = new[]
                    {
                        new Product {Id = 1, Name = "Cheeseburger", Sort = 1, Cost = 5.25m},
                        new Product {Id = 2, Name = "Baconburger", Sort = 2, Cost = 7.25m}
                    }

                },
                new Category()
                {
                    Id = 2,
                    Sort = 2,
                    Name = "Shakes",
                    Products = new[]
                    {
                        new Product {Id = 3, Name = "Vanilla", Sort = 1, Cost = 5.00m},
                        new Product {Id = 4, Name = "Salty Caramel", Sort = 1, Cost = 5.00m}
                    }
                },
            };
        }
    }

    public class BasketRepository : IBasketRepository
    {
        public BasketRepository()
        {
                
        }

        public int Create(DateTime? basketTimeWanted, int basketLocationId, string basketCustomerName, string basketCustomerEmail)
        {
            return 1;
        }

        public void AddProduct(int basketId, int productProductId, int productQuantity)
        {

        }

        public void AddPayment(int basketId, string cardName, int cardNumber, int expireMonth, int expireYear, string billingZip)
        {

        }

        public Basket Get(int basketId)
        {
            return new Basket
            {
                LocationId = 1,
                CustomerEmail = "a@e.com",
                CustomerName = "Albert E",
                Products = new[] {new BasketProduct(1, 1), new BasketProduct(2, 2),},
                SpecialInstructions = "Include napkins.",
                Status = 5,
                TimeWanted = DateTime.Now.AddHours(1),
                Payment = new BasketPayment
                {
                    BillingZip = "10004",
                    CardName = "Albert E",
                    CardNumber = "xxx1234",
                    ExpireMonth = 8,
                    ExpireYear = 2020
                }
            };
        }
    }

    public class OrderRepository : IOrderRepository
    {
        public OrderRepository()
        {
            
        }

        public OrderSumbitResult Sumbit(Basket basket)
        {
            return new OrderSumbitResult {OrderId = 1, Success = true};
        }

        public Order GetOrder(int orderId)
        {
            return new Order
            {
                LocationId = 1,
                CustomerEmail = "a@e.com",
                CustomerName = "Albert E",
                Products = new[] {new BasketProduct(1, 1), new BasketProduct(2, 2),},
                SpecialInstructions = "Include napkins.",
                Status = 5,
                TimeWanted = DateTime.Now.AddHours(1),
                IsClosed = true,
                SubmitDateTime = DateTime.Now.AddMinutes(-5)
            };
        }
    }

    public class PaymentRepository : IPaymentRepository
    {
        public PaymentRepository()
        {
            
        }

        public bool Validate(string paymentCardName, int paymentCardNumber, int paymentExpireMonth, int paymentExpireYear,
            string paymentBillingZip)
        {
            return true;
        }
    }
}
