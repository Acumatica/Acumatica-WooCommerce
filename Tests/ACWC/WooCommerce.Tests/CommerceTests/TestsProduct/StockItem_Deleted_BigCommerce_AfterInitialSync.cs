using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.TestsProduct;
using Core.TestExecution;
using PX.QA.Tools;
using System.Linq;

namespace ACSC.Tests.BigCommerceTests.TestsProduct
{
    public class StockItem_Deleted_BigCommerce_AfterInitialSync : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Create Stock Item in AC and deleting Stock Item in BigCommerce after initial sync"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Preconditions and clearing"))
                {
                    BCClearing(this.GetType());
                }

                using (TestExecution.CreateTestCaseGroup("Step 1 - Create Stock Item"))
                {
                    store = Stores.BigCommerce;
                    ConfigureInventoryAutoNumbering();
                    //Create Stock Item
                    stockItem = DataService.GetStockItemsEntity(BcDataFilePath.StockItem_Deleted_BigCommerce_AfterInitialSync).FirstOrDefault();
                    StockItemPage.OpenScreen();
                    visitor.SetData(stockItem);
                    StockItemPage.Insert();
                    StockItemPage.Full(visitor);
                    StockItemPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Export Stock Items to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.StockItem, Entities.SalesCategory);
                    
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                    ProcessDataPage.ProcessAll();

                    ManualSyncByLocalId(Entities.StockItem, stockItem?.Description);
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(stockItem);
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Delete Stock Item in Acumatica"))
                {
                    StockItemPage.OpenScreen();

                    StockItemPage.Summary.InventoryCD.Select(stockItem.InventoryCD);

                    StockItemPage.Delete();
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Export Stock Items to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.StockItem);
                    ManualSyncByLocalId(Entities.StockItem, stockItem?.Description);
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify deleted Stock Item in BigCommerce"))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.StockItem, Statuses.Deleted, store);

                    var localID = $"{stockItem.Description}";
                    SyncStatus.DetailsFilter.LocalID.Contains(localID);
                    syncStatus = SyncStatus.Get();

                    EntityComparer.Instance.Validate(GetSyncStatusDel(localID), syncStatus)
                                    .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, stockItem.InventoryCD))
                                    .IsValid
                                    .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        protected virtual SyncStatus GetSyncStatusDel(string localID)
        {
            var syncStatus = new SyncStatus();
            syncStatus.DetailsView.Add(new SyncStatusDetails { LocalID = localID, Status = Statuses.Deleted });
            return syncStatus;
        }
    }
}
