using PX.Commerce.BigCommerce;
using PX.Commerce.Core;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCProductWithVariantEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Product;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary };
        public override IMappedEntity[] PreProcessors { get => Categories.ToArray(); }

        public MappedTemplateItem Product;

        public List<MappedCategory> Categories = new List<MappedCategory>();
    }
}
