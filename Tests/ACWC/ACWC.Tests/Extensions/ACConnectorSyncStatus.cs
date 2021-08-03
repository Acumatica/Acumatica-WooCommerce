using System;
using System.Collections.Generic;
using GeneratedWrappers.Acumatica;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.Sync;
using Controls.CheckBox;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;

namespace ACSC.Tests.Extensions
{
    public class ACConnectorSyncStatus : BC301000_BCSyncHistoryMaint
    {
        public c_masterview_form Header => MasterView_form;
        public c_detailsview_grid DetailsGrid => DetailsView_grid;
        public HeaderFilter FormFilter => new HeaderFilter(this);
        public DetailsGridHeader DetailsFilter => new DetailsGridHeader(this);
        public DetailsGridRow DetailsRow => new DetailsGridRow(this);

        public class HeaderFilter
        {
            private readonly ACConnectorSyncStatus _parent;

            public HeaderFilter(ACConnectorSyncStatus parent)
            {
                _parent = parent;
            }

            //public DropDown Connector => _parent.Form.ConnectorType;
            public Selector Store => _parent.Header.BindingID;
            public DropDown Entity => _parent.Header.EntityType;
           // public DropDown View => _parent.Form.View;
           // public DropDown Status => _parent.Form.Status;
        }

        public class DetailsGridHeader
        {
            private readonly ACConnectorSyncStatus _parent;
            private readonly c_detailsview_grid.c_grid_header _header;

            public DetailsGridHeader(ACConnectorSyncStatus parent)
            {
                _parent = parent;
                _header = parent.DetailsGrid.Columns;
            }

            public DropDownColumnFilter Connector => _header.ConnectorType;
            public SelectorColumnFilter Store => _header.BindingID;
            public DropDownColumnFilter Entity => _header.EntityType;
            public DropDownColumnFilter Status => _header.Status;
            public CheckBoxColumnFilter PendingSync => _header.PendingSync;
            public PXTextEditColumnFilter LocalID => _header.Source;
            public DateSelectorColumnFilter LocallyModified => _header.LocalTS;
            public PXTextEditColumnFilter ExternalID => _header.ExternID;
            public DateSelectorColumnFilter ExternallyModified => _header.ExternTS;
            public PXTextEditColumnFilter ExternalHash => _header.ExternHash;
            public DropDownColumnFilter LastOperation => _header.LastOperation;
            public PXTextEditColumnFilter Error => _header.LastErrorMessage;
            //public DateSelectorColumnFilter LastAttempt => _header.LastOperationTS;
            public PXNumberEditColumnFilter AttemptCount => _header.AttemptCount;
        }

        public class DetailsGridRow
        {
            private readonly ACConnectorSyncStatus _parent;
            private readonly c_detailsview_grid.c_grid_row _row;

            public DetailsGridRow(ACConnectorSyncStatus parent)
            {
                _parent = parent;
                _row = _parent.DetailsGrid.Row;
            }

            public CheckBox Selected => _row.Selected;
            public DropDown Connector => _row.ConnectorType;
            public Selector Store => _row.BindingID;
            public DropDown Entity => _row.EntityType;
            public DropDown Status => _row.Status;
            public CheckBox PendingSync => _row.PendingSync;
            public PXTextEdit LocalID => _row.Source;
            public DateSelector LocallyModified => _row.LocalTS;
            public PXTextEdit ExternalID => _row.ExternID;
            public DateSelector ExternallyModified => _row.ExternTS;
            public PXTextEdit ExternHash => _row.ExternHash;
            public DropDown LastOperation => _row.LastOperation;
            public PXTextEdit Error => _row.LastErrorMessage;
            public PXNumberEdit AttemptCount => _row.AttemptCount;

            public object LastAttempt { get; internal set; }
        }

        public SyncStatus Get(ISyncStatusVisitor visitor)
        {
            return visitor.Get(this);
        }

        public SyncStatus Get()
        {
            var visitor = VisitorsManager.GetSingle<ISyncStatusVisitor>(typeof(SyncStatusVisitor));
            return visitor.Get(this);
        }

