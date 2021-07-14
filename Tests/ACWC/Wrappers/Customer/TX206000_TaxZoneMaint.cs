using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ACBC.Tests.Wrappers
{
    
    
    public class TX206000_TaxZoneMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_txzone_form TxZone_form { get; } = new c_txzone_form("ctl00_phF_form", "TxZone_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_details_grid Details_grid { get; } = new c_details_grid("ctl00_phG_PXTab1_t0_grid", "Details_grid");
        protected c_details_lv0 Details_lv0 { get; } = new c_details_lv0("ctl00_phG_PXTab1_t0_grid_lv0", "Details_lv0");
        protected c_zip_gridzip Zip_gridZip { get; } = new c_zip_gridzip("ctl00_phG_PXTab1_t1_gridZip", "Zip_gridZip");
        protected c_zip_lv0 Zip_lv0 { get; } = new c_zip_lv0("ctl00_phG_PXTab1_t1_gridZip_lv0", "Zip_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_zip_importcsvsettings_frmimportcsvsettings Zip_ImportCSVSettings_frmImportCSVSettings { get; } = new c_zip_importcsvsettings_frmimportcsvsettings("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings", "Zip$ImportCSVSettings_frmImportCSVSettings");
        protected c_zip_importxlsxsettings_frmimportxlsxsettings Zip_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_zip_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "Zip$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_zip_importcolumns_grdimportcolumn Zip_ImportColumns_grdImportColumn { get; } = new c_zip_importcolumns_grdimportcolumn("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn", "Zip$ImportColumns_grdImportColumn");
        protected c_zip_importcolumns_lv0 Zip_ImportColumns_lv0 { get; } = new c_zip_importcolumns_lv0("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0", "Zip$ImportColumns_lv0");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public TX206000_TaxZoneMaint()
        {
            ScreenId = "TX206000";
            ScreenUrl = "/Pages/TX/TX206000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual TX206000_TaxZoneMaint ReadOne(Gate gate, string TaxZoneID)
        {
            new BiObject<TX206000_TaxZoneMaint>(gate).ReadOne(this, TaxZoneID);
            return this;
        }
        
        public virtual TX206000_TaxZoneMaint ReadOne(string TaxZoneID)
        {
            return this.ReadOne(ApiConnection.Source, TaxZoneID);
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
        
        public virtual void ManageAttributes()
        {
            ToolBar.ManageAttributes.Click();
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
			public ToolBarButton ManageAttributes { get; }
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
                ManageAttributes = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ManageAttributes\']", "Manage User-Defined Fields", locator, Custom);
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
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_txzone_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
			public Selector DfltTaxCategoryID { get; }
			public Label DfltTaxCategoryIDLabel { get; }
			public CheckBox IsExternal { get; }
			public Label IsExternalLabel { get; }
			public Selector TaxPluginID { get; }
			public Label TaxPluginIDLabel { get; }
			public Selector TaxVendorID { get; }
			public Label TaxVendorIDLabel { get; }
			public CheckBox IsManualVATZone { get; }
			public Label IsManualVATZoneLabel { get; }
			public Selector TaxID { get; }
			public Label TaxIDLabel { get; }
			public CheckBox ShowTaxTabExpr { get; }
			public Label ShowTaxTabExprLabel { get; }
			public CheckBox ShowZipTabExpr { get; }
			public Label ShowZipTabExprLabel { get; }
            
            public c_txzone_form(string locator, string name) : 
                    base(locator, name)
            {
                TaxZoneID = new Selector("ctl00_phF_form_t0_edTaxZoneID", "Tax Zone ID", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                Descr = new PXTextEdit("ctl00_phF_form_t0_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                DfltTaxCategoryID = new Selector("ctl00_phF_form_t0_edDfltTaxCategoryID", "Default Tax Category", locator, null);
                DfltTaxCategoryIDLabel = new Label(DfltTaxCategoryID);
                DfltTaxCategoryID.DataField = "DfltTaxCategoryID";
                IsExternal = new CheckBox("ctl00_phF_form_t0_chkIsExternal", "External Tax Provider", locator, null);
                IsExternalLabel = new Label(IsExternal);
                IsExternal.DataField = "IsExternal";
                TaxPluginID = new Selector("ctl00_phF_form_t0_edTaxPluginID", "Provider ID", locator, null);
                TaxPluginIDLabel = new Label(TaxPluginID);
                TaxPluginID.DataField = "TaxPluginID";
                TaxVendorID = new Selector("ctl00_phF_form_t0_edTaxVendorID", "Tax Agency ID", locator, null);
                TaxVendorIDLabel = new Label(TaxVendorID);
                TaxVendorID.DataField = "TaxVendorID";
                IsManualVATZone = new CheckBox("ctl00_phF_form_t0_chkIsManualVATZone", "Manual VAT Entry", locator, null);
                IsManualVATZoneLabel = new Label(IsManualVATZone);
                IsManualVATZone.DataField = "IsManualVATZone";
                TaxID = new Selector("ctl00_phF_form_t0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                ShowTaxTabExpr = new CheckBox("ctl00_phF_form_t0_chkShowTaxTabExpr", "ShowTaxTabExpr", locator, null);
                ShowTaxTabExprLabel = new Label(ShowTaxTabExpr);
                ShowTaxTabExpr.DataField = "ShowTaxTabExpr";
                ShowZipTabExpr = new CheckBox("ctl00_phF_form_t0_chkShowZipTabExpr", "ShowZipTabExpr", locator, null);
                ShowZipTabExprLabel = new Label(ShowZipTabExpr);
                ShowZipTabExpr.DataField = "ShowZipTabExpr";
                DataMemberName = "TxZone";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DfltTaxCategoryIDEdit()
            {
                Buttons.DfltTaxCategoryIDEdit.Click();
            }
            
            public virtual void TaxPluginIDEdit()
            {
                Buttons.TaxPluginIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DfltTaxCategoryIDEdit { get; }
			public Button TaxPluginIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DfltTaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edDfltTaxCategoryID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "DfltTaxCategoryIDEdit", "ctl00_phF_form");
                    DfltTaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TaxPluginIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edTaxPluginID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "TaxPluginIDEdit", "ctl00_phF_form");
                    TaxPluginIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
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
        
        public class c_details_grid : Grid<c_details_grid.c_grid_row, c_details_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_details_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXTab1_t0_grid");
                DataMemberName = "Details";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PXTab1_t0_grid_fe_gf", "FilterForm");
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
            
            public virtual void TaxIDEdit()
            {
                Buttons.TaxIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxIDEdit = new Button("css=div[id=\'ctl00_phG_PXTab1_t0_grid_lv0_edTaxID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "TaxIDEdit", "ctl00_phG_PXTab1_t0_grid");
                    TaxIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxID { get; }
			public InputLocalizable Tax__Descr { get; }
			public DropDown Tax__TaxType { get; }
			public DropDown Tax__TaxCalcRule { get; }
			public DropDown Tax__TaxApplyTermsDisc { get; }
			public Selector TaxZoneID { get; }
                
                public c_grid_row(c_details_grid grid) : 
                        base(grid)
                {
                    TaxID = new Selector("_ctl00_phG_PXTab1_t0_grid_lv0_edTaxID", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    Tax__Descr = new InputLocalizable("_ctl00_phG_PXTab1_t0_grid_lv0_edTax__Descr", "Description", grid.Locator, "Tax__Descr");
                    Tax__Descr.DataField = "Tax__Descr";
                    Tax__TaxType = new DropDown("_ctl00_phG_PXTab1_t0_grid_lv0_edTax__TaxType", "Tax Type", grid.Locator, "Tax__TaxType");
                    Tax__TaxType.DataField = "Tax__TaxType";
                    Tax__TaxType.Items.Add("S", "Sales");
                    Tax__TaxType.Items.Add("P", "Use");
                    Tax__TaxType.Items.Add("V", "VAT");
                    Tax__TaxType.Items.Add("W", "Withholding");
                    Tax__TaxType.Items.Add("Q", "Per-Unit/Specific");
                    Tax__TaxCalcRule = new DropDown("_ctl00_phG_PXTab1_t0_grid_lv0_edTax__TaxCalcRule", "Calculation Rule", grid.Locator, "Tax__TaxCalcRule");
                    Tax__TaxCalcRule.DataField = "Tax__TaxCalcRule";
                    Tax__TaxCalcRule.Items.Add("I0", "Inclusive Line-Level");
                    Tax__TaxCalcRule.Items.Add("I1", "Exclusive Line-Level");
                    Tax__TaxCalcRule.Items.Add("I2", "Compound Line-Level");
                    Tax__TaxCalcRule.Items.Add("D0", "Inclusive Document-Level");
                    Tax__TaxCalcRule.Items.Add("D1", "Exclusive Document-Level");
                    Tax__TaxCalcRule.Items.Add("D2", "Compound Document-Level");
                    Tax__TaxApplyTermsDisc = new DropDown("_ctl00_phG_PXTab1_t0_grid_lv0_edTax__TaxApplyTermsDisc", "Cash Discount", grid.Locator, "Tax__TaxApplyTermsDisc");
                    Tax__TaxApplyTermsDisc.DataField = "Tax__TaxApplyTermsDisc";
                    Tax__TaxApplyTermsDisc.Items.Add("X", "Reduces Taxable Amount");
                    Tax__TaxApplyTermsDisc.Items.Add("P", "Reduces Taxable Amount on Early Payment");
                    Tax__TaxApplyTermsDisc.Items.Add("N", "Does Not Affect Taxable Amount");
                    TaxZoneID = new Selector("_ctl00_phG_PXTab1_t0_grid_lv0_es", "Tax Zone ID", grid.Locator, "TaxZoneID");
                    TaxZoneID.DataField = "TaxZoneID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxID { get; }
				public PXTextEditColumnFilter Tax__Descr { get; }
				public DropDownColumnFilter Tax__TaxType { get; }
				public DropDownColumnFilter Tax__TaxCalcRule { get; }
				public DropDownColumnFilter Tax__TaxApplyTermsDisc { get; }
				public SelectorColumnFilter TaxZoneID { get; }
                
                public c_grid_header(c_details_grid grid) : 
                        base(grid)
                {
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                    Tax__Descr = new PXTextEditColumnFilter(grid.Row.Tax__Descr);
                    Tax__TaxType = new DropDownColumnFilter(grid.Row.Tax__TaxType);
                    Tax__TaxCalcRule = new DropDownColumnFilter(grid.Row.Tax__TaxCalcRule);
                    Tax__TaxApplyTermsDisc = new DropDownColumnFilter(grid.Row.Tax__TaxApplyTermsDisc);
                    TaxZoneID = new SelectorColumnFilter(grid.Row.TaxZoneID);
                }
            }
        }
        
        public class c_details_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Tax__TaxType { get; }
			public Label Tax__TaxTypeLabel { get; }
			public Selector TaxID { get; }
			public Label TaxIDLabel { get; }
			public InputLocalizable Tax__Descr { get; }
			public Label Tax__DescrLabel { get; }
			public DropDown Tax__TaxCalcRule { get; }
			public Label Tax__TaxCalcRuleLabel { get; }
			public DropDown Tax__TaxApplyTermsDisc { get; }
			public Label Tax__TaxApplyTermsDiscLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_details_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Tax__TaxType = new DropDown("ctl00_phG_PXTab1_t0_grid_lv0_edTax__TaxType", "Tax Type", locator, null);
                Tax__TaxTypeLabel = new Label(Tax__TaxType);
                Tax__TaxType.DataField = "Tax__TaxType";
                Tax__TaxType.Items.Add("S", "Sales");
                Tax__TaxType.Items.Add("P", "Use");
                Tax__TaxType.Items.Add("V", "VAT");
                Tax__TaxType.Items.Add("W", "Withholding");
                Tax__TaxType.Items.Add("Q", "Per-Unit/Specific");
                TaxID = new Selector("ctl00_phG_PXTab1_t0_grid_lv0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                Tax__Descr = new InputLocalizable("ctl00_phG_PXTab1_t0_grid_lv0_edTax__Descr", "Description", locator, null);
                Tax__DescrLabel = new Label(Tax__Descr);
                Tax__Descr.DataField = "Tax__Descr";
                Tax__TaxCalcRule = new DropDown("ctl00_phG_PXTab1_t0_grid_lv0_edTax__TaxCalcRule", "Calculation Rule", locator, null);
                Tax__TaxCalcRuleLabel = new Label(Tax__TaxCalcRule);
                Tax__TaxCalcRule.DataField = "Tax__TaxCalcRule";
                Tax__TaxCalcRule.Items.Add("I0", "Inclusive Line-Level");
                Tax__TaxCalcRule.Items.Add("I1", "Exclusive Line-Level");
                Tax__TaxCalcRule.Items.Add("I2", "Compound Line-Level");
                Tax__TaxCalcRule.Items.Add("D0", "Inclusive Document-Level");
                Tax__TaxCalcRule.Items.Add("D1", "Exclusive Document-Level");
                Tax__TaxCalcRule.Items.Add("D2", "Compound Document-Level");
                Tax__TaxApplyTermsDisc = new DropDown("ctl00_phG_PXTab1_t0_grid_lv0_edTax__TaxApplyTermsDisc", "Cash Discount", locator, null);
                Tax__TaxApplyTermsDiscLabel = new Label(Tax__TaxApplyTermsDisc);
                Tax__TaxApplyTermsDisc.DataField = "Tax__TaxApplyTermsDisc";
                Tax__TaxApplyTermsDisc.Items.Add("X", "Reduces Taxable Amount");
                Tax__TaxApplyTermsDisc.Items.Add("P", "Reduces Taxable Amount on Early Payment");
                Tax__TaxApplyTermsDisc.Items.Add("N", "Does Not Affect Taxable Amount");
                Es = new Selector("ctl00_phG_PXTab1_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Details";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TaxIDEdit()
            {
                Buttons.TaxIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxIDEdit = new Button("css=div[id=\'ctl00_phG_PXTab1_t0_grid_lv0_edTaxID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "TaxIDEdit", "ctl00_phG_PXTab1_t0_grid_lv0");
                    TaxIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_zip_gridzip : Grid<c_zip_gridzip.c_grid_row, c_zip_gridzip.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_zip_gridzip(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXTab1_t1_gridZip");
                DataMemberName = "Zip";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_PXTab1_t1_gridZip_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_PXTab1_t1_gridZip_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_gridZip_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    Ok = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_PXTab1_t1_gridZip");
                    Cancel = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_PXTab1_t1_gridZip");
                    Ok1 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_PXTab1_t1_gridZip");
                    Cancel1 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_PXTab1_t1_gridZip");
                    First = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_PXTab1_t1_gridZip");
                    Prev = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_PXTab1_t1_gridZip");
                    Next = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_PXTab1_t1_gridZip");
                    Last = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_PXTab1_t1_gridZip");
                    Ok2 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_PXTab1_t1_gridZip");
                    Cancel2 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_PXTab1_t1_gridZip");
                    Upload1 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_PXTab1_t1_gridZip");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ZipCode { get; }
			public PXNumberEdit ZipMin { get; }
			public PXNumberEdit ZipMax { get; }
			public PXTextEdit TaxZoneID { get; }
                
                public c_grid_row(c_zip_gridzip grid) : 
                        base(grid)
                {
                    ZipCode = new PXTextEdit("_ctl00_phG_PXTab1_t1_gridZip_lv0_edZipCode", "Zip Code", grid.Locator, "ZipCode");
                    ZipCode.DataField = "ZipCode";
                    ZipMin = new PXNumberEdit("_ctl00_phG_PXTab1_t1_gridZip_lv0_edZipMin", "Zip Code+4 (Min.)", grid.Locator, "ZipMin");
                    ZipMin.DataField = "ZipMin";
                    ZipMax = new PXNumberEdit("_ctl00_phG_PXTab1_t1_gridZip_lv0_edZipMax", "Zip Code+4 (Max.)", grid.Locator, "ZipMax");
                    ZipMax.DataField = "ZipMax";
                    TaxZoneID = new PXTextEdit("ctl00_phG_PXTab1_t1_gridZip_ei", "TaxZoneID", grid.Locator, "TaxZoneID");
                    TaxZoneID.DataField = "TaxZoneID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ZipCode { get; }
				public PXNumberEditColumnFilter ZipMin { get; }
				public PXNumberEditColumnFilter ZipMax { get; }
				public PXTextEditColumnFilter TaxZoneID { get; }
                
                public c_grid_header(c_zip_gridzip grid) : 
                        base(grid)
                {
                    ZipCode = new PXTextEditColumnFilter(grid.Row.ZipCode);
                    ZipMin = new PXNumberEditColumnFilter(grid.Row.ZipMin);
                    ZipMax = new PXNumberEditColumnFilter(grid.Row.ZipMax);
                    TaxZoneID = new PXTextEditColumnFilter(grid.Row.TaxZoneID);
                }
            }
        }
        
        public class c_zip_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit ZipCode { get; }
			public Label ZipCodeLabel { get; }
			public PXNumberEdit ZipMin { get; }
			public Label ZipMinLabel { get; }
			public PXNumberEdit ZipMax { get; }
			public Label ZipMaxLabel { get; }
            
            public c_zip_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ZipCode = new PXTextEdit("ctl00_phG_PXTab1_t1_gridZip_lv0_edZipCode", "Zip Code", locator, null);
                ZipCodeLabel = new Label(ZipCode);
                ZipCode.DataField = "ZipCode";
                ZipMin = new PXNumberEdit("ctl00_phG_PXTab1_t1_gridZip_lv0_edZipMin", "Zip Code+4 (Min.)", locator, null);
                ZipMinLabel = new Label(ZipMin);
                ZipMin.DataField = "ZipMin";
                ZipMax = new PXNumberEdit("ctl00_phG_PXTab1_t1_gridZip_lv0_edZipMax", "Zip Code+4 (Max.)", locator, null);
                ZipMaxLabel = new Label(ZipMax);
                ZipMax.DataField = "ZipMax";
                DataMemberName = "Zip";
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
                    Ok = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Cancel = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Ok1 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Cancel1 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    First = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Prev = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Next = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Last = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Ok2 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Cancel2 = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_PXTab1_t1_gridZip_lv0");
                    Upload = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_PXTab1_t1_gridZip_lv0");
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
        
        public class c_zip_importcsvsettings_frmimportcsvsettings : Container
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
            
            public c_zip_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings_edSepar" +
                        "ator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings_edNullV" +
                        "alue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings_edCodeP" +
                        "age", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings_edCultu" +
                        "res", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "Zip$ImportCSVSettings";
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
                    Ok = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_PXTab1_t1_gridZip_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_zip_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_zip_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edNul" +
                        "lValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edCul" +
                        "tures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edMod" +
                        "e", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "Zip$ImportXLSXSettings";
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
                    Ok = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                    Cancel = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_PXTab1_t1_gridZip_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                }
            }
        }
        
        public class c_zip_importcolumns_grdimportcolumn : Grid<c_zip_importcolumns_grdimportcolumn.c_grid_row, c_zip_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_zip_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "Zip$ImportColumns";
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
                    First = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_zip_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_zip_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_zip_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_zip_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Zip$ImportColumns";
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
                    First = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_PXTab1_t1_gridZip_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
        
        public class c_attributes : Container
        {
            
            public c_attributes(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = null;
            }
        }
    }
}
