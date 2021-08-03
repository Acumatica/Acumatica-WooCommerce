using ACSC.Tests.PageVisitors.Location;
using System.Collections.Generic;
using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.CustomerLocations
{
    public class CustomerLocation : AR303020_CustomerLocationMaint
    {
        public c_location_frmheader Summary => Location_frmHeader;
        public c_locationcurrent_tab Details => LocationCurrent_tab;
        public c_address_address Address => Address_Address;
        public c_contact_contact Contact => Contact_Contact;

        internal void Full(List<ILocationVisitor> visitors)
        {
            foreach (var visitor in visitors)
            {
                visitor.Full(this);
            }
        }
    }
}