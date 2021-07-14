using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.EmailEdit;
using Controls.Editors.LinkEdit;
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
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ACBC.Tests.Wrappers
{
    
    
    public class IN204000_INSiteMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        protected c_site_form Site_form { get; } = new c_site_form("ctl00_phF_form", "site_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_siteaccounts_tab Siteaccounts_tab { get; } = new c_siteaccounts_tab("ctl00_phG_tab", "siteaccounts_tab");
        protected c_siteaccounts_buildform Siteaccounts_buildform { get; } = new c_siteaccounts_buildform("ctl00_phG_tab_t4_buildForm", "siteaccounts_buildForm");
        protected c_location_grid Location_grid { get; } = new c_location_grid("ctl00_phG_tab_t0_grid", "location_grid");
        protected c_location_lv0 Location_lv0 { get; } = new c_location_lv0("ctl00_phG_tab_t0_grid_lv0", "location_lv0");
        protected c_carts_gridcarts Carts_gridcarts { get; } = new c_carts_gridcarts("ctl00_phG_tab_t1_gridCarts", "carts_gridCarts");
        protected c_carts_lv0 Carts_lv0 { get; } = new c_carts_lv0("ctl00_phG_tab_t1_gridCarts_lv0", "carts_lv0");
        protected c_totes_gridtotes Totes_gridtotes { get; } = new c_totes_gridtotes("ctl00_phG_tab_t2_gridTotes", "totes_gridTotes");
        protected c_totes_lv0 Totes_lv0 { get; } = new c_totes_lv0("ctl00_phG_tab_t2_gridTotes_lv0", "totes_lv0");
        protected c_totesincart_gridtotesincart Totesincart_gridtotesincart { get; } = new c_totesincart_gridtotesincart("ctl00_phG_ViewTotesInCartDialog_gridTotesInCart", "totesInCart_gridTotesInCart");
        protected c_totesincart_lv0 Totesincart_lv0 { get; } = new c_totesincart_lv0("ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_lv0", "totesInCart_lv0");
        protected c_address_addrform Address_addrForm { get; } = new c_address_addrform("ctl00_phG_tab_t4_addrForm", "Address_addrForm");
        protected c_contact_colform Contact_colForm { get; } = new c_contact_colform("ctl00_phG_tab_t4_colForm", "Contact_colForm");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phF_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_location_importcsvsettings_frmimportcsvsettings Location_importcsvsettings_frmimportcsvsettings { get; } = new c_location_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings", "location$ImportCSVSettings_frmImportCSVSettings");
        protected c_location_importxlsxsettings_frmimportxlsxsettings Location_importxlsxsettings_frmimportxlsxsettings { get; } = new c_location_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "location$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_location_importcolumns_grdimportcolumn Location_importcolumns_grdimportcolumn { get; } = new c_location_importcolumns_grdimportcolumn("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn", "location$ImportColumns_grdImportColumn");
        protected c_location_importcolumns_lv0 Location_importcolumns_lv0 { get; } = new c_location_importcolumns_lv0("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0", "location$ImportColumns_lv0");
        protected c_carts_importcsvsettings_frmimportcsvsettings Carts_importcsvsettings_frmimportcsvsettings { get; } = new c_carts_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings", "carts$ImportCSVSettings_frmImportCSVSettings");
        protected c_carts_importxlsxsettings_frmimportxlsxsettings Carts_importxlsxsettings_frmimportxlsxsettings { get; } = new c_carts_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "carts$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_carts_importcolumns_grdimportcolumn Carts_importcolumns_grdimportcolumn { get; } = new c_carts_importcolumns_grdimportcolumn("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn", "carts$ImportColumns_grdImportColumn");
        protected c_carts_importcolumns_lv0 Carts_importcolumns_lv0 { get; } = new c_carts_importcolumns_lv0("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0", "carts$ImportColumns_lv0");
        protected c_totes_importcsvsettings_frmimportcsvsettings Totes_importcsvsettings_frmimportcsvsettings { get; } = new c_totes_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings", "totes$ImportCSVSettings_frmImportCSVSettings");
        protected c_totes_importxlsxsettings_frmimportxlsxsettings Totes_importxlsxsettings_frmimportxlsxsettings { get; } = new c_totes_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "totes$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_totes_importcolumns_grdimportcolumn Totes_importcolumns_grdimportcolumn { get; } = new c_totes_importcolumns_grdimportcolumn("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn", "totes$ImportColumns_grdImportColumn");
        protected c_totes_importcolumns_lv0 Totes_importcolumns_lv0 { get; } = new c_totes_importcolumns_lv0("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0", "totes$ImportColumns_lv0");
        
        public IN204000_INSiteMaint()
        {
            ScreenId = "IN204000";
            ScreenUrl = "/Pages/IN/IN204000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual IN204000_INSiteMaint ReadOne(Gate gate, string SiteCD)
        {
            new BiObject<IN204000_INSiteMaint>(gate).ReadOne(this, SiteCD);
            return this;
        }
        
        public virtual IN204000_INSiteMaint ReadOne(string SiteCD)
        {
            return this.ReadOne(ApiConnection.Source, SiteCD);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Favorites()
        {
            ToolBar.Favorites.Click();
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
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void ViewRestrictionGroups()
        {
            ToolBar.ViewRestrictionGroups.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void Reports()
        {
            ToolBar.Reports.Click();
        }
        
        public virtual void INLocationLabels()
        {
            ToolBar.INLocationLabels.Click();
        }
        
        public virtual void ChangeIDHidden()
        {
            ToolBar.ChangeIDHidden.Click();
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
			public ToolBarButton Actions { get; }
			public ToolBarButton ViewRestrictionGroups { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton Reports { get; }
			public ToolBarButton INLocationLabels { get; }
			public ToolBarButton ChangeIDHidden { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
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
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CancelClose\']", "Discard Changes and Close", locator, null);
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'SaveClose\']", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Save\']", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
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
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                ViewRestrictionGroups = new ToolBarButton("css=li[data-cmd=\'Action@ViewRestrictionGroups\']", "View Restriction Groups", locator, Actions);
                ValidateAddresses = new ToolBarButton("css=li[data-cmd=\'Action@ValidateAddresses\']", "Validate Addresses", locator, Actions);
                ChangeID = new ToolBarButton("css=li[data-cmd=\'Action@changeID\']", "Change ID", locator, Actions);
                Reports = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                INLocationLabels = new ToolBarButton("css=li[data-cmd=\'Report@INLocationLabels\']", "Location Labels", locator, Reports);
                ChangeIDHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'changeID\']", "Change ID", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_site_form : Container
        {
            
			public Selector SiteCD { get; }
			public Label SiteCDLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector ReplenishmentClassID { get; }
			public Label ReplenishmentClassIDLabel { get; }
			public DropDown LocationValid { get; }
			public Label LocationValidLabel { get; }
			public DropDown AvgDefaultCost { get; }
			public Label AvgDefaultCostLabel { get; }
			public DropDown FIFODefaultCost { get; }
			public Label FIFODefaultCostLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
            
            public c_site_form(string locator, string name) : 
                    base(locator, name)
            {
                SiteCD = new Selector("ctl00_phF_form_edSiteCD", "Warehouse ID", locator, null);
                SiteCDLabel = new Label(SiteCD);
                SiteCD.DataField = "SiteCD";
                BranchID = new Selector("ctl00_phF_form_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                ReplenishmentClassID = new Selector("ctl00_phF_form_edReplenishmentClassID", "Replenishment Class", locator, null);
                ReplenishmentClassIDLabel = new Label(ReplenishmentClassID);
                ReplenishmentClassID.DataField = "ReplenishmentClassID";
                LocationValid = new DropDown("ctl00_phF_form_edLocationValid", "Location Entry", locator, null);
                LocationValidLabel = new Label(LocationValid);
                LocationValid.DataField = "LocationValid";
                LocationValid.Items.Add("V", "Do Not Allow On-the-Fly Entry");
                LocationValid.Items.Add("W", "Warn But Allow On-the-Fly Entry");
                LocationValid.Items.Add("N", "Allow On-the-Fly Entry");
                AvgDefaultCost = new DropDown("ctl00_phF_form_edAvgDefaultCost", "Avg. Default Returns Cost", locator, null);
                AvgDefaultCostLabel = new Label(AvgDefaultCost);
                AvgDefaultCost.DataField = "AvgDefaultCost";
                AvgDefaultCost.Items.Add("A", "Average");
                AvgDefaultCost.Items.Add("L", "Last");
                FIFODefaultCost = new DropDown("ctl00_phF_form_edFIFODefaultCost", "FIFO Default Returns Cost", locator, null);
                FIFODefaultCostLabel = new Label(FIFODefaultCost);
                FIFODefaultCost.DataField = "FIFODefaultCost";
                FIFODefaultCost.Items.Add("A", "Average");
                FIFODefaultCost.Items.Add("L", "Last");
                Active = new CheckBox("ctl00_phF_form_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                Descr = new PXTextEdit("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                DataMemberName = "site";
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
        
        public class c_siteaccounts_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ReceiptLocationID { get; }
			public Label ReceiptLocationIDLabel { get; }
			public Selector ShipLocationID { get; }
			public Label ShipLocationIDLabel { get; }
			public Selector ReturnLocationID { get; }
			public Label ReturnLocationIDLabel { get; }
			public Selector DropShipLocationID { get; }
			public Label DropShipLocationIDLabel { get; }
			public CheckBox UseItemDefaultLocationForPicking { get; }
			public Label UseItemDefaultLocationForPickingLabel { get; }
			public CheckBox OverrideInvtAccSub { get; }
			public Label OverrideInvtAccSubLabel { get; }
			public Selector InvtAcctID { get; }
			public Label InvtAcctIDLabel { get; }
			public Selector InvtSubID { get; }
			public Label InvtSubIDLabel { get; }
			public Selector ReasonCodeSubID { get; }
			public Label ReasonCodeSubIDLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public Selector COGSAcctID { get; }
			public Label COGSAcctIDLabel { get; }
			public Selector COGSSubID { get; }
			public Label COGSSubIDLabel { get; }
			public Selector StdCstVarAcctID { get; }
			public Label StdCstVarAcctIDLabel { get; }
			public Selector StdCstVarSubID { get; }
			public Label StdCstVarSubIDLabel { get; }
			public Selector StdCstRevAcctID { get; }
			public Label StdCstRevAcctIDLabel { get; }
			public Selector StdCstRevSubID { get; }
			public Label StdCstRevSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public Selector PPVAcctID { get; }
			public Label PPVAcctIDLabel { get; }
			public Selector PPVSubID { get; }
			public Label PPVSubIDLabel { get; }
			public Selector LCVarianceAcctID { get; }
			public Label LCVarianceAcctIDLabel { get; }
			public Selector LCVarianceSubID { get; }
			public Label LCVarianceSubIDLabel { get; }
			public Selector AMWIPAcctID { get; }
			public Label AMWIPAcctIDLabel { get; }
			public Selector AMWIPSubID { get; }
			public Label AMWIPSubIDLabel { get; }
			public Selector AMWIPVarianceAcctID { get; }
			public Label AMWIPVarianceAcctIDLabel { get; }
			public Selector AMWIPVarianceSubID { get; }
			public Label AMWIPVarianceSubIDLabel { get; }
			public CheckBox AMMRPFcst { get; }
			public Label AMMRPFcstLabel { get; }
			public CheckBox AMMRPPO { get; }
			public Label AMMRPPOLabel { get; }
			public CheckBox AMMRPFlag { get; }
			public Label AMMRPFlagLabel { get; }
			public CheckBox AMMRPProd { get; }
			public Label AMMRPProdLabel { get; }
			public CheckBox AMMRPMPS { get; }
			public Label AMMRPMPSLabel { get; }
			public CheckBox AMMRPSO { get; }
			public Label AMMRPSOLabel { get; }
			public CheckBox AMMRPShip { get; }
			public Label AMMRPShipLabel { get; }
			public Selector AMScrapSiteID { get; }
			public Label AMScrapSiteIDLabel { get; }
			public Selector AMScrapLocationID { get; }
			public Label AMScrapLocationIDLabel { get; }
			public Label Label1_importColumnDlg { get; }
			public Label LblImportSource_ { get; }
			public Label LblPassword_ { get; }
			public Label Label1_importColumnDlg2 { get; }
			public Label LblImportSource_2 { get; }
			public Label LblPassword_2 { get; }
			public Label Label1_importColumnDlg3 { get; }
			public Label LblImportSource_3 { get; }
			public Label LblPassword_3 { get; }
            
            public c_siteaccounts_tab(string locator, string name) : 
                    base(locator, name)
            {
                ReceiptLocationID = new Selector("ctl00_phG_tab_t0_edReceiptLocationID", "Receiving Location", locator, null);
                ReceiptLocationIDLabel = new Label(ReceiptLocationID);
                ReceiptLocationID.DataField = "ReceiptLocationID";
                ShipLocationID = new Selector("ctl00_phG_tab_t0_edShipLocationID", "Shipping Location", locator, null);
                ShipLocationIDLabel = new Label(ShipLocationID);
                ShipLocationID.DataField = "ShipLocationID";
                ReturnLocationID = new Selector("ctl00_phG_tab_t0_edReturnLocationID", "RMA Location", locator, null);
                ReturnLocationIDLabel = new Label(ReturnLocationID);
                ReturnLocationID.DataField = "ReturnLocationID";
                DropShipLocationID = new Selector("ctl00_phG_tab_t0_edDropShipLocationID", "Drop-Ship Location", locator, null);
                DropShipLocationIDLabel = new Label(DropShipLocationID);
                DropShipLocationID.DataField = "DropShipLocationID";
                UseItemDefaultLocationForPicking = new CheckBox("ctl00_phG_tab_t0_chkUseItemDefaultLocationForPicking", "Use Item Default Location for Picking", locator, null);
                UseItemDefaultLocationForPickingLabel = new Label(UseItemDefaultLocationForPicking);
                UseItemDefaultLocationForPicking.DataField = "UseItemDefaultLocationForPicking";
                OverrideInvtAccSub = new CheckBox("ctl00_phG_tab_t3_chkOverrideAccSub", "Override Inventory Account/Sub.", locator, null);
                OverrideInvtAccSubLabel = new Label(OverrideInvtAccSub);
                OverrideInvtAccSub.DataField = "OverrideInvtAccSub";
                InvtAcctID = new Selector("ctl00_phG_tab_t3_edInvtAcctID", "Inventory Account", locator, null);
                InvtAcctIDLabel = new Label(InvtAcctID);
                InvtAcctID.DataField = "InvtAcctID";
                InvtSubID = new Selector("ctl00_phG_tab_t3_edInvtSubID", "Inventory Sub.", locator, null);
                InvtSubIDLabel = new Label(InvtSubID);
                InvtSubID.DataField = "InvtSubID";
                ReasonCodeSubID = new Selector("ctl00_phG_tab_t3_edReasonCodeSubID", "Reason Code Sub.", locator, null);
                ReasonCodeSubIDLabel = new Label(ReasonCodeSubID);
                ReasonCodeSubID.DataField = "ReasonCodeSubID";
                SalesAcctID = new Selector("ctl00_phG_tab_t3_edSalesAcctID", "Sales Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t3_edSalesSubID", "Sales Sub.", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                COGSAcctID = new Selector("ctl00_phG_tab_t3_edCOGSAcctID", "COGS/Expense Account", locator, null);
                COGSAcctIDLabel = new Label(COGSAcctID);
                COGSAcctID.DataField = "COGSAcctID";
                COGSSubID = new Selector("ctl00_phG_tab_t3_edCOGSSubID", "COGS/Expense Sub.", locator, null);
                COGSSubIDLabel = new Label(COGSSubID);
                COGSSubID.DataField = "COGSSubID";
                StdCstVarAcctID = new Selector("ctl00_phG_tab_t3_edStdCstVarAcctID", "Standard Cost Variance Account", locator, null);
                StdCstVarAcctIDLabel = new Label(StdCstVarAcctID);
                StdCstVarAcctID.DataField = "StdCstVarAcctID";
                StdCstVarSubID = new Selector("ctl00_phG_tab_t3_edStdCstVarSubID", "Standard Cost Variance Sub.", locator, null);
                StdCstVarSubIDLabel = new Label(StdCstVarSubID);
                StdCstVarSubID.DataField = "StdCstVarSubID";
                StdCstRevAcctID = new Selector("ctl00_phG_tab_t3_edStdCstRevAcctID", "Standard Cost Revaluation Account", locator, null);
                StdCstRevAcctIDLabel = new Label(StdCstRevAcctID);
                StdCstRevAcctID.DataField = "StdCstRevAcctID";
                StdCstRevSubID = new Selector("ctl00_phG_tab_t3_edStdCstRevSubID", "Standard Cost Revaluation Sub.", locator, null);
                StdCstRevSubIDLabel = new Label(StdCstRevSubID);
                StdCstRevSubID.DataField = "StdCstRevSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t3_edPOAccrualAcctID", "PO Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t3_edPOAccrualSubID", "PO Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                PPVAcctID = new Selector("ctl00_phG_tab_t3_edPPVAcctID", "Purchase Price Variance Account", locator, null);
                PPVAcctIDLabel = new Label(PPVAcctID);
                PPVAcctID.DataField = "PPVAcctID";
                PPVSubID = new Selector("ctl00_phG_tab_t3_edPPVSubID", "Purchase Price Variance Sub.", locator, null);
                PPVSubIDLabel = new Label(PPVSubID);
                PPVSubID.DataField = "PPVSubID";
                LCVarianceAcctID = new Selector("ctl00_phG_tab_t3_edLCVarianceAcctID", "Landed Cost Variance Account", locator, null);
                LCVarianceAcctIDLabel = new Label(LCVarianceAcctID);
                LCVarianceAcctID.DataField = "LCVarianceAcctID";
                LCVarianceSubID = new Selector("ctl00_phG_tab_t3_edLCVarianceSubID", "Landed Cost Variance Sub.", locator, null);
                LCVarianceSubIDLabel = new Label(LCVarianceSubID);
                LCVarianceSubID.DataField = "LCVarianceSubID";
                AMWIPAcctID = new Selector("ctl00_phG_tab_t3_edWIPAcctID", "Work in Process Account", locator, null);
                AMWIPAcctIDLabel = new Label(AMWIPAcctID);
                AMWIPAcctID.DataField = "AMWIPAcctID";
                AMWIPSubID = new Selector("ctl00_phG_tab_t3_edWIPSubID", "Work In Process Sub.", locator, null);
                AMWIPSubIDLabel = new Label(AMWIPSubID);
                AMWIPSubID.DataField = "AMWIPSubID";
                AMWIPVarianceAcctID = new Selector("ctl00_phG_tab_t3_edAMWIPVarianceAcctID", "WIP Variance Account", locator, null);
                AMWIPVarianceAcctIDLabel = new Label(AMWIPVarianceAcctID);
                AMWIPVarianceAcctID.DataField = "AMWIPVarianceAcctID";
                AMWIPVarianceSubID = new Selector("ctl00_phG_tab_t3_edAMWIPVarianceSubID", "WIP Variance Sub.", locator, null);
                AMWIPVarianceSubIDLabel = new Label(AMWIPVarianceSubID);
                AMWIPVarianceSubID.DataField = "AMWIPVarianceSubID";
                AMMRPFcst = new CheckBox("ctl00_phG_tab_t5_edAMMRPFcst", "Forecasts", locator, null);
                AMMRPFcstLabel = new Label(AMMRPFcst);
                AMMRPFcst.DataField = "AMMRPFcst";
                AMMRPPO = new CheckBox("ctl00_phG_tab_t5_edAMMRPPO", "Purchase Orders", locator, null);
                AMMRPPOLabel = new Label(AMMRPPO);
                AMMRPPO.DataField = "AMMRPPO";
                AMMRPFlag = new CheckBox("ctl00_phG_tab_t5_edAMMRPFlag", "Inventory On Hand", locator, null);
                AMMRPFlagLabel = new Label(AMMRPFlag);
                AMMRPFlag.DataField = "AMMRPFlag";
                AMMRPProd = new CheckBox("ctl00_phG_tab_t5_edAMMRPProd", "Production Orders", locator, null);
                AMMRPProdLabel = new Label(AMMRPProd);
                AMMRPProd.DataField = "AMMRPProd";
                AMMRPMPS = new CheckBox("ctl00_phG_tab_t5_edAMMRPMPS", "MPS", locator, null);
                AMMRPMPSLabel = new Label(AMMRPMPS);
                AMMRPMPS.DataField = "AMMRPMPS";
                AMMRPSO = new CheckBox("ctl00_phG_tab_t5_edAMMRPSO", "Sales Orders", locator, null);
                AMMRPSOLabel = new Label(AMMRPSO);
                AMMRPSO.DataField = "AMMRPSO";
                AMMRPShip = new CheckBox("ctl00_phG_tab_t5_edAMMRPShip", "Shipments", locator, null);
                AMMRPShipLabel = new Label(AMMRPShip);
                AMMRPShip.DataField = "AMMRPShip";
                AMScrapSiteID = new Selector("ctl00_phG_tab_t5_edAMScrapSiteID", "Scrap Warehouse", locator, null);
                AMScrapSiteIDLabel = new Label(AMScrapSiteID);
                AMScrapSiteID.DataField = "AMScrapSiteID";
                AMScrapLocationID = new Selector("ctl00_phG_tab_t5_edAMScrapLocationID", "Location", locator, null);
                AMScrapLocationIDLabel = new Label(AMScrapLocationID);
                AMScrapLocationID.DataField = "AMScrapLocationID";
                Label1_importColumnDlg = new Label("ctl00_phG_tab_t0_grid_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_ = new Label("ctl00_phG_tab_t0_grid_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_ = new Label("ctl00_phG_tab_t0_grid_imp_upl_pnl_lblPassword", "Password:", locator, null);
                Label1_importColumnDlg2 = new Label("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_2 = new Label("ctl00_phG_tab_t1_gridCarts_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_2 = new Label("ctl00_phG_tab_t1_gridCarts_imp_upl_pnl_lblPassword", "Password:", locator, null);
                Label1_importColumnDlg3 = new Label("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_3 = new Label("ctl00_phG_tab_t2_gridTotes_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_3 = new Label("ctl00_phG_tab_t2_gridTotes_imp_upl_pnl_lblPassword", "Password:", locator, null);
                DataMemberName = "siteaccounts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AMScrapSiteIDEdit()
            {
                Buttons.AMScrapSiteIDEdit.Click();
            }
            
            public virtual void AMScrapLocationIDEdit()
            {
                Buttons.AMScrapLocationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AMScrapSiteIDEdit { get; }
			public Button AMScrapLocationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AMScrapSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_edAMScrapSiteID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "AMScrapSiteIDEdit", "ctl00_phG_tab");
                    AMScrapSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMScrapLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_edAMScrapLocationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMScrapLocationIDEdit", "ctl00_phG_tab");
                    AMScrapLocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_siteaccounts_buildform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BuildingID { get; }
			public Label BuildingIDLabel { get; }
            
            public c_siteaccounts_buildform(string locator, string name) : 
                    base(locator, name)
            {
                BuildingID = new Selector("ctl00_phG_tab_t4_buildForm_edBuilding", "Building ID", locator, null);
                BuildingIDLabel = new Label(BuildingID);
                BuildingID.DataField = "BuildingID";
                DataMemberName = "siteaccounts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void CountryIDEdit()
            {
                Buttons.CountryIDEdit.Click();
            }
            
            public virtual void StateEdit()
            {
                Buttons.StateEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button CountryIDEdit { get; }
			public Button StateEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t4_addrForm_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t4_buildForm");
                    ViewonMap = new Button("ctl00_phG_tab_t4_addrForm_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t4_buildForm");
                    CountryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_addrForm_edCountryID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "CountryIDEdit", "ctl00_phG_tab_t4_buildForm");
                    CountryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    StateEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_addrForm_edState\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "StateEdit", "ctl00_phG_tab_t4_buildForm");
                    StateEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_location_grid : Grid<c_location_grid.c_grid_row, c_location_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_location_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "location";
                Buttons = new PxButtonCollection();
                PredefinedFilter = new DropDown("ctl00_phG_tab_t0_grid_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                UploadForm = new c_grid_upload("ctl00_phG_tab_t0_grid_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_grid_fe_gf", "FilterForm");
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
            
            public virtual void Files()
            {
                ToolBar.Files.Click();
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
            
            public virtual void Filter()
            {
                ToolBar.Filter.Click();
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
			public ToolBarButtonGrid Files { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Files = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'FilesMenu\']", "Show the files attached to the record.", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_grid");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_grid");
                    Ok1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_grid");
                    Cancel1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_grid");
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid");
                    Ok2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid");
                    Cancel2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid");
                    Upload1 = new Button("ctl00_phG_tab_t0_grid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t0_grid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector LocationCD { get; }
			public PXTextEdit Descr { get; }
			public CheckBox Active { get; }
			public CheckBox IsSorting { get; }
			public CheckBox InclQtyAvail { get; }
			public CheckBox IsCosted { get; }
			public CheckBox SalesValid { get; }
			public CheckBox ReceiptsValid { get; }
			public CheckBox TransfersValid { get; }
			public CheckBox AssemblyValid { get; }
			public PXNumberEdit PickPriority { get; }
			public PXNumberEdit PathPriority { get; }
			public DropDown PrimaryItemValid { get; }
			public Selector PrimaryItemID { get; }
			public Selector PrimaryItemClassID { get; }
			public Selector ProjectID { get; }
			public Selector TaskID { get; }
			public CheckBox AMMRPFlag { get; }
			public PXNumberEdit SiteID { get; }
                
                public c_grid_row(c_location_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    LocationCD = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLocationCD", "Location ID", grid.Locator, "LocationCD");
                    LocationCD.DataField = "LocationCD";
                    Descr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edDescr", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    Active = new CheckBox("ctl00_phG_tab_t0_grid_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    IsSorting = new CheckBox("ctl00_phG_tab_t0_grid", "Sort Location", grid.Locator, "IsSorting");
                    IsSorting.DataField = "IsSorting";
                    InclQtyAvail = new CheckBox("ctl00_phG_tab_t0_grid_ef", "Include in Qty. Available", grid.Locator, "InclQtyAvail");
                    InclQtyAvail.DataField = "InclQtyAvail";
                    IsCosted = new CheckBox("ctl00_phG_tab_t0_grid_ef", "Cost Separately", grid.Locator, "IsCosted");
                    IsCosted.DataField = "IsCosted";
                    SalesValid = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkSalesValid", "Sales Allowed", grid.Locator, "SalesValid");
                    SalesValid.DataField = "SalesValid";
                    ReceiptsValid = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkReceiptsValid", "Receipts Allowed", grid.Locator, "ReceiptsValid");
                    ReceiptsValid.DataField = "ReceiptsValid";
                    TransfersValid = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkTransfersValid", "Transfers Allowed", grid.Locator, "TransfersValid");
                    TransfersValid.DataField = "TransfersValid";
                    AssemblyValid = new CheckBox("ctl00_phG_tab_t0_grid_ef", "Assembly Allowed", grid.Locator, "AssemblyValid");
                    AssemblyValid.DataField = "AssemblyValid";
                    PickPriority = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edPickPriority", "Pick Priority", grid.Locator, "PickPriority");
                    PickPriority.DataField = "PickPriority";
                    PathPriority = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Path", grid.Locator, "PathPriority");
                    PathPriority.DataField = "PathPriority";
                    PrimaryItemValid = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edPrimaryItemValid", "Primary Item Validation", grid.Locator, "PrimaryItemValid");
                    PrimaryItemValid.DataField = "PrimaryItemValid";
                    PrimaryItemValid.Items.Add("N", "No Validation");
                    PrimaryItemValid.Items.Add("X", "Primary Item Warning");
                    PrimaryItemValid.Items.Add("I", "Primary Item Error");
                    PrimaryItemValid.Items.Add("Y", "Primary Item Class Warning");
                    PrimaryItemValid.Items.Add("C", "Primary Item Class Error");
                    PrimaryItemID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPrimaryItemID", "Primary Item", grid.Locator, "PrimaryItemID");
                    PrimaryItemID.DataField = "PrimaryItemID";
                    PrimaryItemClassID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPrimaryItemClassID", "Primary Item Class", grid.Locator, "PrimaryItemClassID");
                    PrimaryItemClassID.DataField = "PrimaryItemClassID";
                    ProjectID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    AMMRPFlag = new CheckBox("ctl00_phG_tab_t0_grid", "MRP", grid.Locator, "AMMRPFlag");
                    AMMRPFlag.DataField = "AMMRPFlag";
                    SiteID = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "SiteID", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public InputColumnFilter LocationCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter IsSorting { get; }
				public CheckBoxColumnFilter InclQtyAvail { get; }
				public CheckBoxColumnFilter IsCosted { get; }
				public CheckBoxColumnFilter SalesValid { get; }
				public CheckBoxColumnFilter ReceiptsValid { get; }
				public CheckBoxColumnFilter TransfersValid { get; }
				public CheckBoxColumnFilter AssemblyValid { get; }
				public PXNumberEditColumnFilter PickPriority { get; }
				public PXNumberEditColumnFilter PathPriority { get; }
				public DropDownColumnFilter PrimaryItemValid { get; }
				public SelectorColumnFilter PrimaryItemID { get; }
				public SelectorColumnFilter PrimaryItemClassID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter TaskID { get; }
				public CheckBoxColumnFilter AMMRPFlag { get; }
				public PXNumberEditColumnFilter SiteID { get; }
                
                public c_grid_header(c_location_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    LocationCD = new InputColumnFilter(grid.Row.LocationCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    IsSorting = new CheckBoxColumnFilter(grid.Row.IsSorting);
                    InclQtyAvail = new CheckBoxColumnFilter(grid.Row.InclQtyAvail);
                    IsCosted = new CheckBoxColumnFilter(grid.Row.IsCosted);
                    SalesValid = new CheckBoxColumnFilter(grid.Row.SalesValid);
                    ReceiptsValid = new CheckBoxColumnFilter(grid.Row.ReceiptsValid);
                    TransfersValid = new CheckBoxColumnFilter(grid.Row.TransfersValid);
                    AssemblyValid = new CheckBoxColumnFilter(grid.Row.AssemblyValid);
                    PickPriority = new PXNumberEditColumnFilter(grid.Row.PickPriority);
                    PathPriority = new PXNumberEditColumnFilter(grid.Row.PathPriority);
                    PrimaryItemValid = new DropDownColumnFilter(grid.Row.PrimaryItemValid);
                    PrimaryItemID = new SelectorColumnFilter(grid.Row.PrimaryItemID);
                    PrimaryItemClassID = new SelectorColumnFilter(grid.Row.PrimaryItemClassID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    AMMRPFlag = new CheckBoxColumnFilter(grid.Row.AMMRPFlag);
                    SiteID = new PXNumberEditColumnFilter(grid.Row.SiteID);
                }
            }
        }
        
        public class c_location_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector LocationCD { get; }
			public Label LocationCDLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
			public CheckBox SalesValid { get; }
			public Label SalesValidLabel { get; }
			public CheckBox ReceiptsValid { get; }
			public Label ReceiptsValidLabel { get; }
			public CheckBox TransfersValid { get; }
			public Label TransfersValidLabel { get; }
			public DropDown PrimaryItemValid { get; }
			public Label PrimaryItemValidLabel { get; }
			public Selector PrimaryItemID { get; }
			public Label PrimaryItemIDLabel { get; }
			public Selector PrimaryItemClassID { get; }
			public Label PrimaryItemClassIDLabel { get; }
			public PXNumberEdit PickPriority { get; }
			public Label PickPriorityLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_location_lv0(string locator, string name) : 
                    base(locator, name)
            {
                LocationCD = new Selector("ctl00_phG_tab_t0_grid_lv0_edLocationCD", "Location ID", locator, null);
                LocationCDLabel = new Label(LocationCD);
                LocationCD.DataField = "LocationCD";
                Descr = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                SalesValid = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkSalesValid", "Sales Allowed", locator, null);
                SalesValidLabel = new Label(SalesValid);
                SalesValid.DataField = "SalesValid";
                ReceiptsValid = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkReceiptsValid", "Receipts Allowed", locator, null);
                ReceiptsValidLabel = new Label(ReceiptsValid);
                ReceiptsValid.DataField = "ReceiptsValid";
                TransfersValid = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkTransfersValid", "Transfers Allowed", locator, null);
                TransfersValidLabel = new Label(TransfersValid);
                TransfersValid.DataField = "TransfersValid";
                PrimaryItemValid = new DropDown("ctl00_phG_tab_t0_grid_lv0_edPrimaryItemValid", "Primary Item Validation", locator, null);
                PrimaryItemValidLabel = new Label(PrimaryItemValid);
                PrimaryItemValid.DataField = "PrimaryItemValid";
                PrimaryItemValid.Items.Add("N", "No Validation");
                PrimaryItemValid.Items.Add("X", "Primary Item Warning");
                PrimaryItemValid.Items.Add("I", "Primary Item Error");
                PrimaryItemValid.Items.Add("Y", "Primary Item Class Warning");
                PrimaryItemValid.Items.Add("C", "Primary Item Class Error");
                PrimaryItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edPrimaryItemID", "Primary Item", locator, null);
                PrimaryItemIDLabel = new Label(PrimaryItemID);
                PrimaryItemID.DataField = "PrimaryItemID";
                PrimaryItemClassID = new Selector("ctl00_phG_tab_t0_grid_lv0_edPrimaryItemClassID", "Primary Item Class", locator, null);
                PrimaryItemClassIDLabel = new Label(PrimaryItemClassID);
                PrimaryItemClassID.DataField = "PrimaryItemClassID";
                PickPriority = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edPickPriority", "Pick Priority", locator, null);
                PickPriorityLabel = new Label(PickPriority);
                PickPriority.DataField = "PickPriority";
                ProjectID = new Selector("ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "location";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PrimaryItemIDEdit()
            {
                Buttons.PrimaryItemIDEdit.Click();
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
                
			public Button PrimaryItemIDEdit { get; }
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
                    PrimaryItemIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edPrimaryItemID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "PrimaryItemIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    PrimaryItemIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_grid_lv0");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_grid_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_grid_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_grid_lv0");
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid_lv0");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid_lv0");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid_lv0");
                    Upload = new Button("ctl00_phG_tab_t0_grid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t0_grid_lv0");
                }
            }
        }
        
        public class c_carts_gridcarts : Grid<c_carts_gridcarts.c_grid_row, c_carts_gridcarts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_carts_gridcarts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_gridCarts");
                DataMemberName = "carts";
                Buttons = new PxButtonCollection();
                PredefinedFilter = new DropDown("ctl00_phG_tab_t1_gridCarts_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                UploadForm = new c_grid_upload("ctl00_phG_tab_t1_gridCarts_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_gridCarts_fe_gf", "FilterForm");
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
            
            public virtual void ViewTotesInCart()
            {
                ToolBar.ViewTotesInCart.Click();
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
            
            public virtual void Filter()
            {
                ToolBar.Filter.Click();
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
			public ToolBarButtonGrid ViewTotesInCart { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    ViewTotesInCart = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'ViewTotesInCart\']", "Assigned Totes", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridCarts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    Ok = new Button("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t1_gridCarts");
                    Cancel = new Button("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t1_gridCarts");
                    Ok1 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t1_gridCarts");
                    Cancel1 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t1_gridCarts");
                    First = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t1_gridCarts");
                    Prev = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t1_gridCarts");
                    Next = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t1_gridCarts");
                    Last = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t1_gridCarts");
                    Ok2 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridCarts");
                    Cancel2 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridCarts");
                    Upload1 = new Button("ctl00_phG_tab_t1_gridCarts_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t1_gridCarts");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector CartCD { get; }
			public PXTextEdit Descr { get; }
			public PXNumberEdit AssignedNbrOfTotes { get; }
			public CheckBox Active { get; }
			public Selector SiteID { get; }
                
                public c_grid_row(c_carts_gridcarts grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    CartCD = new Selector("_ctl00_phG_tab_t1_gridCarts_lv0_edCartCD", "Cart ID", grid.Locator, "CartCD");
                    CartCD.DataField = "CartCD";
                    Descr = new PXTextEdit("ctl00_phG_tab_t1_gridCarts_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    AssignedNbrOfTotes = new PXNumberEdit("ctl00_phG_tab_t1_gridCarts_en", "Assigned Number of Totes", grid.Locator, "AssignedNbrOfTotes");
                    AssignedNbrOfTotes.DataField = "AssignedNbrOfTotes";
                    Active = new CheckBox("ctl00_phG_tab_t1_gridCarts", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    SiteID = new Selector("_ctl00_phG_tab_t1_gridCarts_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter CartCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public PXNumberEditColumnFilter AssignedNbrOfTotes { get; }
				public CheckBoxColumnFilter Active { get; }
				public SelectorColumnFilter SiteID { get; }
                
                public c_grid_header(c_carts_gridcarts grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    CartCD = new SelectorColumnFilter(grid.Row.CartCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    AssignedNbrOfTotes = new PXNumberEditColumnFilter(grid.Row.AssignedNbrOfTotes);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                }
            }
        }
        
        public class c_carts_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CartCD { get; }
			public Label CartCDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_carts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CartCD = new Selector("ctl00_phG_tab_t1_gridCarts_lv0_edCartCD", "Cart ID", locator, null);
                CartCDLabel = new Label(CartCD);
                CartCD.DataField = "CartCD";
                Es = new Selector("ctl00_phG_tab_t1_gridCarts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "carts";
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
                    Ok = new Button("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Cancel = new Button("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t1_gridCarts_lv0");
                    First = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Next = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Last = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridCarts_lv0");
                    Upload = new Button("ctl00_phG_tab_t1_gridCarts_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t1_gridCarts_lv0");
                }
            }
        }
        
        public class c_totes_gridtotes : Grid<c_totes_gridtotes.c_grid_row, c_totes_gridtotes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_totes_gridtotes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_gridTotes");
                DataMemberName = "totes";
                Buttons = new PxButtonCollection();
                PredefinedFilter = new DropDown("ctl00_phG_tab_t2_gridTotes_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                UploadForm = new c_grid_upload("ctl00_phG_tab_t2_gridTotes_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_gridTotes_fe_gf", "FilterForm");
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
            
            public virtual void Filter()
            {
                ToolBar.Filter.Click();
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
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridTotes_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    Ok = new Button("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t2_gridTotes");
                    Cancel = new Button("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t2_gridTotes");
                    Ok1 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t2_gridTotes");
                    Cancel1 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t2_gridTotes");
                    First = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridTotes");
                    Prev = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridTotes");
                    Next = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridTotes");
                    Last = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridTotes");
                    Ok2 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridTotes");
                    Cancel2 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridTotes");
                    Upload1 = new Button("ctl00_phG_tab_t2_gridTotes_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t2_gridTotes");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector ToteCD { get; }
			public PXTextEdit Descr { get; }
			public Selector AssignedCartID { get; }
			public CheckBox Active { get; }
			public Selector SiteID { get; }
                
                public c_grid_row(c_totes_gridtotes grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ToteCD = new Selector("_ctl00_phG_tab_t2_gridTotes_lv0_edToteCD", "Tote ID", grid.Locator, "ToteCD");
                    ToteCD.DataField = "ToteCD";
                    Descr = new PXTextEdit("ctl00_phG_tab_t2_gridTotes_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    AssignedCartID = new Selector("_ctl00_phG_tab_t2_gridTotes_lv0_es", "Assigned Cart ID", grid.Locator, "AssignedCartID");
                    AssignedCartID.DataField = "AssignedCartID";
                    Active = new CheckBox("ctl00_phG_tab_t2_gridTotes", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    SiteID = new Selector("_ctl00_phG_tab_t2_gridTotes_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter ToteCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter AssignedCartID { get; }
				public CheckBoxColumnFilter Active { get; }
				public SelectorColumnFilter SiteID { get; }
                
                public c_grid_header(c_totes_gridtotes grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ToteCD = new SelectorColumnFilter(grid.Row.ToteCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    AssignedCartID = new SelectorColumnFilter(grid.Row.AssignedCartID);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                }
            }
        }
        
        public class c_totes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ToteCD { get; }
			public Label ToteCDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_totes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ToteCD = new Selector("ctl00_phG_tab_t2_gridTotes_lv0_edToteCD", "Tote ID", locator, null);
                ToteCDLabel = new Label(ToteCD);
                ToteCD.DataField = "ToteCD";
                Es = new Selector("ctl00_phG_tab_t2_gridTotes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "totes";
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
                    Ok = new Button("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Cancel = new Button("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t2_gridTotes_lv0");
                    First = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Prev = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Next = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Last = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridTotes_lv0");
                    Upload = new Button("ctl00_phG_tab_t2_gridTotes_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t2_gridTotes_lv0");
                }
            }
        }
        
        public class c_totesincart_gridtotesincart : Grid<c_totesincart_gridtotesincart.c_grid_row, c_totesincart_gridtotesincart.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_totesincart_gridtotesincart(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_ViewTotesInCartDialog_gridTotesInCart");
                DataMemberName = "totesInCart";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_at_tlb div[data-cmd=\'Refresh" +
                            "\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_at_tlb div[data-cmd=\'AdjustC" +
                            "olumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_at_tlb div[data-cmd=\'ExportE" +
                            "xcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_ab_tlb div[data-cmd=\'PageFir" +
                            "st\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_ab_tlb div[data-cmd=\'PagePre" +
                            "v\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_ab_tlb div[data-cmd=\'PageNex" +
                            "t\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_ab_tlb div[data-cmd=\'PageLas" +
                            "t\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_ViewTotesInCartDialog_PXButton1", "OK", "ctl00_phG_ViewTotesInCartDialog_gridTotesInCart");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector ToteCD { get; }
			public PXTextEdit Descr { get; }
			public CheckBox Active { get; }
			public Selector SiteID { get; }
                
                public c_grid_row(c_totesincart_gridtotesincart grid) : 
                        base(grid)
                {
                    ToteCD = new Selector("_ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_lv0_es", "Tote ID", grid.Locator, "ToteCD");
                    ToteCD.DataField = "ToteCD";
                    Descr = new PXTextEdit("ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    Active = new CheckBox("ctl00_phG_ViewTotesInCartDialog_gridTotesInCart", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    SiteID = new Selector("_ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter ToteCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter Active { get; }
				public SelectorColumnFilter SiteID { get; }
                
                public c_grid_header(c_totesincart_gridtotesincart grid) : 
                        base(grid)
                {
                    ToteCD = new SelectorColumnFilter(grid.Row.ToteCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                }
            }
        }
        
        public class c_totesincart_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_totesincart_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "totesInCart";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_ViewTotesInCartDialog_PXButton1", "OK", "ctl00_phG_ViewTotesInCartDialog_gridTotesInCart_lv0");
                }
            }
        }
        
        public class c_address_addrform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_address_addrform(string locator, string name) : 
                    base(locator, name)
            {
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t4_addrForm_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t4_addrForm_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t4_addrForm_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t4_addrForm_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t4_addrForm_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t4_addrForm_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                IsValidated = new CheckBox("ctl00_phG_tab_t4_addrForm_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Address";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void CountryIDEdit()
            {
                Buttons.CountryIDEdit.Click();
            }
            
            public virtual void StateEdit()
            {
                Buttons.StateEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button CountryIDEdit { get; }
			public Button StateEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t4_addrForm_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t4_addrForm");
                    ViewonMap = new Button("ctl00_phG_tab_t4_addrForm_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t4_addrForm");
                    CountryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_addrForm_edCountryID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "CountryIDEdit", "ctl00_phG_tab_t4_addrForm");
                    CountryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    StateEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_addrForm_edState\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "StateEdit", "ctl00_phG_tab_t4_addrForm");
                    StateEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_contact_colform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
            
            public c_contact_colform(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t4_colForm_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t4_colForm_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                EMail = new EmailEdit("ctl00_phG_tab_t4_colForm_edEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t4_colForm_edWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t4_colForm_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2 = new PXTextEdit("ctl00_phG_tab_t4_colForm_edPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                Fax = new PXTextEdit("ctl00_phG_tab_t4_colForm_edFax", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                DataMemberName = "Contact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void CountryIDEdit()
            {
                Buttons.CountryIDEdit.Click();
            }
            
            public virtual void StateEdit()
            {
                Buttons.StateEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button CountryIDEdit { get; }
			public Button StateEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t4_addrForm_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t4_colForm");
                    ViewonMap = new Button("ctl00_phG_tab_t4_addrForm_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t4_colForm");
                    CountryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_addrForm_edCountryID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "CountryIDEdit", "ctl00_phG_tab_t4_colForm");
                    CountryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    StateEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_addrForm_edState\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "StateEdit", "ctl00_phG_tab_t4_colForm");
                    StateEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_addresslookupfilter_addresslookuppanelformaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit SearchAddress { get; }
			public Label SearchAddressLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit AddressLine3 { get; }
			public Label AddressLine3Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public PXTextEdit CountryID { get; }
			public Label CountryIDLabel { get; }
			public PXTextEdit State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public PXTextEdit Latitude { get; }
			public Label LatitudeLabel { get; }
			public PXTextEdit Longitude { get; }
			public Label LongitudeLabel { get; }
            
            public c_addresslookupfilter_addresslookuppanelformaddress(string locator, string name) : 
                    base(locator, name)
            {
                SearchAddress = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_searchBox", "Search Address", locator, null);
                SearchAddressLabel = new Label(SearchAddress);
                SearchAddress.DataField = "SearchAddress";
                ViewName = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_addressLookupViewName", "ViewName", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                AddressLine1 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine1", "AddressLine1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine2", "AddressLine2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                AddressLine3 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine3", "AddressLine3", locator, null);
                AddressLine3Label = new Label(AddressLine3);
                AddressLine3.DataField = "AddressLine3";
                City = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseCountry", "CountryID", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponsePostalCo" +
                        "de", "PostalCode", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                Latitude = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseLatitude" +
                        "", "Latitude", locator, null);
                LatitudeLabel = new Label(Latitude);
                Latitude.DataField = "Latitude";
                Longitude = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseLongitud" +
                        "e", "Longitude", locator, null);
                LongitudeLabel = new Label(Longitude);
                Longitude.DataField = "Longitude";
                DataMemberName = "AddressLookupFilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Select()
            {
                Buttons.Select.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Select { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Select = new Button("ctl00_phG_AddressLookupPanel_AddressLookupSelectAction", "Select", "ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress");
                    Cancel = new Button("ctl00_phG_AddressLookupPanel_AddressEntityBtnCancel", "Cancel", "ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress");
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
                CD = new Selector("ctl00_phF_pnlChangeID_formChangeID_edAcctCD", "Warehouse ID", locator, null);
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
        
        public class c_location_importcsvsettings_frmimportcsvsettings : Container
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
            
            public c_location_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "location$ImportCSVSettings";
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
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_location_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_location_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edNullValue" +
                        "", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "location$ImportXLSXSettings";
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
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                }
            }
        }
        
        public class c_location_importcolumns_grdimportcolumn : Grid<c_location_importcolumns_grdimportcolumn.c_grid_row, c_location_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_location_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "location$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_location_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_location_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_location_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_location_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "location$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
        
        public class c_carts_importcsvsettings_frmimportcsvsettings : Container
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
            
            public c_carts_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings_edSepara" +
                        "tor", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings_edNullVa" +
                        "lue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings_edCodePa" +
                        "ge", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings_edCultur" +
                        "es", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "carts$ImportCSVSettings";
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
                    Ok = new Button("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t1_gridCarts_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_carts_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_carts_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edNull" +
                        "Value", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edCult" +
                        "ures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edMode" +
                        "", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "carts$ImportXLSXSettings";
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
                    Ok = new Button("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                    Cancel = new Button("ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t1_gridCarts_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                }
            }
        }
        
        public class c_carts_importcolumns_grdimportcolumn : Grid<c_carts_importcolumns_grdimportcolumn.c_grid_row, c_carts_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_carts_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "carts$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_carts_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_carts_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_carts_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_carts_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "carts$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t1_gridCarts_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
        
        public class c_totes_importcsvsettings_frmimportcsvsettings : Container
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
            
            public c_totes_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings_edSepara" +
                        "tor", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings_edNullVa" +
                        "lue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings_edCodePa" +
                        "ge", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings_edCultur" +
                        "es", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "totes$ImportCSVSettings";
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
                    Ok = new Button("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t2_gridTotes_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_totes_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_totes_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edNull" +
                        "Value", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edCult" +
                        "ures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edMode" +
                        "", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "totes$ImportXLSXSettings";
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
                    Ok = new Button("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                    Cancel = new Button("ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t2_gridTotes_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                }
            }
        }
        
        public class c_totes_importcolumns_grdimportcolumn : Grid<c_totes_importcolumns_grdimportcolumn.c_grid_row, c_totes_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_totes_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "totes$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_totes_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_totes_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_totes_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_totes_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "totes$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t2_gridTotes_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
    }
}
