using System;
using System.Collections.Generic;
using System.Linq;
using GeneratedWrappers.Acumatica;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.ConnectorEntity;
using Controls.Editors.DropDown;
using Controls.Editors.FormulaCombo;
using Core.Log;

namespace ACSC.Tests.Extensions
{
    public class ACConnectorEntities : BC202000_BCEntityMaint
    {
        public c_entityfilter_form Header => EntityFilter_form;
        public c_currententity_pxformview2 Settings => CurrentEntity_PXFormView2;
        public c_exportfilters_gridexportconditions ExportFilters => ExportFilters_gridExportConditions;
        public c_importfilters_gridimportconditions ImportFilters => ImportFilters_gridImportConditions;
        public c_exportmappings_gridexportmapping ExportMappings => ExportMappings_gridExportMapping;
        public c_importmappings_gridimportmapping ImportMappings => ImportMappings_gridImportMapping;
        public c_deleteconfirmationpanel_cstformview45 DeleteConfirmationPanel => DeleteConfirmationPanel_CstFormView45;

        public void SetConnectorSettings(string entity, string direction = null, string primarySystem = null, string store = null)
        {
            if (store != null)
            {
                Header.BindingID.Select(store);
            }

            Header.EntityType.Select(entity);

            if (direction != null)
            {
                Settings.Direction.Select(direction);
            }

            if (primarySystem != null)
            {
                Settings.PrimarySystem.Select(primarySystem);
            }
        }

        public void ClearExportFilter()
        {
            ExportFilters.RemoveAllRows();
            var count = ExportFilters.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                ExportFilters.SelectRow(i);
                ExportFilters.Delete();
            }
        }

        public void SetExportFilter(string fieldName, string condition, string value, string Operator)
        {
            ExportFilters.New();
            ExportFilters.Row.FieldName.Select(fieldName);
            ExportFilters.Row.Condition.Select(condition);
            ExportFilters.Row.Value.Type(value);
            ExportFilters.Row.Operator.Select(Operator);
        }

        public void SetExportFilter(ConnectorEntity connectorEntity)
        {
            SetConnectorSettings(connectorEntity.EntityType, store: connectorEntity.Store);
            RemoveImportExportAllRows();
            foreach (var filter in connectorEntity.ExportFiltering)
            {
                ExportFilters.New();
                ExportFilters.Row.OpenBrackets.Select(filter.OpenBrackets);
                ExportFilters.Row.FieldName.Select(filter.FieldName);
                ExportFilters.Row.Condition.Select(filter.Condition);
                ExportFilters.Row.Value.Type(filter.Value);
                ExportFilters.Row.CloseBrackets.Select(filter.CloseBrackets);
                ExportFilters.Row.Operator.Select(filter.Operator);
            }

        }

        public void SetImportFilter(ConnectorEntity connectorEntity)
        {
            SetConnectorSettings(connectorEntity.EntityType, store: connectorEntity.Store);
            RemoveImportExportAllRows();
            foreach (var filter in connectorEntity.ImportFiltering)
            {
                ImportFilters.New();
                ImportFilters.Row.OpenBrackets.Select(filter.OpenBrackets);
                ImportFilters.Row.FieldName.Select(filter.FieldName);
                ImportFilters.Row.Condition.Select(filter.Condition);
                ImportFilters.Row.Value.Type(filter.Value);
                ImportFilters.Row.CloseBrackets.Select(filter.CloseBrackets);
                ImportFilters.Row.Operator.Select(filter.Operator);
            }

        }

        public void SetImportMapping(ConnectorEntity connectorEntity)
        {
            SetConnectorSettings(connectorEntity.EntityType, store: connectorEntity.Store);
            RemoveImportExportAllRows();
            foreach (var mapping in connectorEntity.ImportMapping)
            {
                ImportMappings.New();
                ImportMappings.Row.TargetObject.DynamicControl<DropDown>().Select(mapping.TargetObj);
                ImportMappings.Row.TargetField.DynamicControl<DropDown>().Select(mapping.TargetField);
                ImportMappings.Row.SourceObject.DynamicControl<DropDown>().Select(mapping.SourceObj);
                ImportMappings.Row.SourceField.DynamicControl<FormulaCombo>().Type(mapping.SourceField);
            }
            Save();
        }
        public void RemoveImportExportMappingFiltering(string store, params string[] entities)
        {
            OpenScreen();
            foreach (var entity in entities.Any() ? entities : new[] { Entities.SalesOrder, Entities.Customer, Entities.StockItem })
            {
                SetConnectorSettings(entity, store: store);
                ImportMappings.RemoveAllRows();
                ImportFilters.RemoveAllRows();
                ExportMappings.RemoveAllRows();
                ExportFilters.RemoveAllRows();
            }
            Save();
        }
        public void RemoveImportExportAllRows()
        {
            ImportMappings.RemoveAllRows();
            ImportFilters.RemoveAllRows();
            ExportMappings.RemoveAllRows();
            ExportFilters.RemoveAllRows();
        }
        public void SetExportMapping(ConnectorEntity connectorEntity)
        {
            SetConnectorSettings(connectorEntity.EntityType, store: connectorEntity.Store);
            RemoveImportExportAllRows();
            foreach (var mapping in connectorEntity.ExportMapping)
            {
                ExportMappings.New();
                ExportMappings.Row.TargetObject.DynamicControl<DropDown>().Select(mapping.TargetObj);
                ExportMappings.Row.TargetField.DynamicControl<DropDown>().Select(mapping.TargetField);
                ExportMappings.Row.SourceObject.DynamicControl<DropDown>().Select(mapping.SourceObj);
                ExportMappings.Row.SourceField.DynamicControl<FormulaCombo>().Type(mapping.SourceField);
                ExportMappings.CommitRows();
                if (ExportMappings.Row.HasError())
                {
                    var error = ExportMappings.Row.GetError();
                    Log.Error($"Export Mapping error: {error}");
                    ExportMappings.RemoveRow();
                }
            }
        }

        public void ClearImportFilter(ConnectorEntity connectorEntity)
        {
            SetConnectorSettings(connectorEntity.EntityType, store: connectorEntity.Store);
            ImportFilters.RemoveAllRows();
        }
        public void ClearImportMapping(ConnectorEntity connectorEntity = null)
        {
            if (connectorEntity != null)
            {
                SetConnectorSettings(connectorEntity.EntityType, store: connectorEntity.Store);
            }

            var count = ImportMappings.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                ImportMappings.SelectRow(1);
                ImportMappings.Delete();
            }
        }

        public void ClearSyncEntity(string store, params string[] entities)
        {
            OpenScreen();
            foreach (var entity in entities.Any() ? entities : new[] { Entities.SalesOrder, Entities.Customer, Entities.StockItem, Entities.Shipment, Entities.ProductAvailability, Entities.NonStockItem, Entities.TemplateItem })
            {
                SetConnectorSettings(entity, store: store);
                RemoveImportExportAllRows();
                Save();
                ClearSync();
                DeleteConfirmationPanel.EntityName.Type(entity);
                DeleteConfirmationPanel.Continue();
            }
        }
    }
}