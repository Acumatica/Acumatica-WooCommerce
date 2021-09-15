using System;
using System.Collections.Generic;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntity
    {
        public SalesOrderEntity()
        {
            Summary = new SalesOrderEntityHeader();
            DocumentDetails = new List<SalesOrderEntityDetails>();
            TaxDetails = new List<SalesOrderEntityTaxDetails>();
            DiscountDetails = new List<SalesOrderEntityDiscountDetails>();
            ShippingSettings = new SalesOrderEntityShippingSettings();
            Shipments = new List<SalesOrderEntityShipment>();
            Payments = new List<SalesOrderEntityPayments>();
            Totals = new SalesOrderEntityTotals();
        }
       
        public SalesOrderEntityHeader Summary { get; set; }
        public List<SalesOrderEntityDetails> DocumentDetails { get; set; }
        public List<SalesOrderEntityTaxDetails> TaxDetails { get; set; }
        public List<SalesOrderEntityDiscountDetails> DiscountDetails { get; set; }
        public SalesOrderEntityShippingSettings ShippingSettings { get; set; }
        public List<SalesOrderEntityShipment> Shipments { get; set; }
        public List<SalesOrderEntityPayments> Payments { get; set; }
        public SalesOrderEntityTotals Totals { get; set; }

        //public static implicit operator object(SalesOrderEntity v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}