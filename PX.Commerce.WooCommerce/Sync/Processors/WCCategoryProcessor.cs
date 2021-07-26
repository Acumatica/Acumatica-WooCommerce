using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.Sync.Buckets;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PX.Commerce.WooCommerce.Sync.Processors
{
    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.SalesCategory, BCCaptions.SalesCategory,
        IsInternal = false,
        Direction = SyncDirection.Export,
        PrimaryDirection = SyncDirection.Export,
        PrimarySystem = PrimarySystem.Local,
        PrimaryGraph = typeof(PX.Objects.IN.INCategoryMaint),
        ExternTypes = new Type[] { typeof(CategoryData) },
        LocalTypes = new Type[] { typeof(BCItemSalesCategory) },
        AcumaticaPrimaryType = typeof(PX.Objects.IN.INCategory),
        AcumaticaPrimarySelect = typeof(PX.Objects.IN.INCategory.categoryID),
        URL = "products/categories/{0}/edit"
    )]
    public class WCCategoryProcessor : BCProcessorSingleBase<WCCategoryProcessor, WCCategoryEntityBucket, MappedCategory>, IProcessor
    {
        protected ProductCategoryDataProvider categoryDataProvider;

        #region Constructor
        public override void Initialise(IConnector iconnector, ConnectorOperation operation)
        {
            base.Initialise(iconnector, operation);

            cbapi.UseNoteID = true;
            categoryDataProvider = new ProductCategoryDataProvider(WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>()));
        }
        #endregion

        #region Common
        public override MappedCategory PullEntity(Guid? localID, Dictionary<string, object> fields)
        {
            BCItemSalesCategory impl = cbapi.GetByID<BCItemSalesCategory>(localID);
            if (impl == null) return null;

            MappedCategory obj = new MappedCategory(impl, impl.SyncID, impl.SyncTime);

            return obj;
        }

        public override MappedCategory PullEntity(string externID, string jsonObject)
        {
            CategoryData data = categoryDataProvider.GetByID(externID);
            if (data == null) return null;

            MappedCategory obj = new MappedCategory(data, data.Id.ToString(), data.CalculateHash());

            return obj;
        }

        public override IEnumerable<MappedCategory> PullSimilar(IExternEntity entity, out string uniqueField)
        {
            uniqueField = ((CategoryData)entity)?.Name;
            var parent = ((CategoryData)entity)?.Parent;
            if (uniqueField == null) return null;

            PX.Objects.IN.INCategory incategory = PXSelectJoin<PX.Objects.IN.INCategory,
                    LeftJoin<BCSyncStatus, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                    Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncStatus.entityType, Equal<Current<BCEntity.entityType>>,
                        And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>.Select(this, parent);
            int parentId = incategory?.CategoryID ?? 0;
            var impls = cbapi.GetAll(new BCItemSalesCategory() { Description = uniqueField.SearchField(), ParentCategoryID = parentId.SearchField() },
                 filters: GetFilter(Operation.EntityType).LocalFiltersRows.Cast<PXFilterRow>().ToArray());
            if (impls == null) return null;

            return impls.Select(impl => new MappedCategory(impl, impl.SyncID, impl.SyncTime));
        }

        public override IEnumerable<MappedCategory> PullSimilar(ILocalEntity entity, out string uniqueField)
        {
            uniqueField = ((BCItemSalesCategory)entity)?.Description?.Value;
            var parent = ((BCItemSalesCategory)entity)?.ParentCategoryID?.Value;
            if (uniqueField == null) return null;

            BCSyncStatus parentStatus = PXSelectJoin<BCSyncStatus,
                    LeftJoin<PX.Objects.IN.INCategory, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                    Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                        And<PX.Objects.IN.INCategory.categoryID, Equal<Required<PX.Objects.IN.INCategory.categoryID>>>>>>>
                        .Select(this, BCEntitiesAttribute.SalesCategory, parent);
            int parentId = parentStatus?.ExternID?.ToInt() ?? 0;
            IEnumerable<CategoryData> datas = categoryDataProvider.GetAll(new FilterProductCategories() { slug = uniqueField, Parent = parentId });
            if (datas == null) return null;

            return datas.Select(data => new MappedCategory(data, data.Id.ToString(), data.CalculateHash()));
        }

        public override void NavigateLocal(IConnector connector, ISyncStatus status)
        {
            PX.Objects.IN.INCategoryMaint extGraph = CreateInstance<PX.Objects.IN.INCategoryMaint>();
            Objects.BCINCategoryMaintExt extGraphExt = extGraph.GetExtension<Objects.BCINCategoryMaintExt>();
            extGraphExt.SelectedCategory.Current = PXSelect<Objects.BCINCategoryMaintExt.SelectedINCategory,
              Where<Objects.BCINCategoryMaintExt.SelectedINCategory.noteID, Equal<Required<Objects.BCINCategoryMaintExt.SelectedINCategory.noteID>>>>.Select(extGraph, status.LocalID);

            throw new PXRedirectRequiredException(extGraph, true, "Navigation");
        }
        #endregion

        #region Import
        public override void FetchBucketsForImport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            FilterProductCategories filter = new FilterProductCategories() { HideEmpty = true }; //No DateTime filtering for Category

            IEnumerable<CategoryData> datas = categoryDataProvider.GetAll(filter);

            foreach (CategoryData data in datas)
            {
                if (data == null) continue;

                WCCategoryEntityBucket bucket = CreateBucket();
                MappedCategory obj = bucket.Category = bucket.Category.Set(data, data.Id.ToString(), data.CalculateHash());
                EnsureStatus(obj, SyncDirection.Import);
            }
        }

        public override EntityStatus GetBucketForImport(WCCategoryEntityBucket bucket, BCSyncStatus bcstatus)
        {
            CategoryData data = categoryDataProvider.GetByID(bcstatus.ExternID);
            if (data == null) return EntityStatus.None;

            MappedCategory obj = bucket.Category = bucket.Category.Set(data, data.Id.ToString(), data.CalculateHash());
            EntityStatus status = EnsureStatus(obj, SyncDirection.Import);

            int? parent = obj.Extern.Parent;
            if (parent != null && parent > 0)
            {
                CategoryData parentData = categoryDataProvider.GetByID(parent.ToString());
                if (parentData != null)
                {
                    MappedCategory parentObj = bucket.ExternParent = bucket.ExternParent.Set(parentData, parentData.Id.ToString(), data.CalculateHash());

                    EnsureStatus(parentObj);
                }
            }

            return status;
        }

        public override void MapBucketImport(WCCategoryEntityBucket bucket, IMappedEntity existing)
        {
            MappedCategory obj = bucket.Category;

            CategoryData data = obj.Extern;
            BCItemSalesCategory impl = obj.Local = new BCItemSalesCategory();
            impl.Custom = GetCustomFieldsForImport();

            impl.Description = data.Name.ValueField();
            impl.SortOrder = data.Id.ValueField();

            if (data.Parent != null && data.Parent > 0 && impl.Description?.Value != null)
            {
                PX.Objects.IN.INCategory incategory = PXSelectJoin<PX.Objects.IN.INCategory,
                    LeftJoin<BCSyncStatus, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                    Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncStatus.entityType, Equal<Current<BCEntity.entityType>>,
                        And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>.Select(this, data.Parent);
                if (incategory == null) throw new PXException(BCMessages.CategoryNotSyncronizedParent, impl.Description.Value);
                obj.Local.ParentCategoryID = incategory.CategoryID.ValueField();
            }
            else obj.Local.ParentCategoryID = 0.ValueField();
        }

        public override void SaveBucketImport(WCCategoryEntityBucket bucket, IMappedEntity existing, string operation)
        {
            MappedCategory obj = bucket.Category;

            if (existing?.Local != null) obj.Local.CategoryID = ((BCItemSalesCategory)existing.Local).CategoryID.Value.SearchField();

            // Prevent to save of category with no changes. Workaround for a bug in Acumatica, where it returns the wrong record in case not changes.
            if (existing != null && ((BCItemSalesCategory)existing.Local).Description?.Value == obj.Local.Description?.Value
                && (((BCItemSalesCategory)existing.Local).ParentCategoryID?.Value ?? 0) == (obj.Local.ParentCategoryID?.Value ?? 0))
            {
                UpdateStatus(obj, operation);
                return;
            }

            BCItemSalesCategory impl = cbapi.Put(obj.Local, obj.LocalID);

            bucket.Category.AddLocal(impl, impl.SyncID, impl.SyncTime);
            UpdateStatus(obj, operation);
        }
        #endregion

        #region Export
        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            IEnumerable<BCItemSalesCategory> impls = cbapi.GetAll(new BCItemSalesCategory() { Path = new StringReturn() }, minDateTime, maxDateTime, filters, false);
            var invIDs = new List<int>();

            foreach (BCItemSalesCategory impl in impls)
            {
                if (impl.SyncID == null) continue; //We need to skip the root node, which does not have a ID

                MappedCategory obj = new MappedCategory(impl, impl.SyncID, impl.SyncTime);
                EntityStatus status = EnsureStatus(obj, SyncDirection.Export);
                if (status == EntityStatus.Pending) invIDs.Add(impl?.CategoryID?.Value ?? 0);
            }
        }

        public override EntityStatus GetBucketForExport(WCCategoryEntityBucket bucket, BCSyncStatus bcstatus)
        {
            BCItemSalesCategory impl = cbapi.GetByID<BCItemSalesCategory>(bcstatus.LocalID, GetCustomFieldsForExport());
            if (impl == null) return EntityStatus.None;

            MappedCategory obj = bucket.Category = bucket.Category.Set(impl, impl.SyncID, impl.SyncTime);
            EntityStatus status = EnsureStatus(obj, SyncDirection.Export);

            int? parent = obj.Local.ParentCategoryID?.Value;
            if (parent != null && parent > 0)
            {
                BCItemSalesCategory parentImpl = cbapi.Get(new BCItemSalesCategory() { CategoryID = parent.ValueField() });
                if (parentImpl != null)
                {
                    MappedCategory parentObj = bucket.LocalParent = bucket.LocalParent.Set(parentImpl, parentImpl.SyncID, parentImpl.SyncTime);
                    EntityStatus parentStatus = EnsureStatus(parentObj);
                }
            }
            return status;
        }

        public override void MapBucketExport(WCCategoryEntityBucket bucket, IMappedEntity existing)
        {
            MappedCategory obj = bucket.Category;

            BCItemSalesCategory impl = obj.Local;
            CategoryData data = obj.Extern = new CategoryData();
            if (!string.IsNullOrWhiteSpace(obj.ExternID))
                data.Id = int.Parse(obj.ExternID);
            data.Name = impl.Description?.Value;

            if (impl.ParentCategoryID?.Value != null && impl.ParentCategoryID?.Value > 0 && data.Name != null)
            {
                BCSyncStatus parentStatus = PXSelectJoin<BCSyncStatus,
                    LeftJoin<PX.Objects.IN.INCategory, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                    Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                        And<PX.Objects.IN.INCategory.categoryID, Equal<Required<PX.Objects.IN.INCategory.categoryID>>>>>>>
                        .Select(this, BCEntitiesAttribute.SalesCategory, impl.ParentCategoryID?.Value);
                if (parentStatus == null) throw new PXException(BCMessages.CategoryNotSyncronizedParent, data.Name);

                data.Parent = parentStatus.ExternID.ToInt();
            }
            else data.Parent = 0;
        }

        public override void SaveBucketExport(WCCategoryEntityBucket bucket, IMappedEntity existing, string operation)
        {
            MappedCategory obj = bucket.Category;

            CategoryData data;
            if (obj.ExternID == null)
                data = categoryDataProvider.Create(obj.Extern);
            else
                data = categoryDataProvider.Update(obj.Extern, obj.ExternID.ToInt().Value);
            obj.AddExtern(data, data.Id.ToString(), data.CalculateHash());
            UpdateStatus(obj, operation);
        }
        #endregion
    }
}
