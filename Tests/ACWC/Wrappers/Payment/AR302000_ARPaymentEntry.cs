using Api;
using Controls;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CheckBoxButton;
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
    
    
    public class AR302000_ARPaymentEntry : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        protected c_document_form Document_form { get; } = new c_document_form("ctl00_phF_form", "Document_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c__arpayment_currencyinfo__rf _ARPayment_CurrencyInfo__rf { get; } = new c__arpayment_currencyinfo__rf("ctl00_phF_form_t0_edCury_pnlRate_rf", "_ARPayment_CurrencyInfo__rf");
        protected c_currentdocument_form2 CurrentDocument_form2 { get; } = new c_currentdocument_form2("ctl00_phG_tab_t4_form2", "CurrentDocument_form2");
        protected c_adjustments_detgrid Adjustments_detgrid { get; } = new c_adjustments_detgrid("ctl00_phG_tab_t0_detgrid", "Adjustments_detgrid");
        protected c_adjustments_lv0 Adjustments_lv0 { get; } = new c_adjustments_lv0("ctl00_phG_tab_t0_detgrid_lv0", "Adjustments_lv0");
        protected c_adjustments_history_detgrid2 Adjustments_History_detgrid2 { get; } = new c_adjustments_history_detgrid2("ctl00_phG_tab_t1_detgrid2", "Adjustments_History_detgrid2");
        protected c_adjustments_history_lv0 Adjustments_History_lv0 { get; } = new c_adjustments_history_lv0("ctl00_phG_tab_t1_detgrid2_lv0", "Adjustments_History_lv0");
        protected c_soadjustments_detgrid3 SOAdjustments_detgrid3 { get; } = new c_soadjustments_detgrid3("ctl00_phG_tab_t2_detgrid3", "SOAdjustments_detgrid3");
        protected c_soadjustments_lv0 SOAdjustments_lv0 { get; } = new c_soadjustments_lv0("ctl00_phG_tab_t2_detgrid3_lv0", "SOAdjustments_lv0");
        protected c_paymentcharges_detgrid3 PaymentCharges_detgrid3 { get; } = new c_paymentcharges_detgrid3("ctl00_phG_tab_t7_detgrid3", "PaymentCharges_detgrid3");
        protected c_paymentcharges_lv0 PaymentCharges_lv0 { get; } = new c_paymentcharges_lv0("ctl00_phG_tab_t7_detgrid3_lv0", "PaymentCharges_lv0");
        protected c_loadopts_loform Loadopts_loform { get; } = new c_loadopts_loform("ctl00_phG_pnlLoadOpts_loform", "loadOpts_loform");
        protected c_voucher_voucherdetails Voucher_VoucherDetails { get; } = new c_voucher_voucherdetails("ctl00_phG_tab_t4_form2_VoucherDetails", "Voucher_VoucherDetails");
        protected c_ccproctran_grdccproctran Ccproctran_grdccproctran { get; } = new c_ccproctran_grdccproctran("ctl00_phG_tab_t6_grdCCProcTran", "ccProcTran_grdCCProcTran");
        protected c_ccproctran_lv0 Ccproctran_lv0 { get; } = new c_ccproctran_lv0("ctl00_phG_tab_t6_grdCCProcTran_lv0", "ccProcTran_lv0");
        protected c_approval_gridapproval Approval_gridApproval { get; } = new c_approval_gridapproval("ctl00_phG_tab_t5_gridApproval", "Approval_gridApproval");
        protected c_approval_lv0 Approval_lv0 { get; } = new c_approval_lv0("ctl00_phG_tab_t5_gridApproval_lv0", "Approval_lv0");
        protected c_ccpaymentinfo_frmccpaymentinfo Ccpaymentinfo_frmccpaymentinfo { get; } = new c_ccpaymentinfo_frmccpaymentinfo("ctl00_phDS_pnlRecordCCPayment_frmCCPaymentInfo", "ccPaymentInfo_frmCCPaymentInfo");
        protected c_ccpaymentinfo_frmccpaymentinfo1 Ccpaymentinfo_frmccpaymentinfo1 { get; } = new c_ccpaymentinfo_frmccpaymentinfo1("ctl00_phDS_pnlCaptureCCOnly_frmCCPaymentInfo1", "ccPaymentInfo_frmCCPaymentInfo1");
        protected c_reasonapproverejectparams_pxformviewpanelreason ReasonApproveRejectParams_PXFormViewPanelReason { get; } = new c_reasonapproverejectparams_pxformviewpanelreason("ctl00_phG_panelReason_PXFormViewPanelReason", "ReasonApproveRejectParams_PXFormViewPanelReason");
        protected c_compliancedocuments_grdcompliancedocuments ComplianceDocuments_grdComplianceDocuments { get; } = new c_compliancedocuments_grdcompliancedocuments("ctl00_phG_tab_t8_grdComplianceDocuments", "ComplianceDocuments_grdComplianceDocuments");
        protected c_compliancedocuments_lv0 ComplianceDocuments_lv0 { get; } = new c_compliancedocuments_lv0("ctl00_phG_tab_t8_grdComplianceDocuments_lv0", "ComplianceDocuments_lv0");
        protected c_fsadjustments_detgridfs FSAdjustments_detgridFS { get; } = new c_fsadjustments_detgridfs("ctl00_phG_tab_t3_detgridFS", "FSAdjustments_detgridFS");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public AR302000_ARPaymentEntry()
        {
            ScreenId = "AR302000";
            ScreenUrl = "/Pages/AR/AR302000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AR302000_ARPaymentEntry ReadOne(Gate gate, string DocType, string RefNbr)
        {
            new BiObject<AR302000_ARPaymentEntry>(gate).ReadOne(this, DocType, RefNbr);
            return this;
        }
        
        public virtual AR302000_ARPaymentEntry ReadOne(string DocType, string RefNbr)
        {
            return this.ReadOne(ApiConnection.Source, DocType, RefNbr);
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
        
        public virtual void VoidCheck()
        {
            ToolBar.VoidCheck.Click();
        }
        
        public virtual void VoidCheck(bool status, string message = null)
        {
            ToolBar.VoidCheck.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.VoidCheck.Click();
        }
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void CaptureCCPayment()
        {
            ToolBar.CaptureCCPayment.Click();
        }
        
        public virtual void AuthorizeCCPayment()
        {
            ToolBar.AuthorizeCCPayment.Click();
        }
        
        public virtual void VoidCCPayment()
        {
            ToolBar.VoidCCPayment.Click();
        }
        
        public virtual void CreditCCPayment()
        {
            ToolBar.CreditCCPayment.Click();
        }
        
        public virtual void RecordCCPayment()
        {
            ToolBar.RecordCCPayment.Click();
        }
        
        public virtual void CaptureOnlyCCPayment()
        {
            ToolBar.CaptureOnlyCCPayment.Click();
        }
        
        public virtual void ValidateCCPayment()
        {
            ToolBar.ValidateCCPayment.Click();
        }
        
        public virtual void Approve()
        {
            ToolBar.Approve.Click();
        }
        
        public virtual void Reject()
        {
            ToolBar.Reject.Click();
        }
        
        public virtual void Inquiries()
        {
            ToolBar.Inquiries.Click();
        }
        
        public virtual void CustomerDetails()
        {
            ToolBar.CustomerDetails.Click();
        }
        
        public virtual void Reports()
        {
            ToolBar.Reports.Click();
        }
        
        public virtual void ArEditDetailed()
        {
            ToolBar.ArEditDetailed.Click();
        }
        
        public virtual void ArRegisterDetailed()
        {
            ToolBar.ArRegisterDetailed.Click();
        }
        
        public virtual void ViewSODocumentToApply()
        {
            ToolBar.ViewSODocumentToApply.Click();
        }
        
        public virtual void RegisterBCAuthTran()
        {
            ToolBar.RegisterBCAuthTran.Click();
        }
        
        public virtual void RegisterBCAuthTran(bool status, string message = null)
        {
            ToolBar.RegisterBCAuthTran.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.RegisterBCAuthTran.Click();
        }
        
        public virtual void VoidCCPaymentForReAuthorization()
        {
            ToolBar.VoidCCPaymentForReAuthorization.Click();
        }
        
        public virtual void VoidCCPaymentForReAuthorization(bool status, string message = null)
        {
            ToolBar.VoidCCPaymentForReAuthorization.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.VoidCCPaymentForReAuthorization.Click();
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
			public ToolBarButton VoidCheck { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton CaptureCCPayment { get; }
			public ToolBarButton AuthorizeCCPayment { get; }
			public ToolBarButton VoidCCPayment { get; }
			public ToolBarButton CreditCCPayment { get; }
			public ToolBarButton RecordCCPayment { get; }
			public ToolBarButton CaptureOnlyCCPayment { get; }
			public ToolBarButton ValidateCCPayment { get; }
			public ToolBarButton Approve { get; }
			public ToolBarButton Reject { get; }
			public ToolBarButton Inquiries { get; }
			public ToolBarButton CustomerDetails { get; }
			public ToolBarButton Reports { get; }
			public ToolBarButton ArEditDetailed { get; }
			public ToolBarButton ArRegisterDetailed { get; }
			public ToolBarButton ViewSODocumentToApply { get; }
			public ToolBarButton RegisterBCAuthTran { get; }
			public ToolBarButton VoidCCPaymentForReAuthorization { get; }
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
                VoidCheck = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'VoidCheck\']", "Void", locator, null);
                VoidCheck.WaitAction = Wait.WaitForLongOperationToComplete;
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                CaptureCCPayment = new ToolBarButton("css=li[data-cmd=\'Action@CaptureCCPayment\']", "Capture CC Payment", locator, Actions);
                AuthorizeCCPayment = new ToolBarButton("css=li[data-cmd=\'Action@AuthorizeCCPayment\']", "Authorize CC Payment", locator, Actions);
                VoidCCPayment = new ToolBarButton("css=li[data-cmd=\'Action@VoidCCPayment\']", "Void CC Payment", locator, Actions);
                CreditCCPayment = new ToolBarButton("css=li[data-cmd=\'Action@CreditCCPayment\']", "Refund CC Payment", locator, Actions);
                RecordCCPayment = new ToolBarButton("css=li[data-cmd=\'Action@RecordCCPayment\']", "Record CC Payment", locator, Actions);
                CaptureOnlyCCPayment = new ToolBarButton("css=li[data-cmd=\'Action@CaptureOnlyCCPayment\']", "Extern. Authorized CC Payment", locator, Actions);
                ValidateCCPayment = new ToolBarButton("css=li[data-cmd=\'Action@ValidateCCPayment\']", "Validate CC Payment", locator, Actions);
                Approve = new ToolBarButton("css=li[data-cmd=\'Action@Approve\']", "Approve", locator, Actions);
                Reject = new ToolBarButton("css=li[data-cmd=\'Action@Reject\']", "Reject", locator, Actions);
                Inquiries = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Inquiries\") > div[data-type=\'drop\']", "Inquiries", locator, null);
                CustomerDetails = new ToolBarButton("css=li[data-cmd=\'Inquiry@Customer Details\']", "Customer Details", locator, Inquiries);
                Reports = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                ArEditDetailed = new ToolBarButton("css=li[data-cmd=\'Report@AR Edit Detailed\']", "AR Edit Detailed", locator, Reports);
                ArRegisterDetailed = new ToolBarButton("css=li[data-cmd=\'Report@AR Register Detailed\']", "AR Register Detailed", locator, Reports);
                ViewSODocumentToApply = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewSODocumentToApply\']", "View Order", locator, null);
                RegisterBCAuthTran = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'RegisterBCAuthTran\']", "Register BC Auth Tran", locator, null);
                RegisterBCAuthTran.WaitAction = Wait.WaitForLongOperationToComplete;
                VoidCCPaymentForReAuthorization = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'VoidCCPaymentForReAuthorization\']", "Void CC Payment for Reauthorization", locator, null);
                VoidCCPaymentForReAuthorization.WaitAction = Wait.WaitForLongOperationToComplete;
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_document_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown DocType { get; }
			public Label DocTypeLabel { get; }
			public Selector RefNbr { get; }
			public Label RefNbrLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public CheckBox Hold { get; }
			public Label HoldLabel { get; }
			public DateSelector AdjDate { get; }
			public Label AdjDateLabel { get; }
			public Selector AdjFinPeriodID { get; }
			public Label AdjFinPeriodIDLabel { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Label ExtRefNbrLabel { get; }
			public Selector CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public Selector CustomerLocationID { get; }
			public Label CustomerLocationIDLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public Selector RefTranExtNbr { get; }
			public Label RefTranExtNbrLabel { get; }
			public Selector PMInstanceID { get; }
			public Label PMInstanceIDLabel { get; }
			public Selector ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
			public CheckBox NewCard { get; }
			public Label NewCardLabel { get; }
			public CheckBox SaveCard { get; }
			public Label SaveCardLabel { get; }
			public PXTextEdit CCPaymentStateDescr { get; }
			public Label CCPaymentStateDescrLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public DateSelector DepositAfter { get; }
			public Label DepositAfterLabel { get; }
			public CheckBox ChkServiceManagement { get; }
			public Label ChkServiceManagementLabel { get; }
			public PXTextEdit DocDesc { get; }
			public Label DocDescLabel { get; }
			public PXNumberEdit CuryOrigDocAmt { get; }
			public Label CuryOrigDocAmtLabel { get; }
			public PXNumberEdit CuryApplAmt { get; }
			public Label CuryApplAmtLabel { get; }
			public PXNumberEdit CurySOApplAmt { get; }
			public Label CurySOApplAmtLabel { get; }
			public PXNumberEdit CuryUnappliedBal { get; }
			public Label CuryUnappliedBalLabel { get; }
			public PXNumberEdit CuryInitDocBal { get; }
			public Label CuryInitDocBalLabel { get; }
			public PXNumberEdit CuryWOAmt { get; }
			public Label CuryWOAmtLabel { get; }
			public PXNumberEdit CuryChargeAmt { get; }
			public Label CuryChargeAmtLabel { get; }
			public PXNumberEdit CuryConsolidateChargeTotal { get; }
			public Label CuryConsolidateChargeTotalLabel { get; }
			public CheckBox IsCCPayment { get; }
			public Label IsCCPaymentLabel { get; }
			public CheckBox IsRUTROTPayment { get; }
			public Label IsRUTROTPaymentLabel { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
            
            public c_document_form(string locator, string name) : 
                    base(locator, name)
            {
                DocType = new DropDown("ctl00_phF_form_t0_edDocType", "Type", locator, null);
                DocTypeLabel = new Label(DocType);
                DocType.DataField = "DocType";
                DocType.Items.Add("PMT", "Payment");
                DocType.Items.Add("CRM", "Credit Memo");
                DocType.Items.Add("PPM", "Prepayment");
                DocType.Items.Add("REF", "Customer Refund");
                DocType.Items.Add("VRF", "Voided Refund");
                DocType.Items.Add("RPM", "Voided Payment");
                DocType.Items.Add("SMB", "Balance WO");
                RefNbr = new Selector("ctl00_phF_form_t0_edRefNbr", "Reference Nbr.", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("R", "Credit Hold");
                Status.Items.Add("W", "Pending Processing");
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("B", "Balanced");
                Status.Items.Add("V", "Voided");
                Status.Items.Add("S", "Scheduled");
                Status.Items.Add("N", "Open");
                Status.Items.Add("C", "Closed");
                Status.Items.Add("P", "Pending Print");
                Status.Items.Add("E", "Pending Email");
                Status.Items.Add("Z", "Reserved");
                Status.Items.Add("D", "Pending Approval");
                Status.Items.Add("J", "Rejected");
                Status.Items.Add("L", "Canceled");
                Hold = new CheckBox("ctl00_phF_form_t0_chkHold", "Hold", locator, null);
                HoldLabel = new Label(Hold);
                Hold.DataField = "Hold";
                AdjDate = new DateSelector("ctl00_phF_form_t0_edAdjDate", "Application Date", locator, null);
                AdjDateLabel = new Label(AdjDate);
                AdjDate.DataField = "AdjDate";
                AdjFinPeriodID = new Selector("ctl00_phF_form_t0_edAdjFinPeriodID", "Application Period", locator, null);
                AdjFinPeriodIDLabel = new Label(AdjFinPeriodID);
                AdjFinPeriodID.DataField = "AdjFinPeriodID";
                ExtRefNbr = new PXTextEdit("ctl00_phF_form_t0_edExtRefNbr", "Payment Ref.", locator, null);
                ExtRefNbrLabel = new Label(ExtRefNbr);
                ExtRefNbr.DataField = "ExtRefNbr";
                CustomerID = new Selector("ctl00_phF_form_t0_edCustomerID", "Customer", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                CustomerLocationID = new Selector("ctl00_phF_form_t0_edCustomerLocationID", "Location", locator, null);
                CustomerLocationIDLabel = new Label(CustomerLocationID);
                CustomerLocationID.DataField = "CustomerLocationID";
                PaymentMethodID = new Selector("ctl00_phF_form_t0_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                RefTranExtNbr = new Selector("ctl00_phF_form_t0_PXSelector2", "Orig. Transaction", locator, null);
                RefTranExtNbrLabel = new Label(RefTranExtNbr);
                RefTranExtNbr.DataField = "RefTranExtNbr";
                PMInstanceID = new Selector("ctl00_phF_form_t0_edPMInstanceID", "Card/Account No", locator, null);
                PMInstanceIDLabel = new Label(PMInstanceID);
                PMInstanceID.DataField = "PMInstanceID";
                ProcessingCenterID = new Selector("ctl00_phF_form_t0_edProcessingCenterID", "Proc. Center ID", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                NewCard = new CheckBox("ctl00_phF_form_t0_chkNewCard", "New Card", locator, null);
                NewCardLabel = new Label(NewCard);
                NewCard.DataField = "NewCard";
                SaveCard = new CheckBox("ctl00_phF_form_t0_chkSaveCard", "Save Card", locator, null);
                SaveCardLabel = new Label(SaveCard);
                SaveCard.DataField = "SaveCard";
                CCPaymentStateDescr = new PXTextEdit("ctl00_phF_form_t0_edCCPaymentStateDescr", "Processing Status", locator, null);
                CCPaymentStateDescrLabel = new Label(CCPaymentStateDescr);
                CCPaymentStateDescr.DataField = "CCPaymentStateDescr";
                CashAccountID = new Selector("ctl00_phF_form_t0_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                CuryID = new Selector("ctl00_phF_form_t0_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_t0_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                DepositAfter = new DateSelector("ctl00_phF_form_t0_edDepositAfter", "Deposit After", locator, null);
                DepositAfterLabel = new Label(DepositAfter);
                DepositAfter.DataField = "DepositAfter";
                ChkServiceManagement = new CheckBox("ctl00_phF_form_t0_chkServiceManagement", "chkServiceManagement", locator, null);
                ChkServiceManagementLabel = new Label(ChkServiceManagement);
                ChkServiceManagement.DataField = "ChkServiceManagement";
                DocDesc = new PXTextEdit("ctl00_phF_form_t0_edDocDesc", "Description", locator, null);
                DocDescLabel = new Label(DocDesc);
                DocDesc.DataField = "DocDesc";
                CuryOrigDocAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigDocAmt", "Payment Amount", locator, null);
                CuryOrigDocAmtLabel = new Label(CuryOrigDocAmt);
                CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                CuryApplAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryApplAmt", "Applied to Documents", locator, null);
                CuryApplAmtLabel = new Label(CuryApplAmt);
                CuryApplAmt.DataField = "CuryApplAmt";
                CurySOApplAmt = new PXNumberEdit("ctl00_phF_form_t0_edCurySOApplAmt", "Applied to Orders", locator, null);
                CurySOApplAmtLabel = new Label(CurySOApplAmt);
                CurySOApplAmt.DataField = "CurySOApplAmt";
                CuryUnappliedBal = new PXNumberEdit("ctl00_phF_form_t0_edCuryUnappliedBal", "Available Balance", locator, null);
                CuryUnappliedBalLabel = new Label(CuryUnappliedBal);
                CuryUnappliedBal.DataField = "CuryUnappliedBal";
                CuryInitDocBal = new PXNumberEdit("ctl00_phF_form_t0_edCuryInitDocBal", "Available Balance", locator, null);
                CuryInitDocBalLabel = new Label(CuryInitDocBal);
                CuryInitDocBal.DataField = "CuryInitDocBal";
                CuryWOAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryWOAmt", "Write-Off Amount", locator, null);
                CuryWOAmtLabel = new Label(CuryWOAmt);
                CuryWOAmt.DataField = "CuryWOAmt";
                CuryChargeAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryChargeAmt", "Finance Charges", locator, null);
                CuryChargeAmtLabel = new Label(CuryChargeAmt);
                CuryChargeAmt.DataField = "CuryChargeAmt";
                CuryConsolidateChargeTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryConsolidateChargeTotal", "Deducted Charges", locator, null);
                CuryConsolidateChargeTotalLabel = new Label(CuryConsolidateChargeTotal);
                CuryConsolidateChargeTotal.DataField = "CuryConsolidateChargeTotal";
                IsCCPayment = new CheckBox("ctl00_phF_form_t0_chkIsCCPayment", "IsCCPayment", locator, null);
                IsCCPaymentLabel = new Label(IsCCPayment);
                IsCCPayment.DataField = "IsCCPayment";
                IsRUTROTPayment = new CheckBox("ctl00_phF_form_t0_chkIsRUTROT", "ROT or RUT payment", locator, null);
                IsRUTROTPaymentLabel = new Label(IsRUTROTPayment);
                IsRUTROTPayment.DataField = "IsRUTROTPayment";
                LblCount_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "Document";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Viewbase()
            {
                Buttons.Viewbase.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void SetPaymentAmounttoAppliedtoDocumentsamount()
            {
                Buttons.SetPaymentAmounttoAppliedtoDocumentsamount.Click();
            }
            
            public virtual void CustomerIDEdit()
            {
                Buttons.CustomerIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
			public Button SetPaymentAmounttoAppliedtoDocumentsamount { get; }
			public Button CustomerIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phF_form_t0_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_t0_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                    SetPaymentAmounttoAppliedtoDocumentsamount = new Button("ctl00_phF_form_t0_btnAdjustDocAmt", "Set Payment Amount to Applied to Documents amount", "ctl00_phF_form");
                    CustomerIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edCustomerID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "CustomerIDEdit", "ctl00_phF_form");
                    CustomerIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c__arpayment_currencyinfo__rf : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public DateSelector CuryEffDate { get; }
			public Label CuryEffDateLabel { get; }
			public PXTextEdit DisplayCuryID { get; }
			public Label DisplayCuryIDLabel { get; }
			public PXNumberEdit SampleCuryRate { get; }
			public Label SampleCuryRateLabel { get; }
			public PXTextEdit BaseCuryID { get; }
			public Label BaseCuryIDLabel { get; }
			public PXTextEdit BaseCuryID2 { get; }
			public Label BaseCuryID2Label { get; }
			public PXNumberEdit SampleRecipRate { get; }
			public Label SampleRecipRateLabel { get; }
			public PXTextEdit DisplayCuryID2 { get; }
			public Label DisplayCuryID2Label { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
            
            public c__arpayment_currencyinfo__rf(string locator, string name) : 
                    base(locator, name)
            {
                CuryRateTypeID = new Selector("ctl00_phF_form_t0_edCury_pnlRate_rf_edRateType", "Curr. Rate Type ID", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                CuryEffDate = new DateSelector("ctl00_phF_form_t0_edCury_pnlRate_rf_edEffDate", "Effective Date", locator, null);
                CuryEffDateLabel = new Label(CuryEffDate);
                CuryEffDate.DataField = "CuryEffDate";
                DisplayCuryID = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCury", "Display Cury ID", locator, null);
                DisplayCuryIDLabel = new Label(DisplayCuryID);
                DisplayCuryID.DataField = "DisplayCuryID";
                SampleCuryRate = new PXNumberEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCuryRate", "Sample Cury Rate", locator, null);
                SampleCuryRateLabel = new Label(SampleCuryRate);
                SampleCuryRate.DataField = "SampleCuryRate";
                BaseCuryID = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtBaseCury", "Base Cury ID", locator, null);
                BaseCuryIDLabel = new Label(BaseCuryID);
                BaseCuryID.DataField = "BaseCuryID";
                BaseCuryID2 = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtBaseCury2", "Base Cury ID 2", locator, null);
                BaseCuryID2Label = new Label(BaseCuryID2);
                BaseCuryID2.DataField = "BaseCuryID";
                SampleRecipRate = new PXNumberEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCuryRate2", "Sample Recip Rate", locator, null);
                SampleRecipRateLabel = new Label(SampleRecipRate);
                SampleRecipRate.DataField = "SampleRecipRate";
                DisplayCuryID2 = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCury2", "Display Cury ID 2", locator, null);
                DisplayCuryID2Label = new Label(DisplayCuryID2);
                DisplayCuryID2.DataField = "DisplayCuryID";
                LblCount_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "_ARPayment_CurrencyInfo_";
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
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form_t0_edCury_pnlRate_rf");
                }
            }
        }
        
        public class c_currentdocument_form2 : Container
        {
            
			public Selector BatchNbr { get; }
			public Label BatchNbrLabel { get; }
			public PXNumberEdit DisplayCuryInitDocBal { get; }
			public Label DisplayCuryInitDocBalLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector ARAccountID { get; }
			public Label ARAccountIDLabel { get; }
			public Selector ARSubID { get; }
			public Label ARSubIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public PXTextEdit OrigRefNbr { get; }
			public Label OrigRefNbrLabel { get; }
			public DateSelector DocDate { get; }
			public Label DocDateLabel { get; }
			public Selector FinPeriodID { get; }
			public Label FinPeriodIDLabel { get; }
			public CheckBox Cleared { get; }
			public Label ClearedLabel { get; }
			public DateSelector ClearDate { get; }
			public Label ClearDateLabel { get; }
			public CheckBox DepositAsBatch { get; }
			public Label DepositAsBatchLabel { get; }
			public CheckBox Deposited { get; }
			public Label DepositedLabel { get; }
			public DateSelector DepositDate { get; }
			public Label DepositDateLabel { get; }
			public PXTextEdit DepositNbr { get; }
			public Label DepositNbrLabel { get; }
            
            public c_currentdocument_form2(string locator, string name) : 
                    base(locator, name)
            {
                BatchNbr = new Selector("ctl00_phG_tab_t4_form2_edBatchNbr", "Batch Nbr.", locator, null);
                BatchNbrLabel = new Label(BatchNbr);
                BatchNbr.DataField = "BatchNbr";
                DisplayCuryInitDocBal = new PXNumberEdit("ctl00_phG_tab_t4_form2_edDisplayCuryInitDocBal", "Migrated Balance", locator, null);
                DisplayCuryInitDocBalLabel = new Label(DisplayCuryInitDocBal);
                DisplayCuryInitDocBal.DataField = "DisplayCuryInitDocBal";
                BranchID = new Selector("ctl00_phG_tab_t4_form2_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                ARAccountID = new Selector("ctl00_phG_tab_t4_form2_edARAccountID", "AR Account", locator, null);
                ARAccountIDLabel = new Label(ARAccountID);
                ARAccountID.DataField = "ARAccountID";
                ARSubID = new Selector("ctl00_phG_tab_t4_form2_edARSubID", "AR Subaccount", locator, null);
                ARSubIDLabel = new Label(ARSubID);
                ARSubID.DataField = "ARSubID";
                ProjectID = new Selector("ctl00_phG_tab_t4_form2_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                TaskID = new Selector("ctl00_phG_tab_t4_form2_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                OrigRefNbr = new PXTextEdit("ctl00_phG_tab_t4_form2_edOrigRefNbr", "Original Document", locator, null);
                OrigRefNbrLabel = new Label(OrigRefNbr);
                OrigRefNbr.DataField = "OrigRefNbr";
                DocDate = new DateSelector("ctl00_phG_tab_t4_form2_edDocDate", "Payment Date", locator, null);
                DocDateLabel = new Label(DocDate);
                DocDate.DataField = "DocDate";
                FinPeriodID = new Selector("ctl00_phG_tab_t4_form2_edFinPeriodID", "Payment Period", locator, null);
                FinPeriodIDLabel = new Label(FinPeriodID);
                FinPeriodID.DataField = "FinPeriodID";
                Cleared = new CheckBox("ctl00_phG_tab_t4_form2_edCleared", "Cleared", locator, null);
                ClearedLabel = new Label(Cleared);
                Cleared.DataField = "Cleared";
                ClearDate = new DateSelector("ctl00_phG_tab_t4_form2_edClearDate", "Clear Date", locator, null);
                ClearDateLabel = new Label(ClearDate);
                ClearDate.DataField = "ClearDate";
                DepositAsBatch = new CheckBox("ctl00_phG_tab_t4_form2_chkDepositAsBatch", "Batch Deposit", locator, null);
                DepositAsBatchLabel = new Label(DepositAsBatch);
                DepositAsBatch.DataField = "DepositAsBatch";
                Deposited = new CheckBox("ctl00_phG_tab_t4_form2_chkDeposited", "Deposited", locator, null);
                DepositedLabel = new Label(Deposited);
                Deposited.DataField = "Deposited";
                DepositDate = new DateSelector("ctl00_phG_tab_t4_form2_edDepositDate", "Batch Deposit Date", locator, null);
                DepositDateLabel = new Label(DepositDate);
                DepositDate.DataField = "DepositDate";
                DepositNbr = new PXTextEdit("ctl00_phG_tab_t4_form2_edDepositNbr", "Batch Deposit Nbr.", locator, null);
                DepositNbrLabel = new Label(DepositNbr);
                DepositNbr.DataField = "DepositNbr";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_adjustments_detgrid : Grid<c_adjustments_detgrid.c_grid_row, c_adjustments_detgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_adjustments_detgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_detgrid");
                DataMemberName = "Adjustments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_detgrid_fe_gf", "FilterForm");
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
            
            public virtual void LoadInvoices()
            {
                ToolBar.LoadInvoices.Click();
            }
            
            public virtual void AutoApply()
            {
                ToolBar.AutoApply.Click();
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
			public ToolBarButtonGrid LoadInvoices { get; }
			public ToolBarButtonGrid AutoApply { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    LoadInvoices = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'LoadInvoices\']", "Load Documents", locator, null);
                    AutoApply = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'AutoApply\']", "Auto Apply", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_detgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public Selector AdjdBranchID { get; }
			public DropDown AdjdDocType { get; }
			public Selector AdjdRefNbr { get; }
			public Selector AdjdLineNbr { get; }
			public Selector ARTran__InventoryID { get; }
			public Selector ARTran__ProjectID { get; }
			public Selector ARTran__TaskID { get; }
			public Selector ARTran__CostCodeID { get; }
			public Selector ARTran__AccountID { get; }
			public Selector AdjdCustomerID { get; }
			public PXNumberEdit CuryAdjgAmt { get; }
			public PXNumberEdit CuryAdjgPPDAmt { get; }
			public PXNumberEdit CuryAdjgWOAmt { get; }
			public Selector WriteOffReasonCode { get; }
			public DateSelector AdjdDocDate { get; }
			public DateSelector ARRegisterAlias__DueDate { get; }
			public DateSelector ARInvoice__DiscDate { get; }
			public PXNumberEdit AdjdCuryRate { get; }
			public PXNumberEdit CuryDocBal { get; }
			public PXNumberEdit CuryDiscBal { get; }
			public PXTextEdit ARRegisterAlias__DocDesc { get; }
			public PXTextEdit AdjdCuryID { get; }
			public PXTextEdit AdjdFinPeriodID { get; }
			public PXTextEdit ARInvoice__InvoiceNbr { get; }
			public CheckBox HasExpiredComplianceDocuments { get; }
			public PXTextEdit AdjgDocType { get; }
			public PXTextEdit AdjgRefNbr { get; }
			public PXNumberEdit AdjNbr { get; }
                
                public c_grid_row(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_tab_t0_detgrid", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    AdjdBranchID = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_es", "Branch", grid.Locator, "AdjdBranchID");
                    AdjdBranchID.DataField = "AdjdBranchID";
                    AdjdDocType = new DropDown("_ctl00_phG_tab_t0_detgrid_lv0_edAdjdDocType", "Doc. Type", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    AdjdDocType.Items.Add("INV", "Invoice");
                    AdjdDocType.Items.Add("DRM", "Debit Memo");
                    AdjdDocType.Items.Add("CRM", "Credit Memo");
                    AdjdDocType.Items.Add("FCH", "Overdue Charge");
                    AdjdRefNbr = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_edAdjdRefNbr", "Reference Nbr.", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                    AdjdLineNbr = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_edAdjdLineNbr", "Line Nbr.", grid.Locator, "AdjdLineNbr");
                    AdjdLineNbr.DataField = "AdjdLineNbr";
                    ARTran__InventoryID = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_es", "Inventory ID", grid.Locator, "ARTran__InventoryID");
                    ARTran__InventoryID.DataField = "ARTran__InventoryID";
                    ARTran__ProjectID = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_es", "Project", grid.Locator, "ARTran__ProjectID");
                    ARTran__ProjectID.DataField = "ARTran__ProjectID";
                    ARTran__TaskID = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_es", "Project Task", grid.Locator, "ARTran__TaskID");
                    ARTran__TaskID.DataField = "ARTran__TaskID";
                    ARTran__CostCodeID = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_es", "Cost Code", grid.Locator, "ARTran__CostCodeID");
                    ARTran__CostCodeID.DataField = "ARTran__CostCodeID";
                    ARTran__AccountID = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_es", "Account", grid.Locator, "ARTran__AccountID");
                    ARTran__AccountID.DataField = "ARTran__AccountID";
                    AdjdCustomerID = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_es", "Customer", grid.Locator, "AdjdCustomerID");
                    AdjdCustomerID.DataField = "AdjdCustomerID";
                    CuryAdjgAmt = new PXNumberEdit("_ctl00_phG_tab_t0_detgrid_lv0_edCuryAdjgAmt", "Amount Paid", grid.Locator, "CuryAdjgAmt");
                    CuryAdjgAmt.DataField = "CuryAdjgAmt";
                    CuryAdjgPPDAmt = new PXNumberEdit("_ctl00_phG_tab_t0_detgrid_lv0_edCuryAdjgPPDAmt", "Cash Discount Taken", grid.Locator, "CuryAdjgPPDAmt");
                    CuryAdjgPPDAmt.DataField = "CuryAdjgPPDAmt";
                    CuryAdjgWOAmt = new PXNumberEdit("_ctl00_phG_tab_t0_detgrid_lv0_edCuryAdjgWOAmt", "Write-Off Amount", grid.Locator, "CuryAdjgWOAmt");
                    CuryAdjgWOAmt.DataField = "CuryAdjgWOAmt";
                    WriteOffReasonCode = new Selector("_ctl00_phG_tab_t0_detgrid_lv0_PXSelector1", "Write-Off Reason Code", grid.Locator, "WriteOffReasonCode");
                    WriteOffReasonCode.DataField = "WriteOffReasonCode";
                    AdjdDocDate = new DateSelector("_ctl00_phG_tab_t0_detgrid_lv0_edAdjdDocDate", "Date", grid.Locator, "AdjdDocDate");
                    AdjdDocDate.DataField = "AdjdDocDate";
                    ARRegisterAlias__DueDate = new DateSelector("_ctl00_phG_tab_t0_detgrid_lv0_edARRegisterAlias__DueDate", "Due Date", grid.Locator, "ARRegisterAlias__DueDate");
                    ARRegisterAlias__DueDate.DataField = "ARRegisterAlias__DueDate";
                    ARInvoice__DiscDate = new DateSelector("_ctl00_phG_tab_t0_detgrid_lv0_edARInvoice__DiscDate", "Cash Discount Date", grid.Locator, "ARInvoice__DiscDate");
                    ARInvoice__DiscDate.DataField = "ARInvoice__DiscDate";
                    AdjdCuryRate = new PXNumberEdit("_ctl00_phG_tab_t0_detgrid_lv0_edAdjdCuryRate", "Cross Rate", grid.Locator, "AdjdCuryRate");
                    AdjdCuryRate.DataField = "AdjdCuryRate";
                    CuryDocBal = new PXNumberEdit("_ctl00_phG_tab_t0_detgrid_lv0_edCuryDocBal", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    CuryDiscBal = new PXNumberEdit("_ctl00_phG_tab_t0_detgrid_lv0_edCuryDiscBal", "Cash Discount Balance", grid.Locator, "CuryDiscBal");
                    CuryDiscBal.DataField = "CuryDiscBal";
                    ARRegisterAlias__DocDesc = new PXTextEdit("_ctl00_phG_tab_t0_detgrid_lv0_edARRegisterAlias__DocDesc1", "Description", grid.Locator, "ARRegisterAlias__DocDesc");
                    ARRegisterAlias__DocDesc.DataField = "ARRegisterAlias__DocDesc";
                    AdjdCuryID = new PXTextEdit("_ctl00_phG_tab_t0_detgrid_lv0_edAdjdCuryID", "Currency", grid.Locator, "AdjdCuryID");
                    AdjdCuryID.DataField = "AdjdCuryID";
                    AdjdFinPeriodID = new PXTextEdit("_ctl00_phG_tab_t0_detgrid_lv0_edAdjdFinPeriodID", "Post Period", grid.Locator, "AdjdFinPeriodID");
                    AdjdFinPeriodID.DataField = "AdjdFinPeriodID";
                    ARInvoice__InvoiceNbr = new PXTextEdit("_ctl00_phG_tab_t0_detgrid_lv0_edARInvoice__InvoiceNbr", "Customer Order Nbr.", grid.Locator, "ARInvoice__InvoiceNbr");
                    ARInvoice__InvoiceNbr.DataField = "ARInvoice__InvoiceNbr";
                    HasExpiredComplianceDocuments = new CheckBox("ctl00_phG_tab_t0_detgrid", "Has Expired Compliance Documents", grid.Locator, "HasExpiredComplianceDocuments");
                    HasExpiredComplianceDocuments.DataField = "HasExpiredComplianceDocuments";
                    AdjgDocType = new PXTextEdit("ctl00_phG_tab_t0_detgrid_ei", "AdjgDocType", grid.Locator, "AdjgDocType");
                    AdjgDocType.DataField = "AdjgDocType";
                    AdjgRefNbr = new PXTextEdit("ctl00_phG_tab_t0_detgrid_ei", "AdjgRefNbr", grid.Locator, "AdjgRefNbr");
                    AdjgRefNbr.DataField = "AdjgRefNbr";
                    AdjNbr = new PXNumberEdit("ctl00_phG_tab_t0_detgrid_en", "Adjustment Nbr.", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter AdjdBranchID { get; }
				public DropDownColumnFilter AdjdDocType { get; }
				public SelectorColumnFilter AdjdRefNbr { get; }
				public SelectorColumnFilter AdjdLineNbr { get; }
				public SelectorColumnFilter ARTran__InventoryID { get; }
				public SelectorColumnFilter ARTran__ProjectID { get; }
				public SelectorColumnFilter ARTran__TaskID { get; }
				public SelectorColumnFilter ARTran__CostCodeID { get; }
				public SelectorColumnFilter ARTran__AccountID { get; }
				public SelectorColumnFilter AdjdCustomerID { get; }
				public PXNumberEditColumnFilter CuryAdjgAmt { get; }
				public PXNumberEditColumnFilter CuryAdjgPPDAmt { get; }
				public PXNumberEditColumnFilter CuryAdjgWOAmt { get; }
				public SelectorColumnFilter WriteOffReasonCode { get; }
				public DateSelectorColumnFilter AdjdDocDate { get; }
				public DateSelectorColumnFilter ARRegisterAlias__DueDate { get; }
				public DateSelectorColumnFilter ARInvoice__DiscDate { get; }
				public PXNumberEditColumnFilter AdjdCuryRate { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public PXNumberEditColumnFilter CuryDiscBal { get; }
				public PXTextEditColumnFilter ARRegisterAlias__DocDesc { get; }
				public PXTextEditColumnFilter AdjdCuryID { get; }
				public PXTextEditColumnFilter AdjdFinPeriodID { get; }
				public PXTextEditColumnFilter ARInvoice__InvoiceNbr { get; }
				public CheckBoxColumnFilter HasExpiredComplianceDocuments { get; }
				public PXTextEditColumnFilter AdjgDocType { get; }
				public PXTextEditColumnFilter AdjgRefNbr { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
                
                public c_grid_header(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    AdjdBranchID = new SelectorColumnFilter(grid.Row.AdjdBranchID);
                    AdjdDocType = new DropDownColumnFilter(grid.Row.AdjdDocType);
                    AdjdRefNbr = new SelectorColumnFilter(grid.Row.AdjdRefNbr);
                    AdjdLineNbr = new SelectorColumnFilter(grid.Row.AdjdLineNbr);
                    ARTran__InventoryID = new SelectorColumnFilter(grid.Row.ARTran__InventoryID);
                    ARTran__ProjectID = new SelectorColumnFilter(grid.Row.ARTran__ProjectID);
                    ARTran__TaskID = new SelectorColumnFilter(grid.Row.ARTran__TaskID);
                    ARTran__CostCodeID = new SelectorColumnFilter(grid.Row.ARTran__CostCodeID);
                    ARTran__AccountID = new SelectorColumnFilter(grid.Row.ARTran__AccountID);
                    AdjdCustomerID = new SelectorColumnFilter(grid.Row.AdjdCustomerID);
                    CuryAdjgAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgAmt);
                    CuryAdjgPPDAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgPPDAmt);
                    CuryAdjgWOAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgWOAmt);
                    WriteOffReasonCode = new SelectorColumnFilter(grid.Row.WriteOffReasonCode);
                    AdjdDocDate = new DateSelectorColumnFilter(grid.Row.AdjdDocDate);
                    ARRegisterAlias__DueDate = new DateSelectorColumnFilter(grid.Row.ARRegisterAlias__DueDate);
                    ARInvoice__DiscDate = new DateSelectorColumnFilter(grid.Row.ARInvoice__DiscDate);
                    AdjdCuryRate = new PXNumberEditColumnFilter(grid.Row.AdjdCuryRate);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    CuryDiscBal = new PXNumberEditColumnFilter(grid.Row.CuryDiscBal);
                    ARRegisterAlias__DocDesc = new PXTextEditColumnFilter(grid.Row.ARRegisterAlias__DocDesc);
                    AdjdCuryID = new PXTextEditColumnFilter(grid.Row.AdjdCuryID);
                    AdjdFinPeriodID = new PXTextEditColumnFilter(grid.Row.AdjdFinPeriodID);
                    ARInvoice__InvoiceNbr = new PXTextEditColumnFilter(grid.Row.ARInvoice__InvoiceNbr);
                    HasExpiredComplianceDocuments = new CheckBoxColumnFilter(grid.Row.HasExpiredComplianceDocuments);
                    AdjgDocType = new PXTextEditColumnFilter(grid.Row.AdjgDocType);
                    AdjgRefNbr = new PXTextEditColumnFilter(grid.Row.AdjgRefNbr);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                }
            }
        }
        
        public class c_adjustments_lv0 : Container
        {
            
			public DropDown AdjdDocType { get; }
			public Label AdjdDocTypeLabel { get; }
			public Selector AdjdRefNbr { get; }
			public Label AdjdRefNbrLabel { get; }
			public Selector AdjdLineNbr { get; }
			public Label AdjdLineNbrLabel { get; }
			public PXNumberEdit CuryAdjgAmt { get; }
			public Label CuryAdjgAmtLabel { get; }
			public PXNumberEdit CuryAdjgPPDAmt { get; }
			public Label CuryAdjgPPDAmtLabel { get; }
			public PXNumberEdit CuryAdjgWOAmt { get; }
			public Label CuryAdjgWOAmtLabel { get; }
			public DateSelector AdjdDocDate { get; }
			public Label AdjdDocDateLabel { get; }
			public DateSelector ARRegisterAlias__DueDate { get; }
			public Label ARRegisterAlias__DueDateLabel { get; }
			public DateSelector ARInvoice__DiscDate { get; }
			public Label ARInvoice__DiscDateLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public PXNumberEdit CuryDiscBal { get; }
			public Label CuryDiscBalLabel { get; }
			public PXTextEdit AdjdCuryID { get; }
			public Label AdjdCuryIDLabel { get; }
			public Selector WriteOffReasonCode { get; }
			public Label WriteOffReasonCodeLabel { get; }
			public PXTextEdit ARInvoice__InvoiceNbr { get; }
			public Label ARInvoice__InvoiceNbrLabel { get; }
			public PXTextEdit AdjdFinPeriodID { get; }
			public Label AdjdFinPeriodIDLabel { get; }
			public PXNumberEdit AdjdCuryRate { get; }
			public Label AdjdCuryRateLabel { get; }
			public PXTextEdit ARRegisterAlias__DocDesc { get; }
			public Label ARRegisterAlias__DocDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_adjustments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AdjdDocType = new DropDown("ctl00_phG_tab_t0_detgrid_lv0_edAdjdDocType", "Doc. Type", locator, null);
                AdjdDocTypeLabel = new Label(AdjdDocType);
                AdjdDocType.DataField = "AdjdDocType";
                AdjdDocType.Items.Add("INV", "Invoice");
                AdjdDocType.Items.Add("DRM", "Debit Memo");
                AdjdDocType.Items.Add("CRM", "Credit Memo");
                AdjdDocType.Items.Add("FCH", "Overdue Charge");
                AdjdRefNbr = new Selector("ctl00_phG_tab_t0_detgrid_lv0_edAdjdRefNbr", "Reference Nbr.", locator, null);
                AdjdRefNbrLabel = new Label(AdjdRefNbr);
                AdjdRefNbr.DataField = "AdjdRefNbr";
                AdjdLineNbr = new Selector("ctl00_phG_tab_t0_detgrid_lv0_edAdjdLineNbr", "Line Nbr.", locator, null);
                AdjdLineNbrLabel = new Label(AdjdLineNbr);
                AdjdLineNbr.DataField = "AdjdLineNbr";
                CuryAdjgAmt = new PXNumberEdit("ctl00_phG_tab_t0_detgrid_lv0_edCuryAdjgAmt", "Amount Paid", locator, null);
                CuryAdjgAmtLabel = new Label(CuryAdjgAmt);
                CuryAdjgAmt.DataField = "CuryAdjgAmt";
                CuryAdjgPPDAmt = new PXNumberEdit("ctl00_phG_tab_t0_detgrid_lv0_edCuryAdjgPPDAmt", "Cash Discount Taken", locator, null);
                CuryAdjgPPDAmtLabel = new Label(CuryAdjgPPDAmt);
                CuryAdjgPPDAmt.DataField = "CuryAdjgPPDAmt";
                CuryAdjgWOAmt = new PXNumberEdit("ctl00_phG_tab_t0_detgrid_lv0_edCuryAdjgWOAmt", "Write-Off Amount", locator, null);
                CuryAdjgWOAmtLabel = new Label(CuryAdjgWOAmt);
                CuryAdjgWOAmt.DataField = "CuryAdjgWOAmt";
                AdjdDocDate = new DateSelector("ctl00_phG_tab_t0_detgrid_lv0_edAdjdDocDate", "Date", locator, null);
                AdjdDocDateLabel = new Label(AdjdDocDate);
                AdjdDocDate.DataField = "AdjdDocDate";
                ARRegisterAlias__DueDate = new DateSelector("ctl00_phG_tab_t0_detgrid_lv0_edARRegisterAlias__DueDate", "Due Date", locator, null);
                ARRegisterAlias__DueDateLabel = new Label(ARRegisterAlias__DueDate);
                ARRegisterAlias__DueDate.DataField = "ARRegisterAlias__DueDate";
                ARInvoice__DiscDate = new DateSelector("ctl00_phG_tab_t0_detgrid_lv0_edARInvoice__DiscDate", "Cash Discount Date", locator, null);
                ARInvoice__DiscDateLabel = new Label(ARInvoice__DiscDate);
                ARInvoice__DiscDate.DataField = "ARInvoice__DiscDate";
                CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t0_detgrid_lv0_edCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                CuryDiscBal = new PXNumberEdit("ctl00_phG_tab_t0_detgrid_lv0_edCuryDiscBal", "Cash Discount Balance", locator, null);
                CuryDiscBalLabel = new Label(CuryDiscBal);
                CuryDiscBal.DataField = "CuryDiscBal";
                AdjdCuryID = new PXTextEdit("ctl00_phG_tab_t0_detgrid_lv0_edAdjdCuryID", "Currency", locator, null);
                AdjdCuryIDLabel = new Label(AdjdCuryID);
                AdjdCuryID.DataField = "AdjdCuryID";
                WriteOffReasonCode = new Selector("ctl00_phG_tab_t0_detgrid_lv0_PXSelector1", "Write-Off Reason Code", locator, null);
                WriteOffReasonCodeLabel = new Label(WriteOffReasonCode);
                WriteOffReasonCode.DataField = "WriteOffReasonCode";
                ARInvoice__InvoiceNbr = new PXTextEdit("ctl00_phG_tab_t0_detgrid_lv0_edARInvoice__InvoiceNbr", "Customer Order Nbr.", locator, null);
                ARInvoice__InvoiceNbrLabel = new Label(ARInvoice__InvoiceNbr);
                ARInvoice__InvoiceNbr.DataField = "ARInvoice__InvoiceNbr";
                AdjdFinPeriodID = new PXTextEdit("ctl00_phG_tab_t0_detgrid_lv0_edAdjdFinPeriodID", "Post Period", locator, null);
                AdjdFinPeriodIDLabel = new Label(AdjdFinPeriodID);
                AdjdFinPeriodID.DataField = "AdjdFinPeriodID";
                AdjdCuryRate = new PXNumberEdit("ctl00_phG_tab_t0_detgrid_lv0_edAdjdCuryRate", "Cross Rate", locator, null);
                AdjdCuryRateLabel = new Label(AdjdCuryRate);
                AdjdCuryRate.DataField = "AdjdCuryRate";
                ARRegisterAlias__DocDesc = new PXTextEdit("ctl00_phG_tab_t0_detgrid_lv0_edARRegisterAlias__DocDesc1", "Description", locator, null);
                ARRegisterAlias__DocDescLabel = new Label(ARRegisterAlias__DocDesc);
                ARRegisterAlias__DocDesc.DataField = "ARRegisterAlias__DocDesc";
                Es = new Selector("ctl00_phG_tab_t0_detgrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Adjustments";
            }
        }
        
        public class c_adjustments_history_detgrid2 : Grid<c_adjustments_history_detgrid2.c_grid_row, c_adjustments_history_detgrid2.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_adjustments_history_detgrid2(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_detgrid2");
                DataMemberName = "Adjustments_History";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_detgrid2_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void ReverseApplication()
            {
                ToolBar.ReverseApplication.Click();
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
			public ToolBarButtonGrid ReverseApplication { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    ReverseApplication = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_at_tlb div[data-cmd=\'ReverseApplication\']", "Reverse Application", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_detgrid2_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector AdjdBranchID { get; }
			public Selector AdjBatchNbr { get; }
			public DropDown DisplayDocType { get; }
			public PXTextEdit DisplayRefNbr { get; }
			public Selector AdjdLineNbr { get; }
			public Selector ARTran__InventoryID { get; }
			public Selector ARTran__ProjectID { get; }
			public Selector ARTran__TaskID { get; }
			public Selector ARTran__CostCodeID { get; }
			public Selector ARTran__AccountID { get; }
			public PXTextEdit DisplayCustomerID { get; }
			public PXNumberEdit DisplayCuryAmt { get; }
			public PXNumberEdit DisplayCuryPPDAmt { get; }
			public PXNumberEdit DisplayCuryWOAmt { get; }
			public PXTextEdit AdjgFinPeriodID { get; }
			public DateSelector DisplayDocDate { get; }
			public DateSelector ARInvoice__DueDate { get; }
			public DateSelector ARInvoice__DiscDate { get; }
			public PXNumberEdit CuryDocBal { get; }
			public PXNumberEdit CuryDiscBal { get; }
			public PXTextEdit DisplayDocDesc { get; }
			public Selector DisplayCuryID { get; }
			public PXTextEdit AdjdFinPeriodID { get; }
			public PXTextEdit ARInvoice__InvoiceNbr { get; }
			public CheckBox PendingPPD { get; }
			public Selector PPDCrMemoRefNbr { get; }
			public PXTextEdit TaxInvoiceNbr { get; }
			public CheckBox HasExpiredComplianceDocuments { get; }
			public PXTextEdit AdjgDocType { get; }
			public PXTextEdit AdjgRefNbr { get; }
			public DropDown AdjdDocType { get; }
			public Selector AdjdRefNbr { get; }
			public PXNumberEdit AdjNbr { get; }
                
                public c_grid_row(c_adjustments_history_detgrid2 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    AdjdBranchID = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Branch", grid.Locator, "AdjdBranchID");
                    AdjdBranchID.DataField = "AdjdBranchID";
                    AdjBatchNbr = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Batch Number", grid.Locator, "AdjBatchNbr");
                    AdjBatchNbr.DataField = "AdjBatchNbr";
                    DisplayDocType = new DropDown("_ctl00_phG_tab_t1_detgrid2_lv0_ec", "Doc. Type", grid.Locator, "DisplayDocType");
                    DisplayDocType.DataField = "DisplayDocType";
                    DisplayDocType.Items.Add("INV", "Invoice");
                    DisplayDocType.Items.Add("DRM", "Debit Memo");
                    DisplayDocType.Items.Add("CRM", "Credit Memo");
                    DisplayDocType.Items.Add("PMT", "Payment");
                    DisplayDocType.Items.Add("RPM", "Voided Payment");
                    DisplayDocType.Items.Add("PPM", "Prepayment");
                    DisplayDocType.Items.Add("REF", "Customer Refund");
                    DisplayDocType.Items.Add("VRF", "Voided Refund");
                    DisplayDocType.Items.Add("FCH", "Overdue Charge");
                    DisplayDocType.Items.Add("SMB", "Balance WO");
                    DisplayDocType.Items.Add("SMC", "Credit WO");
                    DisplayDocType.Items.Add("CSL", "Cash Sale");
                    DisplayDocType.Items.Add("RCS", "Cash Return");
                    DisplayRefNbr = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_em", "Reference Nbr.", grid.Locator, "DisplayRefNbr");
                    DisplayRefNbr.DataField = "DisplayRefNbr";
                    AdjdLineNbr = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Line Nbr.", grid.Locator, "AdjdLineNbr");
                    AdjdLineNbr.DataField = "AdjdLineNbr";
                    ARTran__InventoryID = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Inventory ID", grid.Locator, "ARTran__InventoryID");
                    ARTran__InventoryID.DataField = "ARTran__InventoryID";
                    ARTran__ProjectID = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Project", grid.Locator, "ARTran__ProjectID");
                    ARTran__ProjectID.DataField = "ARTran__ProjectID";
                    ARTran__TaskID = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Project Task", grid.Locator, "ARTran__TaskID");
                    ARTran__TaskID.DataField = "ARTran__TaskID";
                    ARTran__CostCodeID = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Cost Code", grid.Locator, "ARTran__CostCodeID");
                    ARTran__CostCodeID.DataField = "ARTran__CostCodeID";
                    ARTran__AccountID = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Account", grid.Locator, "ARTran__AccountID");
                    ARTran__AccountID.DataField = "ARTran__AccountID";
                    DisplayCustomerID = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_ei", "Customer", grid.Locator, "DisplayCustomerID");
                    DisplayCustomerID.DataField = "DisplayCustomerID";
                    DisplayCuryAmt = new PXNumberEdit("ctl00_phG_tab_t1_detgrid2_en", "Amount Paid", grid.Locator, "DisplayCuryAmt");
                    DisplayCuryAmt.DataField = "DisplayCuryAmt";
                    DisplayCuryPPDAmt = new PXNumberEdit("ctl00_phG_tab_t1_detgrid2_en", "Cash Discount Taken", grid.Locator, "DisplayCuryPPDAmt");
                    DisplayCuryPPDAmt.DataField = "DisplayCuryPPDAmt";
                    DisplayCuryWOAmt = new PXNumberEdit("ctl00_phG_tab_t1_detgrid2_en", "Write-Off Amount", grid.Locator, "DisplayCuryWOAmt");
                    DisplayCuryWOAmt.DataField = "DisplayCuryWOAmt";
                    AdjgFinPeriodID = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_em", "Application Period", grid.Locator, "AdjgFinPeriodID");
                    AdjgFinPeriodID.DataField = "AdjgFinPeriodID";
                    DisplayDocDate = new DateSelector("_ctl00_phG_tab_t1_detgrid2_lv0_ed17", "Date", grid.Locator, "DisplayDocDate");
                    DisplayDocDate.DataField = "DisplayDocDate";
                    ARInvoice__DueDate = new DateSelector("_ctl00_phG_tab_t1_detgrid2_lv0_ed18", "Due Date", grid.Locator, "ARInvoice__DueDate");
                    ARInvoice__DueDate.DataField = "ARInvoice__DueDate";
                    ARInvoice__DiscDate = new DateSelector("_ctl00_phG_tab_t1_detgrid2_lv0_ed19", "Cash Discount Date", grid.Locator, "ARInvoice__DiscDate");
                    ARInvoice__DiscDate.DataField = "ARInvoice__DiscDate";
                    CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t1_detgrid2_en", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    CuryDiscBal = new PXNumberEdit("ctl00_phG_tab_t1_detgrid2_en", "Cash Discount Balance", grid.Locator, "CuryDiscBal");
                    CuryDiscBal.DataField = "CuryDiscBal";
                    DisplayDocDesc = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_ei", "Description", grid.Locator, "DisplayDocDesc");
                    DisplayDocDesc.DataField = "DisplayDocDesc";
                    DisplayCuryID = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Currency", grid.Locator, "DisplayCuryID");
                    DisplayCuryID.DataField = "DisplayCuryID";
                    AdjdFinPeriodID = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_em", "Post Period", grid.Locator, "AdjdFinPeriodID");
                    AdjdFinPeriodID.DataField = "AdjdFinPeriodID";
                    ARInvoice__InvoiceNbr = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_ei", "Customer Order Nbr.", grid.Locator, "ARInvoice__InvoiceNbr");
                    ARInvoice__InvoiceNbr.DataField = "ARInvoice__InvoiceNbr";
                    PendingPPD = new CheckBox("ctl00_phG_tab_t1_detgrid2", "VAT Adjustment", grid.Locator, "PendingPPD");
                    PendingPPD.DataField = "PendingPPD";
                    PPDCrMemoRefNbr = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "VAT Credit Memo", grid.Locator, "PPDCrMemoRefNbr");
                    PPDCrMemoRefNbr.DataField = "PPDCrMemoRefNbr";
                    TaxInvoiceNbr = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_ei", "Tax Doc. Nbr", grid.Locator, "TaxInvoiceNbr");
                    TaxInvoiceNbr.DataField = "TaxInvoiceNbr";
                    HasExpiredComplianceDocuments = new CheckBox("ctl00_phG_tab_t1_detgrid2", "Has Expired Compliance Documents", grid.Locator, "HasExpiredComplianceDocuments");
                    HasExpiredComplianceDocuments.DataField = "HasExpiredComplianceDocuments";
                    AdjgDocType = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_ei", "AdjgDocType", grid.Locator, "AdjgDocType");
                    AdjgDocType.DataField = "AdjgDocType";
                    AdjgRefNbr = new PXTextEdit("ctl00_phG_tab_t1_detgrid2_ei", "AdjgRefNbr", grid.Locator, "AdjgRefNbr");
                    AdjgRefNbr.DataField = "AdjgRefNbr";
                    AdjdDocType = new DropDown("_ctl00_phG_tab_t1_detgrid2_lv0_ec", "Doc. Type", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    AdjdDocType.Items.Add("INV", "Invoice");
                    AdjdDocType.Items.Add("DRM", "Debit Memo");
                    AdjdDocType.Items.Add("CRM", "Credit Memo");
                    AdjdDocType.Items.Add("FCH", "Overdue Charge");
                    AdjdRefNbr = new Selector("_ctl00_phG_tab_t1_detgrid2_lv0_es", "Reference Nbr.", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                    AdjNbr = new PXNumberEdit("ctl00_phG_tab_t1_detgrid2_en", "Adjustment Nbr.", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter AdjdBranchID { get; }
				public SelectorColumnFilter AdjBatchNbr { get; }
				public DropDownColumnFilter DisplayDocType { get; }
				public PXTextEditColumnFilter DisplayRefNbr { get; }
				public SelectorColumnFilter AdjdLineNbr { get; }
				public SelectorColumnFilter ARTran__InventoryID { get; }
				public SelectorColumnFilter ARTran__ProjectID { get; }
				public SelectorColumnFilter ARTran__TaskID { get; }
				public SelectorColumnFilter ARTran__CostCodeID { get; }
				public SelectorColumnFilter ARTran__AccountID { get; }
				public PXTextEditColumnFilter DisplayCustomerID { get; }
				public PXNumberEditColumnFilter DisplayCuryAmt { get; }
				public PXNumberEditColumnFilter DisplayCuryPPDAmt { get; }
				public PXNumberEditColumnFilter DisplayCuryWOAmt { get; }
				public PXTextEditColumnFilter AdjgFinPeriodID { get; }
				public DateSelectorColumnFilter DisplayDocDate { get; }
				public DateSelectorColumnFilter ARInvoice__DueDate { get; }
				public DateSelectorColumnFilter ARInvoice__DiscDate { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public PXNumberEditColumnFilter CuryDiscBal { get; }
				public PXTextEditColumnFilter DisplayDocDesc { get; }
				public SelectorColumnFilter DisplayCuryID { get; }
				public PXTextEditColumnFilter AdjdFinPeriodID { get; }
				public PXTextEditColumnFilter ARInvoice__InvoiceNbr { get; }
				public CheckBoxColumnFilter PendingPPD { get; }
				public SelectorColumnFilter PPDCrMemoRefNbr { get; }
				public PXTextEditColumnFilter TaxInvoiceNbr { get; }
				public CheckBoxColumnFilter HasExpiredComplianceDocuments { get; }
				public PXTextEditColumnFilter AdjgDocType { get; }
				public PXTextEditColumnFilter AdjgRefNbr { get; }
				public DropDownColumnFilter AdjdDocType { get; }
				public SelectorColumnFilter AdjdRefNbr { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
                
                public c_grid_header(c_adjustments_history_detgrid2 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    AdjdBranchID = new SelectorColumnFilter(grid.Row.AdjdBranchID);
                    AdjBatchNbr = new SelectorColumnFilter(grid.Row.AdjBatchNbr);
                    DisplayDocType = new DropDownColumnFilter(grid.Row.DisplayDocType);
                    DisplayRefNbr = new PXTextEditColumnFilter(grid.Row.DisplayRefNbr);
                    AdjdLineNbr = new SelectorColumnFilter(grid.Row.AdjdLineNbr);
                    ARTran__InventoryID = new SelectorColumnFilter(grid.Row.ARTran__InventoryID);
                    ARTran__ProjectID = new SelectorColumnFilter(grid.Row.ARTran__ProjectID);
                    ARTran__TaskID = new SelectorColumnFilter(grid.Row.ARTran__TaskID);
                    ARTran__CostCodeID = new SelectorColumnFilter(grid.Row.ARTran__CostCodeID);
                    ARTran__AccountID = new SelectorColumnFilter(grid.Row.ARTran__AccountID);
                    DisplayCustomerID = new PXTextEditColumnFilter(grid.Row.DisplayCustomerID);
                    DisplayCuryAmt = new PXNumberEditColumnFilter(grid.Row.DisplayCuryAmt);
                    DisplayCuryPPDAmt = new PXNumberEditColumnFilter(grid.Row.DisplayCuryPPDAmt);
                    DisplayCuryWOAmt = new PXNumberEditColumnFilter(grid.Row.DisplayCuryWOAmt);
                    AdjgFinPeriodID = new PXTextEditColumnFilter(grid.Row.AdjgFinPeriodID);
                    DisplayDocDate = new DateSelectorColumnFilter(grid.Row.DisplayDocDate);
                    ARInvoice__DueDate = new DateSelectorColumnFilter(grid.Row.ARInvoice__DueDate);
                    ARInvoice__DiscDate = new DateSelectorColumnFilter(grid.Row.ARInvoice__DiscDate);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    CuryDiscBal = new PXNumberEditColumnFilter(grid.Row.CuryDiscBal);
                    DisplayDocDesc = new PXTextEditColumnFilter(grid.Row.DisplayDocDesc);
                    DisplayCuryID = new SelectorColumnFilter(grid.Row.DisplayCuryID);
                    AdjdFinPeriodID = new PXTextEditColumnFilter(grid.Row.AdjdFinPeriodID);
                    ARInvoice__InvoiceNbr = new PXTextEditColumnFilter(grid.Row.ARInvoice__InvoiceNbr);
                    PendingPPD = new CheckBoxColumnFilter(grid.Row.PendingPPD);
                    PPDCrMemoRefNbr = new SelectorColumnFilter(grid.Row.PPDCrMemoRefNbr);
                    TaxInvoiceNbr = new PXTextEditColumnFilter(grid.Row.TaxInvoiceNbr);
                    HasExpiredComplianceDocuments = new CheckBoxColumnFilter(grid.Row.HasExpiredComplianceDocuments);
                    AdjgDocType = new PXTextEditColumnFilter(grid.Row.AdjgDocType);
                    AdjgRefNbr = new PXTextEditColumnFilter(grid.Row.AdjgRefNbr);
                    AdjdDocType = new DropDownColumnFilter(grid.Row.AdjdDocType);
                    AdjdRefNbr = new SelectorColumnFilter(grid.Row.AdjdRefNbr);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                }
            }
        }
        
        public class c_adjustments_history_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_adjustments_history_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t1_detgrid2_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t1_detgrid2_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t1_detgrid2_lv0_ec", "Ec", locator, null);
                DataMemberName = "Adjustments_History";
            }
        }
        
        public class c_soadjustments_detgrid3 : Grid<c_soadjustments_detgrid3.c_grid_row, c_soadjustments_detgrid3.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_soadjustments_detgrid3(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_detgrid3");
                DataMemberName = "SOAdjustments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_detgrid3_fe_gf", "FilterForm");
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
            
            public virtual void LoadOrders()
            {
                ToolBar.LoadOrders.Click();
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
			public ToolBarButtonGrid LoadOrders { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    LoadOrders = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_at_tlb div[data-cmd=\'LoadOrders\']", "Load Documents", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_detgrid3_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector AdjdOrderType { get; }
			public Selector AdjdOrderNbr { get; }
			public DropDown SOOrder__Status { get; }
			public PXNumberEdit CuryAdjgAmt { get; }
			public PXNumberEdit CuryAdjgBilledAmt { get; }
			public DateSelector AdjdOrderDate { get; }
			public DateSelector SOOrder__DueDate { get; }
			public DateSelector SOOrder__DiscDate { get; }
			public PXNumberEdit CuryDocBal { get; }
			public PXTextEdit SOOrder__OrderDesc { get; }
			public PXNumberEdit SOOrder__CuryOrderTotal { get; }
			public PXTextEdit SOOrder__CuryID { get; }
			public PXTextEdit SOOrder__InvoiceNbr { get; }
			public DateSelector SOOrder__InvoiceDate { get; }
			public PXNumberEdit RecordID { get; }
			public DropDown AdjgDocType { get; }
			public PXTextEdit AdjgRefNbr { get; }
                
                public c_grid_row(c_soadjustments_detgrid3 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    AdjdOrderType = new Selector("_ctl00_phG_tab_t2_detgrid3_lv0_edSOAdjdOrderType", "Order Type", grid.Locator, "AdjdOrderType");
                    AdjdOrderType.DataField = "AdjdOrderType";
                    AdjdOrderNbr = new Selector("_ctl00_phG_tab_t2_detgrid3_lv0_edSOAdjdOrderNbr", "Order Nbr.", grid.Locator, "AdjdOrderNbr");
                    AdjdOrderNbr.DataField = "AdjdOrderNbr";
                    SOOrder__Status = new DropDown("_ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__Status", "Status", grid.Locator, "SOOrder__Status");
                    SOOrder__Status.DataField = "SOOrder__Status";
                    SOOrder__Status.Items.Add("N", "Open");
                    SOOrder__Status.Items.Add("H", "On Hold");
                    SOOrder__Status.Items.Add("P", "Pending Approval");
                    SOOrder__Status.Items.Add("V", "Rejected");
                    SOOrder__Status.Items.Add("A", "Awaiting Payment");
                    SOOrder__Status.Items.Add("R", "Credit Hold");
                    SOOrder__Status.Items.Add("C", "Completed");
                    SOOrder__Status.Items.Add("L", "Canceled");
                    SOOrder__Status.Items.Add("B", "Back Order");
                    SOOrder__Status.Items.Add("S", "Shipping");
                    SOOrder__Status.Items.Add("I", "Invoiced");
                    CuryAdjgAmt = new PXNumberEdit("_ctl00_phG_tab_t2_detgrid3_lv0_edSOCuryAdjgAmt", "Applied To Order", grid.Locator, "CuryAdjgAmt");
                    CuryAdjgAmt.DataField = "CuryAdjgAmt";
                    CuryAdjgBilledAmt = new PXNumberEdit("_ctl00_phG_tab_t2_detgrid3_lv0_edSOCuryAdjgBilledAmt", "Transferred to Invoice", grid.Locator, "CuryAdjgBilledAmt");
                    CuryAdjgBilledAmt.DataField = "CuryAdjgBilledAmt";
                    AdjdOrderDate = new DateSelector("_ctl00_phG_tab_t2_detgrid3_lv0_edSOAdjdOrderDate", "Date", grid.Locator, "AdjdOrderDate");
                    AdjdOrderDate.DataField = "AdjdOrderDate";
                    SOOrder__DueDate = new DateSelector("_ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__DueDate", "Due Date", grid.Locator, "SOOrder__DueDate");
                    SOOrder__DueDate.DataField = "SOOrder__DueDate";
                    SOOrder__DiscDate = new DateSelector("_ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__DiscDate", "Cash Discount Date", grid.Locator, "SOOrder__DiscDate");
                    SOOrder__DiscDate.DataField = "SOOrder__DiscDate";
                    CuryDocBal = new PXNumberEdit("_ctl00_phG_tab_t2_detgrid3_lv0_edSOCuryDocBal", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    SOOrder__OrderDesc = new PXTextEdit("_ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__OrderDesc", "Description", grid.Locator, "SOOrder__OrderDesc");
                    SOOrder__OrderDesc.DataField = "SOOrder__OrderDesc";
                    SOOrder__CuryOrderTotal = new PXNumberEdit("_ctl00_phG_tab_t2_detgrid3_lv0_edSOOrder__CuryOrderTotal", "Order Total", grid.Locator, "SOOrder__CuryOrderTotal");
                    SOOrder__CuryOrderTotal.DataField = "SOOrder__CuryOrderTotal";
                    SOOrder__CuryID = new PXTextEdit("_ctl00_phG_tab_t2_detgrid3_lv0_edSOOrder__CuryID", "Currency", grid.Locator, "SOOrder__CuryID");
                    SOOrder__CuryID.DataField = "SOOrder__CuryID";
                    SOOrder__InvoiceNbr = new PXTextEdit("_ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__InvoiceNbr", "Invoice Nbr.", grid.Locator, "SOOrder__InvoiceNbr");
                    SOOrder__InvoiceNbr.DataField = "SOOrder__InvoiceNbr";
                    SOOrder__InvoiceDate = new DateSelector("_ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__InvoiceDate", "Invoice Date", grid.Locator, "SOOrder__InvoiceDate");
                    SOOrder__InvoiceDate.DataField = "SOOrder__InvoiceDate";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t2_detgrid3_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                    AdjgDocType = new DropDown("_ctl00_phG_tab_t2_detgrid3_lv0_ec", "Doc. Type", grid.Locator, "AdjgDocType");
                    AdjgDocType.DataField = "AdjgDocType";
                    AdjgDocType.Items.Add("PMT", "Payment");
                    AdjgDocType.Items.Add("CRM", "Credit Memo");
                    AdjgDocType.Items.Add("PPM", "Prepayment");
                    AdjgDocType.Items.Add("REF", "Customer Refund");
                    AdjgDocType.Items.Add("VRF", "Voided Refund");
                    AdjgDocType.Items.Add("RPM", "Voided Payment");
                    AdjgDocType.Items.Add("SMB", "Balance WO");
                    AdjgRefNbr = new PXTextEdit("ctl00_phG_tab_t2_detgrid3_ei", "Reference Nbr.", grid.Locator, "AdjgRefNbr");
                    AdjgRefNbr.DataField = "AdjgRefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter AdjdOrderType { get; }
				public SelectorColumnFilter AdjdOrderNbr { get; }
				public DropDownColumnFilter SOOrder__Status { get; }
				public PXNumberEditColumnFilter CuryAdjgAmt { get; }
				public PXNumberEditColumnFilter CuryAdjgBilledAmt { get; }
				public DateSelectorColumnFilter AdjdOrderDate { get; }
				public DateSelectorColumnFilter SOOrder__DueDate { get; }
				public DateSelectorColumnFilter SOOrder__DiscDate { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public PXTextEditColumnFilter SOOrder__OrderDesc { get; }
				public PXNumberEditColumnFilter SOOrder__CuryOrderTotal { get; }
				public PXTextEditColumnFilter SOOrder__CuryID { get; }
				public PXTextEditColumnFilter SOOrder__InvoiceNbr { get; }
				public DateSelectorColumnFilter SOOrder__InvoiceDate { get; }
				public PXNumberEditColumnFilter RecordID { get; }
				public DropDownColumnFilter AdjgDocType { get; }
				public PXTextEditColumnFilter AdjgRefNbr { get; }
                
                public c_grid_header(c_soadjustments_detgrid3 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    AdjdOrderType = new SelectorColumnFilter(grid.Row.AdjdOrderType);
                    AdjdOrderNbr = new SelectorColumnFilter(grid.Row.AdjdOrderNbr);
                    SOOrder__Status = new DropDownColumnFilter(grid.Row.SOOrder__Status);
                    CuryAdjgAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgAmt);
                    CuryAdjgBilledAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgBilledAmt);
                    AdjdOrderDate = new DateSelectorColumnFilter(grid.Row.AdjdOrderDate);
                    SOOrder__DueDate = new DateSelectorColumnFilter(grid.Row.SOOrder__DueDate);
                    SOOrder__DiscDate = new DateSelectorColumnFilter(grid.Row.SOOrder__DiscDate);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    SOOrder__OrderDesc = new PXTextEditColumnFilter(grid.Row.SOOrder__OrderDesc);
                    SOOrder__CuryOrderTotal = new PXNumberEditColumnFilter(grid.Row.SOOrder__CuryOrderTotal);
                    SOOrder__CuryID = new PXTextEditColumnFilter(grid.Row.SOOrder__CuryID);
                    SOOrder__InvoiceNbr = new PXTextEditColumnFilter(grid.Row.SOOrder__InvoiceNbr);
                    SOOrder__InvoiceDate = new DateSelectorColumnFilter(grid.Row.SOOrder__InvoiceDate);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                    AdjgDocType = new DropDownColumnFilter(grid.Row.AdjgDocType);
                    AdjgRefNbr = new PXTextEditColumnFilter(grid.Row.AdjgRefNbr);
                }
            }
        }
        
        public class c_soadjustments_lv0 : Container
        {
            
			public Selector AdjdOrderType { get; }
			public Label AdjdOrderTypeLabel { get; }
			public Selector AdjdOrderNbr { get; }
			public Label AdjdOrderNbrLabel { get; }
			public PXTextEdit SOOrder__Status { get; }
			public Label SOOrder__StatusLabel { get; }
			public PXNumberEdit CuryAdjgAmt { get; }
			public Label CuryAdjgAmtLabel { get; }
			public PXNumberEdit CuryAdjgBilledAmt { get; }
			public Label CuryAdjgBilledAmtLabel { get; }
			public DateSelector AdjdOrderDate { get; }
			public Label AdjdOrderDateLabel { get; }
			public DateSelector SOOrder__DueDate { get; }
			public Label SOOrder__DueDateLabel { get; }
			public DateSelector SOOrder__DiscDate { get; }
			public Label SOOrder__DiscDateLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public PXNumberEdit SOOrder__CuryOrderTotal { get; }
			public Label SOOrder__CuryOrderTotalLabel { get; }
			public PXTextEdit SOOrder__CuryID { get; }
			public Label SOOrder__CuryIDLabel { get; }
			public PXTextEdit SOOrder__InvoiceNbr { get; }
			public Label SOOrder__InvoiceNbrLabel { get; }
			public DateSelector SOOrder__InvoiceDate { get; }
			public Label SOOrder__InvoiceDateLabel { get; }
			public PXTextEdit SOOrder__OrderDesc { get; }
			public Label SOOrder__OrderDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_soadjustments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AdjdOrderType = new Selector("ctl00_phG_tab_t2_detgrid3_lv0_edSOAdjdOrderType", "Order Type", locator, null);
                AdjdOrderTypeLabel = new Label(AdjdOrderType);
                AdjdOrderType.DataField = "AdjdOrderType";
                AdjdOrderNbr = new Selector("ctl00_phG_tab_t2_detgrid3_lv0_edSOAdjdOrderNbr", "Order Nbr.", locator, null);
                AdjdOrderNbrLabel = new Label(AdjdOrderNbr);
                AdjdOrderNbr.DataField = "AdjdOrderNbr";
                SOOrder__Status = new PXTextEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__Status", "Status", locator, null);
                SOOrder__StatusLabel = new Label(SOOrder__Status);
                SOOrder__Status.DataField = "SOOrder__Status";
                CuryAdjgAmt = new PXNumberEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOCuryAdjgAmt", "Applied To Order", locator, null);
                CuryAdjgAmtLabel = new Label(CuryAdjgAmt);
                CuryAdjgAmt.DataField = "CuryAdjgAmt";
                CuryAdjgBilledAmt = new PXNumberEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOCuryAdjgBilledAmt", "Transferred to Invoice", locator, null);
                CuryAdjgBilledAmtLabel = new Label(CuryAdjgBilledAmt);
                CuryAdjgBilledAmt.DataField = "CuryAdjgBilledAmt";
                AdjdOrderDate = new DateSelector("ctl00_phG_tab_t2_detgrid3_lv0_edSOAdjdOrderDate", "Date", locator, null);
                AdjdOrderDateLabel = new Label(AdjdOrderDate);
                AdjdOrderDate.DataField = "AdjdOrderDate";
                SOOrder__DueDate = new DateSelector("ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__DueDate", "Due Date", locator, null);
                SOOrder__DueDateLabel = new Label(SOOrder__DueDate);
                SOOrder__DueDate.DataField = "SOOrder__DueDate";
                SOOrder__DiscDate = new DateSelector("ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__DiscDate", "Cash Discount Date", locator, null);
                SOOrder__DiscDateLabel = new Label(SOOrder__DiscDate);
                SOOrder__DiscDate.DataField = "SOOrder__DiscDate";
                CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                SOOrder__CuryOrderTotal = new PXNumberEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOOrder__CuryOrderTotal", "Order Total", locator, null);
                SOOrder__CuryOrderTotalLabel = new Label(SOOrder__CuryOrderTotal);
                SOOrder__CuryOrderTotal.DataField = "SOOrder__CuryOrderTotal";
                SOOrder__CuryID = new PXTextEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOOrder__CuryID", "Currency", locator, null);
                SOOrder__CuryIDLabel = new Label(SOOrder__CuryID);
                SOOrder__CuryID.DataField = "SOOrder__CuryID";
                SOOrder__InvoiceNbr = new PXTextEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__InvoiceNbr", "Invoice Nbr.", locator, null);
                SOOrder__InvoiceNbrLabel = new Label(SOOrder__InvoiceNbr);
                SOOrder__InvoiceNbr.DataField = "SOOrder__InvoiceNbr";
                SOOrder__InvoiceDate = new DateSelector("ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__InvoiceDate", "Invoice Date", locator, null);
                SOOrder__InvoiceDateLabel = new Label(SOOrder__InvoiceDate);
                SOOrder__InvoiceDate.DataField = "SOOrder__InvoiceDate";
                SOOrder__OrderDesc = new PXTextEdit("ctl00_phG_tab_t2_detgrid3_lv0_edSOSOOrder__OrderDesc", "Description", locator, null);
                SOOrder__OrderDescLabel = new Label(SOOrder__OrderDesc);
                SOOrder__OrderDesc.DataField = "SOOrder__OrderDesc";
                Es = new Selector("ctl00_phG_tab_t2_detgrid3_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t2_detgrid3_lv0_ec", "Ec", locator, null);
                DataMemberName = "SOAdjustments";
            }
        }
        
        public class c_paymentcharges_detgrid3 : Grid<c_paymentcharges_detgrid3.c_grid_row, c_paymentcharges_detgrid3.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_paymentcharges_detgrid3(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_detgrid3");
                DataMemberName = "PaymentCharges";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_detgrid3_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid3_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector EntryTypeID { get; }
			public PXTextEdit TranDesc { get; }
			public Selector AccountID { get; }
			public Selector SubID { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_paymentcharges_detgrid3 grid) : 
                        base(grid)
                {
                    EntryTypeID = new Selector("_ctl00_phG_tab_t7_detgrid3_lv0_edEntryTypeID", "Entry Type", grid.Locator, "EntryTypeID");
                    EntryTypeID.DataField = "EntryTypeID";
                    TranDesc = new PXTextEdit("ctl00_phG_tab_t7_detgrid3_ei", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    AccountID = new Selector("_ctl00_phG_tab_t7_detgrid3_lv0_edAccountID", "Offset Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    SubID = new Selector("_ctl00_phG_tab_t7_detgrid3_lv0_edSubID", "Offset Subaccount", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    CuryTranAmt = new PXNumberEdit("_ctl00_phG_tab_t7_detgrid3_lv0_edCuryTranAmt", "Amount", grid.Locator, "CuryTranAmt");
                    CuryTranAmt.DataField = "CuryTranAmt";
                    DocType = new PXTextEdit("ctl00_phG_tab_t7_detgrid3_ei", "DocType", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t7_detgrid3_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t7_detgrid3_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter EntryTypeID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter AccountID { get; }
				public SelectorColumnFilter SubID { get; }
				public PXNumberEditColumnFilter CuryTranAmt { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_paymentcharges_detgrid3 grid) : 
                        base(grid)
                {
                    EntryTypeID = new SelectorColumnFilter(grid.Row.EntryTypeID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    CuryTranAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAmt);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_paymentcharges_lv0 : Container
        {
            
			public Selector EntryTypeID { get; }
			public Label EntryTypeIDLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector SubID { get; }
			public Label SubIDLabel { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Label CuryTranAmtLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_paymentcharges_lv0(string locator, string name) : 
                    base(locator, name)
            {
                EntryTypeID = new Selector("ctl00_phG_tab_t7_detgrid3_lv0_edEntryTypeID", "Entry Type", locator, null);
                EntryTypeIDLabel = new Label(EntryTypeID);
                EntryTypeID.DataField = "EntryTypeID";
                AccountID = new Selector("ctl00_phG_tab_t7_detgrid3_lv0_edAccountID", "Offset Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_tab_t7_detgrid3_lv0_edSubID", "Offset Subaccount", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                CuryTranAmt = new PXNumberEdit("ctl00_phG_tab_t7_detgrid3_lv0_edCuryTranAmt", "Amount", locator, null);
                CuryTranAmtLabel = new Label(CuryTranAmt);
                CuryTranAmt.DataField = "CuryTranAmt";
                Es = new Selector("ctl00_phG_tab_t7_detgrid3_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "PaymentCharges";
            }
        }
        
        public class c_loadopts_loform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXBranchSelector OrgBAccountID { get; }
			public Label OrgBAccountIDLabel { get; }
			public DateSelector FromDate { get; }
			public Label FromDateLabel { get; }
			public DateSelector TillDate { get; }
			public Label TillDateLabel { get; }
			public PXNumberEdit MaxDocs { get; }
			public Label MaxDocsLabel { get; }
			public Selector StartRefNbr { get; }
			public Label StartRefNbrLabel { get; }
			public Selector EndRefNbr { get; }
			public Label EndRefNbrLabel { get; }
			public Selector StartOrderNbr { get; }
			public Label StartOrderNbrLabel { get; }
			public Selector EndOrderNbr { get; }
			public Label EndOrderNbrLabel { get; }
			public CheckBox Apply { get; }
			public Label ApplyLabel { get; }
			public DropDown LoadChildDocuments { get; }
			public Label LoadChildDocumentsLabel { get; }
			public GroupBox OrderBy { get; }
			public Label OrderByLabel { get; }
			public GroupBox SOOrderBy { get; }
			public Label SOOrderByLabel { get; }
            
            public c_loadopts_loform(string locator, string name) : 
                    base(locator, name)
            {
                OrgBAccountID = new PXBranchSelector("ctl00_phG_pnlLoadOpts_loform_BranchSelector1", "Org B Account ID", locator, null);
                OrgBAccountIDLabel = new Label(OrgBAccountID);
                OrgBAccountID.DataField = "OrgBAccountID";
                FromDate = new DateSelector("ctl00_phG_pnlLoadOpts_loform_edFromDate", "From Date", locator, null);
                FromDateLabel = new Label(FromDate);
                FromDate.DataField = "FromDate";
                TillDate = new DateSelector("ctl00_phG_pnlLoadOpts_loform_edTillDate", "Till Date", locator, null);
                TillDateLabel = new Label(TillDate);
                TillDate.DataField = "TillDate";
                MaxDocs = new PXNumberEdit("ctl00_phG_pnlLoadOpts_loform_edMaxDocs", "Max Docs", locator, null);
                MaxDocsLabel = new Label(MaxDocs);
                MaxDocs.DataField = "MaxDocs";
                StartRefNbr = new Selector("ctl00_phG_pnlLoadOpts_loform_edStartRefNbr", "Start Ref Nbr", locator, null);
                StartRefNbrLabel = new Label(StartRefNbr);
                StartRefNbr.DataField = "StartRefNbr";
                EndRefNbr = new Selector("ctl00_phG_pnlLoadOpts_loform_edEndRefNbr", "End Ref Nbr", locator, null);
                EndRefNbrLabel = new Label(EndRefNbr);
                EndRefNbr.DataField = "EndRefNbr";
                StartOrderNbr = new Selector("ctl00_phG_pnlLoadOpts_loform_edStartOrderNbr", "Start Order Nbr", locator, null);
                StartOrderNbrLabel = new Label(StartOrderNbr);
                StartOrderNbr.DataField = "StartOrderNbr";
                EndOrderNbr = new Selector("ctl00_phG_pnlLoadOpts_loform_edEndOrderNbr", "End Order Nbr", locator, null);
                EndOrderNbrLabel = new Label(EndOrderNbr);
                EndOrderNbr.DataField = "EndOrderNbr";
                Apply = new CheckBox("ctl00_phG_pnlLoadOpts_loform_chApply", "Apply", locator, null);
                ApplyLabel = new Label(Apply);
                Apply.DataField = "Apply";
                LoadChildDocuments = new DropDown("ctl00_phG_pnlLoadOpts_loform_edLoadChildDocuments", "Load Child Documents", locator, null);
                LoadChildDocumentsLabel = new Label(LoadChildDocuments);
                LoadChildDocuments.DataField = "LoadChildDocuments";
                OrderBy = new GroupBox("ctl00_phG_pnlLoadOpts_loform_gbOrderBy", "Order By", locator, null);
                OrderByLabel = new Label(OrderBy);
                OrderBy.DataField = "OrderBy";
                SOOrderBy = new GroupBox("ctl00_phG_pnlLoadOpts_loform_gbSOOrderBy", "SO Order By", locator, null);
                SOOrderByLabel = new Label(SOOrderBy);
                SOOrderBy.DataField = "SOOrderBy";
                DataMemberName = "loadOpts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Load()
            {
                Buttons.Load.Click();
            }
            
            public virtual void Reload()
            {
                Buttons.Reload.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Load { get; }
			public Button Reload { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Load = new Button("ctl00_phG_pnlLoadOpts_loform_btnLoad", "Load", "ctl00_phG_pnlLoadOpts_loform");
                    Reload = new Button("ctl00_phG_pnlLoadOpts_loform_btnReload", "Reload", "ctl00_phG_pnlLoadOpts_loform");
                    Cancel = new Button("ctl00_phG_pnlLoadOpts_loform_btnCancel", "Cancel", "ctl00_phG_pnlLoadOpts_loform");
                }
            }
        }
        
        public class c_voucher_voucherdetails : Container
        {
            
			public PXTextEdit VoucherBatchNbr { get; }
			public Label VoucherBatchNbrLabel { get; }
			public PXTextEdit WorkBookID { get; }
			public Label WorkBookIDLabel { get; }
            
            public c_voucher_voucherdetails(string locator, string name) : 
                    base(locator, name)
            {
                VoucherBatchNbr = new PXTextEdit("ctl00_phG_tab_t4_form2_VoucherDetails_linkGLVoucherBatch", "Voucher Batch Nbr.", locator, null);
                VoucherBatchNbrLabel = new Label(VoucherBatchNbr);
                VoucherBatchNbr.DataField = "VoucherBatchNbr";
                WorkBookID = new PXTextEdit("ctl00_phG_tab_t4_form2_VoucherDetails_linkGLWorkBook", "Workbook ID", locator, null);
                WorkBookIDLabel = new Label(WorkBookID);
                WorkBookID.DataField = "WorkBookID";
                DataMemberName = "Voucher";
            }
        }
        
        public class c_ccproctran_grdccproctran : Grid<c_ccproctran_grdccproctran.c_grid_row, c_ccproctran_grdccproctran.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_ccproctran_grdccproctran(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_grdCCProcTran");
                DataMemberName = "ccProcTran";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_grdCCProcTran_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdCCProcTran_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXNumberEdit TranNbr { get; }
			public PXTextEdit ProcessingCenterID { get; }
			public DropDown TranType { get; }
			public DropDown TranStatus { get; }
			public PXNumberEdit Amount { get; }
			public PXNumberEdit RefTranNbr { get; }
			public PXTextEdit PCTranNumber { get; }
			public PXTextEdit AuthNumber { get; }
			public PXTextEdit PCResponseReasonText { get; }
			public DateSelector StartTime { get; }
			public DropDown ProcStatus { get; }
			public DropDown CVVVerificationStatus { get; }
			public PXTextEdit ErrorSource { get; }
			public PXTextEdit ErrorText { get; }
                
                public c_grid_row(c_ccproctran_grdccproctran grid) : 
                        base(grid)
                {
                    TranNbr = new PXNumberEdit("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edTranNbr", "Tran. Nbr.", grid.Locator, "TranNbr");
                    TranNbr.DataField = "TranNbr";
                    ProcessingCenterID = new PXTextEdit("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edProcessingCenterID", "Proc. Center", grid.Locator, "ProcessingCenterID");
                    ProcessingCenterID.DataField = "ProcessingCenterID";
                    TranType = new DropDown("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edTranType", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    TranType.Items.Add("AUT", "Authorize Only");
                    TranType.Items.Add("AAC", "Authorize and Capture");
                    TranType.Items.Add("PAC", "Capture Authorized");
                    TranType.Items.Add("CAP", "Capture Manualy Authorized");
                    TranType.Items.Add("VDG", "Void");
                    TranType.Items.Add("CDT", "Refund");
                    TranType.Items.Add("UKN", "Unknown");
                    TranStatus = new DropDown("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edTranStatus", "Tran. Status", grid.Locator, "TranStatus");
                    TranStatus.DataField = "TranStatus";
                    TranStatus.Items.Add("APR", "Approved");
                    TranStatus.Items.Add("DEC", "Declined");
                    TranStatus.Items.Add("ERR", "Error");
                    TranStatus.Items.Add("HFR", "Held for Review");
                    TranStatus.Items.Add("EXP", "Expired");
                    TranStatus.Items.Add("UKN", "Unknown");
                    Amount = new PXNumberEdit("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edAmount", "Tran. Amount", grid.Locator, "Amount");
                    Amount.DataField = "Amount";
                    RefTranNbr = new PXNumberEdit("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edRefTranNbr", "Referenced Tran. Nbr.", grid.Locator, "RefTranNbr");
                    RefTranNbr.DataField = "RefTranNbr";
                    PCTranNumber = new PXTextEdit("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edPCTranNumber", "Proc. Center Tran. Nbr.", grid.Locator, "PCTranNumber");
                    PCTranNumber.DataField = "PCTranNumber";
                    AuthNumber = new PXTextEdit("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edAuthNumber", "Proc. Center Auth. Nbr.", grid.Locator, "AuthNumber");
                    AuthNumber.DataField = "AuthNumber";
                    PCResponseReasonText = new PXTextEdit("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edPCResponseReasonText", "PC Response Reason", grid.Locator, "PCResponseReasonText");
                    PCResponseReasonText.DataField = "PCResponseReasonText";
                    StartTime = new DateSelector("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edStartTime", "Tran. Time", grid.Locator, "StartTime");
                    StartTime.DataField = "StartTime";
                    ProcStatus = new DropDown("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edProcStatus", "Proc. Status", grid.Locator, "ProcStatus");
                    ProcStatus.DataField = "ProcStatus";
                    ProcStatus.Items.Add("OPN", "Open");
                    ProcStatus.Items.Add("FIN", "Completed");
                    ProcStatus.Items.Add("ERR", "Error");
                    CVVVerificationStatus = new DropDown("_ctl00_phG_tab_t6_grdCCProcTran_lv0_edCVVVerificationStatus", "CVV Verification", grid.Locator, "CVVVerificationStatus");
                    CVVVerificationStatus.DataField = "CVVVerificationStatus";
                    CVVVerificationStatus.Items.Add("MTH", "Matched");
                    CVVVerificationStatus.Items.Add("NMH", "Not Matched");
                    CVVVerificationStatus.Items.Add("NOV", "Required but Not Verified");
                    CVVVerificationStatus.Items.Add("SBP", "Required but Not Provided");
                    CVVVerificationStatus.Items.Add("INV", "Not Verified Due to Issuer");
                    CVVVerificationStatus.Items.Add("RPV", "Skipped Due to Prior Verification");
                    CVVVerificationStatus.Items.Add("UKN", "Unknown");
                    ErrorSource = new PXTextEdit("ctl00_phG_tab_t6_grdCCProcTran_ei", "Error Source", grid.Locator, "ErrorSource");
                    ErrorSource.DataField = "ErrorSource";
                    ErrorText = new PXTextEdit("ctl00_phG_tab_t6_grdCCProcTran_ei", "Error Text", grid.Locator, "ErrorText");
                    ErrorText.DataField = "ErrorText";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXNumberEditColumnFilter TranNbr { get; }
				public PXTextEditColumnFilter ProcessingCenterID { get; }
				public DropDownColumnFilter TranType { get; }
				public DropDownColumnFilter TranStatus { get; }
				public PXNumberEditColumnFilter Amount { get; }
				public PXNumberEditColumnFilter RefTranNbr { get; }
				public PXTextEditColumnFilter PCTranNumber { get; }
				public PXTextEditColumnFilter AuthNumber { get; }
				public PXTextEditColumnFilter PCResponseReasonText { get; }
				public DateSelectorColumnFilter StartTime { get; }
				public DropDownColumnFilter ProcStatus { get; }
				public DropDownColumnFilter CVVVerificationStatus { get; }
				public PXTextEditColumnFilter ErrorSource { get; }
				public PXTextEditColumnFilter ErrorText { get; }
                
                public c_grid_header(c_ccproctran_grdccproctran grid) : 
                        base(grid)
                {
                    TranNbr = new PXNumberEditColumnFilter(grid.Row.TranNbr);
                    ProcessingCenterID = new PXTextEditColumnFilter(grid.Row.ProcessingCenterID);
                    TranType = new DropDownColumnFilter(grid.Row.TranType);
                    TranStatus = new DropDownColumnFilter(grid.Row.TranStatus);
                    Amount = new PXNumberEditColumnFilter(grid.Row.Amount);
                    RefTranNbr = new PXNumberEditColumnFilter(grid.Row.RefTranNbr);
                    PCTranNumber = new PXTextEditColumnFilter(grid.Row.PCTranNumber);
                    AuthNumber = new PXTextEditColumnFilter(grid.Row.AuthNumber);
                    PCResponseReasonText = new PXTextEditColumnFilter(grid.Row.PCResponseReasonText);
                    StartTime = new DateSelectorColumnFilter(grid.Row.StartTime);
                    ProcStatus = new DropDownColumnFilter(grid.Row.ProcStatus);
                    CVVVerificationStatus = new DropDownColumnFilter(grid.Row.CVVVerificationStatus);
                    ErrorSource = new PXTextEditColumnFilter(grid.Row.ErrorSource);
                    ErrorText = new PXTextEditColumnFilter(grid.Row.ErrorText);
                }
            }
        }
        
        public class c_ccproctran_lv0 : Container
        {
            
			public PXNumberEdit TranNbr { get; }
			public Label TranNbrLabel { get; }
			public DropDown ProcStatus { get; }
			public Label ProcStatusLabel { get; }
			public PXTextEdit ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
			public DropDown CVVVerificationStatus { get; }
			public Label CVVVerificationStatusLabel { get; }
			public DropDown TranType { get; }
			public Label TranTypeLabel { get; }
			public DropDown TranStatus { get; }
			public Label TranStatusLabel { get; }
			public PXNumberEdit Amount { get; }
			public Label AmountLabel { get; }
			public PXNumberEdit RefTranNbr { get; }
			public Label RefTranNbrLabel { get; }
			public PXTextEdit PCTranNumber { get; }
			public Label PCTranNumberLabel { get; }
			public PXTextEdit AuthNumber { get; }
			public Label AuthNumberLabel { get; }
			public PXTextEdit PCResponseReasonText { get; }
			public Label PCResponseReasonTextLabel { get; }
			public DateSelector StartTime { get; }
			public Label StartTimeLabel { get; }
            
            public c_ccproctran_lv0(string locator, string name) : 
                    base(locator, name)
            {
                TranNbr = new PXNumberEdit("ctl00_phG_tab_t6_grdCCProcTran_lv0_edTranNbr", "Tran. Nbr.", locator, null);
                TranNbrLabel = new Label(TranNbr);
                TranNbr.DataField = "TranNbr";
                ProcStatus = new DropDown("ctl00_phG_tab_t6_grdCCProcTran_lv0_edProcStatus", "Proc. Status", locator, null);
                ProcStatusLabel = new Label(ProcStatus);
                ProcStatus.DataField = "ProcStatus";
                ProcStatus.Items.Add("OPN", "Open");
                ProcStatus.Items.Add("FIN", "Completed");
                ProcStatus.Items.Add("ERR", "Error");
                ProcessingCenterID = new PXTextEdit("ctl00_phG_tab_t6_grdCCProcTran_lv0_edProcessingCenterID", "Proc. Center", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                CVVVerificationStatus = new DropDown("ctl00_phG_tab_t6_grdCCProcTran_lv0_edCVVVerificationStatus", "CVV Verification", locator, null);
                CVVVerificationStatusLabel = new Label(CVVVerificationStatus);
                CVVVerificationStatus.DataField = "CVVVerificationStatus";
                CVVVerificationStatus.Items.Add("MTH", "Matched");
                CVVVerificationStatus.Items.Add("NMH", "Not Matched");
                CVVVerificationStatus.Items.Add("NOV", "Required but Not Verified");
                CVVVerificationStatus.Items.Add("SBP", "Required but Not Provided");
                CVVVerificationStatus.Items.Add("INV", "Not Verified Due to Issuer");
                CVVVerificationStatus.Items.Add("RPV", "Skipped Due to Prior Verification");
                CVVVerificationStatus.Items.Add("UKN", "Unknown");
                TranType = new DropDown("ctl00_phG_tab_t6_grdCCProcTran_lv0_edTranType", "Tran. Type", locator, null);
                TranTypeLabel = new Label(TranType);
                TranType.DataField = "TranType";
                TranType.Items.Add("AUT", "Authorize Only");
                TranType.Items.Add("AAC", "Authorize and Capture");
                TranType.Items.Add("PAC", "Capture Authorized");
                TranType.Items.Add("CAP", "Capture Manualy Authorized");
                TranType.Items.Add("VDG", "Void");
                TranType.Items.Add("CDT", "Refund");
                TranType.Items.Add("UKN", "Unknown");
                TranStatus = new DropDown("ctl00_phG_tab_t6_grdCCProcTran_lv0_edTranStatus", "Tran. Status", locator, null);
                TranStatusLabel = new Label(TranStatus);
                TranStatus.DataField = "TranStatus";
                TranStatus.Items.Add("APR", "Approved");
                TranStatus.Items.Add("DEC", "Declined");
                TranStatus.Items.Add("ERR", "Error");
                TranStatus.Items.Add("HFR", "Held for Review");
                TranStatus.Items.Add("EXP", "Expired");
                TranStatus.Items.Add("UKN", "Unknown");
                Amount = new PXNumberEdit("ctl00_phG_tab_t6_grdCCProcTran_lv0_edAmount", "Tran. Amount", locator, null);
                AmountLabel = new Label(Amount);
                Amount.DataField = "Amount";
                RefTranNbr = new PXNumberEdit("ctl00_phG_tab_t6_grdCCProcTran_lv0_edRefTranNbr", "Referenced Tran. Nbr.", locator, null);
                RefTranNbrLabel = new Label(RefTranNbr);
                RefTranNbr.DataField = "RefTranNbr";
                PCTranNumber = new PXTextEdit("ctl00_phG_tab_t6_grdCCProcTran_lv0_edPCTranNumber", "Proc. Center Tran. Nbr.", locator, null);
                PCTranNumberLabel = new Label(PCTranNumber);
                PCTranNumber.DataField = "PCTranNumber";
                AuthNumber = new PXTextEdit("ctl00_phG_tab_t6_grdCCProcTran_lv0_edAuthNumber", "Proc. Center Auth. Nbr.", locator, null);
                AuthNumberLabel = new Label(AuthNumber);
                AuthNumber.DataField = "AuthNumber";
                PCResponseReasonText = new PXTextEdit("ctl00_phG_tab_t6_grdCCProcTran_lv0_edPCResponseReasonText", "PC Response Reason", locator, null);
                PCResponseReasonTextLabel = new Label(PCResponseReasonText);
                PCResponseReasonText.DataField = "PCResponseReasonText";
                StartTime = new DateSelector("ctl00_phG_tab_t6_grdCCProcTran_lv0_edStartTime", "Tran. Time", locator, null);
                StartTimeLabel = new Label(StartTime);
                StartTime.DataField = "StartTime";
                DataMemberName = "ccProcTran";
            }
        }
        
        public class c_approval_gridapproval : Grid<c_approval_gridapproval.c_grid_row, c_approval_gridapproval.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_approval_gridapproval(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_gridApproval");
                DataMemberName = "Approval";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_gridApproval_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit ApproverEmployee__AcctCD { get; }
			public PXTextEdit ApproverEmployee__AcctName { get; }
			public Selector WorkgroupID { get; }
			public PXTextEdit ApprovedByEmployee__AcctCD { get; }
			public PXTextEdit ApprovedByEmployee__AcctName { get; }
			public DateSelector ApproveDate { get; }
			public DropDown Status { get; }
			public PXTextEdit Reason { get; }
			public Selector AssignmentMapID { get; }
			public Selector RuleID { get; }
			public Selector StepID { get; }
			public DateSelector CreatedDateTime { get; }
			public PXNumberEdit ApprovalID { get; }
                
                public c_grid_row(c_approval_gridapproval grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ApproverEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t5_gridApproval_ei", "Assignee ID", grid.Locator, "ApproverEmployee__AcctCD");
                    ApproverEmployee__AcctCD.DataField = "ApproverEmployee__AcctCD";
                    ApproverEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t5_gridApproval_ei", "Assigned To", grid.Locator, "ApproverEmployee__AcctName");
                    ApproverEmployee__AcctName.DataField = "ApproverEmployee__AcctName";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t5_gridApproval_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    ApprovedByEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t5_gridApproval_ei", "Approved By (ID)", grid.Locator, "ApprovedByEmployee__AcctCD");
                    ApprovedByEmployee__AcctCD.DataField = "ApprovedByEmployee__AcctCD";
                    ApprovedByEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t5_gridApproval_ei", "Approved By", grid.Locator, "ApprovedByEmployee__AcctName");
                    ApprovedByEmployee__AcctName.DataField = "ApprovedByEmployee__AcctName";
                    ApproveDate = new DateSelector("_ctl00_phG_tab_t5_gridApproval_lv0_ed7", "Approval Date", grid.Locator, "ApproveDate");
                    ApproveDate.DataField = "ApproveDate";
                    Status = new DropDown("_ctl00_phG_tab_t5_gridApproval_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("P", "Pending");
                    Status.Items.Add("A", "Approved");
                    Status.Items.Add("R", "Rejected");
                    Reason = new PXTextEdit("ctl00_phG_tab_t5_gridApproval_ei", "Reason", grid.Locator, "Reason");
                    Reason.DataField = "Reason";
                    AssignmentMapID = new Selector("_ctl00_phG_tab_t5_gridApproval_lv0_es", "Approval Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    RuleID = new Selector("_ctl00_phG_tab_t5_gridApproval_lv0_es", "Map Rule", grid.Locator, "RuleID");
                    RuleID.DataField = "RuleID";
                    StepID = new Selector("_ctl00_phG_tab_t5_gridApproval_lv0_es", "Map Step", grid.Locator, "StepID");
                    StepID.DataField = "StepID";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t5_gridApproval_lv0_ed13", "Assignment Date", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    ApprovalID = new PXNumberEdit("ctl00_phG_tab_t5_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
                    ApprovalID.DataField = "ApprovalID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter ApproverEmployee__AcctCD { get; }
				public PXTextEditColumnFilter ApproverEmployee__AcctName { get; }
				public SelectorColumnFilter WorkgroupID { get; }
				public PXTextEditColumnFilter ApprovedByEmployee__AcctCD { get; }
				public PXTextEditColumnFilter ApprovedByEmployee__AcctName { get; }
				public DateSelectorColumnFilter ApproveDate { get; }
				public DropDownColumnFilter Status { get; }
				public PXTextEditColumnFilter Reason { get; }
				public SelectorColumnFilter AssignmentMapID { get; }
				public SelectorColumnFilter RuleID { get; }
				public SelectorColumnFilter StepID { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXNumberEditColumnFilter ApprovalID { get; }
                
                public c_grid_header(c_approval_gridapproval grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ApproverEmployee__AcctCD = new PXTextEditColumnFilter(grid.Row.ApproverEmployee__AcctCD);
                    ApproverEmployee__AcctName = new PXTextEditColumnFilter(grid.Row.ApproverEmployee__AcctName);
                    WorkgroupID = new SelectorColumnFilter(grid.Row.WorkgroupID);
                    ApprovedByEmployee__AcctCD = new PXTextEditColumnFilter(grid.Row.ApprovedByEmployee__AcctCD);
                    ApprovedByEmployee__AcctName = new PXTextEditColumnFilter(grid.Row.ApprovedByEmployee__AcctName);
                    ApproveDate = new DateSelectorColumnFilter(grid.Row.ApproveDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    Reason = new PXTextEditColumnFilter(grid.Row.Reason);
                    AssignmentMapID = new SelectorColumnFilter(grid.Row.AssignmentMapID);
                    RuleID = new SelectorColumnFilter(grid.Row.RuleID);
                    StepID = new SelectorColumnFilter(grid.Row.StepID);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    ApprovalID = new PXNumberEditColumnFilter(grid.Row.ApprovalID);
                }
            }
        }
        
        public class c_approval_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_approval_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t5_gridApproval_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t5_gridApproval_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t5_gridApproval_lv0_ec", "Ec", locator, null);
                DataMemberName = "Approval";
            }
        }
        
        public class c_ccpaymentinfo_frmccpaymentinfo : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit PCTranNumber { get; }
			public Label PCTranNumberLabel { get; }
            
            public c_ccpaymentinfo_frmccpaymentinfo(string locator, string name) : 
                    base(locator, name)
            {
                PCTranNumber = new PXTextEdit("ctl00_phDS_pnlRecordCCPayment_frmCCPaymentInfo_edPCTranNumber", "PC Tran Number", locator, null);
                PCTranNumberLabel = new Label(PCTranNumber);
                PCTranNumber.DataField = "PCTranNumber";
                DataMemberName = "ccPaymentInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phDS_pnlRecordCCPayment_OK", "Save", "ctl00_phDS_pnlRecordCCPayment_frmCCPaymentInfo");
                    Cancel = new Button("ctl00_phDS_pnlRecordCCPayment_Cancel", "Cancel", "ctl00_phDS_pnlRecordCCPayment_frmCCPaymentInfo");
                }
            }
        }
        
        public class c_ccpaymentinfo_frmccpaymentinfo1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AuthNumber { get; }
			public Label AuthNumberLabel { get; }
            
            public c_ccpaymentinfo_frmccpaymentinfo1(string locator, string name) : 
                    base(locator, name)
            {
                AuthNumber = new PXTextEdit("ctl00_phDS_pnlCaptureCCOnly_frmCCPaymentInfo1_edAuthNumber", "Auth Number", locator, null);
                AuthNumberLabel = new Label(AuthNumber);
                AuthNumber.DataField = "AuthNumber";
                DataMemberName = "ccPaymentInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phDS_pnlCaptureCCOnly_PXButton1", "Save", "ctl00_phDS_pnlCaptureCCOnly_frmCCPaymentInfo1");
                    Cancel = new Button("ctl00_phDS_pnlCaptureCCOnly_PXButton2", "Cancel", "ctl00_phDS_pnlCaptureCCOnly_frmCCPaymentInfo1");
                }
            }
        }
        
        public class c_reasonapproverejectparams_pxformviewpanelreason : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Reason { get; }
			public Label ReasonLabel { get; }
            
            public c_reasonapproverejectparams_pxformviewpanelreason(string locator, string name) : 
                    base(locator, name)
            {
                Reason = new PXTextEdit("ctl00_phG_panelReason_PXFormViewPanelReason_edReason", "Reason", locator, null);
                ReasonLabel = new Label(Reason);
                Reason.DataField = "Reason";
                DataMemberName = "ReasonApproveRejectParams";
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
                    Ok = new Button("ctl00_phG_panelReason_PXFormViewPanelReason_btnReasonOk", "OK", "ctl00_phG_panelReason_PXFormViewPanelReason");
                    Cancel = new Button("ctl00_phG_panelReason_PXFormViewPanelReason_btnReasonCancel", "Cancel", "ctl00_phG_panelReason_PXFormViewPanelReason");
                }
            }
        }
        
        public class c_compliancedocuments_grdcompliancedocuments : Grid<c_compliancedocuments_grdcompliancedocuments.c_grid_row, c_compliancedocuments_grdcompliancedocuments.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_compliancedocuments_grdcompliancedocuments(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_grdComplianceDocuments");
                DataMemberName = "ComplianceDocuments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t8_grdComplianceDocuments_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_at_tlb div[data-cmd=\'AdjustColumns\']" +
                            "", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdComplianceDocuments_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ExpirationDate { get; }
			public PXTextEdit DocumentType { get; }
			public PXTextEdit CreationDate { get; }
			public PXTextEdit Status { get; }
			public CheckBox Required { get; }
			public CheckBox Received { get; }
			public PXTextEdit ReceivedDate { get; }
			public CheckBox IsProcessed { get; }
			public CheckBox IsVoided { get; }
			public CheckBox IsCreatedAutomatically { get; }
			public PXTextEdit SentDate { get; }
			public Selector ProjectID { get; }
			public Selector CostTaskID { get; }
			public Selector RevenueTaskID { get; }
			public Selector CostCodeID { get; }
			public PXTextEdit VendorID { get; }
			public PXTextEdit VendorName { get; }
			public Selector BillID { get; }
			public PXTextEdit BillAmount { get; }
			public PXTextEdit AccountID { get; }
			public Selector ApCheckID { get; }
			public PXTextEdit CheckNumber { get; }
			public PXTextEdit CustomerID { get; }
			public PXTextEdit CertificateNumber { get; }
			public PXTextEdit CreatedByID { get; }
			public PXTextEdit CustomerName { get; }
			public Selector ArPaymentID { get; }
			public PXTextEdit DateIssued { get; }
			public PXTextEdit EffectiveDate { get; }
			public PXTextEdit InsuranceCompany { get; }
			public PXTextEdit InvoiceAmount { get; }
			public Selector InvoiceID { get; }
			public CheckBox IsExpired { get; }
			public CheckBox IsRequiredJointCheck { get; }
			public PXTextEdit JointAmount { get; }
			public PXTextEdit JointRelease { get; }
			public CheckBox JointReleaseReceived { get; }
			public PXTextEdit JointVendorInternalId { get; }
			public PXTextEdit JointVendorExternalName { get; }
			public PXTextEdit LastModifiedByID { get; }
			public PXTextEdit LienWaiverAmount { get; }
			public PXTextEdit Limit { get; }
			public PXTextEdit MethodSent { get; }
			public PXTextEdit PaymentDate { get; }
			public PXTextEdit ArPaymentMethodID { get; }
			public PXTextEdit ApPaymentMethodID { get; }
			public PXTextEdit Policy { get; }
			public Selector ProjectTransactionID { get; }
			public Selector PurchaseOrder { get; }
			public Selector PurchaseOrderLineItem { get; }
			public Selector Subcontract { get; }
			public Selector SubcontractLineItem { get; }
			public Selector ChangeOrderNumber { get; }
			public PXTextEdit ReceiptDate { get; }
			public PXTextEdit ReceiveDate { get; }
			public PXTextEdit ReceivedBy { get; }
			public PXTextEdit SecondaryVendorID { get; }
			public PXTextEdit SecondaryVendorName { get; }
			public PXTextEdit SourceType { get; }
			public PXTextEdit SponsorOrganization { get; }
			public PXTextEdit ThroughDate { get; }
			public Selector DocumentTypeValue { get; }
                
                public c_grid_row(c_compliancedocuments_grdcompliancedocuments grid) : 
                        base(grid)
                {
                    ExpirationDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Expiration Date", grid.Locator, "ExpirationDate");
                    ExpirationDate.DataField = "ExpirationDate";
                    DocumentType = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Document Type", grid.Locator, "DocumentType");
                    DocumentType.DataField = "DocumentType";
                    CreationDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Creation Date", grid.Locator, "CreationDate");
                    CreationDate.DataField = "CreationDate";
                    Status = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Required = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    Received = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Received", grid.Locator, "Received");
                    Received.DataField = "Received";
                    ReceivedDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Received Date", grid.Locator, "ReceivedDate");
                    ReceivedDate.DataField = "ReceivedDate";
                    IsProcessed = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Is Processed", grid.Locator, "IsProcessed");
                    IsProcessed.DataField = "IsProcessed";
                    IsVoided = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Is Voided", grid.Locator, "IsVoided");
                    IsVoided.DataField = "IsVoided";
                    IsCreatedAutomatically = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Is Created Automatically", grid.Locator, "IsCreatedAutomatically");
                    IsCreatedAutomatically.DataField = "IsCreatedAutomatically";
                    SentDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Sent Date", grid.Locator, "SentDate");
                    SentDate.DataField = "SentDate";
                    ProjectID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edProjectID", "Project ID", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    CostTaskID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", grid.Locator, "CostTaskID");
                    CostTaskID.DataField = "CostTaskID";
                    RevenueTaskID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", grid.Locator, "RevenueTaskID");
                    RevenueTaskID.DataField = "RevenueTaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    VendorID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorName = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Vendor Name", grid.Locator, "VendorName");
                    VendorName.DataField = "VendorName";
                    BillID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edBillID", "Bill ID", grid.Locator, "BillID");
                    BillID.DataField = "BillID";
                    BillAmount = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Bill Amount", grid.Locator, "BillAmount");
                    BillAmount.DataField = "BillAmount";
                    AccountID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Account ID", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    ApCheckID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", grid.Locator, "ApCheckID");
                    ApCheckID.DataField = "ApCheckID";
                    CheckNumber = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Check Number", grid.Locator, "CheckNumber");
                    CheckNumber.DataField = "CheckNumber";
                    CustomerID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Customer ID", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    CertificateNumber = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Certificate Number", grid.Locator, "CertificateNumber");
                    CertificateNumber.DataField = "CertificateNumber";
                    CreatedByID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Created By ID", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CustomerName = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Customer Name", grid.Locator, "CustomerName");
                    CustomerName.DataField = "CustomerName";
                    ArPaymentID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", grid.Locator, "ArPaymentID");
                    ArPaymentID.DataField = "ArPaymentID";
                    DateIssued = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Date Issued", grid.Locator, "DateIssued");
                    DateIssued.DataField = "DateIssued";
                    EffectiveDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Effective Date", grid.Locator, "EffectiveDate");
                    EffectiveDate.DataField = "EffectiveDate";
                    InsuranceCompany = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Insurance Company", grid.Locator, "InsuranceCompany");
                    InsuranceCompany.DataField = "InsuranceCompany";
                    InvoiceAmount = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Invoice Amount", grid.Locator, "InvoiceAmount");
                    InvoiceAmount.DataField = "InvoiceAmount";
                    InvoiceID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", grid.Locator, "InvoiceID");
                    InvoiceID.DataField = "InvoiceID";
                    IsExpired = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Is Expired", grid.Locator, "IsExpired");
                    IsExpired.DataField = "IsExpired";
                    IsRequiredJointCheck = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Is Required Joint Check", grid.Locator, "IsRequiredJointCheck");
                    IsRequiredJointCheck.DataField = "IsRequiredJointCheck";
                    JointAmount = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Joint Amount", grid.Locator, "JointAmount");
                    JointAmount.DataField = "JointAmount";
                    JointRelease = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Joint Release", grid.Locator, "JointRelease");
                    JointRelease.DataField = "JointRelease";
                    JointReleaseReceived = new CheckBox("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Joint Release Received", grid.Locator, "JointReleaseReceived");
                    JointReleaseReceived.DataField = "JointReleaseReceived";
                    JointVendorInternalId = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Joint Vendor Internal Id", grid.Locator, "JointVendorInternalId");
                    JointVendorInternalId.DataField = "JointVendorInternalId";
                    JointVendorExternalName = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Joint Vendor External Name", grid.Locator, "JointVendorExternalName");
                    JointVendorExternalName.DataField = "JointVendorExternalName";
                    LastModifiedByID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Last Modified By ID", grid.Locator, "LastModifiedByID");
                    LastModifiedByID.DataField = "LastModifiedByID";
                    LienWaiverAmount = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Lien Waiver Amount", grid.Locator, "LienWaiverAmount");
                    LienWaiverAmount.DataField = "LienWaiverAmount";
                    Limit = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Limit", grid.Locator, "Limit");
                    Limit.DataField = "Limit";
                    MethodSent = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Method Sent", grid.Locator, "MethodSent");
                    MethodSent.DataField = "MethodSent";
                    PaymentDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Payment Date", grid.Locator, "PaymentDate");
                    PaymentDate.DataField = "PaymentDate";
                    ArPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Ar Payment Method ID", grid.Locator, "ArPaymentMethodID");
                    ArPaymentMethodID.DataField = "ArPaymentMethodID";
                    ApPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Ap Payment Method ID", grid.Locator, "ApPaymentMethodID");
                    ApPaymentMethodID.DataField = "ApPaymentMethodID";
                    Policy = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Policy", grid.Locator, "Policy");
                    Policy.DataField = "Policy";
                    ProjectTransactionID = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", grid.Locator, "ProjectTransactionID");
                    ProjectTransactionID.DataField = "ProjectTransactionID";
                    PurchaseOrder = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", grid.Locator, "PurchaseOrder");
                    PurchaseOrder.DataField = "PurchaseOrder";
                    PurchaseOrderLineItem = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", grid.Locator, "PurchaseOrderLineItem");
                    PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                    Subcontract = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", grid.Locator, "Subcontract");
                    Subcontract.DataField = "Subcontract";
                    SubcontractLineItem = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", grid.Locator, "SubcontractLineItem");
                    SubcontractLineItem.DataField = "SubcontractLineItem";
                    ChangeOrderNumber = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", grid.Locator, "ChangeOrderNumber");
                    ChangeOrderNumber.DataField = "ChangeOrderNumber";
                    ReceiptDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Receipt Date", grid.Locator, "ReceiptDate");
                    ReceiptDate.DataField = "ReceiptDate";
                    ReceiveDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Receive Date", grid.Locator, "ReceiveDate");
                    ReceiveDate.DataField = "ReceiveDate";
                    ReceivedBy = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Received By", grid.Locator, "ReceivedBy");
                    ReceivedBy.DataField = "ReceivedBy";
                    SecondaryVendorID = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Secondary Vendor ID", grid.Locator, "SecondaryVendorID");
                    SecondaryVendorID.DataField = "SecondaryVendorID";
                    SecondaryVendorName = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Secondary Vendor Name", grid.Locator, "SecondaryVendorName");
                    SecondaryVendorName.DataField = "SecondaryVendorName";
                    SourceType = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Source Type", grid.Locator, "SourceType");
                    SourceType.DataField = "SourceType";
                    SponsorOrganization = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Sponsor Organization", grid.Locator, "SponsorOrganization");
                    SponsorOrganization.DataField = "SponsorOrganization";
                    ThroughDate = new PXTextEdit("ctl00_phG_tab_t8_grdComplianceDocuments_ei", "Through Date", grid.Locator, "ThroughDate");
                    ThroughDate.DataField = "ThroughDate";
                    DocumentTypeValue = new Selector("_ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", grid.Locator, "DocumentTypeValue");
                    DocumentTypeValue.DataField = "DocumentTypeValue";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ExpirationDate { get; }
				public PXTextEditColumnFilter DocumentType { get; }
				public PXTextEditColumnFilter CreationDate { get; }
				public PXTextEditColumnFilter Status { get; }
				public CheckBoxColumnFilter Required { get; }
				public CheckBoxColumnFilter Received { get; }
				public PXTextEditColumnFilter ReceivedDate { get; }
				public CheckBoxColumnFilter IsProcessed { get; }
				public CheckBoxColumnFilter IsVoided { get; }
				public CheckBoxColumnFilter IsCreatedAutomatically { get; }
				public PXTextEditColumnFilter SentDate { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter CostTaskID { get; }
				public SelectorColumnFilter RevenueTaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public PXTextEditColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorName { get; }
				public InputColumnFilter BillID { get; }
				public PXTextEditColumnFilter BillAmount { get; }
				public PXTextEditColumnFilter AccountID { get; }
				public InputColumnFilter ApCheckID { get; }
				public PXTextEditColumnFilter CheckNumber { get; }
				public PXTextEditColumnFilter CustomerID { get; }
				public PXTextEditColumnFilter CertificateNumber { get; }
				public PXTextEditColumnFilter CreatedByID { get; }
				public PXTextEditColumnFilter CustomerName { get; }
				public InputColumnFilter ArPaymentID { get; }
				public PXTextEditColumnFilter DateIssued { get; }
				public PXTextEditColumnFilter EffectiveDate { get; }
				public PXTextEditColumnFilter InsuranceCompany { get; }
				public PXTextEditColumnFilter InvoiceAmount { get; }
				public InputColumnFilter InvoiceID { get; }
				public CheckBoxColumnFilter IsExpired { get; }
				public CheckBoxColumnFilter IsRequiredJointCheck { get; }
				public PXTextEditColumnFilter JointAmount { get; }
				public PXTextEditColumnFilter JointRelease { get; }
				public CheckBoxColumnFilter JointReleaseReceived { get; }
				public PXTextEditColumnFilter JointVendorInternalId { get; }
				public PXTextEditColumnFilter JointVendorExternalName { get; }
				public PXTextEditColumnFilter LastModifiedByID { get; }
				public PXTextEditColumnFilter LienWaiverAmount { get; }
				public PXTextEditColumnFilter Limit { get; }
				public PXTextEditColumnFilter MethodSent { get; }
				public PXTextEditColumnFilter PaymentDate { get; }
				public PXTextEditColumnFilter ArPaymentMethodID { get; }
				public PXTextEditColumnFilter ApPaymentMethodID { get; }
				public PXTextEditColumnFilter Policy { get; }
				public InputColumnFilter ProjectTransactionID { get; }
				public InputColumnFilter PurchaseOrder { get; }
				public SelectorColumnFilter PurchaseOrderLineItem { get; }
				public SelectorColumnFilter Subcontract { get; }
				public SelectorColumnFilter SubcontractLineItem { get; }
				public SelectorColumnFilter ChangeOrderNumber { get; }
				public PXTextEditColumnFilter ReceiptDate { get; }
				public PXTextEditColumnFilter ReceiveDate { get; }
				public PXTextEditColumnFilter ReceivedBy { get; }
				public PXTextEditColumnFilter SecondaryVendorID { get; }
				public PXTextEditColumnFilter SecondaryVendorName { get; }
				public PXTextEditColumnFilter SourceType { get; }
				public PXTextEditColumnFilter SponsorOrganization { get; }
				public PXTextEditColumnFilter ThroughDate { get; }
				public SelectorColumnFilter DocumentTypeValue { get; }
                
                public c_grid_header(c_compliancedocuments_grdcompliancedocuments grid) : 
                        base(grid)
                {
                    ExpirationDate = new PXTextEditColumnFilter(grid.Row.ExpirationDate);
                    DocumentType = new PXTextEditColumnFilter(grid.Row.DocumentType);
                    CreationDate = new PXTextEditColumnFilter(grid.Row.CreationDate);
                    Status = new PXTextEditColumnFilter(grid.Row.Status);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    Received = new CheckBoxColumnFilter(grid.Row.Received);
                    ReceivedDate = new PXTextEditColumnFilter(grid.Row.ReceivedDate);
                    IsProcessed = new CheckBoxColumnFilter(grid.Row.IsProcessed);
                    IsVoided = new CheckBoxColumnFilter(grid.Row.IsVoided);
                    IsCreatedAutomatically = new CheckBoxColumnFilter(grid.Row.IsCreatedAutomatically);
                    SentDate = new PXTextEditColumnFilter(grid.Row.SentDate);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    CostTaskID = new SelectorColumnFilter(grid.Row.CostTaskID);
                    RevenueTaskID = new SelectorColumnFilter(grid.Row.RevenueTaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    VendorID = new PXTextEditColumnFilter(grid.Row.VendorID);
                    VendorName = new PXTextEditColumnFilter(grid.Row.VendorName);
                    BillID = new InputColumnFilter(grid.Row.BillID);
                    BillAmount = new PXTextEditColumnFilter(grid.Row.BillAmount);
                    AccountID = new PXTextEditColumnFilter(grid.Row.AccountID);
                    ApCheckID = new InputColumnFilter(grid.Row.ApCheckID);
                    CheckNumber = new PXTextEditColumnFilter(grid.Row.CheckNumber);
                    CustomerID = new PXTextEditColumnFilter(grid.Row.CustomerID);
                    CertificateNumber = new PXTextEditColumnFilter(grid.Row.CertificateNumber);
                    CreatedByID = new PXTextEditColumnFilter(grid.Row.CreatedByID);
                    CustomerName = new PXTextEditColumnFilter(grid.Row.CustomerName);
                    ArPaymentID = new InputColumnFilter(grid.Row.ArPaymentID);
                    DateIssued = new PXTextEditColumnFilter(grid.Row.DateIssued);
                    EffectiveDate = new PXTextEditColumnFilter(grid.Row.EffectiveDate);
                    InsuranceCompany = new PXTextEditColumnFilter(grid.Row.InsuranceCompany);
                    InvoiceAmount = new PXTextEditColumnFilter(grid.Row.InvoiceAmount);
                    InvoiceID = new InputColumnFilter(grid.Row.InvoiceID);
                    IsExpired = new CheckBoxColumnFilter(grid.Row.IsExpired);
                    IsRequiredJointCheck = new CheckBoxColumnFilter(grid.Row.IsRequiredJointCheck);
                    JointAmount = new PXTextEditColumnFilter(grid.Row.JointAmount);
                    JointRelease = new PXTextEditColumnFilter(grid.Row.JointRelease);
                    JointReleaseReceived = new CheckBoxColumnFilter(grid.Row.JointReleaseReceived);
                    JointVendorInternalId = new PXTextEditColumnFilter(grid.Row.JointVendorInternalId);
                    JointVendorExternalName = new PXTextEditColumnFilter(grid.Row.JointVendorExternalName);
                    LastModifiedByID = new PXTextEditColumnFilter(grid.Row.LastModifiedByID);
                    LienWaiverAmount = new PXTextEditColumnFilter(grid.Row.LienWaiverAmount);
                    Limit = new PXTextEditColumnFilter(grid.Row.Limit);
                    MethodSent = new PXTextEditColumnFilter(grid.Row.MethodSent);
                    PaymentDate = new PXTextEditColumnFilter(grid.Row.PaymentDate);
                    ArPaymentMethodID = new PXTextEditColumnFilter(grid.Row.ArPaymentMethodID);
                    ApPaymentMethodID = new PXTextEditColumnFilter(grid.Row.ApPaymentMethodID);
                    Policy = new PXTextEditColumnFilter(grid.Row.Policy);
                    ProjectTransactionID = new InputColumnFilter(grid.Row.ProjectTransactionID);
                    PurchaseOrder = new InputColumnFilter(grid.Row.PurchaseOrder);
                    PurchaseOrderLineItem = new SelectorColumnFilter(grid.Row.PurchaseOrderLineItem);
                    Subcontract = new SelectorColumnFilter(grid.Row.Subcontract);
                    SubcontractLineItem = new SelectorColumnFilter(grid.Row.SubcontractLineItem);
                    ChangeOrderNumber = new SelectorColumnFilter(grid.Row.ChangeOrderNumber);
                    ReceiptDate = new PXTextEditColumnFilter(grid.Row.ReceiptDate);
                    ReceiveDate = new PXTextEditColumnFilter(grid.Row.ReceiveDate);
                    ReceivedBy = new PXTextEditColumnFilter(grid.Row.ReceivedBy);
                    SecondaryVendorID = new PXTextEditColumnFilter(grid.Row.SecondaryVendorID);
                    SecondaryVendorName = new PXTextEditColumnFilter(grid.Row.SecondaryVendorName);
                    SourceType = new PXTextEditColumnFilter(grid.Row.SourceType);
                    SponsorOrganization = new PXTextEditColumnFilter(grid.Row.SponsorOrganization);
                    ThroughDate = new PXTextEditColumnFilter(grid.Row.ThroughDate);
                    DocumentTypeValue = new SelectorColumnFilter(grid.Row.DocumentTypeValue);
                }
            }
        }
        
        public class c_compliancedocuments_lv0 : Container
        {
            
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public Selector DocumentTypeValue { get; }
			public Label DocumentTypeValueLabel { get; }
			public Selector BillID { get; }
			public Label BillIDLabel { get; }
			public Selector InvoiceID { get; }
			public Label InvoiceIDLabel { get; }
			public Selector ApCheckID { get; }
			public Label ApCheckIDLabel { get; }
			public Selector ArPaymentID { get; }
			public Label ArPaymentIDLabel { get; }
			public Selector ProjectTransactionID { get; }
			public Label ProjectTransactionIDLabel { get; }
			public Selector PurchaseOrder { get; }
			public Label PurchaseOrderLabel { get; }
			public Selector PurchaseOrderLineItem { get; }
			public Label PurchaseOrderLineItemLabel { get; }
			public Selector Subcontract { get; }
			public Label SubcontractLabel { get; }
			public Selector SubcontractLineItem { get; }
			public Label SubcontractLineItemLabel { get; }
			public Selector ChangeOrderNumber { get; }
			public Label ChangeOrderNumberLabel { get; }
			public Selector CostTaskID { get; }
			public Label CostTaskIDLabel { get; }
			public Selector RevenueTaskID { get; }
			public Label RevenueTaskIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
            
            public c_compliancedocuments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CostCodeID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                DocumentTypeValue = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", locator, null);
                DocumentTypeValueLabel = new Label(DocumentTypeValue);
                DocumentTypeValue.DataField = "DocumentTypeValue";
                BillID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edBillID", "Bill ID", locator, null);
                BillIDLabel = new Label(BillID);
                BillID.DataField = "BillID";
                InvoiceID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", locator, null);
                InvoiceIDLabel = new Label(InvoiceID);
                InvoiceID.DataField = "InvoiceID";
                ApCheckID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", locator, null);
                ApCheckIDLabel = new Label(ApCheckID);
                ApCheckID.DataField = "ApCheckID";
                ArPaymentID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", locator, null);
                ArPaymentIDLabel = new Label(ArPaymentID);
                ArPaymentID.DataField = "ArPaymentID";
                ProjectTransactionID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", locator, null);
                ProjectTransactionIDLabel = new Label(ProjectTransactionID);
                ProjectTransactionID.DataField = "ProjectTransactionID";
                PurchaseOrder = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", locator, null);
                PurchaseOrderLabel = new Label(PurchaseOrder);
                PurchaseOrder.DataField = "PurchaseOrder";
                PurchaseOrderLineItem = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", locator, null);
                PurchaseOrderLineItemLabel = new Label(PurchaseOrderLineItem);
                PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                Subcontract = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", locator, null);
                SubcontractLabel = new Label(Subcontract);
                Subcontract.DataField = "Subcontract";
                SubcontractLineItem = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", locator, null);
                SubcontractLineItemLabel = new Label(SubcontractLineItem);
                SubcontractLineItem.DataField = "SubcontractLineItem";
                ChangeOrderNumber = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", locator, null);
                ChangeOrderNumberLabel = new Label(ChangeOrderNumber);
                ChangeOrderNumber.DataField = "ChangeOrderNumber";
                CostTaskID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", locator, null);
                CostTaskIDLabel = new Label(CostTaskID);
                CostTaskID.DataField = "CostTaskID";
                RevenueTaskID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", locator, null);
                RevenueTaskIDLabel = new Label(RevenueTaskID);
                RevenueTaskID.DataField = "RevenueTaskID";
                ProjectID = new Selector("ctl00_phG_tab_t8_grdComplianceDocuments_lv0_edProjectID", "Project ID", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                DataMemberName = "ComplianceDocuments";
            }
        }
        
        public class c_fsadjustments_detgridfs : Grid<c_fsadjustments_detgridfs.c_grid_row, c_fsadjustments_detgridfs.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_fsadjustments_detgridfs(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_detgridFS");
                DataMemberName = "FSAdjustments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_detgridFS_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_detgridFS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit AdjdOrderType { get; }
			public PXTextEdit AdjdOrderNbr { get; }
			public PXTextEdit FSServiceOrder__Status { get; }
			public PXTextEdit AdjdAppRefNbr { get; }
			public PXTextEdit AdjdOrderDate { get; }
			public PXTextEdit FSServiceOrder__DocDesc { get; }
			public PXTextEdit FSServiceOrder__CuryDocTotal { get; }
			public PXTextEdit SOCuryCompletedBillableTotal { get; }
			public PXTextEdit FSServiceOrder__CuryID { get; }
                
                public c_grid_row(c_fsadjustments_detgridfs grid) : 
                        base(grid)
                {
                    AdjdOrderType = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "Adjd Order Type", grid.Locator, "AdjdOrderType");
                    AdjdOrderType.DataField = "AdjdOrderType";
                    AdjdOrderNbr = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "Adjd Order Nbr", grid.Locator, "AdjdOrderNbr");
                    AdjdOrderNbr.DataField = "AdjdOrderNbr";
                    FSServiceOrder__Status = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "FS Service Order __ Status", grid.Locator, "FSServiceOrder__Status");
                    FSServiceOrder__Status.DataField = "FSServiceOrder__Status";
                    AdjdAppRefNbr = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "Adjd App Ref Nbr", grid.Locator, "AdjdAppRefNbr");
                    AdjdAppRefNbr.DataField = "AdjdAppRefNbr";
                    AdjdOrderDate = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "Adjd Order Date", grid.Locator, "AdjdOrderDate");
                    AdjdOrderDate.DataField = "AdjdOrderDate";
                    FSServiceOrder__DocDesc = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "FS Service Order __ Doc Desc", grid.Locator, "FSServiceOrder__DocDesc");
                    FSServiceOrder__DocDesc.DataField = "FSServiceOrder__DocDesc";
                    FSServiceOrder__CuryDocTotal = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "FS Service Order __ Cury Doc Total", grid.Locator, "FSServiceOrder__CuryDocTotal");
                    FSServiceOrder__CuryDocTotal.DataField = "FSServiceOrder__CuryDocTotal";
                    SOCuryCompletedBillableTotal = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "SO Cury Completed Billable Total", grid.Locator, "SOCuryCompletedBillableTotal");
                    SOCuryCompletedBillableTotal.DataField = "SOCuryCompletedBillableTotal";
                    FSServiceOrder__CuryID = new PXTextEdit("ctl00_phG_tab_t3_detgridFS_ei", "FS Service Order __ Cury ID", grid.Locator, "FSServiceOrder__CuryID");
                    FSServiceOrder__CuryID.DataField = "FSServiceOrder__CuryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter AdjdOrderType { get; }
				public PXTextEditColumnFilter AdjdOrderNbr { get; }
				public PXTextEditColumnFilter FSServiceOrder__Status { get; }
				public PXTextEditColumnFilter AdjdAppRefNbr { get; }
				public PXTextEditColumnFilter AdjdOrderDate { get; }
				public PXTextEditColumnFilter FSServiceOrder__DocDesc { get; }
				public PXTextEditColumnFilter FSServiceOrder__CuryDocTotal { get; }
				public PXTextEditColumnFilter SOCuryCompletedBillableTotal { get; }
				public PXTextEditColumnFilter FSServiceOrder__CuryID { get; }
                
                public c_grid_header(c_fsadjustments_detgridfs grid) : 
                        base(grid)
                {
                    AdjdOrderType = new PXTextEditColumnFilter(grid.Row.AdjdOrderType);
                    AdjdOrderNbr = new PXTextEditColumnFilter(grid.Row.AdjdOrderNbr);
                    FSServiceOrder__Status = new PXTextEditColumnFilter(grid.Row.FSServiceOrder__Status);
                    AdjdAppRefNbr = new PXTextEditColumnFilter(grid.Row.AdjdAppRefNbr);
                    AdjdOrderDate = new PXTextEditColumnFilter(grid.Row.AdjdOrderDate);
                    FSServiceOrder__DocDesc = new PXTextEditColumnFilter(grid.Row.FSServiceOrder__DocDesc);
                    FSServiceOrder__CuryDocTotal = new PXTextEditColumnFilter(grid.Row.FSServiceOrder__CuryDocTotal);
                    SOCuryCompletedBillableTotal = new PXTextEditColumnFilter(grid.Row.SOCuryCompletedBillableTotal);
                    FSServiceOrder__CuryID = new PXTextEditColumnFilter(grid.Row.FSServiceOrder__CuryID);
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
