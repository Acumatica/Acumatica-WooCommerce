using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.Extensions.TemplateItems;

namespace ACSC.Tests.PageVisitors.TemplateItem
{
    public interface ITemplateItemGIVisitor
    {
        TemplateItemGI Get(ACTemplateItemGI page);
    }
}