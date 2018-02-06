using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AutoMapper;
using Samples.Data;
using StructureMap;

namespace Samples.SimpleOrdering.Controllers
{
    public abstract class BaseController : ApiController
    {
        private readonly IMapper _objectMapper;

        protected BaseController()
        {
            _objectMapper = Mapper.Instance;
        }

        protected BaseController(IMapper mapper)
        {
            _objectMapper = mapper;
        }

        protected U Map<T,U>(T t)
        {
            return _objectMapper.Map<U>(t);
        }

        protected T Construct<T>()
        {
            var container = new Container();
            container.Configure(x =>
            {
                x.For<IBasketRepository>().Use<BasketRepository>().Singleton();
                x.For<ILocationRepository>().Use<LocationRepository>().Singleton();
                x.For<IOrderRepository>().Use<OrderRepository>().Singleton();
                x.For<IPaymentRepository>().Use<PaymentRepository>().Singleton();

            });
            return container.GetInstance<T>();
        }
    }
}