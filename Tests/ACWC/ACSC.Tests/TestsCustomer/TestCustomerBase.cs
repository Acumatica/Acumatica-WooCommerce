using ACSC.Tests.BigCommerceRest;
using ACSC.Tests.Cleanup;
using ACSC.Tests.Entity.Attribute;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Entity.Location;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.Extensions.Customer;
using ACSC.Tests.Extensions.CustomerClass;
using ACSC.Tests.Extensions.CustomerLocations;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Order;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.TestsBase;
using Core.Config;
using Core.Core.Browser;
using Core.Log;
using Core.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.Extensions.CustomerPriceClasses;
using Controls.Grid;

namespace ACSC.Tests.TestsCustomer
{
    public abstract class TestCustomerBase : TestBase
    {
        protected static CustomersGI CustomerGI => new CustomersGI();
        protected static CustomerAr CustomerPage => new CustomerAr();
        protected static ACCustomerPriceClassesPage CustomerPriceClass => new ACCustomerPriceClassesPage();
        protected static CustomerLocation LocationPage => new CustomerLocation();
        protected static CustomerClassAr ACCustomerClassPage => new CustomerClassAr();
        protected static ShipVia CarrierPage => new ShipVia();
        protected static ShipViaGI CarrierGI => new ShipViaGI();
        protected static TaxZone ACTaxZonePage => new TaxZone();
        protected static ShipmentTerms ACShipTermsPage => new ShipmentTerms();
        protected CustomerEntity customerEntity;
        protected CustomerData newCustomer;
        protected BigCommerceRest.Rest.Domain.Entities.Customers.CustomerData newBcCustomer;
        
        protected SyncStatus syncStatus;
        protected string externalID;
        protected string customerLocalId;
        protected List<LocationEntity> locations;
        protected CustomerData customerData;
        protected BigCommerceRest.Rest.Domain.Entities.Customers.CustomerData bcCustomerData;
        protected DateTime? lastModifiedEx;
        protected List<AttributeEntity> attributes;

        protected BCApiClient.Rest.Client.DataRepository.Customers.CustomerRestDataProvider bcCustomerRestDataProvider;
        protected BCApiClient.Rest.Client.DataRepository.Customers.CustomerAddressRestDataProvider bcCustomerAddressRestDataProvider;
        protected BCApiClient.Rest.Client.DataRepository.Customers.CustomerFormFieldValuesDataProvider bcCustomerFormFieldValuesDataProvider;
        

        public TestCustomerBase()
        {
            bcCustomerAddressRestDataProvider = BigCommerceApiService.Instance.customerAddressRestDataProvider;
            bcCustomerRestDataProvider = BigCommerceApiService.Instance.сustomerRestDataProvider;
            bcCustomerFormFieldValuesDataProvider = BigCommerceApiService.Instance.customerFormFieldValuesDataProvider;
        }

        public override void BeforeExecute()
        {
            Browser.StartingUrl = Config.SITE_DST_URL;
            PxLogin LoginPage = new PxLogin();
            LoginPage.Username.Type(Config.SITE_DST_LOGIN);
            LoginPage.Password.Type(Config.SITE_DST_PASSWORD);
            LoginPage.SignIn.Click();
        }

        public override void AfterExecute()
        {
            CustomerGI.LogOut();
            Browser.Stop();
            base.AfterExecute();
        }

        protected virtual void Clearing(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            var apiDataProvider = WooCommerceApiService.Instance.CustomerRestDataProvider;
            try
            {
                var data = clenupHelper.Get(type);
                if (data.Any())
                {
                    foreach (var id in data.SelectMany(c => c.IDs))
                    {
                        //var orders = apiDataProvider.GetCustomerAll(id);
                        DeleteCustomerRelatedOrders(id);
                        apiDataProvider.Delete(id);
                    }
                    clenupHelper.Clean(type);
                }
            }
            catch (Exception e)
            {
                Log.Error($"Clearing error: {e}");
            }
        }
        
        protected virtual void BCClearing(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            try
            {
                var data = clenupHelper.Get(type);
                if (data.Any())
                {
                    foreach (var id in data.SelectMany(c => c.IDs))
                    {
                        bcCustomerRestDataProvider.Delete(int.Parse(id));
                    }
                    clenupHelper.Clean(type);
                }
            }
            catch (Exception e)
            {
                Log.Error($"Clearing error: {e}");
            }
        }

        protected virtual void DeleteCustomerRelatedOrders(string customerId)
        {
            long id;
            if (customerId != null)
            {
                if (customerId.Contains(";"))
                {
                    customerId = customerId.Split(';')[0];
                }

                id = Convert.ToInt64(customerId);
               
                DraftOrderRestDataProvider draftsProvider = WooCommerceApiService.Instance.DraftOrderRestDataProvider;
                List<DraftOrderData> drafts = draftsProvider.GetAll().Where(c => c.Customer.Id == id).ToList();
                foreach (DraftOrderData draft in drafts)
                {
                    draftsProvider.Delete(draft.Id.ToString());
                }

                OrderRestDataProvider ordersProvider = WooCommerceApiService.Instance.OrderRestDataProvider;
                List<OrderData> orders = ordersProvider.GetAll().Where(c => c.Customer.Id == id).ToList();
                foreach (OrderData order in orders)
                {
                    ordersProvider.CancelOrder(order.Id.ToString());
                    ordersProvider.Delete(order.Id.ToString());
                }
            }
        }
        protected virtual void SaveID(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            clenupHelper.Save(type, new List<ClenupEntity> { new ClenupEntity(typeof(CustomerData), externalID) });
        }
    }
}