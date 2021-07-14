using ACSC.Tests.PageVisitors.ItemWarehouseDetails;
using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.ItemWarehouseDetails
{
    public class ItemWarehouseDetails : IN204500_INItemSiteMaint
    {
        public c_itemsiterecord_form Summary => Itemsiterecord_form;

        internal void Full(IItemWarehouseDetailsVisitor visitor)
        {
            visitor.Full(this);
        }
    }
}
