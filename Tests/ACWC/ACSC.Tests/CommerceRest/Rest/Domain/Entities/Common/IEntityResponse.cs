using System.Collections.Generic;

namespace BCApiClient.Rest.Domain.Entities.Common
{
    public interface IEntityResponse<T>
    {
        T Data { get; set; }
        Meta Meta { get; set; }
    }

    public interface IEntitiesResponse<T>
    {
        List<T> Data { get; set; }
        Meta Meta { get; set; }
    }
}
