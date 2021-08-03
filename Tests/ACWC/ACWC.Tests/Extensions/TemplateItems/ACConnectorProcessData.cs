using ACBC.Tests.Wrappers;

namespace ACSC.Tests.Extensions.TemplateItems
{
    public class ACConnectorProcessData : BC501500_BCProcessData
    {
        public c_processfilter_form Header => ProcessFilter_form;
        public c_statuses_grid GridDetails => Statuses_grid;

        public void SetProcessFilter(string store, string[] status, params string[] entity)
        {
            Header.BindingID.Select(store);
            GridDetails.Columns.EntityType.Equals(entity);
            GridDetails.Columns.Status.Equals(status);

            //var count = GridDetails.RowsCount().ToString();
            //int.TryParse(count, out int rowCount);

            //for (var i = 1; i <= rowCount; i++)
            //{
            //    GridDetails.SelectRow(i);
            //    var row = GridDetails.Row;
            //    if (row != null)
            //    {
            //        row.Selected.SetTrue();
            //    }
            //}
        }
    }
}