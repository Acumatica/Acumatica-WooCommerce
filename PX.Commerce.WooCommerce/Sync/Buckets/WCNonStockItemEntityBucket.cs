using PX.Commerce.Core;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCNonStockItemEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Product;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary };
        public override IMappedEntity[] PreProcessors { get => Categories.ToArray(); }

        public MappedNonStockItem Product;

        public List<MappedCategory> Categories = new List<MappedCategory>();
    }
}
