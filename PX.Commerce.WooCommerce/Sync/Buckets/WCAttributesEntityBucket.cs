using PX.Commerce.BigCommerce;
using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.Sync.Buckets
{
    public class WCAttributesEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Attributes;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary };
        public override IMappedEntity[] PreProcessors { get => new IMappedEntity[] { LocalParent, ExternParent }; }

        public MappedAttributes Attributes;
        public MappedAttributes LocalParent;
        public MappedAttributes ExternParent;
    }
}
