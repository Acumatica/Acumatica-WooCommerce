using ACSC.Tests.Entity.Location;
using ACSC.Tests.Extensions.CustomerLocations;

namespace ACSC.Tests.PageVisitors.Location
{
    public interface ILocationVisitor
    {
        void Full(CustomerLocation page);

        LocationEntity Get(CustomerLocation page);
    }
}