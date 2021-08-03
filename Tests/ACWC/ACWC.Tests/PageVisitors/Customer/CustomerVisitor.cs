using System;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Extensions.Customer;

namespace ACSC.Tests.PageVisitors.Customer
{
    public class CustomerVisitor : ICustomerVisitor
    {
        private CustomerEntity _customer;

        public CustomerVisitor(CustomerEntity customer)
        {
            _customer = customer;
        }

        public CustomerVisitor()
        {
            _customer = new CustomerEntity();
        }

        public void SetData(CustomerEntity customer)
        {
            _customer = customer;
        }

        public CustomerEntity Get(CustomerAr page)
        {
            GetGeneralInfo(page);
            GetContactInfo(page);
            GetDeliverySetting(page);
            GetAddressInfo(page);
            GetFinancicalInfo(page);
            GetLocations(page);
            GetAttributes(page);
            
            return _customer;
        }

        private void GetGeneralInfo(CustomerAr page)
        {
            _customer.AcctCD = page.Summary.AcctCD.GetValue();
            _customer.AcctName = page.GeneralSettings.AcctName.GetValue();
            _customer.Status = page.Summary.Status.GetValue();
            //_customer.MainContact.ConsentDate = page.GeneralInfo_DataPrivacy.ConsentDate.GetValue();
        }

        private void GetContactInfo(CustomerAr page)
        {
            //_customer.MainContact.FullName = page.Contact.FullName.GetValue();
            //_customer.MainContact.Attention = page.Contact.Attention.GetValue();
            _customer.MainContact.EMail = page.Contact.EMail.GetValue();
            _customer.MainContact.Web = page.Contact.WebSite.GetValue();
            _customer.MainContact.Phone1 = page.Contact.Phone1.GetValue();
            _customer.MainContact.Phone2 = page.Contact.Phone2.GetValue();
        }

        private void GetDeliverySetting(CustomerAr page)
        {
            _customer.DefaultLocationSettings.PriceClassID = page.DeliverySettings.CPriceClassID.GetValue();
        }

        private void GetAddressInfo(CustomerAr page)
        {
            _customer.MainAddress.AddressLine1 = page.Address.AddressLine1.GetValue();
            _customer.MainAddress.City = page.Address.City.GetValue();
            _customer.MainAddress.CountryID = page.Address.CountryID.GetValue();
            _customer.MainAddress.StateID = page.Address.State.GetValue();
            _customer.MainAddress.PostalCode = page.Address.PostalCode.GetValue();
        }

        private void GetAttributes(CustomerAr page)
        {
            var count = page.AttributesGrid.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.AttributesGrid.SelectRow(i);
                var row = page.AttributesRow;
                if (row != null)
                {
                    _customer.Attributes.Add(new CustomerEntityAttributes()
                    {
                        Attribute = row.Attribute.GetValue(),
                        Value = row.Value.GetValue()
                    });
                }
            }
        }

        private void GetFinancicalInfo(CustomerAr page)
        {
            _customer.CustomerClassID = page.Summary.CustomerClassID.GetValue();
            _customer.CuryID = page.GeneralSettings.CuryID.GetValue();
        }

        private void GetLocations(CustomerAr page)
        {
            var count = page.Locations.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.Locations.SelectRow(i);
                var row = page.Locations.Row;
                if (row != null)
                {
                    _customer.Locations.Add(new CustomerEntityLocations()
                    {
                        Active = row.IsActive.GetValue(),
                        IsDefault = row.IsDefault.GetValue(),
                        LocationID = row.LocationCD.GetValue(),
                        LocationName = row.Descr.GetValue(),
                        City = row.Address__City.GetValue(),
                        Country = row.Address__CountryID.GetValue(),
                        State = row.Address__State.GetValue(),
                        TaxZone = row.CTaxZoneID.GetValue(),
                        PriceClassID = row.CPriceClassID.GetValue(),
                        SalesAccount = row.CSalesAcctID.GetValue(),
                        SalesSub = row.CSalesSubID.GetValue(),
                        ARAccount = row.CARAccountID.GetValue(),
                        ARSub = row.CARSubID.GetValue(),
                    });
                }
            }
        }

        public void Full(CustomerAr page)
        {
            FullGeneralInfo(page);
            FullContactInfo(page);
            FullAddressInfo(page);
            FullFinancicalInfo(page);
            FullLocationSettings(page);
        }

        private void FullGeneralInfo(CustomerAr page)
        {
            page.Summary.AcctCD.Type(_customer.AcctCD);
            page.GeneralSettings.AcctName.Type(_customer.AcctName);
            //page.Summary.Status.Select(_customer.Status);
        }

        private void FullContactInfo(CustomerAr page)
        {
            //page.Contact.FullName.Type(_customer.MainContact.FullName);
            //page.Contact.Attention.Type(_customer.MainContact.Attention);
            page.Contact.EMail.Type(_customer.MainContact.EMail);
            page.Contact.Phone1.Type(_customer.MainContact.Phone1);
            page.Contact.Phone2.Type(_customer.MainContact.Phone2);
        }

        private void FullAddressInfo(CustomerAr page)
        {
            page.Address.AddressLine1.Type(_customer.MainAddress.AddressLine1);
            page.Address.City.Type(_customer.MainAddress.City);
            page.Address.CountryID.Select(_customer.MainAddress.CountryID);
            page.Address.State.Select(_customer.MainAddress.StateID);
            page.Address.PostalCode.Type(_customer.MainAddress.PostalCode);
        }

        private void FullFinancicalInfo(CustomerAr page)
        {
            string messageText = null;
            page.Summary.CustomerClassID.Select(_customer.CustomerClassID);
            try
            {
                messageText = page.MessageBox.Message.GetValue();
            }
            catch (Exception)
            {
                // ignored
            }

            if (!string.IsNullOrEmpty(messageText))
            {
                page.MessageBox.Yes();
                //messageText = null;
            }
            page.GeneralSettings.CuryID.Select(_customer.CuryID);
            if (_customer.IsBillSameAsMain)
            {
                page.GeneralSettings.OverrideBillAddress.Set(_customer.IsBillSameAsMain);
                page.GeneralSettings.OverrideBillContact.Set(_customer.IsBillContSameAsMain);
            }
        }

        private void FullLocationSettings(CustomerAr page)
        {
            page.DeliverySettings.CTaxZoneID.Select(_customer.DefaultLocationSettings.CTaxZoneID);
            page.DeliverySettings.CPriceClassID.Type(_customer.DefaultLocationSettings.PriceClassID);
            page.DeliverySettings.CCarrierID.Select(_customer.DefaultLocationSettings.CCarrierID);
            page.DeliverySettings.CShipTermsID.Select(_customer.DefaultLocationSettings.CShipTermsID);
            if (_customer.DefaultLocationSettings.IsContactSameAsMain)
            {
                page.DeliverySettings.OverrideContact.Set(_customer.DefaultLocationSettings.IsContactSameAsMain);
                page.DeliverySettings.OverrideAddress.Set(_customer.DefaultLocationSettings.IsAddressSameAsMain);
            }
        }
    }
}