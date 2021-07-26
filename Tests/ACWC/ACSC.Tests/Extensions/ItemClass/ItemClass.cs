using GeneratedWrappers.Acumatica;


namespace ACSC.Tests.Extensions.ItemClass
{
    public class ItemClass : IN201000_INItemClassMaint
    {
        public c_itemclass_form Summary => Itemclass_form;
        public c_itemclasssettings_tab GeneralSettings => Itemclasssettings_tab;
        public c_mapping_attributesgrid Attributes => Mapping_AttributesGrid;
    }
}