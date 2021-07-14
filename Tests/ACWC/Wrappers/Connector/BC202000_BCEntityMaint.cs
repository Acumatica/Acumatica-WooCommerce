using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.FormulaCombo;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Controls.TreeView;
using Core;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ACBC.Tests.Wrappers
{
    
    
    public class BC202000_BCEntityMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_entityfilter_form EntityFilter_form { get; } = new c_entityfilter_form("ctl00_phF_form", "EntityFilter_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_currententity_tab CurrentEntity_tab { get; } = new c_currententity_tab("ctl00_phG_tab", "CurrentEntity_tab");
        protected c_currententity_pxformview1 CurrentEntity_PXFormView1 { get; } = new c_currententity_pxformview1("ctl00_phF_form_PXFormView1", "CurrentEntity_PXFormView1");
        protected c_currententity_pxformview2 CurrentEntity_PXFormView2 { get; } = new c_currententity_pxformview2("ctl00_phF_form_PXFormView2", "CurrentEntity_PXFormView2");
        protected c_currententity_pxformview3 CurrentEntity_PXFormView3 { get; } = new c_currententity_pxformview3("ctl00_phF_form_PXFormView3", "CurrentEntity_PXFormView3");
        protected c_deleteconfirmationpanel_cstformview45 DeleteConfirmationPanel_CstFormView45 { get; } = new c_deleteconfirmationpanel_cstformview45("ctl00_phG_CstSmartPanel44_CstFormView45", "DeleteConfirmationPanel_CstFormView45");
        protected c_startrealtimepanel_pxformview5 StartRealTimePanel_PXFormView5 { get; } = new c_startrealtimepanel_pxformview5("ctl00_phG_PXSmartPanel2_PXFormView5", "StartRealTimePanel_PXFormView5");
        protected c_importmappings_gridimportmapping ImportMappings_gridImportMapping { get; } = new c_importmappings_gridimportmapping("ctl00_phG_tab_t0_gridImportMapping", "ImportMappings_gridImportMapping");
        protected c_importmappings_lv0 ImportMappings_lv0 { get; } = new c_importmappings_lv0("ctl00_phG_tab_t0_gridImportMapping_lv0", "ImportMappings_lv0");
        protected c_exportmappings_gridexportmapping ExportMappings_gridExportMapping { get; } = new c_exportmappings_gridexportmapping("ctl00_phG_tab_t2_gridExportMapping", "ExportMappings_gridExportMapping");
        protected c_exportmappings_lv0 ExportMappings_lv0 { get; } = new c_exportmappings_lv0("ctl00_phG_tab_t2_gridExportMapping_lv0", "ExportMappings_lv0");
        protected c_importfilters_gridimportconditions ImportFilters_gridImportConditions { get; } = new c_importfilters_gridimportconditions("ctl00_phG_tab_t1_gridImportConditions", "ImportFilters_gridImportConditions");
        protected c_importfilters_lv0 ImportFilters_lv0 { get; } = new c_importfilters_lv0("ctl00_phG_tab_t1_gridImportConditions_lv0", "ImportFilters_lv0");
        protected c_exportfilters_gridexportconditions ExportFilters_gridExportConditions { get; } = new c_exportfilters_gridexportconditions("ctl00_phG_tab_t3_gridExportConditions", "ExportFilters_gridExportConditions");
        protected c_exportfilters_lv0 ExportFilters_lv0 { get; } = new c_exportfilters_lv0("ctl00_phG_tab_t3_gridExportConditions_lv0", "ExportFilters_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_parameters Parameters { get; } = new c_parameters("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_cat", "parameters");
        protected c_importmappings_importcsvsettings_frmimportcsvsettings ImportMappings_ImportCSVSettings_frmImportCSVSettings { get; } = new c_importmappings_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings", "ImportMappings$ImportCSVSettings_frmImportCSVSettings");
        protected c_importmappings_importxlsxsettings_frmimportxlsxsettings ImportMappings_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_importmappings_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "ImportMappings$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_importmappings_importcolumns_grdimportcolumn ImportMappings_ImportColumns_grdImportColumn { get; } = new c_importmappings_importcolumns_grdimportcolumn("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn", "ImportMappings$ImportColumns_grdImportColumn");
        protected c_importmappings_importcolumns_lv0 ImportMappings_ImportColumns_lv0 { get; } = new c_importmappings_importcolumns_lv0("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0", "ImportMappings$ImportColumns_lv0");
        protected c_importfilters_importcsvsettings_frmimportcsvsettings ImportFilters_ImportCSVSettings_frmImportCSVSettings { get; } = new c_importfilters_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettings", "ImportFilters$ImportCSVSettings_frmImportCSVSettings");
        protected c_importfilters_importxlsxsettings_frmimportxlsxsettings ImportFilters_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_importfilters_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "ImportFilters$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_importfilters_importcolumns_grdimportcolumn ImportFilters_ImportColumns_grdImportColumn { get; } = new c_importfilters_importcolumns_grdimportcolumn("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn", "ImportFilters$ImportColumns_grdImportColumn");
        protected c_importfilters_importcolumns_lv0 ImportFilters_ImportColumns_lv0 { get; } = new c_importfilters_importcolumns_lv0("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0", "ImportFilters$ImportColumns_lv0");
        protected c_exportmappings_importcsvsettings_frmimportcsvsettings ExportMappings_ImportCSVSettings_frmImportCSVSettings { get; } = new c_exportmappings_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings", "ExportMappings$ImportCSVSettings_frmImportCSVSettings");
        protected c_exportmappings_importxlsxsettings_frmimportxlsxsettings ExportMappings_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_exportmappings_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "ExportMappings$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_exportmappings_importcolumns_grdimportcolumn ExportMappings_ImportColumns_grdImportColumn { get; } = new c_exportmappings_importcolumns_grdimportcolumn("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn", "ExportMappings$ImportColumns_grdImportColumn");
        protected c_exportmappings_importcolumns_lv0 ExportMappings_ImportColumns_lv0 { get; } = new c_exportmappings_importcolumns_lv0("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0", "ExportMappings$ImportColumns_lv0");
        protected c_exportfilters_importcsvsettings_frmimportcsvsettings ExportFilters_ImportCSVSettings_frmImportCSVSettings { get; } = new c_exportfilters_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettings", "ExportFilters$ImportCSVSettings_frmImportCSVSettings");
        protected c_exportfilters_importxlsxsettings_frmimportxlsxsettings ExportFilters_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_exportfilters_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "ExportFilters$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_exportfilters_importcolumns_grdimportcolumn ExportFilters_ImportColumns_grdImportColumn { get; } = new c_exportfilters_importcolumns_grdimportcolumn("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn", "ExportFilters$ImportColumns_grdImportColumn");
        protected c_exportfilters_importcolumns_lv0 ExportFilters_ImportColumns_lv0 { get; } = new c_exportfilters_importcolumns_lv0("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0", "ExportFilters$ImportColumns_lv0");
        
        public BC202000_BCEntityMaint()
        {
            ScreenId = "BC202000";
            ScreenUrl = "/Pages/BC/BC202000.aspx";
            ToolBar = new PxToolBar(null);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Favorites()
        {
            ToolBar.Favorites.Click();
        }
        
        public virtual void Custom()
        {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject()
        {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAltClick()
        {
            ToolBar.InspectElementCtrlAltClick.Click();
        }
        
        public virtual void MenuEditProj()
        {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations()
        {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void KeyBtnRefresh()
        {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help()
        {
            ToolBar.Help.Click();
        }
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void RealtimeStart()
        {
            ToolBar.RealtimeStart.Click();
        }
        
        public virtual void RealtimeStart(bool status, string message = null)
        {
            ToolBar.RealtimeStart.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.RealtimeStart.Click();
        }
        
        public virtual void RealtimeStop()
        {
            ToolBar.RealtimeStop.Click();
        }
        
        public virtual void RealtimeStop(bool status, string message = null)
        {
            ToolBar.RealtimeStop.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.RealtimeStop.Click();
        }
        
        public virtual void ClearSync()
        {
            ToolBar.ClearSync.Click();
        }
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void ElapsedTime()
        {
            ToolBar.ElapsedTime.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton Favorites { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton RealtimeStart { get; }
			public ToolBarButton RealtimeStop { get; }
			public ToolBarButton ClearSync { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                Custom = new ToolBarButton("css=#ctl00_usrCaption_CustomizationDialogs_PXToolBar1 div[data-cmd=\'Custom\']", "Customization", locator, null);
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ActionSelectWorkingProject\']", "Select Project...", locator, Custom);
                InspectElementCtrlAltClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Inspect Element (Ctrl+Alt+Click)\")", "Inspect Element (Ctrl+Alt+Click)", locator, Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Save\']", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                RealtimeStart = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'realtimeStart\']", "Start Real-Time Sync", locator, null);
                RealtimeStart.WaitAction = Wait.WaitForLongOperationToComplete;
                RealtimeStop = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'realtimeStop\']", "Stop Real-Time Sync", locator, null);
                RealtimeStop.WaitAction = Wait.WaitForLongOperationToComplete;
                ClearSync = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'clearSync\']", "Clear Sync Data", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_entityfilter_form : Container
        {
            
			public DropDown ConnectorType { get; }
			public Label ConnectorTypeLabel { get; }
			public Selector BindingID { get; }
			public Label BindingIDLabel { get; }
			public DropDown EntityType { get; }
			public Label EntityTypeLabel { get; }
            
            public c_entityfilter_form(string locator, string name) : 
                    base(locator, name)
            {
                ConnectorType = new DropDown("ctl00_phF_form_CstPXDropDown1", "Connector", locator, null);
                ConnectorTypeLabel = new Label(ConnectorType);
                ConnectorType.DataField = "ConnectorType";
                ConnectorType.Items.Add("BCC", "BigCommerce");
                ConnectorType.Items.Add("SPC", "Shopify");
                BindingID = new Selector("ctl00_phF_form_CstPXSelector25", "Store", locator, null);
                BindingIDLabel = new Label(BindingID);
                BindingID.DataField = "BindingID";
                EntityType = new DropDown("ctl00_phF_form_CstPXDropDown27", "Entity", locator, null);
                EntityTypeLabel = new Label(EntityType);
                EntityType.DataField = "EntityType";
                EntityType.Items.Add("CU", "Customer");
                EntityType.Items.Add("AD", "Customer Location");
                EntityType.Items.Add("IN", "Stock Item");
                EntityType.Items.Add("NS", "Non-Stock Item");
                EntityType.Items.Add("VP", "Template Item");
                EntityType.Items.Add("PI", "Product Image");
                EntityType.Items.Add("PA", "Product Availability");
                EntityType.Items.Add("SO", "Sales Order");
                EntityType.Items.Add("PY", "Payment");
                EntityType.Items.Add("SH", "Shipment");
                EntityType.Items.Add("OR", "Refunds");
                DataMemberName = "EntityFilter";
            }
        }
        
        public class c_parameters_gridwizard : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public CheckBox Override { get; }
			public Label OverrideLabel { get; }
			public Selector RoleName { get; }
			public Label RoleNameLabel { get; }
            
            public c_parameters_gridwizard(string locator, string name) : 
                    base(locator, name)
            {
                IsDefault = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_defaultCkbx", "Is Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Override = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_overrideCkbx", "Override", locator, null);
                OverrideLabel = new Label(Override);
                Override.DataField = "Override";
                RoleName = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_edRole", "Role Name", locator, null);
                RoleNameLabel = new Label(RoleName);
                RoleName.DataField = "RoleName";
                DataMemberName = "Parameters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Cancel { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    Cancel = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_cancel", "Cancel", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Prev = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_prev", "Prev", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Next = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_next", "Next", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Finish = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_save", "Finish", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                }
            }
        }
        
        public class c_firstselect_formactions : Container
        {
            
			public PXTextEdit Key { get; }
			public Label KeyLabel { get; }
            
            public c_firstselect_formactions(string locator, string name) : 
                    base(locator, name)
            {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", locator, null);
                KeyLabel = new Label(Key);
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_comboboxvalues_gridcombos : Grid<c_comboboxvalues_gridcombos.c_grid_row, c_comboboxvalues_gridcombos.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_comboboxvalues_gridcombos(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                DataMemberName = "ComboBoxValues";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    Close = new Button("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_PXButton5", "Close", "ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Value { get; }
			public PXTextEdit Description { get; }
                
                public c_grid_row(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Description = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Description { get; }
                
                public c_grid_header(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                }
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl { get; }
			public Label AspxControlLabel { get; }
			public GroupBox IsComboBox { get; }
			public Label IsComboBoxLabel { get; }
			public PXTextEdit CacheType { get; }
			public Label CacheTypeLabel { get; }
			public PXTextEdit FieldName { get; }
			public Label FieldNameLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit GraphName { get; }
			public Label GraphNameLabel { get; }
			public PXTextEdit ActionName { get; }
			public Label ActionNameLabel { get; }
            
            public c_vieweleminfo_formeleminfo(string locator, string name) : 
                    base(locator, name)
            {
                AspxControl = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_edAspxControl", "Control Type", locator, null);
                AspxControlLabel = new Label(AspxControl);
                AspxControl.DataField = "AspxControl";
                IsComboBox = new GroupBox("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1", "Is Combo Box", locator, null);
                IsComboBoxLabel = new Label(IsComboBox);
                IsComboBox.DataField = "IsComboBox";
                CacheType = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_CacheType", "Data Class", locator, null);
                CacheTypeLabel = new Label(CacheType);
                CacheType.DataField = "CacheType";
                FieldName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_FieldName", "Data Field", locator, null);
                FieldNameLabel = new Label(FieldName);
                FieldName.DataField = "FieldName";
                ViewName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ViewName", "View Name", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                GraphName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_GraphName", "Business Logic", locator, null);
                GraphNameLabel = new Label(GraphName);
                GraphName.DataField = "GraphName";
                ActionName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ActionName", "Action Name", locator, null);
                ActionNameLabel = new Label(ActionName);
                ActionName.DataField = "ActionName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DropDownValues()
            {
                Buttons.DropDownValues.Click();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public virtual void Actions()
            {
                Buttons.Actions.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DropDownValues { get; }
			public Button Customize { get; }
			public Button Actions { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    DropDownValues = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1_P" +
                            "XButton1", "Drop Down Values", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject { get; }
			public Label NewProjectLabel { get; }
            
            public c_filterworkingproject_formnewproject(string locator, string name) : 
                    base(locator, name)
            {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", locator, null);
                NewProjectLabel = new Label(NewProject);
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Name { get; }
			public Label NameLabel { get; }
            
            public c_filterworkingproject_formselectproject(string locator, string name) : 
                    base(locator, name)
            {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void New()
            {
                Buttons.New.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button New { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                }
            }
        }
        
        public class c_gridlist_gridgrid : Grid<c_gridlist_gridgrid.c_grid_row, c_gridlist_gridgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_gridlist_gridgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid");
                DataMemberName = "GridList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit View { get; }
			public PXTextEdit Id { get; }
                
                public c_grid_row(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ef", "Included", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    View = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Table ID", grid.Locator, "View");
                    View.DataField = "View";
                    Id = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Grid ID", grid.Locator, "Id");
                    Id.DataField = "Id";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter View { get; }
				public PXTextEditColumnFilter Id { get; }
                
                public c_grid_header(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    View = new PXTextEditColumnFilter(grid.Row.View);
                    Id = new PXTextEditColumnFilter(grid.Row.Id);
                }
            }
        }
        
        public class c_userlist_usergrid : Grid<c_userlist_usergrid.c_grid_row, c_userlist_usergrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_userlist_usergrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid");
                DataMemberName = "UserList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Included { get; }
			public Selector Username { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Email { get; }
			public PXTextEdit Guest { get; }
			public DropDown State { get; }
                
                public c_grid_row(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Username = new Selector("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    DisplayName = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Display Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Email = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Guest = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Guest Account", grid.Locator, "Guest");
                    Guest.DataField = "Guest";
                    State = new DropDown("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Status", grid.Locator, "State");
                    State.DataField = "State";
                    State.Items.Add("N", "Not Created");
                    State.Items.Add("O", "Online");
                    State.Items.Add("P", "Pending Activation");
                    State.Items.Add("D", "Disabled");
                    State.Items.Add("A", "Active");
                    State.Items.Add("L", "Temporarily Locked");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Included { get; }
				public SelectorColumnFilter Username { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Email { get; }
				public PXTextEditColumnFilter Guest { get; }
				public DropDownColumnFilter State { get; }
                
                public c_grid_header(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    Username = new SelectorColumnFilter(grid.Row.Username);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Guest = new PXTextEditColumnFilter(grid.Row.Guest);
                    State = new DropDownColumnFilter(grid.Row.State);
                }
            }
        }
        
        public class c_userlist_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_userlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "UserList";
            }
        }
        
        public class c_currententity_tab : Container
        {
            
			public Label LblValidate_ { get; }
			public Label Label1_importColumnDlg { get; }
			public Label LblImportSource_ { get; }
			public Label LblPassword_ { get; }
			public Label Label1_importColumnDlg2 { get; }
			public Label LblImportSource_2 { get; }
			public Label LblPassword_2 { get; }
			public Label LblValidate_2 { get; }
			public Label Label1_importColumnDlg3 { get; }
			public Label LblImportSource_3 { get; }
			public Label LblPassword_3 { get; }
			public Label Label1_importColumnDlg4 { get; }
			public Label LblImportSource_4 { get; }
			public Label LblPassword_4 { get; }
            
            public c_currententity_tab(string locator, string name) : 
                    base(locator, name)
            {
                LblValidate_ = new Label("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_lblVal" +
                        "idate", "Lbl Validate _", locator, null);
                Label1_importColumnDlg = new Label("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_ = new Label("ctl00_phG_tab_t0_gridImportMapping_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_ = new Label("ctl00_phG_tab_t0_gridImportMapping_imp_upl_pnl_lblPassword", "Password:", locator, null);
                Label1_importColumnDlg2 = new Label("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_2 = new Label("ctl00_phG_tab_t1_gridImportConditions_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_2 = new Label("ctl00_phG_tab_t1_gridImportConditions_imp_upl_pnl_lblPassword", "Password:", locator, null);
                LblValidate_2 = new Label("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_lblVal" +
                        "idate", "Lbl Validate _2", locator, null);
                Label1_importColumnDlg3 = new Label("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_3 = new Label("ctl00_phG_tab_t2_gridExportMapping_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_3 = new Label("ctl00_phG_tab_t2_gridExportMapping_imp_upl_pnl_lblPassword", "Password:", locator, null);
                Label1_importColumnDlg4 = new Label("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_4 = new Label("ctl00_phG_tab_t3_gridExportConditions_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_4 = new Label("ctl00_phG_tab_t3_gridExportConditions_imp_upl_pnl_lblPassword", "Password:", locator, null);
                DataMemberName = "CurrentEntity";
            }
        }
        
        public class c_currententity_pxformview1 : Container
        {
            
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
            
            public c_currententity_pxformview1(string locator, string name) : 
                    base(locator, name)
            {
                IsActive = new CheckBox("ctl00_phF_form_PXFormView1_CstPXCheckBox10", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                DataMemberName = "CurrentEntity";
            }
        }
        
        public class c_currententity_pxformview2 : Container
        {
            
			public DropDown Direction { get; }
			public Label DirectionLabel { get; }
			public DropDown PrimarySystem { get; }
			public Label PrimarySystemLabel { get; }
			public PXNumberEdit MaxAttemptCount { get; }
			public Label MaxAttemptCountLabel { get; }
			public CheckBox AutoMergeDuplicates { get; }
			public Label AutoMergeDuplicatesLabel { get; }
			public CheckBox ParallelProcessing { get; }
			public Label ParallelProcessingLabel { get; }
            
            public c_currententity_pxformview2(string locator, string name) : 
                    base(locator, name)
            {
                Direction = new DropDown("ctl00_phF_form_PXFormView2_CstPXDropDown11", "Sync Direction", locator, null);
                DirectionLabel = new Label(Direction);
                Direction.DataField = "Direction";
                Direction.Items.Add("B", "Bidirectional");
                Direction.Items.Add("I", "Import");
                Direction.Items.Add("E", "Export");
                PrimarySystem = new DropDown("ctl00_phF_form_PXFormView2_CstPXDropDown12", "Primary System", locator, null);
                PrimarySystemLabel = new Label(PrimarySystem);
                PrimarySystem.DataField = "PrimarySystem";
                PrimarySystem.Items.Add("L", "Local");
                PrimarySystem.Items.Add("E", "External");
                MaxAttemptCount = new PXNumberEdit("ctl00_phF_form_PXFormView2_CstPXNumberEdit5", "Max. Number of Failed Attempts", locator, null);
                MaxAttemptCountLabel = new Label(MaxAttemptCount);
                MaxAttemptCount.DataField = "MaxAttemptCount";
                AutoMergeDuplicates = new CheckBox("ctl00_phF_form_PXFormView2_CstPXCheckBox42", "Merge Duplicate", locator, null);
                AutoMergeDuplicatesLabel = new Label(AutoMergeDuplicates);
                AutoMergeDuplicates.DataField = "AutoMergeDuplicates";
                ParallelProcessing = new CheckBox("ctl00_phF_form_PXFormView2_CstPXCheckBox43", "Parallel Processing", locator, null);
                ParallelProcessingLabel = new Label(ParallelProcessing);
                ParallelProcessing.DataField = "ParallelProcessing";
                DataMemberName = "CurrentEntity";
            }
        }
        
        public class c_currententity_pxformview3 : Container
        {
            
			public DropDown ImportRealTimeStatus { get; }
			public Label ImportRealTimeStatusLabel { get; }
			public DropDown ExportRealTimeStatus { get; }
			public Label ExportRealTimeStatusLabel { get; }
			public DropDown RealTimeMode { get; }
			public Label RealTimeModeLabel { get; }
			public PXTextEdit RealTimeBaseURL { get; }
			public Label RealTimeBaseURLLabel { get; }
            
            public c_currententity_pxformview3(string locator, string name) : 
                    base(locator, name)
            {
                ImportRealTimeStatus = new DropDown("ctl00_phF_form_PXFormView3_CstPXDropDown35", "Real-Time Import", locator, null);
                ImportRealTimeStatusLabel = new Label(ImportRealTimeStatus);
                ImportRealTimeStatus.DataField = "ImportRealTimeStatus";
                ImportRealTimeStatus.Items.Add("R", "Running");
                ImportRealTimeStatus.Items.Add("S", "Stopped");
                ImportRealTimeStatus.Items.Add("E", "Stopped Due to an Error");
                ImportRealTimeStatus.Items.Add("N", "Not Supported");
                ExportRealTimeStatus = new DropDown("ctl00_phF_form_PXFormView3_CstPXDropDown34", "Real-Time Export", locator, null);
                ExportRealTimeStatusLabel = new Label(ExportRealTimeStatus);
                ExportRealTimeStatus.DataField = "ExportRealTimeStatus";
                ExportRealTimeStatus.Items.Add("R", "Running");
                ExportRealTimeStatus.Items.Add("S", "Stopped");
                ExportRealTimeStatus.Items.Add("E", "Stopped Due to an Error");
                ExportRealTimeStatus.Items.Add("N", "Not Supported");
                RealTimeMode = new DropDown("ctl00_phF_form_PXFormView3_CstPXCheckBox17", "Real-Time Mode", locator, null);
                RealTimeModeLabel = new Label(RealTimeMode);
                RealTimeMode.DataField = "RealTimeMode";
                RealTimeMode.Items.Add("F", "Prepare");
                RealTimeMode.Items.Add("S", "Prepare & Process");
                RealTimeBaseURL = new PXTextEdit("ctl00_phF_form_PXFormView3_edRealTimeBaseURL", "Real-Time Webhook URL", locator, null);
                RealTimeBaseURLLabel = new Label(RealTimeBaseURL);
                RealTimeBaseURL.DataField = "RealTimeBaseURL";
                DataMemberName = "CurrentEntity";
            }
        }
        
        public class c_deleteconfirmationpanel_cstformview45 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit EntityName { get; }
			public Label EntityNameLabel { get; }
			public Label CstLabel51_ { get; }
			public Label CstLabel52_ { get; }
            
            public c_deleteconfirmationpanel_cstformview45(string locator, string name) : 
                    base(locator, name)
            {
                EntityName = new PXTextEdit("ctl00_phG_CstSmartPanel44_CstFormView45_CstPXTextEdit46", "Entity Name", locator, null);
                EntityNameLabel = new Label(EntityName);
                EntityName.DataField = "EntityName";
                CstLabel51_ = new Label("ctl00_phG_CstSmartPanel44_CstFormView45_CstLabel51", "Are you sure you want to delete all synchronization data for the entity? This ope" +
                        "ration cannot be undone.", locator, null);
                CstLabel52_ = new Label("ctl00_phG_CstSmartPanel44_CstFormView45_CstLabel52", "Please enter the Entity Name to confirm.", locator, null);
                DataMemberName = "DeleteConfirmationPanel";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Continue()
            {
                Buttons.Continue.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Continue { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Continue = new Button("ctl00_phG_CstSmartPanel44_CstButton49", "Continue", "ctl00_phG_CstSmartPanel44_CstFormView45");
                    Cancel = new Button("ctl00_phG_CstSmartPanel44_CstButton50", "Cancel", "ctl00_phG_CstSmartPanel44_CstFormView45");
                }
            }
        }
        
        public class c_startrealtimepanel_pxformview5 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit RealTimeURL { get; }
			public Label RealTimeURLLabel { get; }
			public Label CstLabel54_ { get; }
			public Label CstLabel55_ { get; }
            
            public c_startrealtimepanel_pxformview5(string locator, string name) : 
                    base(locator, name)
            {
                RealTimeURL = new PXTextEdit("ctl00_phG_PXSmartPanel2_PXFormView5_CstPXTextEdit47", "Real-Time Webhook URL", locator, null);
                RealTimeURLLabel = new Label(RealTimeURL);
                RealTimeURL.DataField = "RealTimeURL";
                CstLabel54_ = new Label("ctl00_phG_PXSmartPanel2_PXFormView5_CstLabel54", "This webhook URL will be used to receive push notifications from the external sys" +
                        "tem.", locator, null);
                CstLabel55_ = new Label("ctl00_phG_PXSmartPanel2_PXFormView5_CstLabel55", "Please make sure that the URL is correct and click Continue to proceed.", locator, null);
                DataMemberName = "StartRealTimePanel";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Continue()
            {
                Buttons.Continue.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Continue { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Continue = new Button("ctl00_phG_PXSmartPanel2_CstButton51", "Continue", "ctl00_phG_PXSmartPanel2_PXFormView5");
                    Cancel = new Button("ctl00_phG_PXSmartPanel2_CstButton52", "Cancel", "ctl00_phG_PXSmartPanel2_PXFormView5");
                }
            }
        }
        
        public class c_importmappings_gridimportmapping : Grid<c_importmappings_gridimportmapping.c_grid_row, c_importmappings_gridimportmapping.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_importmappings_gridimportmapping(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_gridImportMapping");
                DataMemberName = "ImportMappings";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t0_gridImportMapping_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_gridImportMapping_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Upload()
            {
                ToolBar.Upload.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void Validate()
            {
                Buttons.Validate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok3()
            {
                Buttons.Ok3.Click();
            }
            
            public virtual void Cancel3()
            {
                Buttons.Cancel3.Click();
            }
            
            public virtual void Upload1()
            {
                Buttons.Upload1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridImportMapping_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Validate { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok3 { get; }
			public Button Cancel3 { get; }
			public Button Upload1 { get; }
                
                public PxButtonCollection()
                {
                    Validate = new Button("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_btnVal" +
                            "idate", "Validate", "ctl00_phG_tab_t0_gridImportMapping");
                    Ok = new Button("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_btnSav" +
                            "eExp", "OK", "ctl00_phG_tab_t0_gridImportMapping");
                    Cancel = new Button("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_btnCan" +
                            "celExp", "Cancel", "ctl00_phG_tab_t0_gridImportMapping");
                    Ok1 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_gridImportMapping");
                    Cancel1 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_gridImportMapping");
                    Ok2 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_gridImportMapping");
                    Cancel2 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_gridImportMapping");
                    First = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_gridImportMapping");
                    Prev = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridImportMapping");
                    Next = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_gridImportMapping");
                    Last = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_gridImportMapping");
                    Ok3 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_gridImportMapping");
                    Cancel3 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_gridImportMapping");
                    Upload1 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t0_gridImportMapping");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXNumberEdit SortOrder { get; }
			public CheckBox IsActive { get; }
			public PXTextEdit TargetObject { get; }
			public PXTextEdit TargetField { get; }
			public PXTextEdit SourceObject { get; }
			public PXTextEdit SourceField { get; }
			public PXTextEdit ConnectorType { get; }
			public PXNumberEdit BindingID { get; }
			public PXTextEdit EntityType { get; }
			public PXNumberEdit ImportMappingID { get; }
                
                public c_grid_row(c_importmappings_gridimportmapping grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t0_gridImportMapping_en", "Line Nbr.", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    IsActive = new CheckBox("ctl00_phG_tab_t0_gridImportMapping_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    TargetObject = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_ei", "Target Object", grid.Locator, "TargetObject");
                    TargetObject.DataField = "TargetObject";
                    TargetField = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_ei", "Target Field", grid.Locator, "TargetField");
                    TargetField.DataField = "TargetField";
                    SourceObject = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_ei", "Source Object", grid.Locator, "SourceObject");
                    SourceObject.DataField = "SourceObject";
                    SourceField = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_ei", "Source Field / Value", grid.Locator, "SourceField");
                    SourceField.DataField = "SourceField";
                    ConnectorType = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_ei", "ConnectorType", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    BindingID = new PXNumberEdit("ctl00_phG_tab_t0_gridImportMapping_en", "BindingID", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                    EntityType = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_ei", "EntityType", grid.Locator, "EntityType");
                    EntityType.DataField = "EntityType";
                    ImportMappingID = new PXNumberEdit("ctl00_phG_tab_t0_gridImportMapping_en", "ImportMappingID", grid.Locator, "ImportMappingID");
                    ImportMappingID.DataField = "ImportMappingID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public PXTextEditColumnFilter TargetObject { get; }
				public PXTextEditColumnFilter TargetField { get; }
				public PXTextEditColumnFilter SourceObject { get; }
				public PXTextEditColumnFilter SourceField { get; }
				public PXTextEditColumnFilter ConnectorType { get; }
				public PXNumberEditColumnFilter BindingID { get; }
				public PXTextEditColumnFilter EntityType { get; }
				public PXNumberEditColumnFilter ImportMappingID { get; }
                
                public c_grid_header(c_importmappings_gridimportmapping grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    TargetObject = new PXTextEditColumnFilter(grid.Row.TargetObject);
                    TargetField = new PXTextEditColumnFilter(grid.Row.TargetField);
                    SourceObject = new PXTextEditColumnFilter(grid.Row.SourceObject);
                    SourceField = new PXTextEditColumnFilter(grid.Row.SourceField);
                    ConnectorType = new PXTextEditColumnFilter(grid.Row.ConnectorType);
                    BindingID = new PXNumberEditColumnFilter(grid.Row.BindingID);
                    EntityType = new PXTextEditColumnFilter(grid.Row.EntityType);
                    ImportMappingID = new PXNumberEditColumnFilter(grid.Row.ImportMappingID);
                }
            }
        }
        
        public class c_importmappings_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public FormulaCombo Value { get; }
			public Label ValueLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
			public Label LblValidate_ { get; }
            
            public c_importmappings_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Value = new FormulaCombo("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField", "Value", locator, null);
                ValueLabel = new Label(Value);
                Value.DataField = "Value";
                Ed = new DateSelector("ctl00_phG_tab_t0_gridImportMapping_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_gridImportMapping_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t0_gridImportMapping_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t0_gridImportMapping_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                LblValidate_ = new Label("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_lblVal" +
                        "idate", "Lbl Validate _", locator, null);
                DataMemberName = "ImportMappings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Validate()
            {
                Buttons.Validate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok3()
            {
                Buttons.Ok3.Click();
            }
            
            public virtual void Cancel3()
            {
                Buttons.Cancel3.Click();
            }
            
            public virtual void Upload()
            {
                Buttons.Upload.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Validate { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok3 { get; }
			public Button Cancel3 { get; }
			public Button Upload { get; }
                
                public PxButtonCollection()
                {
                    Validate = new Button("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_btnVal" +
                            "idate", "Validate", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Ok = new Button("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_btnSav" +
                            "eExp", "OK", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Cancel = new Button("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_btnCan" +
                            "celExp", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    First = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Next = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Last = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Ok3 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Cancel3 = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                    Upload = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t0_gridImportMapping_lv0");
                }
            }
        }
        
        public class c_exportmappings_gridexportmapping : Grid<c_exportmappings_gridexportmapping.c_grid_row, c_exportmappings_gridexportmapping.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_exportmappings_gridexportmapping(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_gridExportMapping");
                DataMemberName = "ExportMappings";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t2_gridExportMapping_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_gridExportMapping_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Upload()
            {
                ToolBar.Upload.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void Validate()
            {
                Buttons.Validate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok3()
            {
                Buttons.Ok3.Click();
            }
            
            public virtual void Cancel3()
            {
                Buttons.Cancel3.Click();
            }
            
            public virtual void Upload1()
            {
                Buttons.Upload1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridExportMapping_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Validate { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok3 { get; }
			public Button Cancel3 { get; }
			public Button Upload1 { get; }
                
                public PxButtonCollection()
                {
                    Validate = new Button("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_btnVal" +
                            "idate", "Validate", "ctl00_phG_tab_t2_gridExportMapping");
                    Ok = new Button("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_btnSav" +
                            "eExp", "OK", "ctl00_phG_tab_t2_gridExportMapping");
                    Cancel = new Button("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_btnCan" +
                            "celExp", "Cancel", "ctl00_phG_tab_t2_gridExportMapping");
                    Ok1 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t2_gridExportMapping");
                    Cancel1 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t2_gridExportMapping");
                    Ok2 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t2_gridExportMapping");
                    Cancel2 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t2_gridExportMapping");
                    First = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridExportMapping");
                    Prev = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridExportMapping");
                    Next = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridExportMapping");
                    Last = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridExportMapping");
                    Ok3 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridExportMapping");
                    Cancel3 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridExportMapping");
                    Upload1 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t2_gridExportMapping");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXNumberEdit SortOrder { get; }
			public CheckBox IsActive { get; }
			public PXTextEdit TargetObject { get; }
			public PXTextEdit TargetField { get; }
			public PXTextEdit SourceObject { get; }
			public PXTextEdit SourceField { get; }
			public PXTextEdit ConnectorType { get; }
			public PXNumberEdit BindingID { get; }
			public PXTextEdit EntityType { get; }
			public PXNumberEdit ExportMappingID { get; }
                
                public c_grid_row(c_exportmappings_gridexportmapping grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t2_gridExportMapping_en", "Line Nbr.", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    IsActive = new CheckBox("ctl00_phG_tab_t2_gridExportMapping_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    TargetObject = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_ei", "Target Object", grid.Locator, "TargetObject");
                    TargetObject.DataField = "TargetObject";
                    TargetField = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_ei", "Target Field", grid.Locator, "TargetField");
                    TargetField.DataField = "TargetField";
                    SourceObject = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_ei", "Source Object", grid.Locator, "SourceObject");
                    SourceObject.DataField = "SourceObject";
                    SourceField = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_ei", "Source Field / Value", grid.Locator, "SourceField");
                    SourceField.DataField = "SourceField";
                    ConnectorType = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_ei", "ConnectorType", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    BindingID = new PXNumberEdit("ctl00_phG_tab_t2_gridExportMapping_en", "BindingID", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                    EntityType = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_ei", "EntityType", grid.Locator, "EntityType");
                    EntityType.DataField = "EntityType";
                    ExportMappingID = new PXNumberEdit("ctl00_phG_tab_t2_gridExportMapping_en", "ExportMappingID", grid.Locator, "ExportMappingID");
                    ExportMappingID.DataField = "ExportMappingID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public PXTextEditColumnFilter TargetObject { get; }
				public PXTextEditColumnFilter TargetField { get; }
				public PXTextEditColumnFilter SourceObject { get; }
				public PXTextEditColumnFilter SourceField { get; }
				public PXTextEditColumnFilter ConnectorType { get; }
				public PXNumberEditColumnFilter BindingID { get; }
				public PXTextEditColumnFilter EntityType { get; }
				public PXNumberEditColumnFilter ExportMappingID { get; }
                
                public c_grid_header(c_exportmappings_gridexportmapping grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    TargetObject = new PXTextEditColumnFilter(grid.Row.TargetObject);
                    TargetField = new PXTextEditColumnFilter(grid.Row.TargetField);
                    SourceObject = new PXTextEditColumnFilter(grid.Row.SourceObject);
                    SourceField = new PXTextEditColumnFilter(grid.Row.SourceField);
                    ConnectorType = new PXTextEditColumnFilter(grid.Row.ConnectorType);
                    BindingID = new PXNumberEditColumnFilter(grid.Row.BindingID);
                    EntityType = new PXTextEditColumnFilter(grid.Row.EntityType);
                    ExportMappingID = new PXNumberEditColumnFilter(grid.Row.ExportMappingID);
                }
            }
        }
        
        public class c_exportmappings_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public FormulaCombo Value { get; }
			public Label ValueLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
			public Label LblValidate_ { get; }
            
            public c_exportmappings_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Value = new FormulaCombo("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField", "Value", locator, null);
                ValueLabel = new Label(Value);
                Value.DataField = "Value";
                Ed = new DateSelector("ctl00_phG_tab_t2_gridExportMapping_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t2_gridExportMapping_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t2_gridExportMapping_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t2_gridExportMapping_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                LblValidate_ = new Label("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_lblVal" +
                        "idate", "Lbl Validate _", locator, null);
                DataMemberName = "ExportMappings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Validate()
            {
                Buttons.Validate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok3()
            {
                Buttons.Ok3.Click();
            }
            
            public virtual void Cancel3()
            {
                Buttons.Cancel3.Click();
            }
            
            public virtual void Upload()
            {
                Buttons.Upload.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Validate { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok3 { get; }
			public Button Cancel3 { get; }
			public Button Upload { get; }
                
                public PxButtonCollection()
                {
                    Validate = new Button("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_btnVal" +
                            "idate", "Validate", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Ok = new Button("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_btnSav" +
                            "eExp", "OK", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Cancel = new Button("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_btnCan" +
                            "celExp", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    First = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Prev = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Next = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Last = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Ok3 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Cancel3 = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                    Upload = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t2_gridExportMapping_lv0");
                }
            }
        }
        
        public class c_importfilters_gridimportconditions : Grid<c_importfilters_gridimportconditions.c_grid_row, c_importfilters_gridimportconditions.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_importfilters_gridimportconditions(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_gridImportConditions");
                DataMemberName = "ImportFilters";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t1_gridImportConditions_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_gridImportConditions_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Upload()
            {
                ToolBar.Upload.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload1()
            {
                Buttons.Upload1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridImportConditions_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload1 { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t1_gridImportConditions");
                    Cancel = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t1_gridImportConditions");
                    Ok1 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t1_gridImportConditions");
                    Cancel1 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t1_gridImportConditions");
                    First = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t1_gridImportConditions");
                    Prev = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t1_gridImportConditions");
                    Next = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t1_gridImportConditions");
                    Last = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t1_gridImportConditions");
                    Ok2 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridImportConditions");
                    Cancel2 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridImportConditions");
                    Upload1 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t1_gridImportConditions");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXNumberEdit SortOrder { get; }
			public CheckBox IsActive { get; }
			public DropDown OpenBrackets { get; }
			public DropDown FieldName { get; }
			public DropDown Condition { get; }
			public CheckBox IsRelative { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit Value2 { get; }
			public DropDown CloseBrackets { get; }
			public DropDown Operator { get; }
			public PXTextEdit ConnectorType { get; }
			public PXNumberEdit BindingID { get; }
			public PXTextEdit EntityType { get; }
			public PXNumberEdit ImportFilterID { get; }
                
                public c_grid_row(c_importfilters_gridimportconditions grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t1_gridImportConditions_en", "Line Nbr.", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    IsActive = new CheckBox("ctl00_phG_tab_t1_gridImportConditions_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    OpenBrackets = new DropDown("_ctl00_phG_tab_t1_gridImportConditions_lv0_ec", "Brackets", grid.Locator, "OpenBrackets");
                    OpenBrackets.DataField = "OpenBrackets";
                    OpenBrackets.Items.Add("0", "-");
                    OpenBrackets.Items.Add("1", "(");
                    OpenBrackets.Items.Add("2", "((");
                    OpenBrackets.Items.Add("3", "(((");
                    OpenBrackets.Items.Add("4", "((((");
                    OpenBrackets.Items.Add("5", "(((((");
                    FieldName = new DropDown("_ctl00_phG_tab_t1_gridImportConditions_lv0_ec", "Field Name", grid.Locator, "FieldName");
                    FieldName.DataField = "FieldName";
                    Condition = new DropDown("_ctl00_phG_tab_t1_gridImportConditions_lv0_ec", "Condition", grid.Locator, "Condition");
                    Condition.DataField = "Condition";
                    Condition.Items.Add("0", "Equals");
                    Condition.Items.Add("1", "Does Not Equal");
                    Condition.Items.Add("2", "Is Greater Than");
                    Condition.Items.Add("3", "Is Greater Than or Equal To");
                    Condition.Items.Add("4", "Is Less Than");
                    Condition.Items.Add("5", "Is Less Than or Equal To");
                    Condition.Items.Add("6", "Contains");
                    Condition.Items.Add("7", "Ends With");
                    Condition.Items.Add("8", "Starts With");
                    Condition.Items.Add("9", "Does Not Contain");
                    Condition.Items.Add("10", "Is Between");
                    Condition.Items.Add("11", "Is Empty");
                    Condition.Items.Add("12", "Is Not Empty");
                    IsRelative = new CheckBox("ctl00_phG_tab_t1_gridImportConditions_ef", "Is Relative", grid.Locator, "IsRelative");
                    IsRelative.DataField = "IsRelative";
                    Value = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Value2 = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_ei", "Value 2", grid.Locator, "Value2");
                    Value2.DataField = "Value2";
                    CloseBrackets = new DropDown("_ctl00_phG_tab_t1_gridImportConditions_lv0_ec", "Brackets", grid.Locator, "CloseBrackets");
                    CloseBrackets.DataField = "CloseBrackets";
                    CloseBrackets.Items.Add("0", "-");
                    CloseBrackets.Items.Add("1", ")");
                    CloseBrackets.Items.Add("2", "))");
                    CloseBrackets.Items.Add("3", ")))");
                    CloseBrackets.Items.Add("4", "))))");
                    CloseBrackets.Items.Add("5", ")))))");
                    Operator = new DropDown("_ctl00_phG_tab_t1_gridImportConditions_lv0_ec", "Operator", grid.Locator, "Operator");
                    Operator.DataField = "Operator";
                    Operator.Items.Add("0", "And");
                    Operator.Items.Add("1", "Or");
                    ConnectorType = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_ei", "ConnectorType", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    BindingID = new PXNumberEdit("ctl00_phG_tab_t1_gridImportConditions_en", "BindingID", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                    EntityType = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_ei", "EntityType", grid.Locator, "EntityType");
                    EntityType.DataField = "EntityType";
                    ImportFilterID = new PXNumberEdit("ctl00_phG_tab_t1_gridImportConditions_en", "ImportFilterID", grid.Locator, "ImportFilterID");
                    ImportFilterID.DataField = "ImportFilterID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public DropDownColumnFilter OpenBrackets { get; }
				public InputColumnFilter FieldName { get; }
				public DropDownColumnFilter Condition { get; }
				public CheckBoxColumnFilter IsRelative { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Value2 { get; }
				public DropDownColumnFilter CloseBrackets { get; }
				public DropDownColumnFilter Operator { get; }
				public PXTextEditColumnFilter ConnectorType { get; }
				public PXNumberEditColumnFilter BindingID { get; }
				public PXTextEditColumnFilter EntityType { get; }
				public PXNumberEditColumnFilter ImportFilterID { get; }
                
                public c_grid_header(c_importfilters_gridimportconditions grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    OpenBrackets = new DropDownColumnFilter(grid.Row.OpenBrackets);
                    FieldName = new InputColumnFilter(grid.Row.FieldName);
                    Condition = new DropDownColumnFilter(grid.Row.Condition);
                    IsRelative = new CheckBoxColumnFilter(grid.Row.IsRelative);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Value2 = new PXTextEditColumnFilter(grid.Row.Value2);
                    CloseBrackets = new DropDownColumnFilter(grid.Row.CloseBrackets);
                    Operator = new DropDownColumnFilter(grid.Row.Operator);
                    ConnectorType = new PXTextEditColumnFilter(grid.Row.ConnectorType);
                    BindingID = new PXNumberEditColumnFilter(grid.Row.BindingID);
                    EntityType = new PXTextEditColumnFilter(grid.Row.EntityType);
                    ImportFilterID = new PXNumberEditColumnFilter(grid.Row.ImportFilterID);
                }
            }
        }
        
        public class c_importfilters_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_importfilters_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t1_gridImportConditions_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t1_gridImportConditions_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t1_gridImportConditions_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t1_gridImportConditions_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ImportFilters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload()
            {
                Buttons.Upload.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Cancel = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    First = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Next = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Last = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                    Upload = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t1_gridImportConditions_lv0");
                }
            }
        }
        
        public class c_exportfilters_gridexportconditions : Grid<c_exportfilters_gridexportconditions.c_grid_row, c_exportfilters_gridexportconditions.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_exportfilters_gridexportconditions(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_gridExportConditions");
                DataMemberName = "ExportFilters";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t3_gridExportConditions_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_gridExportConditions_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Upload()
            {
                ToolBar.Upload.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload1()
            {
                Buttons.Upload1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridExportConditions_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload1 { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t3_gridExportConditions");
                    Cancel = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t3_gridExportConditions");
                    Ok1 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t3_gridExportConditions");
                    Cancel1 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t3_gridExportConditions");
                    First = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t3_gridExportConditions");
                    Prev = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t3_gridExportConditions");
                    Next = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t3_gridExportConditions");
                    Last = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t3_gridExportConditions");
                    Ok2 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t3_gridExportConditions");
                    Cancel2 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t3_gridExportConditions");
                    Upload1 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t3_gridExportConditions");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXNumberEdit SortOrder { get; }
			public CheckBox IsActive { get; }
			public DropDown OpenBrackets { get; }
			public DropDown FieldName { get; }
			public DropDown Condition { get; }
			public CheckBox IsRelative { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit Value2 { get; }
			public DropDown CloseBrackets { get; }
			public DropDown Operator { get; }
			public PXTextEdit ConnectorType { get; }
			public PXNumberEdit BindingID { get; }
			public PXTextEdit EntityType { get; }
			public PXNumberEdit ExportFilterID { get; }
                
                public c_grid_row(c_exportfilters_gridexportconditions grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t3_gridExportConditions_en", "Line Nbr.", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    IsActive = new CheckBox("ctl00_phG_tab_t3_gridExportConditions_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    OpenBrackets = new DropDown("_ctl00_phG_tab_t3_gridExportConditions_lv0_ec", "Brackets", grid.Locator, "OpenBrackets");
                    OpenBrackets.DataField = "OpenBrackets";
                    OpenBrackets.Items.Add("0", "-");
                    OpenBrackets.Items.Add("1", "(");
                    OpenBrackets.Items.Add("2", "((");
                    OpenBrackets.Items.Add("3", "(((");
                    OpenBrackets.Items.Add("4", "((((");
                    OpenBrackets.Items.Add("5", "(((((");
                    FieldName = new DropDown("_ctl00_phG_tab_t3_gridExportConditions_lv0_ec", "Field Name", grid.Locator, "FieldName");
                    FieldName.DataField = "FieldName";
                    Condition = new DropDown("_ctl00_phG_tab_t3_gridExportConditions_lv0_ec", "Condition", grid.Locator, "Condition");
                    Condition.DataField = "Condition";
                    Condition.Items.Add("0", "Equals");
                    Condition.Items.Add("1", "Does Not Equal");
                    Condition.Items.Add("2", "Is Greater Than");
                    Condition.Items.Add("3", "Is Greater Than or Equal To");
                    Condition.Items.Add("4", "Is Less Than");
                    Condition.Items.Add("5", "Is Less Than or Equal To");
                    Condition.Items.Add("6", "Contains");
                    Condition.Items.Add("7", "Ends With");
                    Condition.Items.Add("8", "Starts With");
                    Condition.Items.Add("9", "Does Not Contain");
                    Condition.Items.Add("10", "Is Between");
                    Condition.Items.Add("11", "Is Empty");
                    Condition.Items.Add("12", "Is Not Empty");
                    IsRelative = new CheckBox("ctl00_phG_tab_t3_gridExportConditions_ef", "Is Relative", grid.Locator, "IsRelative");
                    IsRelative.DataField = "IsRelative";
                    Value = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Value2 = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_ei", "Value 2", grid.Locator, "Value2");
                    Value2.DataField = "Value2";
                    CloseBrackets = new DropDown("_ctl00_phG_tab_t3_gridExportConditions_lv0_ec", "Brackets", grid.Locator, "CloseBrackets");
                    CloseBrackets.DataField = "CloseBrackets";
                    CloseBrackets.Items.Add("0", "-");
                    CloseBrackets.Items.Add("1", ")");
                    CloseBrackets.Items.Add("2", "))");
                    CloseBrackets.Items.Add("3", ")))");
                    CloseBrackets.Items.Add("4", "))))");
                    CloseBrackets.Items.Add("5", ")))))");
                    Operator = new DropDown("_ctl00_phG_tab_t3_gridExportConditions_lv0_ec", "Operator", grid.Locator, "Operator");
                    Operator.DataField = "Operator";
                    Operator.Items.Add("0", "And");
                    Operator.Items.Add("1", "Or");
                    ConnectorType = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_ei", "ConnectorType", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    BindingID = new PXNumberEdit("ctl00_phG_tab_t3_gridExportConditions_en", "BindingID", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                    EntityType = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_ei", "EntityType", grid.Locator, "EntityType");
                    EntityType.DataField = "EntityType";
                    ExportFilterID = new PXNumberEdit("ctl00_phG_tab_t3_gridExportConditions_en", "ExportFilterID", grid.Locator, "ExportFilterID");
                    ExportFilterID.DataField = "ExportFilterID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public DropDownColumnFilter OpenBrackets { get; }
				public InputColumnFilter FieldName { get; }
				public DropDownColumnFilter Condition { get; }
				public CheckBoxColumnFilter IsRelative { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Value2 { get; }
				public DropDownColumnFilter CloseBrackets { get; }
				public DropDownColumnFilter Operator { get; }
				public PXTextEditColumnFilter ConnectorType { get; }
				public PXNumberEditColumnFilter BindingID { get; }
				public PXTextEditColumnFilter EntityType { get; }
				public PXNumberEditColumnFilter ExportFilterID { get; }
                
                public c_grid_header(c_exportfilters_gridexportconditions grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    OpenBrackets = new DropDownColumnFilter(grid.Row.OpenBrackets);
                    FieldName = new InputColumnFilter(grid.Row.FieldName);
                    Condition = new DropDownColumnFilter(grid.Row.Condition);
                    IsRelative = new CheckBoxColumnFilter(grid.Row.IsRelative);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Value2 = new PXTextEditColumnFilter(grid.Row.Value2);
                    CloseBrackets = new DropDownColumnFilter(grid.Row.CloseBrackets);
                    Operator = new DropDownColumnFilter(grid.Row.Operator);
                    ConnectorType = new PXTextEditColumnFilter(grid.Row.ConnectorType);
                    BindingID = new PXNumberEditColumnFilter(grid.Row.BindingID);
                    EntityType = new PXTextEditColumnFilter(grid.Row.EntityType);
                    ExportFilterID = new PXNumberEditColumnFilter(grid.Row.ExportFilterID);
                }
            }
        }
        
        public class c_exportfilters_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_exportfilters_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t3_gridExportConditions_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t3_gridExportConditions_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t3_gridExportConditions_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t3_gridExportConditions_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ExportFilters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload()
            {
                Buttons.Upload.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Cancel = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    First = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Prev = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Next = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Last = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                    Upload = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t3_gridExportConditions_lv0");
                }
            }
        }
        
        public class c_filterpreview_formpreview : Container
        {
            
            public PxButtonCollection Buttons;
            
            public c_filterpreview_formpreview(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "FilterPreview";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonOK", "OK", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                    Cancel = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonCancel", "Cancel", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                }
            }
        }
        
        public class c_parameters : Container
        {
            
			public TreeView Cat { get; }
			public TreeView Cat2 { get; }
            
            public c_parameters(string locator, string name) : 
                    base(locator, name)
            {
                Cat = new TreeView("ctl00_phG_tab_t0_gridImportMapping_lv0_edImportSourceField_pnlFormulaCombo_cat", "Cat", locator, null);
                Cat2 = new TreeView("ctl00_phG_tab_t2_gridExportMapping_lv0_edExportSourceField_pnlFormulaCombo_cat", "Cat 2", locator, null);
                DataMemberName = "";
            }
        }
        
        public class c_importmappings_importcsvsettings_frmimportcsvsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Separator { get; }
			public Label SeparatorLabel { get; }
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown CodePage { get; }
			public Label CodePageLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_importmappings_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ImportMappings$ImportCSVSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_importmappings_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_importmappings_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                        "s_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                        "s_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                        "s_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ImportMappings$ImportXLSXSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                            "s");
                    Cancel = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                            "s");
                }
            }
        }
        
        public class c_importmappings_importcolumns_grdimportcolumn : Grid<c_importmappings_importcolumns_grdimportcolumn.c_grid_row, c_importmappings_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_importmappings_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ImportMappings$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_importmappings_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_importmappings_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_importmappings_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_importmappings_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ImportMappings$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_gridImportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
        
        public class c_importfilters_importcsvsettings_frmimportcsvsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Separator { get; }
			public Label SeparatorLabel { get; }
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown CodePage { get; }
			public Label CodePageLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_importfilters_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ImportFilters$ImportCSVSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                            "gs");
                    Cancel = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t1_gridImportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                            "gs");
                }
            }
        }
        
        public class c_importfilters_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_importfilters_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                        "ings_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                        "ings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                        "ings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ImportFilters$ImportXLSXSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                            "ings");
                    Cancel = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t1_gridImportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                            "ings");
                }
            }
        }
        
        public class c_importfilters_importcolumns_grdimportcolumn : Grid<c_importfilters_importcolumns_grdimportcolumn.c_grid_row, c_importfilters_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_importfilters_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ImportFilters$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_importfilters_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0_ec" +
                            "", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_importfilters_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_importfilters_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_importfilters_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ImportFilters$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridImportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
        
        public class c_exportmappings_importcsvsettings_frmimportcsvsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Separator { get; }
			public Label SeparatorLabel { get; }
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown CodePage { get; }
			public Label CodePageLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_exportmappings_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings_" +
                        "edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ExportMappings$ImportCSVSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_exportmappings_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_exportmappings_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                        "s_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                        "s_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                        "s_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ExportMappings$ImportXLSXSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                            "s");
                    Cancel = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_imp_importXLSXSettingsDlg_frmImportXLSXSetting" +
                            "s");
                }
            }
        }
        
        public class c_exportmappings_importcolumns_grdimportcolumn : Grid<c_exportmappings_importcolumns_grdimportcolumn.c_grid_row, c_exportmappings_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_exportmappings_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ExportMappings$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_exportmappings_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_exportmappings_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_exportmappings_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_exportmappings_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ExportMappings$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridExportMapping_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
        
        public class c_exportfilters_importcsvsettings_frmimportcsvsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Separator { get; }
			public Label SeparatorLabel { get; }
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown CodePage { get; }
			public Label CodePageLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_exportfilters_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                        "gs_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ExportFilters$ImportCSVSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                            "gs");
                    Cancel = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t3_gridExportConditions_imp_importCSVSettingsDlg_frmImportCSVSettin" +
                            "gs");
                }
            }
        }
        
        public class c_exportfilters_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_exportfilters_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                        "ings_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                        "ings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                        "ings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "ExportFilters$ImportXLSXSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                            "ings");
                    Cancel = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t3_gridExportConditions_imp_importXLSXSettingsDlg_frmImportXLSXSett" +
                            "ings");
                }
            }
        }
        
        public class c_exportfilters_importcolumns_grdimportcolumn : Grid<c_exportfilters_importcolumns_grdimportcolumn.c_grid_row, c_exportfilters_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_exportfilters_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ExportFilters$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_exportfilters_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0_ec" +
                            "", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_exportfilters_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_exportfilters_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_exportfilters_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ExportFilters$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfFirst" +
                            "0", "First", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfPrev0" +
                            "", "Prev", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfNext0" +
                            "", "Next", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lfLast0" +
                            "", "Last", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t3_gridExportConditions_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
    }
}
