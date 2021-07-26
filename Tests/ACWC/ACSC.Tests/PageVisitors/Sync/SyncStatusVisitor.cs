using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.Extensions;

namespace ACSC.Tests.PageVisitors.Sync
{
    public class SyncStatusVisitor : ISyncStatusVisitor
    {
        public SyncStatus Get(ACConnectorSyncStatus page)
        {
            var syncStatus = new SyncStatus
            {
                //Connector = page.FormFilter.Connector.GetValue(),
                Store = page.FormFilter.Store.GetValue(),
                Entity = page.FormFilter.Entity.GetValue(),
                //View = page.FormFilter.View.GetValue(),
                //Status = page.FormFilter.Status.GetValue(),               
            };
            

            var count = page.DetailsGrid.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.DetailsGrid.SelectRow(i);
                var row = page.DetailsRow;
                if (row != null)
                {
                    syncStatus.DetailsView.Add(
                        new SyncStatusDetails
                        {
                            Selected = row.Selected.GetValue(),
                            Connector = row.Connector.GetValue(),
                            Store = row.Store.GetValue(),
                            Entity = row.Entity.GetValue(),
                            Status = row.Status.GetValue(),
                            PendingSync = row.PendingSync.GetValue(),
                            LocalID = row.LocalID.GetValue(),
                            LocallyModified = row.LocallyModified.GetValue(),
                            ExternalID = row.ExternalID.GetValue(),
                            ExternallyModified = row.ExternallyModified.GetValue(),
                            ExternalHash = row.ExternHash.GetValue(),
                            LastOperation = row.LastOperation.GetValue(),
                            Error = row.Error.GetValue(),
                            //LastAttempt = row.LastAttempt.Getvalue(),
                            AttemptCount = row.AttemptCount.GetValue()
                        }) ;
                }
            }

            return syncStatus;
        }
    }
}