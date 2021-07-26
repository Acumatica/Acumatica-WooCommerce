using System;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities
{
    public interface IWooEntity
    {
        DateTime? DateCreatedUT { get; set; }

        DateTime? DateModified { get; set; }

    }
}
