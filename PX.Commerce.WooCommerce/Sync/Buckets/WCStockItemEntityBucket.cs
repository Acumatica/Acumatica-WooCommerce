using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCStockItemEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Product;
        public IMappedEntity[] Entities => new IMappedEntity[] { Product };

        public MappedStockItem Product;
    }
}
