using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Editors.TreeSelector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.ImageUploader;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.RichTextEdit;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class IN202000_NonStockItemMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_allscreens_screensgrid AllScreens_screensGrid { get; } = new c_allscreens_screensgrid("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid", "AllScreens_screensGrid");
        protected c_pages_articlesgrid Pages_articlesGrid { get; } = new c_pages_articlesgrid("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid", "Pages_articlesGrid");
        protected c_pages_lv0 Pages_lv0 { get; } = new c_pages_lv0("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0", "Pages_lv0");
        protected c_fileswithsize_filessearchgrid FilesWithSize_filesSearchGrid { get; } = new c_fileswithsize_filessearchgrid("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid", "FilesWithSize_filesSearchGrid");
        protected c_fileswithsize_lv0 FilesWithSize_lv0 { get; } = new c_fileswithsize_lv0("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0", "FilesWithSize_lv0");
        protected c_item_form Item_form { get; } = new c_item_form("ctl00_phF_form", "Item_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_profilerinfoview_formprofiler ProfilerInfoView_formProfiler { get; } = new c_profilerinfoview_formprofiler("ctl00_usrCaption_pnlProfiler_formProfiler", "ProfilerInfoView_formProfiler");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_itemsettings_tab ItemSettings_tab { get; } = new c_itemsettings_tab("ctl00_phG_tab", "ItemSettings_tab");
        protected c_itemclass_tab ItemClass_tab { get; } = new c_itemclass_tab("ctl00_phG_tab", "ItemClass_tab");
        protected c_itemsettings_formdr ItemSettings_formDR { get; } = new c_itemsettings_formdr("ctl00_phG_tab_t6_formDR", "ItemSettings_formDR");
        protected c_itemunits_gridunits Itemunits_gridunits { get; } = new c_itemunits_gridunits("ctl00_phG_tab_t0_gridUnits", "itemunits_gridUnits");
        protected c_itemunits_lv0 Itemunits_lv0 { get; } = new c_itemunits_lv0("ctl00_phG_tab_t0_gridUnits_lv0", "itemunits_lv0");
        protected c_components_pxgridcomponents Components_PXGridComponents { get; } = new c_components_pxgridcomponents("ctl00_phG_tab_t6_PXGridComponents", "Components_PXGridComponents");
        protected c_components_lv0 Components_lv0 { get; } = new c_components_lv0("ctl00_phG_tab_t6_PXGridComponents_lv0", "Components_lv0");
        protected c_itemxrefrecords_crossgrid Itemxrefrecords_crossgrid { get; } = new c_itemxrefrecords_crossgrid("ctl00_phG_tab_t3_crossgrid", "itemxrefrecords_crossgrid");
        protected c_itemxrefrecords_lv0 Itemxrefrecords_lv0 { get; } = new c_itemxrefrecords_lv0("ctl00_phG_tab_t3_crossgrid_lv0", "itemxrefrecords_lv0");
        protected c_vendoritems_pxgridvendoritems VendorItems_PXGridVendorItems { get; } = new c_vendoritems_pxgridvendoritems("ctl00_phG_tab_t2_PXGridVendorItems", "VendorItems_PXGridVendorItems");
        protected c_vendoritems_lv0 VendorItems_lv0 { get; } = new c_vendoritems_lv0("ctl00_phG_tab_t2_PXGridVendorItems_lv0", "VendorItems_lv0");
        protected c_answers_pxgridanswers Answers_PXGridAnswers { get; } = new c_answers_pxgridanswers("ctl00_phG_tab_t8_PXGridAnswers", "Answers_PXGridAnswers");
        protected c_answers_lv0 Answers_lv0 { get; } = new c_answers_lv0("ctl00_phG_tab_t8_PXGridAnswers_lv0", "Answers_lv0");
        protected c_category_pxgridcategory Category_PXGridCategory { get; } = new c_category_pxgridcategory("ctl00_phG_tab_t8_PXGridCategory", "Category_PXGridCategory");
        protected c_category_lv0 Category_lv0 { get; } = new c_category_lv0("ctl00_phG_tab_t8_PXGridCategory_lv0", "Category_lv0");
        protected c_relateditems_relateditemsgrid RelatedItems_relatedItemsGrid { get; } = new c_relateditems_relateditemsgrid("ctl00_phG_tab_t4_relatedItemsGrid", "RelatedItems_relatedItemsGrid");
        protected c_relateditems_lv0 RelatedItems_lv0 { get; } = new c_relateditems_lv0("ctl00_phG_tab_t4_relatedItemsGrid_lv0", "RelatedItems_lv0");
        protected c_inventoryfileurls_gridinventoryfileurls InventoryFileUrls_gridInventoryFileUrls { get; } = new c_inventoryfileurls_gridinventoryfileurls("ctl00_phG_tab_t15_gridInventoryFileUrls", "InventoryFileUrls_gridInventoryFileUrls");
        protected c_inventoryfileurls_lv0 InventoryFileUrls_lv0 { get; } = new c_inventoryfileurls_lv0("ctl00_phG_tab_t15_gridInventoryFileUrls_lv0", "InventoryFileUrls_lv0");
        protected c_curysettings_inventoryitem_curysettingsform CurySettings_InventoryItem_curySettingsForm { get; } = new c_curysettings_inventoryitem_curysettingsform("ctl00_phG_tab_t1_curySettingsForm", "CurySettings_InventoryItem_curySettingsForm");
        protected c_curysettings_inventoryitem_curysettingsform2 CurySettings_InventoryItem_curySettingsForm2 { get; } = new c_curysettings_inventoryitem_curysettingsform2("ctl00_phG_tab_t1_curySettingsForm2", "CurySettings_InventoryItem_curySettingsForm2");
        protected c_vendorinventory_updateprice_formeffectivedate VendorInventory_UpdatePrice_formEffectiveDate { get; } = new c_vendorinventory_updateprice_formeffectivedate("ctl00_phG_pnlUpdatePrice_formEffectiveDate", "VendorInventory$UpdatePrice_formEffectiveDate");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phF_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_serviceskills_gridserviceskills ServiceSkills_gridServiceSkills { get; } = new c_serviceskills_gridserviceskills("ctl00_phG_tab_t10_gridServiceSkills", "ServiceSkills_gridServiceSkills");
        protected c_serviceskills_lv0 ServiceSkills_lv0 { get; } = new c_serviceskills_lv0("ctl00_phG_tab_t10_gridServiceSkills_lv0", "ServiceSkills_lv0");
        protected c_servicelicensetypes_gridservicelicensetypes ServiceLicenseTypes_gridServiceLicenseTypes { get; } = new c_servicelicensetypes_gridservicelicensetypes("ctl00_phG_tab_t11_gridServiceLicenseTypes", "ServiceLicenseTypes_gridServiceLicenseTypes");
        protected c_servicelicensetypes_lv0 ServiceLicenseTypes_lv0 { get; } = new c_servicelicensetypes_lv0("ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0", "ServiceLicenseTypes_lv0");
        protected c_serviceequipmenttypes_gridserviceequipmenttypes ServiceEquipmentTypes_gridServiceEquipmentTypes { get; } = new c_serviceequipmenttypes_gridserviceequipmenttypes("ctl00_phG_tab_t12_gridServiceEquipmentTypes", "ServiceEquipmentTypes_gridServiceEquipmentTypes");
        protected c_serviceequipmenttypes_lv0 ServiceEquipmentTypes_lv0 { get; } = new c_serviceequipmenttypes_lv0("ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0", "ServiceEquipmentTypes_lv0");
        protected c_serviceinventoryitems_gridpickdeliver ServiceInventoryItems_gridPickDeliver { get; } = new c_serviceinventoryitems_gridpickdeliver("ctl00_phG_tab_t13_gridPickDeliver", "ServiceInventoryItems_gridPickDeliver");
        protected c_serviceinventoryitems_lv0 ServiceInventoryItems_lv0 { get; } = new c_serviceinventoryitems_lv0("ctl00_phG_tab_t13_gridPickDeliver_lv0", "ServiceInventoryItems_lv0");
        protected c_syncrecs_syncgrid SyncRecs_syncGrid { get; } = new c_syncrecs_syncgrid("ctl00_phG_tab_t14_syncGrid", "SyncRecs_syncGrid");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_itemsettings_filesgrid ItemSettings_filesGrid { get; } = new c_itemsettings_filesgrid("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid", "ItemSettings_filesGrid");
        protected c_relateditems_importcsvsettings_frmimportcsvsettings RelatedItems_ImportCSVSettings_frmImportCSVSettings { get; } = new c_relateditems_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings", "RelatedItems$ImportCSVSettings_frmImportCSVSettings");
        protected c_relateditems_importxlsxsettings_frmimportxlsxsettings RelatedItems_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_relateditems_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "RelatedItems$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_relateditems_importcolumns_grdimportcolumn RelatedItems_ImportColumns_grdImportColumn { get; } = new c_relateditems_importcolumns_grdimportcolumn("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn", "RelatedItems$ImportColumns_grdImportColumn");
        protected c_relateditems_importcolumns_lv0 RelatedItems_ImportColumns_lv0 { get; } = new c_relateditems_importcolumns_lv0("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0", "RelatedItems$ImportColumns_lv0");
        
        public IN202000_NonStockItemMaint()
        {
            ScreenId = "IN202000";
            ScreenUrl = "/Pages/IN/IN202000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual IN202000_NonStockItemMaint ReadOne(Gate gate, string InventoryCD)
        {
            new BiObject<IN202000_NonStockItemMaint>(gate).ReadOne(this, InventoryCD);
            return this;
        }
        
        public virtual IN202000_NonStockItemMaint ReadOne(string InventoryCD)
        {
            return this.ReadOne(ApiConnection.Source, InventoryCD);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Note()
        {
            ToolBar.Note.Click();
        }
        
        public virtual void ActivityShow()
        {
            ToolBar.ActivityShow.Click();
        }
        
        public virtual void FilesMenuShow()
        {
            ToolBar.FilesMenuShow.Click();
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
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void ElapsedTime()
        {
            ToolBar.ElapsedTime.Click();
        }
        
        public virtual void CancelClose()
        {
            ToolBar.CancelClose.Click();
        }
        
        public virtual void SaveClose()
        {
            ToolBar.SaveClose.Click();
        }
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Insert()
        {
            ToolBar.Insert.Click();
        }
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void Clipboard()
        {
            ToolBar.Clipboard.Click();
        }
        
        public virtual void CopyDocument()
        {
            ToolBar.CopyDocument.Click();
        }
        
        public virtual void PasteDocument()
        {
            ToolBar.PasteDocument.Click();
        }
        
        public virtual void SaveTemplate()
        {
            ToolBar.SaveTemplate.Click();
        }
        
        public virtual void First()
        {
            ToolBar.First.Click();
        }
        
        public virtual void Previous()
        {
            ToolBar.Previous.Click();
        }
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void Last()
        {
            ToolBar.Last.Click();
        }
        
        public virtual void ChangeIDHidden()
        {
            ToolBar.ChangeIDHidden.Click();
        }
        
        public virtual void UpdateCostHidden()
        {
            ToolBar.UpdateCostHidden.Click();
        }
        
        public virtual void ViewRestrictionGroupsHidden()
        {
            ToolBar.ViewRestrictionGroupsHidden.Click();
        }
        
        public virtual void ViewSalesPricesHidden()
        {
            ToolBar.ViewSalesPricesHidden.Click();
        }
        
        public virtual void ViewVendorPricesHidden()
        {
            ToolBar.ViewVendorPricesHidden.Click();
        }
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void UpdateCost()
        {
            ToolBar.UpdateCost.Click();
        }
        
        public virtual void ViewRestrictionGroups()
        {
            ToolBar.ViewRestrictionGroups.Click();
        }
        
        public virtual void Inquiries()
        {
            ToolBar.Inquiries.Click();
        }
        
        public virtual void ViewSalesPrices()
        {
            ToolBar.ViewSalesPrices.Click();
        }
        
        public virtual void ViewVendorPrices()
        {
            ToolBar.ViewVendorPrices.Click();
        }
        
        public virtual void LongRun1()
        {
            ToolBar.LongRun1.Click();
        }
        
        public virtual void ElapsedTime1()
        {
            ToolBar.ElapsedTime1.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton Note { get; }
			public ToolBarButton ActivityShow { get; }
			public ToolBarButton FilesMenuShow { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
			public ToolBarButton CancelClose { get; }
			public ToolBarButton SaveClose { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton Clipboard { get; }
			public ToolBarButton CopyDocument { get; }
			public ToolBarButton PasteDocument { get; }
			public ToolBarButton SaveTemplate { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Previous { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton ChangeIDHidden { get; }
			public ToolBarButton UpdateCostHidden { get; }
			public ToolBarButton ViewRestrictionGroupsHidden { get; }
			public ToolBarButton ViewSalesPricesHidden { get; }
			public ToolBarButton ViewVendorPricesHidden { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton UpdateCost { get; }
			public ToolBarButton ViewRestrictionGroups { get; }
			public ToolBarButton Inquiries { get; }
			public ToolBarButton ViewSalesPrices { get; }
			public ToolBarButton ViewVendorPrices { get; }
			public ToolBarButton LongRun1 { get; }
			public ToolBarButton ElapsedTime1 { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                ActivityShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'ActivityShow\']", "Activities", locator, null);
                FilesMenuShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
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
                LongRun = new ToolBarButton("css=#ctl00_usrCaption_pnlProfiler_dsProfiler_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_usrCaption_pnlProfiler_dsProfiler_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CancelClose\']", "Discard Changes and Close", locator, null);
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'SaveClose\']", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Save\']", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Insert\']", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Delete\']", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                Clipboard = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div.toolsBtn[tooltip=\'Clipboard\']", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=li[data-cmd=\'CopyPaste@CopyDocument\']", "Copy", locator, Clipboard);
                PasteDocument = new ToolBarButton("css=li[data-cmd=\'CopyPaste@PasteDocument\']", "Paste", locator, Clipboard);
                SaveTemplate = new ToolBarButton("css=li[data-cmd=\'CopyPaste@SaveTemplate\']", "Save as Template...", locator, Clipboard);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'First\']", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Previous\']", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Next\']", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Last\']", "Go to Last Record", locator, null);
                ChangeIDHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ChangeID\']", "Change ID", locator, null);
                UpdateCostHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'UpdateCost\']", "Update Cost", locator, null);
                ViewRestrictionGroupsHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewRestrictionGroups\']", "View Restriction Groups", locator, null);
                ViewSalesPricesHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewSalesPrices\']", "Sales Prices", locator, null);
                ViewVendorPricesHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewVendorPrices\']", "Vendor Prices", locator, null);
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                ChangeID = new ToolBarButton("css=li[data-cmd=\'Action@ChangeID\']", "Change ID", locator, Actions);
                UpdateCost = new ToolBarButton("css=li[data-cmd=\'Action@UpdateCost\']", "Update Cost", locator, Actions);
                ViewRestrictionGroups = new ToolBarButton("css=li[data-cmd=\'Action@ViewRestrictionGroups\']", "View Restriction Groups", locator, Actions);
                Inquiries = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Inquiries\") > div[data-type=\'drop\']", "Inquiries", locator, null);
                ViewSalesPrices = new ToolBarButton("css=li[data-cmd=\'Inquiry@ViewSalesPrices\']", "Sales Prices", locator, Inquiries);
                ViewVendorPrices = new ToolBarButton("css=li[data-cmd=\'Inquiry@ViewVendorPrices\']", "Vendor Prices", locator, Inquiries);
                LongRun1 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime1 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_allscreens_screensgrid : Grid<c_allscreens_screensgrid.c_grid_row, c_allscreens_screensgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_allscreens_screensgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid");
                DataMemberName = "AllScreens";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_at_tlb div[da" +
                            "ta-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_at_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Title { get; }
			public PXTextEdit ScreenID { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit Url { get; }
                
                public c_grid_row(c_allscreens_screensgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Title", grid.Locator, "Title");
                    Title.DataField = "Title";
                    ScreenID = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "ScreenID", grid.Locator, "ScreenID");
                    ScreenID.DataField = "ScreenID";
                    Module = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    Url = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Url", grid.Locator, "Url");
                    Url.DataField = "Url";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Title { get; }
				public PXTextEditColumnFilter ScreenID { get; }
				public PXTextEditColumnFilter Module { get; }
				public PXTextEditColumnFilter Url { get; }
                
                public c_grid_header(c_allscreens_screensgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEditColumnFilter(grid.Row.Title);
                    ScreenID = new PXTextEditColumnFilter(grid.Row.ScreenID);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    Url = new PXTextEditColumnFilter(grid.Row.Url);
                }
            }
        }
        
        public class c_pages_articlesgrid : Grid<c_pages_articlesgrid.c_grid_row, c_pages_articlesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_pages_articlesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid");
                DataMemberName = "Pages";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_at_tlb div[" +
                            "data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_at_tlb div[" +
                            "data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Title { get; }
			public PXTextEdit WikiPageParent__Title { get; }
			public DateSelector CreatedDateTime { get; }
			public PXTextEdit PageID { get; }
                
                public c_grid_row(c_pages_articlesgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "Title", grid.Locator, "Title");
                    Title.DataField = "Title";
                    WikiPageParent__Title = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "Title", grid.Locator, "WikiPageParent__Title");
                    WikiPageParent__Title.DataField = "WikiPageParent__Title";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0_ed2", "Create", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    PageID = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "PageID", grid.Locator, "PageID");
                    PageID.DataField = "PageID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Title { get; }
				public PXTextEditColumnFilter WikiPageParent__Title { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXTextEditColumnFilter PageID { get; }
                
                public c_grid_header(c_pages_articlesgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEditColumnFilter(grid.Row.Title);
                    WikiPageParent__Title = new PXTextEditColumnFilter(grid.Row.WikiPageParent__Title);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    PageID = new PXTextEditColumnFilter(grid.Row.PageID);
                }
            }
        }
        
        public class c_pages_lv0 : Container
        {
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_pages_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "Pages";
            }
        }
        
        public class c_fileswithsize_filessearchgrid : Grid<c_fileswithsize_filessearchgrid.c_grid_row, c_fileswithsize_filessearchgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_fileswithsize_filessearchgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid");
                DataMemberName = "FilesWithSize";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_at_tlb d" +
                            "iv[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_at_tlb d" +
                            "iv[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector Name { get; }
			public PXTextEdit Size { get; }
			public PXTextEdit Comment { get; }
			public PXTextEdit FileID { get; }
                
                public c_grid_row(c_fileswithsize_filessearchgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Name = new Selector("_ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0_es", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Size = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "Size (kb)", grid.Locator, "Size");
                    Size.DataField = "Size";
                    Comment = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                    FileID = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "File", grid.Locator, "FileID");
                    FileID.DataField = "FileID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter Name { get; }
				public PXTextEditColumnFilter Size { get; }
				public PXTextEditColumnFilter Comment { get; }
				public PXTextEditColumnFilter FileID { get; }
                
                public c_grid_header(c_fileswithsize_filessearchgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Name = new SelectorColumnFilter(grid.Row.Name);
                    Size = new PXTextEditColumnFilter(grid.Row.Size);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                    FileID = new PXTextEditColumnFilter(grid.Row.FileID);
                }
            }
        }
        
        public class c_fileswithsize_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_fileswithsize_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "FilesWithSize";
            }
        }
        
        public class c_item_form : Container
        {
            
			public Selector InventoryCD { get; }
			public Label InventoryCDLabel { get; }
			public DropDown ItemStatus { get; }
			public Label ItemStatusLabel { get; }
			public Selector ProductWorkgroupID { get; }
			public Label ProductWorkgroupIDLabel { get; }
			public Selector ProductManagerID { get; }
			public Label ProductManagerIDLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public CheckBox ChkServiceManagement { get; }
			public Label ChkServiceManagementLabel { get; }
            
            public c_item_form(string locator, string name) : 
                    base(locator, name)
            {
                InventoryCD = new Selector("ctl00_phF_form_edInventoryCD", "Inventory ID", locator, null);
                InventoryCDLabel = new Label(InventoryCD);
                InventoryCD.DataField = "InventoryCD";
                ItemStatus = new DropDown("ctl00_phF_form_edItemStatus", "Item Status", locator, null);
                ItemStatusLabel = new Label(ItemStatus);
                ItemStatus.DataField = "ItemStatus";
                ItemStatus.Items.Add("AC", "Active");
                ItemStatus.Items.Add("NS", "No Sales");
                ItemStatus.Items.Add("NP", "No Purchases");
                ItemStatus.Items.Add("NR", "No Request");
                ItemStatus.Items.Add("IN", "Inactive");
                ItemStatus.Items.Add("DE", "Marked for Deletion");
                ProductWorkgroupID = new Selector("ctl00_phF_form_edProductWorkgroupID", "Product Workgroup", locator, null);
                ProductWorkgroupIDLabel = new Label(ProductWorkgroupID);
                ProductWorkgroupID.DataField = "ProductWorkgroupID";
                ProductManagerID = new Selector("ctl00_phF_form_edProductManagerID", "Product Manager", locator, null);
                ProductManagerIDLabel = new Label(ProductManagerID);
                ProductManagerID.DataField = "ProductManagerID";
                Descr = new InputLocalizable("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                ChkServiceManagement = new CheckBox("ctl00_phF_form_chkServiceManagement", "chkServiceManagement", locator, null);
                ChkServiceManagementLabel = new Label(ChkServiceManagement);
                ChkServiceManagement.DataField = "ChkServiceManagement";
                DataMemberName = "Item";
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
        
        public class c_profilerinfoview_formprofiler : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit StartText { get; }
			public Label StartTextLabel { get; }
			public PXTextEdit Started { get; }
			public Label StartedLabel { get; }
			public PXTextEdit RequestsLogged { get; }
			public Label RequestsLoggedLabel { get; }
			public PXTextEdit ExportText { get; }
			public Label ExportTextLabel { get; }
			public Label PXLabel1_ { get; }
			public Label LblPlace_ { get; }
            
            public c_profilerinfoview_formprofiler(string locator, string name) : 
                    base(locator, name)
            {
                StartText = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartText", "Start Text", locator, null);
                StartTextLabel = new Label(StartText);
                StartText.DataField = "StartText";
                Started = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartedAt", "Started", locator, null);
                StartedLabel = new Label(Started);
                Started.DataField = "Started";
                RequestsLogged = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblRequestsLogged", "Requests Logged", locator, null);
                RequestsLoggedLabel = new Label(RequestsLogged);
                RequestsLogged.DataField = "RequestsLogged";
                ExportText = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblExportText", "Export Text", locator, null);
                ExportTextLabel = new Label(ExportText);
                ExportText.DataField = "ExportText";
                PXLabel1_ = new Label("ctl00_usrCaption_pnlProfiler_formProfiler_PXLabel1", "PX Label 1_", locator, null);
                LblPlace_ = new Label("ctl00_usrCaption_pnlProfiler_formProfiler_lblPlace", "Lbl Place _", locator, null);
                DataMemberName = "ProfilerInfoView";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnStartProfiler()
            {
                Buttons.BtnStartProfiler.Click();
            }
            
            public virtual void BtnStopProfiler()
            {
                Buttons.BtnStopProfiler.Click();
            }
            
            public virtual void BtnLastRequest()
            {
                Buttons.BtnLastRequest.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnStartProfiler { get; }
			public Button BtnStopProfiler { get; }
			public Button BtnLastRequest { get; }
                
                public PxButtonCollection()
                {
                    BtnStartProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStartProfiler", "btnStartProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnStopProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStopProfiler", "btnStopProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnLastRequest = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnLastRequest", "btnLastRequest", "ctl00_usrCaption_pnlProfiler_formProfiler");
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
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
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
        
        public class c_itemsettings_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TemplateItemID { get; }
			public Label TemplateItemIDLabel { get; }
			public Selector ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public DropDown ItemType { get; }
			public Label ItemTypeLabel { get; }
			public Selector PostClassID { get; }
			public Label PostClassIDLabel { get; }
			public CheckBox KitItem { get; }
			public Label KitItemLabel { get; }
			public CheckBox IsTravelItem { get; }
			public Label IsTravelItemLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public Selector DfltSiteID { get; }
			public Label DfltSiteIDLabel { get; }
			public CheckBox NonStockReceipt { get; }
			public Label NonStockReceiptLabel { get; }
			public CheckBox NonStockReceiptAsService { get; }
			public Label NonStockReceiptAsServiceLabel { get; }
			public CheckBox NonStockShip { get; }
			public Label NonStockShipLabel { get; }
			public DropDown CompletePOLine { get; }
			public Label CompletePOLineLabel { get; }
			public DropDown AMDefaultMarkFor { get; }
			public Label AMDefaultMarkForLabel { get; }
			public PXTextEdit EstimatedDuration { get; }
			public Label EstimatedDurationLabel { get; }
			public Selector BaseUnit { get; }
			public Label BaseUnitLabel { get; }
			public CheckBox DecimalBaseUnit { get; }
			public Label DecimalBaseUnitLabel { get; }
			public Selector SalesUnit { get; }
			public Label SalesUnitLabel { get; }
			public CheckBox DecimalSalesUnit { get; }
			public Label DecimalSalesUnitLabel { get; }
			public Selector PurchaseUnit { get; }
			public Label PurchaseUnitLabel { get; }
			public CheckBox DecimalPurchaseUnit { get; }
			public Label DecimalPurchaseUnitLabel { get; }
			public Selector PriceClassID { get; }
			public Label PriceClassIDLabel { get; }
			public Selector PriceWorkgroupID { get; }
			public Label PriceWorkgroupIDLabel { get; }
			public Selector PriceManagerID { get; }
			public Label PriceManagerIDLabel { get; }
			public CheckBox Commisionable { get; }
			public Label CommisionableLabel { get; }
			public PXNumberEdit MinGrossProfitPct { get; }
			public Label MinGrossProfitPctLabel { get; }
			public PXNumberEdit MarkupPct { get; }
			public Label MarkupPctLabel { get; }
			public CheckBox AccrueCost { get; }
			public Label AccrueCostLabel { get; }
			public DropDown CostBasis { get; }
			public Label CostBasisLabel { get; }
			public PXNumberEdit PercentOfSalesPrice { get; }
			public Label PercentOfSalesPriceLabel { get; }
			public CheckBox IsRUTROTDeductible { get; }
			public Label IsRUTROTDeductibleLabel { get; }
			public GroupBox RUTROTType { get; }
			public Label RUTROTTypeLabel { get; }
			public DropDown RUTROTItemType { get; }
			public Label RUTROTItemTypeLabel { get; }
			public Selector RUTROTWorkTypeID { get; }
			public Label RUTROTWorkTypeIDLabel { get; }
			public Selector DfltEarningType { get; }
			public Label DfltEarningTypeLabel { get; }
			public DropDown BillingRule { get; }
			public Label BillingRuleLabel { get; }
			public PXNumberEdit BaseItemWeight { get; }
			public Label BaseItemWeightLabel { get; }
			public Selector WeightUOM { get; }
			public Label WeightUOMLabel { get; }
			public PXNumberEdit BaseItemVolume { get; }
			public Label BaseItemVolumeLabel { get; }
			public Selector VolumeUOM { get; }
			public Label VolumeUOMLabel { get; }
			public PXNumberEdit UndershipThreshold { get; }
			public Label UndershipThresholdLabel { get; }
			public PXNumberEdit OvershipThreshold { get; }
			public Label OvershipThresholdLabel { get; }
			public Selector InvtAcctID { get; }
			public Label InvtAcctIDLabel { get; }
			public Selector InvtSubID { get; }
			public Label InvtSubIDLabel { get; }
			public Selector ReasonCodeSubID { get; }
			public Label ReasonCodeSubIDLabel { get; }
			public Selector COGSAcctID { get; }
			public Label COGSAcctIDLabel { get; }
			public Selector COGSSubID { get; }
			public Label COGSSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public Selector PPVAcctID { get; }
			public Label PPVAcctIDLabel { get; }
			public Selector PPVSubID { get; }
			public Label PPVSubIDLabel { get; }
			public Selector DeferralAcctID { get; }
			public Label DeferralAcctIDLabel { get; }
			public Selector DeferralSubID { get; }
			public Label DeferralSubIDLabel { get; }
			public Selector EarningsAcctID { get; }
			public Label EarningsAcctIDLabel { get; }
			public Selector EarningsSubID { get; }
			public Label EarningsSubIDLabel { get; }
			public Selector BenefitExpenseAcctID { get; }
			public Label BenefitExpenseAcctIDLabel { get; }
			public Selector BenefitExpenseSubID { get; }
			public Label BenefitExpenseSubIDLabel { get; }
			public Selector TaxExpenseAcctID { get; }
			public Label TaxExpenseAcctIDLabel { get; }
			public Selector TaxExpenseSubID { get; }
			public Label TaxExpenseSubIDLabel { get; }
			public ImageUploader ImageUrl { get; }
			public Label ImageUrlLabel { get; }
			public RichTextEdit Body { get; }
			public Label BodyLabel { get; }
			public DropDown ActionType { get; }
			public Label ActionTypeLabel { get; }
			public CheckBox ExportToExternal { get; }
			public Label ExportToExternalLabel { get; }
			public DropDown Visibility { get; }
			public Label VisibilityLabel { get; }
			public DropDown Availability { get; }
			public Label AvailabilityLabel { get; }
			public PXTextEdit CustomURL { get; }
			public Label CustomURLLabel { get; }
			public InputLocalizable PageTitle { get; }
			public Label PageTitleLabel { get; }
			public InputLocalizable ShortDescription { get; }
			public Label ShortDescriptionLabel { get; }
			public InputLocalizable SearchKeywords { get; }
			public Label SearchKeywordsLabel { get; }
			public InputLocalizable MetaKeywords { get; }
			public Label MetaKeywordsLabel { get; }
			public InputLocalizable MetaDescription { get; }
			public Label MetaDescriptionLabel { get; }
			public Label Label1_importColumnDlg { get; }
			public Label LblImportSource_ { get; }
			public Label LblPassword_ { get; }
			public Label Ctl08_ { get; }
			public Label Ctl21_ { get; }
			public Label Pixwidth_ { get; }
			public Label Pixcaption_ { get; }
			public Label Ctl34_ { get; }
            
            public c_itemsettings_tab(string locator, string name) : 
                    base(locator, name)
            {
                TemplateItemID = new Selector("ctl00_phG_tab_t0_edTemplateItemID", "Template ID", locator, null);
                TemplateItemIDLabel = new Label(TemplateItemID);
                TemplateItemID.DataField = "TemplateItemID";
                ItemClassID = new Selector("ctl00_phG_tab_t0_edItemClassID", "Item Class", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                ItemType = new DropDown("ctl00_phG_tab_t0_edItemType", "Type", locator, null);
                ItemTypeLabel = new Label(ItemType);
                ItemType.DataField = "ItemType";
                ItemType.Items.Add("N", "Non-Stock Item");
                ItemType.Items.Add("L", "Labor");
                ItemType.Items.Add("S", "Service");
                ItemType.Items.Add("C", "Charge");
                ItemType.Items.Add("E", "Expense");
                PostClassID = new Selector("ctl00_phG_tab_t0_edPostClassID", "Posting Class", locator, null);
                PostClassIDLabel = new Label(PostClassID);
                PostClassID.DataField = "PostClassID";
                KitItem = new CheckBox("ctl00_phG_tab_t0_chkKitItem", "Is a Kit", locator, null);
                KitItemLabel = new Label(KitItem);
                KitItem.DataField = "KitItem";
                IsTravelItem = new CheckBox("ctl00_phG_tab_t0_edIsTravelItem", "Is a Travel Item", locator, null);
                IsTravelItemLabel = new Label(IsTravelItem);
                IsTravelItem.DataField = "IsTravelItem";
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                TaxCalcMode = new DropDown("ctl00_phG_tab_t0_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                DfltSiteID = new Selector("ctl00_phG_tab_t0_edDfltSiteID", "Default Warehouse", locator, null);
                DfltSiteIDLabel = new Label(DfltSiteID);
                DfltSiteID.DataField = "DfltSiteID";
                NonStockReceipt = new CheckBox("ctl00_phG_tab_t0_chkNonStockReceipt", "Require Receipt", locator, null);
                NonStockReceiptLabel = new Label(NonStockReceipt);
                NonStockReceipt.DataField = "NonStockReceipt";
                NonStockReceiptAsService = new CheckBox("ctl00_phG_tab_t0_chkNonStockReceiptAsService", "Process Item via Receipt", locator, null);
                NonStockReceiptAsServiceLabel = new Label(NonStockReceiptAsService);
                NonStockReceiptAsService.DataField = "NonStockReceiptAsService";
                NonStockShip = new CheckBox("ctl00_phG_tab_t0_chkNonStockShip", "Require Shipment", locator, null);
                NonStockShipLabel = new Label(NonStockShip);
                NonStockShip.DataField = "NonStockShip";
                CompletePOLine = new DropDown("ctl00_phG_tab_t0_edCompletePOLine", "Close PO Line", locator, null);
                CompletePOLineLabel = new Label(CompletePOLine);
                CompletePOLine.DataField = "CompletePOLine";
                CompletePOLine.Items.Add("A", "By Amount");
                CompletePOLine.Items.Add("Q", "By Quantity");
                AMDefaultMarkFor = new DropDown("ctl00_phG_tab_t0_edAMDefaultMarkFor", "Dflt Mark For", locator, null);
                AMDefaultMarkForLabel = new Label(AMDefaultMarkFor);
                AMDefaultMarkFor.DataField = "AMDefaultMarkFor";
                EstimatedDuration = new PXTextEdit("ctl00_phG_tab_t0_edEstimatedDuration", "Estimated Duration", locator, null);
                EstimatedDurationLabel = new Label(EstimatedDuration);
                EstimatedDuration.DataField = "EstimatedDuration";
                BaseUnit = new Selector("ctl00_phG_tab_t0_edBaseUnit", "Base Unit", locator, null);
                BaseUnitLabel = new Label(BaseUnit);
                BaseUnit.DataField = "BaseUnit";
                DecimalBaseUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalBaseUnit", "Divisible Unit", locator, null);
                DecimalBaseUnitLabel = new Label(DecimalBaseUnit);
                DecimalBaseUnit.DataField = "DecimalBaseUnit";
                SalesUnit = new Selector("ctl00_phG_tab_t0_edSalesUnit", "Sales Unit", locator, null);
                SalesUnitLabel = new Label(SalesUnit);
                SalesUnit.DataField = "SalesUnit";
                DecimalSalesUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalSalesUnit", "Divisible Unit", locator, null);
                DecimalSalesUnitLabel = new Label(DecimalSalesUnit);
                DecimalSalesUnit.DataField = "DecimalSalesUnit";
                PurchaseUnit = new Selector("ctl00_phG_tab_t0_edPurchaseUnit", "Purchase Unit", locator, null);
                PurchaseUnitLabel = new Label(PurchaseUnit);
                PurchaseUnit.DataField = "PurchaseUnit";
                DecimalPurchaseUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalPurchaseUnit", "Divisible Unit", locator, null);
                DecimalPurchaseUnitLabel = new Label(DecimalPurchaseUnit);
                DecimalPurchaseUnit.DataField = "DecimalPurchaseUnit";
                PriceClassID = new Selector("ctl00_phG_tab_t1_edPriceClassID", "Price Class", locator, null);
                PriceClassIDLabel = new Label(PriceClassID);
                PriceClassID.DataField = "PriceClassID";
                PriceWorkgroupID = new Selector("ctl00_phG_tab_t1_edPriceWorkgroupID", "Price Workgroup", locator, null);
                PriceWorkgroupIDLabel = new Label(PriceWorkgroupID);
                PriceWorkgroupID.DataField = "PriceWorkgroupID";
                PriceManagerID = new Selector("ctl00_phG_tab_t1_edPriceManagerID", "Price Manager", locator, null);
                PriceManagerIDLabel = new Label(PriceManagerID);
                PriceManagerID.DataField = "PriceManagerID";
                Commisionable = new CheckBox("ctl00_phG_tab_t1_chkCommisionable", "Subject to Commission", locator, null);
                CommisionableLabel = new Label(Commisionable);
                Commisionable.DataField = "Commisionable";
                MinGrossProfitPct = new PXNumberEdit("ctl00_phG_tab_t1_edMinGrossProfitPct", "Min. Markup %", locator, null);
                MinGrossProfitPctLabel = new Label(MinGrossProfitPct);
                MinGrossProfitPct.DataField = "MinGrossProfitPct";
                MarkupPct = new PXNumberEdit("ctl00_phG_tab_t1_edMarkupPct", "Markup %", locator, null);
                MarkupPctLabel = new Label(MarkupPct);
                MarkupPct.DataField = "MarkupPct";
                AccrueCost = new CheckBox("ctl00_phG_tab_t1_chkAccrueCost", "Accrue Cost", locator, null);
                AccrueCostLabel = new Label(AccrueCost);
                AccrueCost.DataField = "AccrueCost";
                CostBasis = new DropDown("ctl00_phG_tab_t1_edCostBasis", "Cost Based On", locator, null);
                CostBasisLabel = new Label(CostBasis);
                CostBasis.DataField = "CostBasis";
                CostBasis.Items.Add("S", "Standard Cost");
                CostBasis.Items.Add("M", "Markup %");
                CostBasis.Items.Add("P", "Percentage of Sales Price");
                PercentOfSalesPrice = new PXNumberEdit("ctl00_phG_tab_t1_edPercentOfSalesPrice", "Percent of Sales Price", locator, null);
                PercentOfSalesPriceLabel = new Label(PercentOfSalesPrice);
                PercentOfSalesPrice.DataField = "PercentOfSalesPrice";
                IsRUTROTDeductible = new CheckBox("ctl00_phG_tab_t1_chkIsRUTROTDeductible", "ROT or RUT Deductible Item", locator, null);
                IsRUTROTDeductibleLabel = new Label(IsRUTROTDeductible);
                IsRUTROTDeductible.DataField = "IsRUTROTDeductible";
                RUTROTType = new GroupBox("ctl00_phG_tab_t1_gbRRType", "RUTROT Type", locator, null);
                RUTROTTypeLabel = new Label(RUTROTType);
                RUTROTType.DataField = "RUTROTType";
                RUTROTItemType = new DropDown("ctl00_phG_tab_t1_cmbRUTROTItemType", "Type", locator, null);
                RUTROTItemTypeLabel = new Label(RUTROTItemType);
                RUTROTItemType.DataField = "RUTROTItemType";
                RUTROTWorkTypeID = new Selector("ctl00_phG_tab_t1_cmbRUTROTWorkType", "Type of Work", locator, null);
                RUTROTWorkTypeIDLabel = new Label(RUTROTWorkTypeID);
                RUTROTWorkTypeID.DataField = "RUTROTWorkTypeID";
                DfltEarningType = new Selector("ctl00_phG_tab_t1_edDfltEarningType", "Earning Type", locator, null);
                DfltEarningTypeLabel = new Label(DfltEarningType);
                DfltEarningType.DataField = "DfltEarningType";
                BillingRule = new DropDown("ctl00_phG_tab_t1_edBillingRule", "Billing Rule", locator, null);
                BillingRuleLabel = new Label(BillingRule);
                BillingRule.DataField = "BillingRule";
                BaseItemWeight = new PXNumberEdit("ctl00_phG_tab_t5_edBaseItemWeight", "Weight", locator, null);
                BaseItemWeightLabel = new Label(BaseItemWeight);
                BaseItemWeight.DataField = "BaseItemWeight";
                WeightUOM = new Selector("ctl00_phG_tab_t5_edWeightUOM", "Weight UOM", locator, null);
                WeightUOMLabel = new Label(WeightUOM);
                WeightUOM.DataField = "WeightUOM";
                BaseItemVolume = new PXNumberEdit("ctl00_phG_tab_t5_edBaseItemVolume", "Volume", locator, null);
                BaseItemVolumeLabel = new Label(BaseItemVolume);
                BaseItemVolume.DataField = "BaseItemVolume";
                VolumeUOM = new Selector("ctl00_phG_tab_t5_edVolumeUOM", "Volume UOM", locator, null);
                VolumeUOMLabel = new Label(VolumeUOM);
                VolumeUOM.DataField = "VolumeUOM";
                UndershipThreshold = new PXNumberEdit("ctl00_phG_tab_t5_edUndershipThreshold", "Undership Threshold (%)", locator, null);
                UndershipThresholdLabel = new Label(UndershipThreshold);
                UndershipThreshold.DataField = "UndershipThreshold";
                OvershipThreshold = new PXNumberEdit("ctl00_phG_tab_t5_edOvershipThreshold", "Overship Threshold (%)", locator, null);
                OvershipThresholdLabel = new Label(OvershipThreshold);
                OvershipThreshold.DataField = "OvershipThreshold";
                InvtAcctID = new Selector("ctl00_phG_tab_t7_edInvtAcctID", "Expense Accrual Account", locator, null);
                InvtAcctIDLabel = new Label(InvtAcctID);
                InvtAcctID.DataField = "InvtAcctID";
                InvtSubID = new Selector("ctl00_phG_tab_t7_edInvtSubID", "Expense Accrual Sub.", locator, null);
                InvtSubIDLabel = new Label(InvtSubID);
                InvtSubID.DataField = "InvtSubID";
                ReasonCodeSubID = new Selector("ctl00_phG_tab_t7_edReasonCodeSubID", "Reason Code Sub.", locator, null);
                ReasonCodeSubIDLabel = new Label(ReasonCodeSubID);
                ReasonCodeSubID.DataField = "ReasonCodeSubID";
                COGSAcctID = new Selector("ctl00_phG_tab_t7_edExpenseAccountID", "Expense Account", locator, null);
                COGSAcctIDLabel = new Label(COGSAcctID);
                COGSAcctID.DataField = "COGSAcctID";
                COGSSubID = new Selector("ctl00_phG_tab_t7_edExpenseSubID", "Expense Sub.", locator, null);
                COGSSubIDLabel = new Label(COGSSubID);
                COGSSubID.DataField = "COGSSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t7_edPOAccrualAcctID", "PO Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t7_edPOAccrualSubID", "PO Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                SalesAcctID = new Selector("ctl00_phG_tab_t7_edSalesAcctID", "Sales Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t7_edSalesSubID", "Sales Sub.", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                PPVAcctID = new Selector("ctl00_phG_tab_t7_edPPVAcctID", "Purchase Price Variance Account", locator, null);
                PPVAcctIDLabel = new Label(PPVAcctID);
                PPVAcctID.DataField = "PPVAcctID";
                PPVSubID = new Selector("ctl00_phG_tab_t7_edPPVSubID", "Purchase Price Variance Sub.", locator, null);
                PPVSubIDLabel = new Label(PPVSubID);
                PPVSubID.DataField = "PPVSubID";
                DeferralAcctID = new Selector("ctl00_phG_tab_t7_edDeferralAcctID", "Deferral Account", locator, null);
                DeferralAcctIDLabel = new Label(DeferralAcctID);
                DeferralAcctID.DataField = "DeferralAcctID";
                DeferralSubID = new Selector("ctl00_phG_tab_t7_edDeferralSubID", "Deferral Sub.", locator, null);
                DeferralSubIDLabel = new Label(DeferralSubID);
                DeferralSubID.DataField = "DeferralSubID";
                EarningsAcctID = new Selector("ctl00_phG_tab_t7_edEarningsAcctID", "Earnings Account", locator, null);
                EarningsAcctIDLabel = new Label(EarningsAcctID);
                EarningsAcctID.DataField = "EarningsAcctID";
                EarningsSubID = new Selector("ctl00_phG_tab_t7_edEarningsSubID", "Earnings Sub.", locator, null);
                EarningsSubIDLabel = new Label(EarningsSubID);
                EarningsSubID.DataField = "EarningsSubID";
                BenefitExpenseAcctID = new Selector("ctl00_phG_tab_t7_edBenefitExpenseAcctID", "Benefit Expense Account", locator, null);
                BenefitExpenseAcctIDLabel = new Label(BenefitExpenseAcctID);
                BenefitExpenseAcctID.DataField = "BenefitExpenseAcctID";
                BenefitExpenseSubID = new Selector("ctl00_phG_tab_t7_edBenefitExpenseSubID", "Benefit Expense Sub.", locator, null);
                BenefitExpenseSubIDLabel = new Label(BenefitExpenseSubID);
                BenefitExpenseSubID.DataField = "BenefitExpenseSubID";
                TaxExpenseAcctID = new Selector("ctl00_phG_tab_t7_edTaxExpenseAcctID", "Tax Expense Account", locator, null);
                TaxExpenseAcctIDLabel = new Label(TaxExpenseAcctID);
                TaxExpenseAcctID.DataField = "TaxExpenseAcctID";
                TaxExpenseSubID = new Selector("ctl00_phG_tab_t7_edTaxExpenseSubID", "Tax Expense Sub.", locator, null);
                TaxExpenseSubIDLabel = new Label(TaxExpenseSubID);
                TaxExpenseSubID.DataField = "TaxExpenseSubID";
                ImageUrl = new ImageUploader("ctl00_phG_tab_t8_imgUploader", "Image Url", locator);
                ImageUrlLabel = new Label(ImageUrl);
                ImageUrl.DataField = "ImageUrl";
                Body = new RichTextEdit("ctl00_phG_tab_t9_edBody", "Body", locator, null);
                BodyLabel = new Label(Body);
                Body.DataField = "Body";
                ActionType = new DropDown("ctl00_phG_tab_t13_CstPXDropDown48", "Pickup/Delivery Action", locator, null);
                ActionTypeLabel = new Label(ActionType);
                ActionType.DataField = "ActionType";
                ExportToExternal = new CheckBox("ctl00_phG_tab_t15_edExportToExternal", "Export To External System", locator, null);
                ExportToExternalLabel = new Label(ExportToExternal);
                ExportToExternal.DataField = "ExportToExternal";
                Visibility = new DropDown("ctl00_phG_tab_t15_edVisibility", "Visibility", locator, null);
                VisibilityLabel = new Label(Visibility);
                Visibility.DataField = "Visibility";
                Visibility.Items.Add("X", "Store Default");
                Visibility.Items.Add("V", "Visible");
                Visibility.Items.Add("F", "Featured");
                Visibility.Items.Add("I", "Invisible");
                Availability = new DropDown("ctl00_phG_tab_t15_edAvailability", "Availability", locator, null);
                AvailabilityLabel = new Label(Availability);
                Availability.DataField = "Availability";
                Availability.Items.Add("X", "Store Default");
                Availability.Items.Add("S", "Set as Available (Don\'t Track Qty)");
                Availability.Items.Add("P", "Set as Pre-Order");
                Availability.Items.Add("N", "Do Not Update");
                Availability.Items.Add("D", "Set as Unavailable");
                CustomURL = new PXTextEdit("ctl00_phG_tab_t15_edCustomURL", "Custom URL", locator, null);
                CustomURLLabel = new Label(CustomURL);
                CustomURL.DataField = "CustomURL";
                PageTitle = new InputLocalizable("ctl00_phG_tab_t15_edPageTitle", "Page Title", locator, null);
                PageTitleLabel = new Label(PageTitle);
                PageTitle.DataField = "PageTitle";
                ShortDescription = new InputLocalizable("ctl00_phG_tab_t15_edShortDescription", "Short Description", locator, null);
                ShortDescriptionLabel = new Label(ShortDescription);
                ShortDescription.DataField = "ShortDescription";
                SearchKeywords = new InputLocalizable("ctl00_phG_tab_t15_edSearchKeywords", "Search Keywords", locator, null);
                SearchKeywordsLabel = new Label(SearchKeywords);
                SearchKeywords.DataField = "SearchKeywords";
                MetaKeywords = new InputLocalizable("ctl00_phG_tab_t15_edMetaKeywords", "Meta Keywords", locator, null);
                MetaKeywordsLabel = new Label(MetaKeywords);
                MetaKeywords.DataField = "MetaKeywords";
                MetaDescription = new InputLocalizable("ctl00_phG_tab_t15_edMetaDescription", "Meta Description", locator, null);
                MetaDescriptionLabel = new Label(MetaDescription);
                MetaDescription.DataField = "MetaDescription";
                Label1_importColumnDlg = new Label("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_ = new Label("ctl00_phG_tab_t4_relatedItemsGrid_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_ = new Label("ctl00_phG_tab_t4_relatedItemsGrid_imp_upl_pnl_lblPassword", "Password:", locator, null);
                Ctl08_ = new Label("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_ctl08", "Enter file URL here", locator, null);
                Ctl21_ = new Label("ctl00_phG_tab_t9_edBody_insi2_splitter_rpnl_ctl21", "Enter image URL:", locator, null);
                Pixwidth_ = new Label("ctl00_phG_tab_t9_edBody_imgprops_pixwidth", "Width", locator, null);
                Pixcaption_ = new Label("ctl00_phG_tab_t9_edBody_imgprops_pixcaption", "Caption", locator, null);
                Ctl34_ = new Label("ctl00_phG_tab_t9_edBody_imgprops_ctl34", "px", locator, null);
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ItemClassIDEdit()
            {
                Buttons.ItemClassIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ItemClassIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button PriceClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edItemClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "ItemClassIDEdit", "ctl00_phG_tab");
                    ItemClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemclass_tab : Container
        {
            
			public CheckBox Mem_RouteService { get; }
			public Label Mem_RouteServiceLabel { get; }
            
            public c_itemclass_tab(string locator, string name) : 
                    base(locator, name)
            {
                Mem_RouteService = new CheckBox("ctl00_phG_tab_t0_edRouteService", "Route Service", locator, null);
                Mem_RouteServiceLabel = new Label(Mem_RouteService);
                Mem_RouteService.DataField = "Mem_RouteService";
                DataMemberName = "ItemClass";
            }
        }
        
        public class c_itemsettings_formdr : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector DeferredCode { get; }
			public Label DeferredCodeLabel { get; }
			public PXNumberEdit DefaultTerm { get; }
			public Label DefaultTermLabel { get; }
			public DropDown DefaultTermUOM { get; }
			public Label DefaultTermUOMLabel { get; }
			public CheckBox UseParentSubID { get; }
			public Label UseParentSubIDLabel { get; }
			public PXNumberEdit TotalPercentage { get; }
			public Label TotalPercentageLabel { get; }
            
            public c_itemsettings_formdr(string locator, string name) : 
                    base(locator, name)
            {
                DeferredCode = new Selector("ctl00_phG_tab_t6_formDR_edDeferredCode1", "Deferral Code", locator, null);
                DeferredCodeLabel = new Label(DeferredCode);
                DeferredCode.DataField = "DeferredCode";
                DefaultTerm = new PXNumberEdit("ctl00_phG_tab_t6_formDR_edDefaultTerm", "Default Term", locator, null);
                DefaultTermLabel = new Label(DefaultTerm);
                DefaultTerm.DataField = "DefaultTerm";
                DefaultTermUOM = new DropDown("ctl00_phG_tab_t6_formDR_edDefaultTermUOM", "Default Term UOM", locator, null);
                DefaultTermUOMLabel = new Label(DefaultTermUOM);
                DefaultTermUOM.DataField = "DefaultTermUOM";
                DefaultTermUOM.Items.Add("D", "day(s)");
                DefaultTermUOM.Items.Add("W", "week(s)");
                DefaultTermUOM.Items.Add("M", "month(s)");
                DefaultTermUOM.Items.Add("Y", "year(s)");
                UseParentSubID = new CheckBox("ctl00_phG_tab_t6_formDR_chkUseParentSubID", "Use Component Subaccounts", locator, null);
                UseParentSubIDLabel = new Label(UseParentSubID);
                UseParentSubID.DataField = "UseParentSubID";
                TotalPercentage = new PXNumberEdit("ctl00_phG_tab_t6_formDR_edTotalPercentage", "Total Percentage", locator, null);
                TotalPercentageLabel = new Label(TotalPercentage);
                TotalPercentage.DataField = "TotalPercentage";
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DeferredCodeEdit()
            {
                Buttons.DeferredCodeEdit.Click();
            }
            
            public virtual void DeferredCodeEdit1()
            {
                Buttons.DeferredCodeEdit1.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DeferredCodeEdit { get; }
			public Button DeferredCodeEdit1 { get; }
                
                public PxButtonCollection()
                {
                    DeferredCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDR_edDeferredCode1\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "DeferredCodeEdit", "ctl00_phG_tab_t6_formDR");
                    DeferredCodeEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit1 = new Button("css=div[id=\'ctl00_phG_tab_t6_PXGridComponents_lv0_edDeferredCode\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DeferredCodeEdit", "ctl00_phG_tab_t6_formDR");
                    DeferredCodeEdit1.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemunits_gridunits : Grid<c_itemunits_gridunits.c_grid_row, c_itemunits_gridunits.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_itemunits_gridunits(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_gridUnits");
                DataMemberName = "itemunits";
                Buttons = new PxButtonCollection();
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
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
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
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PostClassIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_tab_t0_gridUnits");
                    Prev = new Button("ctl00_phG_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridUnits");
                    Next = new Button("ctl00_phG_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_tab_t0_gridUnits");
                    Last = new Button("ctl00_phG_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_tab_t0_gridUnits");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown UnitType { get; }
			public PXNumberEdit ItemClassID { get; }
			public PXNumberEdit InventoryID { get; }
			public PXTextEdit FromUnit { get; }
			public DropDown UnitMultDiv { get; }
			public PXNumberEdit UnitRate { get; }
			public PXTextEdit SampleToUnit { get; }
			public PXNumberEdit PriceAdjustmentMultiplier { get; }
			public Selector ToUnit { get; }
                
                public c_grid_row(c_itemunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDown("_ctl00_phG_tab_t0_gridUnits_lv0_ec", "Unit Type", grid.Locator, "UnitType");
                    UnitType.DataField = "UnitType";
                    UnitType.Items.Add("1", "Inventory Item");
                    UnitType.Items.Add("2", "Item Class");
                    UnitType.Items.Add("3", "Global");
                    ItemClassID = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    InventoryID = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    FromUnit = new PXTextEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", grid.Locator, "FromUnit");
                    FromUnit.DataField = "FromUnit";
                    UnitMultDiv = new DropDown("_ctl00_phG_tab_t0_gridUnits_lv0_ec", "Multiply/Divide", grid.Locator, "UnitMultDiv");
                    UnitMultDiv.DataField = "UnitMultDiv";
                    UnitMultDiv.Items.Add("M", "Multiply");
                    UnitMultDiv.Items.Add("D", "Divide");
                    UnitRate = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", grid.Locator, "UnitRate");
                    UnitRate.DataField = "UnitRate";
                    SampleToUnit = new PXTextEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", grid.Locator, "SampleToUnit");
                    SampleToUnit.DataField = "SampleToUnit";
                    PriceAdjustmentMultiplier = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_en", "Price Adjustment Multiplier", grid.Locator, "PriceAdjustmentMultiplier");
                    PriceAdjustmentMultiplier.DataField = "PriceAdjustmentMultiplier";
                    ToUnit = new Selector("_ctl00_phG_tab_t0_gridUnits_lv0_es", "To Unit", grid.Locator, "ToUnit");
                    ToUnit.DataField = "ToUnit";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter UnitType { get; }
				public PXNumberEditColumnFilter ItemClassID { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter FromUnit { get; }
				public DropDownColumnFilter UnitMultDiv { get; }
				public PXNumberEditColumnFilter UnitRate { get; }
				public PXTextEditColumnFilter SampleToUnit { get; }
				public PXNumberEditColumnFilter PriceAdjustmentMultiplier { get; }
				public SelectorColumnFilter ToUnit { get; }
                
                public c_grid_header(c_itemunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDownColumnFilter(grid.Row.UnitType);
                    ItemClassID = new PXNumberEditColumnFilter(grid.Row.ItemClassID);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    FromUnit = new PXTextEditColumnFilter(grid.Row.FromUnit);
                    UnitMultDiv = new DropDownColumnFilter(grid.Row.UnitMultDiv);
                    UnitRate = new PXNumberEditColumnFilter(grid.Row.UnitRate);
                    SampleToUnit = new PXTextEditColumnFilter(grid.Row.SampleToUnit);
                    PriceAdjustmentMultiplier = new PXNumberEditColumnFilter(grid.Row.PriceAdjustmentMultiplier);
                    ToUnit = new SelectorColumnFilter(grid.Row.ToUnit);
                }
            }
        }
        
        public class c_itemunits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public PXNumberEdit InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public PXTextEdit FromUnit { get; }
			public Label FromUnitLabel { get; }
			public PXTextEdit SampleToUnit { get; }
			public Label SampleToUnitLabel { get; }
			public PXNumberEdit UnitRate { get; }
			public Label UnitRateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_itemunits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ItemClassID = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                InventoryID = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                FromUnit = new PXTextEdit("ctl00_phG_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", locator, null);
                FromUnitLabel = new Label(FromUnit);
                FromUnit.DataField = "FromUnit";
                SampleToUnit = new PXTextEdit("ctl00_phG_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", locator, null);
                SampleToUnitLabel = new Label(SampleToUnit);
                SampleToUnit.DataField = "SampleToUnit";
                UnitRate = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", locator, null);
                UnitRateLabel = new Label(UnitRate);
                UnitRate.DataField = "UnitRate";
                Es = new Selector("ctl00_phG_tab_t0_gridUnits_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t0_gridUnits_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_gridUnits_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t0_gridUnits_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "itemunits";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
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
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PostClassIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Next = new Button("ctl00_phG_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Last = new Button("ctl00_phG_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_tab_t0_gridUnits_lv0");
                }
            }
        }
        
        public class c_components_pxgridcomponents : Grid<c_components_pxgridcomponents.c_grid_row, c_components_pxgridcomponents.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_components_pxgridcomponents(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_PXGridComponents");
                DataMemberName = "Components";
                Buttons = new PxButtonCollection();
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
            
            public virtual void DeferredCodeEdit()
            {
                Buttons.DeferredCodeEdit.Click();
            }
            
            public virtual void DeferredCodeEdit1()
            {
                Buttons.DeferredCodeEdit1.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridComponents_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DeferredCodeEdit { get; }
			public Button DeferredCodeEdit1 { get; }
                
                public PxButtonCollection()
                {
                    DeferredCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDR_edDeferredCode1\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "DeferredCodeEdit", "ctl00_phG_tab_t6_PXGridComponents");
                    DeferredCodeEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit1 = new Button("css=div[id=\'ctl00_phG_tab_t6_PXGridComponents_lv0_edDeferredCode\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DeferredCodeEdit", "ctl00_phG_tab_t6_PXGridComponents");
                    DeferredCodeEdit1.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector ComponentID { get; }
			public Selector SalesAcctID { get; }
			public Selector SalesSubID { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public Selector DeferredCode { get; }
			public PXNumberEdit DefaultTerm { get; }
			public DropDown DefaultTermUOM { get; }
			public DropDown AmtOption { get; }
			public PXNumberEdit FixedAmt { get; }
			public PXNumberEdit Percentage { get; }
			public PXNumberEdit InventoryID { get; }
                
                public c_grid_row(c_components_pxgridcomponents grid) : 
                        base(grid)
                {
                    ComponentID = new Selector("_ctl00_phG_tab_t6_PXGridComponents_lv0_edComponentID", "Inventory ID", grid.Locator, "ComponentID");
                    ComponentID.DataField = "ComponentID";
                    SalesAcctID = new Selector("_ctl00_phG_tab_t6_PXGridComponents_lv0_edSalesAcctID", "Sales Account", grid.Locator, "SalesAcctID");
                    SalesAcctID.DataField = "SalesAcctID";
                    SalesSubID = new Selector("_ctl00_phG_tab_t6_PXGridComponents_lv0_edSalesSubID", "Sales Sub.", grid.Locator, "SalesSubID");
                    SalesSubID.DataField = "SalesSubID";
                    UOM = new Selector("_ctl00_phG_tab_t6_PXGridComponents_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t6_PXGridComponents_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    DeferredCode = new Selector("_ctl00_phG_tab_t6_PXGridComponents_lv0_edDeferredCode", "Deferral Code", grid.Locator, "DeferredCode");
                    DeferredCode.DataField = "DeferredCode";
                    DefaultTerm = new PXNumberEdit("_ctl00_phG_tab_t6_PXGridComponents_lv0_edDefaultTerm", "Default Term", grid.Locator, "DefaultTerm");
                    DefaultTerm.DataField = "DefaultTerm";
                    DefaultTermUOM = new DropDown("_ctl00_phG_tab_t6_PXGridComponents_lv0_ec", "Default Term UOM", grid.Locator, "DefaultTermUOM");
                    DefaultTermUOM.DataField = "DefaultTermUOM";
                    DefaultTermUOM.Items.Add("D", "day(s)");
                    DefaultTermUOM.Items.Add("W", "week(s)");
                    DefaultTermUOM.Items.Add("M", "month(s)");
                    DefaultTermUOM.Items.Add("Y", "year(s)");
                    AmtOption = new DropDown("_ctl00_phG_tab_t6_PXGridComponents_lv0_edPriceOption", "Allocation Method", grid.Locator, "AmtOption");
                    AmtOption.DataField = "AmtOption";
                    AmtOption.Items.Add("P", "Percentage");
                    AmtOption.Items.Add("F", "Fixed Amount");
                    AmtOption.Items.Add("R", "Residual");
                    FixedAmt = new PXNumberEdit("_ctl00_phG_tab_t6_PXGridComponents_lv0_edFixedAmt", "Fixed Amount", grid.Locator, "FixedAmt");
                    FixedAmt.DataField = "FixedAmt";
                    Percentage = new PXNumberEdit("_ctl00_phG_tab_t6_PXGridComponents_lv0_edPercentage", "Percentage", grid.Locator, "Percentage");
                    Percentage.DataField = "Percentage";
                    InventoryID = new PXNumberEdit("ctl00_phG_tab_t6_PXGridComponents_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter ComponentID { get; }
				public SelectorColumnFilter SalesAcctID { get; }
				public SelectorColumnFilter SalesSubID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter DeferredCode { get; }
				public PXNumberEditColumnFilter DefaultTerm { get; }
				public DropDownColumnFilter DefaultTermUOM { get; }
				public DropDownColumnFilter AmtOption { get; }
				public PXNumberEditColumnFilter FixedAmt { get; }
				public PXNumberEditColumnFilter Percentage { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
                
                public c_grid_header(c_components_pxgridcomponents grid) : 
                        base(grid)
                {
                    ComponentID = new SelectorColumnFilter(grid.Row.ComponentID);
                    SalesAcctID = new SelectorColumnFilter(grid.Row.SalesAcctID);
                    SalesSubID = new SelectorColumnFilter(grid.Row.SalesSubID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    DeferredCode = new SelectorColumnFilter(grid.Row.DeferredCode);
                    DefaultTerm = new PXNumberEditColumnFilter(grid.Row.DefaultTerm);
                    DefaultTermUOM = new DropDownColumnFilter(grid.Row.DefaultTermUOM);
                    AmtOption = new DropDownColumnFilter(grid.Row.AmtOption);
                    FixedAmt = new PXNumberEditColumnFilter(grid.Row.FixedAmt);
                    Percentage = new PXNumberEditColumnFilter(grid.Row.Percentage);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_components_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown AmtOption { get; }
			public Label AmtOptionLabel { get; }
			public Selector ComponentID { get; }
			public Label ComponentIDLabel { get; }
			public PXNumberEdit FixedAmt { get; }
			public Label FixedAmtLabel { get; }
			public Selector DeferredCode { get; }
			public Label DeferredCodeLabel { get; }
			public PXNumberEdit DefaultTerm { get; }
			public Label DefaultTermLabel { get; }
			public PXNumberEdit Percentage { get; }
			public Label PercentageLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_components_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AmtOption = new DropDown("ctl00_phG_tab_t6_PXGridComponents_lv0_edPriceOption", "Allocation Method", locator, null);
                AmtOptionLabel = new Label(AmtOption);
                AmtOption.DataField = "AmtOption";
                AmtOption.Items.Add("P", "Percentage");
                AmtOption.Items.Add("F", "Fixed Amount");
                AmtOption.Items.Add("R", "Residual");
                ComponentID = new Selector("ctl00_phG_tab_t6_PXGridComponents_lv0_edComponentID", "Inventory ID", locator, null);
                ComponentIDLabel = new Label(ComponentID);
                ComponentID.DataField = "ComponentID";
                FixedAmt = new PXNumberEdit("ctl00_phG_tab_t6_PXGridComponents_lv0_edFixedAmt", "Fixed Amount", locator, null);
                FixedAmtLabel = new Label(FixedAmt);
                FixedAmt.DataField = "FixedAmt";
                DeferredCode = new Selector("ctl00_phG_tab_t6_PXGridComponents_lv0_edDeferredCode", "Deferral Code", locator, null);
                DeferredCodeLabel = new Label(DeferredCode);
                DeferredCode.DataField = "DeferredCode";
                DefaultTerm = new PXNumberEdit("ctl00_phG_tab_t6_PXGridComponents_lv0_edDefaultTerm", "Default Term", locator, null);
                DefaultTermLabel = new Label(DefaultTerm);
                DefaultTerm.DataField = "DefaultTerm";
                Percentage = new PXNumberEdit("ctl00_phG_tab_t6_PXGridComponents_lv0_edPercentage", "Percentage", locator, null);
                PercentageLabel = new Label(Percentage);
                Percentage.DataField = "Percentage";
                SalesAcctID = new Selector("ctl00_phG_tab_t6_PXGridComponents_lv0_edSalesAcctID", "Sales Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t6_PXGridComponents_lv0_edSalesSubID", "Sales Sub.", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                UOM = new Selector("ctl00_phG_tab_t6_PXGridComponents_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t6_PXGridComponents_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                Es = new Selector("ctl00_phG_tab_t6_PXGridComponents_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t6_PXGridComponents_lv0_ec", "Ec", locator, null);
                DataMemberName = "Components";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ComponentIDEdit()
            {
                Buttons.ComponentIDEdit.Click();
            }
            
            public virtual void DeferredCodeEdit()
            {
                Buttons.DeferredCodeEdit.Click();
            }
            
            public virtual void DeferredCodeEdit1()
            {
                Buttons.DeferredCodeEdit1.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ComponentIDEdit { get; }
			public Button DeferredCodeEdit { get; }
			public Button DeferredCodeEdit1 { get; }
                
                public PxButtonCollection()
                {
                    ComponentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_PXGridComponents_lv0_edComponentID\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "ComponentIDEdit", "ctl00_phG_tab_t6_PXGridComponents_lv0");
                    ComponentIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_PXGridComponents_lv0_edDeferredCode\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DeferredCodeEdit", "ctl00_phG_tab_t6_PXGridComponents_lv0");
                    DeferredCodeEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit1 = new Button("css=div[id=\'ctl00_phG_tab_t6_formDR_edDeferredCode1\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "DeferredCodeEdit", "ctl00_phG_tab_t6_PXGridComponents_lv0");
                    DeferredCodeEdit1.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemxrefrecords_crossgrid : Grid<c_itemxrefrecords_crossgrid.c_grid_row, c_itemxrefrecords_crossgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_itemxrefrecords_crossgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_crossgrid");
                DataMemberName = "itemxrefrecords";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_crossgrid_fe_gf", "FilterForm");
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
            
            public virtual void UOMEdit()
            {
                Buttons.UOMEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_crossgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button UOMEdit { get; }
                
                public PxButtonCollection()
                {
                    UOMEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_crossgrid_lv0_edxUOM\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "UOMEdit", "ctl00_phG_tab_t3_crossgrid");
                    UOMEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown AlternateType { get; }
			public Selector BAccountID { get; }
			public PXTextEdit AlternateID { get; }
			public Selector UOM { get; }
			public PXTextEdit Descr { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
                
                public c_grid_row(c_itemxrefrecords_crossgrid grid) : 
                        base(grid)
                {
                    AlternateType = new DropDown("_ctl00_phG_tab_t3_crossgrid_lv0_ec", "Alternate Type", grid.Locator, "AlternateType");
                    AlternateType.DataField = "AlternateType";
                    AlternateType.Items.Add("0CPN", "Customer Part Number");
                    AlternateType.Items.Add("0VPN", "Vendor Part Number");
                    AlternateType.Items.Add("GLBL", "Global");
                    AlternateType.Items.Add("BAR", "Barcode");
                    BAccountID = new Selector("_ctl00_phG_tab_t3_crossgrid_lv0_edBAccountID", "Vendor/Customer", grid.Locator, "BAccountID");
                    BAccountID.DataField = "BAccountID";
                    AlternateID = new PXTextEdit("_ctl00_phG_tab_t3_crossgrid_lv0_edAlternateID", "Alternate ID", grid.Locator, "AlternateID");
                    AlternateID.DataField = "AlternateID";
                    UOM = new Selector("_ctl00_phG_tab_t3_crossgrid_lv0_edxUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Descr = new PXTextEdit("_ctl00_phG_tab_t3_crossgrid_lv0_edDescr", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    InventoryID = new Selector("_ctl00_phG_tab_t3_crossgrid_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_tab_t3_crossgrid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter AlternateType { get; }
				public SelectorColumnFilter BAccountID { get; }
				public PXTextEditColumnFilter AlternateID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
                
                public c_grid_header(c_itemxrefrecords_crossgrid grid) : 
                        base(grid)
                {
                    AlternateType = new DropDownColumnFilter(grid.Row.AlternateType);
                    BAccountID = new SelectorColumnFilter(grid.Row.BAccountID);
                    AlternateID = new PXTextEditColumnFilter(grid.Row.AlternateID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                }
            }
        }
        
        public class c_itemxrefrecords_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BAccountID { get; }
			public Label BAccountIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public PXTextEdit AlternateID { get; }
			public Label AlternateIDLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_itemxrefrecords_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BAccountID = new Selector("ctl00_phG_tab_t3_crossgrid_lv0_edBAccountID", "Vendor/Customer", locator, null);
                BAccountIDLabel = new Label(BAccountID);
                BAccountID.DataField = "BAccountID";
                UOM = new Selector("ctl00_phG_tab_t3_crossgrid_lv0_edxUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                SubItemID = new Selector("ctl00_phG_tab_t3_crossgrid_lv0_edSubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                AlternateID = new PXTextEdit("ctl00_phG_tab_t3_crossgrid_lv0_edAlternateID", "Alternate ID", locator, null);
                AlternateIDLabel = new Label(AlternateID);
                AlternateID.DataField = "AlternateID";
                Descr = new PXTextEdit("ctl00_phG_tab_t3_crossgrid_lv0_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                Es = new Selector("ctl00_phG_tab_t3_crossgrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t3_crossgrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "itemxrefrecords";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BAccountIDEdit()
            {
                Buttons.BAccountIDEdit.Click();
            }
            
            public virtual void UOMEdit()
            {
                Buttons.UOMEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BAccountIDEdit { get; }
			public Button UOMEdit { get; }
                
                public PxButtonCollection()
                {
                    BAccountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_crossgrid_lv0_edBAccountID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "BAccountIDEdit", "ctl00_phG_tab_t3_crossgrid_lv0");
                    BAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    UOMEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_crossgrid_lv0_edxUOM\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "UOMEdit", "ctl00_phG_tab_t3_crossgrid_lv0");
                    UOMEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_vendoritems_pxgridvendoritems : Grid<c_vendoritems_pxgridvendoritems.c_grid_row, c_vendoritems_pxgridvendoritems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_vendoritems_pxgridvendoritems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_PXGridVendorItems");
                DataMemberName = "VendorItems";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_PXGridVendorItems_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_PXGridVendorItems_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public CheckBox IsDefault { get; }
			public Selector VendorID { get; }
			public PXTextEdit Vendor__AcctName { get; }
			public Selector VendorLocationID { get; }
			public Selector PurchaseUnit { get; }
			public PXTextEdit VendorInventoryID { get; }
			public Selector CuryID { get; }
			public PXNumberEdit LastPrice { get; }
			public PXNumberEdit PrepaymentPct { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_vendoritems_pxgridvendoritems grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_vp_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    IsDefault = new CheckBox("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_IsDefault", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    VendorID = new Selector("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_edVendorID", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    Vendor__AcctName = new PXTextEdit("ctl00_phG_tab_t2_PXGridVendorItems_ei", "Vendor Name", grid.Locator, "Vendor__AcctName");
                    Vendor__AcctName.DataField = "Vendor__AcctName";
                    VendorLocationID = new Selector("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_edVendorLocationID", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    PurchaseUnit = new Selector("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_es", "Purchase Unit", grid.Locator, "PurchaseUnit");
                    PurchaseUnit.DataField = "PurchaseUnit";
                    VendorInventoryID = new PXTextEdit("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_edVendorInventoryID", "Vendor Inventory ID", grid.Locator, "VendorInventoryID");
                    VendorInventoryID.DataField = "VendorInventoryID";
                    CuryID = new Selector("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_es", "Currency ID", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    LastPrice = new PXNumberEdit("_ctl00_phG_tab_t2_PXGridVendorItems_lv0_edLastPrice", "Last Vendor Price", grid.Locator, "LastPrice");
                    LastPrice.DataField = "LastPrice";
                    PrepaymentPct = new PXNumberEdit("ctl00_phG_tab_t2_PXGridVendorItems_en", "Prepayment Percent", grid.Locator, "PrepaymentPct");
                    PrepaymentPct.DataField = "PrepaymentPct";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t2_PXGridVendorItems_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public SelectorColumnFilter VendorID { get; }
				public PXTextEditColumnFilter Vendor__AcctName { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public SelectorColumnFilter PurchaseUnit { get; }
				public PXTextEditColumnFilter VendorInventoryID { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter LastPrice { get; }
				public PXNumberEditColumnFilter PrepaymentPct { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_vendoritems_pxgridvendoritems grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    Vendor__AcctName = new PXTextEditColumnFilter(grid.Row.Vendor__AcctName);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    PurchaseUnit = new SelectorColumnFilter(grid.Row.PurchaseUnit);
                    VendorInventoryID = new PXTextEditColumnFilter(grid.Row.VendorInventoryID);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    LastPrice = new PXNumberEditColumnFilter(grid.Row.LastPrice);
                    PrepaymentPct = new PXNumberEditColumnFilter(grid.Row.PrepaymentPct);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_vendoritems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public PXTextEdit VendorInventoryID { get; }
			public Label VendorInventoryIDLabel { get; }
			public PXNumberEdit LastPrice { get; }
			public Label LastPriceLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_vendoritems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Active = new CheckBox("ctl00_phG_tab_t2_PXGridVendorItems_lv0_vp_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                IsDefault = new CheckBox("ctl00_phG_tab_t2_PXGridVendorItems_lv0_IsDefault", "Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                VendorID = new Selector("ctl00_phG_tab_t2_PXGridVendorItems_lv0_edVendorID", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                VendorLocationID = new Selector("ctl00_phG_tab_t2_PXGridVendorItems_lv0_edVendorLocationID", "Location", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                VendorInventoryID = new PXTextEdit("ctl00_phG_tab_t2_PXGridVendorItems_lv0_edVendorInventoryID", "Vendor Inventory ID", locator, null);
                VendorInventoryIDLabel = new Label(VendorInventoryID);
                VendorInventoryID.DataField = "VendorInventoryID";
                LastPrice = new PXNumberEdit("ctl00_phG_tab_t2_PXGridVendorItems_lv0_edLastPrice", "Last Vendor Price", locator, null);
                LastPriceLabel = new Label(LastPrice);
                LastPrice.DataField = "LastPrice";
                Es = new Selector("ctl00_phG_tab_t2_PXGridVendorItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "VendorItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void VendorIDEdit()
            {
                Buttons.VendorIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button VendorIDEdit { get; }
                
                public PxButtonCollection()
                {
                    VendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_PXGridVendorItems_lv0_edVendorID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "VendorIDEdit", "ctl00_phG_tab_t2_PXGridVendorItems_lv0");
                    VendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_answers_pxgridanswers : Grid<c_answers_pxgridanswers.c_grid_row, c_answers_pxgridanswers.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_answers_pxgridanswers(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "Answers";
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
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridAnswers");
                    Prev = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridAnswers");
                    Next = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridAnswers");
                    Last = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridAnswers");
                    First1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridAnswers");
                    Prev1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridAnswers");
                    Next1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridAnswers");
                    Last1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridAnswers");
                    UpBtn = new Button("ctl00_phG_tab_t8_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t8_PXGridAnswers");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit AttributeID { get; }
			public CheckBox IsRequired { get; }
			public DropDown AttributeCategory { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit RefNoteID { get; }
                
                public c_grid_row(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new PXTextEdit("_ctl00_phG_tab_t8_PXGridAnswers_lv0_edParameterID", "Attribute", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    IsRequired = new CheckBox("ctl00_phG_tab_t8_PXGridAnswers", "Required", grid.Locator, "isRequired");
                    IsRequired.DataField = "isRequired";
                    AttributeCategory = new DropDown("_ctl00_phG_tab_t8_PXGridAnswers_lv0_ec", "Category", grid.Locator, "AttributeCategory");
                    AttributeCategory.DataField = "AttributeCategory";
                    AttributeCategory.Items.Add("A", "Attribute");
                    AttributeCategory.Items.Add("V", "Variant");
                    Value = new PXTextEdit("_ctl00_phG_tab_t8_PXGridAnswers_lv0_edAnswerValue", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t8_PXGridAnswers_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter AttributeID { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public DropDownColumnFilter AttributeCategory { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
                
                public c_grid_header(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new PXTextEditColumnFilter(grid.Row.AttributeID);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    AttributeCategory = new DropDownColumnFilter(grid.Row.AttributeCategory);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                }
            }
        }
        
        public class c_answers_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AttributeID { get; }
			public Label AttributeIDLabel { get; }
			public PXTextEdit Value { get; }
			public Label ValueLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_answers_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AttributeID = new PXTextEdit("ctl00_phG_tab_t8_PXGridAnswers_lv0_edParameterID", "Attribute", locator, null);
                AttributeIDLabel = new Label(AttributeID);
                AttributeID.DataField = "AttributeID";
                Value = new PXTextEdit("ctl00_phG_tab_t8_PXGridAnswers_lv0_edAnswerValue", "Value", locator, null);
                ValueLabel = new Label(Value);
                Value.DataField = "Value";
                Es = new Selector("ctl00_phG_tab_t8_PXGridAnswers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t8_PXGridAnswers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t8_PXGridAnswers_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t8_PXGridAnswers_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Answers";
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
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    Prev = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    Next = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    Last = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    First1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    Next1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    Last1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                    UpBtn = new Button("ctl00_phG_tab_t8_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t8_PXGridAnswers_lv0");
                }
            }
        }
        
        public class c_category_pxgridcategory : Grid<c_category_pxgridcategory.c_grid_row, c_category_pxgridcategory.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_category_pxgridcategory(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_PXGridCategory");
                DataMemberName = "Category";
                Buttons = new PxButtonCollection();
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
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
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
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_PXGridCategory_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_PXGridCategory_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_PXGridCategory_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_PXGridCategory_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridCategory");
                    Prev = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridCategory");
                    Next = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridCategory");
                    Last = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridCategory");
                    First1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridCategory");
                    Prev1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridCategory");
                    Next1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridCategory");
                    Last1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridCategory");
                    UpBtn = new Button("ctl00_phG_tab_t8_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t8_PXGridCategory");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public TreeSelector CategoryID { get; }
			public Selector InventoryID { get; }
                
                public c_grid_row(c_category_pxgridcategory grid) : 
                        base(grid)
                {
                    CategoryID = new TreeSelector("_ctl00_phG_tab_t8_PXGridCategory_lv0_edParent", "Category ID", grid.Locator, "CategoryID");
                    CategoryID.DataField = "CategoryID";
                    InventoryID = new Selector("_ctl00_phG_tab_t8_PXGridCategory_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public TreeSelectorColumnFilter CategoryID { get; }
				public SelectorColumnFilter InventoryID { get; }
                
                public c_grid_header(c_category_pxgridcategory grid) : 
                        base(grid)
                {
                    CategoryID = new TreeSelectorColumnFilter(grid.Row.CategoryID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_category_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public TreeSelector CategoryID { get; }
			public Label CategoryIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_category_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CategoryID = new TreeSelector("ctl00_phG_tab_t8_PXGridCategory_lv0_edParent", "Category ID", locator, null);
                CategoryIDLabel = new Label(CategoryID);
                CategoryID.DataField = "CategoryID";
                Es = new Selector("ctl00_phG_tab_t8_PXGridCategory_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Category";
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
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    Prev = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    Next = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    Last = new Button("ctl00_phG_tab_t8_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    First1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    Next1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    Last1 = new Button("ctl00_phG_tab_t8_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                    UpBtn = new Button("ctl00_phG_tab_t8_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t8_PXGridCategory_lv0");
                }
            }
        }
        
        public class c_relateditems_relateditemsgrid : Grid<c_relateditems_relateditemsgrid.c_grid_row, c_relateditems_relateditemsgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public Note NotePanel { get; }
            
            public c_relateditems_relateditemsgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_relatedItemsGrid");
                DataMemberName = "RelatedItems";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t4_relatedItemsGrid_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_relatedItemsGrid_fe_gf", "FilterForm");
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
            
            public virtual void RelatedInventoryIDEdit()
            {
                Buttons.RelatedInventoryIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_relatedItemsGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RelatedInventoryIDEdit { get; }
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
                    RelatedInventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryID\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "RelatedInventoryIDEdit", "ctl00_phG_tab_t4_relatedItemsGrid");
                    RelatedInventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Ok = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Cancel = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Ok1 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Cancel1 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid");
                    First = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Prev = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Next = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Last = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Ok2 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Cancel2 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid");
                    Upload1 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t4_relatedItemsGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public NoteColumnButton Notes { get; }
			public DropDown Relation { get; }
			public PXNumberEdit Rank { get; }
			public DropDown Tag { get; }
			public Selector RelatedInventoryID { get; }
			public PXTextEdit Desc { get; }
			public Selector UOM { get; }
			public DateSelector EffectiveDate { get; }
			public DateSelector ExpirationDate { get; }
			public CheckBox IsActive { get; }
			public PXNumberEdit InventoryID { get; }
			public PXNumberEdit LineID { get; }
                
                public c_grid_row(c_relateditems_relateditemsgrid grid) : 
                        base(grid)
                {
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Relation = new DropDown("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelation", "Relation", grid.Locator, "Relation");
                    Relation.DataField = "Relation";
                    Relation.Items.Add("CSELL", "Cross-Sell");
                    Relation.Items.Add("USELL", "Up-Sell");
                    Relation.Items.Add("RLTD", "Related");
                    Relation.Items.Add("SUBST", "Substitute");
                    Relation.Items.Add("ALT", "Alternative");
                    Rank = new PXNumberEdit("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRank", "Rank", grid.Locator, "Rank");
                    Rank.DataField = "Rank";
                    Tag = new DropDown("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edTag", "Tag", grid.Locator, "Tag");
                    Tag.DataField = "Tag";
                    Tag.Items.Add("COMP", "Complementary Items");
                    Tag.Items.Add("INTS", "Items of Interest");
                    Tag.Items.Add("USER", "Other Users Bought");
                    Tag.Items.Add("ESNT", "Essential Related Products");
                    Tag.Items.Add("SERV", "Services");
                    Tag.Items.Add("PREM", "Premium");
                    Tag.Items.Add("CUST", "Customization");
                    Tag.Items.Add("OPTN", "Options");
                    Tag.Items.Add("PROM", "Promotional");
                    Tag.Items.Add("POPL", "Popular");
                    Tag.Items.Add("SEAS", "Seasonal");
                    Tag.Items.Add("RLTD", "Related");
                    Tag.Items.Add("SUBS", "Substitute");
                    Tag.Items.Add("ALTN", "Alternative");
                    RelatedInventoryID = new Selector("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryID", "Inventory ID", grid.Locator, "RelatedInventoryID");
                    RelatedInventoryID.DataField = "RelatedInventoryID";
                    Desc = new PXTextEdit("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryDesc", "Description", grid.Locator, "Desc");
                    Desc.DataField = "Desc";
                    UOM = new Selector("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    EffectiveDate = new DateSelector("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edEffectiveDate", "Effective Date", grid.Locator, "EffectiveDate");
                    EffectiveDate.DataField = "EffectiveDate";
                    ExpirationDate = new DateSelector("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edExpirationDate", "Expiration Date", grid.Locator, "ExpirationDate");
                    ExpirationDate.DataField = "ExpirationDate";
                    IsActive = new CheckBox("_ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedItemIsActive", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    InventoryID = new PXNumberEdit("ctl00_phG_tab_t4_relatedItemsGrid_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineID = new PXNumberEdit("ctl00_phG_tab_t4_relatedItemsGrid_en", "LineID", grid.Locator, "LineID");
                    LineID.DataField = "LineID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter Relation { get; }
				public PXNumberEditColumnFilter Rank { get; }
				public DropDownColumnFilter Tag { get; }
				public SelectorColumnFilter RelatedInventoryID { get; }
				public PXTextEditColumnFilter Desc { get; }
				public SelectorColumnFilter UOM { get; }
				public DateSelectorColumnFilter EffectiveDate { get; }
				public DateSelectorColumnFilter ExpirationDate { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter LineID { get; }
                
                public c_grid_header(c_relateditems_relateditemsgrid grid) : 
                        base(grid)
                {
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Relation = new DropDownColumnFilter(grid.Row.Relation);
                    Rank = new PXNumberEditColumnFilter(grid.Row.Rank);
                    Tag = new DropDownColumnFilter(grid.Row.Tag);
                    RelatedInventoryID = new SelectorColumnFilter(grid.Row.RelatedInventoryID);
                    Desc = new PXTextEditColumnFilter(grid.Row.Desc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    EffectiveDate = new DateSelectorColumnFilter(grid.Row.EffectiveDate);
                    ExpirationDate = new DateSelectorColumnFilter(grid.Row.ExpirationDate);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    LineID = new PXNumberEditColumnFilter(grid.Row.LineID);
                }
            }
        }
        
        public class c_relateditems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Relation { get; }
			public Label RelationLabel { get; }
			public PXNumberEdit Rank { get; }
			public Label RankLabel { get; }
			public DropDown Tag { get; }
			public Label TagLabel { get; }
			public Selector RelatedInventoryID { get; }
			public Label RelatedInventoryIDLabel { get; }
			public PXTextEdit Desc { get; }
			public Label DescLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public DateSelector EffectiveDate { get; }
			public Label EffectiveDateLabel { get; }
			public DateSelector ExpirationDate { get; }
			public Label ExpirationDateLabel { get; }
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_relateditems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Relation = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelation", "Relation", locator, null);
                RelationLabel = new Label(Relation);
                Relation.DataField = "Relation";
                Relation.Items.Add("CSELL", "Cross-Sell");
                Relation.Items.Add("USELL", "Up-Sell");
                Relation.Items.Add("RLTD", "Related");
                Relation.Items.Add("SUBST", "Substitute");
                Relation.Items.Add("ALT", "Alternative");
                Rank = new PXNumberEdit("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRank", "Rank", locator, null);
                RankLabel = new Label(Rank);
                Rank.DataField = "Rank";
                Tag = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edTag", "Tag", locator, null);
                TagLabel = new Label(Tag);
                Tag.DataField = "Tag";
                Tag.Items.Add("COMP", "Complementary Items");
                Tag.Items.Add("INTS", "Items of Interest");
                Tag.Items.Add("USER", "Other Users Bought");
                Tag.Items.Add("ESNT", "Essential Related Products");
                Tag.Items.Add("SERV", "Services");
                Tag.Items.Add("PREM", "Premium");
                Tag.Items.Add("CUST", "Customization");
                Tag.Items.Add("OPTN", "Options");
                Tag.Items.Add("PROM", "Promotional");
                Tag.Items.Add("POPL", "Popular");
                Tag.Items.Add("SEAS", "Seasonal");
                Tag.Items.Add("RLTD", "Related");
                Tag.Items.Add("SUBS", "Substitute");
                Tag.Items.Add("ALTN", "Alternative");
                RelatedInventoryID = new Selector("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryID", "Inventory ID", locator, null);
                RelatedInventoryIDLabel = new Label(RelatedInventoryID);
                RelatedInventoryID.DataField = "RelatedInventoryID";
                Desc = new PXTextEdit("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryDesc", "Description", locator, null);
                DescLabel = new Label(Desc);
                Desc.DataField = "Desc";
                UOM = new Selector("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                EffectiveDate = new DateSelector("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edEffectiveDate", "Effective Date", locator, null);
                EffectiveDateLabel = new Label(EffectiveDate);
                EffectiveDate.DataField = "EffectiveDate";
                ExpirationDate = new DateSelector("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edExpirationDate", "Expiration Date", locator, null);
                ExpirationDateLabel = new Label(ExpirationDate);
                ExpirationDate.DataField = "ExpirationDate";
                IsActive = new CheckBox("ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedItemIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                Es = new Selector("ctl00_phG_tab_t4_relatedItemsGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "RelatedItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void RelatedInventoryIDEdit()
            {
                Buttons.RelatedInventoryIDEdit.Click();
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
                
			public Button RelatedInventoryIDEdit { get; }
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
                    RelatedInventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_relatedItemsGrid_lv0_edRelatedInventoryID\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "RelatedInventoryIDEdit", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    RelatedInventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Ok = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Cancel = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    First = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Prev = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Next = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Last = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                    Upload = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t4_relatedItemsGrid_lv0");
                }
            }
        }
        
        public class c_inventoryfileurls_gridinventoryfileurls : Grid<c_inventoryfileurls_gridinventoryfileurls.c_grid_row, c_inventoryfileurls_gridinventoryfileurls.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_inventoryfileurls_gridinventoryfileurls(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t15_gridInventoryFileUrls");
                DataMemberName = "InventoryFileUrls";
                Buttons = new PxButtonCollection();
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
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
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
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridInventoryFileUrls_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridInventoryFileUrls_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridInventoryFileUrls_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridInventoryFileUrls_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfFirst0", "First", "ctl00_phG_tab_t15_gridInventoryFileUrls");
                    Prev = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfPrev0", "Prev", "ctl00_phG_tab_t15_gridInventoryFileUrls");
                    Next = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfNext0", "Next", "ctl00_phG_tab_t15_gridInventoryFileUrls");
                    Last = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfLast0", "Last", "ctl00_phG_tab_t15_gridInventoryFileUrls");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit FileURL { get; }
			public DropDown FileType { get; }
			public PXNumberEdit FileID { get; }
                
                public c_grid_row(c_inventoryfileurls_gridinventoryfileurls grid) : 
                        base(grid)
                {
                    FileURL = new PXTextEdit("ctl00_phG_tab_t15_gridInventoryFileUrls_ei", "URL", grid.Locator, "FileURL");
                    FileURL.DataField = "FileURL";
                    FileType = new DropDown("_ctl00_phG_tab_t15_gridInventoryFileUrls_lv0_ec", "Type", grid.Locator, "FileType");
                    FileType.DataField = "FileType";
                    FileType.Items.Add("I", "Image");
                    FileType.Items.Add("V", "Video");
                    FileID = new PXNumberEdit("ctl00_phG_tab_t15_gridInventoryFileUrls_en", "FileID", grid.Locator, "FileID");
                    FileID.DataField = "FileID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter FileURL { get; }
				public DropDownColumnFilter FileType { get; }
				public PXNumberEditColumnFilter FileID { get; }
                
                public c_grid_header(c_inventoryfileurls_gridinventoryfileurls grid) : 
                        base(grid)
                {
                    FileURL = new PXTextEditColumnFilter(grid.Row.FileURL);
                    FileType = new DropDownColumnFilter(grid.Row.FileType);
                    FileID = new PXNumberEditColumnFilter(grid.Row.FileID);
                }
            }
        }
        
        public class c_inventoryfileurls_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_inventoryfileurls_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t15_gridInventoryFileUrls_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t15_gridInventoryFileUrls_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t15_gridInventoryFileUrls_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t15_gridInventoryFileUrls_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "InventoryFileUrls";
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
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfFirst0", "First", "ctl00_phG_tab_t15_gridInventoryFileUrls_lv0");
                    Prev = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfPrev0", "Prev", "ctl00_phG_tab_t15_gridInventoryFileUrls_lv0");
                    Next = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfNext0", "Next", "ctl00_phG_tab_t15_gridInventoryFileUrls_lv0");
                    Last = new Button("ctl00_phG_tab_t15_gridInventoryFileUrls_lfLast0", "Last", "ctl00_phG_tab_t15_gridInventoryFileUrls_lv0");
                }
            }
        }
        
        public class c_curysettings_inventoryitem_curysettingsform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit RecPrice_Label { get; }
			public Label RecPrice_LabelLabel { get; }
			public PXNumberEdit RecPrice { get; }
			public Label RecPriceLabel { get; }
			public PXTextEdit BasePrice_Label { get; }
			public Label BasePrice_LabelLabel { get; }
			public PXNumberEdit BasePrice { get; }
			public Label BasePriceLabel { get; }
            
            public c_curysettings_inventoryitem_curysettingsform(string locator, string name) : 
                    base(locator, name)
            {
                RecPrice_Label = new PXTextEdit("ctl00_phG_tab_t1_curySettingsForm_edRecPriceLabel", "Rec Price _ Label", locator, null);
                RecPrice_LabelLabel = new Label(RecPrice_Label);
                RecPrice_Label.DataField = "RecPrice_Label";
                RecPrice = new PXNumberEdit("ctl00_phG_tab_t1_curySettingsForm_edRecPrice", "Rec Price", locator, null);
                RecPriceLabel = new Label(RecPrice);
                RecPrice.DataField = "RecPrice";
                BasePrice_Label = new PXTextEdit("ctl00_phG_tab_t1_curySettingsForm_edBasePriceLabel", "Base Price _ Label", locator, null);
                BasePrice_LabelLabel = new Label(BasePrice_Label);
                BasePrice_Label.DataField = "BasePrice_Label";
                BasePrice = new PXNumberEdit("ctl00_phG_tab_t1_curySettingsForm_edBasePrice", "Base Price", locator, null);
                BasePriceLabel = new Label(BasePrice);
                BasePrice.DataField = "BasePrice";
                DataMemberName = "CurySettings_InventoryItem";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PriceClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab_t1_curySettingsForm");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_curysettings_inventoryitem_curysettingsform2 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit PendingStdCost_Label { get; }
			public Label PendingStdCost_LabelLabel { get; }
			public PXNumberEdit PendingStdCost { get; }
			public Label PendingStdCostLabel { get; }
			public DateSelector PendingStdCostDate { get; }
			public Label PendingStdCostDateLabel { get; }
			public PXTextEdit StdCost_Label { get; }
			public Label StdCost_LabelLabel { get; }
			public PXNumberEdit StdCost { get; }
			public Label StdCostLabel { get; }
			public DateSelector StdCostDate { get; }
			public Label StdCostDateLabel { get; }
			public PXTextEdit LastStdCost_Label { get; }
			public Label LastStdCost_LabelLabel { get; }
			public PXNumberEdit LastStdCost { get; }
			public Label LastStdCostLabel { get; }
            
            public c_curysettings_inventoryitem_curysettingsform2(string locator, string name) : 
                    base(locator, name)
            {
                PendingStdCost_Label = new PXTextEdit("ctl00_phG_tab_t1_curySettingsForm2_edPendingStdCostLabel", "Pending Std Cost _ Label", locator, null);
                PendingStdCost_LabelLabel = new Label(PendingStdCost_Label);
                PendingStdCost_Label.DataField = "PendingStdCost_Label";
                PendingStdCost = new PXNumberEdit("ctl00_phG_tab_t1_curySettingsForm2_edPendingStdCost", "Pending Std Cost", locator, null);
                PendingStdCostLabel = new Label(PendingStdCost);
                PendingStdCost.DataField = "PendingStdCost";
                PendingStdCostDate = new DateSelector("ctl00_phG_tab_t1_curySettingsForm2_edPendingStdCostDate", "Pending Cost Date", locator, null);
                PendingStdCostDateLabel = new Label(PendingStdCostDate);
                PendingStdCostDate.DataField = "PendingStdCostDate";
                StdCost_Label = new PXTextEdit("ctl00_phG_tab_t1_curySettingsForm2_edStdCostLabel", "Std Cost _ Label", locator, null);
                StdCost_LabelLabel = new Label(StdCost_Label);
                StdCost_Label.DataField = "StdCost_Label";
                StdCost = new PXNumberEdit("ctl00_phG_tab_t1_curySettingsForm2_edStdCost", "Std Cost", locator, null);
                StdCostLabel = new Label(StdCost);
                StdCost.DataField = "StdCost";
                StdCostDate = new DateSelector("ctl00_phG_tab_t1_curySettingsForm2_edStdCostDate", "Effective Date", locator, null);
                StdCostDateLabel = new Label(StdCostDate);
                StdCostDate.DataField = "StdCostDate";
                LastStdCost_Label = new PXTextEdit("ctl00_phG_tab_t1_curySettingsForm2_edLastStdCostLabel", "Last Std Cost _ Label", locator, null);
                LastStdCost_LabelLabel = new Label(LastStdCost_Label);
                LastStdCost_Label.DataField = "LastStdCost_Label";
                LastStdCost = new PXNumberEdit("ctl00_phG_tab_t1_curySettingsForm2_edLastStdCost", "Last Std Cost", locator, null);
                LastStdCostLabel = new Label(LastStdCost);
                LastStdCost.DataField = "LastStdCost";
                DataMemberName = "CurySettings_InventoryItem";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PriceClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab_t1_curySettingsForm2");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_vendorinventory_updateprice_formeffectivedate : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector PendingDate { get; }
			public Label PendingDateLabel { get; }
            
            public c_vendorinventory_updateprice_formeffectivedate(string locator, string name) : 
                    base(locator, name)
            {
                PendingDate = new DateSelector("ctl00_phG_pnlUpdatePrice_formEffectiveDate_edPendingDate", "Max. Pending Date", locator, null);
                PendingDateLabel = new Label(PendingDate);
                PendingDate.DataField = "PendingDate";
                DataMemberName = "VendorInventory$UpdatePrice";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Update()
            {
                Buttons.Update.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Update { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Update = new Button("ctl00_phG_pnlUpdatePrice_PXButton9", "Update", "ctl00_phG_pnlUpdatePrice_formEffectiveDate");
                    Cancel = new Button("ctl00_phG_pnlUpdatePrice_PXButton10", "Cancel", "ctl00_phG_pnlUpdatePrice_formEffectiveDate");
                }
            }
        }
        
        public class c_changeiddialog_formchangeid : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CD { get; }
			public Label CDLabel { get; }
            
            public c_changeiddialog_formchangeid(string locator, string name) : 
                    base(locator, name)
            {
                CD = new Selector("ctl00_phF_pnlChangeID_formChangeID_edAcctCD", "Inventory ID", locator, null);
                CDLabel = new Label(CD);
                CD.DataField = "CD";
                DataMemberName = "ChangeIDDialog";
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
                    Ok = new Button("ctl00_phF_pnlChangeID_btnOK", "OK", "ctl00_phF_pnlChangeID_formChangeID");
                    Cancel = new Button("ctl00_phF_pnlChangeID_btnCancel", "Cancel", "ctl00_phF_pnlChangeID_formChangeID");
                }
            }
        }
        
        public class c_serviceskills_gridserviceskills : Grid<c_serviceskills_gridserviceskills.c_grid_row, c_serviceskills_gridserviceskills.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_serviceskills_gridserviceskills(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t10_gridServiceSkills");
                DataMemberName = "ServiceSkills";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t10_gridServiceSkills_fe_gf", "FilterForm");
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
            
            public virtual void SkillIDEdit()
            {
                Buttons.SkillIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridServiceSkills_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button SkillIDEdit { get; }
                
                public PxButtonCollection()
                {
                    SkillIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_gridServiceSkills_lv0_edSkillID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "SkillIDEdit", "ctl00_phG_tab_t10_gridServiceSkills");
                    SkillIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SkillID { get; }
			public PXTextEdit FSSkill__Descr { get; }
                
                public c_grid_row(c_serviceskills_gridserviceskills grid) : 
                        base(grid)
                {
                    SkillID = new Selector("_ctl00_phG_tab_t10_gridServiceSkills_lv0_edSkillID", "Skill ID", grid.Locator, "SkillID");
                    SkillID.DataField = "SkillID";
                    FSSkill__Descr = new PXTextEdit("_ctl00_phG_tab_t10_gridServiceSkills_lv0_edFSSkill__Descr", "FS Skill __ Descr", grid.Locator, "FSSkill__Descr");
                    FSSkill__Descr.DataField = "FSSkill__Descr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SkillID { get; }
				public PXTextEditColumnFilter FSSkill__Descr { get; }
                
                public c_grid_header(c_serviceskills_gridserviceskills grid) : 
                        base(grid)
                {
                    SkillID = new SelectorColumnFilter(grid.Row.SkillID);
                    FSSkill__Descr = new PXTextEditColumnFilter(grid.Row.FSSkill__Descr);
                }
            }
        }
        
        public class c_serviceskills_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SkillID { get; }
			public Label SkillIDLabel { get; }
			public PXTextEdit FSSkill__Descr { get; }
			public Label FSSkill__DescrLabel { get; }
            
            public c_serviceskills_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SkillID = new Selector("ctl00_phG_tab_t10_gridServiceSkills_lv0_edSkillID", "Skill ID", locator, null);
                SkillIDLabel = new Label(SkillID);
                SkillID.DataField = "SkillID";
                FSSkill__Descr = new PXTextEdit("ctl00_phG_tab_t10_gridServiceSkills_lv0_edFSSkill__Descr", "FS Skill __ Descr", locator, null);
                FSSkill__DescrLabel = new Label(FSSkill__Descr);
                FSSkill__Descr.DataField = "FSSkill__Descr";
                DataMemberName = "ServiceSkills";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void SkillIDEdit()
            {
                Buttons.SkillIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button SkillIDEdit { get; }
                
                public PxButtonCollection()
                {
                    SkillIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_gridServiceSkills_lv0_edSkillID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "SkillIDEdit", "ctl00_phG_tab_t10_gridServiceSkills_lv0");
                    SkillIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_servicelicensetypes_gridservicelicensetypes : Grid<c_servicelicensetypes_gridservicelicensetypes.c_grid_row, c_servicelicensetypes_gridservicelicensetypes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_servicelicensetypes_gridservicelicensetypes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t11_gridServiceLicenseTypes");
                DataMemberName = "ServiceLicenseTypes";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t11_gridServiceLicenseTypes_fe_gf", "FilterForm");
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
            
            public virtual void LicenseTypeIDEdit()
            {
                Buttons.LicenseTypeIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_at_tlb div[data-cmd=\'AdjustColumns" +
                            "\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_at_tlb div[data-cmd=\'ExportExcel\']" +
                            "", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_gridServiceLicenseTypes_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button LicenseTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    LicenseTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0_edLicenseTypeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "LicenseTypeIDEdit", "ctl00_phG_tab_t11_gridServiceLicenseTypes");
                    LicenseTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector LicenseTypeID { get; }
			public PXTextEdit FSLicenseType__Descr { get; }
                
                public c_grid_row(c_servicelicensetypes_gridservicelicensetypes grid) : 
                        base(grid)
                {
                    LicenseTypeID = new Selector("_ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0_edLicenseTypeID", "License Type ID", grid.Locator, "LicenseTypeID");
                    LicenseTypeID.DataField = "LicenseTypeID";
                    FSLicenseType__Descr = new PXTextEdit("_ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0_edFSLicenseType__Descr", "FS License Type __ Descr", grid.Locator, "FSLicenseType__Descr");
                    FSLicenseType__Descr.DataField = "FSLicenseType__Descr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter LicenseTypeID { get; }
				public PXTextEditColumnFilter FSLicenseType__Descr { get; }
                
                public c_grid_header(c_servicelicensetypes_gridservicelicensetypes grid) : 
                        base(grid)
                {
                    LicenseTypeID = new SelectorColumnFilter(grid.Row.LicenseTypeID);
                    FSLicenseType__Descr = new PXTextEditColumnFilter(grid.Row.FSLicenseType__Descr);
                }
            }
        }
        
        public class c_servicelicensetypes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector LicenseTypeID { get; }
			public Label LicenseTypeIDLabel { get; }
			public PXTextEdit FSLicenseType__Descr { get; }
			public Label FSLicenseType__DescrLabel { get; }
            
            public c_servicelicensetypes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                LicenseTypeID = new Selector("ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0_edLicenseTypeID", "License Type ID", locator, null);
                LicenseTypeIDLabel = new Label(LicenseTypeID);
                LicenseTypeID.DataField = "LicenseTypeID";
                FSLicenseType__Descr = new PXTextEdit("ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0_edFSLicenseType__Descr", "FS License Type __ Descr", locator, null);
                FSLicenseType__DescrLabel = new Label(FSLicenseType__Descr);
                FSLicenseType__Descr.DataField = "FSLicenseType__Descr";
                DataMemberName = "ServiceLicenseTypes";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void LicenseTypeIDEdit()
            {
                Buttons.LicenseTypeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button LicenseTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    LicenseTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0_edLicenseTypeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "LicenseTypeIDEdit", "ctl00_phG_tab_t11_gridServiceLicenseTypes_lv0");
                    LicenseTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_serviceequipmenttypes_gridserviceequipmenttypes : Grid<c_serviceequipmenttypes_gridserviceequipmenttypes.c_grid_row, c_serviceequipmenttypes_gridserviceequipmenttypes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_serviceequipmenttypes_gridserviceequipmenttypes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t12_gridServiceEquipmentTypes");
                DataMemberName = "ServiceEquipmentTypes";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t12_gridServiceEquipmentTypes_fe_gf", "FilterForm");
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
            
            public virtual void EquipmentTypeIDEdit()
            {
                Buttons.EquipmentTypeIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_at_tlb div[data-cmd=\'AdjustColum" +
                            "ns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_at_tlb div[data-cmd=\'ExportExcel" +
                            "\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_ab_tlb div[data-cmd=\'PageFirst\']" +
                            "", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_gridServiceEquipmentTypes_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button EquipmentTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    EquipmentTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0_edEquipmentTypeID\'] d" +
                            "iv[class=\'editBtnCont\'] > div > div", "EquipmentTypeIDEdit", "ctl00_phG_tab_t12_gridServiceEquipmentTypes");
                    EquipmentTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector EquipmentTypeID { get; }
			public PXTextEdit FSEquipmentType__Descr { get; }
                
                public c_grid_row(c_serviceequipmenttypes_gridserviceequipmenttypes grid) : 
                        base(grid)
                {
                    EquipmentTypeID = new Selector("_ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0_edEquipmentTypeID", "Equipment Type ID", grid.Locator, "EquipmentTypeID");
                    EquipmentTypeID.DataField = "EquipmentTypeID";
                    FSEquipmentType__Descr = new PXTextEdit("_ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0_edFSEquipmentType__Descr", "FS Equipment Type __ Descr", grid.Locator, "FSEquipmentType__Descr");
                    FSEquipmentType__Descr.DataField = "FSEquipmentType__Descr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter EquipmentTypeID { get; }
				public PXTextEditColumnFilter FSEquipmentType__Descr { get; }
                
                public c_grid_header(c_serviceequipmenttypes_gridserviceequipmenttypes grid) : 
                        base(grid)
                {
                    EquipmentTypeID = new SelectorColumnFilter(grid.Row.EquipmentTypeID);
                    FSEquipmentType__Descr = new PXTextEditColumnFilter(grid.Row.FSEquipmentType__Descr);
                }
            }
        }
        
        public class c_serviceequipmenttypes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector EquipmentTypeID { get; }
			public Label EquipmentTypeIDLabel { get; }
			public PXTextEdit FSEquipmentType__Descr { get; }
			public Label FSEquipmentType__DescrLabel { get; }
            
            public c_serviceequipmenttypes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                EquipmentTypeID = new Selector("ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0_edEquipmentTypeID", "Equipment Type ID", locator, null);
                EquipmentTypeIDLabel = new Label(EquipmentTypeID);
                EquipmentTypeID.DataField = "EquipmentTypeID";
                FSEquipmentType__Descr = new PXTextEdit("ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0_edFSEquipmentType__Descr", "FS Equipment Type __ Descr", locator, null);
                FSEquipmentType__DescrLabel = new Label(FSEquipmentType__Descr);
                FSEquipmentType__Descr.DataField = "FSEquipmentType__Descr";
                DataMemberName = "ServiceEquipmentTypes";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void EquipmentTypeIDEdit()
            {
                Buttons.EquipmentTypeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button EquipmentTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    EquipmentTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0_edEquipmentTypeID\'] d" +
                            "iv[class=\'editBtnCont\'] > div > div", "EquipmentTypeIDEdit", "ctl00_phG_tab_t12_gridServiceEquipmentTypes_lv0");
                    EquipmentTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_serviceinventoryitems_gridpickdeliver : Grid<c_serviceinventoryitems_gridpickdeliver.c_grid_row, c_serviceinventoryitems_gridpickdeliver.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_serviceinventoryitems_gridpickdeliver(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t13_gridPickDeliver");
                DataMemberName = "ServiceInventoryItems";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t13_gridPickDeliver_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridPickDeliver_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector InventoryID { get; }
			public InputLocalizable InventoryItem__Descr { get; }
                
                public c_grid_row(c_serviceinventoryitems_gridpickdeliver grid) : 
                        base(grid)
                {
                    InventoryID = new Selector("_ctl00_phG_tab_t13_gridPickDeliver_lv0_edSMInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    InventoryItem__Descr = new InputLocalizable("_ctl00_phG_tab_t13_gridPickDeliver_lv0_edInventoryItem__Descr", "Inventory Item __ Descr", grid.Locator, "InventoryItem__Descr");
                    InventoryItem__Descr.DataField = "InventoryItem__Descr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter InventoryItem__Descr { get; }
                
                public c_grid_header(c_serviceinventoryitems_gridpickdeliver grid) : 
                        base(grid)
                {
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    InventoryItem__Descr = new PXTextEditColumnFilter(grid.Row.InventoryItem__Descr);
                }
            }
        }
        
        public class c_serviceinventoryitems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public InputLocalizable InventoryItem__Descr { get; }
			public Label InventoryItem__DescrLabel { get; }
            
            public c_serviceinventoryitems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t13_gridPickDeliver_lv0_edSMInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                InventoryItem__Descr = new InputLocalizable("ctl00_phG_tab_t13_gridPickDeliver_lv0_edInventoryItem__Descr", "Inventory Item __ Descr", locator, null);
                InventoryItem__DescrLabel = new Label(InventoryItem__Descr);
                InventoryItem__Descr.DataField = "InventoryItem__Descr";
                DataMemberName = "ServiceInventoryItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t13_gridPickDeliver_lv0_edSMInventoryID\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "InventoryIDEdit", "ctl00_phG_tab_t13_gridPickDeliver_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_syncrecs_syncgrid : Grid<c_syncrecs_syncgrid.c_grid_row, c_syncrecs_syncgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_syncrecs_syncgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t14_syncGrid");
                DataMemberName = "SyncRecs";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t14_syncGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void SyncSalesforce()
            {
                ToolBar.SyncSalesforce.Click();
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
			public ToolBarButtonGrid SyncSalesforce { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    SyncSalesforce = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_at_tlb div[data-cmd=\'SyncSalesforce\']", "SyncSalesforce", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_syncGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit SYProvider__Name { get; }
			public PXTextEdit RemoteID { get; }
			public PXTextEdit Status { get; }
			public PXTextEdit Operation { get; }
			public PXTextEdit LastErrorMessage { get; }
			public PXTextEdit LastAttemptTS { get; }
			public PXTextEdit AttemptCount { get; }
			public PXTextEdit SFEntitySetup__ImportScenario { get; }
			public PXTextEdit SFEntitySetup__ExportScenario { get; }
                
                public c_grid_row(c_syncrecs_syncgrid grid) : 
                        base(grid)
                {
                    SYProvider__Name = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "SY Provider __ Name", grid.Locator, "SYProvider__Name");
                    SYProvider__Name.DataField = "SYProvider__Name";
                    RemoteID = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "Remote ID", grid.Locator, "RemoteID");
                    RemoteID.DataField = "RemoteID";
                    Status = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Operation = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "Operation", grid.Locator, "Operation");
                    Operation.DataField = "Operation";
                    LastErrorMessage = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "Last Error Message", grid.Locator, "LastErrorMessage");
                    LastErrorMessage.DataField = "LastErrorMessage";
                    LastAttemptTS = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_em", "Last Attempt TS", grid.Locator, "LastAttemptTS");
                    LastAttemptTS.DataField = "LastAttemptTS";
                    AttemptCount = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "Attempt Count", grid.Locator, "AttemptCount");
                    AttemptCount.DataField = "AttemptCount";
                    SFEntitySetup__ImportScenario = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "SF Entity Setup __ Import Scenario", grid.Locator, "SFEntitySetup__ImportScenario");
                    SFEntitySetup__ImportScenario.DataField = "SFEntitySetup__ImportScenario";
                    SFEntitySetup__ExportScenario = new PXTextEdit("ctl00_phG_tab_t14_syncGrid_ei", "SF Entity Setup __ Export Scenario", grid.Locator, "SFEntitySetup__ExportScenario");
                    SFEntitySetup__ExportScenario.DataField = "SFEntitySetup__ExportScenario";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter SYProvider__Name { get; }
				public PXTextEditColumnFilter RemoteID { get; }
				public PXTextEditColumnFilter Status { get; }
				public PXTextEditColumnFilter Operation { get; }
				public PXTextEditColumnFilter LastErrorMessage { get; }
				public PXTextEditColumnFilter LastAttemptTS { get; }
				public PXTextEditColumnFilter AttemptCount { get; }
				public PXTextEditColumnFilter SFEntitySetup__ImportScenario { get; }
				public PXTextEditColumnFilter SFEntitySetup__ExportScenario { get; }
                
                public c_grid_header(c_syncrecs_syncgrid grid) : 
                        base(grid)
                {
                    SYProvider__Name = new PXTextEditColumnFilter(grid.Row.SYProvider__Name);
                    RemoteID = new PXTextEditColumnFilter(grid.Row.RemoteID);
                    Status = new PXTextEditColumnFilter(grid.Row.Status);
                    Operation = new PXTextEditColumnFilter(grid.Row.Operation);
                    LastErrorMessage = new PXTextEditColumnFilter(grid.Row.LastErrorMessage);
                    LastAttemptTS = new PXTextEditColumnFilter(grid.Row.LastAttemptTS);
                    AttemptCount = new PXTextEditColumnFilter(grid.Row.AttemptCount);
                    SFEntitySetup__ImportScenario = new PXTextEditColumnFilter(grid.Row.SFEntitySetup__ImportScenario);
                    SFEntitySetup__ExportScenario = new PXTextEditColumnFilter(grid.Row.SFEntitySetup__ExportScenario);
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
        
        public class c_itemsettings_filesgrid : Grid<c_itemsettings_filesgrid.c_grid_row, c_itemsettings_filesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_itemsettings_filesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid");
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_at_tlb div[dat" +
                            "a-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_at_tlb div[dat" +
                            "a-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    UpBtn = new Button("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_attFileUp_upBtn", "upBtn", "ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Name { get; }
			public PXTextEdit Size { get; }
			public PXTextEdit Comment { get; }
                
                public c_grid_row(c_itemsettings_filesgrid grid) : 
                        base(grid)
                {
                    Name = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Size = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Size (kb)", grid.Locator, "Size");
                    Size.DataField = "Size";
                    Comment = new PXTextEdit("ctl00_phG_tab_t9_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Name { get; }
				public PXTextEditColumnFilter Size { get; }
				public PXTextEditColumnFilter Comment { get; }
                
                public c_grid_header(c_itemsettings_filesgrid grid) : 
                        base(grid)
                {
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    Size = new PXTextEditColumnFilter(grid.Row.Size);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                }
            }
        }
        
        public class c_relateditems_importcsvsettings_frmimportcsvsettings : Container
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
            
            public c_relateditems_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "RelatedItems$ImportCSVSettings";
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
                    Ok = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_relateditems_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_relateditems_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                        "_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                        "_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                        "_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "RelatedItems$ImportXLSXSettings";
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
                    Ok = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                            "");
                    Cancel = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                            "");
                }
            }
        }
        
        public class c_relateditems_importcolumns_grdimportcolumn : Grid<c_relateditems_importcolumns_grdimportcolumn.c_grid_row, c_relateditems_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_relateditems_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "RelatedItems$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_relateditems_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_relateditems_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_relateditems_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_relateditems_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "RelatedItems$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t4_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
    }
}
