using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Orders;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products;
using ACSC.Tests.Cleanup;
using ACSC.Tests.Custom;
using ACSC.Tests.TestsSalesOrder;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Customers;
using BCApiClient.Rest.Domain.Entities.Orders;
using ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Orders;
using ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products;
using ACSC.Tests.Entity.ConnectorEntity;
using ACSC.Tests.Extensions;
using Core.Log;

namespace ACSC.Tests.BigCommerceTests.TestsSalesOrder
{
    public abstract class BCTestSalesOrderBase : TestSalesOrderBase
    {
        protected ConnectorEntity connectorEntity;
        protected BigCommerceApiService bcService = BigCommerceApiService.Instance;
        protected OrderRestDataProvider bcOrderDataProvider;
        protected OrderPaymentRestDataProvider bcOrderPaymentRestDataProvider;
        protected ProductRestDataProvider bcProductDataProvider;
        protected ProductBulkPricingRulesDataProvider ProductBulkPricingRulesDataProvider;
        protected ProductVariantRestDataProvider ProductVariantsRestDataProvider;
        protected string productId;
        protected BCTestSalesOrderBase()
        {
            ProductBulkPricingRulesDataProvider = bcService.ProductBulkPricingRulesRestDataProvider;
            ProductVariantsRestDataProvider = bcService.ProductVariantsRestDataProvider;
            connectorEntity = new ConnectorEntity();
            bcProductDataProvider = bcService.ProductRestDataProvider;
            bcOrderDataProvider = bcService.OrderDataProvider;
            bcOrderPaymentRestDataProvider = bcService.OrderPaymentRestDataProvider;
        }
        public OrderProductData GetOrderProduct(ProductData product, int quantity)
        {
            int cost = 200;
            return new OrderProductData()
            {
                Id = product.Id,
                ProductName = product.Name,
                Sku = product.Sku,
                Quantity = quantity,
                PriceIncludingTax = cost,
                PriceExcludingTax = cost
            };
        }


        public OrderDataResponse CreateTestOrder()
        {
            var product = bcProductDataProvider.GetByID(int.Parse(productId));
            var bcCustomer = bcService.сustomerRestDataProvider.GetByID(int.Parse(extCustID));

            List<OrderProductData> orderProducts = new List<OrderProductData>();
            var orderProduct = GetOrderProduct(product, 1);
            orderProducts.Add(orderProduct);

            return CreateBCOrderWithPayment(orderProducts, bcCustomer);
        }

        public OrderData GetBcOrder(CustomerData bcCustomer, OrderBillingAddressData billingAddress, OrderShippingAddressData shippingAddress, List<OrderProductData> orderProducts)
        {
            if (orderProducts.Count > 0)
            {
                return new OrderData
                {
                    CustomerId = bcCustomer.Id,
                    Customer = bcCustomer,
                    BillingAddress = billingAddress,
                    ShippingAddresses = new List<OrderShippingAddressData>() { shippingAddress },
                    Products = new List<OrderProductData> {new OrderProductData {Id = int.Parse(productId), Quantity = 1}},
                    StatusId = 0
                };
            }
            else
            {
                throw new Exception("At least one order product should be added.");
            }
        }
        protected OrderDataResponse CreateBCOrder(OrderData orderData)
        {
            //var billingAddress = GetOrderBillingAddress(bcCustomer.Addresses.FirstOrDefault());
            //var shipmentAddress = GetOrderShippingAddress(bcCustomer.Addresses.FirstOrDefault());
            //var orderData = GetBcOrder(bcCustomer, billingAddress, shipmentAddress, orderProductData);

            var createdOrder = bcOrderDataProvider.CreateOrder(orderData);
            var orderId = createdOrder?.Id.ToString();
            if (string.IsNullOrEmpty(orderId)) throw new Exception(Messages.OrderWasntCreatedException);
            var bCPayment = GetOrderPayment();
            ProcessPayment(bCPayment, createdOrder.Id);
            return bcOrderDataProvider.GetOrderByID(createdOrder.Id);
        }
        protected OrderDataResponse CreateBCOrderWithPayment(List<OrderProductData> orderProductData, CustomerData bcCustomer )
        {
            var billingAddress = GetOrderBillingAddress(bcCustomer.Addresses.FirstOrDefault());
            var shipmentAddress = GetOrderShippingAddress(bcCustomer.Addresses.FirstOrDefault());
            var orderData = GetBcOrder(bcCustomer, billingAddress, shipmentAddress, orderProductData);

            var createdOrder = bcOrderDataProvider.CreateOrder(orderData);
            var orderId = createdOrder?.Id.ToString();
            if (string.IsNullOrEmpty(orderId)) throw new Exception(Messages.OrderWasntCreatedException);
            var bCPayment = GetOrderPayment();
            ProcessPayment(bCPayment, createdOrder.Id);
            return bcOrderDataProvider.GetOrderByID(createdOrder.Id);
        }
        public OrderPaymentData GetOrderPayment()
        {
            return new OrderPaymentData()
            {
                Payment = new OrderPayment()
                {
                    Instrument =
                        new OrderPaymentInstrument()
                        {
                            CardholderName = "BP",
                            ExpiryMonth = 12,
                            ExpiryYear = 2023,
                            Number = "4111111111111111",
                            Type = "card",
                            VerificationValue = "411"
                        },
                    PaymentMethodID = "authorizenet.card"
                }
            };
        }

        public ProcesssPaymentResult ProcessPayment(OrderPaymentData bcPayment, int orderId)
        {
            OrderPaymentTokenData token = bcOrderPaymentRestDataProvider.GetPaymentAccessToken(new PaymentTokenOrderData() { Order = new PaymentTokenOrder() { Id = orderId } });
            return bcOrderPaymentRestDataProvider.ProcessPayment(bcPayment, token);
        }

        public OrderBillingAddressData GetOrderBillingAddress(CustomerAddressData address)
        {
            return new OrderBillingAddressData()
            {
                City = address.City,
                Company = address.Company,
                Country = address.Country,
                CountryIso2 = address.CountryIso2,
                Phone = address.Phone,
                FirstName = address.FirstName,
                LastName = address.LastName,
                State = address.State,
                Street1 = address.Street1,
                Street2 = address.Street2,
                ZipCode = address.ZipCode,
                Email = GenerateRandomEmail()
            };
        }

        public OrderShippingAddressData GetOrderShippingAddress(CustomerAddressData address)
        {
            return new OrderShippingAddressData()
            {
                City = address.City,
                Company = address.Company,
                Country = address.Country,
                CountryIso2 = address.CountryIso2,
                Phone = address.Phone,
                FirstName = address.FirstName,
                LastName = address.LastName,
                State = address.State,
                Street1 = address.Street1,
                Street2 = address.Street2,
                ZipCode = address.ZipCode,
                Email = GenerateRandomEmail()
            };
        }
        protected virtual void BCClearing(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            var apiDataProvider = BigCommerceApiService.Instance.OrderDataProvider;
            try
            {
                var data = clenupHelper.Get(type);
                if (data.Any())
                {
                    foreach (var id in data.SelectMany(c => c.IDs))
                    {
                        apiDataProvider.Delete(int.Parse(id));
                    }
                    clenupHelper.Clean(type);
                }
            }
            catch (Exception e)
            {
                Log.Error($"Clearing error: {e}");
            }
        }

    }
}