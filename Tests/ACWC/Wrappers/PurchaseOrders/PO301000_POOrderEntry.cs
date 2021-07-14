using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CheckBoxButton;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.EmailEdit;
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
    
    
    public class PO301000_POOrderEntry : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
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
        protected c__poorder_currencyinfo__rf _POOrder_CurrencyInfo__rf { get; } = new c__poorder_currencyinfo__rf("ctl00_phF_form_t0_edCury_pnlRate_rf", "_POOrder_CurrencyInfo__rf");
        protected c_currentdocument_tab CurrentDocument_tab { get; } = new c_currentdocument_tab("ctl00_phG_tab", "CurrentDocument_tab");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "Transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "Transactions_lv0");
        protected c_taxes_gridtaxes Taxes_gridTaxes { get; } = new c_taxes_gridtaxes("ctl00_phG_tab_t1_gridTaxes", "Taxes_gridTaxes");
        protected c_taxes_lv0 Taxes_lv0 { get; } = new c_taxes_lv0("ctl00_phG_tab_t1_gridTaxes_lv0", "Taxes_lv0");
        protected c_discountdetails_formdiscountdetail DiscountDetails_formDiscountDetail { get; } = new c_discountdetails_formdiscountdetail("ctl00_phG_tab_t5_formDiscountDetail", "DiscountDetails_formDiscountDetail");
        protected c_discountdetails_lv0 DiscountDetails_lv0 { get; } = new c_discountdetails_lv0("ctl00_phG_tab_t5_formDiscountDetail_lv0", "DiscountDetails_lv0");
        protected c_remit_address_formva Remit_Address_formVA { get; } = new c_remit_address_formva("ctl00_phG_tab_t3_formVA", "Remit_Address_formVA");
        protected c_remit_contact_formvc Remit_Contact_formVC { get; } = new c_remit_contact_formvc("ctl00_phG_tab_t3_formVC", "Remit_Contact_formVC");
        protected c_shipping_address_formsa Shipping_Address_formSA { get; } = new c_shipping_address_formsa("ctl00_phG_tab_t2_formSA", "Shipping_Address_formSA");
        protected c_shipping_contact_formsc Shipping_Contact_formSC { get; } = new c_shipping_contact_formsc("ctl00_phG_tab_t2_formSC", "Shipping_Contact_formSC");
        protected c_approval_gridapproval Approval_gridApproval { get; } = new c_approval_gridapproval("ctl00_phG_tab_t4_gridApproval", "Approval_gridApproval");
        protected c_approval_lv0 Approval_lv0 { get; } = new c_approval_lv0("ctl00_phG_tab_t4_gridApproval_lv0", "Approval_lv0");
        protected c_replenishmentlines_gridreplenishmentlines ReplenishmentLines_gridReplenishmentLines { get; } = new c_replenishmentlines_gridreplenishmentlines("ctl00_phDS_PanelReplenishment_gridReplenishmentLines", "ReplenishmentLines_gridReplenishmentLines");
        protected c_replenishmentlines_lv0 ReplenishmentLines_lv0 { get; } = new c_replenishmentlines_lv0("ctl00_phDS_PanelReplenishment_gridReplenishmentLines_lv0", "ReplenishmentLines_lv0");
        protected c_receipts_formreceipts Receipts_formReceipts { get; } = new c_receipts_formreceipts("ctl00_phG_tab_t6_sp1_formReceipts", "Receipts_formReceipts");
        protected c_receipts_lv0 Receipts_lv0 { get; } = new c_receipts_lv0("ctl00_phG_tab_t6_sp1_formReceipts_lv0", "Receipts_lv0");
        protected c_apdocs_formapdocs APDocs_formAPDocs { get; } = new c_apdocs_formapdocs("ctl00_phG_tab_t6_sp1_formAPDocs", "APDocs_formAPDocs");
        protected c_apdocs_lv0 APDocs_lv0 { get; } = new c_apdocs_lv0("ctl00_phG_tab_t6_sp1_formAPDocs_lv0", "APDocs_lv0");
        protected c_sitestatusfilter_formsitesstatus Sitestatusfilter_formsitesstatus { get; } = new c_sitestatusfilter_formsitesstatus("ctl00_phG_PanelAddSiteStatus_formSitesStatus", "sitestatusfilter_formSitesStatus");
        protected c_sitestatus_gripsitestatus Sitestatus_gripsitestatus { get; } = new c_sitestatus_gripsitestatus("ctl00_phG_PanelAddSiteStatus_gripSiteStatus", "siteStatus_gripSiteStatus");
        protected c_sitestatus_lv0 Sitestatus_lv0 { get; } = new c_sitestatus_lv0("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0", "siteStatus_lv0");
        protected c_filter_frmpofilter Filter_frmpofilter { get; } = new c_filter_frmpofilter("ctl00_phDS_PanelAddPOLine_frmPOFilter", "filter_frmPOFilter");
        protected c_polinesselection_gridol Polinesselection_gridol { get; } = new c_polinesselection_gridol("ctl00_phDS_PanelAddPOLine_gridOL", "poLinesSelection_gridOL");
        protected c_polinesselection_lv0 Polinesselection_lv0 { get; } = new c_polinesselection_lv0("ctl00_phDS_PanelAddPOLine_gridOL_lv0", "poLinesSelection_lv0");
        protected c_openorders_grdopenorders Openorders_grdopenorders { get; } = new c_openorders_grdopenorders("ctl00_phDS_PanelAddPO_grdOpenOrders", "openOrders_grdOpenOrders");
        protected c_openorders_lv0 Openorders_lv0 { get; } = new c_openorders_lv0("ctl00_phDS_PanelAddPO_grdOpenOrders_lv0", "openOrders_lv0");
        protected c_fixeddemand_gridfixeddemand FixedDemand_gridFixedDemand { get; } = new c_fixeddemand_gridfixeddemand("ctl00_phDS_PanelFixedDemand_gridFixedDemand", "FixedDemand_gridFixedDemand");
        protected c_fixeddemand_lv0 FixedDemand_lv0 { get; } = new c_fixeddemand_lv0("ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0", "FixedDemand_lv0");
        protected c_recalcdiscountsfilter_formrecalcdiscounts Recalcdiscountsfilter_formrecalcdiscounts { get; } = new c_recalcdiscountsfilter_formrecalcdiscounts("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts", "recalcdiscountsfilter_formRecalcDiscounts");
        protected c_matrix_matrixmatrix Matrix_MatrixMatrix { get; } = new c_matrix_matrixmatrix("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix", "Matrix_MatrixMatrix");
        protected c_changeorders_changeordersgrid ChangeOrders_ChangeOrdersGrid { get; } = new c_changeorders_changeordersgrid("ctl00_phG_tab_t8_ChangeOrdersGrid", "ChangeOrders_ChangeOrdersGrid");
        protected c_changeorders_lv0 ChangeOrders_lv0 { get; } = new c_changeorders_lv0("ctl00_phG_tab_t8_ChangeOrdersGrid_lv0", "ChangeOrders_lv0");
        protected c_prepaymentdocuments_prepaymentgrid PrepaymentDocuments_PrepaymentGrid { get; } = new c_prepaymentdocuments_prepaymentgrid("ctl00_phG_tab_t7_PrepaymentGrid", "PrepaymentDocuments_PrepaymentGrid");
        protected c_prepaymentdocuments_lv0 PrepaymentDocuments_lv0 { get; } = new c_prepaymentdocuments_lv0("ctl00_phG_tab_t7_PrepaymentGrid_lv0", "PrepaymentDocuments_lv0");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_reasonapproverejectparams_pxformviewpanelreason ReasonApproveRejectParams_PXFormViewPanelReason { get; } = new c_reasonapproverejectparams_pxformviewpanelreason("ctl00_phG_panelReason_PXFormViewPanelReason", "ReasonApproveRejectParams_PXFormViewPanelReason");
        protected c_header_matrixentryformview Header_MatrixEntryFormView { get; } = new c_header_matrixentryformview("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView", "Header_MatrixEntryFormView");
        protected c_header_matrixformview Header_MatrixFormView { get; } = new c_header_matrixformview("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView", "Header_MatrixFormView");
        protected c_additionalattributes_matrixattributes AdditionalAttributes_MatrixAttributes { get; } = new c_additionalattributes_matrixattributes("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes", "AdditionalAttributes_MatrixAttributes");
        protected c_additionalattributes_lv0 AdditionalAttributes_lv0 { get; } = new c_additionalattributes_lv0("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_lv0", "AdditionalAttributes_lv0");
        protected c_matrixitems_matrixitems MatrixItems_MatrixItems { get; } = new c_matrixitems_matrixitems("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems", "MatrixItems_MatrixItems");
        protected c_matrixitems_lv0 MatrixItems_lv0 { get; } = new c_matrixitems_lv0("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0", "MatrixItems_lv0");
        protected c_compliancedocuments_grdcompliancedocuments ComplianceDocuments_grdComplianceDocuments { get; } = new c_compliancedocuments_grdcompliancedocuments("ctl00_phG_tab_t10_grdComplianceDocuments", "ComplianceDocuments_grdComplianceDocuments");
        protected c_compliancedocuments_lv0 ComplianceDocuments_lv0 { get; } = new c_compliancedocuments_lv0("ctl00_phG_tab_t10_grdComplianceDocuments_lv0", "ComplianceDocuments_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_transactions_importcsvsettings_frmimportcsvsettings Transactions_ImportCSVSettings_frmImportCSVSettings { get; } = new c_transactions_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings", "Transactions$ImportCSVSettings_frmImportCSVSettings");
        protected c_transactions_importxlsxsettings_frmimportxlsxsettings Transactions_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_transactions_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "Transactions$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_transactions_importcolumns_grdimportcolumn Transactions_ImportColumns_grdImportColumn { get; } = new c_transactions_importcolumns_grdimportcolumn("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn", "Transactions$ImportColumns_grdImportColumn");
        protected c_transactions_importcolumns_lv0 Transactions_ImportColumns_lv0 { get; } = new c_transactions_importcolumns_lv0("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0", "Transactions$ImportColumns_lv0");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public PO301000_POOrderEntry()
        {
            ScreenId = "PO301000";
            ScreenUrl = "/Pages/PO/PO301000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual PO301000_POOrderEntry ReadOne(Gate gate, string OrderType, string OrderNbr)
        {
            new BiObject<PO301000_POOrderEntry>(gate).ReadOne(this, OrderType, OrderNbr);
            return this;
        }
        
        public virtual PO301000_POOrderEntry ReadOne(string OrderType, string OrderNbr)
        {
            return this.ReadOne(ApiConnection.Source, OrderType, OrderNbr);
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
        
        public virtual void ViewActivity()
        {
            ToolBar.ViewActivity.Click();
        }
        
        public virtual void OpenActivityOwner()
        {
            ToolBar.OpenActivityOwner.Click();
        }
        
        public virtual void ViewAllActivities()
        {
            ToolBar.ViewAllActivities.Click();
        }
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void Approve()
        {
            ToolBar.Approve.Click();
        }
        
        public virtual void Reject()
        {
            ToolBar.Reject.Click();
        }
        
        public virtual void EmailPurchaseOrder()
        {
            ToolBar.EmailPurchaseOrder.Click();
        }
        
        public virtual void MarkAsDoNotEmail()
        {
            ToolBar.MarkAsDoNotEmail.Click();
        }
        
        public virtual void EnterPoReceipt()
        {
            ToolBar.EnterPoReceipt.Click();
        }
        
        public virtual void EnterApBill()
        {
            ToolBar.EnterApBill.Click();
        }
        
        public virtual void CompleteOrder()
        {
            ToolBar.CompleteOrder.Click();
        }
        
        public virtual void CancelOrder()
        {
            ToolBar.CancelOrder.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void RecalculateDiscountsAction()
        {
            ToolBar.RecalculateDiscountsAction.Click();
        }
        
        public virtual void CreatePrepayment()
        {
            ToolBar.CreatePrepayment.Click();
        }
        
        public virtual void Complete()
        {
            ToolBar.Complete.Click();
        }
        
        public virtual void Notifications()
        {
            ToolBar.Notifications.Click();
        }
        
        public virtual void Reports()
        {
            ToolBar.Reports.Click();
        }
        
        public virtual void VendorDetails()
        {
            ToolBar.VendorDetails.Click();
        }
        
        public virtual void PrintPurchaseOrder()
        {
            ToolBar.PrintPurchaseOrder.Click();
        }
        
        public virtual void ViewPurchaseOrderReceiptAndBillingHistory()
        {
            ToolBar.ViewPurchaseOrderReceiptAndBillingHistory.Click();
        }
        
        public virtual void CreateAPInvoice()
        {
            ToolBar.CreateAPInvoice.Click();
        }
        
        public virtual void CreateAPInvoice(bool status, string message = null)
        {
            ToolBar.CreateAPInvoice.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreateAPInvoice.Click();
        }
        
        public virtual void MatrixGridCellChanged()
        {
            ToolBar.MatrixGridCellChanged.Click();
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
			public ToolBarButton ViewActivity { get; }
			public ToolBarButton OpenActivityOwner { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton Approve { get; }
			public ToolBarButton Reject { get; }
			public ToolBarButton EmailPurchaseOrder { get; }
			public ToolBarButton MarkAsDoNotEmail { get; }
			public ToolBarButton EnterPoReceipt { get; }
			public ToolBarButton EnterApBill { get; }
			public ToolBarButton CompleteOrder { get; }
			public ToolBarButton CancelOrder { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton RecalculateDiscountsAction { get; }
			public ToolBarButton CreatePrepayment { get; }
			public ToolBarButton Complete { get; }
			public ToolBarButton Notifications { get; }
			public ToolBarButton Reports { get; }
			public ToolBarButton VendorDetails { get; }
			public ToolBarButton PrintPurchaseOrder { get; }
			public ToolBarButton ViewPurchaseOrderReceiptAndBillingHistory { get; }
			public ToolBarButton CreateAPInvoice { get; }
			public ToolBarButton MatrixGridCellChanged { get; }
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
                ViewActivity = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewActivity\']", "Details", locator, null);
                OpenActivityOwner = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'OpenActivityOwner\']", "OpenActivityOwner", locator, null);
                ViewAllActivities = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewAllActivities\']", "View Activities", locator, null);
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                Approve = new ToolBarButton("css=li[data-cmd=\'Action@Approve\']", "Approve", locator, Actions);
                Reject = new ToolBarButton("css=li[data-cmd=\'Action@Reject\']", "Reject", locator, Actions);
                EmailPurchaseOrder = new ToolBarButton("css=li[data-cmd=\'Action@Email Purchase Order\']", "Email Purchase Order", locator, Actions);
                MarkAsDoNotEmail = new ToolBarButton("css=li[data-cmd=\'Action@Mark as Do not Email\']", "Mark as Do not Email", locator, Actions);
                EnterPoReceipt = new ToolBarButton("css=li[data-cmd=\'Action@Enter PO Receipt\']", "Enter PO Receipt", locator, Actions);
                EnterApBill = new ToolBarButton("css=li[data-cmd=\'Action@Enter AP Bill\']", "Enter AP Bill", locator, Actions);
                CompleteOrder = new ToolBarButton("css=li[data-cmd=\'Action@Complete Order\']", "Complete Order", locator, Actions);
                CancelOrder = new ToolBarButton("css=li[data-cmd=\'Action@Cancel Order\']", "Cancel Order", locator, Actions);
                ValidateAddresses = new ToolBarButton("css=li[data-cmd=\'Action@ValidateAddresses\']", "Validate Addresses", locator, Actions);
                RecalculateDiscountsAction = new ToolBarButton("css=li[data-cmd=\'Action@RecalculateDiscountsAction\']", "Recalculate Prices", locator, Actions);
                CreatePrepayment = new ToolBarButton("css=li[data-cmd=\'Action@CreatePrepayment\']", "Create Prepayment Request", locator, Actions);
                Complete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Complete\']", "Complete", locator, null);
                Notifications = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Notifications\") > div[data-type=\'drop\']" +
                        "", "Notifications", locator, null);
                Reports = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                VendorDetails = new ToolBarButton("css=li[data-cmd=\'Report@Vendor Details\']", "Vendor Details", locator, Reports);
                PrintPurchaseOrder = new ToolBarButton("css=li[data-cmd=\'Report@Print Purchase Order\']", "Print Purchase Order", locator, Reports);
                ViewPurchaseOrderReceiptAndBillingHistory = new ToolBarButton("css=li[data-cmd=\'Report@View Purchase Order Receipt and Billing History\']", "View Purchase Order Receipt and Billing History", locator, Reports);
                CreateAPInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateAPInvoice\']", "Enter AP Bill", locator, null);
                CreateAPInvoice.WaitAction = Wait.WaitForLongOperationToComplete;
                MatrixGridCellChanged = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'matrixGridCellChanged\']", "matrixGridCellChanged", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_document_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public CheckBox Hold { get; }
			public Label HoldLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public DropDown Behavior { get; }
			public Label BehaviorLabel { get; }
			public CheckBox RequestApproval { get; }
			public Label RequestApprovalLabel { get; }
			public CheckBox Approved { get; }
			public Label ApprovedLabel { get; }
			public DateSelector OrderDate { get; }
			public Label OrderDateLabel { get; }
			public DateSelector ExpectedDate { get; }
			public Label ExpectedDateLabel { get; }
			public DateSelector ExpirationDate { get; }
			public Label ExpirationDateLabel { get; }
			public PXTextEdit OrderDesc { get; }
			public Label OrderDescLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public Selector EmployeeID { get; }
			public Label EmployeeIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public PXTextEdit VendorRefNbr { get; }
			public Label VendorRefNbrLabel { get; }
			public PXNumberEdit CuryLineTotal { get; }
			public Label CuryLineTotalLabel { get; }
			public PXNumberEdit CuryDiscTot { get; }
			public Label CuryDiscTotLabel { get; }
			public PXNumberEdit CuryVatExemptTotal { get; }
			public Label CuryVatExemptTotalLabel { get; }
			public PXNumberEdit CuryVatTaxableTotal { get; }
			public Label CuryVatTaxableTotalLabel { get; }
			public PXNumberEdit CuryTaxTotal { get; }
			public Label CuryTaxTotalLabel { get; }
			public PXNumberEdit CuryRetainageTotal { get; }
			public Label CuryRetainageTotalLabel { get; }
			public PXNumberEdit CuryOrderTotal { get; }
			public Label CuryOrderTotalLabel { get; }
			public PXNumberEdit CuryControlTotal { get; }
			public Label CuryControlTotalLabel { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
            
            public c_document_form(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new DropDown("ctl00_phF_form_t0_edOrderType", "Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderType.Items.Add("RO", "Normal");
                OrderType.Items.Add("DP", "Drop Ship");
                OrderType.Items.Add("BL", "Blanket");
                OrderType.Items.Add("SB", "Standard");
                OrderNbr = new Selector("ctl00_phF_form_t0_edOrderNbr", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                Hold = new CheckBox("ctl00_phF_form_t0_chkHold", "Hold", locator, null);
                HoldLabel = new Label(Hold);
                Hold.DataField = "Hold";
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("B", "Pending Approval");
                Status.Items.Add("V", "Rejected");
                Status.Items.Add("N", "Open");
                Status.Items.Add("D", "Pending Printing");
                Status.Items.Add("E", "Pending Email");
                Status.Items.Add("L", "Canceled");
                Status.Items.Add("M", "Completed");
                Status.Items.Add("C", "Closed");
                Status.Items.Add("P", "Printed");
                Behavior = new DropDown("ctl00_phF_form_t0_edBehavior", "Workflow", locator, null);
                BehaviorLabel = new Label(Behavior);
                Behavior.DataField = "Behavior";
                Behavior.Items.Add("S", "Standard");
                Behavior.Items.Add("C", "Change Order");
                RequestApproval = new CheckBox("ctl00_phF_form_t0_chkRequestApproval", "Request Approval", locator, null);
                RequestApprovalLabel = new Label(RequestApproval);
                RequestApproval.DataField = "RequestApproval";
                Approved = new CheckBox("ctl00_phF_form_t0_chkApproved", "Approved", locator, null);
                ApprovedLabel = new Label(Approved);
                Approved.DataField = "Approved";
                OrderDate = new DateSelector("ctl00_phF_form_t0_edOrderDate", "Date", locator, null);
                OrderDateLabel = new Label(OrderDate);
                OrderDate.DataField = "OrderDate";
                ExpectedDate = new DateSelector("ctl00_phF_form_t0_edExpectedDate", "Promised On", locator, null);
                ExpectedDateLabel = new Label(ExpectedDate);
                ExpectedDate.DataField = "ExpectedDate";
                ExpirationDate = new DateSelector("ctl00_phF_form_t0_edExpirationDate", "Expires On", locator, null);
                ExpirationDateLabel = new Label(ExpirationDate);
                ExpirationDate.DataField = "ExpirationDate";
                OrderDesc = new PXTextEdit("ctl00_phF_form_t0_edOrderDesc", "Description", locator, null);
                OrderDescLabel = new Label(OrderDesc);
                OrderDesc.DataField = "OrderDesc";
                VendorID = new Selector("ctl00_phF_form_t0_edVendorID", "Vendor", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                VendorLocationID = new Selector("ctl00_phF_form_t0_edVendorLocationID", "Location", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                EmployeeID = new Selector("ctl00_phF_form_t0_edEmployeeID", "Owner", locator, null);
                EmployeeIDLabel = new Label(EmployeeID);
                EmployeeID.DataField = "EmployeeID";
                ProjectID = new Selector("ctl00_phF_form_t0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                CuryID = new Selector("ctl00_phF_form_t0_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_t0_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                VendorRefNbr = new PXTextEdit("ctl00_phF_form_t0_edVendorRefNbr", "Vendor Ref.", locator, null);
                VendorRefNbrLabel = new Label(VendorRefNbr);
                VendorRefNbr.DataField = "VendorRefNbr";
                CuryLineTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryLineTotal", "Line Total", locator, null);
                CuryLineTotalLabel = new Label(CuryLineTotal);
                CuryLineTotal.DataField = "CuryLineTotal";
                CuryDiscTot = new PXNumberEdit("ctl00_phF_form_t0_edCuryDiscTot", "Discount Total", locator, null);
                CuryDiscTotLabel = new Label(CuryDiscTot);
                CuryDiscTot.DataField = "CuryDiscTot";
                CuryVatExemptTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryVatExemptTotal", "VAT Exempt Total", locator, null);
                CuryVatExemptTotalLabel = new Label(CuryVatExemptTotal);
                CuryVatExemptTotal.DataField = "CuryVatExemptTotal";
                CuryVatTaxableTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryVatTaxableTotal", "VAT Taxable Total", locator, null);
                CuryVatTaxableTotalLabel = new Label(CuryVatTaxableTotal);
                CuryVatTaxableTotal.DataField = "CuryVatTaxableTotal";
                CuryTaxTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryTaxTotal", "Tax Total", locator, null);
                CuryTaxTotalLabel = new Label(CuryTaxTotal);
                CuryTaxTotal.DataField = "CuryTaxTotal";
                CuryRetainageTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryRetainageTotal", "Retainage Total", locator, null);
                CuryRetainageTotalLabel = new Label(CuryRetainageTotal);
                CuryRetainageTotal.DataField = "CuryRetainageTotal";
                CuryOrderTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrderTotal", "Order Total", locator, null);
                CuryOrderTotalLabel = new Label(CuryOrderTotal);
                CuryOrderTotal.DataField = "CuryOrderTotal";
                CuryControlTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryControlTotal", "Control Total", locator, null);
                CuryControlTotalLabel = new Label(CuryControlTotal);
                CuryControlTotal.DataField = "CuryControlTotal";
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
            
            public virtual void VendorIDEdit()
            {
                Buttons.VendorIDEdit.Click();
            }
            
            public virtual void ProjectIDEdit()
            {
                Buttons.ProjectIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
			public Button VendorIDEdit { get; }
			public Button ProjectIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phF_form_t0_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_t0_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                    VendorIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edVendorID\'] div[class=\'editBtnCont\'] > div > div", "VendorIDEdit", "ctl00_phF_form");
                    VendorIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ProjectIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edProjectID\'] div[class=\'editBtnCont\'] > div > div", "ProjectIDEdit", "ctl00_phF_form");
                    ProjectIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c__poorder_currencyinfo__rf : Container
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
            
            public c__poorder_currencyinfo__rf(string locator, string name) : 
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
                DataMemberName = "_POOrder_CurrencyInfo_";
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
        
        public class c_currentdocument_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown ShipDestType { get; }
			public Label ShipDestTypeLabel { get; }
			public Selector ShipToBAccountID { get; }
			public Label ShipToBAccountIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector ShipToLocationID { get; }
			public Label ShipToLocationIDLabel { get; }
			public Selector FOBPoint { get; }
			public Label FOBPointLabel { get; }
			public Selector ShipVia { get; }
			public Label ShipViaLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public Selector PayToVendorID { get; }
			public Label PayToVendorIDLabel { get; }
			public PXNumberEdit PrepaymentPct { get; }
			public Label PrepaymentPctLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector SOOrderType { get; }
			public Label SOOrderTypeLabel { get; }
			public Selector SOOrderNbr { get; }
			public Label SOOrderNbrLabel { get; }
			public Selector RQReqNbr { get; }
			public Label RQReqNbrLabel { get; }
			public Selector OwnerWorkgroupID { get; }
			public Label OwnerWorkgroupIDLabel { get; }
			public CheckBox DontPrint { get; }
			public Label DontPrintLabel { get; }
			public CheckBox Printed { get; }
			public Label PrintedLabel { get; }
			public CheckBox DontEmail { get; }
			public Label DontEmailLabel { get; }
			public CheckBox Emailed { get; }
			public Label EmailedLabel { get; }
			public CheckBox OrderBasedAPBill { get; }
			public Label OrderBasedAPBillLabel { get; }
			public CheckBox RetainageApply { get; }
			public Label RetainageApplyLabel { get; }
			public PXNumberEdit DefRetainagePct { get; }
			public Label DefRetainagePctLabel { get; }
			public PXNumberEdit UnbilledOrderQty { get; }
			public Label UnbilledOrderQtyLabel { get; }
			public PXNumberEdit CuryUnbilledOrderTotal { get; }
			public Label CuryUnbilledOrderTotalLabel { get; }
			public PXNumberEdit CuryPrepaidTotal { get; }
			public Label CuryPrepaidTotalLabel { get; }
			public PXNumberEdit CuryUnprepaidTotal { get; }
			public Label CuryUnprepaidTotalLabel { get; }
			public Label Label1_importColumnDlg { get; }
			public Label LblImportSource_ { get; }
			public Label LblPassword_ { get; }
            
            public c_currentdocument_tab(string locator, string name) : 
                    base(locator, name)
            {
                ShipDestType = new DropDown("ctl00_phG_tab_t2_edShipDestType", "Shipping Destination Type", locator, null);
                ShipDestTypeLabel = new Label(ShipDestType);
                ShipDestType.DataField = "ShipDestType";
                ShipDestType.Items.Add("L", "Branch");
                ShipDestType.Items.Add("C", "Customer");
                ShipDestType.Items.Add("V", "Vendor");
                ShipDestType.Items.Add("S", "Warehouse");
                ShipToBAccountID = new Selector("ctl00_phG_tab_t2_edShipToBAccountID", "Ship To", locator, null);
                ShipToBAccountIDLabel = new Label(ShipToBAccountID);
                ShipToBAccountID.DataField = "ShipToBAccountID";
                SiteID = new Selector("ctl00_phG_tab_t2_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                ShipToLocationID = new Selector("ctl00_phG_tab_t2_edShipToLocationID", "Shipping Location", locator, null);
                ShipToLocationIDLabel = new Label(ShipToLocationID);
                ShipToLocationID.DataField = "ShipToLocationID";
                FOBPoint = new Selector("ctl00_phG_tab_t2_edFOBPoint", "FOB Point", locator, null);
                FOBPointLabel = new Label(FOBPoint);
                FOBPoint.DataField = "FOBPoint";
                ShipVia = new Selector("ctl00_phG_tab_t2_edShipVia", "Ship Via", locator, null);
                ShipViaLabel = new Label(ShipVia);
                ShipVia.DataField = "ShipVia";
                TermsID = new Selector("ctl00_phG_tab_t3_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                TaxZoneID = new Selector("ctl00_phG_tab_t3_edTaxZoneID", "Vendor Tax Zone", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                TaxCalcMode = new DropDown("ctl00_phG_tab_t3_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                PayToVendorID = new Selector("ctl00_phG_tab_t3_edPayToVendorID", "Pay-to Vendor", locator, null);
                PayToVendorIDLabel = new Label(PayToVendorID);
                PayToVendorID.DataField = "PayToVendorID";
                PrepaymentPct = new PXNumberEdit("ctl00_phG_tab_t3_edPrepaymentPct", "Prepayment Percent", locator, null);
                PrepaymentPctLabel = new Label(PrepaymentPct);
                PrepaymentPct.DataField = "PrepaymentPct";
                BranchID = new Selector("ctl00_phG_tab_t9_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                SOOrderType = new Selector("ctl00_phG_tab_t9_edSOOrderType", "Sales Order Type", locator, null);
                SOOrderTypeLabel = new Label(SOOrderType);
                SOOrderType.DataField = "SOOrderType";
                SOOrderNbr = new Selector("ctl00_phG_tab_t9_edSOOrderNbr", "Sales Order Nbr.", locator, null);
                SOOrderNbrLabel = new Label(SOOrderNbr);
                SOOrderNbr.DataField = "SOOrderNbr";
                RQReqNbr = new Selector("ctl00_phG_tab_t9_edRQReqNbr", "Requisition Ref. Nbr.", locator, null);
                RQReqNbrLabel = new Label(RQReqNbr);
                RQReqNbr.DataField = "RQReqNbr";
                OwnerWorkgroupID = new Selector("ctl00_phG_tab_t9_edOwnerWorkgroupID", "Workgroup ID", locator, null);
                OwnerWorkgroupIDLabel = new Label(OwnerWorkgroupID);
                OwnerWorkgroupID.DataField = "OwnerWorkgroupID";
                DontPrint = new CheckBox("ctl00_phG_tab_t9_chkDontPrint", "Don\'t Print", locator, null);
                DontPrintLabel = new Label(DontPrint);
                DontPrint.DataField = "DontPrint";
                Printed = new CheckBox("ctl00_phG_tab_t9_chkPrinted", "Printed", locator, null);
                PrintedLabel = new Label(Printed);
                Printed.DataField = "Printed";
                DontEmail = new CheckBox("ctl00_phG_tab_t9_chkDontEmail", "Don\'t Email", locator, null);
                DontEmailLabel = new Label(DontEmail);
                DontEmail.DataField = "DontEmail";
                Emailed = new CheckBox("ctl00_phG_tab_t9_chkEmailed", "Emailed", locator, null);
                EmailedLabel = new Label(Emailed);
                Emailed.DataField = "Emailed";
                OrderBasedAPBill = new CheckBox("ctl00_phG_tab_t9_chkOrderBasedAPBill", "Allow AP Bill Before Receipt", locator, null);
                OrderBasedAPBillLabel = new Label(OrderBasedAPBill);
                OrderBasedAPBill.DataField = "OrderBasedAPBill";
                RetainageApply = new CheckBox("ctl00_phG_tab_t9_chkRetainageApply", "Apply Retainage", locator, null);
                RetainageApplyLabel = new Label(RetainageApply);
                RetainageApply.DataField = "RetainageApply";
                DefRetainagePct = new PXNumberEdit("ctl00_phG_tab_t9_edDefRetainagePct", "Retainage Percent", locator, null);
                DefRetainagePctLabel = new Label(DefRetainagePct);
                DefRetainagePct.DataField = "DefRetainagePct";
                UnbilledOrderQty = new PXNumberEdit("ctl00_phG_tab_t9_edUnbilledOrderQty", "Unbilled Quantity", locator, null);
                UnbilledOrderQtyLabel = new Label(UnbilledOrderQty);
                UnbilledOrderQty.DataField = "UnbilledOrderQty";
                CuryUnbilledOrderTotal = new PXNumberEdit("ctl00_phG_tab_t9_edCuryUnbilledOrderTotal", "Unbilled Amount", locator, null);
                CuryUnbilledOrderTotalLabel = new Label(CuryUnbilledOrderTotal);
                CuryUnbilledOrderTotal.DataField = "CuryUnbilledOrderTotal";
                CuryPrepaidTotal = new PXNumberEdit("ctl00_phG_tab_t9_edCuryPrepaidTotal", "Unbilled Prepayment Total", locator, null);
                CuryPrepaidTotalLabel = new Label(CuryPrepaidTotal);
                CuryPrepaidTotal.DataField = "CuryPrepaidTotal";
                CuryUnprepaidTotal = new PXNumberEdit("ctl00_phG_tab_t9_edCuryUnprepaidTotal", "Unpaid Amount", locator, null);
                CuryUnprepaidTotalLabel = new Label(CuryUnprepaidTotal);
                CuryUnprepaidTotal.DataField = "CuryUnprepaidTotal";
                Label1_importColumnDlg = new Label("ctl00_phG_tab_t0_grid_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_ = new Label("ctl00_phG_tab_t0_grid_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_ = new Label("ctl00_phG_tab_t0_grid_imp_upl_pnl_lblPassword", "Password:", locator, null);
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PayToVendorIDEdit()
            {
                Buttons.PayToVendorIDEdit.Click();
            }
            
            public virtual void SOOrderNbrEdit()
            {
                Buttons.SOOrderNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PayToVendorIDEdit { get; }
			public Button SOOrderNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    PayToVendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_edPayToVendorID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "PayToVendorIDEdit", "ctl00_phG_tab");
                    PayToVendorIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SOOrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t9_edSOOrderNbr\'] div[class=\'editBtnCont\'] > div > div", "SOOrderNbrEdit", "ctl00_phG_tab");
                    SOOrderNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_transactions_grid : Grid<c_transactions_grid.c_grid_row, c_transactions_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_transactions_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "Transactions";
                Buttons = new PxButtonCollection();
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
            
            public virtual void FormView()
            {
                ToolBar.FormView.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void AddItem()
            {
                ToolBar.AddItem.Click();
            }
            
            public virtual void ShowMatrixPanel()
            {
                ToolBar.ShowMatrixPanel.Click();
            }
            
            public virtual void ViewDemand()
            {
                ToolBar.ViewDemand.Click();
            }
            
            public virtual void AddBlanketPo()
            {
                ToolBar.AddBlanketPo.Click();
            }
            
            public virtual void AddBlanketPoLine()
            {
                ToolBar.AddBlanketPoLine.Click();
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
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void PONbrEdit()
            {
                Buttons.PONbrEdit.Click();
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
			public ToolBarButtonGrid FormView { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid AddItem { get; }
			public ToolBarButtonGrid ShowMatrixPanel { get; }
			public ToolBarButtonGrid ViewDemand { get; }
			public ToolBarButtonGrid AddBlanketPo { get; }
			public ToolBarButtonGrid AddBlanketPoLine { get; }
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
                    FormView = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'EditRecord\']", "Switch Between Grid and Form", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    AddItem = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdASI\']", "Add Item", locator, null);
                    ShowMatrixPanel = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ShowMatrixPanel\']", "Add Matrix Item", locator, null);
                    ViewDemand = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ViewDemand\']", "View SO Demand", locator, null);
                    AddBlanketPo = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdPO\']", "Add Blanket PO", locator, null);
                    AddBlanketPoLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdAddPOLine\']", "Add Blanket PO Line", locator, null);
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
                
			public Button DiscountIDEdit { get; }
			public Button PONbrEdit { get; }
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
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDiscountCode\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PONbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edPONbr\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "PONbrEdit", "ctl00_phG_tab_t0_grid");
                    PONbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
			public DropDown LineType { get; }
			public Selector SiteID { get; }
			public PXTextEdit TranDesc { get; }
			public Selector UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit BaseOrderQty { get; }
			public PXNumberEdit ReceivedQty { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public CheckBox ManualPrice { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public PXNumberEdit DiscPct { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public PXNumberEdit CuryDiscCost { get; }
			public CheckBox ManualDisc { get; }
			public Selector DiscountID { get; }
			public PXTextEdit DiscountSequenceID { get; }
			public PXNumberEdit DisplayReqPrepaidQty { get; }
			public PXNumberEdit CuryReqPrepaidAmt { get; }
			public PXNumberEdit RetainagePct { get; }
			public PXNumberEdit CuryRetainageAmt { get; }
			public PXNumberEdit CuryExtCost { get; }
			public PXTextEdit AlternateID { get; }
			public PXTextEdit LotSerialNbr { get; }
			public PXNumberEdit RcptQtyMin { get; }
			public PXNumberEdit RcptQtyMax { get; }
			public PXNumberEdit RcptQtyThreshold { get; }
			public DropDown RcptQtyAction { get; }
			public Selector TaxCategoryID { get; }
			public Selector ExpenseAcctID { get; }
			public PXTextEdit ExpenseAcctID_Account_description { get; }
			public Selector ExpenseSubID { get; }
			public Selector POAccrualAcctID { get; }
			public Selector POAccrualSubID { get; }
			public Selector ProjectID { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public PXTextEdit OrderType { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SortOrder { get; }
			public DateSelector RequestedDate { get; }
			public DateSelector PromisedDate { get; }
			public DropDown CompletePOLine { get; }
			public CheckBox Completed { get; }
			public CheckBox Cancelled { get; }
			public CheckBox Closed { get; }
			public PXNumberEdit BilledQty { get; }
			public PXNumberEdit CuryBilledAmt { get; }
			public PXNumberEdit UnbilledQty { get; }
			public PXNumberEdit CuryUnbilledAmt { get; }
			public DropDown POType { get; }
			public Selector PONbr { get; }
			public DropDown POAccrualType { get; }
			public PXTextEdit HasExpiredComplianceDocuments { get; }
			public DateSelector DRTermStartDate { get; }
			public DateSelector DRTermEndDate { get; }
			public PXTextEdit OrderNbr { get; }
                
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
                    LineType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edLineType", "Line Type", grid.Locator, "LineType");
                    LineType.DataField = "LineType";
                    LineType.Items.Add("GI", "Goods for IN");
                    LineType.Items.Add("GS", "Goods for SO");
                    LineType.Items.Add("GF", "Goods for FS");
                    LineType.Items.Add("GR", "Goods for RP");
                    LineType.Items.Add("GP", "Goods for Drop-Ship");
                    LineType.Items.Add("NP", "Non-Stock for Drop-Ship");
                    LineType.Items.Add("NO", "Non-Stock for SO");
                    LineType.Items.Add("NF", "Non-Stock for FS");
                    LineType.Items.Add("NS", "Non-Stock");
                    LineType.Items.Add("SV", "Service");
                    LineType.Items.Add("FT", "Freight");
                    LineType.Items.Add("DN", "Description");
                    SiteID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    TranDesc = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Line Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrderQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edOrderQty", "Order Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    BaseOrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Base Order Qty.", grid.Locator, "BaseOrderQty");
                    BaseOrderQty.DataField = "BaseOrderQty";
                    ReceivedQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edReceivedQty", "Qty. On Receipts", grid.Locator, "ReceivedQty");
                    ReceivedQty.DataField = "ReceivedQty";
                    CuryUnitCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", grid.Locator, "CuryUnitCost");
                    CuryUnitCost.DataField = "CuryUnitCost";
                    ManualPrice = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Cost", grid.Locator, "ManualPrice");
                    ManualPrice.DataField = "ManualPrice";
                    CuryLineAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryLineAmt", "Ext. Cost", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    DiscPct = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edDiscPct", "Discount Percent", grid.Locator, "DiscPct");
                    DiscPct.DataField = "DiscPct";
                    CuryDiscAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryDiscAmt", "Discount Amount", grid.Locator, "CuryDiscAmt");
                    CuryDiscAmt.DataField = "CuryDiscAmt";
                    CuryDiscCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Disc. Unit Cost", grid.Locator, "CuryDiscCost");
                    CuryDiscCost.DataField = "CuryDiscCost";
                    ManualDisc = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", grid.Locator, "ManualDisc");
                    ManualDisc.DataField = "ManualDisc";
                    DiscountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDiscountCode", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Discount Sequence", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    DisplayReqPrepaidQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Prepaid Qty.", grid.Locator, "DisplayReqPrepaidQty");
                    DisplayReqPrepaidQty.DataField = "DisplayReqPrepaidQty";
                    CuryReqPrepaidAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Prepaid Amount", grid.Locator, "CuryReqPrepaidAmt");
                    CuryReqPrepaidAmt.DataField = "CuryReqPrepaidAmt";
                    RetainagePct = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Retainage Percent", grid.Locator, "RetainagePct");
                    RetainagePct.DataField = "RetainagePct";
                    CuryRetainageAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Retainage Amount", grid.Locator, "CuryRetainageAmt");
                    CuryRetainageAmt.DataField = "CuryRetainageAmt";
                    CuryExtCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryExtCost", "Amount", grid.Locator, "CuryExtCost");
                    CuryExtCost.DataField = "CuryExtCost";
                    AlternateID = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edAlternateID", "Alternate ID", grid.Locator, "AlternateID");
                    AlternateID.DataField = "AlternateID";
                    LotSerialNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Lot Serial Number", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    RcptQtyMin = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edRcptQtyMin", "Min. Receipt (%)", grid.Locator, "RcptQtyMin");
                    RcptQtyMin.DataField = "RcptQtyMin";
                    RcptQtyMax = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edRcptQtyMax", "Max. Receipt (%)", grid.Locator, "RcptQtyMax");
                    RcptQtyMax.DataField = "RcptQtyMax";
                    RcptQtyThreshold = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edRcptQtyThreshold", "Complete On (%)", grid.Locator, "RcptQtyThreshold");
                    RcptQtyThreshold.DataField = "RcptQtyThreshold";
                    RcptQtyAction = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edRcptQtyAction", "Receipt Action", grid.Locator, "RcptQtyAction");
                    RcptQtyAction.DataField = "RcptQtyAction";
                    RcptQtyAction.Items.Add("R", "Reject");
                    RcptQtyAction.Items.Add("W", "Accept but Warn");
                    RcptQtyAction.Items.Add("A", "Accept");
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    ExpenseAcctID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseAcctID", "Account", grid.Locator, "ExpenseAcctID");
                    ExpenseAcctID.DataField = "ExpenseAcctID";
                    ExpenseAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Description", grid.Locator, "ExpenseAcctID_Account_description");
                    ExpenseAcctID_Account_description.DataField = "ExpenseAcctID_Account_description";
                    ExpenseSubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseSubID", "Sub.", grid.Locator, "ExpenseSubID");
                    ExpenseSubID.DataField = "ExpenseSubID";
                    POAccrualAcctID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPOAccrualAcctID", "Accrual Account", grid.Locator, "POAccrualAcctID");
                    POAccrualAcctID.DataField = "POAccrualAcctID";
                    POAccrualSubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPOAccrualSubID", "Accrual Sub.", grid.Locator, "POAccrualSubID");
                    POAccrualSubID.DataField = "POAccrualSubID";
                    ProjectID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edCostCode", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    OrderType = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edOrderType", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Line Order", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    RequestedDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edRequestedDate", "Requested", grid.Locator, "RequestedDate");
                    RequestedDate.DataField = "RequestedDate";
                    PromisedDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edPromisedDate", "Promised", grid.Locator, "PromisedDate");
                    PromisedDate.DataField = "PromisedDate";
                    CompletePOLine = new DropDown("_ctl00_phG_tab_t0_grid_lv0_ec", "Close PO Line", grid.Locator, "CompletePOLine");
                    CompletePOLine.DataField = "CompletePOLine";
                    CompletePOLine.Items.Add("A", "By Amount");
                    CompletePOLine.Items.Add("Q", "By Quantity");
                    Completed = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkCompleted", "Completed", grid.Locator, "Completed");
                    Completed.DataField = "Completed";
                    Cancelled = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkCancelled", "Cancelled", grid.Locator, "Cancelled");
                    Cancelled.DataField = "Cancelled";
                    Closed = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkClosed", "Closed", grid.Locator, "Closed");
                    Closed.DataField = "Closed";
                    BilledQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edBilledQty", "Billed Qty.", grid.Locator, "BilledQty");
                    BilledQty.DataField = "BilledQty";
                    CuryBilledAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryBilledAmt", "Billed Amount", grid.Locator, "CuryBilledAmt");
                    CuryBilledAmt.DataField = "CuryBilledAmt";
                    UnbilledQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edUnbilledQty", "Unbilled Qty.", grid.Locator, "UnbilledQty");
                    UnbilledQty.DataField = "UnbilledQty";
                    CuryUnbilledAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryUnbilledAmt", "Unbilled Amount", grid.Locator, "CuryUnbilledAmt");
                    CuryUnbilledAmt.DataField = "CuryUnbilledAmt";
                    POType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edPOType", "Blanket PO Type", grid.Locator, "POType");
                    POType.DataField = "POType";
                    POType.Items.Add("RO", "Normal");
                    POType.Items.Add("DP", "Drop Ship");
                    POType.Items.Add("BL", "Blanket");
                    POType.Items.Add("SB", "Standard");
                    PONbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPONbr", "Blanket PO Nbr.", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    POAccrualType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edPOAccrualType", "Billing Based On", grid.Locator, "POAccrualType");
                    POAccrualType.DataField = "POAccrualType";
                    POAccrualType.Items.Add("R", "Receipt");
                    POAccrualType.Items.Add("O", "Order");
                    HasExpiredComplianceDocuments = new PXTextEdit("ctl00_phG_tab_t0_grid", "Has Expired Compliance Documents", grid.Locator, "HasExpiredComplianceDocuments");
                    HasExpiredComplianceDocuments.DataField = "HasExpiredComplianceDocuments";
                    DRTermStartDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", grid.Locator, "DRTermStartDate");
                    DRTermStartDate.DataField = "DRTermStartDate";
                    DRTermEndDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", grid.Locator, "DRTermEndDate");
                    DRTermEndDate.DataField = "DRTermEndDate";
                    OrderNbr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edOrderNbr", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter BranchID { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public DropDownColumnFilter LineType { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter BaseOrderQty { get; }
				public PXNumberEditColumnFilter ReceivedQty { get; }
				public PXNumberEditColumnFilter CuryUnitCost { get; }
				public CheckBoxColumnFilter ManualPrice { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public PXNumberEditColumnFilter DiscPct { get; }
				public PXNumberEditColumnFilter CuryDiscAmt { get; }
				public PXNumberEditColumnFilter CuryDiscCost { get; }
				public CheckBoxColumnFilter ManualDisc { get; }
				public SelectorColumnFilter DiscountID { get; }
				public PXTextEditColumnFilter DiscountSequenceID { get; }
				public PXNumberEditColumnFilter DisplayReqPrepaidQty { get; }
				public PXNumberEditColumnFilter CuryReqPrepaidAmt { get; }
				public PXNumberEditColumnFilter RetainagePct { get; }
				public PXNumberEditColumnFilter CuryRetainageAmt { get; }
				public PXNumberEditColumnFilter CuryExtCost { get; }
				public PXTextEditColumnFilter AlternateID { get; }
				public PXTextEditColumnFilter LotSerialNbr { get; }
				public PXNumberEditColumnFilter RcptQtyMin { get; }
				public PXNumberEditColumnFilter RcptQtyMax { get; }
				public PXNumberEditColumnFilter RcptQtyThreshold { get; }
				public DropDownColumnFilter RcptQtyAction { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public SelectorColumnFilter ExpenseAcctID { get; }
				public PXTextEditColumnFilter ExpenseAcctID_Account_description { get; }
				public SelectorColumnFilter ExpenseSubID { get; }
				public SelectorColumnFilter POAccrualAcctID { get; }
				public SelectorColumnFilter POAccrualSubID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public DateSelectorColumnFilter RequestedDate { get; }
				public DateSelectorColumnFilter PromisedDate { get; }
				public DropDownColumnFilter CompletePOLine { get; }
				public CheckBoxColumnFilter Completed { get; }
				public CheckBoxColumnFilter Cancelled { get; }
				public CheckBoxColumnFilter Closed { get; }
				public PXNumberEditColumnFilter BilledQty { get; }
				public PXNumberEditColumnFilter CuryBilledAmt { get; }
				public PXNumberEditColumnFilter UnbilledQty { get; }
				public PXNumberEditColumnFilter CuryUnbilledAmt { get; }
				public DropDownColumnFilter POType { get; }
				public SelectorColumnFilter PONbr { get; }
				public DropDownColumnFilter POAccrualType { get; }
				public PXTextEditColumnFilter HasExpiredComplianceDocuments { get; }
				public DateSelectorColumnFilter DRTermStartDate { get; }
				public DateSelectorColumnFilter DRTermEndDate { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    LineType = new DropDownColumnFilter(grid.Row.LineType);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    BaseOrderQty = new PXNumberEditColumnFilter(grid.Row.BaseOrderQty);
                    ReceivedQty = new PXNumberEditColumnFilter(grid.Row.ReceivedQty);
                    CuryUnitCost = new PXNumberEditColumnFilter(grid.Row.CuryUnitCost);
                    ManualPrice = new CheckBoxColumnFilter(grid.Row.ManualPrice);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    DiscPct = new PXNumberEditColumnFilter(grid.Row.DiscPct);
                    CuryDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscAmt);
                    CuryDiscCost = new PXNumberEditColumnFilter(grid.Row.CuryDiscCost);
                    ManualDisc = new CheckBoxColumnFilter(grid.Row.ManualDisc);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new PXTextEditColumnFilter(grid.Row.DiscountSequenceID);
                    DisplayReqPrepaidQty = new PXNumberEditColumnFilter(grid.Row.DisplayReqPrepaidQty);
                    CuryReqPrepaidAmt = new PXNumberEditColumnFilter(grid.Row.CuryReqPrepaidAmt);
                    RetainagePct = new PXNumberEditColumnFilter(grid.Row.RetainagePct);
                    CuryRetainageAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainageAmt);
                    CuryExtCost = new PXNumberEditColumnFilter(grid.Row.CuryExtCost);
                    AlternateID = new PXTextEditColumnFilter(grid.Row.AlternateID);
                    LotSerialNbr = new PXTextEditColumnFilter(grid.Row.LotSerialNbr);
                    RcptQtyMin = new PXNumberEditColumnFilter(grid.Row.RcptQtyMin);
                    RcptQtyMax = new PXNumberEditColumnFilter(grid.Row.RcptQtyMax);
                    RcptQtyThreshold = new PXNumberEditColumnFilter(grid.Row.RcptQtyThreshold);
                    RcptQtyAction = new DropDownColumnFilter(grid.Row.RcptQtyAction);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    ExpenseAcctID = new SelectorColumnFilter(grid.Row.ExpenseAcctID);
                    ExpenseAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.ExpenseAcctID_Account_description);
                    ExpenseSubID = new SelectorColumnFilter(grid.Row.ExpenseSubID);
                    POAccrualAcctID = new SelectorColumnFilter(grid.Row.POAccrualAcctID);
                    POAccrualSubID = new SelectorColumnFilter(grid.Row.POAccrualSubID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    RequestedDate = new DateSelectorColumnFilter(grid.Row.RequestedDate);
                    PromisedDate = new DateSelectorColumnFilter(grid.Row.PromisedDate);
                    CompletePOLine = new DropDownColumnFilter(grid.Row.CompletePOLine);
                    Completed = new CheckBoxColumnFilter(grid.Row.Completed);
                    Cancelled = new CheckBoxColumnFilter(grid.Row.Cancelled);
                    Closed = new CheckBoxColumnFilter(grid.Row.Closed);
                    BilledQty = new PXNumberEditColumnFilter(grid.Row.BilledQty);
                    CuryBilledAmt = new PXNumberEditColumnFilter(grid.Row.CuryBilledAmt);
                    UnbilledQty = new PXNumberEditColumnFilter(grid.Row.UnbilledQty);
                    CuryUnbilledAmt = new PXNumberEditColumnFilter(grid.Row.CuryUnbilledAmt);
                    POType = new DropDownColumnFilter(grid.Row.POType);
                    PONbr = new SelectorColumnFilter(grid.Row.PONbr);
                    POAccrualType = new DropDownColumnFilter(grid.Row.POAccrualType);
                    HasExpiredComplianceDocuments = new PXTextEditColumnFilter(grid.Row.HasExpiredComplianceDocuments);
                    DRTermStartDate = new DateSelectorColumnFilter(grid.Row.DRTermStartDate);
                    DRTermEndDate = new DateSelectorColumnFilter(grid.Row.DRTermEndDate);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                }
            }
        }
        
        public class c_transactions_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public DropDown LineType { get; }
			public Label LineTypeLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit OrderQty { get; }
			public Label OrderQtyLabel { get; }
			public PXNumberEdit ReceivedQty { get; }
			public Label ReceivedQtyLabel { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public Label CuryUnitCostLabel { get; }
			public CheckBox ManualPrice { get; }
			public Label ManualPriceLabel { get; }
			public Selector DiscountID { get; }
			public Label DiscountIDLabel { get; }
			public PXNumberEdit DiscPct { get; }
			public Label DiscPctLabel { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public Label CuryDiscAmtLabel { get; }
			public CheckBox ManualDisc { get; }
			public Label ManualDiscLabel { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public Label CuryLineAmtLabel { get; }
			public PXNumberEdit CuryExtCost { get; }
			public Label CuryExtCostLabel { get; }
			public PXNumberEdit RcptQtyMin { get; }
			public Label RcptQtyMinLabel { get; }
			public PXNumberEdit RcptQtyMax { get; }
			public Label RcptQtyMaxLabel { get; }
			public PXNumberEdit RcptQtyThreshold { get; }
			public Label RcptQtyThresholdLabel { get; }
			public DropDown RcptQtyAction { get; }
			public Label RcptQtyActionLabel { get; }
			public CheckBox Completed { get; }
			public Label CompletedLabel { get; }
			public CheckBox Cancelled { get; }
			public Label CancelledLabel { get; }
			public CheckBox Closed { get; }
			public Label ClosedLabel { get; }
			public PXNumberEdit BilledQty { get; }
			public Label BilledQtyLabel { get; }
			public PXNumberEdit CuryBilledAmt { get; }
			public Label CuryBilledAmtLabel { get; }
			public PXNumberEdit UnbilledQty { get; }
			public Label UnbilledQtyLabel { get; }
			public PXNumberEdit CuryUnbilledAmt { get; }
			public Label CuryUnbilledAmtLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector ExpenseAcctID { get; }
			public Label ExpenseAcctIDLabel { get; }
			public Selector ExpenseSubID { get; }
			public Label ExpenseSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public DateSelector RequestedDate { get; }
			public Label RequestedDateLabel { get; }
			public DateSelector PromisedDate { get; }
			public Label PromisedDateLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public PXTextEdit AlternateID { get; }
			public Label AlternateIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public DropDown POType { get; }
			public Label POTypeLabel { get; }
			public Selector PONbr { get; }
			public Label PONbrLabel { get; }
			public DropDown POAccrualType { get; }
			public Label POAccrualTypeLabel { get; }
			public DateSelector DRTermStartDate { get; }
			public Label DRTermStartDateLabel { get; }
			public DateSelector DRTermEndDate { get; }
			public Label DRTermEndDateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public PXTextEdit OrderType { get; }
			public Label OrderTypeLabel { get; }
			public PXTextEdit OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public PXNumberEdit LineNbr { get; }
			public Label LineNbrLabel { get; }
            
            public c_transactions_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SubItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                SiteID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LineType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edLineType", "Line Type", locator, null);
                LineTypeLabel = new Label(LineType);
                LineType.DataField = "LineType";
                LineType.Items.Add("GI", "Goods for IN");
                LineType.Items.Add("GS", "Goods for SO");
                LineType.Items.Add("GF", "Goods for FS");
                LineType.Items.Add("GR", "Goods for RP");
                LineType.Items.Add("GP", "Goods for Drop-Ship");
                LineType.Items.Add("NP", "Non-Stock for Drop-Ship");
                LineType.Items.Add("NO", "Non-Stock for SO");
                LineType.Items.Add("NF", "Non-Stock for FS");
                LineType.Items.Add("NS", "Non-Stock");
                LineType.Items.Add("SV", "Service");
                LineType.Items.Add("FT", "Freight");
                LineType.Items.Add("DN", "Description");
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                OrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edOrderQty", "Order Qty.", locator, null);
                OrderQtyLabel = new Label(OrderQty);
                OrderQty.DataField = "OrderQty";
                ReceivedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edReceivedQty", "Qty. On Receipts", locator, null);
                ReceivedQtyLabel = new Label(ReceivedQty);
                ReceivedQty.DataField = "ReceivedQty";
                CuryUnitCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", locator, null);
                CuryUnitCostLabel = new Label(CuryUnitCost);
                CuryUnitCost.DataField = "CuryUnitCost";
                ManualPrice = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Cost", locator, null);
                ManualPriceLabel = new Label(ManualPrice);
                ManualPrice.DataField = "ManualPrice";
                DiscountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edDiscountCode", "Discount Code", locator, null);
                DiscountIDLabel = new Label(DiscountID);
                DiscountID.DataField = "DiscountID";
                DiscPct = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edDiscPct", "Discount Percent", locator, null);
                DiscPctLabel = new Label(DiscPct);
                DiscPct.DataField = "DiscPct";
                CuryDiscAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryDiscAmt", "Discount Amount", locator, null);
                CuryDiscAmtLabel = new Label(CuryDiscAmt);
                CuryDiscAmt.DataField = "CuryDiscAmt";
                ManualDisc = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", locator, null);
                ManualDiscLabel = new Label(ManualDisc);
                ManualDisc.DataField = "ManualDisc";
                CuryLineAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryLineAmt", "Ext. Cost", locator, null);
                CuryLineAmtLabel = new Label(CuryLineAmt);
                CuryLineAmt.DataField = "CuryLineAmt";
                CuryExtCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryExtCost", "Amount", locator, null);
                CuryExtCostLabel = new Label(CuryExtCost);
                CuryExtCost.DataField = "CuryExtCost";
                RcptQtyMin = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edRcptQtyMin", "Min. Receipt (%)", locator, null);
                RcptQtyMinLabel = new Label(RcptQtyMin);
                RcptQtyMin.DataField = "RcptQtyMin";
                RcptQtyMax = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edRcptQtyMax", "Max. Receipt (%)", locator, null);
                RcptQtyMaxLabel = new Label(RcptQtyMax);
                RcptQtyMax.DataField = "RcptQtyMax";
                RcptQtyThreshold = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edRcptQtyThreshold", "Complete On (%)", locator, null);
                RcptQtyThresholdLabel = new Label(RcptQtyThreshold);
                RcptQtyThreshold.DataField = "RcptQtyThreshold";
                RcptQtyAction = new DropDown("ctl00_phG_tab_t0_grid_lv0_edRcptQtyAction", "Receipt Action", locator, null);
                RcptQtyActionLabel = new Label(RcptQtyAction);
                RcptQtyAction.DataField = "RcptQtyAction";
                RcptQtyAction.Items.Add("R", "Reject");
                RcptQtyAction.Items.Add("W", "Accept but Warn");
                RcptQtyAction.Items.Add("A", "Accept");
                Completed = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkCompleted", "Completed", locator, null);
                CompletedLabel = new Label(Completed);
                Completed.DataField = "Completed";
                Cancelled = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkCancelled", "Cancelled", locator, null);
                CancelledLabel = new Label(Cancelled);
                Cancelled.DataField = "Cancelled";
                Closed = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkClosed", "Closed", locator, null);
                ClosedLabel = new Label(Closed);
                Closed.DataField = "Closed";
                BilledQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edBilledQty", "Billed Qty.", locator, null);
                BilledQtyLabel = new Label(BilledQty);
                BilledQty.DataField = "BilledQty";
                CuryBilledAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryBilledAmt", "Billed Amount", locator, null);
                CuryBilledAmtLabel = new Label(CuryBilledAmt);
                CuryBilledAmt.DataField = "CuryBilledAmt";
                UnbilledQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edUnbilledQty", "Unbilled Qty.", locator, null);
                UnbilledQtyLabel = new Label(UnbilledQty);
                UnbilledQty.DataField = "UnbilledQty";
                CuryUnbilledAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnbilledAmt", "Unbilled Amount", locator, null);
                CuryUnbilledAmtLabel = new Label(CuryUnbilledAmt);
                CuryUnbilledAmt.DataField = "CuryUnbilledAmt";
                TranDesc = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Line Description", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                BranchID = new Selector("ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                ExpenseAcctID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseAcctID", "Account", locator, null);
                ExpenseAcctIDLabel = new Label(ExpenseAcctID);
                ExpenseAcctID.DataField = "ExpenseAcctID";
                ExpenseSubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseSubID", "Sub.", locator, null);
                ExpenseSubIDLabel = new Label(ExpenseSubID);
                ExpenseSubID.DataField = "ExpenseSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t0_grid_lv0_edPOAccrualAcctID", "Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edPOAccrualSubID", "Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                RequestedDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edRequestedDate", "Requested", locator, null);
                RequestedDateLabel = new Label(RequestedDate);
                RequestedDate.DataField = "RequestedDate";
                PromisedDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edPromisedDate", "Promised", locator, null);
                PromisedDateLabel = new Label(PromisedDate);
                PromisedDate.DataField = "PromisedDate";
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                AlternateID = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edAlternateID", "Alternate ID", locator, null);
                AlternateIDLabel = new Label(AlternateID);
                AlternateID.DataField = "AlternateID";
                ProjectID = new Selector("ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                CostCodeID = new Selector("ctl00_phG_tab_t0_grid_lv0_edCostCode", "Cost Code", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                POType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edPOType", "Blanket PO Type", locator, null);
                POTypeLabel = new Label(POType);
                POType.DataField = "POType";
                POType.Items.Add("RO", "Normal");
                POType.Items.Add("DP", "Drop Ship");
                POType.Items.Add("BL", "Blanket");
                POType.Items.Add("SB", "Standard");
                PONbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edPONbr", "Blanket PO Nbr.", locator, null);
                PONbrLabel = new Label(PONbr);
                PONbr.DataField = "PONbr";
                POAccrualType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edPOAccrualType", "Billing Based On", locator, null);
                POAccrualTypeLabel = new Label(POAccrualType);
                POAccrualType.DataField = "POAccrualType";
                POAccrualType.Items.Add("R", "Receipt");
                POAccrualType.Items.Add("O", "Order");
                DRTermStartDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", locator, null);
                DRTermStartDateLabel = new Label(DRTermStartDate);
                DRTermStartDate.DataField = "DRTermStartDate";
                DRTermEndDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", locator, null);
                DRTermEndDateLabel = new Label(DRTermEndDate);
                DRTermEndDate.DataField = "DRTermEndDate";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_lv0_ec", "Ec", locator, null);
                OrderType = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                LineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                DataMemberName = "Transactions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void PONbrEdit()
            {
                Buttons.PONbrEdit.Click();
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
			public Button DiscountIDEdit { get; }
			public Button PONbrEdit { get; }
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
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDiscountCode\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PONbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edPONbr\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "PONbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    PONbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c_taxes_gridtaxes : Grid<c_taxes_gridtaxes.c_grid_row, c_taxes_gridtaxes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_taxes_gridtaxes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_gridTaxes");
                DataMemberName = "Taxes";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_gridTaxes_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridTaxes_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxID { get; }
			public PXNumberEdit TaxRate { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public Selector TaxUOM { get; }
			public PXNumberEdit TaxableQty { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public PXNumberEdit CuryRetainedTaxableAmt { get; }
			public PXNumberEdit CuryRetainedTaxAmt { get; }
			public DropDown Tax__TaxType { get; }
			public CheckBox Tax__PendingTax { get; }
			public CheckBox Tax__ReverseTax { get; }
			public CheckBox Tax__ExemptTax { get; }
			public CheckBox Tax__StatisticalTax { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_taxes_gridtaxes grid) : 
                        base(grid)
                {
                    TaxID = new Selector("_ctl00_phG_tab_t1_gridTaxes_lv0_edTaxID", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    TaxRate = new PXNumberEdit("_ctl00_phG_tab_t1_gridTaxes_lv0_edTaxRate", "Tax Rate", grid.Locator, "TaxRate");
                    TaxRate.DataField = "TaxRate";
                    CuryTaxableAmt = new PXNumberEdit("_ctl00_phG_tab_t1_gridTaxes_lv0_edCuryTaxableAmt", "Taxable Amount", grid.Locator, "CuryTaxableAmt");
                    CuryTaxableAmt.DataField = "CuryTaxableAmt";
                    TaxUOM = new Selector("_ctl00_phG_tab_t1_gridTaxes_lv0_es", "Tax UOM", grid.Locator, "TaxUOM");
                    TaxUOM.DataField = "TaxUOM";
                    TaxableQty = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_en", "Taxable Qty.", grid.Locator, "TaxableQty");
                    TaxableQty.DataField = "TaxableQty";
                    CuryTaxAmt = new PXNumberEdit("_ctl00_phG_tab_t1_gridTaxes_lv0_edCuryTaxAmt", "Tax Amount", grid.Locator, "CuryTaxAmt");
                    CuryTaxAmt.DataField = "CuryTaxAmt";
                    CuryRetainedTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_en", "Retained Taxable", grid.Locator, "CuryRetainedTaxableAmt");
                    CuryRetainedTaxableAmt.DataField = "CuryRetainedTaxableAmt";
                    CuryRetainedTaxAmt = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_en", "Retained Tax", grid.Locator, "CuryRetainedTaxAmt");
                    CuryRetainedTaxAmt.DataField = "CuryRetainedTaxAmt";
                    Tax__TaxType = new DropDown("_ctl00_phG_tab_t1_gridTaxes_lv0_ec", "Tax Type", grid.Locator, "Tax__TaxType");
                    Tax__TaxType.DataField = "Tax__TaxType";
                    Tax__TaxType.Items.Add("S", "Sales");
                    Tax__TaxType.Items.Add("P", "Use");
                    Tax__TaxType.Items.Add("V", "VAT");
                    Tax__TaxType.Items.Add("W", "Withholding");
                    Tax__TaxType.Items.Add("Q", "Per-Unit/Specific");
                    Tax__PendingTax = new CheckBox("ctl00_phG_tab_t1_gridTaxes", "Pending VAT", grid.Locator, "Tax__PendingTax");
                    Tax__PendingTax.DataField = "Tax__PendingTax";
                    Tax__ReverseTax = new CheckBox("ctl00_phG_tab_t1_gridTaxes", "Reverse VAT", grid.Locator, "Tax__ReverseTax");
                    Tax__ReverseTax.DataField = "Tax__ReverseTax";
                    Tax__ExemptTax = new CheckBox("ctl00_phG_tab_t1_gridTaxes", "Include in VAT Exempt Total", grid.Locator, "Tax__ExemptTax");
                    Tax__ExemptTax.DataField = "Tax__ExemptTax";
                    Tax__StatisticalTax = new CheckBox("ctl00_phG_tab_t1_gridTaxes", "Statistical VAT", grid.Locator, "Tax__StatisticalTax");
                    Tax__StatisticalTax.DataField = "Tax__StatisticalTax";
                    OrderType = new PXTextEdit("ctl00_phG_tab_t1_gridTaxes_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_tab_t1_gridTaxes_ei", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxID { get; }
				public PXNumberEditColumnFilter TaxRate { get; }
				public PXNumberEditColumnFilter CuryTaxableAmt { get; }
				public SelectorColumnFilter TaxUOM { get; }
				public PXNumberEditColumnFilter TaxableQty { get; }
				public PXNumberEditColumnFilter CuryTaxAmt { get; }
				public PXNumberEditColumnFilter CuryRetainedTaxableAmt { get; }
				public PXNumberEditColumnFilter CuryRetainedTaxAmt { get; }
				public DropDownColumnFilter Tax__TaxType { get; }
				public CheckBoxColumnFilter Tax__PendingTax { get; }
				public CheckBoxColumnFilter Tax__ReverseTax { get; }
				public CheckBoxColumnFilter Tax__ExemptTax { get; }
				public CheckBoxColumnFilter Tax__StatisticalTax { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_taxes_gridtaxes grid) : 
                        base(grid)
                {
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                    TaxRate = new PXNumberEditColumnFilter(grid.Row.TaxRate);
                    CuryTaxableAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxableAmt);
                    TaxUOM = new SelectorColumnFilter(grid.Row.TaxUOM);
                    TaxableQty = new PXNumberEditColumnFilter(grid.Row.TaxableQty);
                    CuryTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxAmt);
                    CuryRetainedTaxableAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainedTaxableAmt);
                    CuryRetainedTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainedTaxAmt);
                    Tax__TaxType = new DropDownColumnFilter(grid.Row.Tax__TaxType);
                    Tax__PendingTax = new CheckBoxColumnFilter(grid.Row.Tax__PendingTax);
                    Tax__ReverseTax = new CheckBoxColumnFilter(grid.Row.Tax__ReverseTax);
                    Tax__ExemptTax = new CheckBoxColumnFilter(grid.Row.Tax__ExemptTax);
                    Tax__StatisticalTax = new CheckBoxColumnFilter(grid.Row.Tax__StatisticalTax);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_taxes_lv0 : Container
        {
            
			public Selector TaxID { get; }
			public Label TaxIDLabel { get; }
			public PXNumberEdit TaxRate { get; }
			public Label TaxRateLabel { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public Label CuryTaxableAmtLabel { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public Label CuryTaxAmtLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_taxes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                TaxID = new Selector("ctl00_phG_tab_t1_gridTaxes_lv0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                TaxRate = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_lv0_edTaxRate", "Tax Rate", locator, null);
                TaxRateLabel = new Label(TaxRate);
                TaxRate.DataField = "TaxRate";
                CuryTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_lv0_edCuryTaxableAmt", "Cury Taxable Amt", locator, null);
                CuryTaxableAmtLabel = new Label(CuryTaxableAmt);
                CuryTaxableAmt.DataField = "CuryTaxableAmt";
                CuryTaxAmt = new PXNumberEdit("ctl00_phG_tab_t1_gridTaxes_lv0_edCuryTaxAmt", "Cury Tax Amt", locator, null);
                CuryTaxAmtLabel = new Label(CuryTaxAmt);
                CuryTaxAmt.DataField = "CuryTaxAmt";
                Es = new Selector("ctl00_phG_tab_t1_gridTaxes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t1_gridTaxes_lv0_ec", "Ec", locator, null);
                DataMemberName = "Taxes";
            }
        }
        
        public class c_discountdetails_formdiscountdetail : Grid<c_discountdetails_formdiscountdetail.c_grid_row, c_discountdetails_formdiscountdetail.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_discountdetails_formdiscountdetail(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_formDiscountDetail");
                DataMemberName = "DiscountDetails";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_formDiscountDetail_fe_gf", "FilterForm");
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
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void DiscountSequenceIDEdit()
            {
                Buttons.DiscountSequenceIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_formDiscountDetail_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t5_formDiscountDetail");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t5_formDiscountDetail");
                    DiscountSequenceIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox SkipDiscount { get; }
			public Selector DiscountID { get; }
			public Selector DiscountSequenceID { get; }
			public DropDown Type { get; }
			public CheckBox IsManual { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public PXNumberEdit DiscountableQty { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public PXNumberEdit CuryRetainedDiscountAmt { get; }
			public PXNumberEdit DiscountPct { get; }
			public PXTextEdit ExtDiscCode { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit RecordID { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
                
                public c_grid_row(c_discountdetails_formdiscountdetail grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBox("_ctl00_phG_tab_t5_formDiscountDetail_lv0_chkSkipDiscount", "Skip Discount", grid.Locator, "SkipDiscount");
                    SkipDiscount.DataField = "SkipDiscount";
                    DiscountID = new Selector("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountID", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new Selector("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountSequenceID", "Sequence ID", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    Type = new DropDown("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edType", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("L", "Line");
                    Type.Items.Add("G", "Group");
                    Type.Items.Add("D", "Document");
                    Type.Items.Add("B", "External Document");
                    IsManual = new CheckBox("_ctl00_phG_tab_t5_formDiscountDetail_lv0_chkIsManual", "Manual Discount", grid.Locator, "IsManual");
                    IsManual.DataField = "IsManual";
                    CuryDiscountableAmt = new PXNumberEdit("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edCuryDiscountableAmt", "Discountable Amt.", grid.Locator, "CuryDiscountableAmt");
                    CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                    DiscountableQty = new PXNumberEdit("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountableQty", "Discountable Qty.", grid.Locator, "DiscountableQty");
                    DiscountableQty.DataField = "DiscountableQty";
                    CuryDiscountAmt = new PXNumberEdit("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edCuryDiscountAmt", "Discount Amt.", grid.Locator, "CuryDiscountAmt");
                    CuryDiscountAmt.DataField = "CuryDiscountAmt";
                    CuryRetainedDiscountAmt = new PXNumberEdit("ctl00_phG_tab_t5_formDiscountDetail_en", "Retained Discount", grid.Locator, "CuryRetainedDiscountAmt");
                    CuryRetainedDiscountAmt.DataField = "CuryRetainedDiscountAmt";
                    DiscountPct = new PXNumberEdit("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountPct", "Discount Percent", grid.Locator, "DiscountPct");
                    DiscountPct.DataField = "DiscountPct";
                    ExtDiscCode = new PXTextEdit("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edExtDiscCode", "External Discount Code", grid.Locator, "ExtDiscCode");
                    ExtDiscCode.DataField = "ExtDiscCode";
                    Description = new PXTextEdit("_ctl00_phG_tab_t5_formDiscountDetail_lv0_edDescription", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t5_formDiscountDetail_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                    OrderType = new PXTextEdit("ctl00_phG_tab_t5_formDiscountDetail_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_tab_t5_formDiscountDetail_em", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter SkipDiscount { get; }
				public SelectorColumnFilter DiscountID { get; }
				public SelectorColumnFilter DiscountSequenceID { get; }
				public DropDownColumnFilter Type { get; }
				public CheckBoxColumnFilter IsManual { get; }
				public PXNumberEditColumnFilter CuryDiscountableAmt { get; }
				public PXNumberEditColumnFilter DiscountableQty { get; }
				public PXNumberEditColumnFilter CuryDiscountAmt { get; }
				public PXNumberEditColumnFilter CuryRetainedDiscountAmt { get; }
				public PXNumberEditColumnFilter DiscountPct { get; }
				public PXTextEditColumnFilter ExtDiscCode { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXNumberEditColumnFilter RecordID { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
                
                public c_grid_header(c_discountdetails_formdiscountdetail grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBoxColumnFilter(grid.Row.SkipDiscount);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new SelectorColumnFilter(grid.Row.DiscountSequenceID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    IsManual = new CheckBoxColumnFilter(grid.Row.IsManual);
                    CuryDiscountableAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountableAmt);
                    DiscountableQty = new PXNumberEditColumnFilter(grid.Row.DiscountableQty);
                    CuryDiscountAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountAmt);
                    CuryRetainedDiscountAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainedDiscountAmt);
                    DiscountPct = new PXNumberEditColumnFilter(grid.Row.DiscountPct);
                    ExtDiscCode = new PXTextEditColumnFilter(grid.Row.ExtDiscCode);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                }
            }
        }
        
        public class c_discountdetails_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox SkipDiscount { get; }
			public Label SkipDiscountLabel { get; }
			public Selector DiscountID { get; }
			public Label DiscountIDLabel { get; }
			public DropDown Type { get; }
			public Label TypeLabel { get; }
			public CheckBox IsManual { get; }
			public Label IsManualLabel { get; }
			public Selector DiscountSequenceID { get; }
			public Label DiscountSequenceIDLabel { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public Label CuryDiscountableAmtLabel { get; }
			public PXNumberEdit DiscountableQty { get; }
			public Label DiscountableQtyLabel { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public Label CuryDiscountAmtLabel { get; }
			public PXNumberEdit DiscountPct { get; }
			public Label DiscountPctLabel { get; }
			public PXTextEdit ExtDiscCode { get; }
			public Label ExtDiscCodeLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_discountdetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SkipDiscount = new CheckBox("ctl00_phG_tab_t5_formDiscountDetail_lv0_chkSkipDiscount", "Skip Discount", locator, null);
                SkipDiscountLabel = new Label(SkipDiscount);
                SkipDiscount.DataField = "SkipDiscount";
                DiscountID = new Selector("ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountID", "Discount Code", locator, null);
                DiscountIDLabel = new Label(DiscountID);
                DiscountID.DataField = "DiscountID";
                Type = new DropDown("ctl00_phG_tab_t5_formDiscountDetail_lv0_edType", "Type", locator, null);
                TypeLabel = new Label(Type);
                Type.DataField = "Type";
                Type.Items.Add("L", "Line");
                Type.Items.Add("G", "Group");
                Type.Items.Add("D", "Document");
                Type.Items.Add("B", "External Document");
                IsManual = new CheckBox("ctl00_phG_tab_t5_formDiscountDetail_lv0_chkIsManual", "Manual Discount", locator, null);
                IsManualLabel = new Label(IsManual);
                IsManual.DataField = "IsManual";
                DiscountSequenceID = new Selector("ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountSequenceID", "Sequence ID", locator, null);
                DiscountSequenceIDLabel = new Label(DiscountSequenceID);
                DiscountSequenceID.DataField = "DiscountSequenceID";
                CuryDiscountableAmt = new PXNumberEdit("ctl00_phG_tab_t5_formDiscountDetail_lv0_edCuryDiscountableAmt", "Discountable Amt.", locator, null);
                CuryDiscountableAmtLabel = new Label(CuryDiscountableAmt);
                CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                DiscountableQty = new PXNumberEdit("ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountableQty", "Discountable Qty.", locator, null);
                DiscountableQtyLabel = new Label(DiscountableQty);
                DiscountableQty.DataField = "DiscountableQty";
                CuryDiscountAmt = new PXNumberEdit("ctl00_phG_tab_t5_formDiscountDetail_lv0_edCuryDiscountAmt", "Discount Amt.", locator, null);
                CuryDiscountAmtLabel = new Label(CuryDiscountAmt);
                CuryDiscountAmt.DataField = "CuryDiscountAmt";
                DiscountPct = new PXNumberEdit("ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountPct", "Discount Percent", locator, null);
                DiscountPctLabel = new Label(DiscountPct);
                DiscountPct.DataField = "DiscountPct";
                ExtDiscCode = new PXTextEdit("ctl00_phG_tab_t5_formDiscountDetail_lv0_edExtDiscCode", "External Discount Code", locator, null);
                ExtDiscCodeLabel = new Label(ExtDiscCode);
                ExtDiscCode.DataField = "ExtDiscCode";
                Description = new PXTextEdit("ctl00_phG_tab_t5_formDiscountDetail_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                Es = new Selector("ctl00_phG_tab_t5_formDiscountDetail_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "DiscountDetails";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void DiscountSequenceIDEdit()
            {
                Buttons.DiscountSequenceIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t5_formDiscountDetail_lv0");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_formDiscountDetail_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t5_formDiscountDetail_lv0");
                    DiscountSequenceIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_remit_address_formva : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideAddress { get; }
			public Label OverrideAddressLabel { get; }
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
            
            public c_remit_address_formva(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t3_formVA_chkOverrideAddress", "Override", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t3_formVA_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t3_formVA_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t3_formVA_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t3_formVA_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t3_formVA_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t3_formVA_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                IsValidated = new CheckBox("ctl00_phG_tab_t3_formVA_chkIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Remit_Address";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t3_formVA_btnRemitAddressLookup", "Address Lookup", "ctl00_phG_tab_t3_formVA");
                }
            }
        }
        
        public class c_remit_contact_formvc : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideContact { get; }
			public Label OverrideContactLabel { get; }
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public EmailEdit Email { get; }
			public Label EmailLabel { get; }
            
            public c_remit_contact_formvc(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t3_formVC_chkOverrideContact", "Override", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t3_formVC_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t3_formVC_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t3_formVC_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t3_formVC_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                DataMemberName = "Remit_Contact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t3_formVA_btnRemitAddressLookup", "Address Lookup", "ctl00_phG_tab_t3_formVC");
                }
            }
        }
        
        public class c_shipping_address_formsa : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideAddress { get; }
			public Label OverrideAddressLabel { get; }
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
            
            public c_shipping_address_formsa(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t2_formSA_chkOverrideAddress", "Override", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t2_formSA_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t2_formSA_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t2_formSA_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t2_formSA_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t2_formSA_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t2_formSA_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                IsValidated = new CheckBox("ctl00_phG_tab_t2_formSA_chkIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Shipping_Address";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_formSA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_formSA");
                }
            }
        }
        
        public class c_shipping_contact_formsc : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideContact { get; }
			public Label OverrideContactLabel { get; }
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public EmailEdit Email { get; }
			public Label EmailLabel { get; }
            
            public c_shipping_contact_formsc(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t2_formSC_chkOverrideContact", "Override", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t2_formSC_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t2_formSC_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t2_formSC_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t2_formSC_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                DataMemberName = "Shipping_Contact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_formSA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_formSC");
                }
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_gridApproval");
                DataMemberName = "Approval";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_gridApproval_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    ApproverEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Assignee ID", grid.Locator, "ApproverEmployee__AcctCD");
                    ApproverEmployee__AcctCD.DataField = "ApproverEmployee__AcctCD";
                    ApproverEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Assigned To", grid.Locator, "ApproverEmployee__AcctName");
                    ApproverEmployee__AcctName.DataField = "ApproverEmployee__AcctName";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    ApprovedByEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Approved By (ID)", grid.Locator, "ApprovedByEmployee__AcctCD");
                    ApprovedByEmployee__AcctCD.DataField = "ApprovedByEmployee__AcctCD";
                    ApprovedByEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Approved By", grid.Locator, "ApprovedByEmployee__AcctName");
                    ApprovedByEmployee__AcctName.DataField = "ApprovedByEmployee__AcctName";
                    ApproveDate = new DateSelector("_ctl00_phG_tab_t4_gridApproval_lv0_ed7", "Approval Date", grid.Locator, "ApproveDate");
                    ApproveDate.DataField = "ApproveDate";
                    Status = new DropDown("_ctl00_phG_tab_t4_gridApproval_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("P", "Pending");
                    Status.Items.Add("A", "Approved");
                    Status.Items.Add("R", "Rejected");
                    Reason = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Reason", grid.Locator, "Reason");
                    Reason.DataField = "Reason";
                    AssignmentMapID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    RuleID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Map Rule", grid.Locator, "RuleID");
                    RuleID.DataField = "RuleID";
                    StepID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Map Step", grid.Locator, "StepID");
                    StepID.DataField = "StepID";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t4_gridApproval_lv0_ed13", "Assignment Date", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    ApprovalID = new PXNumberEdit("ctl00_phG_tab_t4_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
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
                Es = new Selector("ctl00_phG_tab_t4_gridApproval_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t4_gridApproval_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t4_gridApproval_lv0_ec", "Ec", locator, null);
                DataMemberName = "Approval";
            }
        }
        
        public class c_replenishmentlines_gridreplenishmentlines : Grid<c_replenishmentlines_gridreplenishmentlines.c_grid_row, c_replenishmentlines_gridreplenishmentlines.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_replenishmentlines_gridreplenishmentlines(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phDS_PanelReplenishment_gridReplenishmentLines");
                DataMemberName = "ReplenishmentLines";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phDS_PanelReplenishment_gridReplenishmentLines_fe_gf", "FilterForm");
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
            
            public virtual void Close()
            {
                Buttons.Close.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_at_tlb div[data-cmd=\'Re" +
                            "fresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_at_tlb div[data-cmd=\'Ad" +
                            "justColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_at_tlb div[data-cmd=\'Ex" +
                            "portExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_at_tlb div[data-cmd=\'hi" +
                            "\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_ab_tlb div[data-cmd=\'Pa" +
                            "geFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_ab_tlb div[data-cmd=\'Pa" +
                            "gePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_ab_tlb div[data-cmd=\'Pa" +
                            "geNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_ab_tlb div[data-cmd=\'Pa" +
                            "geLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phDS_PanelReplenishment_gridReplenishmentLines_ab_tlb div[data-cmd=\'hi" +
                            "\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    Close = new Button("ctl00_phDS_PanelReplenishment_PXButton9", "Close", "ctl00_phDS_PanelReplenishment_gridReplenishmentLines");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit RefNbr { get; }
			public DateSelector OrderDate { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_replenishmentlines_gridreplenishmentlines grid) : 
                        base(grid)
                {
                    RefNbr = new PXTextEdit("ctl00_phDS_PanelReplenishment_gridReplenishmentLines_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    OrderDate = new DateSelector("_ctl00_phDS_PanelReplenishment_gridReplenishmentLines_lv0_ed1", "Order Date", grid.Locator, "OrderDate");
                    OrderDate.DataField = "OrderDate";
                    UOM = new Selector("_ctl00_phDS_PanelReplenishment_gridReplenishmentLines_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("ctl00_phDS_PanelReplenishment_gridReplenishmentLines_en", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    LineNbr = new PXNumberEdit("ctl00_phDS_PanelReplenishment_gridReplenishmentLines_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter RefNbr { get; }
				public DateSelectorColumnFilter OrderDate { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_replenishmentlines_gridreplenishmentlines grid) : 
                        base(grid)
                {
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    OrderDate = new DateSelectorColumnFilter(grid.Row.OrderDate);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_replenishmentlines_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_replenishmentlines_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phDS_PanelReplenishment_gridReplenishmentLines_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phDS_PanelReplenishment_gridReplenishmentLines_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "ReplenishmentLines";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    Close = new Button("ctl00_phDS_PanelReplenishment_PXButton9", "Close", "ctl00_phDS_PanelReplenishment_gridReplenishmentLines_lv0");
                }
            }
        }
        
        public class c_receipts_formreceipts : Grid<c_receipts_formreceipts.c_grid_row, c_receipts_formreceipts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_receipts_formreceipts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_sp1_formReceipts");
                DataMemberName = "Receipts";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_sp1_formReceipts_fe_gf", "FilterForm");
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
            
            public virtual void ReceiptNbrEdit()
            {
                Buttons.ReceiptNbrEdit.Click();
            }
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formReceipts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReceiptNbrEdit { get; }
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formReceipts_lv0_edReceiptNbr\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "ReceiptNbrEdit", "ctl00_phG_tab_t6_sp1_formReceipts");
                    ReceiptNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formAPDocs_lv0_edRefNbr\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t6_sp1_formReceipts");
                    RefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public DropDown ReceiptType { get; }
			public Selector ReceiptNbr { get; }
			public DateSelector DocDate { get; }
			public DropDown Status { get; }
			public PXNumberEdit TotalQty { get; }
			public DropDown POType { get; }
			public Selector PONbr { get; }
			public PXTextEdit StatusText { get; }
                
                public c_grid_row(c_receipts_formreceipts grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ReceiptType = new DropDown("_ctl00_phG_tab_t6_sp1_formReceipts_lv0_ec", "Type", grid.Locator, "ReceiptType");
                    ReceiptType.DataField = "ReceiptType";
                    ReceiptType.Items.Add("RT", "Receipt");
                    ReceiptType.Items.Add("RN", "Return");
                    ReceiptType.Items.Add("RX", "Transfer Receipt");
                    ReceiptNbr = new Selector("_ctl00_phG_tab_t6_sp1_formReceipts_lv0_edReceiptNbr", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    DocDate = new DateSelector("_ctl00_phG_tab_t6_sp1_formReceipts_lv0_ed4", "Date", grid.Locator, "DocDate");
                    DocDate.DataField = "DocDate";
                    Status = new DropDown("_ctl00_phG_tab_t6_sp1_formReceipts_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Balanced");
                    Status.Items.Add("R", "Released");
                    TotalQty = new PXNumberEdit("ctl00_phG_tab_t6_sp1_formReceipts_en", "Received Qty.", grid.Locator, "TotalQty");
                    TotalQty.DataField = "TotalQty";
                    POType = new DropDown("_ctl00_phG_tab_t6_sp1_formReceipts_lv0_ec", "PO Type", grid.Locator, "POType");
                    POType.DataField = "POType";
                    POType.Items.Add("RO", "Normal");
                    POType.Items.Add("DP", "Drop Ship");
                    POType.Items.Add("BL", "Blanket");
                    POType.Items.Add("SB", "Standard");
                    PONbr = new Selector("_ctl00_phG_tab_t6_sp1_formReceipts_lv0_es", "PO Number", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    StatusText = new PXTextEdit("ctl00_phG_tab_t6_sp1_formReceipts_ei", "StatusText", grid.Locator, "StatusText");
                    StatusText.DataField = "StatusText";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter ReceiptType { get; }
				public SelectorColumnFilter ReceiptNbr { get; }
				public DateSelectorColumnFilter DocDate { get; }
				public DropDownColumnFilter Status { get; }
				public PXNumberEditColumnFilter TotalQty { get; }
				public DropDownColumnFilter POType { get; }
				public SelectorColumnFilter PONbr { get; }
				public PXTextEditColumnFilter StatusText { get; }
                
                public c_grid_header(c_receipts_formreceipts grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ReceiptType = new DropDownColumnFilter(grid.Row.ReceiptType);
                    ReceiptNbr = new SelectorColumnFilter(grid.Row.ReceiptNbr);
                    DocDate = new DateSelectorColumnFilter(grid.Row.DocDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    TotalQty = new PXNumberEditColumnFilter(grid.Row.TotalQty);
                    POType = new DropDownColumnFilter(grid.Row.POType);
                    PONbr = new SelectorColumnFilter(grid.Row.PONbr);
                    StatusText = new PXTextEditColumnFilter(grid.Row.StatusText);
                }
            }
        }
        
        public class c_receipts_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_receipts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ReceiptNbr = new Selector("ctl00_phG_tab_t6_sp1_formReceipts_lv0_edReceiptNbr", "Receipt Nbr", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                Es = new Selector("ctl00_phG_tab_t6_sp1_formReceipts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_sp1_formReceipts_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_sp1_formReceipts_lv0_ec", "Ec", locator, null);
                DataMemberName = "Receipts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ReceiptNbrEdit()
            {
                Buttons.ReceiptNbrEdit.Click();
            }
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReceiptNbrEdit { get; }
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formReceipts_lv0_edReceiptNbr\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "ReceiptNbrEdit", "ctl00_phG_tab_t6_sp1_formReceipts_lv0");
                    ReceiptNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formAPDocs_lv0_edRefNbr\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t6_sp1_formReceipts_lv0");
                    RefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_apdocs_formapdocs : Grid<c_apdocs_formapdocs.c_grid_row, c_apdocs_formapdocs.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_apdocs_formapdocs(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_sp1_formAPDocs");
                DataMemberName = "APDocs";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_sp1_formAPDocs_fe_gf", "FilterForm");
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
            
            public virtual void ReceiptNbrEdit()
            {
                Buttons.ReceiptNbrEdit.Click();
            }
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_sp1_formAPDocs_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReceiptNbrEdit { get; }
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formReceipts_lv0_edReceiptNbr\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "ReceiptNbrEdit", "ctl00_phG_tab_t6_sp1_formAPDocs");
                    ReceiptNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formAPDocs_lv0_edRefNbr\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t6_sp1_formAPDocs");
                    RefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown DocType { get; }
			public Selector RefNbr { get; }
			public DateSelector DocDate { get; }
			public DropDown Status { get; }
			public PXNumberEdit TotalQty { get; }
			public PXNumberEdit TotalAmt { get; }
			public PXNumberEdit TotalPPVAmt { get; }
			public PXTextEdit CuryID { get; }
			public DropDown POOrderType { get; }
			public Selector PONbr { get; }
			public PXTextEdit StatusText { get; }
                
                public c_grid_row(c_apdocs_formapdocs grid) : 
                        base(grid)
                {
                    DocType = new DropDown("_ctl00_phG_tab_t6_sp1_formAPDocs_lv0_ec", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("INV", "Bill");
                    DocType.Items.Add("ACR", "Credit Adj.");
                    DocType.Items.Add("ADR", "Debit Adj.");
                    DocType.Items.Add("CHK", "Check");
                    DocType.Items.Add("VCK", "Voided Check");
                    DocType.Items.Add("PPM", "Prepayment");
                    DocType.Items.Add("REF", "Vendor Refund");
                    DocType.Items.Add("VRF", "Voided Refund");
                    DocType.Items.Add("QCK", "Quick Check");
                    DocType.Items.Add("VQC", "Void Quick Check");
                    DocType.Items.Add("PPR", "Prepayment Req.");
                    RefNbr = new Selector("_ctl00_phG_tab_t6_sp1_formAPDocs_lv0_edRefNbr", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    DocDate = new DateSelector("_ctl00_phG_tab_t6_sp1_formAPDocs_lv0_ed2", "Date", grid.Locator, "DocDate");
                    DocDate.DataField = "DocDate";
                    Status = new DropDown("_ctl00_phG_tab_t6_sp1_formAPDocs_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Balanced");
                    Status.Items.Add("V", "Voided");
                    Status.Items.Add("S", "Scheduled");
                    Status.Items.Add("N", "Open");
                    Status.Items.Add("C", "Closed");
                    Status.Items.Add("P", "Printed");
                    Status.Items.Add("K", "Pre-Released");
                    Status.Items.Add("E", "Pending Approval");
                    Status.Items.Add("R", "Rejected");
                    Status.Items.Add("Z", "Reserved");
                    Status.Items.Add("G", "Pending Print");
                    TotalQty = new PXNumberEdit("ctl00_phG_tab_t6_sp1_formAPDocs_en", "Billed Qty.", grid.Locator, "TotalQty");
                    TotalQty.DataField = "TotalQty";
                    TotalAmt = new PXNumberEdit("ctl00_phG_tab_t6_sp1_formAPDocs_en", "Billed Amt.", grid.Locator, "TotalAmt");
                    TotalAmt.DataField = "TotalAmt";
                    TotalPPVAmt = new PXNumberEdit("ctl00_phG_tab_t6_sp1_formAPDocs_en", "PPV Amt", grid.Locator, "TotalPPVAmt");
                    TotalPPVAmt.DataField = "TotalPPVAmt";
                    CuryID = new PXTextEdit("ctl00_phG_tab_t6_sp1_formAPDocs_em", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    POOrderType = new DropDown("_ctl00_phG_tab_t6_sp1_formAPDocs_lv0_ec", "PO Type", grid.Locator, "POOrderType");
                    POOrderType.DataField = "POOrderType";
                    POOrderType.Items.Add("RO", "Normal");
                    POOrderType.Items.Add("DP", "Drop Ship");
                    POOrderType.Items.Add("BL", "Blanket");
                    POOrderType.Items.Add("SB", "Standard");
                    PONbr = new Selector("_ctl00_phG_tab_t6_sp1_formAPDocs_lv0_es", "PO Number", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    StatusText = new PXTextEdit("ctl00_phG_tab_t6_sp1_formAPDocs_ei", "StatusText", grid.Locator, "StatusText");
                    StatusText.DataField = "StatusText";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter DocType { get; }
				public SelectorColumnFilter RefNbr { get; }
				public DateSelectorColumnFilter DocDate { get; }
				public DropDownColumnFilter Status { get; }
				public PXNumberEditColumnFilter TotalQty { get; }
				public PXNumberEditColumnFilter TotalAmt { get; }
				public PXNumberEditColumnFilter TotalPPVAmt { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public DropDownColumnFilter POOrderType { get; }
				public SelectorColumnFilter PONbr { get; }
				public PXTextEditColumnFilter StatusText { get; }
                
                public c_grid_header(c_apdocs_formapdocs grid) : 
                        base(grid)
                {
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    RefNbr = new SelectorColumnFilter(grid.Row.RefNbr);
                    DocDate = new DateSelectorColumnFilter(grid.Row.DocDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    TotalQty = new PXNumberEditColumnFilter(grid.Row.TotalQty);
                    TotalAmt = new PXNumberEditColumnFilter(grid.Row.TotalAmt);
                    TotalPPVAmt = new PXNumberEditColumnFilter(grid.Row.TotalPPVAmt);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    POOrderType = new DropDownColumnFilter(grid.Row.POOrderType);
                    PONbr = new SelectorColumnFilter(grid.Row.PONbr);
                    StatusText = new PXTextEditColumnFilter(grid.Row.StatusText);
                }
            }
        }
        
        public class c_apdocs_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector RefNbr { get; }
			public Label RefNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_apdocs_lv0(string locator, string name) : 
                    base(locator, name)
            {
                RefNbr = new Selector("ctl00_phG_tab_t6_sp1_formAPDocs_lv0_edRefNbr", "Ref Nbr", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Es = new Selector("ctl00_phG_tab_t6_sp1_formAPDocs_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_sp1_formAPDocs_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_sp1_formAPDocs_lv0_ec", "Ec", locator, null);
                DataMemberName = "APDocs";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
            }
            
            public virtual void ReceiptNbrEdit()
            {
                Buttons.ReceiptNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RefNbrEdit { get; }
			public Button ReceiptNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formAPDocs_lv0_edRefNbr\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t6_sp1_formAPDocs_lv0");
                    RefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_sp1_formReceipts_lv0_edReceiptNbr\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "ReceiptNbrEdit", "ctl00_phG_tab_t6_sp1_formAPDocs_lv0");
                    ReceiptNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
			public CheckBox OnlyAvailable { get; }
			public Label OnlyAvailableLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector ItemClass { get; }
			public Label ItemClassLabel { get; }
			public Selector SubItem { get; }
			public Label SubItemLabel { get; }
            
            public c_sitestatusfilter_formsitesstatus(string locator, string name) : 
                    base(locator, name)
            {
                Inventory = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edInventory", "Inventory", locator, null);
                InventoryLabel = new Label(Inventory);
                Inventory.DataField = "Inventory";
                BarCode = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edBarCode", "Bar Code", locator, null);
                BarCodeLabel = new Label(BarCode);
                BarCode.DataField = "BarCode";
                OnlyAvailable = new CheckBox("ctl00_phG_PanelAddSiteStatus_formSitesStatus_chkOnlyAvailable", "Only Available", locator, null);
                OnlyAvailableLabel = new Label(OnlyAvailable);
                OnlyAvailable.DataField = "OnlyAvailable";
                SiteID = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                ItemClass = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edItemClassID", "Item Class", locator, null);
                ItemClassLabel = new Label(ItemClass);
                ItemClass.DataField = "ItemClass";
                SubItem = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edSubItem", "Sub Item", locator, null);
                SubItemLabel = new Label(SubItem);
                SubItem.DataField = "SubItem";
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
                    Add = new Button("ctl00_phG_PanelAddSiteStatus_PXButton6", "Add", "ctl00_phG_PanelAddSiteStatus_formSitesStatus");
                    AddClose = new Button("ctl00_phG_PanelAddSiteStatus_PXButton7", "Add & Close", "ctl00_phG_PanelAddSiteStatus_formSitesStatus");
                    Cancel = new Button("ctl00_phG_PanelAddSiteStatus_PXButton8", "Cancel", "ctl00_phG_PanelAddSiteStatus_formSitesStatus");
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
                    Add = new Button("ctl00_phG_PanelAddSiteStatus_PXButton6", "Add", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus");
                    AddClose = new Button("ctl00_phG_PanelAddSiteStatus_PXButton7", "Add & Close", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus");
                    Cancel = new Button("ctl00_phG_PanelAddSiteStatus_PXButton8", "Cancel", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXNumberEdit QtySelected { get; }
			public Selector SiteID { get; }
			public Selector ItemClassID { get; }
			public InputLocalizable ItemClassDescription { get; }
			public PXTextEdit PriceClassID { get; }
			public PXTextEdit PriceClassDescription { get; }
			public Selector PreferredVendorID { get; }
			public PXTextEdit PreferredVendorDescription { get; }
			public Selector InventoryCD { get; }
			public Selector SubItemID { get; }
			public InputLocalizable Descr { get; }
			public Selector PurchaseUnit { get; }
			public PXNumberEdit QtyAvailExt { get; }
			public PXNumberEdit QtyOnHandExt { get; }
			public PXNumberEdit QtyPOOrdersExt { get; }
			public PXNumberEdit QtyPOReceiptsExt { get; }
			public PXTextEdit AlternateID { get; }
			public DropDown AlternateType { get; }
			public PXTextEdit AlternateDescr { get; }
			public Selector InventoryID { get; }
                
                public c_grid_row(c_sitestatus_gripsitestatus grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    QtySelected = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. Selected", grid.Locator, "QtySelected");
                    QtySelected.DataField = "QtySelected";
                    SiteID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    ItemClassID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_editemClass", "Item Class ID", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    ItemClassDescription = new InputLocalizable("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Item Class Description", grid.Locator, "ItemClassDescription");
                    ItemClassDescription.DataField = "ItemClassDescription";
                    PriceClassID = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_em", "Price Class ID", grid.Locator, "PriceClassID");
                    PriceClassID.DataField = "PriceClassID";
                    PriceClassDescription = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Price Class Description", grid.Locator, "PriceClassDescription");
                    PriceClassDescription.DataField = "PriceClassDescription";
                    PreferredVendorID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Preferred Vendor ID", grid.Locator, "PreferredVendorID");
                    PreferredVendorID.DataField = "PreferredVendorID";
                    PreferredVendorDescription = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Preferred Vendor Name", grid.Locator, "PreferredVendorDescription");
                    PreferredVendorDescription.DataField = "PreferredVendorDescription";
                    InventoryCD = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Inventory ID", grid.Locator, "InventoryCD");
                    InventoryCD.DataField = "InventoryCD";
                    SubItemID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    Descr = new InputLocalizable("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    PurchaseUnit = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Purchase Unit", grid.Locator, "PurchaseUnit");
                    PurchaseUnit.DataField = "PurchaseUnit";
                    QtyAvailExt = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. Available", grid.Locator, "QtyAvailExt");
                    QtyAvailExt.DataField = "QtyAvailExt";
                    QtyOnHandExt = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. On Hand", grid.Locator, "QtyOnHandExt");
                    QtyOnHandExt.DataField = "QtyOnHandExt";
                    QtyPOOrdersExt = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. PO Orders", grid.Locator, "QtyPOOrdersExt");
                    QtyPOOrdersExt.DataField = "QtyPOOrdersExt";
                    QtyPOReceiptsExt = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. PO Receipts", grid.Locator, "QtyPOReceiptsExt");
                    QtyPOReceiptsExt.DataField = "QtyPOReceiptsExt";
                    AlternateID = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Alternate ID", grid.Locator, "AlternateID");
                    AlternateID.DataField = "AlternateID";
                    AlternateType = new DropDown("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_ec", "Alternate Type", grid.Locator, "AlternateType");
                    AlternateType.DataField = "AlternateType";
                    AlternateType.Items.Add("0CPN", "Customer Part Number");
                    AlternateType.Items.Add("0VPN", "Vendor Part Number");
                    AlternateType.Items.Add("GLBL", "Global");
                    AlternateType.Items.Add("BAR", "Barcode");
                    AlternateDescr = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Alternate Description", grid.Locator, "AlternateDescr");
                    AlternateDescr.DataField = "AlternateDescr";
                    InventoryID = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter QtySelected { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter ItemClassID { get; }
				public PXTextEditColumnFilter ItemClassDescription { get; }
				public PXTextEditColumnFilter PriceClassID { get; }
				public PXTextEditColumnFilter PriceClassDescription { get; }
				public SelectorColumnFilter PreferredVendorID { get; }
				public PXTextEditColumnFilter PreferredVendorDescription { get; }
				public SelectorColumnFilter InventoryCD { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter PurchaseUnit { get; }
				public PXNumberEditColumnFilter QtyAvailExt { get; }
				public PXNumberEditColumnFilter QtyOnHandExt { get; }
				public PXNumberEditColumnFilter QtyPOOrdersExt { get; }
				public PXNumberEditColumnFilter QtyPOReceiptsExt { get; }
				public PXTextEditColumnFilter AlternateID { get; }
				public DropDownColumnFilter AlternateType { get; }
				public PXTextEditColumnFilter AlternateDescr { get; }
				public SelectorColumnFilter InventoryID { get; }
                
                public c_grid_header(c_sitestatus_gripsitestatus grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    QtySelected = new PXNumberEditColumnFilter(grid.Row.QtySelected);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    ItemClassID = new SelectorColumnFilter(grid.Row.ItemClassID);
                    ItemClassDescription = new PXTextEditColumnFilter(grid.Row.ItemClassDescription);
                    PriceClassID = new PXTextEditColumnFilter(grid.Row.PriceClassID);
                    PriceClassDescription = new PXTextEditColumnFilter(grid.Row.PriceClassDescription);
                    PreferredVendorID = new SelectorColumnFilter(grid.Row.PreferredVendorID);
                    PreferredVendorDescription = new PXTextEditColumnFilter(grid.Row.PreferredVendorDescription);
                    InventoryCD = new SelectorColumnFilter(grid.Row.InventoryCD);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    PurchaseUnit = new SelectorColumnFilter(grid.Row.PurchaseUnit);
                    QtyAvailExt = new PXNumberEditColumnFilter(grid.Row.QtyAvailExt);
                    QtyOnHandExt = new PXNumberEditColumnFilter(grid.Row.QtyOnHandExt);
                    QtyPOOrdersExt = new PXNumberEditColumnFilter(grid.Row.QtyPOOrdersExt);
                    QtyPOReceiptsExt = new PXNumberEditColumnFilter(grid.Row.QtyPOReceiptsExt);
                    AlternateID = new PXTextEditColumnFilter(grid.Row.AlternateID);
                    AlternateType = new DropDownColumnFilter(grid.Row.AlternateType);
                    AlternateDescr = new PXTextEditColumnFilter(grid.Row.AlternateDescr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
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
			public DropDown Ec { get; }
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
                Ec = new DropDown("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_ec", "Ec", locator, null);
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
                    Add = new Button("ctl00_phG_PanelAddSiteStatus_PXButton6", "Add", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddSiteStatus_PXButton7", "Add & Close", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddSiteStatus_PXButton8", "Cancel", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                }
            }
        }
        
        public class c_filter_frmpofilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
            
            public c_filter_frmpofilter(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new DropDown("ctl00_phDS_PanelAddPOLine_frmPOFilter_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phDS_PanelAddPOLine_frmPOFilter_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                DataMemberName = "filter";
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
                    Save = new Button("ctl00_phDS_PanelAddPOLine_PXButton1", "Save", "ctl00_phDS_PanelAddPOLine_frmPOFilter");
                    Cancel = new Button("ctl00_phDS_PanelAddPOLine_PXButton2", "Cancel", "ctl00_phDS_PanelAddPOLine_frmPOFilter");
                }
            }
        }
        
        public class c_polinesselection_gridol : Grid<c_polinesselection_gridol.c_grid_row, c_polinesselection_gridol.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_polinesselection_gridol(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phDS_PanelAddPOLine_gridOL");
                DataMemberName = "poLinesSelection";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phDS_PanelAddPOLine_gridOL_fe_gf", "FilterForm");
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
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phDS_PanelAddPOLine_PXButton1", "Save", "ctl00_phDS_PanelAddPOLine_gridOL");
                    Cancel = new Button("ctl00_phDS_PanelAddPOLine_PXButton2", "Cancel", "ctl00_phDS_PanelAddPOLine_gridOL");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public DropDown LineType { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit LeftToReceiveQty { get; }
			public PXTextEdit TranDesc { get; }
			public PXNumberEdit RcptQtyMin { get; }
			public PXNumberEdit RcptQtyMax { get; }
			public DropDown RcptQtyAction { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_polinesselection_gridol grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phDS_PanelAddPOLine_gridOL_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    LineType = new DropDown("_ctl00_phDS_PanelAddPOLine_gridOL_lv0_ec", "Line Type", grid.Locator, "LineType");
                    LineType.DataField = "LineType";
                    LineType.Items.Add("GI", "Goods for IN");
                    LineType.Items.Add("GS", "Goods for SO");
                    LineType.Items.Add("GF", "Goods for FS");
                    LineType.Items.Add("GR", "Goods for RP");
                    LineType.Items.Add("GP", "Goods for Drop-Ship");
                    LineType.Items.Add("NP", "Non-Stock for Drop-Ship");
                    LineType.Items.Add("NO", "Non-Stock for SO");
                    LineType.Items.Add("NF", "Non-Stock for FS");
                    LineType.Items.Add("NS", "Non-Stock");
                    LineType.Items.Add("SV", "Service");
                    LineType.Items.Add("FT", "Freight");
                    LineType.Items.Add("DN", "Description");
                    InventoryID = new Selector("_ctl00_phDS_PanelAddPOLine_gridOL_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phDS_PanelAddPOLine_gridOL_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    UOM = new Selector("_ctl00_phDS_PanelAddPOLine_gridOL_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrderQty = new PXNumberEdit("ctl00_phDS_PanelAddPOLine_gridOL_en", "Order Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    LeftToReceiveQty = new PXNumberEdit("ctl00_phDS_PanelAddPOLine_gridOL_en", "Open Qty.", grid.Locator, "LeftToReceiveQty");
                    LeftToReceiveQty.DataField = "LeftToReceiveQty";
                    TranDesc = new PXTextEdit("ctl00_phDS_PanelAddPOLine_gridOL_ei", "Line Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    RcptQtyMin = new PXNumberEdit("ctl00_phDS_PanelAddPOLine_gridOL_en", "Min. Receipt (%)", grid.Locator, "RcptQtyMin");
                    RcptQtyMin.DataField = "RcptQtyMin";
                    RcptQtyMax = new PXNumberEdit("ctl00_phDS_PanelAddPOLine_gridOL_en", "Max. Receipt (%)", grid.Locator, "RcptQtyMax");
                    RcptQtyMax.DataField = "RcptQtyMax";
                    RcptQtyAction = new DropDown("_ctl00_phDS_PanelAddPOLine_gridOL_lv0_ec", "Receipt Action", grid.Locator, "RcptQtyAction");
                    RcptQtyAction.DataField = "RcptQtyAction";
                    RcptQtyAction.Items.Add("R", "Reject");
                    RcptQtyAction.Items.Add("W", "Accept but Warn");
                    RcptQtyAction.Items.Add("A", "Accept");
                    OrderType = new PXTextEdit("ctl00_phDS_PanelAddPOLine_gridOL_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phDS_PanelAddPOLine_gridOL_ei", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    LineNbr = new PXNumberEdit("ctl00_phDS_PanelAddPOLine_gridOL_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter LineType { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter LeftToReceiveQty { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXNumberEditColumnFilter RcptQtyMin { get; }
				public PXNumberEditColumnFilter RcptQtyMax { get; }
				public DropDownColumnFilter RcptQtyAction { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_polinesselection_gridol grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    LineType = new DropDownColumnFilter(grid.Row.LineType);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    LeftToReceiveQty = new PXNumberEditColumnFilter(grid.Row.LeftToReceiveQty);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    RcptQtyMin = new PXNumberEditColumnFilter(grid.Row.RcptQtyMin);
                    RcptQtyMax = new PXNumberEditColumnFilter(grid.Row.RcptQtyMax);
                    RcptQtyAction = new DropDownColumnFilter(grid.Row.RcptQtyAction);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_polinesselection_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_polinesselection_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phDS_PanelAddPOLine_gridOL_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phDS_PanelAddPOLine_gridOL_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phDS_PanelAddPOLine_gridOL_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "poLinesSelection";
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
                    Save = new Button("ctl00_phDS_PanelAddPOLine_PXButton1", "Save", "ctl00_phDS_PanelAddPOLine_gridOL_lv0");
                    Cancel = new Button("ctl00_phDS_PanelAddPOLine_PXButton2", "Cancel", "ctl00_phDS_PanelAddPOLine_gridOL_lv0");
                }
            }
        }
        
        public class c_openorders_grdopenorders : Grid<c_openorders_grdopenorders.c_grid_row, c_openorders_grdopenorders.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_openorders_grdopenorders(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phDS_PanelAddPO_grdOpenOrders");
                DataMemberName = "openOrders";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phDS_PanelAddPO_grdOpenOrders_fe_gf", "FilterForm");
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
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phDS_PanelAddPO_PXButton3", "Save", "ctl00_phDS_PanelAddPO_grdOpenOrders");
                    Cancel = new Button("ctl00_phDS_PanelAddPO_PXButton4", "Cancel", "ctl00_phDS_PanelAddPO_grdOpenOrders");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public DropDown OrderType { get; }
			public Selector OrderNbr { get; }
			public DateSelector OrderDate { get; }
			public DateSelector ExpirationDate { get; }
			public DropDown Status { get; }
			public Selector CuryID { get; }
			public PXNumberEdit CuryOrderTotal { get; }
			public PXTextEdit VendorRefNbr { get; }
			public Selector TermsID { get; }
			public PXTextEdit OrderDesc { get; }
			public PXNumberEdit LeftToReceiveQty { get; }
			public PXNumberEdit CuryLeftToReceiveCost { get; }
                
                public c_grid_row(c_openorders_grdopenorders grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phDS_PanelAddPO_grdOpenOrders_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderType = new DropDown("_ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_ec", "Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderType.Items.Add("RO", "Normal");
                    OrderType.Items.Add("DP", "Drop Ship");
                    OrderType.Items.Add("BL", "Blanket");
                    OrderType.Items.Add("SB", "Standard");
                    OrderNbr = new Selector("_ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_es", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    OrderDate = new DateSelector("_ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_ed3", "Date", grid.Locator, "OrderDate");
                    OrderDate.DataField = "OrderDate";
                    ExpirationDate = new DateSelector("_ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_ed4", "Expired On", grid.Locator, "ExpirationDate");
                    ExpirationDate.DataField = "ExpirationDate";
                    Status = new DropDown("_ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Pending Approval");
                    Status.Items.Add("V", "Rejected");
                    Status.Items.Add("N", "Open");
                    Status.Items.Add("D", "Pending Printing");
                    Status.Items.Add("E", "Pending Email");
                    Status.Items.Add("L", "Canceled");
                    Status.Items.Add("M", "Completed");
                    Status.Items.Add("C", "Closed");
                    Status.Items.Add("P", "Printed");
                    CuryID = new Selector("_ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    CuryOrderTotal = new PXNumberEdit("ctl00_phDS_PanelAddPO_grdOpenOrders_en", "Order Total", grid.Locator, "CuryOrderTotal");
                    CuryOrderTotal.DataField = "CuryOrderTotal";
                    VendorRefNbr = new PXTextEdit("ctl00_phDS_PanelAddPO_grdOpenOrders_ei", "Vendor Ref.", grid.Locator, "VendorRefNbr");
                    VendorRefNbr.DataField = "VendorRefNbr";
                    TermsID = new Selector("_ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_es", "Terms", grid.Locator, "TermsID");
                    TermsID.DataField = "TermsID";
                    OrderDesc = new PXTextEdit("ctl00_phDS_PanelAddPO_grdOpenOrders_ei", "Description", grid.Locator, "OrderDesc");
                    OrderDesc.DataField = "OrderDesc";
                    LeftToReceiveQty = new PXNumberEdit("ctl00_phDS_PanelAddPO_grdOpenOrders_en", "Open Qty.", grid.Locator, "LeftToReceiveQty");
                    LeftToReceiveQty.DataField = "LeftToReceiveQty";
                    CuryLeftToReceiveCost = new PXNumberEdit("ctl00_phDS_PanelAddPO_grdOpenOrders_en", "Open Amt.", grid.Locator, "CuryLeftToReceiveCost");
                    CuryLeftToReceiveCost.DataField = "CuryLeftToReceiveCost";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public DateSelectorColumnFilter OrderDate { get; }
				public DateSelectorColumnFilter ExpirationDate { get; }
				public DropDownColumnFilter Status { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter CuryOrderTotal { get; }
				public PXTextEditColumnFilter VendorRefNbr { get; }
				public SelectorColumnFilter TermsID { get; }
				public PXTextEditColumnFilter OrderDesc { get; }
				public PXNumberEditColumnFilter LeftToReceiveQty { get; }
				public PXNumberEditColumnFilter CuryLeftToReceiveCost { get; }
                
                public c_grid_header(c_openorders_grdopenorders grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderType = new DropDownColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    OrderDate = new DateSelectorColumnFilter(grid.Row.OrderDate);
                    ExpirationDate = new DateSelectorColumnFilter(grid.Row.ExpirationDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    CuryOrderTotal = new PXNumberEditColumnFilter(grid.Row.CuryOrderTotal);
                    VendorRefNbr = new PXTextEditColumnFilter(grid.Row.VendorRefNbr);
                    TermsID = new SelectorColumnFilter(grid.Row.TermsID);
                    OrderDesc = new PXTextEditColumnFilter(grid.Row.OrderDesc);
                    LeftToReceiveQty = new PXNumberEditColumnFilter(grid.Row.LeftToReceiveQty);
                    CuryLeftToReceiveCost = new PXNumberEditColumnFilter(grid.Row.CuryLeftToReceiveCost);
                }
            }
        }
        
        public class c_openorders_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_openorders_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phDS_PanelAddPO_grdOpenOrders_lv0_ec", "Ec", locator, null);
                DataMemberName = "openOrders";
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
                    Save = new Button("ctl00_phDS_PanelAddPO_PXButton3", "Save", "ctl00_phDS_PanelAddPO_grdOpenOrders_lv0");
                    Cancel = new Button("ctl00_phDS_PanelAddPO_PXButton4", "Cancel", "ctl00_phDS_PanelAddPO_grdOpenOrders_lv0");
                }
            }
        }
        
        public class c_fixeddemand_gridfixeddemand : Grid<c_fixeddemand_gridfixeddemand.c_grid_row, c_fixeddemand_gridfixeddemand.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_fixeddemand_gridfixeddemand(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phDS_PanelFixedDemand_gridFixedDemand");
                DataMemberName = "FixedDemand";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phDS_PanelFixedDemand_gridFixedDemand_fe_gf", "FilterForm");
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
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_at_tlb div[data-cmd=\'AdjustColum" +
                            "ns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_at_tlb div[data-cmd=\'ExportExcel" +
                            "\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_ab_tlb div[data-cmd=\'PageFirst\']" +
                            "", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phDS_PanelFixedDemand_gridFixedDemand_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNbrEdit { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_edOrderNbr\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "OrderNbrEdit", "ctl00_phDS_PanelFixedDemand_gridFixedDemand");
                    OrderNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    Close = new Button("ctl00_phDS_PanelFixedDemand_PXButton5", "Close", "ctl00_phDS_PanelFixedDemand_gridFixedDemand");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit OrderType { get; }
			public Selector OrderNbr { get; }
			public DateSelector RequestDate { get; }
			public Selector CustomerID { get; }
			public Selector SiteID { get; }
			public Selector UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public PXTextEdit POUOM { get; }
			public PXNumberEdit POUOMOrderQty { get; }
			public CheckBox INItemPlan__Active { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SortOrder { get; }
			public PXNumberEdit SplitLineNbr { get; }
                
                public c_grid_row(c_fixeddemand_gridfixeddemand grid) : 
                        base(grid)
                {
                    OrderType = new PXTextEdit("ctl00_phDS_PanelFixedDemand_gridFixedDemand_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new Selector("_ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_edOrderNbr", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    RequestDate = new DateSelector("_ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_ed2", "Requested", grid.Locator, "RequestDate");
                    RequestDate.DataField = "RequestDate";
                    CustomerID = new Selector("_ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_es", "Customer", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    SiteID = new Selector("_ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    UOM = new Selector("_ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_es", "Orig. UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrderQty = new PXNumberEdit("ctl00_phDS_PanelFixedDemand_gridFixedDemand_en", "Orig. Quantity", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    POUOM = new PXTextEdit("ctl00_phDS_PanelFixedDemand_gridFixedDemand_em", "UOM", grid.Locator, "POUOM");
                    POUOM.DataField = "POUOM";
                    POUOMOrderQty = new PXNumberEdit("ctl00_phDS_PanelFixedDemand_gridFixedDemand_en", "Quantity", grid.Locator, "POUOMOrderQty");
                    POUOMOrderQty.DataField = "POUOMOrderQty";
                    INItemPlan__Active = new CheckBox("ctl00_phDS_PanelFixedDemand_gridFixedDemand", "Active", grid.Locator, "INItemPlan__Active");
                    INItemPlan__Active.DataField = "INItemPlan__Active";
                    LineNbr = new PXNumberEdit("ctl00_phDS_PanelFixedDemand_gridFixedDemand_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SortOrder = new PXNumberEdit("ctl00_phDS_PanelFixedDemand_gridFixedDemand_en", "SortOrder", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    SplitLineNbr = new PXNumberEdit("ctl00_phDS_PanelFixedDemand_gridFixedDemand_en", "SplitLineNbr", grid.Locator, "SplitLineNbr");
                    SplitLineNbr.DataField = "SplitLineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public DateSelectorColumnFilter RequestDate { get; }
				public SelectorColumnFilter CustomerID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXTextEditColumnFilter POUOM { get; }
				public PXNumberEditColumnFilter POUOMOrderQty { get; }
				public CheckBoxColumnFilter INItemPlan__Active { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public PXNumberEditColumnFilter SplitLineNbr { get; }
                
                public c_grid_header(c_fixeddemand_gridfixeddemand grid) : 
                        base(grid)
                {
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    RequestDate = new DateSelectorColumnFilter(grid.Row.RequestDate);
                    CustomerID = new SelectorColumnFilter(grid.Row.CustomerID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    POUOM = new PXTextEditColumnFilter(grid.Row.POUOM);
                    POUOMOrderQty = new PXNumberEditColumnFilter(grid.Row.POUOMOrderQty);
                    INItemPlan__Active = new CheckBoxColumnFilter(grid.Row.INItemPlan__Active);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    SplitLineNbr = new PXNumberEditColumnFilter(grid.Row.SplitLineNbr);
                }
            }
        }
        
        public class c_fixeddemand_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_fixeddemand_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrderNbr = new Selector("ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_edOrderNbr", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                Es = new Selector("ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "FixedDemand";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNbrEdit { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0_edOrderNbr\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "OrderNbrEdit", "ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0");
                    OrderNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    Close = new Button("ctl00_phDS_PanelFixedDemand_PXButton5", "Close", "ctl00_phDS_PanelFixedDemand_gridFixedDemand_lv0");
                }
            }
        }
        
        public class c_recalcdiscountsfilter_formrecalcdiscounts : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown RecalcTarget { get; }
			public Label RecalcTargetLabel { get; }
			public CheckBox RecalcUnitPrices { get; }
			public Label RecalcUnitPricesLabel { get; }
			public CheckBox OverrideManualPrices { get; }
			public Label OverrideManualPricesLabel { get; }
			public CheckBox RecalcDiscounts { get; }
			public Label RecalcDiscountsLabel { get; }
			public CheckBox OverrideManualDiscounts { get; }
			public Label OverrideManualDiscountsLabel { get; }
			public CheckBox OverrideManualDocGroupDiscounts { get; }
			public Label OverrideManualDocGroupDiscountsLabel { get; }
            
            public c_recalcdiscountsfilter_formrecalcdiscounts(string locator, string name) : 
                    base(locator, name)
            {
                RecalcTarget = new DropDown("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_edRecalcTerget", "Recalc Target", locator, null);
                RecalcTargetLabel = new Label(RecalcTarget);
                RecalcTarget.DataField = "RecalcTarget";
                RecalcUnitPrices = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkRecalcUnitPrices", "Recalc Unit Prices", locator, null);
                RecalcUnitPricesLabel = new Label(RecalcUnitPrices);
                RecalcUnitPrices.DataField = "RecalcUnitPrices";
                OverrideManualPrices = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkOverrideManualPrices", "Override Manual Prices", locator, null);
                OverrideManualPricesLabel = new Label(OverrideManualPrices);
                OverrideManualPrices.DataField = "OverrideManualPrices";
                RecalcDiscounts = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkRecalcDiscounts", "Recalc Discounts", locator, null);
                RecalcDiscountsLabel = new Label(RecalcDiscounts);
                RecalcDiscounts.DataField = "RecalcDiscounts";
                OverrideManualDiscounts = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkOverrideManualDiscounts", "Override Manual Discounts", locator, null);
                OverrideManualDiscountsLabel = new Label(OverrideManualDiscounts);
                OverrideManualDiscounts.DataField = "OverrideManualDiscounts";
                OverrideManualDocGroupDiscounts = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkOverrideManualDocGroupDisco" +
                        "unts", "Override Manual Doc Group Discounts", locator, null);
                OverrideManualDocGroupDiscountsLabel = new Label(OverrideManualDocGroupDiscounts);
                OverrideManualDocGroupDiscounts.DataField = "OverrideManualDocGroupDiscounts";
                DataMemberName = "recalcdiscountsfilter";
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
                    Ok = new Button("ctl00_phG_PanelRecalcDiscounts_PXButton10", "OK", "ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts");
                }
            }
        }
        
        public class c_matrix_matrixmatrix : Grid<c_matrix_matrixmatrix.c_grid_row, c_matrix_matrixmatrix.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_matrix_matrixmatrix(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix");
                DataMemberName = "Matrix";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_fe_gf", "FilterForm");
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
            
            public virtual void Addandclose()
            {
                Buttons.Addandclose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_at_tlb div[data-cmd=\'" +
                            "Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_at_tlb div[data-cmd=\'" +
                            "AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_at_tlb div[data-cmd=\'" +
                            "ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_at_tlb div[data-cmd=\'" +
                            "hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_ab_tlb div[data-cmd=\'" +
                            "PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_ab_tlb div[data-cmd=\'" +
                            "PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_ab_tlb div[data-cmd=\'" +
                            "PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_ab_tlb div[data-cmd=\'" +
                            "PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_ab_tlb div[data-cmd=\'" +
                            "hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Addandclose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Addandclose = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonOK" +
                            "", "Add and close", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix");
                    Cancel = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonCa" +
                            "ncel", "Cancel", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit RowAttributeValueDescr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit MatrixAvailability { get; }
                
                public c_grid_row(c_matrix_matrixmatrix grid) : 
                        base(grid)
                {
                    RowAttributeValueDescr = new PXTextEdit("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_ei", "Attribute Value", grid.Locator, "RowAttributeValueDescr");
                    RowAttributeValueDescr.DataField = "RowAttributeValueDescr";
                    LineNbr = new PXNumberEdit("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    MatrixAvailability = new PXTextEdit("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix_ei", "MatrixAvailability", grid.Locator, "MatrixAvailability");
                    MatrixAvailability.DataField = "MatrixAvailability";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter RowAttributeValueDescr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter MatrixAvailability { get; }
                
                public c_grid_header(c_matrix_matrixmatrix grid) : 
                        base(grid)
                {
                    RowAttributeValueDescr = new PXTextEditColumnFilter(grid.Row.RowAttributeValueDescr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    MatrixAvailability = new PXTextEditColumnFilter(grid.Row.MatrixAvailability);
                }
            }
        }
        
        public class c_changeorders_changeordersgrid : Grid<c_changeorders_changeordersgrid.c_grid_row, c_changeorders_changeordersgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_changeorders_changeordersgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_ChangeOrdersGrid");
                DataMemberName = "ChangeOrders";
                PredefinedFilter = new DropDown("ctl00_phG_tab_t8_ChangeOrdersGrid_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t8_ChangeOrdersGrid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
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
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_ChangeOrdersGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit RefNbr { get; }
			public Selector PMChangeOrder__ClassID { get; }
			public PXTextEdit PMChangeOrder__ProjectNbr { get; }
			public DropDown PMChangeOrder__Status { get; }
			public PXTextEdit PMChangeOrder__Description { get; }
			public DateSelector PMChangeOrder__Date { get; }
			public DateSelector PMChangeOrder__CompletionDate { get; }
			public PXNumberEdit PMChangeOrder__DelayDays { get; }
			public DropDown PMChangeOrder__ReverseStatus { get; }
			public PXTextEdit PMChangeOrder__OrigRefNbr { get; }
			public PXTextEdit PMChangeOrder__ExtRefNbr { get; }
			public Selector ProjectID { get; }
			public Selector TaskID { get; }
			public Selector InventoryID { get; }
			public Selector CostCodeID { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit Qty { get; }
			public Selector UOM { get; }
			public PXNumberEdit UnitCost { get; }
			public PXNumberEdit Amount { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_changeorders_changeordersgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_ei", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    PMChangeOrder__ClassID = new Selector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_es", "Class", grid.Locator, "PMChangeOrder__ClassID");
                    PMChangeOrder__ClassID.DataField = "PMChangeOrder__ClassID";
                    PMChangeOrder__ProjectNbr = new PXTextEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_ei", "Revenue Change Nbr.", grid.Locator, "PMChangeOrder__ProjectNbr");
                    PMChangeOrder__ProjectNbr.DataField = "PMChangeOrder__ProjectNbr";
                    PMChangeOrder__Status = new DropDown("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_ec", "Status", grid.Locator, "PMChangeOrder__Status");
                    PMChangeOrder__Status.DataField = "PMChangeOrder__Status";
                    PMChangeOrder__Status.Items.Add("H", "On Hold");
                    PMChangeOrder__Status.Items.Add("A", "Pending Approval");
                    PMChangeOrder__Status.Items.Add("O", "Open");
                    PMChangeOrder__Status.Items.Add("C", "Closed");
                    PMChangeOrder__Status.Items.Add("R", "Rejected");
                    PMChangeOrder__Description = new PXTextEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_ei", "Description", grid.Locator, "PMChangeOrder__Description");
                    PMChangeOrder__Description.DataField = "PMChangeOrder__Description";
                    PMChangeOrder__Date = new DateSelector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_ed7", "Change Date", grid.Locator, "PMChangeOrder__Date");
                    PMChangeOrder__Date.DataField = "PMChangeOrder__Date";
                    PMChangeOrder__CompletionDate = new DateSelector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_ed8", "Approval Date", grid.Locator, "PMChangeOrder__CompletionDate");
                    PMChangeOrder__CompletionDate.DataField = "PMChangeOrder__CompletionDate";
                    PMChangeOrder__DelayDays = new PXNumberEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_en", "Contract Time Change, Days", grid.Locator, "PMChangeOrder__DelayDays");
                    PMChangeOrder__DelayDays.DataField = "PMChangeOrder__DelayDays";
                    PMChangeOrder__ReverseStatus = new DropDown("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_ec", "Reverse Status", grid.Locator, "PMChangeOrder__ReverseStatus");
                    PMChangeOrder__ReverseStatus.DataField = "PMChangeOrder__ReverseStatus";
                    PMChangeOrder__ReverseStatus.Items.Add("N", "None");
                    PMChangeOrder__ReverseStatus.Items.Add("X", "Reversed");
                    PMChangeOrder__ReverseStatus.Items.Add("R", "Reversing");
                    PMChangeOrder__OrigRefNbr = new PXTextEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_ei", "Orig. CO Ref. Nbr.", grid.Locator, "PMChangeOrder__OrigRefNbr");
                    PMChangeOrder__OrigRefNbr.DataField = "PMChangeOrder__OrigRefNbr";
                    PMChangeOrder__ExtRefNbr = new PXTextEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_ei", "External Reference Nbr.", grid.Locator, "PMChangeOrder__ExtRefNbr");
                    PMChangeOrder__ExtRefNbr.DataField = "PMChangeOrder__ExtRefNbr";
                    ProjectID = new Selector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_es", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_es", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    InventoryID = new Selector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_es", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    Description = new PXTextEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    Qty = new PXNumberEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_en", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    UOM = new Selector("_ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    UnitCost = new PXNumberEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_en", "Unit Cost", grid.Locator, "UnitCost");
                    UnitCost.DataField = "UnitCost";
                    Amount = new PXNumberEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_en", "Amount", grid.Locator, "Amount");
                    Amount.DataField = "Amount";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t8_ChangeOrdersGrid_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public SelectorColumnFilter PMChangeOrder__ClassID { get; }
				public PXTextEditColumnFilter PMChangeOrder__ProjectNbr { get; }
				public DropDownColumnFilter PMChangeOrder__Status { get; }
				public PXTextEditColumnFilter PMChangeOrder__Description { get; }
				public DateSelectorColumnFilter PMChangeOrder__Date { get; }
				public DateSelectorColumnFilter PMChangeOrder__CompletionDate { get; }
				public PXNumberEditColumnFilter PMChangeOrder__DelayDays { get; }
				public DropDownColumnFilter PMChangeOrder__ReverseStatus { get; }
				public PXTextEditColumnFilter PMChangeOrder__OrigRefNbr { get; }
				public PXTextEditColumnFilter PMChangeOrder__ExtRefNbr { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter UnitCost { get; }
				public PXNumberEditColumnFilter Amount { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_changeorders_changeordersgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    PMChangeOrder__ClassID = new SelectorColumnFilter(grid.Row.PMChangeOrder__ClassID);
                    PMChangeOrder__ProjectNbr = new PXTextEditColumnFilter(grid.Row.PMChangeOrder__ProjectNbr);
                    PMChangeOrder__Status = new DropDownColumnFilter(grid.Row.PMChangeOrder__Status);
                    PMChangeOrder__Description = new PXTextEditColumnFilter(grid.Row.PMChangeOrder__Description);
                    PMChangeOrder__Date = new DateSelectorColumnFilter(grid.Row.PMChangeOrder__Date);
                    PMChangeOrder__CompletionDate = new DateSelectorColumnFilter(grid.Row.PMChangeOrder__CompletionDate);
                    PMChangeOrder__DelayDays = new PXNumberEditColumnFilter(grid.Row.PMChangeOrder__DelayDays);
                    PMChangeOrder__ReverseStatus = new DropDownColumnFilter(grid.Row.PMChangeOrder__ReverseStatus);
                    PMChangeOrder__OrigRefNbr = new PXTextEditColumnFilter(grid.Row.PMChangeOrder__OrigRefNbr);
                    PMChangeOrder__ExtRefNbr = new PXTextEditColumnFilter(grid.Row.PMChangeOrder__ExtRefNbr);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    UnitCost = new PXNumberEditColumnFilter(grid.Row.UnitCost);
                    Amount = new PXNumberEditColumnFilter(grid.Row.Amount);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_changeorders_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_changeorders_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t8_ChangeOrdersGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "ChangeOrders";
            }
        }
        
        public class c_prepaymentdocuments_prepaymentgrid : Grid<c_prepaymentdocuments_prepaymentgrid.c_grid_row, c_prepaymentdocuments_prepaymentgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_prepaymentdocuments_prepaymentgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_PrepaymentGrid");
                DataMemberName = "PrepaymentDocuments";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_PrepaymentGrid_fe_gf", "FilterForm");
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
            
            public virtual void APRefNbrEdit()
            {
                Buttons.APRefNbrEdit.Click();
            }
            
            public virtual void PayRefNbrEdit()
            {
                Buttons.PayRefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PrepaymentGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button APRefNbrEdit { get; }
			public Button PayRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    APRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPrepaymentRefNbr\'] div[class=\'e" +
                            "ditBtnCont\'] > div > div", "APRefNbrEdit", "ctl00_phG_tab_t7_PrepaymentGrid");
                    APRefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PayRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPaymentRefNbr\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "PayRefNbrEdit", "ctl00_phG_tab_t7_PrepaymentGrid");
                    PayRefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown APDocType { get; }
			public Selector APRefNbr { get; }
			public DateSelector APRegister__DocDate { get; }
			public PXNumberEdit CuryAppliedAmt { get; }
			public PXNumberEdit APRegister__CuryDocBal { get; }
			public DropDown APRegister__Status { get; }
			public Selector APRegister__CuryID { get; }
			public Selector PayRefNbr { get; }
			public DropDown OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXTextEdit StatusText { get; }
                
                public c_grid_row(c_prepaymentdocuments_prepaymentgrid grid) : 
                        base(grid)
                {
                    APDocType = new DropDown("_ctl00_phG_tab_t7_PrepaymentGrid_lv0_ec", "Doc. Type", grid.Locator, "APDocType");
                    APDocType.DataField = "APDocType";
                    APDocType.Items.Add("INV", "Bill");
                    APDocType.Items.Add("ACR", "Credit Adj.");
                    APDocType.Items.Add("ADR", "Debit Adj.");
                    APDocType.Items.Add("CHK", "Check");
                    APDocType.Items.Add("VCK", "Voided Check");
                    APDocType.Items.Add("PPM", "Prepayment");
                    APDocType.Items.Add("REF", "Vendor Refund");
                    APDocType.Items.Add("VRF", "Voided Refund");
                    APDocType.Items.Add("QCK", "Quick Check");
                    APDocType.Items.Add("VQC", "Void Quick Check");
                    APDocType.Items.Add("PPR", "Prepayment Req.");
                    APRefNbr = new Selector("_ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPrepaymentRefNbr", "Reference Nbr.", grid.Locator, "APRefNbr");
                    APRefNbr.DataField = "APRefNbr";
                    APRegister__DocDate = new DateSelector("_ctl00_phG_tab_t7_PrepaymentGrid_lv0_ed2", "Date", grid.Locator, "APRegister__DocDate");
                    APRegister__DocDate.DataField = "APRegister__DocDate";
                    CuryAppliedAmt = new PXNumberEdit("ctl00_phG_tab_t7_PrepaymentGrid_en", "Applied to Order", grid.Locator, "CuryAppliedAmt");
                    CuryAppliedAmt.DataField = "CuryAppliedAmt";
                    APRegister__CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t7_PrepaymentGrid_en", "Balance", grid.Locator, "APRegister__CuryDocBal");
                    APRegister__CuryDocBal.DataField = "APRegister__CuryDocBal";
                    APRegister__Status = new DropDown("_ctl00_phG_tab_t7_PrepaymentGrid_lv0_ec", "Status", grid.Locator, "APRegister__Status");
                    APRegister__Status.DataField = "APRegister__Status";
                    APRegister__Status.Items.Add("H", "On Hold");
                    APRegister__Status.Items.Add("B", "Balanced");
                    APRegister__Status.Items.Add("V", "Voided");
                    APRegister__Status.Items.Add("S", "Scheduled");
                    APRegister__Status.Items.Add("N", "Open");
                    APRegister__Status.Items.Add("C", "Closed");
                    APRegister__Status.Items.Add("P", "Printed");
                    APRegister__Status.Items.Add("K", "Pre-Released");
                    APRegister__Status.Items.Add("E", "Pending Approval");
                    APRegister__Status.Items.Add("R", "Rejected");
                    APRegister__Status.Items.Add("Z", "Reserved");
                    APRegister__Status.Items.Add("G", "Pending Print");
                    APRegister__CuryID = new Selector("_ctl00_phG_tab_t7_PrepaymentGrid_lv0_es", "Currency", grid.Locator, "APRegister__CuryID");
                    APRegister__CuryID.DataField = "APRegister__CuryID";
                    PayRefNbr = new Selector("_ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPaymentRefNbr", "Payment Ref.", grid.Locator, "PayRefNbr");
                    PayRefNbr.DataField = "PayRefNbr";
                    OrderType = new DropDown("_ctl00_phG_tab_t7_PrepaymentGrid_lv0_ec", "Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderType.Items.Add("RO", "Normal");
                    OrderType.Items.Add("DP", "Drop Ship");
                    OrderType.Items.Add("BL", "Blanket");
                    OrderType.Items.Add("SB", "Standard");
                    OrderNbr = new PXTextEdit("ctl00_phG_tab_t7_PrepaymentGrid_ei", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    StatusText = new PXTextEdit("ctl00_phG_tab_t7_PrepaymentGrid_ei", "StatusText", grid.Locator, "StatusText");
                    StatusText.DataField = "StatusText";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter APDocType { get; }
				public SelectorColumnFilter APRefNbr { get; }
				public DateSelectorColumnFilter APRegister__DocDate { get; }
				public PXNumberEditColumnFilter CuryAppliedAmt { get; }
				public PXNumberEditColumnFilter APRegister__CuryDocBal { get; }
				public DropDownColumnFilter APRegister__Status { get; }
				public SelectorColumnFilter APRegister__CuryID { get; }
				public SelectorColumnFilter PayRefNbr { get; }
				public DropDownColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXTextEditColumnFilter StatusText { get; }
                
                public c_grid_header(c_prepaymentdocuments_prepaymentgrid grid) : 
                        base(grid)
                {
                    APDocType = new DropDownColumnFilter(grid.Row.APDocType);
                    APRefNbr = new SelectorColumnFilter(grid.Row.APRefNbr);
                    APRegister__DocDate = new DateSelectorColumnFilter(grid.Row.APRegister__DocDate);
                    CuryAppliedAmt = new PXNumberEditColumnFilter(grid.Row.CuryAppliedAmt);
                    APRegister__CuryDocBal = new PXNumberEditColumnFilter(grid.Row.APRegister__CuryDocBal);
                    APRegister__Status = new DropDownColumnFilter(grid.Row.APRegister__Status);
                    APRegister__CuryID = new SelectorColumnFilter(grid.Row.APRegister__CuryID);
                    PayRefNbr = new SelectorColumnFilter(grid.Row.PayRefNbr);
                    OrderType = new DropDownColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    StatusText = new PXTextEditColumnFilter(grid.Row.StatusText);
                }
            }
        }
        
        public class c_prepaymentdocuments_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector APRefNbr { get; }
			public Label APRefNbrLabel { get; }
			public Selector PayRefNbr { get; }
			public Label PayRefNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_prepaymentdocuments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                APRefNbr = new Selector("ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPrepaymentRefNbr", "Reference Nbr.", locator, null);
                APRefNbrLabel = new Label(APRefNbr);
                APRefNbr.DataField = "APRefNbr";
                PayRefNbr = new Selector("ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPaymentRefNbr", "Payment Ref.", locator, null);
                PayRefNbrLabel = new Label(PayRefNbr);
                PayRefNbr.DataField = "PayRefNbr";
                Es = new Selector("ctl00_phG_tab_t7_PrepaymentGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t7_PrepaymentGrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t7_PrepaymentGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "PrepaymentDocuments";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void APRefNbrEdit()
            {
                Buttons.APRefNbrEdit.Click();
            }
            
            public virtual void PayRefNbrEdit()
            {
                Buttons.PayRefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button APRefNbrEdit { get; }
			public Button PayRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    APRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPrepaymentRefNbr\'] div[class=\'e" +
                            "ditBtnCont\'] > div > div", "APRefNbrEdit", "ctl00_phG_tab_t7_PrepaymentGrid_lv0");
                    APRefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PayRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_PrepaymentGrid_lv0_edPaymentRefNbr\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "PayRefNbrEdit", "ctl00_phG_tab_t7_PrepaymentGrid_lv0");
                    PayRefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c_header_matrixentryformview : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TemplateItemID { get; }
			public Label TemplateItemIDLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
            
            public c_header_matrixentryformview(string locator, string name) : 
                    base(locator, name)
            {
                TemplateItemID = new Selector("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView_edEntryTemplateItemI" +
                        "D", "Template Item ID", locator, null);
                TemplateItemIDLabel = new Label(TemplateItemID);
                TemplateItemID.DataField = "TemplateItemID";
                Description = new PXTextEdit("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView_edEntryDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                SiteID = new Selector("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView_selEntrySiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                DataMemberName = "Header";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void OpenMatrixView()
            {
                Buttons.OpenMatrixView.Click();
            }
            
            public virtual void Addandclose()
            {
                Buttons.Addandclose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button OpenMatrixView { get; }
			public Button Addandclose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsT" +
                            "axCategoryID\'] div[class=\'editBtnCont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    OpenMatrixView = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonToLo" +
                            "okup", "Open Matrix View", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView");
                    Addandclose = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonOK", "Add and close", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView");
                    Cancel = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonCanc" +
                            "el", "Cancel", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView");
                }
            }
        }
        
        public class c_header_matrixformview : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TemplateItemID { get; }
			public Label TemplateItemIDLabel { get; }
			public Selector ColAttributeID { get; }
			public Label ColAttributeIDLabel { get; }
			public Selector RowAttributeID { get; }
			public Label RowAttributeIDLabel { get; }
			public CheckBox ShowAvailable { get; }
			public Label ShowAvailableLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
            
            public c_header_matrixformview(string locator, string name) : 
                    base(locator, name)
            {
                TemplateItemID = new Selector("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView_edTemplateItemID", "Template Item ID", locator, null);
                TemplateItemIDLabel = new Label(TemplateItemID);
                TemplateItemID.DataField = "TemplateItemID";
                ColAttributeID = new Selector("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView_selColumnAttributeID", "Col Attribute ID", locator, null);
                ColAttributeIDLabel = new Label(ColAttributeID);
                ColAttributeID.DataField = "ColAttributeID";
                RowAttributeID = new Selector("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView_selRowAttributeID", "Row Attribute ID", locator, null);
                RowAttributeIDLabel = new Label(RowAttributeID);
                RowAttributeID.DataField = "RowAttributeID";
                ShowAvailable = new CheckBox("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView_edShowAvailable", "Show Available", locator, null);
                ShowAvailableLabel = new Label(ShowAvailable);
                ShowAvailable.DataField = "ShowAvailable";
                SiteID = new Selector("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView_selSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                DataMemberName = "Header";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Addandclose()
            {
                Buttons.Addandclose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Addandclose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Addandclose = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonOK" +
                            "", "Add and close", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView");
                    Cancel = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonCa" +
                            "ncel", "Cancel", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView");
                }
            }
        }
        
        public class c_additionalattributes_matrixattributes : Grid<c_additionalattributes_matrixattributes.c_grid_row, c_additionalattributes_matrixattributes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_additionalattributes_matrixattributes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes");
                DataMemberName = "AdditionalAttributes";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_fe_gf", "FilterForm");
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
            
            public virtual void Addandclose()
            {
                Buttons.Addandclose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_at_tlb div[data-c" +
                            "md=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_at_tlb div[data-c" +
                            "md=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_at_tlb div[data-c" +
                            "md=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_at_tlb div[data-c" +
                            "md=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_ab_tlb div[data-c" +
                            "md=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_ab_tlb div[data-c" +
                            "md=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_ab_tlb div[data-c" +
                            "md=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_ab_tlb div[data-c" +
                            "md=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_ab_tlb div[data-c" +
                            "md=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Addandclose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Addandclose = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonOK" +
                            "", "Add and close", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes");
                    Cancel = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonCa" +
                            "ncel", "Cancel", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector Extra { get; }
                
                public c_grid_row(c_additionalattributes_matrixattributes grid) : 
                        base(grid)
                {
                    Extra = new Selector("_ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_lv0_es", "Template Item", grid.Locator, "Extra");
                    Extra.DataField = "Extra";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter Extra { get; }
                
                public c_grid_header(c_additionalattributes_matrixattributes grid) : 
                        base(grid)
                {
                    Extra = new SelectorColumnFilter(grid.Row.Extra);
                }
            }
        }
        
        public class c_additionalattributes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_additionalattributes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "AdditionalAttributes";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Addandclose()
            {
                Buttons.Addandclose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Addandclose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Addandclose = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonOK" +
                            "", "Add and close", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_lv0");
                    Cancel = new Button("ctl00_phG_InventoryMatrixLookupSmartPanel_InventoryMatrixLookupSmartPanelButtonCa" +
                            "ncel", "Cancel", "ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_lv0");
                }
            }
        }
        
        public class c_matrixitems_matrixitems : Grid<c_matrixitems_matrixitems.c_grid_row, c_matrixitems_matrixitems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_matrixitems_matrixitems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems");
                DataMemberName = "MatrixItems";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_fe_gf", "FilterForm");
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
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void OpenMatrixView()
            {
                Buttons.OpenMatrixView.Click();
            }
            
            public virtual void Addandclose()
            {
                Buttons.Addandclose.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_at_tlb div[data-cmd=\'Re" +
                            "fresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_at_tlb div[data-cmd=\'Ad" +
                            "dNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_at_tlb div[data-cmd=\'De" +
                            "lete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_at_tlb div[data-cmd=\'Ad" +
                            "justColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_at_tlb div[data-cmd=\'Ex" +
                            "portExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_at_tlb div[data-cmd=\'hi" +
                            "\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_ab_tlb div[data-cmd=\'Pa" +
                            "geFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_ab_tlb div[data-cmd=\'Pa" +
                            "gePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_ab_tlb div[data-cmd=\'Pa" +
                            "geNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_ab_tlb div[data-cmd=\'Pa" +
                            "geLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_ab_tlb div[data-cmd=\'hi" +
                            "\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button OpenMatrixView { get; }
			public Button Addandclose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsT" +
                            "axCategoryID\'] div[class=\'editBtnCont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    OpenMatrixView = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonToLo" +
                            "okup", "Open Matrix View", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems");
                    Addandclose = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonOK", "Add and close", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems");
                    Cancel = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonCanc" +
                            "el", "Cancel", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXNumberEdit Qty { get; }
			public Selector InventoryCD { get; }
			public InputLocalizable Descr { get; }
			public CheckBox New { get; }
			public PXTextEdit AttributeValue0 { get; }
			public CheckBox StkItem { get; }
			public PXNumberEdit BasePrice { get; }
			public Selector ItemClassID { get; }
			public Selector TaxCategoryID { get; }
                
                public c_grid_row(c_matrixitems_matrixitems grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Qty = new PXNumberEdit("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_en", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    InventoryCD = new Selector("_ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsInventoryCD", "Inventory ID", grid.Locator, "InventoryCD");
                    InventoryCD.DataField = "InventoryCD";
                    Descr = new InputLocalizable("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    New = new CheckBox("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems", "New", grid.Locator, "New");
                    New.DataField = "New";
                    AttributeValue0 = new PXTextEdit("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_ei", "Attribute Value 0", grid.Locator, "AttributeValue0");
                    AttributeValue0.DataField = "AttributeValue0";
                    StkItem = new CheckBox("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems", "Stock Item", grid.Locator, "StkItem");
                    StkItem.DataField = "StkItem";
                    BasePrice = new PXNumberEdit("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_en", "Default Price", grid.Locator, "BasePrice");
                    BasePrice.DataField = "BasePrice";
                    ItemClassID = new Selector("_ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsItemClassID", "Item Class", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    TaxCategoryID = new Selector("_ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsTaxCategoryI" +
                            "D", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter InventoryCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter New { get; }
				public PXTextEditColumnFilter AttributeValue0 { get; }
				public CheckBoxColumnFilter StkItem { get; }
				public PXNumberEditColumnFilter BasePrice { get; }
				public SelectorColumnFilter ItemClassID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
                
                public c_grid_header(c_matrixitems_matrixitems grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    InventoryCD = new SelectorColumnFilter(grid.Row.InventoryCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    New = new CheckBoxColumnFilter(grid.Row.New);
                    AttributeValue0 = new PXTextEditColumnFilter(grid.Row.AttributeValue0);
                    StkItem = new CheckBoxColumnFilter(grid.Row.StkItem);
                    BasePrice = new PXNumberEditColumnFilter(grid.Row.BasePrice);
                    ItemClassID = new SelectorColumnFilter(grid.Row.ItemClassID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                }
            }
        }
        
        public class c_matrixitems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryCD { get; }
			public Label InventoryCDLabel { get; }
			public Selector DfltSiteID { get; }
			public Label DfltSiteIDLabel { get; }
			public Selector ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_matrixitems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryCD = new Selector("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsInventoryCD", "Inventory ID", locator, null);
                InventoryCDLabel = new Label(InventoryCD);
                InventoryCD.DataField = "InventoryCD";
                DfltSiteID = new Selector("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsDfltSiteID", "Default Warehouse", locator, null);
                DfltSiteIDLabel = new Label(DfltSiteID);
                DfltSiteID.DataField = "DfltSiteID";
                ItemClassID = new Selector("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsItemClassID", "Item Class", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                TaxCategoryID = new Selector("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsTaxCategoryID" +
                        "", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                Es = new Selector("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "MatrixItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryCDEdit()
            {
                Buttons.InventoryCDEdit.Click();
            }
            
            public virtual void DfltSiteIDEdit()
            {
                Buttons.DfltSiteIDEdit.Click();
            }
            
            public virtual void ItemClassIDEdit()
            {
                Buttons.ItemClassIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void OpenMatrixView()
            {
                Buttons.OpenMatrixView.Click();
            }
            
            public virtual void Addandclose()
            {
                Buttons.Addandclose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryCDEdit { get; }
			public Button DfltSiteIDEdit { get; }
			public Button ItemClassIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button OpenMatrixView { get; }
			public Button Addandclose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    InventoryCDEdit = new Button("css=div[id=\'ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsI" +
                            "nventoryCD\'] div[class=\'editBtnCont\'] > div > div", "InventoryCDEdit", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0");
                    InventoryCDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DfltSiteIDEdit = new Button("css=div[id=\'ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsD" +
                            "fltSiteID\'] div[class=\'editBtnCont\'] > div > div", "DfltSiteIDEdit", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0");
                    DfltSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsI" +
                            "temClassID\'] div[class=\'editBtnCont\'] > div > div", "ItemClassIDEdit", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0");
                    ItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0_matrixItemsT" +
                            "axCategoryID\'] div[class=\'editBtnCont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    OpenMatrixView = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonToLo" +
                            "okup", "Open Matrix View", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0");
                    Addandclose = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonOK", "Add and close", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0");
                    Cancel = new Button("ctl00_phG_InventoryMatrixEntrySmartPanel_InventoryMatrixEntrySmartPanelButtonCanc" +
                            "el", "Cancel", "ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0");
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t10_grdComplianceDocuments");
                DataMemberName = "ComplianceDocuments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t10_grdComplianceDocuments_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_at_tlb div[data-cmd=\'AdjustColumns\'" +
                            "]", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_grdComplianceDocuments_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ExpirationDate { get; }
			public Selector DocumentType { get; }
			public PXTextEdit CreationDate { get; }
			public Selector Status { get; }
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
			public Selector VendorID { get; }
			public PXTextEdit VendorName { get; }
			public Selector PurchaseOrder { get; }
			public Selector PurchaseOrderLineItem { get; }
			public Selector Subcontract { get; }
			public Selector SubcontractLineItem { get; }
			public Selector ChangeOrderNumber { get; }
			public Selector AccountID { get; }
			public Selector ApCheckID { get; }
			public PXTextEdit CheckNumber { get; }
			public Selector ArPaymentID { get; }
			public PXTextEdit BillAmount { get; }
			public Selector BillID { get; }
			public PXTextEdit CertificateNumber { get; }
			public PXTextEdit CreatedByID { get; }
			public PXTextEdit CustomerID { get; }
			public PXTextEdit CustomerName { get; }
			public PXTextEdit DateIssued { get; }
			public Selector DocumentTypeValue { get; }
			public PXTextEdit EffectiveDate { get; }
			public PXTextEdit InsuranceCompany { get; }
			public PXTextEdit InvoiceAmount { get; }
			public Selector InvoiceID { get; }
			public CheckBox IsExpired { get; }
			public CheckBox IsRequiredJointCheck { get; }
			public PXTextEdit JointAmount { get; }
			public PXTextEdit JointRelease { get; }
			public PXTextEdit JointReleaseReceived { get; }
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
			public PXTextEdit ReceiptDate { get; }
			public PXTextEdit ReceiveDate { get; }
			public PXTextEdit ReceivedBy { get; }
			public PXTextEdit SecondaryVendorID { get; }
			public PXTextEdit SecondaryVendorName { get; }
			public PXTextEdit SponsorOrganization { get; }
			public PXTextEdit ThroughDate { get; }
			public PXTextEdit SourceType { get; }
                
                public c_grid_row(c_compliancedocuments_grdcompliancedocuments grid) : 
                        base(grid)
                {
                    ExpirationDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Expiration Date", grid.Locator, "ExpirationDate");
                    ExpirationDate.DataField = "ExpirationDate";
                    DocumentType = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edDocumentType", "Document Type", grid.Locator, "DocumentType");
                    DocumentType.DataField = "DocumentType";
                    CreationDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Creation Date", grid.Locator, "CreationDate");
                    CreationDate.DataField = "CreationDate";
                    Status = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edStatus", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Required = new CheckBox("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    Received = new CheckBox("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Received", grid.Locator, "Received");
                    Received.DataField = "Received";
                    ReceivedDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Received Date", grid.Locator, "ReceivedDate");
                    ReceivedDate.DataField = "ReceivedDate";
                    IsProcessed = new CheckBox("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Is Processed", grid.Locator, "IsProcessed");
                    IsProcessed.DataField = "IsProcessed";
                    IsVoided = new CheckBox("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Is Voided", grid.Locator, "IsVoided");
                    IsVoided.DataField = "IsVoided";
                    IsCreatedAutomatically = new CheckBox("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Is Created Automatically", grid.Locator, "IsCreatedAutomatically");
                    IsCreatedAutomatically.DataField = "IsCreatedAutomatically";
                    SentDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Sent Date", grid.Locator, "SentDate");
                    SentDate.DataField = "SentDate";
                    ProjectID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edComplianceProjectID", "Project ID", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    CostTaskID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", grid.Locator, "CostTaskID");
                    CostTaskID.DataField = "CostTaskID";
                    RevenueTaskID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", grid.Locator, "RevenueTaskID");
                    RevenueTaskID.DataField = "RevenueTaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    VendorID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edVendorID", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorName = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Vendor Name", grid.Locator, "VendorName");
                    VendorName.DataField = "VendorName";
                    PurchaseOrder = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", grid.Locator, "PurchaseOrder");
                    PurchaseOrder.DataField = "PurchaseOrder";
                    PurchaseOrderLineItem = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", grid.Locator, "PurchaseOrderLineItem");
                    PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                    Subcontract = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", grid.Locator, "Subcontract");
                    Subcontract.DataField = "Subcontract";
                    SubcontractLineItem = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", grid.Locator, "SubcontractLineItem");
                    SubcontractLineItem.DataField = "SubcontractLineItem";
                    ChangeOrderNumber = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", grid.Locator, "ChangeOrderNumber");
                    ChangeOrderNumber.DataField = "ChangeOrderNumber";
                    AccountID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edAccountID", "Account ID", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    ApCheckID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", grid.Locator, "ApCheckID");
                    ApCheckID.DataField = "ApCheckID";
                    CheckNumber = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Check Number", grid.Locator, "CheckNumber");
                    CheckNumber.DataField = "CheckNumber";
                    ArPaymentID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", grid.Locator, "ArPaymentID");
                    ArPaymentID.DataField = "ArPaymentID";
                    BillAmount = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Bill Amount", grid.Locator, "BillAmount");
                    BillAmount.DataField = "BillAmount";
                    BillID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edBillID", "Bill ID", grid.Locator, "BillID");
                    BillID.DataField = "BillID";
                    CertificateNumber = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Certificate Number", grid.Locator, "CertificateNumber");
                    CertificateNumber.DataField = "CertificateNumber";
                    CreatedByID = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Created By ID", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CustomerID = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Customer ID", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    CustomerName = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Customer Name", grid.Locator, "CustomerName");
                    CustomerName.DataField = "CustomerName";
                    DateIssued = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Date Issued", grid.Locator, "DateIssued");
                    DateIssued.DataField = "DateIssued";
                    DocumentTypeValue = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", grid.Locator, "DocumentTypeValue");
                    DocumentTypeValue.DataField = "DocumentTypeValue";
                    EffectiveDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Effective Date", grid.Locator, "EffectiveDate");
                    EffectiveDate.DataField = "EffectiveDate";
                    InsuranceCompany = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Insurance Company", grid.Locator, "InsuranceCompany");
                    InsuranceCompany.DataField = "InsuranceCompany";
                    InvoiceAmount = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Invoice Amount", grid.Locator, "InvoiceAmount");
                    InvoiceAmount.DataField = "InvoiceAmount";
                    InvoiceID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", grid.Locator, "InvoiceID");
                    InvoiceID.DataField = "InvoiceID";
                    IsExpired = new CheckBox("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Is Expired", grid.Locator, "IsExpired");
                    IsExpired.DataField = "IsExpired";
                    IsRequiredJointCheck = new CheckBox("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Is Required Joint Check", grid.Locator, "IsRequiredJointCheck");
                    IsRequiredJointCheck.DataField = "IsRequiredJointCheck";
                    JointAmount = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Joint Amount", grid.Locator, "JointAmount");
                    JointAmount.DataField = "JointAmount";
                    JointRelease = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Joint Release", grid.Locator, "JointRelease");
                    JointRelease.DataField = "JointRelease";
                    JointReleaseReceived = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Joint Release Received", grid.Locator, "JointReleaseReceived");
                    JointReleaseReceived.DataField = "JointReleaseReceived";
                    JointVendorInternalId = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Joint Vendor Internal Id", grid.Locator, "JointVendorInternalId");
                    JointVendorInternalId.DataField = "JointVendorInternalId";
                    JointVendorExternalName = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Joint Vendor External Name", grid.Locator, "JointVendorExternalName");
                    JointVendorExternalName.DataField = "JointVendorExternalName";
                    LastModifiedByID = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Last Modified By ID", grid.Locator, "LastModifiedByID");
                    LastModifiedByID.DataField = "LastModifiedByID";
                    LienWaiverAmount = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Lien Waiver Amount", grid.Locator, "LienWaiverAmount");
                    LienWaiverAmount.DataField = "LienWaiverAmount";
                    Limit = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Limit", grid.Locator, "Limit");
                    Limit.DataField = "Limit";
                    MethodSent = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Method Sent", grid.Locator, "MethodSent");
                    MethodSent.DataField = "MethodSent";
                    PaymentDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Payment Date", grid.Locator, "PaymentDate");
                    PaymentDate.DataField = "PaymentDate";
                    ArPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Ar Payment Method ID", grid.Locator, "ArPaymentMethodID");
                    ArPaymentMethodID.DataField = "ArPaymentMethodID";
                    ApPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Ap Payment Method ID", grid.Locator, "ApPaymentMethodID");
                    ApPaymentMethodID.DataField = "ApPaymentMethodID";
                    Policy = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Policy", grid.Locator, "Policy");
                    Policy.DataField = "Policy";
                    ProjectTransactionID = new Selector("_ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", grid.Locator, "ProjectTransactionID");
                    ProjectTransactionID.DataField = "ProjectTransactionID";
                    ReceiptDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Receipt Date", grid.Locator, "ReceiptDate");
                    ReceiptDate.DataField = "ReceiptDate";
                    ReceiveDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Receive Date", grid.Locator, "ReceiveDate");
                    ReceiveDate.DataField = "ReceiveDate";
                    ReceivedBy = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Received By", grid.Locator, "ReceivedBy");
                    ReceivedBy.DataField = "ReceivedBy";
                    SecondaryVendorID = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Secondary Vendor ID", grid.Locator, "SecondaryVendorID");
                    SecondaryVendorID.DataField = "SecondaryVendorID";
                    SecondaryVendorName = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Secondary Vendor Name", grid.Locator, "SecondaryVendorName");
                    SecondaryVendorName.DataField = "SecondaryVendorName";
                    SponsorOrganization = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Sponsor Organization", grid.Locator, "SponsorOrganization");
                    SponsorOrganization.DataField = "SponsorOrganization";
                    ThroughDate = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Through Date", grid.Locator, "ThroughDate");
                    ThroughDate.DataField = "ThroughDate";
                    SourceType = new PXTextEdit("ctl00_phG_tab_t10_grdComplianceDocuments_ei", "Source Type", grid.Locator, "SourceType");
                    SourceType.DataField = "SourceType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ExpirationDate { get; }
				public SelectorColumnFilter DocumentType { get; }
				public PXTextEditColumnFilter CreationDate { get; }
				public SelectorColumnFilter Status { get; }
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
				public SelectorColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorName { get; }
				public InputColumnFilter PurchaseOrder { get; }
				public SelectorColumnFilter PurchaseOrderLineItem { get; }
				public SelectorColumnFilter Subcontract { get; }
				public SelectorColumnFilter SubcontractLineItem { get; }
				public SelectorColumnFilter ChangeOrderNumber { get; }
				public SelectorColumnFilter AccountID { get; }
				public InputColumnFilter ApCheckID { get; }
				public PXTextEditColumnFilter CheckNumber { get; }
				public InputColumnFilter ArPaymentID { get; }
				public PXTextEditColumnFilter BillAmount { get; }
				public InputColumnFilter BillID { get; }
				public PXTextEditColumnFilter CertificateNumber { get; }
				public PXTextEditColumnFilter CreatedByID { get; }
				public PXTextEditColumnFilter CustomerID { get; }
				public PXTextEditColumnFilter CustomerName { get; }
				public PXTextEditColumnFilter DateIssued { get; }
				public SelectorColumnFilter DocumentTypeValue { get; }
				public PXTextEditColumnFilter EffectiveDate { get; }
				public PXTextEditColumnFilter InsuranceCompany { get; }
				public PXTextEditColumnFilter InvoiceAmount { get; }
				public InputColumnFilter InvoiceID { get; }
				public CheckBoxColumnFilter IsExpired { get; }
				public CheckBoxColumnFilter IsRequiredJointCheck { get; }
				public PXTextEditColumnFilter JointAmount { get; }
				public PXTextEditColumnFilter JointRelease { get; }
				public PXTextEditColumnFilter JointReleaseReceived { get; }
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
				public PXTextEditColumnFilter ReceiptDate { get; }
				public PXTextEditColumnFilter ReceiveDate { get; }
				public PXTextEditColumnFilter ReceivedBy { get; }
				public PXTextEditColumnFilter SecondaryVendorID { get; }
				public PXTextEditColumnFilter SecondaryVendorName { get; }
				public PXTextEditColumnFilter SponsorOrganization { get; }
				public PXTextEditColumnFilter ThroughDate { get; }
				public PXTextEditColumnFilter SourceType { get; }
                
                public c_grid_header(c_compliancedocuments_grdcompliancedocuments grid) : 
                        base(grid)
                {
                    ExpirationDate = new PXTextEditColumnFilter(grid.Row.ExpirationDate);
                    DocumentType = new SelectorColumnFilter(grid.Row.DocumentType);
                    CreationDate = new PXTextEditColumnFilter(grid.Row.CreationDate);
                    Status = new SelectorColumnFilter(grid.Row.Status);
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
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    VendorName = new PXTextEditColumnFilter(grid.Row.VendorName);
                    PurchaseOrder = new InputColumnFilter(grid.Row.PurchaseOrder);
                    PurchaseOrderLineItem = new SelectorColumnFilter(grid.Row.PurchaseOrderLineItem);
                    Subcontract = new SelectorColumnFilter(grid.Row.Subcontract);
                    SubcontractLineItem = new SelectorColumnFilter(grid.Row.SubcontractLineItem);
                    ChangeOrderNumber = new SelectorColumnFilter(grid.Row.ChangeOrderNumber);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    ApCheckID = new InputColumnFilter(grid.Row.ApCheckID);
                    CheckNumber = new PXTextEditColumnFilter(grid.Row.CheckNumber);
                    ArPaymentID = new InputColumnFilter(grid.Row.ArPaymentID);
                    BillAmount = new PXTextEditColumnFilter(grid.Row.BillAmount);
                    BillID = new InputColumnFilter(grid.Row.BillID);
                    CertificateNumber = new PXTextEditColumnFilter(grid.Row.CertificateNumber);
                    CreatedByID = new PXTextEditColumnFilter(grid.Row.CreatedByID);
                    CustomerID = new PXTextEditColumnFilter(grid.Row.CustomerID);
                    CustomerName = new PXTextEditColumnFilter(grid.Row.CustomerName);
                    DateIssued = new PXTextEditColumnFilter(grid.Row.DateIssued);
                    DocumentTypeValue = new SelectorColumnFilter(grid.Row.DocumentTypeValue);
                    EffectiveDate = new PXTextEditColumnFilter(grid.Row.EffectiveDate);
                    InsuranceCompany = new PXTextEditColumnFilter(grid.Row.InsuranceCompany);
                    InvoiceAmount = new PXTextEditColumnFilter(grid.Row.InvoiceAmount);
                    InvoiceID = new InputColumnFilter(grid.Row.InvoiceID);
                    IsExpired = new CheckBoxColumnFilter(grid.Row.IsExpired);
                    IsRequiredJointCheck = new CheckBoxColumnFilter(grid.Row.IsRequiredJointCheck);
                    JointAmount = new PXTextEditColumnFilter(grid.Row.JointAmount);
                    JointRelease = new PXTextEditColumnFilter(grid.Row.JointRelease);
                    JointReleaseReceived = new PXTextEditColumnFilter(grid.Row.JointReleaseReceived);
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
                    ReceiptDate = new PXTextEditColumnFilter(grid.Row.ReceiptDate);
                    ReceiveDate = new PXTextEditColumnFilter(grid.Row.ReceiveDate);
                    ReceivedBy = new PXTextEditColumnFilter(grid.Row.ReceivedBy);
                    SecondaryVendorID = new PXTextEditColumnFilter(grid.Row.SecondaryVendorID);
                    SecondaryVendorName = new PXTextEditColumnFilter(grid.Row.SecondaryVendorName);
                    SponsorOrganization = new PXTextEditColumnFilter(grid.Row.SponsorOrganization);
                    ThroughDate = new PXTextEditColumnFilter(grid.Row.ThroughDate);
                    SourceType = new PXTextEditColumnFilter(grid.Row.SourceType);
                }
            }
        }
        
        public class c_compliancedocuments_lv0 : Container
        {
            
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
			public Selector DocumentType { get; }
			public Label DocumentTypeLabel { get; }
			public Selector Status { get; }
			public Label StatusLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector CostTaskID { get; }
			public Label CostTaskIDLabel { get; }
			public Selector RevenueTaskID { get; }
			public Label RevenueTaskIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
            
            public c_compliancedocuments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                DocumentTypeValue = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", locator, null);
                DocumentTypeValueLabel = new Label(DocumentTypeValue);
                DocumentTypeValue.DataField = "DocumentTypeValue";
                BillID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edBillID", "Bill ID", locator, null);
                BillIDLabel = new Label(BillID);
                BillID.DataField = "BillID";
                InvoiceID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", locator, null);
                InvoiceIDLabel = new Label(InvoiceID);
                InvoiceID.DataField = "InvoiceID";
                ApCheckID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", locator, null);
                ApCheckIDLabel = new Label(ApCheckID);
                ApCheckID.DataField = "ApCheckID";
                ArPaymentID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", locator, null);
                ArPaymentIDLabel = new Label(ArPaymentID);
                ArPaymentID.DataField = "ArPaymentID";
                ProjectTransactionID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", locator, null);
                ProjectTransactionIDLabel = new Label(ProjectTransactionID);
                ProjectTransactionID.DataField = "ProjectTransactionID";
                PurchaseOrder = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", locator, null);
                PurchaseOrderLabel = new Label(PurchaseOrder);
                PurchaseOrder.DataField = "PurchaseOrder";
                PurchaseOrderLineItem = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", locator, null);
                PurchaseOrderLineItemLabel = new Label(PurchaseOrderLineItem);
                PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                Subcontract = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", locator, null);
                SubcontractLabel = new Label(Subcontract);
                Subcontract.DataField = "Subcontract";
                SubcontractLineItem = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", locator, null);
                SubcontractLineItemLabel = new Label(SubcontractLineItem);
                SubcontractLineItem.DataField = "SubcontractLineItem";
                ChangeOrderNumber = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", locator, null);
                ChangeOrderNumberLabel = new Label(ChangeOrderNumber);
                ChangeOrderNumber.DataField = "ChangeOrderNumber";
                DocumentType = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edDocumentType", "Document Type", locator, null);
                DocumentTypeLabel = new Label(DocumentType);
                DocumentType.DataField = "DocumentType";
                Status = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                VendorID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edVendorID", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                AccountID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edAccountID", "Account ID", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                CostTaskID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", locator, null);
                CostTaskIDLabel = new Label(CostTaskID);
                CostTaskID.DataField = "CostTaskID";
                RevenueTaskID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", locator, null);
                RevenueTaskIDLabel = new Label(RevenueTaskID);
                RevenueTaskID.DataField = "RevenueTaskID";
                ProjectID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edComplianceProjectID", "Project ID", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                CostCodeID = new Selector("ctl00_phG_tab_t10_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                DataMemberName = "ComplianceDocuments";
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
                DataMemberName = "Transactions$ImportCSVSettings";
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
                DataMemberName = "Transactions$ImportXLSXSettings";
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
                DataMemberName = "Transactions$ImportColumns";
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
                DataMemberName = "Transactions$ImportColumns";
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
