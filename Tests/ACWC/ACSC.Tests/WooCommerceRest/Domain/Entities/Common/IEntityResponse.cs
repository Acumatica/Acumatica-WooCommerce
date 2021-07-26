using System.Collections.Generic;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Common
{
    public interface IEntityResponse<T>
    {
        T Data { get; set; }
    }

    public interface IEntitiesResponse<T>
    {
        List<T> Data { get; set; }
       // T Data { get; set; }
    }
}
