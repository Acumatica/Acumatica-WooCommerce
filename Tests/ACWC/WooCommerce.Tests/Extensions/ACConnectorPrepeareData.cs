using System;
using GeneratedWrappers.Acumatica;
using ACSC.Tests.Custom;
using Core.Wait;

namespace ACSC.Tests.Extensions
{
    public class ACConnectorPrepeareData : BC501000_BCPrepareData
    {
        public c_processfilter_form Header => base.ProcessFilter_form;
        public c_entities_grid GridWizard => base.Entities_grid;
        public c_processingview_griddetails ProcessingGrid => ProcessingView_gridDetails;
        public PxToolBar TollBar
        {
            get { return ToolBar; }
        }
        protected ACConnectorProcessData ProccessData => new ACConnectorProcessData();
        public void SetProcessFilter(string fetchMode, string store = null, params string[] entity)
        {
            if (store != null)
            {
                Header.BindingID.Select(store);
            }

            Header.PrepareMode.Select(fetchMode);
            if (fetchMode == FetchMode.Full || fetchMode == FetchMode.Reconciliation)
            {
                Header.StartDate.Reset();
            }
            GridWizard.Columns.EntityType.Equals(entity);

            var count = GridWizard.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                GridWizard.SelectRow(i);
                var row = GridWizard.Row;
                if (row != null)
                {
                    row.Selected.SetTrue();
                }
            }
        }
        public void FetchData(string store, string fetchMode, string entity, params string[] additionalEntities)
        {
            OpenScreen();
            Header.BindingID.Select(store);
            Header.PrepareMode.Select(fetchMode);
            if (fetchMode == FetchMode.Reconciliation || fetchMode == FetchMode.Full)
            {
                Header.StartDate.Reset();
            }
            GridWizard.ResetColumnFilters();
            GridWizard.SelectRow(GridWizard.Columns.EntityType, entity);
            GridWizard.Row.Selected.SetTrue();

            foreach (var adEntity in additionalEntities)
            {
                GridWizard.SelectRow(GridWizard.Columns.EntityType, adEntity);
                GridWizard.Row.Selected.SetTrue();
            }

            using (new Wait(PX.QA.Tools.WaitBase.LongTimeOut * 10))
            {
                ToolBar.Process.WaitAction = Wait.WaitForLongOperationToComplete;
                Process();
            }
            ProcessingGrid.Close();
        }
        
        public void FetchDataByEntityUsingFetchModeWithSyncMode(string store, string fetchMode, string syncMode, string entity, string entityID = null, params string[] additionalsEntities)
        {
            FetchData(store, fetchMode, entity, additionalsEntities);
            if (syncMode == SyncMode.PendingAndFailed)
            {
                ProccessData.OpenScreen();
                if (entityID != null)
                {
                    ProccessData.ProccessingForm.BindingID.Select(store);
                    ProccessData.ProccessingForm.EntityType.Select(entity);
                    ProccessData.Grid.ResetColumnFilters();
                    ProccessData.Grid.Columns.ExternID.Contains(entityID);
                    ProccessData.Grid.SelectRow(1);
                    ProccessData.Grid.Row.Selected.SetTrue();
                    using (new Wait(PX.QA.Tools.WaitBase.LongTimeOut * 5))
                    {
                        ProccessData.ToolBar.Process.WaitActionOverride = () => Wait.WaitForLongOperationToComplete();
                        ProccessData.Process();
                        ProccessData.ProcessingGridDetails.Close();
                    }
                    foreach (var adEntity in additionalsEntities)
                    {
                        ProccessData.ProccessingForm.EntityType.Select(adEntity);
                        ProccessData.Grid.Columns.ExternID.Contains(entityID);
                        ProccessData.Grid.SelectRow(1);
                        ProccessData.Grid.Row.Selected.SetTrue();
                        ProccessData.ToolBar.Process.WaitActionOverride = () => Wait.WaitForLongOperationToComplete();
                        ProccessData.Process();
                        ProccessData.ProcessingGridDetails.Close();
                    }
                }
                else
                {
                    ProccessData.ProccessingForm.EntityType.Select(entity);
                    using (new Wait(PX.QA.Tools.WaitBase.LongTimeOut * 5))
                    {
                        ProccessData.ToolBar.ProcessAll.WaitActionOverride = () => Wait.WaitForLongOperationToComplete();
                        ProccessData.ProcessAll();
                    }
                }
            }
        }
    }
}