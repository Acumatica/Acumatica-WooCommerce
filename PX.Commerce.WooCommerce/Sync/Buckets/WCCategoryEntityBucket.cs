using PX.Commerce.BigCommerce;
using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCCategoryEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Category;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary };
        public override IMappedEntity[] PreProcessors { get => new IMappedEntity[] { LocalParent, ExternParent }; }

        public MappedCategory Category;
        public MappedCategory LocalParent;
        public MappedCategory ExternParent;
    }
}
