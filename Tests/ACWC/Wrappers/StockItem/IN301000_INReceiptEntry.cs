using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
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
    
    
    public class IN301000_INReceiptEntry : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_receipt_form Receipt_form { get; } = new c_receipt_form("ctl00_phF_form", "receipt_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_currentdocument_form2 CurrentDocument_form2 { get; } = new c_currentdocument_form2("ctl00_phG_tab_t1_form2", "CurrentDocument_form2");
        protected c_currentdocument_formam1 CurrentDocument_formam1 { get; } = new c_currentdocument_formam1("ctl00_phG_tab_t2_formam1", "CurrentDocument_formam1");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "transactions_lv0");
        protected c_splits_grid2 Splits_grid2 { get; } = new c_splits_grid2("ctl00_phG_PanelLS_grid2", "splits_grid2");
        protected c_splits_lv0 Splits_lv0 { get; } = new c_splits_lv0("ctl00_phG_PanelLS_grid2_lv0", "splits_lv0");
        protected c_sitestatusfilter_formsitesstatus Sitestatusfilter_formsitesstatus { get; } = new c_sitestatusfilter_formsitesstatus("ctl00_phG_PanelAddSiteStatus_formSitesStatus", "sitestatusfilter_formSitesStatus");
        protected c_sitestatus_gripsitestatus Sitestatus_gripsitestatus { get; } = new c_sitestatus_gripsitestatus("ctl00_phG_PanelAddSiteStatus_gripSiteStatus", "siteStatus_gripSiteStatus");
        protected c_sitestatus_lv0 Sitestatus_lv0 { get; } = new c_sitestatus_lv0("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0", "siteStatus_lv0");
        protected c_lsintran_lotseropts_optform LSINTran_lotseropts_optform { get; } = new c_lsintran_lotseropts_optform("ctl00_phG_PanelLS_optform", "LSINTran_lotseropts_optform");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_transactions_importcsvsettings_frmimportcsvsettings Transactions_importcsvsettings_frmimportcsvsettings { get; } = new c_transactions_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings", "transactions$ImportCSVSettings_frmImportCSVSettings");
        protected c_transactions_importxlsxsettings_frmimportxlsxsettings Transactions_importxlsxsettings_frmimportxlsxsettings { get; } = new c_transactions_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "transactions$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_transactions_importcolumns_grdimportcolumn Transactions_importcolumns_grdimportcolumn { get; } = new c_transactions_importcolumns_grdimportcolumn("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn", "transactions$ImportColumns_grdImportColumn");
        protected c_transactions_importcolumns_lv0 Transactions_importcolumns_lv0 { get; } = new c_transactions_importcolumns_lv0("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0", "transactions$ImportColumns_lv0");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public IN301000_INReceiptEntry()
        {
            ScreenId = "IN301000";
            ScreenUrl = "/Pages/IN/IN301000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual IN301000_INReceiptEntry ReadOne(Gate gate, string RefNbr)
        {
            new BiObject<IN301000_INReceiptEntry>(gate).ReadOne(this, RefNbr);
            return this;
        }
        
        public virtual IN301000_INReceiptEntry ReadOne(string RefNbr)
        {
            return this.ReadOne(ApiConnection.Source, RefNbr);
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
        
        public virtual void BPEventsShow()
        {
            ToolBar.BPEventsShow.Click();
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
        
        public virtual void Release()
        {
            ToolBar.Release.Click();
        }
        
        public virtual void Release(bool status, string message = null)
        {
            ToolBar.Release.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Release.Click();
        }
        
        public virtual void Reports()
        {
            ToolBar.Reports.Click();
        }
        
        public virtual void INEdit()
        {
            ToolBar.INEdit.Click();
        }
        
        public virtual void INRegisterDetails()
        {
            ToolBar.INRegisterDetails.Click();
        }
        
        public virtual void INItemLabels()
        {
            ToolBar.INItemLabels.Click();
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
			public ToolBarButton BPEventsShow { get; }
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
			public ToolBarButton Release { get; }
			public ToolBarButton Reports { get; }
			public ToolBarButton INEdit { get; }
			public ToolBarButton INRegisterDetails { get; }
			public ToolBarButton INItemLabels { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                ActivityShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'ActivityShow\']", "Activities", locator, null);
                FilesMenuShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
                BPEventsShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'BPEventsShow\']", "Business Events", locator, null);
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
                Release = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Release\']", "Release", locator, null);
                Release.WaitAction = Wait.WaitForLongOperationToComplete;
                Reports = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                INEdit = new ToolBarButton("css=li[data-cmd=\'Report@INEdit\']", "Inventory Edit Details", locator, Reports);
                INRegisterDetails = new ToolBarButton("css=li[data-cmd=\'Report@INRegisterDetails\']", "Inventory Register Detailed", locator, Reports);
                INItemLabels = new ToolBarButton("css=li[data-cmd=\'Report@INItemLabels\']", "Inventory Item Labels", locator, Reports);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_receipt_form : Container
        {
            
			public Selector RefNbr { get; }
			public Label RefNbrLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public CheckBox Hold { get; }
			public Label HoldLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public DateSelector TranDate { get; }
			public Label TranDateLabel { get; }
			public Selector FinPeriodID { get; }
			public Label FinPeriodIDLabel { get; }
			public Selector TransferNbr { get; }
			public Label TransferNbrLabel { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Label ExtRefNbrLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public PXNumberEdit TotalQty { get; }
			public Label TotalQtyLabel { get; }
			public PXNumberEdit ControlQty { get; }
			public Label ControlQtyLabel { get; }
			public PXNumberEdit TotalCost { get; }
			public Label TotalCostLabel { get; }
			public PXNumberEdit ControlCost { get; }
			public Label ControlCostLabel { get; }
            
            public c_receipt_form(string locator, string name) : 
                    base(locator, name)
            {
                RefNbr = new Selector("ctl00_phF_form_t0_edRefNbr", "Reference Nbr.", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("B", "Balanced");
                Status.Items.Add("R", "Released");
                Hold = new CheckBox("ctl00_phF_form_t0_chkHold", "Hold", locator, null);
                HoldLabel = new Label(Hold);
                Hold.DataField = "Hold";
                BranchID = new Selector("ctl00_phF_form_t0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                TranDate = new DateSelector("ctl00_phF_form_t0_edTranDate", "Date", locator, null);
                TranDateLabel = new Label(TranDate);
                TranDate.DataField = "TranDate";
                FinPeriodID = new Selector("ctl00_phF_form_t0_edFinPeriodID", "Post Period", locator, null);
                FinPeriodIDLabel = new Label(FinPeriodID);
                FinPeriodID.DataField = "FinPeriodID";
                TransferNbr = new Selector("ctl00_phF_form_t0_edTransferNbr", "Transfer Nbr.", locator, null);
                TransferNbrLabel = new Label(TransferNbr);
                TransferNbr.DataField = "TransferNbr";
                ExtRefNbr = new PXTextEdit("ctl00_phF_form_t0_edExtRefNbr", "External Ref.", locator, null);
                ExtRefNbrLabel = new Label(ExtRefNbr);
                ExtRefNbr.DataField = "ExtRefNbr";
                TranDesc = new PXTextEdit("ctl00_phF_form_t0_edTranDesc", "Description", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                TotalQty = new PXNumberEdit("ctl00_phF_form_t0_edTotalQty", "Total Qty.", locator, null);
                TotalQtyLabel = new Label(TotalQty);
                TotalQty.DataField = "TotalQty";
                ControlQty = new PXNumberEdit("ctl00_phF_form_t0_edControlQty", "Control Qty.", locator, null);
                ControlQtyLabel = new Label(ControlQty);
                ControlQty.DataField = "ControlQty";
                TotalCost = new PXNumberEdit("ctl00_phF_form_t0_edTotalCost", "Total Cost", locator, null);
                TotalCostLabel = new Label(TotalCost);
                TotalCost.DataField = "TotalCost";
                ControlCost = new PXNumberEdit("ctl00_phF_form_t0_edControlCost", "Control Cost", locator, null);
                ControlCostLabel = new Label(ControlCost);
                ControlCost.DataField = "ControlCost";
                DataMemberName = "receipt";
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
        
        public class c_currentdocument_form2 : Container
        {
            
			public Selector BatchNbr { get; }
			public Label BatchNbrLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
            
            public c_currentdocument_form2(string locator, string name) : 
                    base(locator, name)
            {
                BatchNbr = new Selector("ctl00_phG_tab_t1_form2_edBatchNbr", "Batch Nbr.", locator, null);
                BatchNbrLabel = new Label(BatchNbr);
                BatchNbr.DataField = "BatchNbr";
                BranchID = new Selector("ctl00_phG_tab_t1_form2_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_currentdocument_formam1 : Container
        {
            
			public Selector AMBatNbr { get; }
			public Label AMBatNbrLabel { get; }
			public DropDown AMDocType { get; }
			public Label AMDocTypeLabel { get; }
            
            public c_currentdocument_formam1(string locator, string name) : 
                    base(locator, name)
            {
                AMBatNbr = new Selector("ctl00_phG_tab_t2_formam1_edAMBatNbr", "MFG Batch Nbr", locator, null);
                AMBatNbrLabel = new Label(AMBatNbr);
                AMBatNbr.DataField = "AMBatNbr";
                AMDocType = new DropDown("ctl00_phG_tab_t2_formam1_edAMDocType", "MFG Document Type", locator, null);
                AMDocTypeLabel = new Label(AMDocType);
                AMDocType.DataField = "AMDocType";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_transactions_grid : Grid<c_transactions_grid.c_grid_row, c_transactions_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            private Label _StatusBar = new Label("ctl00_phG_tab_t0_grid_ab_tlb_ul", "Status Bar", "ctl00_phG_tab_t0_grid", null);
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_transactions_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "transactions";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t0_grid_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual Label StatusBar
            {
                get
                {
                    return _StatusBar;
                }
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
            
            public virtual void Allocations()
            {
                ToolBar.Allocations.Click();
            }
            
            public virtual void AddItem()
            {
                ToolBar.AddItem.Click();
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
            
            public virtual void POReceiptNbrEdit()
            {
                Buttons.POReceiptNbrEdit.Click();
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
			public ToolBarButtonGrid Allocations { get; }
			public ToolBarButtonGrid AddItem { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Allocations = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div:textEqual(\"Allocations\") > div[data-type=\'b" +
                            "utton\']", "Allocations", locator, null);
                    AddItem = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdASI\']", "Add Item", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
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
                
			public Button POReceiptNbrEdit { get; }
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
                    POReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edPOReceiptNbr\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "POReceiptNbrEdit", "ctl00_phG_tab_t0_grid");
                    POReceiptNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
			public Selector BranchID { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public Selector LocationID { get; }
			public PXNumberEdit Qty { get; }
			public Selector UOM { get; }
			public PXNumberEdit UnitCost { get; }
			public PXNumberEdit TranCost { get; }
			public Selector LotSerialNbr { get; }
			public DateSelector ExpireDate { get; }
			public Selector ReasonCode { get; }
			public Selector ProjectID { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public PXTextEdit TranDesc { get; }
			public Selector POReceiptNbr { get; }
			public DropDown DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit Availability { get; }
                
                public c_grid_row(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    BranchID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    InventoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    UnitCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edUnitCost", "Unit Cost", grid.Locator, "UnitCost");
                    UnitCost.DataField = "UnitCost";
                    TranCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edTranCost", "Ext. Cost", grid.Locator, "TranCost");
                    TranCost.DataField = "TranCost";
                    LotSerialNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    ExpireDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    ReasonCode = new Selector("_ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", grid.Locator, "ReasonCode");
                    ReasonCode.DataField = "ReasonCode";
                    ProjectID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edCostCodeID", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    TranDesc = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    POReceiptNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPOReceiptNbr", "PO Receipt Nbr.", grid.Locator, "POReceiptNbr");
                    POReceiptNbr.DataField = "POReceiptNbr";
                    DocType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_ec", "Document Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("I", "Issue");
                    DocType.Items.Add("R", "Receipt");
                    DocType.Items.Add("T", "Transfer");
                    DocType.Items.Add("A", "Adjustment");
                    DocType.Items.Add("P", "Production");
                    DocType.Items.Add("D", "Disassembly");
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Line Number", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    Availability = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Availability", grid.Locator, "Availability");
                    Availability.DataField = "Availability";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter BranchID { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter UnitCost { get; }
				public PXNumberEditColumnFilter TranCost { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public SelectorColumnFilter ReasonCode { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter POReceiptNbr { get; }
				public DropDownColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter Availability { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    UnitCost = new PXNumberEditColumnFilter(grid.Row.UnitCost);
                    TranCost = new PXNumberEditColumnFilter(grid.Row.TranCost);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    ReasonCode = new SelectorColumnFilter(grid.Row.ReasonCode);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    POReceiptNbr = new SelectorColumnFilter(grid.Row.POReceiptNbr);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    Availability = new PXTextEditColumnFilter(grid.Row.Availability);
                }
            }
        }
        
        public class c_transactions_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit UnitCost { get; }
			public Label UnitCostLabel { get; }
			public PXNumberEdit TranCost { get; }
			public Label TranCostLabel { get; }
			public Selector LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector ReasonCode { get; }
			public Label ReasonCodeLabel { get; }
			public Selector POReceiptNbr { get; }
			public Label POReceiptNbrLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_transactions_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                ProjectID = new Selector("ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                SubItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                CostCodeID = new Selector("ctl00_phG_tab_t0_grid_lv0_edCostCodeID", "Cost Code", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                SiteID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                Qty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                UnitCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edUnitCost", "Unit Cost", locator, null);
                UnitCostLabel = new Label(UnitCost);
                UnitCost.DataField = "UnitCost";
                TranCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edTranCost", "Ext. Cost", locator, null);
                TranCostLabel = new Label(TranCost);
                TranCost.DataField = "TranCost";
                LotSerialNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                ExpireDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                TranDesc = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Description", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                ReasonCode = new Selector("ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", locator, null);
                ReasonCodeLabel = new Label(ReasonCode);
                ReasonCode.DataField = "ReasonCode";
                POReceiptNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edPOReceiptNbr", "PO Receipt Nbr.", locator, null);
                POReceiptNbrLabel = new Label(POReceiptNbr);
                POReceiptNbr.DataField = "POReceiptNbr";
                BranchID = new Selector("ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_lv0_ec", "Ec", locator, null);
                DataMemberName = "transactions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void POReceiptNbrEdit()
            {
                Buttons.POReceiptNbrEdit.Click();
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
                
			public Button InventoryIDEdit { get; }
			public Button POReceiptNbrEdit { get; }
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
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInventoryID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "InventoryIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    InventoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    POReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edPOReceiptNbr\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "POReceiptNbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    POReceiptNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c_splits_grid2 : Grid<c_splits_grid2.c_grid_row, c_splits_grid2.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_splits_grid2(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelLS_grid2");
                DataMemberName = "splits";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelLS_grid2_fe_gf", "FilterForm");
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
            
            public virtual void Generate()
            {
                Buttons.Generate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Generate { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Generate = new Button("ctl00_phG_PanelLS_optform_btnGenerate", "Generate", "ctl00_phG_PanelLS_grid2");
                    Ok = new Button("ctl00_phG_PanelLS_btnSave", "OK", "ctl00_phG_PanelLS_grid2");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector LocationID { get; }
			public Selector LotSerialNbr { get; }
			public PXNumberEdit Qty { get; }
			public Selector UOM { get; }
			public DateSelector ExpireDate { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SplitLineNbr { get; }
                
                public c_grid_row(c_splits_grid2 grid) : 
                        base(grid)
                {
                    InventoryID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edSubItemID2", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    LocationID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edLocationID2", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    LotSerialNbr = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edLotSerialNbr2", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    Qty = new PXNumberEdit("_ctl00_phG_PanelLS_grid2_lv0_edQty2", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    UOM = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edUOM2", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    ExpireDate = new DateSelector("_ctl00_phG_PanelLS_grid2_lv0_edExpireDate2", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    DocType = new PXTextEdit("ctl00_phG_PanelLS_grid2_ei", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_PanelLS_grid2_ei", "Ref. Number", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "Line Number", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SplitLineNbr = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "Split Line Number", grid.Locator, "SplitLineNbr");
                    SplitLineNbr.DataField = "SplitLineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter LocationID { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter UOM { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SplitLineNbr { get; }
                
                public c_grid_header(c_splits_grid2 grid) : 
                        base(grid)
                {
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SplitLineNbr = new PXNumberEditColumnFilter(grid.Row.SplitLineNbr);
                }
            }
        }
        
        public class c_splits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public Selector LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_splits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SubItemID = new Selector("ctl00_phG_PanelLS_grid2_lv0_edSubItemID2", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                LocationID = new Selector("ctl00_phG_PanelLS_grid2_lv0_edLocationID2", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                Qty = new PXNumberEdit("ctl00_phG_PanelLS_grid2_lv0_edQty2", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                UOM = new Selector("ctl00_phG_PanelLS_grid2_lv0_edUOM2", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                LotSerialNbr = new Selector("ctl00_phG_PanelLS_grid2_lv0_edLotSerialNbr2", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                ExpireDate = new DateSelector("ctl00_phG_PanelLS_grid2_lv0_edExpireDate2", "Expiration Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                Es = new Selector("ctl00_phG_PanelLS_grid2_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "splits";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Generate()
            {
                Buttons.Generate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Generate { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Generate = new Button("ctl00_phG_PanelLS_optform_btnGenerate", "Generate", "ctl00_phG_PanelLS_grid2_lv0");
                    Ok = new Button("ctl00_phG_PanelLS_btnSave", "OK", "ctl00_phG_PanelLS_grid2_lv0");
                }
            }
        }
        
        public class c_sitestatusfilter_formsitesstatus : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Inventory { get; }
			public Label InventoryLabel { get; }
			public PXTextEdit BarCode { get; }
			public Label BarCodeLabel { get; }
			public Selector ItemClass { get; }
			public Label ItemClassLabel { get; }
			public CheckBox OnlyAvailable { get; }
			public Label OnlyAvailableLabel { get; }
			public Selector SubItem { get; }
			public Label SubItemLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
            
            public c_sitestatusfilter_formsitesstatus(string locator, string name) : 
                    base(locator, name)
            {
                Inventory = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edInventory", "Inventory", locator, null);
                InventoryLabel = new Label(Inventory);
                Inventory.DataField = "Inventory";
                BarCode = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edBarCode", "Bar Code", locator, null);
                BarCodeLabel = new Label(BarCode);
                BarCode.DataField = "BarCode";
                ItemClass = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edItemClassID", "Item Class", locator, null);
                ItemClassLabel = new Label(ItemClass);
                ItemClass.DataField = "ItemClass";
                OnlyAvailable = new CheckBox("ctl00_phG_PanelAddSiteStatus_formSitesStatus_chkOnlyAvailable", "Only Available", locator, null);
                OnlyAvailableLabel = new Label(OnlyAvailable);
                OnlyAvailable.DataField = "OnlyAvailable";
                SubItem = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edSubItem", "Sub Item", locator, null);
                SubItemLabel = new Label(SubItem);
                SubItem.DataField = "SubItem";
                SiteID = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edLocationID", "Location ID", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                DataMemberName = "sitestatusfilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSiteStatus_PXButton5", "Add", "ctl00_phG_PanelAddSiteStatus_formSitesStatus");
                    AddClose = new Button("ctl00_phG_PanelAddSiteStatus_PXButton4", "Add & Close", "ctl00_phG_PanelAddSiteStatus_formSitesStatus");
                    Cancel = new Button("ctl00_phG_PanelAddSiteStatus_PXButton6", "Cancel", "ctl00_phG_PanelAddSiteStatus_formSitesStatus");
                }
            }
        }
        
        public class c_sitestatus_gripsitestatus : Grid<c_sitestatus_gripsitestatus.c_grid_row, c_sitestatus_gripsitestatus.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_sitestatus_gripsitestatus(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddSiteStatus_gripSiteStatus");
                DataMemberName = "siteStatus";
                Buttons = new PxButtonCollection();
                PredefinedFilter = new DropDown("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_fe_gf", "FilterForm");
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
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb div[data-cmd=\'AdjustColum" +
                            "ns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb div[data-cmd=\'ExportExcel" +
                            "\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb div[data-cmd=\'FilterShow\'" +
                            "]", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ab_tlb div[data-cmd=\'PageFirst\']" +
                            "", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSiteStatus_PXButton5", "Add", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus");
                    AddClose = new Button("ctl00_phG_PanelAddSiteStatus_PXButton4", "Add & Close", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus");
                    Cancel = new Button("ctl00_phG_PanelAddSiteStatus_PXButton6", "Cancel", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXNumberEdit QtySelected { get; }
			public Selector SiteID { get; }
			public PXTextEdit SiteCD { get; }
			public Selector LocationID { get; }
			public PXTextEdit LocationCD { get; }
			public Selector ItemClassID { get; }
			public InputLocalizable ItemClassDescription { get; }
			public PXTextEdit PriceClassID { get; }
			public PXTextEdit PriceClassDescription { get; }
			public Selector InventoryCD { get; }
			public Selector SubItemID { get; }
			public PXTextEdit SubItemCD { get; }
			public InputLocalizable Descr { get; }
			public Selector BaseUnit { get; }
			public PXNumberEdit QtyAvail { get; }
			public PXNumberEdit QtyOnHand { get; }
			public PXNumberEdit InventoryID { get; }
                
                public c_grid_row(c_sitestatus_gripsitestatus grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    QtySelected = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. Selected", grid.Locator, "QtySelected");
                    QtySelected.DataField = "QtySelected";
                    SiteID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    SiteCD = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "SiteCD", grid.Locator, "SiteCD");
                    SiteCD.DataField = "SiteCD";
                    LocationID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    LocationCD = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "LocationCD", grid.Locator, "LocationCD");
                    LocationCD.DataField = "LocationCD";
                    ItemClassID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_editemClass", "Item Class ID", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    ItemClassDescription = new InputLocalizable("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Item Class Description", grid.Locator, "ItemClassDescription");
                    ItemClassDescription.DataField = "ItemClassDescription";
                    PriceClassID = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_em", "Price Class ID", grid.Locator, "PriceClassID");
                    PriceClassID.DataField = "PriceClassID";
                    PriceClassDescription = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Price Class Description", grid.Locator, "PriceClassDescription");
                    PriceClassDescription.DataField = "PriceClassDescription";
                    InventoryCD = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Inventory ID", grid.Locator, "InventoryCD");
                    InventoryCD.DataField = "InventoryCD";
                    SubItemID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SubItemCD = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "SubItemCD", grid.Locator, "SubItemCD");
                    SubItemCD.DataField = "SubItemCD";
                    Descr = new InputLocalizable("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    BaseUnit = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Base Unit", grid.Locator, "BaseUnit");
                    BaseUnit.DataField = "BaseUnit";
                    QtyAvail = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. Available", grid.Locator, "QtyAvail");
                    QtyAvail.DataField = "QtyAvail";
                    QtyOnHand = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. On Hand", grid.Locator, "QtyOnHand");
                    QtyOnHand.DataField = "QtyOnHand";
                    InventoryID = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter QtySelected { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter SiteCD { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXTextEditColumnFilter LocationCD { get; }
				public SelectorColumnFilter ItemClassID { get; }
				public PXTextEditColumnFilter ItemClassDescription { get; }
				public PXTextEditColumnFilter PriceClassID { get; }
				public PXTextEditColumnFilter PriceClassDescription { get; }
				public SelectorColumnFilter InventoryCD { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter SubItemCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter BaseUnit { get; }
				public PXNumberEditColumnFilter QtyAvail { get; }
				public PXNumberEditColumnFilter QtyOnHand { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
                
                public c_grid_header(c_sitestatus_gripsitestatus grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    QtySelected = new PXNumberEditColumnFilter(grid.Row.QtySelected);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    SiteCD = new PXTextEditColumnFilter(grid.Row.SiteCD);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    LocationCD = new PXTextEditColumnFilter(grid.Row.LocationCD);
                    ItemClassID = new SelectorColumnFilter(grid.Row.ItemClassID);
                    ItemClassDescription = new PXTextEditColumnFilter(grid.Row.ItemClassDescription);
                    PriceClassID = new PXTextEditColumnFilter(grid.Row.PriceClassID);
                    PriceClassDescription = new PXTextEditColumnFilter(grid.Row.PriceClassDescription);
                    InventoryCD = new SelectorColumnFilter(grid.Row.InventoryCD);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SubItemCD = new PXTextEditColumnFilter(grid.Row.SubItemCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    BaseUnit = new SelectorColumnFilter(grid.Row.BaseUnit);
                    QtyAvail = new PXNumberEditColumnFilter(grid.Row.QtyAvail);
                    QtyOnHand = new PXNumberEditColumnFilter(grid.Row.QtyOnHand);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_sitestatus_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_sitestatus_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ItemClassID = new Selector("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_editemClass", "Item Class ID", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                Es = new Selector("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "siteStatus";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSiteStatus_PXButton5", "Add", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddSiteStatus_PXButton4", "Add & Close", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddSiteStatus_PXButton6", "Cancel", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                }
            }
        }
        
        public class c_lsintran_lotseropts_optform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit UnassignedQty { get; }
			public Label UnassignedQtyLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXTextEdit StartNumVal { get; }
			public Label StartNumValLabel { get; }
            
            public c_lsintran_lotseropts_optform(string locator, string name) : 
                    base(locator, name)
            {
                UnassignedQty = new PXNumberEdit("ctl00_phG_PanelLS_optform_edUnassignedQty", "Unassigned Qty.", locator, null);
                UnassignedQtyLabel = new Label(UnassignedQty);
                UnassignedQty.DataField = "UnassignedQty";
                Qty = new PXNumberEdit("ctl00_phG_PanelLS_optform_edQty", "Quantity to Generate", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                StartNumVal = new PXTextEdit("ctl00_phG_PanelLS_optform_edStartNumVal", "Start Lot/Serial Number", locator, null);
                StartNumValLabel = new Label(StartNumVal);
                StartNumVal.DataField = "StartNumVal";
                DataMemberName = "LSINTran_lotseropts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Generate()
            {
                Buttons.Generate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Generate { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Generate = new Button("ctl00_phG_PanelLS_optform_btnGenerate", "Generate", "ctl00_phG_PanelLS_optform");
                    Ok = new Button("ctl00_phG_PanelLS_btnSave", "OK", "ctl00_phG_PanelLS_optform");
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
        
        public class c_transactions_importcsvsettings_frmimportcsvsettings : Container
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
            
            public c_transactions_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
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
                DataMemberName = "transactions$ImportCSVSettings";
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
        
        public class c_transactions_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_transactions_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
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
                DataMemberName = "transactions$ImportXLSXSettings";
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
        
        public class c_transactions_importcolumns_grdimportcolumn : Grid<c_transactions_importcolumns_grdimportcolumn.c_grid_row, c_transactions_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_transactions_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "transactions$ImportColumns";
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
                
                public c_grid_row(c_transactions_importcolumns_grdimportcolumn grid) : 
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
                
                public c_grid_header(c_transactions_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_transactions_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_transactions_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "transactions$ImportColumns";
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
