using ACSC.Tests.Entity.Customer;
using ACSC.Tests.PageVisitors;
using Controls.Editors.Selector;
using Controls.Input.PXTextEdit;
using System.Collections.Generic;
using ACSC.Tests.PageVisitors.Customer;
using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.Customer
{
    public class CustomerAr : AR303000_CustomerMaint
    {
        public c_baccount_baccount Summary => BAccount_BAccount;
        public c_defcontact_defcontact1 Contact => DefContact_DefContact1;
       
        //public c_defcontact_edcontactgdpr GeneralInfo_DataPrivacy => DefContact_edContactGDPR;
        public c_defaddress_defaddress Address => DefAddress_DefAddress;
        public c_currentcustomer_tab GeneralSettings => CurrentCustomer_tab;
        public c_changeiddialog_formchangeid SpecifyNewIDForm => ChangeIDDialog_formChangeID;
        public c_deflocation_deflocation DeliverySettings => DefLocation_DefLocation;
        public c_locations_grdlocations Locations => Locations_grdLocations;
        public c_answers_pxgridanswers AttributesGrid => Answers_PXGridAnswers;
        public AttributesGridRow AttributesRow => new AttributesGridRow(this);

        internal void Full(List<ICustomerVisitor> visitors)
        {
            foreach (var visitor in visitors)
            {
                Full(visitor);
            }
        }

        internal void Full(ICustomerVisitor visitor)
        {
            visitor.Full(this);
        }

        public CustomerEntity Get()
        {
            var visitor = VisitorsManager.GetSingle<ICustomerVisitor>(typeof(CustomerVisitor));
            return visitor.Get(this);
        }

        public class AttributesGridRow
        {
            private readonly CustomerAr _parent;
            private readonly c_answers_pxgridanswers.c_grid_row _row;

            public AttributesGridRow(CustomerAr parent)
            {
                _parent = parent;
                _row = _parent.AttributesGrid.Row;
            }

            public Selector Attribute => _row.AttributeID;
            public PXTextEdit Value => _row.Value;

        }
    }
}