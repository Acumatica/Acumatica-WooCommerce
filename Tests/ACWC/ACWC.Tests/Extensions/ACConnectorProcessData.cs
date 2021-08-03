using System.Linq;
using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions
{
    public class ACConnectorProcessData : BC501500_BCProcessData
    {
        public c_processfilter_form ProccessingForm
        {
            get { return ProcessFilter_form; }
        }
        public c_gridlist_gridgrid ProcessingGrid
        {
            get { return GridList_gridGrid; }
        }
        public PxToolBar Tollbar
        {
            get { return ToolBar; }
        }
        public c_processingview_griddetails ProcessingGridDetails
        {
            get { return ProcessingView_gridDetails; }
        } 
        public c_statuses_grid Grid
        {
            get { return Statuses_grid; }
        }

        public void SetLastOperationProcessFilter(string store, string[] status, int rowsCount, string[] operation, params string[] entity)
        {
            OpenScreen();
            ProccessingForm.BindingID.Select(store);
            Grid.Columns.EntityType.Equals(entity);
            Grid.Columns.Status.Equals(status);
            if (rowsCount > 0)
            {
                Grid.Columns.LastOperation.Equals(operation);
                Grid.Columns.LastOperationTS.SortDescending();
                for (var i = 1; i <= rowsCount; i++)
                {
                    Grid.SelectRow(i);
                    Grid.Row.Selected.SetTrue();
                }
            }
        }
        public void SetProcessFilter(string store, string[] status, int rowsCount, params string[] entity)
        {
            ProccessingForm.BindingID.Select(store);
            Grid.Columns.EntityType.Equals(entity);
            Grid.Columns.Status.Equals(status);
            if (rowsCount > 0)
            {
                Grid.Columns.LastOperationTS.SortDescending();
                for (var i = 1; i <= rowsCount; i++)
                {
                    Grid.SelectRow(i);
                    Grid.Row.Selected.SetTrue();
                }
            }
        }
        public void SetProcessFilter(string store, string[] status, params string[] entity)
        {
            ProccessingForm.BindingID.Select(store);
            Grid.Columns.EntityType.Equals(entity);
            Grid.Columns.Status.Equals(status);
        }
    }
}