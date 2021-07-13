using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCCustomerEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Customer;
        public IMappedEntity[] Entities => new IMappedEntity[] { Customer };

        public MappedCustomer Customer;
    }
}
