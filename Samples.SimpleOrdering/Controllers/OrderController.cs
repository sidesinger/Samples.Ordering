using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Samples.Data;
using Samples.Entities;

namespace Samples.SimpleOrdering.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderRepository _orderRepo;

        public OrderController()
        {
            _orderRepo = Construct<IOrderRepository>();
        }

        [Route("order/{orderId}")]
        public Models.Order Get(int orderId)
        {
            var order = _orderRepo.GetOrder(orderId);
            return Map<Entities.Order, Models.Order>(order);
        }
    }
}
