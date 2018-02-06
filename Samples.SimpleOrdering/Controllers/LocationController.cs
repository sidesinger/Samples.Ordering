using Samples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Samples.Data;

namespace Samples.SimpleOrdering.Controllers
{
    public class LocationController : BaseController
    {
        private readonly ILocationRepository _locationRepo;

        public LocationController()
        {
            _locationRepo = Construct<ILocationRepository>();
        }
        public IEnumerable<Models.LocationSummary> Get()
        {
            var locations = _locationRepo.GetAll();
            return Map<IEnumerable<Entities.LocationSummary>, IEnumerable<Models.LocationSummary>>(locations);
        }

        public Models.Location Get(int id)
        {
            var location = _locationRepo.Get(id);
            return Map<Entities.Location, Models.Location>(location);
        }

        [Route("location/find/")]
        [HttpGet]
        public IEnumerable<Models.LocationSummary> Find(string name, string zip)
        {
            var locations = _locationRepo.Find(name, zip);
            return Map<IEnumerable<Entities.LocationSummary>, IEnumerable<Models.LocationSummary>>(locations);
        }
    }
}
