using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCAvailabilityEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Product;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary };

        public MappedAvailability Product;
    }
}
