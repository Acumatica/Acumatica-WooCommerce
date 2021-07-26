using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.CustomerClass
{
    public class CustomerClassAr : AR201000_CustomerClassMaint
    {
        public c_customerclassrecord_form Summary => CustomerClassRecord_form;
        public c_curcustomerclassrecord_tab GeneralSettings => CurCustomerClassRecord_tab;
        public c_mapping_grid Attributes => Mapping_grid;
    }
}
