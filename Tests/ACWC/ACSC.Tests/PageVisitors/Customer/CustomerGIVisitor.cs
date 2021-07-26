using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Extensions.Customer;

namespace ACSC.Tests.PageVisitors.Customer
{
    public class CustomerGIVisitor : ICustomerGIVisitor
    {
        public CustomerGI Get(CustomersGI page)
        {
            var result = new CustomerGI();
            var count = page.Results.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.Results.SelectRow(i);
                var row = page.ResultsGridRow;
                if (row != null)
                {
                    result.ResultRows.Add(new CustomerGIRow
                    {
                        CustomerID = row.CustomerID.GetValue(),
                        CustomerName = row.CustomerName.GetValue(),
                        CustomerClass = row.CustomerClass.GetValue(),
                        Country = row.Country.GetValue(),
                        City = row.City.GetValue(),
                        CurrentcyID = row.CurrentcyID.GetValue(),
                        Status = row.Status.GetValue(),
                        Terms = row.Terms.GetValue(),
                    });
                }
            }

            return result;
        }
    }
}