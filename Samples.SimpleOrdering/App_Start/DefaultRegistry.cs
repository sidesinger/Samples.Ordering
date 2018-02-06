using Samples.Data;
using StructureMap;
using StructureMap.Graph;

namespace Samples.SimpleOrdering
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            For<IBasketRepository>().Use<BasketRepository>();
            For<ILocationRepository>().Use<LocationRepository>();
            For<IOrderRepository>().Use<OrderRepository>();
            For<IPaymentRepository>().Use<PaymentRepository>();
        }
    }
}