using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.Extensions;

namespace ACSC.Tests.PageVisitors.Sync
{
    public interface ISyncStatusVisitor
    {
        SyncStatus Get(ACConnectorSyncStatus page);
    }
}