        public void SetVerifyFilter(string entityType, string status, string localID = null, string externalID = null, string store = null)
        {
            SetVerifyFilter(entityType, status, store: store);
            DetailsGrid.ResetColumnFilters();
            if (!string.IsNullOrEmpty(localID))
            {
                DetailsFilter.LocalID.Contains(localID);
            }

            if (!string.IsNullOrEmpty(externalID))
            {
                DetailsFilter.ExternalID.Contains(externalID);
            }
        }

        public void SetVerifyFilter(string entityType, string status, string store)
        {
            if (store != null)
            {
                Header.BindingID.Select(store);
            }

            Header.EntityType.Select(entityType);
            SelectStatus(status);

        }

        public void SyncManualByLocalId(string store, string entityType, string description)
        {
            OpenScreen();
            if (store != null)
            {
                Header.BindingID.Select(store);
            }
            Header.EntityType.Select(entityType);
            DetailsGrid.AllRecords();
            DetailsGrid.ResetColumnFilters();
            DetailsGrid.Columns.Source.Contains(description);
            if (DetailsGrid.RowsCount() > 1)
            {
                DetailsGrid.Columns.Source.Equals(description);
            }
            DetailsGrid.SelectRow(1);
            DetailsGrid.Row.Selected.SetTrue();
            Sync();
            DetailsGrid.Columns.Source.ClearFilter();
            Save();
        }

        public void SetManualByLocalId(string store, string entityType, string description)
        {
            if (store != null)
            {
                Header.BindingID.Select(store);
            }
            Header.EntityType.Select(entityType);
            DetailsGrid.AllRecords();
            DetailsGrid.ResetColumnFilters();
            DetailsGrid.Columns.Source.Contains(description);
            if (DetailsGrid.RowsCount() > 1)
            {
                DetailsGrid.Columns.Source.Equals(description);
            }
            DetailsGrid.SelectRow(1);
            DetailsGrid.Row.Selected.SetTrue();
            DetailsGrid.Columns.Source.ClearFilter();
           
        }
        public void SetSyncManualListByLocalId(string store, string entityType, List<string> descriptionList, string status = null)
        {
            OpenScreen();
            if (store != null)
            {
                Header.BindingID.Select(store);
            }
            Header.EntityType.Select(entityType);
            SelectStatus(status);
            DetailsGrid.ResetColumnFilters();
            foreach (var description in descriptionList)
            {
                DetailsGrid.Columns.Source.Contains(description);
                if (DetailsGrid.RowsCount() > 1)
                {
                    DetailsGrid.Columns.Source.Equals(description);
                }

                if (DetailsGrid.HasRows())
                {
                    DetailsGrid.SelectRow(1);
                    DetailsGrid.Row.Selected.SetTrue();
                }
                
                DetailsGrid.Columns.Source.ClearFilter();
            }
            Sync();
            Save();
        }
        public void SyncManualListByLocalId(string store, string entityType, List<string> descriptionList)
        {
            OpenScreen();
            if (store != null)
            {
                Header.BindingID.Select(store);
            }
            Header.EntityType.Select(entityType);
            DetailsGrid.AllRecords();
            foreach (var description in descriptionList)
            {
                DetailsGrid.Columns.Source.Contains(description);
                DetailsGrid.SelectRow(1);
                DetailsGrid.Row.Selected.SetTrue();
                Sync();
                DetailsGrid.Columns.Source.ClearFilter();
                Save();
            }

        }
        public void SelectEntity(string entityType)
        {
            OpenScreen();
            Header.EntityType.Select(entityType);
        }
        public void SelectStatus(string syncStatus)
        {
            switch (syncStatus)
            {
                case Statuses.FailedAndPending:
                    DetailsGrid.Failed();
                    break;
                case Statuses.Failed:
                    DetailsGrid.Failed();
                    break;
                case Statuses.Synchronized:
                    DetailsGrid.Processed();
                    break;
                case Statuses.Skipped:
                    DetailsGrid.Skipped();
                    break;
                case Statuses.Deleted:
                    DetailsGrid.Deleted();
                    break;
                case Statuses.All:
                    DetailsGrid.AllRecords();
                    break;
                case Statuses.Filtered:
                    DetailsGrid.Filtered();
                    break;
                default:
                    DetailsGrid.AllRecords();
                    break;
            }
        }
    }
}