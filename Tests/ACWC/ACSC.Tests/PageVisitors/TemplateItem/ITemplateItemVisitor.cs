using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.Extensions.TemplateItems;

namespace ACSC.Tests.PageVisitors.TemplateItem
{
    public interface ITemplateItemVisitor
    {
        void Full(Extensions.TemplateItems.TemplateItem page);
        TemplateItemEntity Get(Extensions.TemplateItems.TemplateItem page);
        void SetData(TemplateItemEntity templateItem);
    }
}