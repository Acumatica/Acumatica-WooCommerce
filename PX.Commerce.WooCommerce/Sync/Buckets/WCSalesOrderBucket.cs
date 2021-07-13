using PX.Commerce.BigCommerce;
using PX.Commerce.Core;
using PX.Common;
using System.Collections.Generic;
using System.Linq;
namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCSalesOrderBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary { get => Order; }
        public IMappedEntity[] Entities => new IMappedEntity[] { Order };

        public override IMappedEntity[] PreProcessors { get => new IMappedEntity[] { Customer }; }
        public override IMappedEntity[] PostProcessors { get => Enumerable.Empty<IMappedEntity>().Concat(Payments).Concat(Shipments).ToArray(); }

        public MappedOrder Order;
        public MappedCustomer Customer;
        public List<MappedPayment> Payments = new List<MappedPayment>();
        public List<MappedShipment> Shipments = new List<MappedShipment>();
    }
}

