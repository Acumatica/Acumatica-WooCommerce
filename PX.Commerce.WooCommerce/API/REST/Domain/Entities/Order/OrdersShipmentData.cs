using PX.Commerce.Core;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class OrdersShipmentData : BCAPIEntity, IWooEntity
    {
		public OrdersShipmentData Сlone(bool? DeepClone = false)
		{
			OrdersShipmentData copyObj = (OrdersShipmentData)this.MemberwiseClone();
			return copyObj;
		}
        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public DateTime? DateCreatedUT { get; set; }
        public DateTime? DateModified { get; set; }
        public List<ShipmentLineItemData> LineItems { get; set; }
        public List<string> TrackingNumbers { get; set; }
        public string TrackingCompany { get; set; }
        public string ShippingMethod { get;  set; }

    }


    public class ShipmentLineItemData
    {
        public int? Id { get; set; }
        public int? OrderId { get; set; }

        public Guid PackageId { get; set; }
        public decimal? Quantity { get; set; }

    }
}