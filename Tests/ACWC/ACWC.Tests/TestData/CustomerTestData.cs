using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using Bogus;

namespace WooCommerce.Tests.TestData
{
    public class CustomerTestData
    {
        public string TestAccountName;
        public CustomerData PrimaryDataGenerator()
        {
            Randomizer.Seed = new Random(new Random().Next(0, int.MaxValue));

            var customerGenerator = new Faker<CustomerData>()
            //.RuleFor(u => u.ID, (f, u) => f.Name.ID())
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                    .RuleFor(c => c.LastName, (f, c) => f.Name.LastName())
                    .RuleFor(c => c.Username, (f, c) => f.Internet.UserName(c.FirstName, c.LastName))
                    .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName, null, "test"));
            return customerGenerator.Generate();
        }
        public CustomerAddressData ShippingDataGenerator()
        {
            Randomizer.Seed = new Random(new Random().Next(0, int.MaxValue));
            var shippingGenerator = new Faker<CustomerAddressData>()
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                    .RuleFor(u => u.LastName, (f, CustomerAddressDatau) => f.Name.LastName())
                    .RuleFor(u => u.Address1, (f, u) => f.Address.BuildingNumber())
                    .RuleFor(u => u.Address2, (f, u) => f.Address.StreetAddress())
                    .RuleFor(u => u.State, (f, u) => f.Address.State())
                    .RuleFor(u => u.Country, (f, u) => "United State")
                    .RuleFor(u => u.ZipCode, (f, u) => f.Address.ZipCode())
                    .RuleFor(u => u.Company, (f, u) => f.Company.CompanyName())
                    .RuleFor(u => u.City, (f, u) => f.Address.City());
            return shippingGenerator.Generate();
        }

        public CustomerAddressData BillingDataGenerator()
        {
            Randomizer.Seed = new Random(new Random().Next(0, int.MaxValue));
            var shippingGenerator = new Faker<CustomerAddressData>()
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                    .RuleFor(u => u.LastName, (f, CustomerAddressDatau) => f.Name.LastName())
                    .RuleFor(u => u.Address1, (f, u) => f.Address.BuildingNumber())
                    .RuleFor(u => u.Address2, (f, u) => f.Address.StreetAddress())
                    .RuleFor(u => u.State, (f, u) => f.Address.State())
                    .RuleFor(u => u.Country, (f, u) => "United State")
                    .RuleFor(u => u.ZipCode, (f, u) => f.Address.ZipCode())
                    .RuleFor(u => u.Company, (f, u) => f.Company.CompanyName())
                    .RuleFor(u => u.City, (f, u) => f.Address.City());
            return shippingGenerator.Generate();
        }

        public CustomerData CustomerDataSetup()
        {
            var customerTestData = new CustomerTestData();
            var customerPrimaryData = customerTestData.PrimaryDataGenerator();
            TestAccountName = customerPrimaryData.Username;
            return customerPrimaryData;
        }

        //public string NewCustomerName()
        //{
        //    return TestAccountName;
        //}
    }
}
