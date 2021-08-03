using ACSC.Tests.Entity.Location;
using ACSC.Tests.Extensions.CustomerLocations;

namespace ACSC.Tests.PageVisitors.Location
{
    public class LocatonVisitor : ILocationVisitor
    {
        private readonly LocationEntity _location;

        public LocatonVisitor(LocationEntity location)
        {
            _location = location;
        }

        public void Full(CustomerLocation page)
        {
            if (_location.LocationCD != null)
            {
                page.Summary.LocationCD.Type(_location.LocationCD);
            }

            if (_location.Descr != null)
            {
                page.Details.Descr.Type(_location.Descr);
            }
           
            if (_location.LocationContact.SameAsMain)
            {
                page.Details.OverrideContact.Set(_location.LocationContact.SameAsMain);
            }

            if (!string.IsNullOrEmpty(_location.LocationContact.FullName))
            {
                page.Contact.FullName.Type(_location.LocationContact.FullName);
            }
            if (!string.IsNullOrEmpty(_location.LocationContact.Attention))
            {
                page.Contact.Attention.Type(_location.LocationContact.Attention);
            }
            if (!string.IsNullOrEmpty(_location.LocationContact.EMail))
            {
                page.Contact.EMail.Type(_location.LocationContact.EMail);
            }

            if (_location.LocationAddress.SameAsMain)
            {
                page.Details.OverrideAddress.Set(_location.LocationAddress.SameAsMain);
            }
            if (!string.IsNullOrEmpty(_location.LocationAddress.AddressLine1))
            {
                page.Address.AddressLine1.Type(_location.LocationAddress.AddressLine1);
            }
            if (!string.IsNullOrEmpty(_location.LocationAddress.AddressLine2))
            {
                page.Address.AddressLine2.Type(_location.LocationAddress.AddressLine2);
            } 
            if (!string.IsNullOrEmpty(_location.LocationAddress.City))
            {
                page.Address.City.Type(_location.LocationAddress.City);
            }
            if (!string.IsNullOrEmpty(_location.LocationAddress.CountryID))
            {
                page.Address.CountryID.Type(_location.LocationAddress.CountryID);
            }
            if (!string.IsNullOrEmpty(_location.LocationAddress.StateID))
            {
                page.Address.State.Type(_location.LocationAddress.StateID);
            }
            if (!string.IsNullOrEmpty(_location.LocationAddress.PostalCode))
            {
                page.Address.PostalCode.Type(_location.LocationAddress.PostalCode);
            }
            if (!string.IsNullOrEmpty(_location.LocationSettings.CTaxZoneID))
            {
                page.Details.CTaxZoneID.Select(_location.LocationSettings.CTaxZoneID);
            }
            if (!string.IsNullOrEmpty(_location.LocationSettings.CCarrierID))
            {
                page.Details.CCarrierID.Select(_location.LocationSettings.CCarrierID);
            }
            if (!string.IsNullOrEmpty(_location.LocationSettings.CShipTermsID))
            {
                page.Details.CShipTermsID.Select(_location.LocationSettings.CShipTermsID);
            }
            
        }

        public LocationEntity Get(CustomerLocation page)
        {
            throw new System.NotImplementedException();
        }
    }
}