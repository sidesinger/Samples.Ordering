using System.Collections.Generic;
using Samples.Entities;

namespace Samples.Data
{
    public interface ILocationRepository
    {
        IEnumerable<LocationSummary> GetAll();
        Location Get(int id);
        IEnumerable<LocationSummary> Find(string name, string zip);
    }
}