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
using Controls.UnknownControl;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ACBC.Tests.Wrappers
{
    
    
    public class SO301000_SOOrderEntry : Wrapper
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
        protected c__soorder_currencyinfo__rf _SOOrder_CurrencyInfo__rf { get; } = new c__soorder_currencyinfo__rf("ctl00_phF_form_t0_edCury_pnlRate_rf", "_SOOrder_CurrencyInfo__rf");
        protected c_currentdocument_commission CurrentDocument_Commission { get; } = new c_currentdocument_commission("ctl00_phG_tab_t3_Commission", "CurrentDocument_Commission");
        protected c_currentdocument_formp CurrentDocument_formP { get; } = new c_currentdocument_formp("ctl00_phG_tab_t4_formP", "CurrentDocument_formP");
        protected c_currentdocument_forme CurrentDocument_formE { get; } = new c_currentdocument_forme("ctl00_phG_tab_t4_formE", "CurrentDocument_formE");
        protected c_currentdocument_formf CurrentDocument_formF { get; } = new c_currentdocument_formf("ctl00_phG_tab_t5_formF", "CurrentDocument_formF");
        protected c_currentdocument_discountparameters CurrentDocument_DiscountParameters { get; } = new c_currentdocument_discountparameters("ctl00_phG_tab_t6_DiscountParameters", "CurrentDocument_DiscountParameters");
        protected c_currentdocument_formpt CurrentDocument_formPT { get; } = new c_currentdocument_formpt("ctl00_phG_tab_t8_formPT", "CurrentDocument_formPT");
        protected c_currentdocument_formg CurrentDocument_formG { get; } = new c_currentdocument_formg("ctl00_phG_tab_t9_formG", "CurrentDocument_formG");
        protected c_documentproperties_formcarrierrates DocumentProperties_formCarrierRates { get; } = new c_documentproperties_formcarrierrates("ctl00_phG_PanelCarrierRates_formCarrierRates", "DocumentProperties_formCarrierRates");
        protected c_documentproperties_pxformview1 DocumentProperties_PXFormView1 { get; } = new c_documentproperties_pxformview1("ctl00_phG_PanelCarrierRates_PXFormView1", "DocumentProperties_PXFormView1");
        protected c_rutrots_rutrotform Rutrots_RUTROTForm { get; } = new c_rutrots_rutrotform("ctl00_phG_tab_t11_RUTROTForm", "Rutrots_RUTROTForm");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "Transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "Transactions_lv0");
        protected c_currentposupply_formcurrentposupply Currentposupply_formcurrentposupply { get; } = new c_currentposupply_formcurrentposupply("ctl00_phG_PanelPOSupply_formCurrentPOSupply", "currentposupply_formCurrentPOSupply");
        protected c_amsolinerecords_createprodgrid AMSOLineRecords_CreateProdgrid { get; } = new c_amsolinerecords_createprodgrid("ctl00_phG_PanelCreateProdOrder_CreateProdgrid", "AMSOLineRecords_CreateProdgrid");
        protected c_amsolinerecords_lv0 AMSOLineRecords_lv0 { get; } = new c_amsolinerecords_lv0("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0", "AMSOLineRecords_lv0");
        protected c_taxes_grid1 Taxes_grid1 { get; } = new c_taxes_grid1("ctl00_phG_tab_t2_grid1", "Taxes_grid1");
        protected c_taxes_lv0 Taxes_lv0 { get; } = new c_taxes_lv0("ctl00_phG_tab_t2_grid1_lv0", "Taxes_lv0");
        protected c_shipmentlist_grid5 ShipmentList_grid5 { get; } = new c_shipmentlist_grid5("ctl00_phG_tab_t7_grid5", "ShipmentList_grid5");
        protected c_shipmentlist_lv0 ShipmentList_lv0 { get; } = new c_shipmentlist_lv0("ctl00_phG_tab_t7_grid5_lv0", "ShipmentList_lv0");
        protected c_billing_address_forma Billing_Address_formA { get; } = new c_billing_address_forma("ctl00_phG_tab_t4_formA", "Billing_Address_formA");
        protected c_shipping_address_formb Shipping_Address_formB { get; } = new c_shipping_address_formb("ctl00_phG_tab_t5_formB", "Shipping_Address_formB");
        protected c_billing_contact_formc Billing_Contact_formC { get; } = new c_billing_contact_formc("ctl00_phG_tab_t4_formC", "Billing_Contact_formC");
        protected c_shipping_contact_formd Shipping_Contact_formD { get; } = new c_shipping_contact_formd("ctl00_phG_tab_t5_formD", "Shipping_Contact_formD");
        protected c_approval_gridapproval Approval_gridApproval { get; } = new c_approval_gridapproval("ctl00_phG_tab_t10_gridApproval", "Approval_gridApproval");
        protected c_approval_lv0 Approval_lv0 { get; } = new c_approval_lv0("ctl00_phG_tab_t10_gridApproval_lv0", "Approval_lv0");
        protected c_discountdetails_formdiscountdetail DiscountDetails_formDiscountDetail { get; } = new c_discountdetails_formdiscountdetail("ctl00_phG_tab_t6_formDiscountDetail", "DiscountDetails_formDiscountDetail");
        protected c_discountdetails_lv0 DiscountDetails_lv0 { get; } = new c_discountdetails_lv0("ctl00_phG_tab_t6_formDiscountDetail_lv0", "DiscountDetails_lv0");
        protected c_splits_grid2 Splits_grid2 { get; } = new c_splits_grid2("ctl00_phG_PanelLS_grid2", "splits_grid2");
        protected c_splits_lv0 Splits_lv0 { get; } = new c_splits_lv0("ctl00_phG_PanelLS_grid2_lv0", "splits_lv0");
        protected c_soparamfilter_formcreateshipment Soparamfilter_formcreateshipment { get; } = new c_soparamfilter_formcreateshipment("ctl00_phG_pnlCreateShipment_formCreateShipment", "soparamfilter_formCreateShipment");
        protected c_addinvoicefilter_form4 Addinvoicefilter_form4 { get; } = new c_addinvoicefilter_form4("ctl00_phDS_PanelAddInvoice_form4", "addinvoicefilter_form4");
        protected c_copyparamfilter_formcopyto Copyparamfilter_formcopyto { get; } = new c_copyparamfilter_formcopyto("ctl00_phG_panelCopyTo_formCopyTo", "copyparamfilter_formCopyTo");
        protected c_recalcdiscountsfilter_formrecalcdiscounts Recalcdiscountsfilter_formrecalcdiscounts { get; } = new c_recalcdiscountsfilter_formrecalcdiscounts("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts", "recalcdiscountsfilter_formRecalcDiscounts");
        protected c_invoicesplits_grid4 Invoicesplits_grid4 { get; } = new c_invoicesplits_grid4("ctl00_phDS_PanelAddInvoice_grid4", "invoicesplits_grid4");
        protected c_invoicesplits_lv0 Invoicesplits_lv0 { get; } = new c_invoicesplits_lv0("ctl00_phDS_PanelAddInvoice_grid4_lv0", "invoicesplits_lv0");
        protected c_posupply_gridposupply Posupply_gridposupply { get; } = new c_posupply_gridposupply("ctl00_phG_PanelPOSupply_gridPOSupply", "posupply_gridPOSupply");
        protected c_posupply_lv0 Posupply_lv0 { get; } = new c_posupply_lv0("ctl00_phG_PanelPOSupply_gridPOSupply_lv0", "posupply_lv0");
        protected c_salespertran_gridsalespertran SalesPerTran_gridSalesPerTran { get; } = new c_salespertran_gridsalespertran("ctl00_phG_tab_t3_gridSalesPerTran", "SalesPerTran_gridSalesPerTran");
        protected c_salespertran_lv0 SalesPerTran_lv0 { get; } = new c_salespertran_lv0("ctl00_phG_tab_t3_gridSalesPerTran_lv0", "SalesPerTran_lv0");
        protected c_packages_gridpackages Packages_gridPackages { get; } = new c_packages_gridpackages("ctl00_phG_PanelCarrierRates_gridPackages", "Packages_gridPackages");
        protected c_packages_lv0 Packages_lv0 { get; } = new c_packages_lv0("ctl00_phG_PanelCarrierRates_gridPackages_lv0", "Packages_lv0");
        protected c_adjustments_detgrid Adjustments_detgrid { get; } = new c_adjustments_detgrid("ctl00_phG_tab_t8_detgrid", "Adjustments_detgrid");
        protected c_adjustments_lv0 Adjustments_lv0 { get; } = new c_adjustments_lv0("ctl00_phG_tab_t8_detgrid_lv0", "Adjustments_lv0");
        protected c_rrdistribution_griddistribution RRDistribution_gridDistribution { get; } = new c_rrdistribution_griddistribution("ctl00_phG_tab_t11_RUTROTForm_gridDistribution", "RRDistribution_gridDistribution");
        protected c_rrdistribution_lv0 RRDistribution_lv0 { get; } = new c_rrdistribution_lv0("ctl00_phG_tab_t11_RUTROTForm_gridDistribution_lv0", "RRDistribution_lv0");
        protected c_sitestatusfilter_formsitesstatus Sitestatusfilter_formsitesstatus { get; } = new c_sitestatusfilter_formsitesstatus("ctl00_phG_PanelAddSiteStatus_formSitesStatus", "sitestatusfilter_formSitesStatus");
        protected c_sitestatus_gripsitestatus Sitestatus_gripsitestatus { get; } = new c_sitestatus_gripsitestatus("ctl00_phG_PanelAddSiteStatus_gripSiteStatus", "siteStatus_gripSiteStatus");
        protected c_sitestatus_lv0 Sitestatus_lv0 { get; } = new c_sitestatus_lv0("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0", "siteStatus_lv0");
        protected c_carrierrates_gridrates CarrierRates_gridRates { get; } = new c_carrierrates_gridrates("ctl00_phG_PanelCarrierRates_gridRates", "CarrierRates_gridRates");
        protected c_carrierrates_lv0 CarrierRates_lv0 { get; } = new c_carrierrates_lv0("ctl00_phG_PanelCarrierRates_gridRates_lv0", "CarrierRates_lv0");
        protected c_matrix_matrixmatrix Matrix_MatrixMatrix { get; } = new c_matrix_matrixmatrix("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixMatrix", "Matrix_MatrixMatrix");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_quickprocessparameters_fromquickprocess QuickProcessParameters_fromQuickProcess { get; } = new c_quickprocessparameters_fromquickprocess("ctl00_phG_PXSmartPanel1_fromQuickProcess", "QuickProcessParameters_fromQuickProcess");
        protected c_reasonapproverejectparams_pxformviewpanelreason ReasonApproveRejectParams_PXFormViewPanelReason { get; } = new c_reasonapproverejectparams_pxformviewpanelreason("ctl00_phG_panelReason_PXFormViewPanelReason", "ReasonApproveRejectParams_PXFormViewPanelReason");
        protected c_lssoline_lotseropts_optform LSSOLine_lotseropts_optform { get; } = new c_lssoline_lotseropts_optform("ctl00_phG_PanelLS_optform", "LSSOLine_lotseropts_optform");
        protected c_header_matrixentryformview Header_MatrixEntryFormView { get; } = new c_header_matrixentryformview("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixEntryFormView", "Header_MatrixEntryFormView");
        protected c_header_matrixformview Header_MatrixFormView { get; } = new c_header_matrixformview("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixFormView", "Header_MatrixFormView");
        protected c_additionalattributes_matrixattributes AdditionalAttributes_MatrixAttributes { get; } = new c_additionalattributes_matrixattributes("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes", "AdditionalAttributes_MatrixAttributes");
        protected c_additionalattributes_lv0 AdditionalAttributes_lv0 { get; } = new c_additionalattributes_lv0("ctl00_phG_InventoryMatrixLookupSmartPanel_MatrixAttributes_lv0", "AdditionalAttributes_lv0");
        protected c_matrixitems_matrixitems MatrixItems_MatrixItems { get; } = new c_matrixitems_matrixitems("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems", "MatrixItems_MatrixItems");
        protected c_matrixitems_lv0 MatrixItems_lv0 { get; } = new c_matrixitems_lv0("ctl00_phG_InventoryMatrixEntrySmartPanel_MatrixItems_lv0", "MatrixItems_lv0");
        protected c_quickpayment_createpaymentformview QuickPayment_CreatePaymentFormView { get; } = new c_quickpayment_createpaymentformview("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView", "QuickPayment_CreatePaymentFormView");
        protected c_importexternaltran_importpaymentformview ImportExternalTran_ImportPaymentFormView { get; } = new c_importexternaltran_importpaymentformview("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView", "ImportExternalTran_ImportPaymentFormView");
        protected c_orderestimaterecords_gridestimates OrderEstimateRecords_gridEstimates { get; } = new c_orderestimaterecords_gridestimates("ctl00_phG_tab_t1_gridEstimates", "OrderEstimateRecords_gridEstimates");
        protected c_orderestimaterecords_lv0 OrderEstimateRecords_lv0 { get; } = new c_orderestimaterecords_lv0("ctl00_phG_tab_t1_gridEstimates_lv0", "OrderEstimateRecords_lv0");
        protected c_selectedestimaterecord_quickestimateform SelectedEstimateRecord_QuickEstimateForm { get; } = new c_selectedestimaterecord_quickestimateform("ctl00_phG_QuickEstimatePanel_QuickEstimateForm", "SelectedEstimateRecord_QuickEstimateForm");
        protected c_orderestimateitemfilter_estimateaddform OrderEstimateItemFilter_estimateAddForm { get; } = new c_orderestimateitemfilter_estimateaddform("ctl00_phG_AddEstimatePanel_estimateAddForm", "OrderEstimateItemFilter_estimateAddForm");
        protected c_createserviceorderfilter_formcreateserviceorder CreateServiceOrderFilter_formCreateServiceOrder { get; } = new c_createserviceorderfilter_formcreateserviceorder("ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder", "CreateServiceOrderFilter_formCreateServiceOrder");
        protected c_workflowview_workflowfictivediagram WorkflowView_WorkflowFictiveDiagram { get; } = new c_workflowview_workflowfictivediagram("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram", "WorkflowView_WorkflowFictiveDiagram");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_transactions_importcsvsettings_frmimportcsvsettings Transactions_ImportCSVSettings_frmImportCSVSettings { get; } = new c_transactions_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings", "Transactions$ImportCSVSettings_frmImportCSVSettings");
        protected c_transactions_importxlsxsettings_frmimportxlsxsettings Transactions_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_transactions_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "Transactions$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_transactions_importcolumns_grdimportcolumn Transactions_ImportColumns_grdImportColumn { get; } = new c_transactions_importcolumns_grdimportcolumn("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn", "Transactions$ImportColumns_grdImportColumn");
        protected c_transactions_importcolumns_lv0 Transactions_ImportColumns_lv0 { get; } = new c_transactions_importcolumns_lv0("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0", "Transactions$ImportColumns_lv0");
        protected c_processingresults ProcessingResults { get; } = new c_processingresults("ctl00_phDS_ds_pnlQuickInfo", "ProcessingResults");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public SO301000_SOOrderEntry()
        {
            ScreenId = "SO301000";
            ScreenUrl = "/Pages/SO/SO301000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual SO301000_SOOrderEntry ReadOne(Gate gate, string OrderType, string OrderNbr)
        {
            new BiObject<SO301000_SOOrderEntry>(gate).ReadOne(this, OrderType, OrderNbr);
            return this;
        }
        
        public virtual SO301000_SOOrderEntry ReadOne(string OrderType, string OrderNbr)
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
        
        public virtual void ShowWorkflow()
        {
            ToolBar.ShowWorkflow.Click();
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
        
        public virtual void PasteFromQuickorderComputers()
        {
            ToolBar.PasteFromQuickorderComputers.Click();
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
        
        public virtual void InitializeState()
        {
            ToolBar.InitializeState.Click();
        }
        
        public virtual void QuickProcessHidden()
        {
            ToolBar.QuickProcessHidden.Click();
        }
        
        public virtual void CreateShipmentIssueHidden()
        {
            ToolBar.CreateShipmentIssueHidden.Click();
        }
        
        public virtual void CreateShipmentReceiptHidden()
        {
            ToolBar.CreateShipmentReceiptHidden.Click();
        }
        
        public virtual void OpenOrderHidden()
        {
            ToolBar.OpenOrderHidden.Click();
        }
        
        public virtual void ReopenOrderHidden()
        {
            ToolBar.ReopenOrderHidden.Click();
        }
        
        public virtual void CopyOrderHidden()
        {
            ToolBar.CopyOrderHidden.Click();
        }
        
        public virtual void EmailSalesOrderHidden()
        {
            ToolBar.EmailSalesOrderHidden.Click();
        }
        
        public virtual void ReleaseFromCreditHoldHidden()
        {
            ToolBar.ReleaseFromCreditHoldHidden.Click();
        }
        
        public virtual void PrepareInvoiceHidden()
        {
            ToolBar.PrepareInvoiceHidden.Click();
        }
        
        public virtual void PrepareInvoiceHidden(bool status, string message = null)
        {
            ToolBar.PrepareInvoiceHidden.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.PrepareInvoiceHidden.Click();
        }
        
        public virtual void CreatePurchaseOrderHidden()
        {
            ToolBar.CreatePurchaseOrderHidden.Click();
        }
        
        public virtual void CreateTransferOrderHidden()
        {
            ToolBar.CreateTransferOrderHidden.Click();
        }
        
        public virtual void CompleteOrderHidden()
        {
            ToolBar.CompleteOrderHidden.Click();
        }
        
        public virtual void CancelOrderHidden()
        {
            ToolBar.CancelOrderHidden.Click();
        }
        
        public virtual void PlaceOnBackOrderHidden()
        {
            ToolBar.PlaceOnBackOrderHidden.Click();
        }
        
        public virtual void PutOnHoldHidden()
        {
            ToolBar.PutOnHoldHidden.Click();
        }
        
        public virtual void ReleaseFromHoldHidden()
        {
            ToolBar.ReleaseFromHoldHidden.Click();
        }
        
        public virtual void CreateAndAuthorizePaymentHidden()
        {
            ToolBar.CreateAndAuthorizePaymentHidden.Click();
        }
        
        public virtual void CreateAndCapturePaymentHidden()
        {
            ToolBar.CreateAndCapturePaymentHidden.Click();
        }
        
        public virtual void PrintSalesOrderHidden()
        {
            ToolBar.PrintSalesOrderHidden.Click();
        }
        
        public virtual void ApproveHidden()
        {
            ToolBar.ApproveHidden.Click();
        }
        
        public virtual void RejectHidden()
        {
            ToolBar.RejectHidden.Click();
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
        
        public virtual void QuickProcess()
        {
            ToolBar.QuickProcess.Click();
        }
        
        public virtual void CreateShipmentIssue()
        {
            ToolBar.CreateShipmentIssue.Click();
        }
        
        public virtual void CreateShipmentReceipt()
        {
            ToolBar.CreateShipmentReceipt.Click();
        }
        
        public virtual void OpenOrder()
        {
            ToolBar.OpenOrder.Click();
        }
        
        public virtual void ReopenOrder()
        {
            ToolBar.ReopenOrder.Click();
        }
        
        public virtual void CopyOrder()
        {
            ToolBar.CopyOrder.Click();
        }
        
        public virtual void EmailSalesOrder()
        {
            ToolBar.EmailSalesOrder.Click();
        }
        
        public virtual void ReleaseFromCreditHold()
        {
            ToolBar.ReleaseFromCreditHold.Click();
        }
        
        public virtual void PrepareInvoice()
        {
            ToolBar.PrepareInvoice.Click();
        }
        
        public virtual void PrepareInvoice(bool status, string message = null)
        {
            ToolBar.PrepareInvoice.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.PrepareInvoice.Click();
        }
        
        public virtual void CreatePurchaseOrder()
        {
            ToolBar.CreatePurchaseOrder.Click();
        }
        
        public virtual void CreateTransferOrder()
        {
            ToolBar.CreateTransferOrder.Click();
        }
        
        public virtual void CompleteOrder()
        {
            ToolBar.CompleteOrder.Click();
        }
        
        public virtual void CancelOrder()
        {
            ToolBar.CancelOrder.Click();
        }
        
        public virtual void PlaceOnBackOrder()
        {
            ToolBar.PlaceOnBackOrder.Click();
        }
        
        public virtual void PutOnHold()
        {
            ToolBar.PutOnHold.Click();
        }
        
        public virtual void ReleaseFromHold()
        {
            ToolBar.ReleaseFromHold.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void RecalculateDiscountsAction()
        {
            ToolBar.RecalculateDiscountsAction.Click();
        }
        
        public virtual void RecalcExternalTax()
        {
            ToolBar.RecalcExternalTax.Click();
        }
        
        public virtual void CreateAndAuthorizePayment()
        {
            ToolBar.CreateAndAuthorizePayment.Click();
        }
        
        public virtual void CreateAndCapturePayment()
        {
            ToolBar.CreateAndCapturePayment.Click();
        }
        
        public virtual void Approve()
        {
            ToolBar.Approve.Click();
        }
        
        public virtual void Reject()
        {
            ToolBar.Reject.Click();
        }
        
        public virtual void CreateShipment()
        {
            ToolBar.CreateShipment.Click();
        }
        
        public virtual void ApplyAssignmentRules()
        {
            ToolBar.ApplyAssignmentRules.Click();
        }
        
        public virtual void PostInvoiceToIN()
        {
            ToolBar.PostInvoiceToIN.Click();
        }
        
        public virtual void PostInvoiceToIN(bool status, string message = null)
        {
            ToolBar.PostInvoiceToIN.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.PostInvoiceToIN.Click();
        }
        
        public virtual void Inquiries()
        {
            ToolBar.Inquiries.Click();
        }
        
        public virtual void Reports()
        {
            ToolBar.Reports.Click();
        }
        
        public virtual void PrintSalesOrder()
        {
            ToolBar.PrintSalesOrder.Click();
        }
        
        public virtual void Notification()
        {
            ToolBar.Notification.Click();
        }
        
        public virtual void Notification(bool status, string message = null)
        {
            ToolBar.Notification.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Notification.Click();
        }
        
        public virtual void MatrixGridCellChanged()
        {
            ToolBar.MatrixGridCellChanged.Click();
        }
        
        public virtual void ManageCCPaymentMethodHF()
        {
            ToolBar.ManageCCPaymentMethodHF.Click();
        }
        
        public virtual void SoordershipmentDisplayshippingrefnoteidLink()
        {
            ToolBar.SoordershipmentDisplayshippingrefnoteidLink.Click();
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
			public ToolBarButton ShowWorkflow { get; }
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
			public ToolBarButton PasteFromQuickorderComputers { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Previous { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton InitializeState { get; }
			public ToolBarButton QuickProcessHidden { get; }
			public ToolBarButton CreateShipmentIssueHidden { get; }
			public ToolBarButton CreateShipmentReceiptHidden { get; }
			public ToolBarButton OpenOrderHidden { get; }
			public ToolBarButton ReopenOrderHidden { get; }
			public ToolBarButton CopyOrderHidden { get; }
			public ToolBarButton EmailSalesOrderHidden { get; }
			public ToolBarButton ReleaseFromCreditHoldHidden { get; }
			public ToolBarButton PrepareInvoiceHidden { get; }
			public ToolBarButton CreatePurchaseOrderHidden { get; }
			public ToolBarButton CreateTransferOrderHidden { get; }
			public ToolBarButton CompleteOrderHidden { get; }
			public ToolBarButton CancelOrderHidden { get; }
			public ToolBarButton PlaceOnBackOrderHidden { get; }
			public ToolBarButton PutOnHoldHidden { get; }
			public ToolBarButton ReleaseFromHoldHidden { get; }
			public ToolBarButton CreateAndAuthorizePaymentHidden { get; }
			public ToolBarButton CreateAndCapturePaymentHidden { get; }
			public ToolBarButton PrintSalesOrderHidden { get; }
			public ToolBarButton ApproveHidden { get; }
			public ToolBarButton RejectHidden { get; }
			public ToolBarButton ViewActivity { get; }
			public ToolBarButton OpenActivityOwner { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton QuickProcess { get; }
			public ToolBarButton CreateShipmentIssue { get; }
			public ToolBarButton CreateShipmentReceipt { get; }
			public ToolBarButton OpenOrder { get; }
			public ToolBarButton ReopenOrder { get; }
			public ToolBarButton CopyOrder { get; }
			public ToolBarButton EmailSalesOrder { get; }
			public ToolBarButton ReleaseFromCreditHold { get; }
			public ToolBarButton PrepareInvoice { get; }
			public ToolBarButton CreatePurchaseOrder { get; }
			public ToolBarButton CreateTransferOrder { get; }
			public ToolBarButton CompleteOrder { get; }
			public ToolBarButton CancelOrder { get; }
			public ToolBarButton PlaceOnBackOrder { get; }
			public ToolBarButton PutOnHold { get; }
			public ToolBarButton ReleaseFromHold { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton RecalculateDiscountsAction { get; }
			public ToolBarButton RecalcExternalTax { get; }
			public ToolBarButton CreateAndAuthorizePayment { get; }
			public ToolBarButton CreateAndCapturePayment { get; }
			public ToolBarButton Approve { get; }
			public ToolBarButton Reject { get; }
			public ToolBarButton CreateShipment { get; }
			public ToolBarButton ApplyAssignmentRules { get; }
			public ToolBarButton PostInvoiceToIN { get; }
			public ToolBarButton Inquiries { get; }
			public ToolBarButton Reports { get; }
			public ToolBarButton PrintSalesOrder { get; }
			public ToolBarButton Notification { get; }
			public ToolBarButton MatrixGridCellChanged { get; }
			public ToolBarButton ManageCCPaymentMethodHF { get; }
			public ToolBarButton SoordershipmentDisplayshippingrefnoteidLink { get; }
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
                ShowWorkflow = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ShowWorkflow\']", "Show state diagram", locator, Custom);
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
                PasteFromQuickorderComputers = new ToolBarButton("css=li[data-cmd=\'CopyPaste@#11\']", "Paste from [QuickOrder - Computers]", locator, Clipboard);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'First\']", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Previous\']", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Next\']", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Last\']", "Go to Last Record", locator, null);
                InitializeState = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'initializeState\']", "initializeState", locator, null);
                QuickProcessHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'QuickProcess\']", "Quick Process", locator, null);
                CreateShipmentIssueHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateShipmentIssue\']", "Create Shipment", locator, null);
                CreateShipmentReceiptHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateShipmentReceipt\']", "Create Receipt", locator, null);
                OpenOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'OpenOrder\']", "Open Order", locator, null);
                ReopenOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ReopenOrder\']", "Re-Open Order", locator, null);
                CopyOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CopyOrder\']", "Copy Order", locator, null);
                EmailSalesOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'EmailSalesOrder\']", "Email Sales Order/Quote", locator, null);
                ReleaseFromCreditHoldHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ReleaseFromCreditHold\']", "Release from Credit Hold", locator, null);
                PrepareInvoiceHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'PrepareInvoice\']", "Prepare Invoice", locator, null);
                PrepareInvoiceHidden.WaitAction = Wait.WaitForLongOperationToComplete;
                CreatePurchaseOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreatePurchaseOrder\']", "Create Purchase Order", locator, null);
                CreateTransferOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateTransferOrder\']", "Create Transfer Order", locator, null);
                CompleteOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CompleteOrder\']", "Complete Order", locator, null);
                CancelOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CancelOrder\']", "Cancel Order", locator, null);
                PlaceOnBackOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'PlaceOnBackOrder\']", "Place on Back Order", locator, null);
                PutOnHoldHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'PutOnHold\']", "Put on Hold", locator, null);
                ReleaseFromHoldHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ReleaseFromHold\']", "Release from Hold", locator, null);
                CreateAndAuthorizePaymentHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateAndAuthorizePayment\']", "Create and Authorize CC Payment", locator, null);
                CreateAndCapturePaymentHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateAndCapturePayment\']", "Create and Capture CC Payment", locator, null);
                PrintSalesOrderHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'PrintSalesOrder\']", "Print Sales Order/Quote", locator, null);
                ApproveHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Approve\']", "Approve", locator, null);
                RejectHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Reject\']", "Reject", locator, null);
                ViewActivity = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewActivity\']", "Details", locator, null);
                OpenActivityOwner = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'OpenActivityOwner\']", "OpenActivityOwner", locator, null);
                ViewAllActivities = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewAllActivities\']", "View Activities", locator, null);
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                QuickProcess = new ToolBarButton("css=li[data-cmd=\'Action@QuickProcess\']", "Quick Process", locator, Actions);
                CreateShipmentIssue = new ToolBarButton("css=li[data-cmd=\'Action@CreateShipmentIssue\']", "Create Shipment", locator, Actions);
                CreateShipmentReceipt = new ToolBarButton("css=li[data-cmd=\'Action@CreateShipmentReceipt\']", "Create Receipt", locator, Actions);
                OpenOrder = new ToolBarButton("css=li[data-cmd=\'Action@OpenOrder\']", "Open Order", locator, Actions);
                ReopenOrder = new ToolBarButton("css=li[data-cmd=\'Action@ReopenOrder\']", "Re-Open Order", locator, Actions);
                CopyOrder = new ToolBarButton("css=li[data-cmd=\'Action@CopyOrder\']", "Copy Order", locator, Actions);
                EmailSalesOrder = new ToolBarButton("css=li[data-cmd=\'Action@EmailSalesOrder\']", "Email Sales Order/Quote", locator, Actions);
                ReleaseFromCreditHold = new ToolBarButton("css=li[data-cmd=\'Action@ReleaseFromCreditHold\']", "Release from Credit Hold", locator, Actions);
                PrepareInvoice = new ToolBarButton("css=li[data-cmd=\'Action@PrepareInvoice\']", "Prepare Invoice", locator, Actions);
                PrepareInvoice.WaitAction = Wait.WaitForLongOperationToComplete;
                CreatePurchaseOrder = new ToolBarButton("css=li[data-cmd=\'Action@CreatePurchaseOrder\']", "Create Purchase Order", locator, Actions);
                CreateTransferOrder = new ToolBarButton("css=li[data-cmd=\'Action@CreateTransferOrder\']", "Create Transfer Order", locator, Actions);
                CompleteOrder = new ToolBarButton("css=li[data-cmd=\'Action@CompleteOrder\']", "Complete Order", locator, Actions);
                CancelOrder = new ToolBarButton("css=li[data-cmd=\'Action@CancelOrder\']", "Cancel Order", locator, Actions);
                PlaceOnBackOrder = new ToolBarButton("css=li[data-cmd=\'Action@PlaceOnBackOrder\']", "Place on Back Order", locator, Actions);
                PutOnHold = new ToolBarButton("css=li[data-cmd=\'Action@PutOnHold\']", "Put on Hold", locator, Actions);
                ReleaseFromHold = new ToolBarButton("css=li[data-cmd=\'Action@ReleaseFromHold\']", "Release from Hold", locator, Actions);
                ValidateAddresses = new ToolBarButton("css=li[data-cmd=\'Action@ValidateAddresses\']", "Validate Addresses", locator, Actions);
                RecalculateDiscountsAction = new ToolBarButton("css=li[data-cmd=\'Action@RecalculateDiscountsAction\']", "Recalculate Prices", locator, Actions);
                RecalcExternalTax = new ToolBarButton("css=li[data-cmd=\'Action@RecalcExternalTax\']", "Recalculate External Tax", locator, Actions);
                CreateAndAuthorizePayment = new ToolBarButton("css=li[data-cmd=\'Action@CreateAndAuthorizePayment\']", "Create and Authorize CC Payment", locator, Actions);
                CreateAndCapturePayment = new ToolBarButton("css=li[data-cmd=\'Action@CreateAndCapturePayment\']", "Create and Capture CC Payment", locator, Actions);
                Approve = new ToolBarButton("css=li[data-cmd=\'Action@Approve\']", "Approve", locator, Actions);
                Reject = new ToolBarButton("css=li[data-cmd=\'Action@Reject\']", "Reject", locator, Actions);
                CreateShipment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateShipment\']", "Create Shipment", locator, null);
                ApplyAssignmentRules = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ApplyAssignmentRules\']", "Apply Assignment Rules", locator, null);
                PostInvoiceToIN = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'PostInvoiceToIN\']", "Post Invoice to IN", locator, null);
                PostInvoiceToIN.WaitAction = Wait.WaitForLongOperationToComplete;
                Inquiries = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Inquiries\") > div[data-type=\'button\']", "Inquiries", locator, null);
                Reports = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                PrintSalesOrder = new ToolBarButton("css=li[data-cmd=\'Report@PrintSalesOrder\']", "Print Sales Order/Quote", locator, Reports);
                Notification = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Notification\']", "Notifications", locator, null);
                Notification.WaitAction = Wait.WaitForLongOperationToComplete;
                MatrixGridCellChanged = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'matrixGridCellChanged\']", "matrixGridCellChanged", locator, null);
                ManageCCPaymentMethodHF = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ManageCCPaymentMethodHF\']", "Edit", locator, null);
                SoordershipmentDisplayshippingrefnoteidLink = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'SOOrderShipment~DisplayShippingRefNoteID" +
                        "~Link\']", "SOOrderShipment\r\nDisplayShippingRefNoteID\r\nLink", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_document_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit UsrCustom_Field { get; }
			public Label UsrCustom_FieldLabel { get; }
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public CheckBox DontApprove { get; }
			public Label DontApproveLabel { get; }
			public CheckBox Approved { get; }
			public Label ApprovedLabel { get; }
			public DateSelector OrderDate { get; }
			public Label OrderDateLabel { get; }
			public DateSelector RequestDate { get; }
			public Label RequestDateLabel { get; }
			public PXTextEdit CustomerOrderNbr { get; }
			public Label CustomerOrderNbrLabel { get; }
			public PXTextEdit CustomerRefNbr { get; }
			public Label CustomerRefNbrLabel { get; }
			public Selector CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public Selector CustomerLocationID { get; }
			public Label CustomerLocationIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public Selector DestinationSiteID { get; }
			public Label DestinationSiteIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public PXTextEdit OrderDesc { get; }
			public Label OrderDescLabel { get; }
			public PXNumberEdit OrderQty { get; }
			public Label OrderQtyLabel { get; }
			public PXNumberEdit CuryDiscTot { get; }
			public Label CuryDiscTotLabel { get; }
			public PXNumberEdit CuryVatExemptTotal { get; }
			public Label CuryVatExemptTotalLabel { get; }
			public PXNumberEdit CuryVatTaxableTotal { get; }
			public Label CuryVatTaxableTotalLabel { get; }
			public PXNumberEdit CuryTaxTotal { get; }
			public Label CuryTaxTotalLabel { get; }
			public PXNumberEdit CuryOrderTotal { get; }
			public Label CuryOrderTotalLabel { get; }
			public PXNumberEdit CuryControlTotal { get; }
			public Label CuryControlTotalLabel { get; }
			public CheckBox IsRUTROTDeductible { get; }
			public Label IsRUTROTDeductibleLabel { get; }
			public CheckBox IsFSIntegrated { get; }
			public Label IsFSIntegratedLabel { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
            
            public c_document_form(string locator, string name) : 
                    base(locator, name)
            {
                UsrCustom_Field = new PXTextEdit("ctl00_phF_form_t0_CstPXTextEdit1", "Custom_Field", locator, null);
                UsrCustom_FieldLabel = new Label(UsrCustom_Field);
                UsrCustom_Field.DataField = "UsrCustom_Field";
                OrderType = new Selector("ctl00_phF_form_t0_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phF_form_t0_edOrderNbr", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("N", "Open");
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("P", "Pending Approval");
                Status.Items.Add("V", "Rejected");
                Status.Items.Add("A", "Awaiting Payment");
                Status.Items.Add("R", "Credit Hold");
                Status.Items.Add("C", "Completed");
                Status.Items.Add("L", "Canceled");
                Status.Items.Add("B", "Back Order");
                Status.Items.Add("S", "Shipping");
                Status.Items.Add("I", "Invoiced");
                DontApprove = new CheckBox("ctl00_phF_form_t0_chkDontApprove", "Don\'t Approve", locator, null);
                DontApproveLabel = new Label(DontApprove);
                DontApprove.DataField = "DontApprove";
                Approved = new CheckBox("ctl00_phF_form_t0_chkApproved", "Approved", locator, null);
                ApprovedLabel = new Label(Approved);
                Approved.DataField = "Approved";
                OrderDate = new DateSelector("ctl00_phF_form_t0_edOrderDate", "Date", locator, null);
                OrderDateLabel = new Label(OrderDate);
                OrderDate.DataField = "OrderDate";
                RequestDate = new DateSelector("ctl00_phF_form_t0_edRequestDate", "Requested On", locator, null);
                RequestDateLabel = new Label(RequestDate);
                RequestDate.DataField = "RequestDate";
                CustomerOrderNbr = new PXTextEdit("ctl00_phF_form_t0_edCustomerOrderNbr", "Customer Order Nbr.", locator, null);
                CustomerOrderNbrLabel = new Label(CustomerOrderNbr);
                CustomerOrderNbr.DataField = "CustomerOrderNbr";
                CustomerRefNbr = new PXTextEdit("ctl00_phF_form_t0_edCustomerRefNbr", "External Reference", locator, null);
                CustomerRefNbrLabel = new Label(CustomerRefNbr);
                CustomerRefNbr.DataField = "CustomerRefNbr";
                CustomerID = new Selector("ctl00_phF_form_t0_edCustomerID", "Customer", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                CustomerLocationID = new Selector("ctl00_phF_form_t0_edCustomerLocationID", "Location", locator, null);
                CustomerLocationIDLabel = new Label(CustomerLocationID);
                CustomerLocationID.DataField = "CustomerLocationID";
                CuryID = new Selector("ctl00_phF_form_t0_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_t0_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                DestinationSiteID = new Selector("ctl00_phF_form_t0_edDestinationSiteID", "Destination Warehouse", locator, null);
                DestinationSiteIDLabel = new Label(DestinationSiteID);
                DestinationSiteID.DataField = "DestinationSiteID";
                ProjectID = new Selector("ctl00_phF_form_t0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                OrderDesc = new PXTextEdit("ctl00_phF_form_t0_edOrderDesc", "Description", locator, null);
                OrderDescLabel = new Label(OrderDesc);
                OrderDesc.DataField = "OrderDesc";
                OrderQty = new PXNumberEdit("ctl00_phF_form_t0_edOrderQty", "Ordered Qty.", locator, null);
                OrderQtyLabel = new Label(OrderQty);
                OrderQty.DataField = "OrderQty";
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
                CuryOrderTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrderTotal", "Order Total", locator, null);
                CuryOrderTotalLabel = new Label(CuryOrderTotal);
                CuryOrderTotal.DataField = "CuryOrderTotal";
                CuryControlTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryControlTotal", "Control Total", locator, null);
                CuryControlTotalLabel = new Label(CuryControlTotal);
                CuryControlTotal.DataField = "CuryControlTotal";
                IsRUTROTDeductible = new CheckBox("ctl00_phF_form_t0_chkRUTROT", "ROT and RUT deductible document", locator, null);
                IsRUTROTDeductibleLabel = new Label(IsRUTROTDeductible);
                IsRUTROTDeductible.DataField = "IsRUTROTDeductible";
                IsFSIntegrated = new CheckBox("ctl00_phF_form_t0_chkIsFSIntegrated", "IsFSIntegrated", locator, null);
                IsFSIntegratedLabel = new Label(IsFSIntegrated);
                IsFSIntegrated.DataField = "IsFSIntegrated";
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
            
            public virtual void CustomerIDEdit()
            {
                Buttons.CustomerIDEdit.Click();
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
			public Button CustomerIDEdit { get; }
			public Button ProjectIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phF_form_t0_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_t0_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                    CustomerIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edCustomerID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "CustomerIDEdit", "ctl00_phF_form");
                    CustomerIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c__soorder_currencyinfo__rf : Container
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
            
            public c__soorder_currencyinfo__rf(string locator, string name) : 
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
                DataMemberName = "_SOOrder_CurrencyInfo_";
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
        
        public class c_currentdocument_commission : Container
        {
            
			public Selector SalesPersonID { get; }
			public Label SalesPersonIDLabel { get; }
            
            public c_currentdocument_commission(string locator, string name) : 
                    base(locator, name)
            {
                SalesPersonID = new Selector("ctl00_phG_tab_t3_Commission_edSalesPersonID", "Default Salesperson", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_currentdocument_formp : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverridePrepayment { get; }
			public Label OverridePrepaymentLabel { get; }
			public PXNumberEdit PrepaymentReqPct { get; }
			public Label PrepaymentReqPctLabel { get; }
			public PXNumberEdit CuryPrepaymentReqAmt { get; }
			public Label CuryPrepaymentReqAmtLabel { get; }
			public CheckBox PrepaymentReqSatisfied { get; }
			public Label PrepaymentReqSatisfiedLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public Selector PMInstanceID { get; }
			public Label PMInstanceIDLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Label ExtRefNbrLabel { get; }
            
            public c_currentdocument_formp(string locator, string name) : 
                    base(locator, name)
            {
                OverridePrepayment = new CheckBox("ctl00_phG_tab_t4_formP_chkOverridePrepayment", "Override Prepayment", locator, null);
                OverridePrepaymentLabel = new Label(OverridePrepayment);
                OverridePrepayment.DataField = "OverridePrepayment";
                PrepaymentReqPct = new PXNumberEdit("ctl00_phG_tab_t4_formP_edPrepaymentReqPct", "Prepayment Percent", locator, null);
                PrepaymentReqPctLabel = new Label(PrepaymentReqPct);
                PrepaymentReqPct.DataField = "PrepaymentReqPct";
                CuryPrepaymentReqAmt = new PXNumberEdit("ctl00_phG_tab_t4_formP_edCuryPrepaymentReqAmt", "Prepayment Amount", locator, null);
                CuryPrepaymentReqAmtLabel = new Label(CuryPrepaymentReqAmt);
                CuryPrepaymentReqAmt.DataField = "CuryPrepaymentReqAmt";
                PrepaymentReqSatisfied = new CheckBox("ctl00_phG_tab_t4_formP_chkPrepaymentReqSatisfied", "Prepayment Requirements Satisfied", locator, null);
                PrepaymentReqSatisfiedLabel = new Label(PrepaymentReqSatisfied);
                PrepaymentReqSatisfied.DataField = "PrepaymentReqSatisfied";
                PaymentMethodID = new Selector("ctl00_phG_tab_t4_formP_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                PMInstanceID = new Selector("ctl00_phG_tab_t4_formP_edPMInstanceID", "Card/Account No", locator, null);
                PMInstanceIDLabel = new Label(PMInstanceID);
                PMInstanceID.DataField = "PMInstanceID";
                CashAccountID = new Selector("ctl00_phG_tab_t4_formP_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                ExtRefNbr = new PXTextEdit("ctl00_phG_tab_t4_formP_edExtRefNbr", "Payment Ref.", locator, null);
                ExtRefNbrLabel = new Label(ExtRefNbr);
                ExtRefNbr.DataField = "ExtRefNbr";
                DataMemberName = "CurrentDocument";
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
                    AddressLookup = new Button("ctl00_phG_tab_t4_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t4_formP");
                }
            }
        }
        
        public class c_currentdocument_forme : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public CheckBox OverrideTaxZone { get; }
			public Label OverrideTaxZoneLabel { get; }
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public Label AvalaraCustomerUsageTypeLabel { get; }
			public CheckBox BillSeparately { get; }
			public Label BillSeparatelyLabel { get; }
			public PXTextEdit InvoiceNbr { get; }
			public Label InvoiceNbrLabel { get; }
			public DateSelector InvoiceDate { get; }
			public Label InvoiceDateLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public DateSelector DueDate { get; }
			public Label DueDateLabel { get; }
			public DateSelector DiscDate { get; }
			public Label DiscDateLabel { get; }
			public Selector FinPeriodID { get; }
			public Label FinPeriodIDLabel { get; }
			public PXTextEdit OrigOrderType { get; }
			public Label OrigOrderTypeLabel { get; }
			public Selector OrigOrderNbr { get; }
			public Label OrigOrderNbrLabel { get; }
			public CheckBox Emailed { get; }
			public Label EmailedLabel { get; }
			public Selector WorkgroupID { get; }
			public Label WorkgroupIDLabel { get; }
			public Selector OwnerID { get; }
			public Label OwnerIDLabel { get; }
            
            public c_currentdocument_forme(string locator, string name) : 
                    base(locator, name)
            {
                BranchID = new Selector("ctl00_phG_tab_t4_formE_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                OverrideTaxZone = new CheckBox("ctl00_phG_tab_t4_formE_chkOverrideTaxZone", "Override Tax Zone", locator, null);
                OverrideTaxZoneLabel = new Label(OverrideTaxZone);
                OverrideTaxZone.DataField = "OverrideTaxZone";
                TaxZoneID = new Selector("ctl00_phG_tab_t4_formE_edTaxZoneID", "Customer Tax Zone", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                TaxCalcMode = new DropDown("ctl00_phG_tab_t4_formE_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                AvalaraCustomerUsageType = new DropDown("ctl00_phG_tab_t4_formE_edAvalaraCustomerUsageTypeID", "Entity Usage Type", locator, null);
                AvalaraCustomerUsageTypeLabel = new Label(AvalaraCustomerUsageType);
                AvalaraCustomerUsageType.DataField = "AvalaraCustomerUsageType";
                AvalaraCustomerUsageType.Items.Add("A", "Federal Government");
                AvalaraCustomerUsageType.Items.Add("B", "State/Local Govt.");
                AvalaraCustomerUsageType.Items.Add("C", "Tribal Government");
                AvalaraCustomerUsageType.Items.Add("D", "Foreign Diplomat");
                AvalaraCustomerUsageType.Items.Add("E", "Charitable Organization");
                AvalaraCustomerUsageType.Items.Add("F", "Religious");
                AvalaraCustomerUsageType.Items.Add("G", "Resale");
                AvalaraCustomerUsageType.Items.Add("H", "Agricultural Production");
                AvalaraCustomerUsageType.Items.Add("I", "Industrial Prod/Mfg.");
                AvalaraCustomerUsageType.Items.Add("J", "Direct Pay Permit");
                AvalaraCustomerUsageType.Items.Add("K", "Direct Mail");
                AvalaraCustomerUsageType.Items.Add("L", "Other");
                AvalaraCustomerUsageType.Items.Add("M", "Education");
                AvalaraCustomerUsageType.Items.Add("N", "Local Government");
                AvalaraCustomerUsageType.Items.Add("P", "Commercial Aquaculture");
                AvalaraCustomerUsageType.Items.Add("Q", "Commercial Fishery");
                AvalaraCustomerUsageType.Items.Add("R", "Non-resident");
                AvalaraCustomerUsageType.Items.Add("0", "Default");
                BillSeparately = new CheckBox("ctl00_phG_tab_t4_formE_chkBillSeparately", "Bill Separately", locator, null);
                BillSeparatelyLabel = new Label(BillSeparately);
                BillSeparately.DataField = "BillSeparately";
                InvoiceNbr = new PXTextEdit("ctl00_phG_tab_t4_formE_edInvoiceNbr", "Invoice Nbr.", locator, null);
                InvoiceNbrLabel = new Label(InvoiceNbr);
                InvoiceNbr.DataField = "InvoiceNbr";
                InvoiceDate = new DateSelector("ctl00_phG_tab_t4_formE_edInvoiceDate", "Invoice Date", locator, null);
                InvoiceDateLabel = new Label(InvoiceDate);
                InvoiceDate.DataField = "InvoiceDate";
                TermsID = new Selector("ctl00_phG_tab_t4_formE_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                DueDate = new DateSelector("ctl00_phG_tab_t4_formE_edDueDate", "Due Date", locator, null);
                DueDateLabel = new Label(DueDate);
                DueDate.DataField = "DueDate";
                DiscDate = new DateSelector("ctl00_phG_tab_t4_formE_edDiscDate", "Cash Discount Date", locator, null);
                DiscDateLabel = new Label(DiscDate);
                DiscDate.DataField = "DiscDate";
                FinPeriodID = new Selector("ctl00_phG_tab_t4_formE_edFinPeriodID", "Post Period", locator, null);
                FinPeriodIDLabel = new Label(FinPeriodID);
                FinPeriodID.DataField = "FinPeriodID";
                OrigOrderType = new PXTextEdit("ctl00_phG_tab_t4_formE_edOrigOrderType", "Orig. Order Type", locator, null);
                OrigOrderTypeLabel = new Label(OrigOrderType);
                OrigOrderType.DataField = "OrigOrderType";
                OrigOrderNbr = new Selector("ctl00_phG_tab_t4_formE_edOrigOrderNbr", "Orig. Order Nbr.", locator, null);
                OrigOrderNbrLabel = new Label(OrigOrderNbr);
                OrigOrderNbr.DataField = "OrigOrderNbr";
                Emailed = new CheckBox("ctl00_phG_tab_t4_formE_chkEmailed", "Emailed", locator, null);
                EmailedLabel = new Label(Emailed);
                Emailed.DataField = "Emailed";
                WorkgroupID = new Selector("ctl00_phG_tab_t4_formE_edWorkgroupID", "Workgroup", locator, null);
                WorkgroupIDLabel = new Label(WorkgroupID);
                WorkgroupID.DataField = "WorkgroupID";
                OwnerID = new Selector("ctl00_phG_tab_t4_formE_edOwnerID", "Owner", locator, null);
                OwnerIDLabel = new Label(OwnerID);
                OwnerID.DataField = "OwnerID";
                DataMemberName = "CurrentDocument";
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
                    AddressLookup = new Button("ctl00_phG_tab_t4_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t4_formE");
                }
            }
        }
        
        public class c_currentdocument_formf : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector ShipDate { get; }
			public Label ShipDateLabel { get; }
			public CheckBox ShipSeparately { get; }
			public Label ShipSeparatelyLabel { get; }
			public DropDown ShipComplete { get; }
			public Label ShipCompleteLabel { get; }
			public DateSelector CancelDate { get; }
			public Label CancelDateLabel { get; }
			public CheckBox Cancelled { get; }
			public Label CancelledLabel { get; }
			public Selector DefaultSiteID { get; }
			public Label DefaultSiteIDLabel { get; }
			public Selector ShipVia { get; }
			public Label ShipViaLabel { get; }
			public CheckBox WillCall { get; }
			public Label WillCallLabel { get; }
			public DropDown FreightClass { get; }
			public Label FreightClassLabel { get; }
			public Selector FOBPoint { get; }
			public Label FOBPointLabel { get; }
			public PXNumberEdit Priority { get; }
			public Label PriorityLabel { get; }
			public Selector ShipTermsID { get; }
			public Label ShipTermsIDLabel { get; }
			public Selector ShipZoneID { get; }
			public Label ShipZoneIDLabel { get; }
			public CheckBox Resedential { get; }
			public Label ResedentialLabel { get; }
			public CheckBox SaturdayDelivery { get; }
			public Label SaturdayDeliveryLabel { get; }
			public CheckBox Insurance { get; }
			public Label InsuranceLabel { get; }
			public CheckBox UseCustomerAccount { get; }
			public Label UseCustomerAccountLabel { get; }
			public CheckBox GroundCollect { get; }
			public Label GroundCollectLabel { get; }
            
            public c_currentdocument_formf(string locator, string name) : 
                    base(locator, name)
            {
                ShipDate = new DateSelector("ctl00_phG_tab_t5_formF_edShipDate", "Sched. Shipment", locator, null);
                ShipDateLabel = new Label(ShipDate);
                ShipDate.DataField = "ShipDate";
                ShipSeparately = new CheckBox("ctl00_phG_tab_t5_formF_chkShipSeparately", "Ship Separately", locator, null);
                ShipSeparatelyLabel = new Label(ShipSeparately);
                ShipSeparately.DataField = "ShipSeparately";
                ShipComplete = new DropDown("ctl00_phG_tab_t5_formF_edShipComplete", "Shipping Rule", locator, null);
                ShipCompleteLabel = new Label(ShipComplete);
                ShipComplete.DataField = "ShipComplete";
                ShipComplete.Items.Add("C", "Ship Complete");
                ShipComplete.Items.Add("B", "Back Order Allowed");
                ShipComplete.Items.Add("L", "Cancel Remainder");
                CancelDate = new DateSelector("ctl00_phG_tab_t5_formF_edCancelDate", "Cancel By", locator, null);
                CancelDateLabel = new Label(CancelDate);
                CancelDate.DataField = "CancelDate";
                Cancelled = new CheckBox("ctl00_phG_tab_t5_formF_chkCancelled", "Canceled", locator, null);
                CancelledLabel = new Label(Cancelled);
                Cancelled.DataField = "Cancelled";
                DefaultSiteID = new Selector("ctl00_phG_tab_t5_formF_edDefaultSiteID", "Preferred Warehouse ID", locator, null);
                DefaultSiteIDLabel = new Label(DefaultSiteID);
                DefaultSiteID.DataField = "DefaultSiteID";
                ShipVia = new Selector("ctl00_phG_tab_t5_formF_edShipVia", "Ship Via", locator, null);
                ShipViaLabel = new Label(ShipVia);
                ShipVia.DataField = "ShipVia";
                WillCall = new CheckBox("ctl00_phG_tab_t5_formF_edWillCall", "Will Call", locator, null);
                WillCallLabel = new Label(WillCall);
                WillCall.DataField = "WillCall";
                FreightClass = new DropDown("ctl00_phG_tab_t5_formF_edFreightClass", "Freight Class", locator, null);
                FreightClassLabel = new Label(FreightClass);
                FreightClass.DataField = "FreightClass";
                FreightClass.Items.Add("50", "50");
                FreightClass.Items.Add("55", "55");
                FreightClass.Items.Add("60", "60");
                FreightClass.Items.Add("65", "65");
                FreightClass.Items.Add("70", "70");
                FreightClass.Items.Add("77.5", "77.5");
                FreightClass.Items.Add("85", "85");
                FreightClass.Items.Add("92.5", "92.5");
                FreightClass.Items.Add("100", "100");
                FreightClass.Items.Add("110", "110");
                FreightClass.Items.Add("125", "125");
                FreightClass.Items.Add("150", "150");
                FreightClass.Items.Add("175", "175");
                FreightClass.Items.Add("200", "200");
                FreightClass.Items.Add("250", "250");
                FreightClass.Items.Add("300", "300");
                FreightClass.Items.Add("400", "400");
                FreightClass.Items.Add("500", "500");
                FOBPoint = new Selector("ctl00_phG_tab_t5_formF_edFOBPoint", "FOB Point", locator, null);
                FOBPointLabel = new Label(FOBPoint);
                FOBPoint.DataField = "FOBPoint";
                Priority = new PXNumberEdit("ctl00_phG_tab_t5_formF_edPriority", "Priority", locator, null);
                PriorityLabel = new Label(Priority);
                Priority.DataField = "Priority";
                ShipTermsID = new Selector("ctl00_phG_tab_t5_formF_edShipTermsID", "Shipping Terms", locator, null);
                ShipTermsIDLabel = new Label(ShipTermsID);
                ShipTermsID.DataField = "ShipTermsID";
                ShipZoneID = new Selector("ctl00_phG_tab_t5_formF_edShipZoneID", "Shipping Zone", locator, null);
                ShipZoneIDLabel = new Label(ShipZoneID);
                ShipZoneID.DataField = "ShipZoneID";
                Resedential = new CheckBox("ctl00_phG_tab_t5_formF_chkResedential", "Residential Delivery", locator, null);
                ResedentialLabel = new Label(Resedential);
                Resedential.DataField = "Resedential";
                SaturdayDelivery = new CheckBox("ctl00_phG_tab_t5_formF_chkSaturdayDelivery", "Saturday Delivery", locator, null);
                SaturdayDeliveryLabel = new Label(SaturdayDelivery);
                SaturdayDelivery.DataField = "SaturdayDelivery";
                Insurance = new CheckBox("ctl00_phG_tab_t5_formF_chkInsurance", "Insurance", locator, null);
                InsuranceLabel = new Label(Insurance);
                Insurance.DataField = "Insurance";
                UseCustomerAccount = new CheckBox("ctl00_phG_tab_t5_formF_chkUseCustomerAccount", "Use Customer\'s Account", locator, null);
                UseCustomerAccountLabel = new Label(UseCustomerAccount);
                UseCustomerAccount.DataField = "UseCustomerAccount";
                GroundCollect = new CheckBox("ctl00_phG_tab_t5_formF_chkGroundCollect", "Ground Collect", locator, null);
                GroundCollectLabel = new Label(GroundCollect);
                GroundCollect.DataField = "GroundCollect";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ShopforRates { get; }
			public Button AddressLookup { get; }
                
                public PxButtonCollection()
                {
                    ShopforRates = new Button("ctl00_phG_tab_t5_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t5_formF");
                    AddressLookup = new Button("ctl00_phG_tab_t5_formB_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_formF");
                }
            }
        }
        
        public class c_currentdocument_discountparameters : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox DisableAutomaticDiscountCalculation { get; }
			public Label DisableAutomaticDiscountCalculationLabel { get; }
            
            public c_currentdocument_discountparameters(string locator, string name) : 
                    base(locator, name)
            {
                DisableAutomaticDiscountCalculation = new CheckBox("ctl00_phG_tab_t6_DiscountParameters_chkDisableAutomaticDiscountCalculation", "Disable Automatic Discount Update", locator, null);
                DisableAutomaticDiscountCalculationLabel = new Label(DisableAutomaticDiscountCalculation);
                DisableAutomaticDiscountCalculation.DataField = "DisableAutomaticDiscountCalculation";
                DataMemberName = "CurrentDocument";
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
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t6_DiscountParameters");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t6_DiscountParameters");
                    DiscountSequenceIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_currentdocument_formpt : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit CuryUnbilledOrderTotal { get; }
			public Label CuryUnbilledOrderTotalLabel { get; }
			public PXNumberEdit CuryCCAuthorizedAmt { get; }
			public Label CuryCCAuthorizedAmtLabel { get; }
			public PXNumberEdit CuryPaidAmt { get; }
			public Label CuryPaidAmtLabel { get; }
			public PXNumberEdit CuryUnpaidBalance { get; }
			public Label CuryUnpaidBalanceLabel { get; }
            
            public c_currentdocument_formpt(string locator, string name) : 
                    base(locator, name)
            {
                CuryUnbilledOrderTotal = new PXNumberEdit("ctl00_phG_tab_t8_formPT_edCuryUnbilledOrderTotal1", "Unbilled Amount", locator, null);
                CuryUnbilledOrderTotalLabel = new Label(CuryUnbilledOrderTotal);
                CuryUnbilledOrderTotal.DataField = "CuryUnbilledOrderTotal";
                CuryCCAuthorizedAmt = new PXNumberEdit("ctl00_phG_tab_t8_formPT_edCuryCCAuthorizedAmt", "Authorized", locator, null);
                CuryCCAuthorizedAmtLabel = new Label(CuryCCAuthorizedAmt);
                CuryCCAuthorizedAmt.DataField = "CuryCCAuthorizedAmt";
                CuryPaidAmt = new PXNumberEdit("ctl00_phG_tab_t8_formPT_edCuryPaidAmt", "Paid", locator, null);
                CuryPaidAmtLabel = new Label(CuryPaidAmt);
                CuryPaidAmt.DataField = "CuryPaidAmt";
                CuryUnpaidBalance = new PXNumberEdit("ctl00_phG_tab_t8_formPT_edCuryUnpaidBalance", "Unpaid Balance", locator, null);
                CuryUnpaidBalanceLabel = new Label(CuryUnpaidBalance);
                CuryUnpaidBalance.DataField = "CuryUnpaidBalance";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ARPayment__RefNbrEdit()
            {
                Buttons.ARPayment__RefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ARPayment__RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ARPayment__RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_detgrid_lv0_edARPayment__RefNbr\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "ARPayment__RefNbrEdit", "ctl00_phG_tab_t8_formPT");
                    ARPayment__RefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_currentdocument_formg : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit AMCuryEstimateTotal { get; }
			public Label AMCuryEstimateTotalLabel { get; }
			public PXNumberEdit CuryLineTotal { get; }
			public Label CuryLineTotalLabel { get; }
			public PXNumberEdit CuryMiscTot { get; }
			public Label CuryMiscTotLabel { get; }
			public PXNumberEdit CuryTaxTotal { get; }
			public Label CuryTaxTotalLabel { get; }
			public PXNumberEdit OrderWeight { get; }
			public Label OrderWeightLabel { get; }
			public PXNumberEdit OrderVolume { get; }
			public Label OrderVolumeLabel { get; }
			public PXNumberEdit PackageWeight { get; }
			public Label PackageWeightLabel { get; }
			public PXNumberEdit CuryFreightCost { get; }
			public Label CuryFreightCostLabel { get; }
			public CheckBox FreightCostIsValid { get; }
			public Label FreightCostIsValidLabel { get; }
			public CheckBox OverrideFreightAmount { get; }
			public Label OverrideFreightAmountLabel { get; }
			public DropDown FreightAmountSource { get; }
			public Label FreightAmountSourceLabel { get; }
			public PXNumberEdit CuryFreightAmt { get; }
			public Label CuryFreightAmtLabel { get; }
			public PXNumberEdit CuryPremiumFreightAmt { get; }
			public Label CuryPremiumFreightAmtLabel { get; }
			public Selector FreightTaxCategoryID { get; }
			public Label FreightTaxCategoryIDLabel { get; }
			public PXNumberEdit AMEstimateQty { get; }
			public Label AMEstimateQtyLabel { get; }
			public PXNumberEdit OpenOrderQty { get; }
			public Label OpenOrderQtyLabel { get; }
			public PXNumberEdit CuryOpenOrderTotal { get; }
			public Label CuryOpenOrderTotalLabel { get; }
			public PXNumberEdit UnbilledOrderQty { get; }
			public Label UnbilledOrderQtyLabel { get; }
			public PXNumberEdit CuryUnbilledOrderTotal { get; }
			public Label CuryUnbilledOrderTotalLabel { get; }
			public PXNumberEdit CuryPaymentTotal { get; }
			public Label CuryPaymentTotalLabel { get; }
			public PXNumberEdit CuryUnpaidBalance { get; }
			public Label CuryUnpaidBalanceLabel { get; }
            
            public c_currentdocument_formg(string locator, string name) : 
                    base(locator, name)
            {
                AMCuryEstimateTotal = new PXNumberEdit("ctl00_phG_tab_t9_formG_edAMCuryEstimateTotal", "Estimate Total", locator, null);
                AMCuryEstimateTotalLabel = new Label(AMCuryEstimateTotal);
                AMCuryEstimateTotal.DataField = "AMCuryEstimateTotal";
                CuryLineTotal = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryLineTotal", "Line Total", locator, null);
                CuryLineTotalLabel = new Label(CuryLineTotal);
                CuryLineTotal.DataField = "CuryLineTotal";
                CuryMiscTot = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryMiscTot", "Misc. Total", locator, null);
                CuryMiscTotLabel = new Label(CuryMiscTot);
                CuryMiscTot.DataField = "CuryMiscTot";
                CuryTaxTotal = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryTaxTotal", "Tax Total", locator, null);
                CuryTaxTotalLabel = new Label(CuryTaxTotal);
                CuryTaxTotal.DataField = "CuryTaxTotal";
                OrderWeight = new PXNumberEdit("ctl00_phG_tab_t9_formG_edOrderWeight", "Order Weight", locator, null);
                OrderWeightLabel = new Label(OrderWeight);
                OrderWeight.DataField = "OrderWeight";
                OrderVolume = new PXNumberEdit("ctl00_phG_tab_t9_formG_edOrderVolume", "Order Volume", locator, null);
                OrderVolumeLabel = new Label(OrderVolume);
                OrderVolume.DataField = "OrderVolume";
                PackageWeight = new PXNumberEdit("ctl00_phG_tab_t9_formG_edPackageWeight", "Package Weight", locator, null);
                PackageWeightLabel = new Label(PackageWeight);
                PackageWeight.DataField = "PackageWeight";
                CuryFreightCost = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryFreightCost", "Freight Cost", locator, null);
                CuryFreightCostLabel = new Label(CuryFreightCost);
                CuryFreightCost.DataField = "CuryFreightCost";
                FreightCostIsValid = new CheckBox("ctl00_phG_tab_t9_formG_chkFreightCostIsValid", "Freight Cost Is up-to-date", locator, null);
                FreightCostIsValidLabel = new Label(FreightCostIsValid);
                FreightCostIsValid.DataField = "FreightCostIsValid";
                OverrideFreightAmount = new CheckBox("ctl00_phG_tab_t9_formG_chkOverrideFreightAmount", "Override Freight Price", locator, null);
                OverrideFreightAmountLabel = new Label(OverrideFreightAmount);
                OverrideFreightAmount.DataField = "OverrideFreightAmount";
                FreightAmountSource = new DropDown("ctl00_phG_tab_t9_formG_edFreightAmountSource", "Invoice Freight Price Based On", locator, null);
                FreightAmountSourceLabel = new Label(FreightAmountSource);
                FreightAmountSource.DataField = "FreightAmountSource";
                FreightAmountSource.Items.Add("S", "Shipment");
                FreightAmountSource.Items.Add("O", "Sales Order");
                CuryFreightAmt = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryFreightAmt", "Freight Price", locator, null);
                CuryFreightAmtLabel = new Label(CuryFreightAmt);
                CuryFreightAmt.DataField = "CuryFreightAmt";
                CuryPremiumFreightAmt = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryPremiumFreightAmt", "Premium Freight Price", locator, null);
                CuryPremiumFreightAmtLabel = new Label(CuryPremiumFreightAmt);
                CuryPremiumFreightAmt.DataField = "CuryPremiumFreightAmt";
                FreightTaxCategoryID = new Selector("ctl00_phG_tab_t9_formG_edFreightTaxCategoryID", "Freight Tax Category", locator, null);
                FreightTaxCategoryIDLabel = new Label(FreightTaxCategoryID);
                FreightTaxCategoryID.DataField = "FreightTaxCategoryID";
                AMEstimateQty = new PXNumberEdit("ctl00_phG_tab_t9_formG_edAMEstimateQty", "Estimate Qty", locator, null);
                AMEstimateQtyLabel = new Label(AMEstimateQty);
                AMEstimateQty.DataField = "AMEstimateQty";
                OpenOrderQty = new PXNumberEdit("ctl00_phG_tab_t9_formG_edOpenOrderQty", "Unshipped Quantity", locator, null);
                OpenOrderQtyLabel = new Label(OpenOrderQty);
                OpenOrderQty.DataField = "OpenOrderQty";
                CuryOpenOrderTotal = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryOpenOrderTotal", "Unshipped Amount", locator, null);
                CuryOpenOrderTotalLabel = new Label(CuryOpenOrderTotal);
                CuryOpenOrderTotal.DataField = "CuryOpenOrderTotal";
                UnbilledOrderQty = new PXNumberEdit("ctl00_phG_tab_t9_formG_edUnbilledOrderQty", "Unbilled Quantity", locator, null);
                UnbilledOrderQtyLabel = new Label(UnbilledOrderQty);
                UnbilledOrderQty.DataField = "UnbilledOrderQty";
                CuryUnbilledOrderTotal = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryUnbilledOrderTotal", "Unbilled Amount", locator, null);
                CuryUnbilledOrderTotalLabel = new Label(CuryUnbilledOrderTotal);
                CuryUnbilledOrderTotal.DataField = "CuryUnbilledOrderTotal";
                CuryPaymentTotal = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryPaymentTotal", "Payment Total", locator, null);
                CuryPaymentTotalLabel = new Label(CuryPaymentTotal);
                CuryPaymentTotal.DataField = "CuryPaymentTotal";
                CuryUnpaidBalance = new PXNumberEdit("ctl00_phG_tab_t9_formG_edCuryUnpaidBalance1", "Unpaid Balance", locator, null);
                CuryUnpaidBalanceLabel = new Label(CuryUnpaidBalance);
                CuryUnpaidBalance.DataField = "CuryUnpaidBalance";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void RefreshFreightCost()
            {
                Buttons.RefreshFreightCost.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RefreshFreightCost { get; }
                
                public PxButtonCollection()
                {
                    RefreshFreightCost = new Button("ctl00_phG_tab_t9_formG_checkFreightRate", "Refresh Freight Cost", "ctl00_phG_tab_t9_formG");
                }
            }
        }
        
        public class c_documentproperties_formcarrierrates : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit OrderWeight { get; }
			public Label OrderWeightLabel { get; }
			public PXNumberEdit PackageWeight { get; }
			public Label PackageWeightLabel { get; }
            
            public c_documentproperties_formcarrierrates(string locator, string name) : 
                    base(locator, name)
            {
                OrderWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_formCarrierRates_edOrderWeight", "Order Weight", locator, null);
                OrderWeightLabel = new Label(OrderWeight);
                OrderWeight.DataField = "OrderWeight";
                PackageWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_formCarrierRates_PXNumberEdit1", "Package Weight", locator, null);
                PackageWeightLabel = new Label(PackageWeight);
                PackageWeight.DataField = "PackageWeight";
                DataMemberName = "DocumentProperties";
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                }
            }
        }
        
        public class c_documentproperties_pxformview1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsManualPackage { get; }
			public Label IsManualPackageLabel { get; }
            
            public c_documentproperties_pxformview1(string locator, string name) : 
                    base(locator, name)
            {
                IsManualPackage = new CheckBox("ctl00_phG_PanelCarrierRates_PXFormView1_edIsManualPackage", "Is Manual Package", locator, null);
                IsManualPackageLabel = new Label(IsManualPackage);
                IsManualPackage.DataField = "IsManualPackage";
                DataMemberName = "DocumentProperties";
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_PXFormView1");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_PXFormView1");
                }
            }
        }
        
        public class c_rutrots_rutrotform : Container
        {
            
			public CheckBox AutoDistribution { get; }
			public Label AutoDistributionLabel { get; }
			public GroupBox RUTROTType { get; }
			public Label RUTROTTypeLabel { get; }
			public PXTextEdit ROTAppartment { get; }
			public Label ROTAppartmentLabel { get; }
			public PXTextEdit ROTEstate { get; }
			public Label ROTEstateLabel { get; }
			public PXTextEdit ROTOrganizationNbr { get; }
			public Label ROTOrganizationNbrLabel { get; }
			public PXNumberEdit DeductionPct { get; }
			public Label DeductionPctLabel { get; }
			public PXNumberEdit CuryTotalAmt { get; }
			public Label CuryTotalAmtLabel { get; }
			public PXNumberEdit CuryOtherCost { get; }
			public Label CuryOtherCostLabel { get; }
			public PXNumberEdit CuryMaterialCost { get; }
			public Label CuryMaterialCostLabel { get; }
			public PXNumberEdit CuryWorkPrice { get; }
			public Label CuryWorkPriceLabel { get; }
			public PXNumberEdit CuryDistributedAmt { get; }
			public Label CuryDistributedAmtLabel { get; }
			public PXNumberEdit CuryUndistributedAmt { get; }
			public Label CuryUndistributedAmtLabel { get; }
            
            public c_rutrots_rutrotform(string locator, string name) : 
                    base(locator, name)
            {
                AutoDistribution = new CheckBox("ctl00_phG_tab_t11_RUTROTForm_chkRRAutoDistribution", "Distribute Automatically", locator, null);
                AutoDistributionLabel = new Label(AutoDistribution);
                AutoDistribution.DataField = "AutoDistribution";
                RUTROTType = new GroupBox("ctl00_phG_tab_t11_RUTROTForm_gbRRType", "RUTROT Type", locator, null);
                RUTROTTypeLabel = new Label(RUTROTType);
                RUTROTType.DataField = "RUTROTType";
                ROTAppartment = new PXTextEdit("ctl00_phG_tab_t11_RUTROTForm_edRAppartment", "Apartment", locator, null);
                ROTAppartmentLabel = new Label(ROTAppartment);
                ROTAppartment.DataField = "ROTAppartment";
                ROTEstate = new PXTextEdit("ctl00_phG_tab_t11_RUTROTForm_edRREstate", "Real estate", locator, null);
                ROTEstateLabel = new Label(ROTEstate);
                ROTEstate.DataField = "ROTEstate";
                ROTOrganizationNbr = new PXTextEdit("ctl00_phG_tab_t11_RUTROTForm_edRROrganizationNbr", "Organization nbr.", locator, null);
                ROTOrganizationNbrLabel = new Label(ROTOrganizationNbr);
                ROTOrganizationNbr.DataField = "ROTOrganizationNbr";
                DeductionPct = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_edRRDeduction", "Deduction,%", locator, null);
                DeductionPctLabel = new Label(DeductionPct);
                DeductionPct.DataField = "DeductionPct";
                CuryTotalAmt = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_edRRTotalAmt", "Total Deductible Amount", locator, null);
                CuryTotalAmtLabel = new Label(CuryTotalAmt);
                CuryTotalAmt.DataField = "CuryTotalAmt";
                CuryOtherCost = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_edRUTROTOtherCost", "Other Cost", locator, null);
                CuryOtherCostLabel = new Label(CuryOtherCost);
                CuryOtherCost.DataField = "CuryOtherCost";
                CuryMaterialCost = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_edRUTROTMaterialCost", "Material Cost", locator, null);
                CuryMaterialCostLabel = new Label(CuryMaterialCost);
                CuryMaterialCost.DataField = "CuryMaterialCost";
                CuryWorkPrice = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_edRUTROTWorkPrice", "Work Price", locator, null);
                CuryWorkPriceLabel = new Label(CuryWorkPrice);
                CuryWorkPrice.DataField = "CuryWorkPrice";
                CuryDistributedAmt = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_edRRAvailAmt", "Distributed Amount", locator, null);
                CuryDistributedAmtLabel = new Label(CuryDistributedAmt);
                CuryDistributedAmt.DataField = "CuryDistributedAmt";
                CuryUndistributedAmt = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_edRRUndsitributedAmt", "Undistributed Amount", locator, null);
                CuryUndistributedAmtLabel = new Label(CuryUndistributedAmt);
                CuryUndistributedAmt.DataField = "CuryUndistributedAmt";
                DataMemberName = "Rutrots";
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
                DataMemberName = "Transactions";
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
            
            public virtual void FormView()
            {
                ToolBar.FormView.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Allocations()
            {
                ToolBar.Allocations.Click();
            }
            
            public virtual void AddInvoice()
            {
                ToolBar.AddInvoice.Click();
            }
            
            public virtual void AddStockItem()
            {
                ToolBar.AddStockItem.Click();
            }
            
            public virtual void ShowMatrixPanel()
            {
                ToolBar.ShowMatrixPanel.Click();
            }
            
            public virtual void POSupplyOK()
            {
                ToolBar.POSupplyOK.Click();
            }
            
            public virtual void InventorySummary()
            {
                ToolBar.InventorySummary.Click();
            }
            
            public virtual void ConfigureEntry()
            {
                ToolBar.ConfigureEntry.Click();
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
            
            public virtual void AppointmentIDEdit()
            {
                Buttons.AppointmentIDEdit.Click();
            }
            
            public virtual void SOIDEdit()
            {
                Buttons.SOIDEdit.Click();
            }
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void AMOrderTypeEdit()
            {
                Buttons.AMOrderTypeEdit.Click();
            }
            
            public virtual void AMProdOrdIDEdit()
            {
                Buttons.AMProdOrdIDEdit.Click();
            }
            
            public virtual void AMEstimateRevisionIDEdit()
            {
                Buttons.AMEstimateRevisionIDEdit.Click();
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
			public ToolBarButtonGrid Allocations { get; }
			public ToolBarButtonGrid AddInvoice { get; }
			public ToolBarButtonGrid AddStockItem { get; }
			public ToolBarButtonGrid ShowMatrixPanel { get; }
			public ToolBarButtonGrid POSupplyOK { get; }
			public ToolBarButtonGrid InventorySummary { get; }
			public ToolBarButtonGrid ConfigureEntry { get; }
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
                    Allocations = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div:textEqual(\"Allocations\") > div[data-type=\'b" +
                            "utton\']", "Allocations", locator, null);
                    AddInvoice = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AddInvoice\']", "Add Invoice", locator, null);
                    AddStockItem = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdASI\']", "Add Stock Item", locator, null);
                    ShowMatrixPanel = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ShowMatrixPanel\']", "Add Matrix Item", locator, null);
                    POSupplyOK = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'POSupplyOK\']", "PO Link", locator, null);
                    InventorySummary = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'InventorySummary\']", "Inventory Summary", locator, null);
                    ConfigureEntry = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ConfigureEntry\']", "Configure", locator, null);
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
                
			public Button AppointmentIDEdit { get; }
			public Button SOIDEdit { get; }
			public Button DiscountIDEdit { get; }
			public Button AMOrderTypeEdit { get; }
			public Button AMProdOrdIDEdit { get; }
			public Button AMEstimateRevisionIDEdit { get; }
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
                    AppointmentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAppointmentID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "AppointmentIDEdit", "ctl00_phG_tab_t0_grid");
                    AppointmentIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SOIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSOID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "SOIDEdit", "ctl00_phG_tab_t0_grid");
                    SOIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edManualDiscountID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMOrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAMOrderType\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "AMOrderTypeEdit", "ctl00_phG_tab_t0_grid");
                    AMOrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMProdOrdIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAMProdOrdID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "AMProdOrdIDEdit", "ctl00_phG_tab_t0_grid");
                    AMProdOrdIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMEstimateRevisionIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAMEstimateRevisionID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "AMEstimateRevisionIDEdit", "ctl00_phG_tab_t0_grid");
                    AMEstimateRevisionIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
			public PXTextEdit Availability { get; }
			public CheckBox IsConfigurable { get; }
			public Selector BranchID { get; }
			public Selector OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SortOrder { get; }
			public DropDown LineType { get; }
			public PXTextEdit InvoiceNbr { get; }
			public DropDown Operation { get; }
			public Selector InventoryID { get; }
			public PXTextEdit AppointmentDate { get; }
			public DropDown EquipmentAction { get; }
			public PXTextEdit Comment { get; }
			public Selector SMEquipmentID { get; }
			public Selector NewTargetEquipmentLineNbr { get; }
			public Selector ComponentID { get; }
			public Selector EquipmentLineRef { get; }
			public PXTextEdit CustomerLocationID { get; }
			public Selector AppointmentID { get; }
			public Selector SOID { get; }
			public CheckBox SDSelected { get; }
			public Selector SubItemID { get; }
			public CheckBox AutoCreateIssueLine { get; }
			public CheckBox IsFree { get; }
			public Selector SiteID { get; }
			public Selector LocationID { get; }
			public InputLocalizable TranDesc { get; }
			public Selector UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit BaseOrderQty { get; }
			public PXNumberEdit ShippedQty { get; }
			public PXNumberEdit OpenQty { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public CheckBox ManualPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit DiscPct { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public Selector DiscountID { get; }
			public PXTextEdit DiscountSequenceID { get; }
			public CheckBox ManualDisc { get; }
			public PXNumberEdit CuryDiscPrice { get; }
			public PXNumberEdit AvgCost { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public DateSelector DRTermStartDate { get; }
			public DateSelector DRTermEndDate { get; }
			public PXNumberEdit CuryUnbilledAmt { get; }
			public DateSelector RequestDate { get; }
			public DateSelector ShipDate { get; }
			public DropDown ShipComplete { get; }
			public PXNumberEdit CompleteQtyMin { get; }
			public PXNumberEdit CompleteQtyMax { get; }
			public CheckBox Completed { get; }
			public CheckBox POCreate { get; }
			public DropDown POSource { get; }
			public Selector LotSerialNbr { get; }
			public DateSelector ExpireDate { get; }
			public Selector ReasonCode { get; }
			public Selector SalesPersonID { get; }
			public Selector TaxCategoryID { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public CheckBox Commissionable { get; }
			public PXTextEdit AlternateID { get; }
			public Selector SalesAcctID { get; }
			public Selector SalesSubID { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public PXNumberEdit CuryUnitPriceDR { get; }
			public PXNumberEdit DiscPctDR { get; }
			public CheckBox IsRUTROTDeductible { get; }
			public DropDown RUTROTItemType { get; }
			public Selector RUTROTWorkTypeID { get; }
			public PXTextEdit CuryRUTROTAvailableAmt { get; }
			public CheckBox AMProdCreate { get; }
			public PXTextEdit AMorderType { get; }
			public Selector AMProdOrdID { get; }
			public Selector AMEstimateID { get; }
			public Selector AMEstimateRevisionID { get; }
			public PXTextEdit AMParentLineNbr { get; }
			public CheckBox AMIsSupplemental { get; }
			public Selector AMConfigKeyID { get; }
                
                public c_grid_row(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Availability = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edAvailability", "Availability", grid.Locator, "Availability");
                    Availability.DataField = "Availability";
                    IsConfigurable = new CheckBox("ctl00_phG_tab_t0_grid", "Configurable", grid.Locator, "IsConfigurable");
                    IsConfigurable.DataField = "IsConfigurable";
                    BranchID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    OrderType = new Selector("_ctl00_phG_tab_t0_grid_lv0_edOrderType", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edOrderNbr", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Line Order", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    LineType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_ec", "Line Type", grid.Locator, "LineType");
                    LineType.DataField = "LineType";
                    LineType.Items.Add("GI", "Goods for Inventory");
                    LineType.Items.Add("GN", "Non-Inventory Goods");
                    LineType.Items.Add("MI", "Misc. Charge");
                    InvoiceNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Invoice Nbr.", grid.Locator, "InvoiceNbr");
                    InvoiceNbr.DataField = "InvoiceNbr";
                    Operation = new DropDown("_ctl00_phG_tab_t0_grid_lv0_ec", "Operation", grid.Locator, "Operation");
                    Operation.DataField = "Operation";
                    Operation.Items.Add("I", "Issue");
                    Operation.Items.Add("R", "Receipt");
                    InventoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    AppointmentDate = new PXTextEdit("ctl00_phG_tab_t0_grid", "Service Appointment Date", grid.Locator, "AppointmentDate");
                    AppointmentDate.DataField = "AppointmentDate";
                    EquipmentAction = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edEquipmentAction", "Equipment Action", grid.Locator, "EquipmentAction");
                    EquipmentAction.DataField = "EquipmentAction";
                    Comment = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edSMComment", "Equipment Action Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                    SMEquipmentID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSMEquipmentID", "Target Equipment ID", grid.Locator, "SMEquipmentID");
                    SMEquipmentID.DataField = "SMEquipmentID";
                    NewTargetEquipmentLineNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edNewTargetEquipmentLineNbr", "Model Equipment Line Nbr.", grid.Locator, "NewTargetEquipmentLineNbr");
                    NewTargetEquipmentLineNbr.DataField = "NewTargetEquipmentLineNbr";
                    ComponentID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSMComponentID", "Component ID", grid.Locator, "ComponentID");
                    ComponentID.DataField = "ComponentID";
                    EquipmentLineRef = new Selector("_ctl00_phG_tab_t0_grid_lv0_edEquipmentLineRef", "Component Line Nbr.", grid.Locator, "EquipmentLineRef");
                    EquipmentLineRef.DataField = "EquipmentLineRef";
                    CustomerLocationID = new PXTextEdit("ctl00_phG_tab_t0_grid", "Location ID", grid.Locator, "CustomerLocationID");
                    CustomerLocationID.DataField = "CustomerLocationID";
                    AppointmentID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAppointmentID", "Appointment Nbr.", grid.Locator, "AppointmentID");
                    AppointmentID.DataField = "AppointmentID";
                    SOID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSOID", "Service Order Nbr.", grid.Locator, "SOID");
                    SOID.DataField = "SOID";
                    SDSelected = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_edSDSelected", "Require Appointment", grid.Locator, "SDSelected");
                    SDSelected.DataField = "SDSelected";
                    SubItemID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    AutoCreateIssueLine = new CheckBox("ctl00_phG_tab_t0_grid_ef", "Auto Create Issue", grid.Locator, "AutoCreateIssueLine");
                    AutoCreateIssueLine.DataField = "AutoCreateIssueLine";
                    IsFree = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkIsFree", "Free Item", grid.Locator, "IsFree");
                    IsFree.DataField = "IsFree";
                    SiteID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    TranDesc = new InputLocalizable("_ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Line Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrderQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edOrderQty", "Quantity", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    BaseOrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Base Order Qty.", grid.Locator, "BaseOrderQty");
                    BaseOrderQty.DataField = "BaseOrderQty";
                    ShippedQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edShippedQty", "Qty. On Shipments", grid.Locator, "ShippedQty");
                    ShippedQty.DataField = "ShippedQty";
                    OpenQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edOpenQty", "Open Qty.", grid.Locator, "OpenQty");
                    OpenQty.DataField = "OpenQty";
                    CuryUnitCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", grid.Locator, "CuryUnitCost");
                    CuryUnitCost.DataField = "CuryUnitCost";
                    CuryUnitPrice = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edUnitPrice", "Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    ManualPrice = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Price", grid.Locator, "ManualPrice");
                    ManualPrice.DataField = "ManualPrice";
                    CuryExtPrice = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryExtPrice", "Ext. Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    DiscPct = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edDiscPct", "Discount Percent", grid.Locator, "DiscPct");
                    DiscPct.DataField = "DiscPct";
                    CuryDiscAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryDiscAmt", "Discount Amount", grid.Locator, "CuryDiscAmt");
                    CuryDiscAmt.DataField = "CuryDiscAmt";
                    DiscountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edManualDiscountID", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Discount Sequence", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    ManualDisc = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", grid.Locator, "ManualDisc");
                    ManualDisc.DataField = "ManualDisc";
                    CuryDiscPrice = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Disc. Unit Price", grid.Locator, "CuryDiscPrice");
                    CuryDiscPrice.DataField = "CuryDiscPrice";
                    AvgCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Average Cost", grid.Locator, "AvgCost");
                    AvgCost.DataField = "AvgCost";
                    CuryLineAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryLineAmt", "Amount", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    DRTermStartDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", grid.Locator, "DRTermStartDate");
                    DRTermStartDate.DataField = "DRTermStartDate";
                    DRTermEndDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", grid.Locator, "DRTermEndDate");
                    DRTermEndDate.DataField = "DRTermEndDate";
                    CuryUnbilledAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryUnbilledAmt", "Unbilled Amount", grid.Locator, "CuryUnbilledAmt");
                    CuryUnbilledAmt.DataField = "CuryUnbilledAmt";
                    RequestDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edRequestDate1", "Requested On", grid.Locator, "RequestDate");
                    RequestDate.DataField = "RequestDate";
                    ShipDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edShipDate", "Ship On", grid.Locator, "ShipDate");
                    ShipDate.DataField = "ShipDate";
                    ShipComplete = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edShipComplete", "Shipping Rule", grid.Locator, "ShipComplete");
                    ShipComplete.DataField = "ShipComplete";
                    ShipComplete.Items.Add("B", "Back Order Allowed");
                    ShipComplete.Items.Add("L", "Cancel Remainder");
                    ShipComplete.Items.Add("C", "Ship Complete");
                    CompleteQtyMin = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCompleteQtyMin", "Undership Threshold (%)", grid.Locator, "CompleteQtyMin");
                    CompleteQtyMin.DataField = "CompleteQtyMin";
                    CompleteQtyMax = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCompleteQtyMax", "Overship Threshold (%)", grid.Locator, "CompleteQtyMax");
                    CompleteQtyMax.DataField = "CompleteQtyMax";
                    Completed = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkCompleted", "Completed", grid.Locator, "Completed");
                    Completed.DataField = "Completed";
                    POCreate = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkPOCreate", "Mark for PO", grid.Locator, "POCreate");
                    POCreate.DataField = "POCreate";
                    POSource = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edPOSource", "PO Source", grid.Locator, "POSource");
                    POSource.DataField = "POSource";
                    POSource.Items.Add("D", "Drop-Ship");
                    POSource.Items.Add("O", "Purchase to Order");
                    LotSerialNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    ExpireDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    ReasonCode = new Selector("_ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", grid.Locator, "ReasonCode");
                    ReasonCode.DataField = "ReasonCode";
                    SalesPersonID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSalesPersonID", "Salesperson ID", grid.Locator, "SalesPersonID");
                    SalesPersonID.DataField = "SalesPersonID";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    AvalaraCustomerUsageType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edAvalaraCustomerUsageTypeID1", "Entity Usage Type", grid.Locator, "AvalaraCustomerUsageType");
                    AvalaraCustomerUsageType.DataField = "AvalaraCustomerUsageType";
                    AvalaraCustomerUsageType.Items.Add("A", "Federal Government");
                    AvalaraCustomerUsageType.Items.Add("B", "State/Local Govt.");
                    AvalaraCustomerUsageType.Items.Add("C", "Tribal Government");
                    AvalaraCustomerUsageType.Items.Add("D", "Foreign Diplomat");
                    AvalaraCustomerUsageType.Items.Add("E", "Charitable Organization");
                    AvalaraCustomerUsageType.Items.Add("F", "Religious");
                    AvalaraCustomerUsageType.Items.Add("G", "Resale");
                    AvalaraCustomerUsageType.Items.Add("H", "Agricultural Production");
                    AvalaraCustomerUsageType.Items.Add("I", "Industrial Prod/Mfg.");
                    AvalaraCustomerUsageType.Items.Add("J", "Direct Pay Permit");
                    AvalaraCustomerUsageType.Items.Add("K", "Direct Mail");
                    AvalaraCustomerUsageType.Items.Add("L", "Other");
                    AvalaraCustomerUsageType.Items.Add("M", "Education");
                    AvalaraCustomerUsageType.Items.Add("N", "Local Government");
                    AvalaraCustomerUsageType.Items.Add("P", "Commercial Aquaculture");
                    AvalaraCustomerUsageType.Items.Add("Q", "Commercial Fishery");
                    AvalaraCustomerUsageType.Items.Add("R", "Non-resident");
                    AvalaraCustomerUsageType.Items.Add("0", "Default");
                    Commissionable = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkCommissionable", "Commissionable", grid.Locator, "Commissionable");
                    Commissionable.DataField = "Commissionable";
                    AlternateID = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edAlternateID", "Alternate ID", grid.Locator, "AlternateID");
                    AlternateID.DataField = "AlternateID";
                    SalesAcctID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSalesAcctID", "Account", grid.Locator, "SalesAcctID");
                    SalesAcctID.DataField = "SalesAcctID";
                    SalesSubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSalesSubID", "Subaccount", grid.Locator, "SalesSubID");
                    SalesSubID.DataField = "SalesSubID";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edCostCode", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    CuryUnitPriceDR = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Unit Price for DR", grid.Locator, "CuryUnitPriceDR");
                    CuryUnitPriceDR.DataField = "CuryUnitPriceDR";
                    DiscPctDR = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Discount Percent for DR", grid.Locator, "DiscPctDR");
                    DiscPctDR.DataField = "DiscPctDR";
                    IsRUTROTDeductible = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkRRDeductibleTran", "ROT or RUT deductible", grid.Locator, "IsRUTROTDeductible");
                    IsRUTROTDeductible.DataField = "IsRUTROTDeductible";
                    RUTROTItemType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_cmbRRItemType", "Item Type", grid.Locator, "RUTROTItemType");
                    RUTROTItemType.DataField = "RUTROTItemType";
                    RUTROTWorkTypeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_cmbRRWorkType", "Type of Work", grid.Locator, "RUTROTWorkTypeID");
                    RUTROTWorkTypeID.DataField = "RUTROTWorkTypeID";
                    CuryRUTROTAvailableAmt = new PXTextEdit("ctl00_phG_tab_t0_grid", "Deductible Amount", grid.Locator, "CuryRUTROTAvailableAmt");
                    CuryRUTROTAvailableAmt.DataField = "CuryRUTROTAvailableAmt";
                    AMProdCreate = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkAMProdCreate", "Mark for Production", grid.Locator, "AMProdCreate");
                    AMProdCreate.DataField = "AMProdCreate";
                    AMorderType = new PXTextEdit("ctl00_phG_tab_t0_grid", "Prod. Order Type", grid.Locator, "AMorderType");
                    AMorderType.DataField = "AMorderType";
                    AMProdOrdID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAMProdOrdID", "Production Nbr", grid.Locator, "AMProdOrdID");
                    AMProdOrdID.DataField = "AMProdOrdID";
                    AMEstimateID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAMEstimateID", "Estimate ID", grid.Locator, "AMEstimateID");
                    AMEstimateID.DataField = "AMEstimateID";
                    AMEstimateRevisionID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAMEstimateRevisionID", "Est. Revision", grid.Locator, "AMEstimateRevisionID");
                    AMEstimateRevisionID.DataField = "AMEstimateRevisionID";
                    AMParentLineNbr = new PXTextEdit("ctl00_phG_tab_t0_grid", "Parent Line Nbr.", grid.Locator, "AMParentLineNbr");
                    AMParentLineNbr.DataField = "AMParentLineNbr";
                    AMIsSupplemental = new CheckBox("ctl00_phG_tab_t0_grid", "Is Supplemental", grid.Locator, "AMIsSupplemental");
                    AMIsSupplemental.DataField = "AMIsSupplemental";
                    AMConfigKeyID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAMConfigKeyID", "Config. Key", grid.Locator, "AMConfigKeyID");
                    AMConfigKeyID.DataField = "AMConfigKeyID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter Availability { get; }
				public CheckBoxColumnFilter IsConfigurable { get; }
				public SelectorColumnFilter BranchID { get; }
				public SelectorColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public DropDownColumnFilter LineType { get; }
				public PXTextEditColumnFilter InvoiceNbr { get; }
				public DropDownColumnFilter Operation { get; }
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter AppointmentDate { get; }
				public DropDownColumnFilter EquipmentAction { get; }
				public PXTextEditColumnFilter Comment { get; }
				public InputColumnFilter SMEquipmentID { get; }
				public InputColumnFilter NewTargetEquipmentLineNbr { get; }
				public InputColumnFilter ComponentID { get; }
				public InputColumnFilter EquipmentLineRef { get; }
				public PXTextEditColumnFilter CustomerLocationID { get; }
				public InputColumnFilter AppointmentID { get; }
				public InputColumnFilter SOID { get; }
				public CheckBoxColumnFilter SDSelected { get; }
				public SelectorColumnFilter SubItemID { get; }
				public CheckBoxColumnFilter AutoCreateIssueLine { get; }
				public CheckBoxColumnFilter IsFree { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter BaseOrderQty { get; }
				public PXNumberEditColumnFilter ShippedQty { get; }
				public PXNumberEditColumnFilter OpenQty { get; }
				public PXNumberEditColumnFilter CuryUnitCost { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public CheckBoxColumnFilter ManualPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter DiscPct { get; }
				public PXNumberEditColumnFilter CuryDiscAmt { get; }
				public SelectorColumnFilter DiscountID { get; }
				public PXTextEditColumnFilter DiscountSequenceID { get; }
				public CheckBoxColumnFilter ManualDisc { get; }
				public PXNumberEditColumnFilter CuryDiscPrice { get; }
				public PXNumberEditColumnFilter AvgCost { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public DateSelectorColumnFilter DRTermStartDate { get; }
				public DateSelectorColumnFilter DRTermEndDate { get; }
				public PXNumberEditColumnFilter CuryUnbilledAmt { get; }
				public DateSelectorColumnFilter RequestDate { get; }
				public DateSelectorColumnFilter ShipDate { get; }
				public DropDownColumnFilter ShipComplete { get; }
				public PXNumberEditColumnFilter CompleteQtyMin { get; }
				public PXNumberEditColumnFilter CompleteQtyMax { get; }
				public CheckBoxColumnFilter Completed { get; }
				public CheckBoxColumnFilter POCreate { get; }
				public DropDownColumnFilter POSource { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public SelectorColumnFilter ReasonCode { get; }
				public SelectorColumnFilter SalesPersonID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public DropDownColumnFilter AvalaraCustomerUsageType { get; }
				public CheckBoxColumnFilter Commissionable { get; }
				public PXTextEditColumnFilter AlternateID { get; }
				public SelectorColumnFilter SalesAcctID { get; }
				public SelectorColumnFilter SalesSubID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public PXNumberEditColumnFilter CuryUnitPriceDR { get; }
				public PXNumberEditColumnFilter DiscPctDR { get; }
				public CheckBoxColumnFilter IsRUTROTDeductible { get; }
				public DropDownColumnFilter RUTROTItemType { get; }
				public InputColumnFilter RUTROTWorkTypeID { get; }
				public PXTextEditColumnFilter CuryRUTROTAvailableAmt { get; }
				public CheckBoxColumnFilter AMProdCreate { get; }
				public PXTextEditColumnFilter AMorderType { get; }
				public InputColumnFilter AMProdOrdID { get; }
				public InputColumnFilter AMEstimateID { get; }
				public InputColumnFilter AMEstimateRevisionID { get; }
				public PXTextEditColumnFilter AMParentLineNbr { get; }
				public CheckBoxColumnFilter AMIsSupplemental { get; }
				public InputColumnFilter AMConfigKeyID { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Availability = new PXTextEditColumnFilter(grid.Row.Availability);
                    IsConfigurable = new CheckBoxColumnFilter(grid.Row.IsConfigurable);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    LineType = new DropDownColumnFilter(grid.Row.LineType);
                    InvoiceNbr = new PXTextEditColumnFilter(grid.Row.InvoiceNbr);
                    Operation = new DropDownColumnFilter(grid.Row.Operation);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    AppointmentDate = new PXTextEditColumnFilter(grid.Row.AppointmentDate);
                    EquipmentAction = new DropDownColumnFilter(grid.Row.EquipmentAction);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                    SMEquipmentID = new InputColumnFilter(grid.Row.SMEquipmentID);
                    NewTargetEquipmentLineNbr = new InputColumnFilter(grid.Row.NewTargetEquipmentLineNbr);
                    ComponentID = new InputColumnFilter(grid.Row.ComponentID);
                    EquipmentLineRef = new InputColumnFilter(grid.Row.EquipmentLineRef);
                    CustomerLocationID = new PXTextEditColumnFilter(grid.Row.CustomerLocationID);
                    AppointmentID = new InputColumnFilter(grid.Row.AppointmentID);
                    SOID = new InputColumnFilter(grid.Row.SOID);
                    SDSelected = new CheckBoxColumnFilter(grid.Row.SDSelected);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    AutoCreateIssueLine = new CheckBoxColumnFilter(grid.Row.AutoCreateIssueLine);
                    IsFree = new CheckBoxColumnFilter(grid.Row.IsFree);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    BaseOrderQty = new PXNumberEditColumnFilter(grid.Row.BaseOrderQty);
                    ShippedQty = new PXNumberEditColumnFilter(grid.Row.ShippedQty);
                    OpenQty = new PXNumberEditColumnFilter(grid.Row.OpenQty);
                    CuryUnitCost = new PXNumberEditColumnFilter(grid.Row.CuryUnitCost);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    ManualPrice = new CheckBoxColumnFilter(grid.Row.ManualPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    DiscPct = new PXNumberEditColumnFilter(grid.Row.DiscPct);
                    CuryDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscAmt);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new PXTextEditColumnFilter(grid.Row.DiscountSequenceID);
                    ManualDisc = new CheckBoxColumnFilter(grid.Row.ManualDisc);
                    CuryDiscPrice = new PXNumberEditColumnFilter(grid.Row.CuryDiscPrice);
                    AvgCost = new PXNumberEditColumnFilter(grid.Row.AvgCost);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    DRTermStartDate = new DateSelectorColumnFilter(grid.Row.DRTermStartDate);
                    DRTermEndDate = new DateSelectorColumnFilter(grid.Row.DRTermEndDate);
                    CuryUnbilledAmt = new PXNumberEditColumnFilter(grid.Row.CuryUnbilledAmt);
                    RequestDate = new DateSelectorColumnFilter(grid.Row.RequestDate);
                    ShipDate = new DateSelectorColumnFilter(grid.Row.ShipDate);
                    ShipComplete = new DropDownColumnFilter(grid.Row.ShipComplete);
                    CompleteQtyMin = new PXNumberEditColumnFilter(grid.Row.CompleteQtyMin);
                    CompleteQtyMax = new PXNumberEditColumnFilter(grid.Row.CompleteQtyMax);
                    Completed = new CheckBoxColumnFilter(grid.Row.Completed);
                    POCreate = new CheckBoxColumnFilter(grid.Row.POCreate);
                    POSource = new DropDownColumnFilter(grid.Row.POSource);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    ReasonCode = new SelectorColumnFilter(grid.Row.ReasonCode);
                    SalesPersonID = new SelectorColumnFilter(grid.Row.SalesPersonID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    AvalaraCustomerUsageType = new DropDownColumnFilter(grid.Row.AvalaraCustomerUsageType);
                    Commissionable = new CheckBoxColumnFilter(grid.Row.Commissionable);
                    AlternateID = new PXTextEditColumnFilter(grid.Row.AlternateID);
                    SalesAcctID = new SelectorColumnFilter(grid.Row.SalesAcctID);
                    SalesSubID = new SelectorColumnFilter(grid.Row.SalesSubID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    CuryUnitPriceDR = new PXNumberEditColumnFilter(grid.Row.CuryUnitPriceDR);
                    DiscPctDR = new PXNumberEditColumnFilter(grid.Row.DiscPctDR);
                    IsRUTROTDeductible = new CheckBoxColumnFilter(grid.Row.IsRUTROTDeductible);
                    RUTROTItemType = new DropDownColumnFilter(grid.Row.RUTROTItemType);
                    RUTROTWorkTypeID = new InputColumnFilter(grid.Row.RUTROTWorkTypeID);
                    CuryRUTROTAvailableAmt = new PXTextEditColumnFilter(grid.Row.CuryRUTROTAvailableAmt);
                    AMProdCreate = new CheckBoxColumnFilter(grid.Row.AMProdCreate);
                    AMorderType = new PXTextEditColumnFilter(grid.Row.AMorderType);
                    AMProdOrdID = new InputColumnFilter(grid.Row.AMProdOrdID);
                    AMEstimateID = new InputColumnFilter(grid.Row.AMEstimateID);
                    AMEstimateRevisionID = new InputColumnFilter(grid.Row.AMEstimateRevisionID);
                    AMParentLineNbr = new PXTextEditColumnFilter(grid.Row.AMParentLineNbr);
                    AMIsSupplemental = new CheckBoxColumnFilter(grid.Row.AMIsSupplemental);
                    AMConfigKeyID = new InputColumnFilter(grid.Row.AMConfigKeyID);
                }
            }
        }
        
        public class c_transactions_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector AppointmentID { get; }
			public Label AppointmentIDLabel { get; }
			public Selector SOID { get; }
			public Label SOIDLabel { get; }
			public CheckBox SDSelected { get; }
			public Label SDSelectedLabel { get; }
			public DropDown EquipmentAction { get; }
			public Label EquipmentActionLabel { get; }
			public PXTextEdit Comment { get; }
			public Label CommentLabel { get; }
			public Selector SMEquipmentID { get; }
			public Label SMEquipmentIDLabel { get; }
			public Selector NewTargetEquipmentLineNbr { get; }
			public Label NewTargetEquipmentLineNbrLabel { get; }
			public Selector ComponentID { get; }
			public Label ComponentIDLabel { get; }
			public Selector EquipmentLineRef { get; }
			public Label EquipmentLineRefLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public CheckBox IsFree { get; }
			public Label IsFreeLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public Label CuryUnitCostLabel { get; }
			public PXNumberEdit OrderQty { get; }
			public Label OrderQtyLabel { get; }
			public PXNumberEdit ShippedQty { get; }
			public Label ShippedQtyLabel { get; }
			public PXNumberEdit OpenQty { get; }
			public Label OpenQtyLabel { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public Label CuryUnitPriceLabel { get; }
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
			public CheckBox Completed { get; }
			public Label CompletedLabel { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public Label CuryExtPriceLabel { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public Label CuryLineAmtLabel { get; }
			public PXNumberEdit CuryUnbilledAmt { get; }
			public Label CuryUnbilledAmtLabel { get; }
			public DateSelector RequestDate { get; }
			public Label RequestDateLabel { get; }
			public DateSelector ShipDate { get; }
			public Label ShipDateLabel { get; }
			public DropDown ShipComplete { get; }
			public Label ShipCompleteLabel { get; }
			public PXNumberEdit CompleteQtyMin { get; }
			public Label CompleteQtyMinLabel { get; }
			public PXNumberEdit CompleteQtyMax { get; }
			public Label CompleteQtyMaxLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public DateSelector DRTermStartDate { get; }
			public Label DRTermStartDateLabel { get; }
			public DateSelector DRTermEndDate { get; }
			public Label DRTermEndDateLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public CheckBox POCreate { get; }
			public Label POCreateLabel { get; }
			public DropDown POSource { get; }
			public Label POSourceLabel { get; }
			public Selector ReasonCode { get; }
			public Label ReasonCodeLabel { get; }
			public Selector SalesPersonID { get; }
			public Label SalesPersonIDLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public Label AvalaraCustomerUsageTypeLabel { get; }
			public PXTextEdit AlternateID { get; }
			public Label AlternateIDLabel { get; }
			public Selector LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public CheckBox Commissionable { get; }
			public Label CommissionableLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public CheckBox IsRUTROTDeductible { get; }
			public Label IsRUTROTDeductibleLabel { get; }
			public DropDown RUTROTItemType { get; }
			public Label RUTROTItemTypeLabel { get; }
			public Selector RUTROTWorkTypeID { get; }
			public Label RUTROTWorkTypeIDLabel { get; }
			public CheckBox AMProdCreate { get; }
			public Label AMProdCreateLabel { get; }
			public Selector AMOrderType { get; }
			public Label AMOrderTypeLabel { get; }
			public Selector AMProdOrdID { get; }
			public Label AMProdOrdIDLabel { get; }
			public Selector AMEstimateID { get; }
			public Label AMEstimateIDLabel { get; }
			public Selector AMEstimateRevisionID { get; }
			public Label AMEstimateRevisionIDLabel { get; }
			public Selector AMConfigKeyID { get; }
			public Label AMConfigKeyIDLabel { get; }
			public InputLocalizable TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public PXTextEdit OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public PXNumberEdit LineNbr { get; }
			public Label LineNbrLabel { get; }
			public PXTextEdit Availability { get; }
			public Label AvailabilityLabel { get; }
            
            public c_transactions_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                AppointmentID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAppointmentID", "Appointment Nbr.", locator, null);
                AppointmentIDLabel = new Label(AppointmentID);
                AppointmentID.DataField = "AppointmentID";
                SOID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSOID", "Service Order Nbr.", locator, null);
                SOIDLabel = new Label(SOID);
                SOID.DataField = "SOID";
                SDSelected = new CheckBox("ctl00_phG_tab_t0_grid_lv0_edSDSelected", "Require Appointment", locator, null);
                SDSelectedLabel = new Label(SDSelected);
                SDSelected.DataField = "SDSelected";
                EquipmentAction = new DropDown("ctl00_phG_tab_t0_grid_lv0_edEquipmentAction", "Equipment Action", locator, null);
                EquipmentActionLabel = new Label(EquipmentAction);
                EquipmentAction.DataField = "EquipmentAction";
                Comment = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edSMComment", "Equipment Action Comment", locator, null);
                CommentLabel = new Label(Comment);
                Comment.DataField = "Comment";
                SMEquipmentID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSMEquipmentID", "Target Equipment ID", locator, null);
                SMEquipmentIDLabel = new Label(SMEquipmentID);
                SMEquipmentID.DataField = "SMEquipmentID";
                NewTargetEquipmentLineNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edNewTargetEquipmentLineNbr", "Model Equipment Line Nbr.", locator, null);
                NewTargetEquipmentLineNbrLabel = new Label(NewTargetEquipmentLineNbr);
                NewTargetEquipmentLineNbr.DataField = "NewTargetEquipmentLineNbr";
                ComponentID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSMComponentID", "Component ID", locator, null);
                ComponentIDLabel = new Label(ComponentID);
                ComponentID.DataField = "ComponentID";
                EquipmentLineRef = new Selector("ctl00_phG_tab_t0_grid_lv0_edEquipmentLineRef", "Component Line Nbr.", locator, null);
                EquipmentLineRefLabel = new Label(EquipmentLineRef);
                EquipmentLineRef.DataField = "EquipmentLineRef";
                SubItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                IsFree = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkIsFree", "Free Item", locator, null);
                IsFreeLabel = new Label(IsFree);
                IsFree.DataField = "IsFree";
                SiteID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                CuryUnitCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", locator, null);
                CuryUnitCostLabel = new Label(CuryUnitCost);
                CuryUnitCost.DataField = "CuryUnitCost";
                OrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edOrderQty", "Quantity", locator, null);
                OrderQtyLabel = new Label(OrderQty);
                OrderQty.DataField = "OrderQty";
                ShippedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edShippedQty", "Qty. On Shipments", locator, null);
                ShippedQtyLabel = new Label(ShippedQty);
                ShippedQty.DataField = "ShippedQty";
                OpenQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edOpenQty", "Open Qty.", locator, null);
                OpenQtyLabel = new Label(OpenQty);
                OpenQty.DataField = "OpenQty";
                CuryUnitPrice = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edUnitPrice", "Unit Price", locator, null);
                CuryUnitPriceLabel = new Label(CuryUnitPrice);
                CuryUnitPrice.DataField = "CuryUnitPrice";
                ManualPrice = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Price", locator, null);
                ManualPriceLabel = new Label(ManualPrice);
                ManualPrice.DataField = "ManualPrice";
                DiscountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edManualDiscountID", "Discount Code", locator, null);
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
                Completed = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkCompleted", "Completed", locator, null);
                CompletedLabel = new Label(Completed);
                Completed.DataField = "Completed";
                CuryExtPrice = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryExtPrice", "Ext. Price", locator, null);
                CuryExtPriceLabel = new Label(CuryExtPrice);
                CuryExtPrice.DataField = "CuryExtPrice";
                CuryLineAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryLineAmt", "Amount", locator, null);
                CuryLineAmtLabel = new Label(CuryLineAmt);
                CuryLineAmt.DataField = "CuryLineAmt";
                CuryUnbilledAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnbilledAmt", "Unbilled Amount", locator, null);
                CuryUnbilledAmtLabel = new Label(CuryUnbilledAmt);
                CuryUnbilledAmt.DataField = "CuryUnbilledAmt";
                RequestDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edRequestDate1", "Requested On", locator, null);
                RequestDateLabel = new Label(RequestDate);
                RequestDate.DataField = "RequestDate";
                ShipDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edShipDate", "Ship On", locator, null);
                ShipDateLabel = new Label(ShipDate);
                ShipDate.DataField = "ShipDate";
                ShipComplete = new DropDown("ctl00_phG_tab_t0_grid_lv0_edShipComplete", "Shipping Rule", locator, null);
                ShipCompleteLabel = new Label(ShipComplete);
                ShipComplete.DataField = "ShipComplete";
                ShipComplete.Items.Add("B", "Back Order Allowed");
                ShipComplete.Items.Add("L", "Cancel Remainder");
                ShipComplete.Items.Add("C", "Ship Complete");
                CompleteQtyMin = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCompleteQtyMin", "Undership Threshold (%)", locator, null);
                CompleteQtyMinLabel = new Label(CompleteQtyMin);
                CompleteQtyMin.DataField = "CompleteQtyMin";
                CompleteQtyMax = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCompleteQtyMax", "Overship Threshold (%)", locator, null);
                CompleteQtyMaxLabel = new Label(CompleteQtyMax);
                CompleteQtyMax.DataField = "CompleteQtyMax";
                ExpireDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                DRTermStartDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", locator, null);
                DRTermStartDateLabel = new Label(DRTermStartDate);
                DRTermStartDate.DataField = "DRTermStartDate";
                DRTermEndDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", locator, null);
                DRTermEndDateLabel = new Label(DRTermEndDate);
                DRTermEndDate.DataField = "DRTermEndDate";
                BranchID = new Selector("ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                SalesAcctID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSalesAcctID", "Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSalesSubID", "Subaccount", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                POCreate = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkPOCreate", "Mark for PO", locator, null);
                POCreateLabel = new Label(POCreate);
                POCreate.DataField = "POCreate";
                POSource = new DropDown("ctl00_phG_tab_t0_grid_lv0_edPOSource", "PO Source", locator, null);
                POSourceLabel = new Label(POSource);
                POSource.DataField = "POSource";
                POSource.Items.Add("D", "Drop-Ship");
                POSource.Items.Add("O", "Purchase to Order");
                ReasonCode = new Selector("ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", locator, null);
                ReasonCodeLabel = new Label(ReasonCode);
                ReasonCode.DataField = "ReasonCode";
                SalesPersonID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSalesPersonID", "Salesperson ID", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                AvalaraCustomerUsageType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edAvalaraCustomerUsageTypeID1", "Entity Usage Type", locator, null);
                AvalaraCustomerUsageTypeLabel = new Label(AvalaraCustomerUsageType);
                AvalaraCustomerUsageType.DataField = "AvalaraCustomerUsageType";
                AvalaraCustomerUsageType.Items.Add("A", "Federal Government");
                AvalaraCustomerUsageType.Items.Add("B", "State/Local Govt.");
                AvalaraCustomerUsageType.Items.Add("C", "Tribal Government");
                AvalaraCustomerUsageType.Items.Add("D", "Foreign Diplomat");
                AvalaraCustomerUsageType.Items.Add("E", "Charitable Organization");
                AvalaraCustomerUsageType.Items.Add("F", "Religious");
                AvalaraCustomerUsageType.Items.Add("G", "Resale");
                AvalaraCustomerUsageType.Items.Add("H", "Agricultural Production");
                AvalaraCustomerUsageType.Items.Add("I", "Industrial Prod/Mfg.");
                AvalaraCustomerUsageType.Items.Add("J", "Direct Pay Permit");
                AvalaraCustomerUsageType.Items.Add("K", "Direct Mail");
                AvalaraCustomerUsageType.Items.Add("L", "Other");
                AvalaraCustomerUsageType.Items.Add("M", "Education");
                AvalaraCustomerUsageType.Items.Add("N", "Local Government");
                AvalaraCustomerUsageType.Items.Add("P", "Commercial Aquaculture");
                AvalaraCustomerUsageType.Items.Add("Q", "Commercial Fishery");
                AvalaraCustomerUsageType.Items.Add("R", "Non-resident");
                AvalaraCustomerUsageType.Items.Add("0", "Default");
                AlternateID = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edAlternateID", "Alternate ID", locator, null);
                AlternateIDLabel = new Label(AlternateID);
                AlternateID.DataField = "AlternateID";
                LotSerialNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                Commissionable = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkCommissionable", "Commissionable", locator, null);
                CommissionableLabel = new Label(Commissionable);
                Commissionable.DataField = "Commissionable";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                CostCodeID = new Selector("ctl00_phG_tab_t0_grid_lv0_edCostCode", "Cost Code", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                IsRUTROTDeductible = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkRRDeductibleTran", "ROT or RUT deductible", locator, null);
                IsRUTROTDeductibleLabel = new Label(IsRUTROTDeductible);
                IsRUTROTDeductible.DataField = "IsRUTROTDeductible";
                RUTROTItemType = new DropDown("ctl00_phG_tab_t0_grid_lv0_cmbRRItemType", "Item Type", locator, null);
                RUTROTItemTypeLabel = new Label(RUTROTItemType);
                RUTROTItemType.DataField = "RUTROTItemType";
                RUTROTWorkTypeID = new Selector("ctl00_phG_tab_t0_grid_lv0_cmbRRWorkType", "Type of Work", locator, null);
                RUTROTWorkTypeIDLabel = new Label(RUTROTWorkTypeID);
                RUTROTWorkTypeID.DataField = "RUTROTWorkTypeID";
                AMProdCreate = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkAMProdCreate", "Mark for Production", locator, null);
                AMProdCreateLabel = new Label(AMProdCreate);
                AMProdCreate.DataField = "AMProdCreate";
                AMOrderType = new Selector("ctl00_phG_tab_t0_grid_lv0_edAMOrderType", "Prod. Order Type", locator, null);
                AMOrderTypeLabel = new Label(AMOrderType);
                AMOrderType.DataField = "AMOrderType";
                AMProdOrdID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAMProdOrdID", "Production Nbr", locator, null);
                AMProdOrdIDLabel = new Label(AMProdOrdID);
                AMProdOrdID.DataField = "AMProdOrdID";
                AMEstimateID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAMEstimateID", "Estimate ID", locator, null);
                AMEstimateIDLabel = new Label(AMEstimateID);
                AMEstimateID.DataField = "AMEstimateID";
                AMEstimateRevisionID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAMEstimateRevisionID", "Est. Revision", locator, null);
                AMEstimateRevisionIDLabel = new Label(AMEstimateRevisionID);
                AMEstimateRevisionID.DataField = "AMEstimateRevisionID";
                AMConfigKeyID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAMConfigKeyID", "Config. Key", locator, null);
                AMConfigKeyIDLabel = new Label(AMConfigKeyID);
                AMConfigKeyID.DataField = "AMConfigKeyID";
                TranDesc = new InputLocalizable("ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Line Description", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_lv0_ec", "Ec", locator, null);
                OrderType = new Selector("ctl00_phG_tab_t0_grid_lv0_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                LineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                Availability = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edAvailability", "Availability", locator, null);
                AvailabilityLabel = new Label(Availability);
                Availability.DataField = "Availability";
                DataMemberName = "Transactions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void AppointmentIDEdit()
            {
                Buttons.AppointmentIDEdit.Click();
            }
            
            public virtual void SOIDEdit()
            {
                Buttons.SOIDEdit.Click();
            }
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void AMOrderTypeEdit()
            {
                Buttons.AMOrderTypeEdit.Click();
            }
            
            public virtual void AMProdOrdIDEdit()
            {
                Buttons.AMProdOrdIDEdit.Click();
            }
            
            public virtual void AMEstimateRevisionIDEdit()
            {
                Buttons.AMEstimateRevisionIDEdit.Click();
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
			public Button AppointmentIDEdit { get; }
			public Button SOIDEdit { get; }
			public Button DiscountIDEdit { get; }
			public Button AMOrderTypeEdit { get; }
			public Button AMProdOrdIDEdit { get; }
			public Button AMEstimateRevisionIDEdit { get; }
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
                    AppointmentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAppointmentID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "AppointmentIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    AppointmentIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SOIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSOID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "SOIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    SOIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edManualDiscountID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMOrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAMOrderType\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "AMOrderTypeEdit", "ctl00_phG_tab_t0_grid_lv0");
                    AMOrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMProdOrdIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAMProdOrdID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "AMProdOrdIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    AMProdOrdIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMEstimateRevisionIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edAMEstimateRevisionID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "AMEstimateRevisionIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    AMEstimateRevisionIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c_currentposupply_formcurrentposupply : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown POSource { get; }
			public Label POSourceLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector POSiteID { get; }
			public Label POSiteIDLabel { get; }
            
            public c_currentposupply_formcurrentposupply(string locator, string name) : 
                    base(locator, name)
            {
                POSource = new DropDown("ctl00_phG_PanelPOSupply_formCurrentPOSupply_edPOSource", "PO Source", locator, null);
                POSourceLabel = new Label(POSource);
                POSource.DataField = "POSource";
                VendorID = new Selector("ctl00_phG_PanelPOSupply_formCurrentPOSupply_edVendorID", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                POSiteID = new Selector("ctl00_phG_PanelPOSupply_formCurrentPOSupply_edPOSiteID", "PO Site ID", locator, null);
                POSiteIDLabel = new Label(POSiteID);
                POSiteID.DataField = "POSiteID";
                DataMemberName = "currentposupply";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
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
                
			public Button OrderNbrEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_PanelPOSupply_gridPOSupply_lv0_edOrderNbr\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "OrderNbrEdit", "ctl00_phG_PanelPOSupply_formCurrentPOSupply");
                    OrderNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfFirst0", "First", "ctl00_phG_PanelPOSupply_formCurrentPOSupply");
                    Prev = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfPrev0", "Prev", "ctl00_phG_PanelPOSupply_formCurrentPOSupply");
                    Next = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfNext0", "Next", "ctl00_phG_PanelPOSupply_formCurrentPOSupply");
                    Last = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfLast0", "Last", "ctl00_phG_PanelPOSupply_formCurrentPOSupply");
                    Save = new Button("ctl00_phG_PanelPOSupply_PXButton7", "Save", "ctl00_phG_PanelPOSupply_formCurrentPOSupply");
                    Cancel = new Button("ctl00_phG_PanelPOSupply_PXButton8", "Cancel", "ctl00_phG_PanelPOSupply_formCurrentPOSupply");
                }
            }
        }
        
        public class c_amsolinerecords_createprodgrid : Grid<c_amsolinerecords_createprodgrid.c_grid_row, c_amsolinerecords_createprodgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_amsolinerecords_createprodgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelCreateProdOrder_CreateProdgrid");
                DataMemberName = "AMSOLineRecords";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_fe_gf", "FilterForm");
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
            
            public virtual void AMorderTypeEdit()
            {
                Buttons.AMorderTypeEdit.Click();
            }
            
            public virtual void AMProdOrdIDEdit()
            {
                Buttons.AMProdOrdIDEdit.Click();
            }
            
            public virtual void Create()
            {
                Buttons.Create.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_at_tlb div[data-cmd=\'Refresh\']" +
                            "", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_at_tlb div[data-cmd=\'AdjustCol" +
                            "umns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_at_tlb div[data-cmd=\'ExportExc" +
                            "el\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_ab_tlb div[data-cmd=\'PageFirst" +
                            "\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_ab_tlb div[data-cmd=\'PagePrev\'" +
                            "]", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_ab_tlb div[data-cmd=\'PageNext\'" +
                            "]", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_ab_tlb div[data-cmd=\'PageLast\'" +
                            "]", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelCreateProdOrder_CreateProdgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AMorderTypeEdit { get; }
			public Button AMProdOrdIDEdit { get; }
			public Button Create { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AMorderTypeEdit = new Button("css=div[id=\'ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOAMorderType\'] " +
                            "div[class=\'editBtnCont\'] > div > div", "AMorderTypeEdit", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid");
                    AMorderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMProdOrdIDEdit = new Button("css=div[id=\'ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOProdOrdID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "AMProdOrdIDEdit", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid");
                    AMProdOrdIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    Create = new Button("ctl00_phG_PanelCreateProdOrder_CreateProd", "Create", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid");
                    Cancel = new Button("ctl00_phG_PanelCreateProdOrder_CancelProd", "Cancel", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox AMSelected { get; }
			public PXTextEdit LineNbr { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public PXNumberEdit AMQtyReadOnly { get; }
			public PXTextEdit AMUOMReadOnly { get; }
			public Selector AMorderType { get; }
			public Selector AMProdOrdID { get; }
			public PXTextEdit AMProdItem__StatusID { get; }
			public PXNumberEdit AMProdItem__QtyComplete { get; }
			public PXTextEdit AMProdItem__UOM { get; }
			public CheckBox AMConfigurationResults__Completed { get; }
                
                public c_grid_row(c_amsolinerecords_createprodgrid grid) : 
                        base(grid)
                {
                    AMSelected = new CheckBox("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_chkCPOSelected", "AM Selected", grid.Locator, "AMSelected");
                    AMSelected.DataField = "AMSelected";
                    LineNbr = new PXTextEdit("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOLineNbr", "Line Nbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    InventoryID = new Selector("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOSubItemID", "Sub Item ID", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    AMQtyReadOnly = new PXNumberEdit("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOOrderQty", "AM Qty Read Only", grid.Locator, "AMQtyReadOnly");
                    AMQtyReadOnly.DataField = "AMQtyReadOnly";
                    AMUOMReadOnly = new PXTextEdit("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOUOM", "AMUOM Read Only", grid.Locator, "AMUOMReadOnly");
                    AMUOMReadOnly.DataField = "AMUOMReadOnly";
                    AMorderType = new Selector("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOAMorderType", "A Morder Type", grid.Locator, "AMorderType");
                    AMorderType.DataField = "AMorderType";
                    AMProdOrdID = new Selector("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOProdOrdID", "AM Prod Ord ID", grid.Locator, "AMProdOrdID");
                    AMProdOrdID.DataField = "AMProdOrdID";
                    AMProdItem__StatusID = new PXTextEdit("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOStatus", "AM Prod Item __ Status ID", grid.Locator, "AMProdItem__StatusID");
                    AMProdItem__StatusID.DataField = "AMProdItem__StatusID";
                    AMProdItem__QtyComplete = new PXNumberEdit("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOQuantityComplete", "AM Prod Item __ Qty Complete", grid.Locator, "AMProdItem__QtyComplete");
                    AMProdItem__QtyComplete.DataField = "AMProdItem__QtyComplete";
                    AMProdItem__UOM = new PXTextEdit("_ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCProdItemUOM", "AM Prod Item __ UOM", grid.Locator, "AMProdItem__UOM");
                    AMProdItem__UOM.DataField = "AMProdItem__UOM";
                    AMConfigurationResults__Completed = new CheckBox("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_ei", "AM Configuration Results __ Completed", grid.Locator, "AMConfigurationResults__Completed");
                    AMConfigurationResults__Completed.DataField = "AMConfigurationResults__Completed";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter AMSelected { get; }
				public PXTextEditColumnFilter LineNbr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXNumberEditColumnFilter AMQtyReadOnly { get; }
				public PXTextEditColumnFilter AMUOMReadOnly { get; }
				public InputColumnFilter AMorderType { get; }
				public InputColumnFilter AMProdOrdID { get; }
				public PXTextEditColumnFilter AMProdItem__StatusID { get; }
				public PXNumberEditColumnFilter AMProdItem__QtyComplete { get; }
				public PXTextEditColumnFilter AMProdItem__UOM { get; }
				public CheckBoxColumnFilter AMConfigurationResults__Completed { get; }
                
                public c_grid_header(c_amsolinerecords_createprodgrid grid) : 
                        base(grid)
                {
                    AMSelected = new CheckBoxColumnFilter(grid.Row.AMSelected);
                    LineNbr = new PXTextEditColumnFilter(grid.Row.LineNbr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    AMQtyReadOnly = new PXNumberEditColumnFilter(grid.Row.AMQtyReadOnly);
                    AMUOMReadOnly = new PXTextEditColumnFilter(grid.Row.AMUOMReadOnly);
                    AMorderType = new InputColumnFilter(grid.Row.AMorderType);
                    AMProdOrdID = new InputColumnFilter(grid.Row.AMProdOrdID);
                    AMProdItem__StatusID = new PXTextEditColumnFilter(grid.Row.AMProdItem__StatusID);
                    AMProdItem__QtyComplete = new PXNumberEditColumnFilter(grid.Row.AMProdItem__QtyComplete);
                    AMProdItem__UOM = new PXTextEditColumnFilter(grid.Row.AMProdItem__UOM);
                    AMConfigurationResults__Completed = new CheckBoxColumnFilter(grid.Row.AMConfigurationResults__Completed);
                }
            }
        }
        
        public class c_amsolinerecords_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox AMSelected { get; }
			public Label AMSelectedLabel { get; }
			public PXTextEdit LineNbr { get; }
			public Label LineNbrLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public PXNumberEdit AMQtyReadOnly { get; }
			public Label AMQtyReadOnlyLabel { get; }
			public PXTextEdit AMUOMReadOnly { get; }
			public Label AMUOMReadOnlyLabel { get; }
			public Selector AMorderType { get; }
			public Label AMorderTypeLabel { get; }
			public Selector AMProdOrdID { get; }
			public Label AMProdOrdIDLabel { get; }
			public PXTextEdit AMProdItem__StatusID { get; }
			public Label AMProdItem__StatusIDLabel { get; }
			public PXNumberEdit AMProdItem__QtyComplete { get; }
			public Label AMProdItem__QtyCompleteLabel { get; }
			public PXTextEdit AMProdItem__UOM { get; }
			public Label AMProdItem__UOMLabel { get; }
            
            public c_amsolinerecords_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AMSelected = new CheckBox("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_chkCPOSelected", "AM Selected", locator, null);
                AMSelectedLabel = new Label(AMSelected);
                AMSelected.DataField = "AMSelected";
                LineNbr = new PXTextEdit("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOLineNbr", "Line Nbr", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                InventoryID = new Selector("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SubItemID = new Selector("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOSubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                AMQtyReadOnly = new PXNumberEdit("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOOrderQty", "AM Qty Read Only", locator, null);
                AMQtyReadOnlyLabel = new Label(AMQtyReadOnly);
                AMQtyReadOnly.DataField = "AMQtyReadOnly";
                AMUOMReadOnly = new PXTextEdit("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOUOM", "AMUOM Read Only", locator, null);
                AMUOMReadOnlyLabel = new Label(AMUOMReadOnly);
                AMUOMReadOnly.DataField = "AMUOMReadOnly";
                AMorderType = new Selector("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOAMorderType", "A Morder Type", locator, null);
                AMorderTypeLabel = new Label(AMorderType);
                AMorderType.DataField = "AMorderType";
                AMProdOrdID = new Selector("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOProdOrdID", "AM Prod Ord ID", locator, null);
                AMProdOrdIDLabel = new Label(AMProdOrdID);
                AMProdOrdID.DataField = "AMProdOrdID";
                AMProdItem__StatusID = new PXTextEdit("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOStatus", "AM Prod Item __ Status ID", locator, null);
                AMProdItem__StatusIDLabel = new Label(AMProdItem__StatusID);
                AMProdItem__StatusID.DataField = "AMProdItem__StatusID";
                AMProdItem__QtyComplete = new PXNumberEdit("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOQuantityComplete", "AM Prod Item __ Qty Complete", locator, null);
                AMProdItem__QtyCompleteLabel = new Label(AMProdItem__QtyComplete);
                AMProdItem__QtyComplete.DataField = "AMProdItem__QtyComplete";
                AMProdItem__UOM = new PXTextEdit("ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCProdItemUOM", "AM Prod Item __ UOM", locator, null);
                AMProdItem__UOMLabel = new Label(AMProdItem__UOM);
                AMProdItem__UOM.DataField = "AMProdItem__UOM";
                DataMemberName = "AMSOLineRecords";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void AMorderTypeEdit()
            {
                Buttons.AMorderTypeEdit.Click();
            }
            
            public virtual void AMProdOrdIDEdit()
            {
                Buttons.AMProdOrdIDEdit.Click();
            }
            
            public virtual void Create()
            {
                Buttons.Create.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
			public Button AMorderTypeEdit { get; }
			public Button AMProdOrdIDEdit { get; }
			public Button Create { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOInventoryID\'] " +
                            "div[class=\'editBtnCont\'] > div > div", "InventoryIDEdit", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0");
                    InventoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMorderTypeEdit = new Button("css=div[id=\'ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOAMorderType\'] " +
                            "div[class=\'editBtnCont\'] > div > div", "AMorderTypeEdit", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0");
                    AMorderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMProdOrdIDEdit = new Button("css=div[id=\'ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0_edCPOProdOrdID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "AMProdOrdIDEdit", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0");
                    AMProdOrdIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    Create = new Button("ctl00_phG_PanelCreateProdOrder_CreateProd", "Create", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0");
                    Cancel = new Button("ctl00_phG_PanelCreateProdOrder_CancelProd", "Cancel", "ctl00_phG_PanelCreateProdOrder_CreateProdgrid_lv0");
                }
            }
        }
        
        public class c_taxes_grid1 : Grid<c_taxes_grid1.c_grid_row, c_taxes_grid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_taxes_grid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_grid1");
                DataMemberName = "Taxes";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_grid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxID { get; }
			public PXNumberEdit TaxRate { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public PXNumberEdit CuryExemptedAmt { get; }
			public Selector TaxUOM { get; }
			public PXNumberEdit TaxableQty { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public DropDown Tax__TaxType { get; }
			public CheckBox Tax__PendingTax { get; }
			public CheckBox Tax__ReverseTax { get; }
			public CheckBox Tax__ExemptTax { get; }
			public CheckBox Tax__StatisticalTax { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_taxes_grid1 grid) : 
                        base(grid)
                {
                    TaxID = new Selector("_ctl00_phG_tab_t2_grid1_lv0_edTaxID", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    TaxRate = new PXNumberEdit("_ctl00_phG_tab_t2_grid1_lv0_edTaxRate", "Tax Rate", grid.Locator, "TaxRate");
                    TaxRate.DataField = "TaxRate";
                    CuryTaxableAmt = new PXNumberEdit("_ctl00_phG_tab_t2_grid1_lv0_edCuryTaxableAmt", "Taxable Amount", grid.Locator, "CuryTaxableAmt");
                    CuryTaxableAmt.DataField = "CuryTaxableAmt";
                    CuryExemptedAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Exempted Amount", grid.Locator, "CuryExemptedAmt");
                    CuryExemptedAmt.DataField = "CuryExemptedAmt";
                    TaxUOM = new Selector("_ctl00_phG_tab_t2_grid1_lv0_es", "Tax UOM", grid.Locator, "TaxUOM");
                    TaxUOM.DataField = "TaxUOM";
                    TaxableQty = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Taxable Qty.", grid.Locator, "TaxableQty");
                    TaxableQty.DataField = "TaxableQty";
                    CuryTaxAmt = new PXNumberEdit("_ctl00_phG_tab_t2_grid1_lv0_edCuryTaxAmt", "Tax Amount", grid.Locator, "CuryTaxAmt");
                    CuryTaxAmt.DataField = "CuryTaxAmt";
                    Tax__TaxType = new DropDown("_ctl00_phG_tab_t2_grid1_lv0_ec", "Tax Type", grid.Locator, "Tax__TaxType");
                    Tax__TaxType.DataField = "Tax__TaxType";
                    Tax__TaxType.Items.Add("S", "Sales");
                    Tax__TaxType.Items.Add("P", "Use");
                    Tax__TaxType.Items.Add("V", "VAT");
                    Tax__TaxType.Items.Add("W", "Withholding");
                    Tax__TaxType.Items.Add("Q", "Per-Unit/Specific");
                    Tax__PendingTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Pending VAT", grid.Locator, "Tax__PendingTax");
                    Tax__PendingTax.DataField = "Tax__PendingTax";
                    Tax__ReverseTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Reverse VAT", grid.Locator, "Tax__ReverseTax");
                    Tax__ReverseTax.DataField = "Tax__ReverseTax";
                    Tax__ExemptTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Include in VAT Exempt Total", grid.Locator, "Tax__ExemptTax");
                    Tax__ExemptTax.DataField = "Tax__ExemptTax";
                    Tax__StatisticalTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Statistical VAT", grid.Locator, "Tax__StatisticalTax");
                    Tax__StatisticalTax.DataField = "Tax__StatisticalTax";
                    OrderType = new PXTextEdit("ctl00_phG_tab_t2_grid1_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_tab_t2_grid1_ei", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxID { get; }
				public PXNumberEditColumnFilter TaxRate { get; }
				public PXNumberEditColumnFilter CuryTaxableAmt { get; }
				public PXNumberEditColumnFilter CuryExemptedAmt { get; }
				public SelectorColumnFilter TaxUOM { get; }
				public PXNumberEditColumnFilter TaxableQty { get; }
				public PXNumberEditColumnFilter CuryTaxAmt { get; }
				public DropDownColumnFilter Tax__TaxType { get; }
				public CheckBoxColumnFilter Tax__PendingTax { get; }
				public CheckBoxColumnFilter Tax__ReverseTax { get; }
				public CheckBoxColumnFilter Tax__ExemptTax { get; }
				public CheckBoxColumnFilter Tax__StatisticalTax { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_taxes_grid1 grid) : 
                        base(grid)
                {
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                    TaxRate = new PXNumberEditColumnFilter(grid.Row.TaxRate);
                    CuryTaxableAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxableAmt);
                    CuryExemptedAmt = new PXNumberEditColumnFilter(grid.Row.CuryExemptedAmt);
                    TaxUOM = new SelectorColumnFilter(grid.Row.TaxUOM);
                    TaxableQty = new PXNumberEditColumnFilter(grid.Row.TaxableQty);
                    CuryTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxAmt);
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
                TaxID = new Selector("ctl00_phG_tab_t2_grid1_lv0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                TaxRate = new PXNumberEdit("ctl00_phG_tab_t2_grid1_lv0_edTaxRate", "Tax Rate", locator, null);
                TaxRateLabel = new Label(TaxRate);
                TaxRate.DataField = "TaxRate";
                CuryTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_lv0_edCuryTaxableAmt", "Cury Taxable Amt", locator, null);
                CuryTaxableAmtLabel = new Label(CuryTaxableAmt);
                CuryTaxableAmt.DataField = "CuryTaxableAmt";
                CuryTaxAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_lv0_edCuryTaxAmt", "Cury Tax Amt", locator, null);
                CuryTaxAmtLabel = new Label(CuryTaxAmt);
                CuryTaxAmt.DataField = "CuryTaxAmt";
                Es = new Selector("ctl00_phG_tab_t2_grid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t2_grid1_lv0_ec", "Ec", locator, null);
                DataMemberName = "Taxes";
            }
        }
        
        public class c_shipmentlist_grid5 : Grid<c_shipmentlist_grid5.c_grid_row, c_shipmentlist_grid5.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_shipmentlist_grid5(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_grid5");
                DataMemberName = "ShipmentList";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_grid5_fe_gf", "FilterForm");
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
            
            public virtual void InvoiceNbrEdit()
            {
                Buttons.InvoiceNbrEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grid5_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InvoiceNbrEdit { get; }
			public Button InvtRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    InvoiceNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_grid5_lv0_edInvoiceNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvoiceNbrEdit", "ctl00_phG_tab_t7_grid5");
                    InvoiceNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_grid5_lv0_edInvtRefNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvtRefNbrEdit", "ctl00_phG_tab_t7_grid5");
                    InvtRefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public DropDown ShipmentType { get; }
			public PXTextEdit ShipmentNbr { get; }
			public PXTextEdit DisplayShippingRefNoteID { get; }
			public DropDown SOShipment__StatusIsNull { get; }
			public DropDown Operation { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public DateSelector ShipDate { get; }
			public PXNumberEdit ShipmentQty { get; }
			public PXNumberEdit ShipmentWeight { get; }
			public PXNumberEdit ShipmentVolume { get; }
			public DropDown InvoiceType { get; }
			public Selector InvoiceNbr { get; }
			public DropDown InvtDocType { get; }
			public Selector InvtRefNbr { get; }
			public PXTextEdit ShippingRefNoteID { get; }
                
                public c_grid_row(c_shipmentlist_grid5 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ShipmentType = new DropDown("_ctl00_phG_tab_t7_grid5_lv0_ec", "Shipment Type", grid.Locator, "ShipmentType");
                    ShipmentType.DataField = "ShipmentType";
                    ShipmentType.Items.Add("I", "Shipment");
                    ShipmentType.Items.Add("H", "Drop-Shipment");
                    ShipmentType.Items.Add("T", "Transfer");
                    ShipmentType.Items.Add("N", "Invoice");
                    ShipmentNbr = new PXTextEdit("ctl00_phG_tab_t7_grid5_ei", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    DisplayShippingRefNoteID = new PXTextEdit("ctl00_phG_tab_t7_grid5_ei", "Document Nbr.", grid.Locator, "DisplayShippingRefNoteID");
                    DisplayShippingRefNoteID.DataField = "DisplayShippingRefNoteID";
                    SOShipment__StatusIsNull = new DropDown("_ctl00_phG_tab_t7_grid5_lv0_ec", "Status", grid.Locator, "SOShipment__StatusIsNull");
                    SOShipment__StatusIsNull.DataField = "SOShipment__StatusIsNull";
                    SOShipment__StatusIsNull.Items.Add("N", "Open");
                    SOShipment__StatusIsNull.Items.Add("H", "On Hold");
                    SOShipment__StatusIsNull.Items.Add("C", "Completed");
                    SOShipment__StatusIsNull.Items.Add("L", "Canceled");
                    SOShipment__StatusIsNull.Items.Add("F", "Confirmed");
                    SOShipment__StatusIsNull.Items.Add("I", "Invoiced");
                    SOShipment__StatusIsNull.Items.Add("Y", "Partially Invoiced");
                    SOShipment__StatusIsNull.Items.Add("R", "Receipted");
                    SOShipment__StatusIsNull.Items.Add("A", "Auto-Generated");
                    Operation = new DropDown("_ctl00_phG_tab_t7_grid5_lv0_ec", "Operation", grid.Locator, "Operation");
                    Operation.DataField = "Operation";
                    Operation.Items.Add("I", "Issue");
                    Operation.Items.Add("R", "Receipt");
                    OrderType = new PXTextEdit("_ctl00_phG_tab_t7_grid5_lv0_edOrderType3", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("_ctl00_phG_tab_t7_grid5_lv0_edOrderNbr3", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    ShipDate = new DateSelector("_ctl00_phG_tab_t7_grid5_lv0_ed9", "Shipment Date", grid.Locator, "ShipDate");
                    ShipDate.DataField = "ShipDate";
                    ShipmentQty = new PXNumberEdit("_ctl00_phG_tab_t7_grid5_lv0_edShipmentQty3", "Shipped Qty.", grid.Locator, "ShipmentQty");
                    ShipmentQty.DataField = "ShipmentQty";
                    ShipmentWeight = new PXNumberEdit("ctl00_phG_tab_t7_grid5_en", "Shipped Weight", grid.Locator, "ShipmentWeight");
                    ShipmentWeight.DataField = "ShipmentWeight";
                    ShipmentVolume = new PXNumberEdit("ctl00_phG_tab_t7_grid5_en", "Shipped Volume", grid.Locator, "ShipmentVolume");
                    ShipmentVolume.DataField = "ShipmentVolume";
                    InvoiceType = new DropDown("_ctl00_phG_tab_t7_grid5_lv0_ec", "Invoice Type", grid.Locator, "InvoiceType");
                    InvoiceType.DataField = "InvoiceType";
                    InvoiceType.Items.Add("INV", "Invoice");
                    InvoiceType.Items.Add("DRM", "Debit Memo");
                    InvoiceType.Items.Add("CRM", "Credit Memo");
                    InvoiceType.Items.Add("PMT", "Payment");
                    InvoiceType.Items.Add("RPM", "Voided Payment");
                    InvoiceType.Items.Add("PPM", "Prepayment");
                    InvoiceType.Items.Add("REF", "Customer Refund");
                    InvoiceType.Items.Add("VRF", "Voided Refund");
                    InvoiceType.Items.Add("FCH", "Overdue Charge");
                    InvoiceType.Items.Add("SMB", "Balance WO");
                    InvoiceType.Items.Add("SMC", "Credit WO");
                    InvoiceType.Items.Add("CSL", "Cash Sale");
                    InvoiceType.Items.Add("RCS", "Cash Return");
                    InvoiceNbr = new Selector("_ctl00_phG_tab_t7_grid5_lv0_edInvoiceNbr3", "Invoice Nbr.", grid.Locator, "InvoiceNbr");
                    InvoiceNbr.DataField = "InvoiceNbr";
                    InvtDocType = new DropDown("_ctl00_phG_tab_t7_grid5_lv0_ec", "Inventory Doc. Type", grid.Locator, "InvtDocType");
                    InvtDocType.DataField = "InvtDocType";
                    InvtDocType.Items.Add("I", "Issue");
                    InvtDocType.Items.Add("R", "Receipt");
                    InvtDocType.Items.Add("T", "Transfer");
                    InvtDocType.Items.Add("A", "Adjustment");
                    InvtDocType.Items.Add("P", "Production");
                    InvtDocType.Items.Add("D", "Disassembly");
                    InvtRefNbr = new Selector("_ctl00_phG_tab_t7_grid5_lv0_edInvtRefNbr3", "Inventory Ref. Nbr.", grid.Locator, "InvtRefNbr");
                    InvtRefNbr.DataField = "InvtRefNbr";
                    ShippingRefNoteID = new PXTextEdit("ctl00_phG_tab_t7_grid5", "ShippingRefNoteID", grid.Locator, "ShippingRefNoteID");
                    ShippingRefNoteID.DataField = "ShippingRefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter ShipmentType { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public PXTextEditColumnFilter DisplayShippingRefNoteID { get; }
				public DropDownColumnFilter SOShipment__StatusIsNull { get; }
				public DropDownColumnFilter Operation { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public DateSelectorColumnFilter ShipDate { get; }
				public PXNumberEditColumnFilter ShipmentQty { get; }
				public PXNumberEditColumnFilter ShipmentWeight { get; }
				public PXNumberEditColumnFilter ShipmentVolume { get; }
				public DropDownColumnFilter InvoiceType { get; }
				public SelectorColumnFilter InvoiceNbr { get; }
				public DropDownColumnFilter InvtDocType { get; }
				public SelectorColumnFilter InvtRefNbr { get; }
				public PXTextEditColumnFilter ShippingRefNoteID { get; }
                
                public c_grid_header(c_shipmentlist_grid5 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ShipmentType = new DropDownColumnFilter(grid.Row.ShipmentType);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    DisplayShippingRefNoteID = new PXTextEditColumnFilter(grid.Row.DisplayShippingRefNoteID);
                    SOShipment__StatusIsNull = new DropDownColumnFilter(grid.Row.SOShipment__StatusIsNull);
                    Operation = new DropDownColumnFilter(grid.Row.Operation);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    ShipDate = new DateSelectorColumnFilter(grid.Row.ShipDate);
                    ShipmentQty = new PXNumberEditColumnFilter(grid.Row.ShipmentQty);
                    ShipmentWeight = new PXNumberEditColumnFilter(grid.Row.ShipmentWeight);
                    ShipmentVolume = new PXNumberEditColumnFilter(grid.Row.ShipmentVolume);
                    InvoiceType = new DropDownColumnFilter(grid.Row.InvoiceType);
                    InvoiceNbr = new SelectorColumnFilter(grid.Row.InvoiceNbr);
                    InvtDocType = new DropDownColumnFilter(grid.Row.InvtDocType);
                    InvtRefNbr = new SelectorColumnFilter(grid.Row.InvtRefNbr);
                    ShippingRefNoteID = new PXTextEditColumnFilter(grid.Row.ShippingRefNoteID);
                }
            }
        }
        
        public class c_shipmentlist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit OrderType { get; }
			public Label OrderTypeLabel { get; }
			public PXTextEdit OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector InvoiceNbr { get; }
			public Label InvoiceNbrLabel { get; }
			public Selector InvtRefNbr { get; }
			public Label InvtRefNbrLabel { get; }
			public PXNumberEdit ShipmentQty { get; }
			public Label ShipmentQtyLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_shipmentlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new PXTextEdit("ctl00_phG_tab_t7_grid5_lv0_edOrderType3", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new PXTextEdit("ctl00_phG_tab_t7_grid5_lv0_edOrderNbr3", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                InvoiceNbr = new Selector("ctl00_phG_tab_t7_grid5_lv0_edInvoiceNbr3", "Invoice Nbr", locator, null);
                InvoiceNbrLabel = new Label(InvoiceNbr);
                InvoiceNbr.DataField = "InvoiceNbr";
                InvtRefNbr = new Selector("ctl00_phG_tab_t7_grid5_lv0_edInvtRefNbr3", "Invt Ref Nbr", locator, null);
                InvtRefNbrLabel = new Label(InvtRefNbr);
                InvtRefNbr.DataField = "InvtRefNbr";
                ShipmentQty = new PXNumberEdit("ctl00_phG_tab_t7_grid5_lv0_edShipmentQty3", "Shipped Qty.", locator, null);
                ShipmentQtyLabel = new Label(ShipmentQty);
                ShipmentQty.DataField = "ShipmentQty";
                Es = new Selector("ctl00_phG_tab_t7_grid5_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t7_grid5_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t7_grid5_lv0_ec", "Ec", locator, null);
                DataMemberName = "ShipmentList";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InvoiceNbrEdit()
            {
                Buttons.InvoiceNbrEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InvoiceNbrEdit { get; }
			public Button InvtRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    InvoiceNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_grid5_lv0_edInvoiceNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvoiceNbrEdit", "ctl00_phG_tab_t7_grid5_lv0");
                    InvoiceNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_grid5_lv0_edInvtRefNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvtRefNbrEdit", "ctl00_phG_tab_t7_grid5_lv0");
                    InvtRefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_billing_address_forma : Container
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
            
            public c_billing_address_forma(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t4_formA_chkOverrideAddress", "Override Address", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t4_formA_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t4_formA_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t4_formA_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t4_formA_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t4_formA_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t4_formA_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                IsValidated = new CheckBox("ctl00_phG_tab_t4_formA_chkIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Billing_Address";
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
                    AddressLookup = new Button("ctl00_phG_tab_t4_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t4_formA");
                }
            }
        }
        
        public class c_shipping_address_formb : Container
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
            
            public c_shipping_address_formb(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t5_formB_chkOverrideAddress", "Override Address", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t5_formB_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t5_formB_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t5_formB_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t5_formB_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t5_formB_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t5_formB_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                IsValidated = new CheckBox("ctl00_phG_tab_t5_formB_chkIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Shipping_Address";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ShopforRates { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t5_formB_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_formB");
                    ShopforRates = new Button("ctl00_phG_tab_t5_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t5_formB");
                }
            }
        }
        
        public class c_billing_contact_formc : Container
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
            
            public c_billing_contact_formc(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t4_formC_chkOverrideContact", "Override Contact", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t4_formC_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t4_formC_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t4_formC_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t4_formC_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                DataMemberName = "Billing_Contact";
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
                    AddressLookup = new Button("ctl00_phG_tab_t4_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t4_formC");
                }
            }
        }
        
        public class c_shipping_contact_formd : Container
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
            
            public c_shipping_contact_formd(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t5_formD_chkOverrideContact", "Override Contact", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t5_formD_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t5_formD_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t5_formD_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t5_formD_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                DataMemberName = "Shipping_Contact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ShopforRates { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t5_formB_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_formD");
                    ShopforRates = new Button("ctl00_phG_tab_t5_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t5_formD");
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t10_gridApproval");
                DataMemberName = "Approval";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t10_gridApproval_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    ApproverEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t10_gridApproval_ei", "Assignee ID", grid.Locator, "ApproverEmployee__AcctCD");
                    ApproverEmployee__AcctCD.DataField = "ApproverEmployee__AcctCD";
                    ApproverEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t10_gridApproval_ei", "Assigned To", grid.Locator, "ApproverEmployee__AcctName");
                    ApproverEmployee__AcctName.DataField = "ApproverEmployee__AcctName";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t10_gridApproval_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    ApprovedByEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t10_gridApproval_ei", "Approved By (ID)", grid.Locator, "ApprovedByEmployee__AcctCD");
                    ApprovedByEmployee__AcctCD.DataField = "ApprovedByEmployee__AcctCD";
                    ApprovedByEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t10_gridApproval_ei", "Approved By", grid.Locator, "ApprovedByEmployee__AcctName");
                    ApprovedByEmployee__AcctName.DataField = "ApprovedByEmployee__AcctName";
                    ApproveDate = new DateSelector("_ctl00_phG_tab_t10_gridApproval_lv0_ed7", "Approval Date", grid.Locator, "ApproveDate");
                    ApproveDate.DataField = "ApproveDate";
                    Status = new DropDown("_ctl00_phG_tab_t10_gridApproval_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("P", "Pending");
                    Status.Items.Add("A", "Approved");
                    Status.Items.Add("R", "Rejected");
                    Reason = new PXTextEdit("ctl00_phG_tab_t10_gridApproval_ei", "Reason", grid.Locator, "Reason");
                    Reason.DataField = "Reason";
                    AssignmentMapID = new Selector("_ctl00_phG_tab_t10_gridApproval_lv0_es", "Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    RuleID = new Selector("_ctl00_phG_tab_t10_gridApproval_lv0_es", "Map Rule", grid.Locator, "RuleID");
                    RuleID.DataField = "RuleID";
                    StepID = new Selector("_ctl00_phG_tab_t10_gridApproval_lv0_es", "Map Step", grid.Locator, "StepID");
                    StepID.DataField = "StepID";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t10_gridApproval_lv0_ed13", "Assignment Date", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    ApprovalID = new PXNumberEdit("ctl00_phG_tab_t10_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
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
                Es = new Selector("ctl00_phG_tab_t10_gridApproval_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t10_gridApproval_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t10_gridApproval_lv0_ec", "Ec", locator, null);
                DataMemberName = "Approval";
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_formDiscountDetail");
                DataMemberName = "DiscountDetails";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_formDiscountDetail_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_formDiscountDetail_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t6_formDiscountDetail");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t6_formDiscountDetail");
                    DiscountSequenceIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox SkipDiscount { get; }
			public PXTextEdit LineNbr { get; }
			public Selector DiscountID { get; }
			public Selector DiscountSequenceID { get; }
			public DropDown Type { get; }
			public CheckBox IsManual { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public PXNumberEdit DiscountableQty { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public PXNumberEdit DiscountPct { get; }
			public Selector FreeItemID { get; }
			public PXNumberEdit FreeItemQty { get; }
			public PXTextEdit ExtDiscCode { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit RecordID { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
                
                public c_grid_row(c_discountdetails_formdiscountdetail grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBox("_ctl00_phG_tab_t6_formDiscountDetail_lv0_chkSkipDiscount", "Skip Discount", grid.Locator, "SkipDiscount");
                    SkipDiscount.DataField = "SkipDiscount";
                    LineNbr = new PXTextEdit("ctl00_phG_tab_t6_formDiscountDetail", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    DiscountID = new Selector("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountID", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new Selector("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountSequenceID", "Sequence ID", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    Type = new DropDown("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edType", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("L", "Line");
                    Type.Items.Add("G", "Group");
                    Type.Items.Add("D", "Document");
                    Type.Items.Add("B", "External Document");
                    IsManual = new CheckBox("_ctl00_phG_tab_t6_formDiscountDetail_lv0_chkIsManual", "Manual Discount", grid.Locator, "IsManual");
                    IsManual.DataField = "IsManual";
                    CuryDiscountableAmt = new PXNumberEdit("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edCuryDiscountableAmt", "Discountable Amt.", grid.Locator, "CuryDiscountableAmt");
                    CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                    DiscountableQty = new PXNumberEdit("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountableQty", "Discountable Qty.", grid.Locator, "DiscountableQty");
                    DiscountableQty.DataField = "DiscountableQty";
                    CuryDiscountAmt = new PXNumberEdit("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edCuryDiscountAmt", "Discount Amt.", grid.Locator, "CuryDiscountAmt");
                    CuryDiscountAmt.DataField = "CuryDiscountAmt";
                    DiscountPct = new PXNumberEdit("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountPct", "Discount Percent", grid.Locator, "DiscountPct");
                    DiscountPct.DataField = "DiscountPct";
                    FreeItemID = new Selector("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edFreeItemID", "Free Item", grid.Locator, "FreeItemID");
                    FreeItemID.DataField = "FreeItemID";
                    FreeItemQty = new PXNumberEdit("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edFreeItemQty", "Free Item Qty.", grid.Locator, "FreeItemQty");
                    FreeItemQty.DataField = "FreeItemQty";
                    ExtDiscCode = new PXTextEdit("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edExtDiscCode", "External Discount Code", grid.Locator, "ExtDiscCode");
                    ExtDiscCode.DataField = "ExtDiscCode";
                    Description = new PXTextEdit("_ctl00_phG_tab_t6_formDiscountDetail_lv0_edDescription", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t6_formDiscountDetail_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                    OrderType = new PXTextEdit("ctl00_phG_tab_t6_formDiscountDetail_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_tab_t6_formDiscountDetail_em", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter SkipDiscount { get; }
				public PXTextEditColumnFilter LineNbr { get; }
				public SelectorColumnFilter DiscountID { get; }
				public SelectorColumnFilter DiscountSequenceID { get; }
				public DropDownColumnFilter Type { get; }
				public CheckBoxColumnFilter IsManual { get; }
				public PXNumberEditColumnFilter CuryDiscountableAmt { get; }
				public PXNumberEditColumnFilter DiscountableQty { get; }
				public PXNumberEditColumnFilter CuryDiscountAmt { get; }
				public PXNumberEditColumnFilter DiscountPct { get; }
				public SelectorColumnFilter FreeItemID { get; }
				public PXNumberEditColumnFilter FreeItemQty { get; }
				public PXTextEditColumnFilter ExtDiscCode { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXNumberEditColumnFilter RecordID { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
                
                public c_grid_header(c_discountdetails_formdiscountdetail grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBoxColumnFilter(grid.Row.SkipDiscount);
                    LineNbr = new PXTextEditColumnFilter(grid.Row.LineNbr);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new SelectorColumnFilter(grid.Row.DiscountSequenceID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    IsManual = new CheckBoxColumnFilter(grid.Row.IsManual);
                    CuryDiscountableAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountableAmt);
                    DiscountableQty = new PXNumberEditColumnFilter(grid.Row.DiscountableQty);
                    CuryDiscountAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountAmt);
                    DiscountPct = new PXNumberEditColumnFilter(grid.Row.DiscountPct);
                    FreeItemID = new SelectorColumnFilter(grid.Row.FreeItemID);
                    FreeItemQty = new PXNumberEditColumnFilter(grid.Row.FreeItemQty);
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
			public Selector DiscountSequenceID { get; }
			public Label DiscountSequenceIDLabel { get; }
			public DropDown Type { get; }
			public Label TypeLabel { get; }
			public CheckBox IsManual { get; }
			public Label IsManualLabel { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public Label CuryDiscountableAmtLabel { get; }
			public PXNumberEdit DiscountableQty { get; }
			public Label DiscountableQtyLabel { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public Label CuryDiscountAmtLabel { get; }
			public PXNumberEdit DiscountPct { get; }
			public Label DiscountPctLabel { get; }
			public Selector FreeItemID { get; }
			public Label FreeItemIDLabel { get; }
			public PXNumberEdit FreeItemQty { get; }
			public Label FreeItemQtyLabel { get; }
			public PXTextEdit ExtDiscCode { get; }
			public Label ExtDiscCodeLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_discountdetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SkipDiscount = new CheckBox("ctl00_phG_tab_t6_formDiscountDetail_lv0_chkSkipDiscount", "Skip Discount", locator, null);
                SkipDiscountLabel = new Label(SkipDiscount);
                SkipDiscount.DataField = "SkipDiscount";
                DiscountID = new Selector("ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountID", "Discount Code", locator, null);
                DiscountIDLabel = new Label(DiscountID);
                DiscountID.DataField = "DiscountID";
                DiscountSequenceID = new Selector("ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountSequenceID", "Sequence ID", locator, null);
                DiscountSequenceIDLabel = new Label(DiscountSequenceID);
                DiscountSequenceID.DataField = "DiscountSequenceID";
                Type = new DropDown("ctl00_phG_tab_t6_formDiscountDetail_lv0_edType", "Type", locator, null);
                TypeLabel = new Label(Type);
                Type.DataField = "Type";
                Type.Items.Add("L", "Line");
                Type.Items.Add("G", "Group");
                Type.Items.Add("D", "Document");
                Type.Items.Add("B", "External Document");
                IsManual = new CheckBox("ctl00_phG_tab_t6_formDiscountDetail_lv0_chkIsManual", "Manual Discount", locator, null);
                IsManualLabel = new Label(IsManual);
                IsManual.DataField = "IsManual";
                CuryDiscountableAmt = new PXNumberEdit("ctl00_phG_tab_t6_formDiscountDetail_lv0_edCuryDiscountableAmt", "Discountable Amt.", locator, null);
                CuryDiscountableAmtLabel = new Label(CuryDiscountableAmt);
                CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                DiscountableQty = new PXNumberEdit("ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountableQty", "Discountable Qty.", locator, null);
                DiscountableQtyLabel = new Label(DiscountableQty);
                DiscountableQty.DataField = "DiscountableQty";
                CuryDiscountAmt = new PXNumberEdit("ctl00_phG_tab_t6_formDiscountDetail_lv0_edCuryDiscountAmt", "Discount Amt.", locator, null);
                CuryDiscountAmtLabel = new Label(CuryDiscountAmt);
                CuryDiscountAmt.DataField = "CuryDiscountAmt";
                DiscountPct = new PXNumberEdit("ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountPct", "Discount Percent", locator, null);
                DiscountPctLabel = new Label(DiscountPct);
                DiscountPct.DataField = "DiscountPct";
                FreeItemID = new Selector("ctl00_phG_tab_t6_formDiscountDetail_lv0_edFreeItemID", "Free Item", locator, null);
                FreeItemIDLabel = new Label(FreeItemID);
                FreeItemID.DataField = "FreeItemID";
                FreeItemQty = new PXNumberEdit("ctl00_phG_tab_t6_formDiscountDetail_lv0_edFreeItemQty", "Free Item Qty.", locator, null);
                FreeItemQtyLabel = new Label(FreeItemQty);
                FreeItemQty.DataField = "FreeItemQty";
                ExtDiscCode = new PXTextEdit("ctl00_phG_tab_t6_formDiscountDetail_lv0_edExtDiscCode", "External Discount Code", locator, null);
                ExtDiscCodeLabel = new Label(ExtDiscCode);
                ExtDiscCode.DataField = "ExtDiscCode";
                Description = new PXTextEdit("ctl00_phG_tab_t6_formDiscountDetail_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                Es = new Selector("ctl00_phG_tab_t6_formDiscountDetail_lv0_es", "Es", locator, null);
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
            
            public virtual void FreeItemIDEdit()
            {
                Buttons.FreeItemIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
			public Button FreeItemIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t6_formDiscountDetail_lv0");
                    DiscountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDiscountDetail_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t6_formDiscountDetail_lv0");
                    DiscountSequenceIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    FreeItemIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_formDiscountDetail_lv0_edFreeItemID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "FreeItemIDEdit", "ctl00_phG_tab_t6_formDiscountDetail_lv0");
                    FreeItemIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_splits_grid2 : Grid<c_splits_grid2.c_grid_row, c_splits_grid2.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_splits_grid2(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelLS_grid2");
                DataMemberName = "splits";
                Buttons = new PxButtonCollection();
                PredefinedFilter = new DropDown("ctl00_phG_PanelLS_grid2_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                PredefinedFilter.Items.Add("00000172-0000-0000-0000-000000000000", "Active");
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
			public ToolBarButtonGrid Filter { get; }
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
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
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
                
			public PXNumberEdit SplitLineNbr { get; }
			public PXNumberEdit ParentSplitLineNbr { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public DateSelector ShipDate { get; }
			public CheckBox IsAllocated { get; }
			public Selector SiteID { get; }
			public CheckBox Completed { get; }
			public Selector LocationID { get; }
			public Selector LotSerialNbr { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit ShippedQty { get; }
			public PXNumberEdit ReceivedQty { get; }
			public Selector UOM { get; }
			public DateSelector ExpireDate { get; }
			public CheckBox POCreate { get; }
			public PXTextEdit RefNoteID { get; }
			public Selector OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_splits_grid2 grid) : 
                        base(grid)
                {
                    SplitLineNbr = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "Allocation ID", grid.Locator, "SplitLineNbr");
                    SplitLineNbr.DataField = "SplitLineNbr";
                    ParentSplitLineNbr = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "Parent Allocation ID", grid.Locator, "ParentSplitLineNbr");
                    ParentSplitLineNbr.DataField = "ParentSplitLineNbr";
                    InventoryID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edSubItemID2", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    ShipDate = new DateSelector("_ctl00_phG_PanelLS_grid2_lv0_ed4", "Ship On", grid.Locator, "ShipDate");
                    ShipDate.DataField = "ShipDate";
                    IsAllocated = new CheckBox("ctl00_phG_PanelLS_grid2_ef", "Allocated", grid.Locator, "IsAllocated");
                    IsAllocated.DataField = "IsAllocated";
                    SiteID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edSiteID2", "Alloc. Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    Completed = new CheckBox("ctl00_phG_PanelLS_grid2", "Completed", grid.Locator, "Completed");
                    Completed.DataField = "Completed";
                    LocationID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edLocationID2", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    LotSerialNbr = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edLotSerialNbr2", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    Qty = new PXNumberEdit("_ctl00_phG_PanelLS_grid2_lv0_edQty2", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    ShippedQty = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "Qty. On Shipments", grid.Locator, "ShippedQty");
                    ShippedQty.DataField = "ShippedQty";
                    ReceivedQty = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "Qty. Received", grid.Locator, "ReceivedQty");
                    ReceivedQty.DataField = "ReceivedQty";
                    UOM = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edUOM2", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    ExpireDate = new DateSelector("_ctl00_phG_PanelLS_grid2_lv0_edExpireDate2", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    POCreate = new CheckBox("ctl00_phG_PanelLS_grid2", "Mark for PO", grid.Locator, "POCreate");
                    POCreate.DataField = "POCreate";
                    RefNoteID = new PXTextEdit("ctl00_phG_PanelLS_grid2", "Related Document", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                    OrderType = new Selector("_ctl00_phG_PanelLS_grid2_lv0_es", "OrderType", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_PanelLS_grid2_ei", "OrderNbr", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXNumberEditColumnFilter SplitLineNbr { get; }
				public PXNumberEditColumnFilter ParentSplitLineNbr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public DateSelectorColumnFilter ShipDate { get; }
				public CheckBoxColumnFilter IsAllocated { get; }
				public SelectorColumnFilter SiteID { get; }
				public CheckBoxColumnFilter Completed { get; }
				public SelectorColumnFilter LocationID { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter ShippedQty { get; }
				public PXNumberEditColumnFilter ReceivedQty { get; }
				public SelectorColumnFilter UOM { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public CheckBoxColumnFilter POCreate { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
				public SelectorColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_splits_grid2 grid) : 
                        base(grid)
                {
                    SplitLineNbr = new PXNumberEditColumnFilter(grid.Row.SplitLineNbr);
                    ParentSplitLineNbr = new PXNumberEditColumnFilter(grid.Row.ParentSplitLineNbr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    ShipDate = new DateSelectorColumnFilter(grid.Row.ShipDate);
                    IsAllocated = new CheckBoxColumnFilter(grid.Row.IsAllocated);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    Completed = new CheckBoxColumnFilter(grid.Row.Completed);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    ShippedQty = new PXNumberEditColumnFilter(grid.Row.ShippedQty);
                    ReceivedQty = new PXNumberEditColumnFilter(grid.Row.ReceivedQty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    POCreate = new CheckBoxColumnFilter(grid.Row.POCreate);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_splits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
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
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_splits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SubItemID = new Selector("ctl00_phG_PanelLS_grid2_lv0_edSubItemID2", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                SiteID = new Selector("ctl00_phG_PanelLS_grid2_lv0_edSiteID2", "Alloc. Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
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
                Ed = new DateSelector("ctl00_phG_PanelLS_grid2_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
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
        
        public class c_soparamfilter_formcreateshipment : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector ShipDate { get; }
			public Label ShipDateLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
            
            public c_soparamfilter_formcreateshipment(string locator, string name) : 
                    base(locator, name)
            {
                ShipDate = new DateSelector("ctl00_phG_pnlCreateShipment_formCreateShipment_edShipDate", "Shipment Date", locator, null);
                ShipDateLabel = new Label(ShipDate);
                ShipDate.DataField = "ShipDate";
                SiteID = new Selector("ctl00_phG_pnlCreateShipment_formCreateShipment_edSiteID", "Warehouse ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                DataMemberName = "soparamfilter";
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
                    Ok = new Button("ctl00_phG_pnlCreateShipment_btnOK", "OK", "ctl00_phG_pnlCreateShipment_formCreateShipment");
                }
            }
        }
        
        public class c_addinvoicefilter_form4 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown DocType { get; }
			public Label DocTypeLabel { get; }
			public Selector RefNbr { get; }
			public Label RefNbrLabel { get; }
			public CheckBox Expand { get; }
			public Label ExpandLabel { get; }
            
            public c_addinvoicefilter_form4(string locator, string name) : 
                    base(locator, name)
            {
                DocType = new DropDown("ctl00_phDS_PanelAddInvoice_form4_edDocType", "Doc Type", locator, null);
                DocTypeLabel = new Label(DocType);
                DocType.DataField = "DocType";
                RefNbr = new Selector("ctl00_phDS_PanelAddInvoice_form4_edRefNbr4", "Ref Nbr", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Expand = new CheckBox("ctl00_phDS_PanelAddInvoice_form4_chkExpand", "Expand", locator, null);
                ExpandLabel = new Label(Expand);
                Expand.DataField = "Expand";
                DataMemberName = "addinvoicefilter";
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
                    Add = new Button("ctl00_phDS_PanelAddInvoice_PXButton1", "Add", "ctl00_phDS_PanelAddInvoice_form4");
                    AddClose = new Button("ctl00_phDS_PanelAddInvoice_PXButton2", "Add & Close", "ctl00_phDS_PanelAddInvoice_form4");
                    Cancel = new Button("ctl00_phDS_PanelAddInvoice_PXButton3", "Cancel", "ctl00_phDS_PanelAddInvoice_form4");
                }
            }
        }
        
        public class c_copyparamfilter_formcopyto : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public PXTextEdit OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public CheckBox RecalcUnitPrices { get; }
			public Label RecalcUnitPricesLabel { get; }
			public CheckBox OverrideManualPrices { get; }
			public Label OverrideManualPricesLabel { get; }
			public CheckBox RecalcDiscounts { get; }
			public Label RecalcDiscountsLabel { get; }
			public CheckBox OverrideManualDiscounts { get; }
			public Label OverrideManualDiscountsLabel { get; }
			public CheckBox AMIncludeEstimate { get; }
			public Label AMIncludeEstimateLabel { get; }
			public CheckBox CopyConfigurations { get; }
			public Label CopyConfigurationsLabel { get; }
            
            public c_copyparamfilter_formcopyto(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new Selector("ctl00_phG_panelCopyTo_formCopyTo_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new PXTextEdit("ctl00_phG_panelCopyTo_formCopyTo_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                RecalcUnitPrices = new CheckBox("ctl00_phG_panelCopyTo_formCopyTo_chkRecalcUnitPrices", "Recalc Unit Prices", locator, null);
                RecalcUnitPricesLabel = new Label(RecalcUnitPrices);
                RecalcUnitPrices.DataField = "RecalcUnitPrices";
                OverrideManualPrices = new CheckBox("ctl00_phG_panelCopyTo_formCopyTo_chkOverrideManualPrices", "Override Manual Prices", locator, null);
                OverrideManualPricesLabel = new Label(OverrideManualPrices);
                OverrideManualPrices.DataField = "OverrideManualPrices";
                RecalcDiscounts = new CheckBox("ctl00_phG_panelCopyTo_formCopyTo_chkRecalcDiscounts", "Recalc Discounts", locator, null);
                RecalcDiscountsLabel = new Label(RecalcDiscounts);
                RecalcDiscounts.DataField = "RecalcDiscounts";
                OverrideManualDiscounts = new CheckBox("ctl00_phG_panelCopyTo_formCopyTo_chkOverrideManualDiscounts", "Override Manual Discounts", locator, null);
                OverrideManualDiscountsLabel = new Label(OverrideManualDiscounts);
                OverrideManualDiscounts.DataField = "OverrideManualDiscounts";
                AMIncludeEstimate = new CheckBox("ctl00_phG_panelCopyTo_formCopyTo_edAMIncludeEstimate", "AM Include Estimate", locator, null);
                AMIncludeEstimateLabel = new Label(AMIncludeEstimate);
                AMIncludeEstimate.DataField = "AMIncludeEstimate";
                CopyConfigurations = new CheckBox("ctl00_phG_panelCopyTo_formCopyTo_chkCopyConfigurations", "Copy Configurations", locator, null);
                CopyConfigurationsLabel = new Label(CopyConfigurations);
                CopyConfigurations.DataField = "CopyConfigurations";
                DataMemberName = "copyparamfilter";
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
                    Ok = new Button("ctl00_phG_panelCopyTo_PXButton9", "OK", "ctl00_phG_panelCopyTo_formCopyTo");
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
        
        public class c_invoicesplits_grid4 : Grid<c_invoicesplits_grid4.c_grid_row, c_invoicesplits_grid4.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_invoicesplits_grid4(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phDS_PanelAddInvoice_grid4");
                DataMemberName = "invoicesplits";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phDS_PanelAddInvoice_grid4_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phDS_PanelAddInvoice_grid4_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phDS_PanelAddInvoice_PXButton1", "Add", "ctl00_phDS_PanelAddInvoice_grid4");
                    AddClose = new Button("ctl00_phDS_PanelAddInvoice_PXButton2", "Add & Close", "ctl00_phDS_PanelAddInvoice_grid4");
                    Cancel = new Button("ctl00_phDS_PanelAddInvoice_PXButton3", "Cancel", "ctl00_phDS_PanelAddInvoice_grid4");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public Selector LocationID { get; }
			public PXTextEdit LotSerialNbr { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public PXTextEdit TranDesc { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit TranTypeARTran { get; }
			public PXTextEdit RefNbrARTran { get; }
			public PXNumberEdit LineNbrARTran { get; }
                
                public c_grid_row(c_invoicesplits_grid4 grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phDS_PanelAddInvoice_grid4_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    InventoryID = new Selector("_ctl00_phDS_PanelAddInvoice_grid4_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phDS_PanelAddInvoice_grid4_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phDS_PanelAddInvoice_grid4_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new Selector("_ctl00_phDS_PanelAddInvoice_grid4_lv0_es", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    LotSerialNbr = new PXTextEdit("ctl00_phDS_PanelAddInvoice_grid4_ei", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    UOM = new Selector("_ctl00_phDS_PanelAddInvoice_grid4_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("ctl00_phDS_PanelAddInvoice_grid4_en", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    TranDesc = new PXTextEdit("ctl00_phDS_PanelAddInvoice_grid4_ei", "Line Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    LineNbr = new PXNumberEdit("ctl00_phDS_PanelAddInvoice_grid4_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    TranTypeARTran = new PXTextEdit("ctl00_phDS_PanelAddInvoice_grid4_ei", "Tran. Type", grid.Locator, "TranTypeARTran");
                    TranTypeARTran.DataField = "TranTypeARTran";
                    RefNbrARTran = new PXTextEdit("ctl00_phDS_PanelAddInvoice_grid4_ei", "Reference Nbr.", grid.Locator, "RefNbrARTran");
                    RefNbrARTran.DataField = "RefNbrARTran";
                    LineNbrARTran = new PXNumberEdit("ctl00_phDS_PanelAddInvoice_grid4_en", "Line Nbr.", grid.Locator, "LineNbrARTran");
                    LineNbrARTran.DataField = "LineNbrARTran";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXTextEditColumnFilter LotSerialNbr { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter TranTypeARTran { get; }
				public PXTextEditColumnFilter RefNbrARTran { get; }
				public PXNumberEditColumnFilter LineNbrARTran { get; }
                
                public c_grid_header(c_invoicesplits_grid4 grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    LotSerialNbr = new PXTextEditColumnFilter(grid.Row.LotSerialNbr);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    TranTypeARTran = new PXTextEditColumnFilter(grid.Row.TranTypeARTran);
                    RefNbrARTran = new PXTextEditColumnFilter(grid.Row.RefNbrARTran);
                    LineNbrARTran = new PXNumberEditColumnFilter(grid.Row.LineNbrARTran);
                }
            }
        }
        
        public class c_invoicesplits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_invoicesplits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phDS_PanelAddInvoice_grid4_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phDS_PanelAddInvoice_grid4_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "invoicesplits";
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
                    Add = new Button("ctl00_phDS_PanelAddInvoice_PXButton1", "Add", "ctl00_phDS_PanelAddInvoice_grid4_lv0");
                    AddClose = new Button("ctl00_phDS_PanelAddInvoice_PXButton2", "Add & Close", "ctl00_phDS_PanelAddInvoice_grid4_lv0");
                    Cancel = new Button("ctl00_phDS_PanelAddInvoice_PXButton3", "Cancel", "ctl00_phDS_PanelAddInvoice_grid4_lv0");
                }
            }
        }
        
        public class c_posupply_gridposupply : Grid<c_posupply_gridposupply.c_grid_row, c_posupply_gridposupply.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_posupply_gridposupply(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "posupply";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelPOSupply_gridPOSupply_fe_gf", "FilterForm");
            }
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
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
                
			public Button OrderNbrEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_PanelPOSupply_gridPOSupply_lv0_edOrderNbr\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "OrderNbrEdit", "ctl00_phG_PanelPOSupply_gridPOSupply");
                    OrderNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfFirst0", "First", "ctl00_phG_PanelPOSupply_gridPOSupply");
                    Prev = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfPrev0", "Prev", "ctl00_phG_PanelPOSupply_gridPOSupply");
                    Next = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfNext0", "Next", "ctl00_phG_PanelPOSupply_gridPOSupply");
                    Last = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfLast0", "Last", "ctl00_phG_PanelPOSupply_gridPOSupply");
                    Save = new Button("ctl00_phG_PanelPOSupply_PXButton7", "Save", "ctl00_phG_PanelPOSupply_gridPOSupply");
                    Cancel = new Button("ctl00_phG_PanelPOSupply_PXButton8", "Cancel", "ctl00_phG_PanelPOSupply_gridPOSupply");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public DropDown OrderType { get; }
			public Selector OrderNbr { get; }
			public PXTextEdit VendorRefNbr { get; }
			public DropDown LineType { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector VendorID { get; }
			public PXTextEdit VendorID_Vendor_AcctName { get; }
			public DateSelector PromisedDate { get; }
			public PXTextEdit UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit OpenQty { get; }
			public PXTextEdit TranDesc { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_posupply_gridposupply grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelPOSupply_gridPOSupply_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderType = new DropDown("_ctl00_phG_PanelPOSupply_gridPOSupply_lv0_ec", "PO Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderType.Items.Add("RO", "Normal");
                    OrderType.Items.Add("DP", "Drop Ship");
                    OrderType.Items.Add("BL", "Blanket");
                    OrderType.Items.Add("SB", "Standard");
                    OrderNbr = new Selector("_ctl00_phG_PanelPOSupply_gridPOSupply_lv0_edOrderNbr", "PO Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    VendorRefNbr = new PXTextEdit("ctl00_phG_PanelPOSupply_gridPOSupply_ei", "Vendor Ref.", grid.Locator, "VendorRefNbr");
                    VendorRefNbr.DataField = "VendorRefNbr";
                    LineType = new DropDown("_ctl00_phG_PanelPOSupply_gridPOSupply_lv0_ec", "Line Type", grid.Locator, "LineType");
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
                    InventoryID = new Selector("_ctl00_phG_PanelPOSupply_gridPOSupply_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelPOSupply_gridPOSupply_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    VendorID = new Selector("_ctl00_phG_PanelPOSupply_gridPOSupply_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorID_Vendor_AcctName = new PXTextEdit("ctl00_phG_PanelPOSupply_gridPOSupply_ei", "Vendor Name", grid.Locator, "VendorID_Vendor_AcctName");
                    VendorID_Vendor_AcctName.DataField = "VendorID_Vendor_AcctName";
                    PromisedDate = new DateSelector("_ctl00_phG_PanelPOSupply_gridPOSupply_lv0_ed9", "Promised", grid.Locator, "PromisedDate");
                    PromisedDate.DataField = "PromisedDate";
                    UOM = new PXTextEdit("ctl00_phG_PanelPOSupply_gridPOSupply_em", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrderQty = new PXNumberEdit("ctl00_phG_PanelPOSupply_gridPOSupply_en", "Order Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    OpenQty = new PXNumberEdit("ctl00_phG_PanelPOSupply_gridPOSupply_en", "Open Qty.", grid.Locator, "OpenQty");
                    OpenQty.DataField = "OpenQty";
                    TranDesc = new PXTextEdit("ctl00_phG_PanelPOSupply_gridPOSupply_ei", "Line Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelPOSupply_gridPOSupply_en", "PO Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public PXTextEditColumnFilter VendorRefNbr { get; }
				public DropDownColumnFilter LineType { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorID_Vendor_AcctName { get; }
				public DateSelectorColumnFilter PromisedDate { get; }
				public PXTextEditColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter OpenQty { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_posupply_gridposupply grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderType = new DropDownColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    VendorRefNbr = new PXTextEditColumnFilter(grid.Row.VendorRefNbr);
                    LineType = new DropDownColumnFilter(grid.Row.LineType);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    VendorID_Vendor_AcctName = new PXTextEditColumnFilter(grid.Row.VendorID_Vendor_AcctName);
                    PromisedDate = new DateSelectorColumnFilter(grid.Row.PromisedDate);
                    UOM = new PXTextEditColumnFilter(grid.Row.UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    OpenQty = new PXNumberEditColumnFilter(grid.Row.OpenQty);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_posupply_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_posupply_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrderNbr = new Selector("ctl00_phG_PanelPOSupply_gridPOSupply_lv0_edOrderNbr", "PO Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                Es = new Selector("ctl00_phG_PanelPOSupply_gridPOSupply_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelPOSupply_gridPOSupply_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelPOSupply_gridPOSupply_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PanelPOSupply_gridPOSupply_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "posupply";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
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
                
			public Button OrderNbrEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_PanelPOSupply_gridPOSupply_lv0_edOrderNbr\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "OrderNbrEdit", "ctl00_phG_PanelPOSupply_gridPOSupply_lv0");
                    OrderNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfFirst0", "First", "ctl00_phG_PanelPOSupply_gridPOSupply_lv0");
                    Prev = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfPrev0", "Prev", "ctl00_phG_PanelPOSupply_gridPOSupply_lv0");
                    Next = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfNext0", "Next", "ctl00_phG_PanelPOSupply_gridPOSupply_lv0");
                    Last = new Button("ctl00_phG_PanelPOSupply_gridPOSupply_lfLast0", "Last", "ctl00_phG_PanelPOSupply_gridPOSupply_lv0");
                    Save = new Button("ctl00_phG_PanelPOSupply_PXButton7", "Save", "ctl00_phG_PanelPOSupply_gridPOSupply_lv0");
                    Cancel = new Button("ctl00_phG_PanelPOSupply_PXButton8", "Cancel", "ctl00_phG_PanelPOSupply_gridPOSupply_lv0");
                }
            }
        }
        
        public class c_salespertran_gridsalespertran : Grid<c_salespertran_gridsalespertran.c_grid_row, c_salespertran_gridsalespertran.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_salespertran_gridsalespertran(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_gridSalesPerTran");
                DataMemberName = "SalesPerTran";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_gridSalesPerTran_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridSalesPerTran_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SalespersonID { get; }
			public PXNumberEdit CommnPct { get; }
			public PXNumberEdit CuryCommnAmt { get; }
			public PXNumberEdit CuryCommnblAmt { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
                
                public c_grid_row(c_salespertran_gridsalespertran grid) : 
                        base(grid)
                {
                    SalespersonID = new Selector("_ctl00_phG_tab_t3_gridSalesPerTran_lv0_edSalesPersonID_1", "Salesperson ID", grid.Locator, "SalespersonID");
                    SalespersonID.DataField = "SalespersonID";
                    CommnPct = new PXNumberEdit("_ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCommnPct", "Commission %", grid.Locator, "CommnPct");
                    CommnPct.DataField = "CommnPct";
                    CuryCommnAmt = new PXNumberEdit("_ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCuryCommnAmt", "Commission Amt.", grid.Locator, "CuryCommnAmt");
                    CuryCommnAmt.DataField = "CuryCommnAmt";
                    CuryCommnblAmt = new PXNumberEdit("_ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCuryCommnblAmt", "Commissionable Amount", grid.Locator, "CuryCommnblAmt");
                    CuryCommnblAmt.DataField = "CuryCommnblAmt";
                    OrderType = new PXTextEdit("ctl00_phG_tab_t3_gridSalesPerTran_ei", "OrderType", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_tab_t3_gridSalesPerTran_ei", "OrderNbr", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SalespersonID { get; }
				public PXNumberEditColumnFilter CommnPct { get; }
				public PXNumberEditColumnFilter CuryCommnAmt { get; }
				public PXNumberEditColumnFilter CuryCommnblAmt { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
                
                public c_grid_header(c_salespertran_gridsalespertran grid) : 
                        base(grid)
                {
                    SalespersonID = new SelectorColumnFilter(grid.Row.SalespersonID);
                    CommnPct = new PXNumberEditColumnFilter(grid.Row.CommnPct);
                    CuryCommnAmt = new PXNumberEditColumnFilter(grid.Row.CuryCommnAmt);
                    CuryCommnblAmt = new PXNumberEditColumnFilter(grid.Row.CuryCommnblAmt);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                }
            }
        }
        
        public class c_salespertran_lv0 : Container
        {
            
			public PXNumberEdit CommnPct { get; }
			public Label CommnPctLabel { get; }
			public PXNumberEdit CommnAmt { get; }
			public Label CommnAmtLabel { get; }
			public PXNumberEdit CuryCommnAmt { get; }
			public Label CuryCommnAmtLabel { get; }
			public PXNumberEdit CommnblAmt { get; }
			public Label CommnblAmtLabel { get; }
			public PXNumberEdit CuryCommnblAmt { get; }
			public Label CuryCommnblAmtLabel { get; }
			public Selector SalespersonID { get; }
			public Label SalespersonIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_salespertran_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CommnPct = new PXNumberEdit("ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCommnPct", "Commission %", locator, null);
                CommnPctLabel = new Label(CommnPct);
                CommnPct.DataField = "CommnPct";
                CommnAmt = new PXNumberEdit("ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCommnAmt", "CommnAmt", locator, null);
                CommnAmtLabel = new Label(CommnAmt);
                CommnAmt.DataField = "CommnAmt";
                CuryCommnAmt = new PXNumberEdit("ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCuryCommnAmt", "Commission Amt.", locator, null);
                CuryCommnAmtLabel = new Label(CuryCommnAmt);
                CuryCommnAmt.DataField = "CuryCommnAmt";
                CommnblAmt = new PXNumberEdit("ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCommnblAmt", "CommnblAmt", locator, null);
                CommnblAmtLabel = new Label(CommnblAmt);
                CommnblAmt.DataField = "CommnblAmt";
                CuryCommnblAmt = new PXNumberEdit("ctl00_phG_tab_t3_gridSalesPerTran_lv0_edCuryCommnblAmt", "Commissionable Amount", locator, null);
                CuryCommnblAmtLabel = new Label(CuryCommnblAmt);
                CuryCommnblAmt.DataField = "CuryCommnblAmt";
                SalespersonID = new Selector("ctl00_phG_tab_t3_gridSalesPerTran_lv0_edSalesPersonID_1", "Salesperson ID", locator, null);
                SalespersonIDLabel = new Label(SalespersonID);
                SalespersonID.DataField = "SalespersonID";
                Es = new Selector("ctl00_phG_tab_t3_gridSalesPerTran_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SalesPerTran";
            }
        }
        
        public class c_packages_gridpackages : Grid<c_packages_gridpackages.c_grid_row, c_packages_gridpackages.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_packages_gridpackages(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelCarrierRates_gridPackages");
                DataMemberName = "Packages";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelCarrierRates_gridPackages_fe_gf", "FilterForm");
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
            
            public virtual void RecalculatePackages()
            {
                ToolBar.RecalculatePackages.Click();
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
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid RecalculatePackages { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    RecalculatePackages = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_at_tlb div[data-cmd=\'RecalculatePac" +
                            "kages\']", "Refresh Packages", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_at_tlb div[data-cmd=\'AdjustColumns\'" +
                            "]", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackages_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackages");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackages");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackages");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackages");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackages");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackages");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackages");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackages");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridPackages");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector BoxID { get; }
			public PXTextEdit Description { get; }
			public Selector SiteID { get; }
			public PXTextEdit WeightUOM { get; }
			public PXNumberEdit Weight { get; }
			public PXNumberEdit BoxWeight { get; }
			public PXNumberEdit GrossWeight { get; }
			public PXNumberEdit DeclaredValue { get; }
			public CheckBox COD { get; }
			public DropDown StampsAddOns { get; }
			public Selector OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_packages_gridpackages grid) : 
                        base(grid)
                {
                    BoxID = new Selector("_ctl00_phG_PanelCarrierRates_gridPackages_lv0_es", "Box ID", grid.Locator, "BoxID");
                    BoxID.DataField = "BoxID";
                    Description = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridPackages_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    SiteID = new Selector("_ctl00_phG_PanelCarrierRates_gridPackages_lv0_es", "Ship From Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    WeightUOM = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridPackages_ei", "Weight UOM", grid.Locator, "WeightUOM");
                    WeightUOM.DataField = "WeightUOM";
                    Weight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackages_en", "Net Weight", grid.Locator, "Weight");
                    Weight.DataField = "Weight";
                    BoxWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackages_en", "Box Weight", grid.Locator, "BoxWeight");
                    BoxWeight.DataField = "BoxWeight";
                    GrossWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackages_en", "Gross Weight", grid.Locator, "GrossWeight");
                    GrossWeight.DataField = "GrossWeight";
                    DeclaredValue = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackages_en", "Declared Value", grid.Locator, "DeclaredValue");
                    DeclaredValue.DataField = "DeclaredValue";
                    COD = new CheckBox("ctl00_phG_PanelCarrierRates_gridPackages_ef", "C.O.D.", grid.Locator, "COD");
                    COD.DataField = "COD";
                    StampsAddOns = new DropDown("_ctl00_phG_PanelCarrierRates_gridPackages_lv0_edStampsAddOns", "Stamps Surcharges", grid.Locator, "StampsAddOns");
                    StampsAddOns.DataField = "StampsAddOns";
                    StampsAddOns.Items.Add("USARD", "USPS Restricted Delivery");
                    StampsAddOns.Items.Add("USAESH", "Priority Mail Express delivery on a Sunday/holiday");
                    StampsAddOns.Items.Add("USANDW", "Priority Mail Express no delivery on Saturday");
                    StampsAddOns.Items.Add("USANND", "USPS notice of non-delivery");
                    StampsAddOns.Items.Add("USALAWS", "Mailable Live Animals with charge");
                    StampsAddOns.Items.Add("USASH", "Fragile items");
                    StampsAddOns.Items.Add("USA1030", "Deliver by 10:30 AM");
                    StampsAddOns.Items.Add("SCAHP", "Hidden Postage");
                    OrderType = new Selector("_ctl00_phG_PanelCarrierRates_gridPackages_lv0_es", "OrderType", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridPackages_ei", "OrderNbr", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackages_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter BoxID { get; }
				public PXTextEditColumnFilter Description { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter WeightUOM { get; }
				public PXNumberEditColumnFilter Weight { get; }
				public PXNumberEditColumnFilter BoxWeight { get; }
				public PXNumberEditColumnFilter GrossWeight { get; }
				public PXNumberEditColumnFilter DeclaredValue { get; }
				public CheckBoxColumnFilter COD { get; }
				public DropDownColumnFilter StampsAddOns { get; }
				public SelectorColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_packages_gridpackages grid) : 
                        base(grid)
                {
                    BoxID = new SelectorColumnFilter(grid.Row.BoxID);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    WeightUOM = new PXTextEditColumnFilter(grid.Row.WeightUOM);
                    Weight = new PXNumberEditColumnFilter(grid.Row.Weight);
                    BoxWeight = new PXNumberEditColumnFilter(grid.Row.BoxWeight);
                    GrossWeight = new PXNumberEditColumnFilter(grid.Row.GrossWeight);
                    DeclaredValue = new PXNumberEditColumnFilter(grid.Row.DeclaredValue);
                    COD = new CheckBoxColumnFilter(grid.Row.COD);
                    StampsAddOns = new DropDownColumnFilter(grid.Row.StampsAddOns);
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_packages_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown StampsAddOns { get; }
			public Label StampsAddOnsLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_packages_lv0(string locator, string name) : 
                    base(locator, name)
            {
                StampsAddOns = new DropDown("ctl00_phG_PanelCarrierRates_gridPackages_lv0_edStampsAddOns", "Stamps Surcharges", locator, null);
                StampsAddOnsLabel = new Label(StampsAddOns);
                StampsAddOns.DataField = "StampsAddOns";
                StampsAddOns.Items.Add("USARD", "USPS Restricted Delivery");
                StampsAddOns.Items.Add("USAESH", "Priority Mail Express delivery on a Sunday/holiday");
                StampsAddOns.Items.Add("USANDW", "Priority Mail Express no delivery on Saturday");
                StampsAddOns.Items.Add("USANND", "USPS notice of non-delivery");
                StampsAddOns.Items.Add("USALAWS", "Mailable Live Animals with charge");
                StampsAddOns.Items.Add("USASH", "Fragile items");
                StampsAddOns.Items.Add("USA1030", "Deliver by 10:30 AM");
                StampsAddOns.Items.Add("SCAHP", "Hidden Postage");
                Es = new Selector("ctl00_phG_PanelCarrierRates_gridPackages_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Packages";
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridPackages_lv0");
                }
            }
        }
        
        public class c_adjustments_detgrid : Grid<c_adjustments_detgrid.c_grid_row, c_adjustments_detgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_adjustments_detgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_detgrid");
                DataMemberName = "Adjustments";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t8_detgrid_fe_gf", "FilterForm");
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
            
            public virtual void CreateDocumentPayment()
            {
                ToolBar.CreateDocumentPayment.Click();
            }
            
            public virtual void CreateOrderPrepayment()
            {
                ToolBar.CreateOrderPrepayment.Click();
            }
            
            public virtual void CaptureDocumentPayment()
            {
                ToolBar.CaptureDocumentPayment.Click();
            }
            
            public virtual void VoidDocumentPayment()
            {
                ToolBar.VoidDocumentPayment.Click();
            }
            
            public virtual void ImportDocumentPayment()
            {
                ToolBar.ImportDocumentPayment.Click();
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
            
            public virtual void ARPayment__RefNbrEdit()
            {
                Buttons.ARPayment__RefNbrEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid CreateDocumentPayment { get; }
			public ToolBarButtonGrid CreateOrderPrepayment { get; }
			public ToolBarButtonGrid CaptureDocumentPayment { get; }
			public ToolBarButtonGrid VoidDocumentPayment { get; }
			public ToolBarButtonGrid ImportDocumentPayment { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    CreateDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'CreateDocumentPayment\']", "Create Payment", locator, null);
                    CreateOrderPrepayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'CreateOrderPrepayment\']", "Create Prepayment", locator, null);
                    CaptureDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'CaptureDocumentPayment\']", "Capture CC Payment", locator, null);
                    VoidDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'VoidDocumentPayment\']", "Void CC Payment", locator, null);
                    ImportDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'ImportDocumentPayment\']", "Import CC Payment", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_detgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ARPayment__RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ARPayment__RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_detgrid_lv0_edARPayment__RefNbr\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "ARPayment__RefNbrEdit", "ctl00_phG_tab_t8_detgrid");
                    ARPayment__RefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public DropDown AdjgDocType { get; }
			public Selector AdjgRefNbr { get; }
			public PXNumberEdit CuryAdjdAmt { get; }
			public PXNumberEdit CuryAdjdBilledAmt { get; }
			public PXNumberEdit CuryDocBal { get; }
			public DropDown ARPayment__Status { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Selector PaymentMethodID { get; }
			public Selector CashAccountID { get; }
			public PXNumberEdit CuryOrigDocAmt { get; }
			public Selector ARPayment__CuryID { get; }
			public DropDown ExternalTransaction__ProcStatus { get; }
			public CheckBox CanVoid { get; }
			public CheckBox CanCapture { get; }
			public PXNumberEdit RecordID { get; }
			public PXTextEdit AdjdOrderType { get; }
			public PXTextEdit AdjdOrderNbr { get; }
                
                public c_grid_row(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    AdjgDocType = new DropDown("_ctl00_phG_tab_t8_detgrid_lv0_edAdjgDocType", "Doc. Type", grid.Locator, "AdjgDocType");
                    AdjgDocType.DataField = "AdjgDocType";
                    AdjgDocType.Items.Add("PMT", "Payment");
                    AdjgDocType.Items.Add("CRM", "Credit Memo");
                    AdjgDocType.Items.Add("PPM", "Prepayment");
                    AdjgRefNbr = new Selector("_ctl00_phG_tab_t8_detgrid_lv0_edAdjgRefNbr", "Reference Nbr.", grid.Locator, "AdjgRefNbr");
                    AdjgRefNbr.DataField = "AdjgRefNbr";
                    CuryAdjdAmt = new PXNumberEdit("_ctl00_phG_tab_t8_detgrid_lv0_edCuryAdjdAmt", "Applied To Order", grid.Locator, "CuryAdjdAmt");
                    CuryAdjdAmt.DataField = "CuryAdjdAmt";
                    CuryAdjdBilledAmt = new PXNumberEdit("_ctl00_phG_tab_t8_detgrid_lv0_edCuryAdjdBilledAmt", "Transferred to Invoice", grid.Locator, "CuryAdjdBilledAmt");
                    CuryAdjdBilledAmt.DataField = "CuryAdjdBilledAmt";
                    CuryDocBal = new PXNumberEdit("_ctl00_phG_tab_t8_detgrid_lv0_edCuryDocBal", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    ARPayment__Status = new DropDown("_ctl00_phG_tab_t8_detgrid_lv0_edARPayment__Status", "Status", grid.Locator, "ARPayment__Status");
                    ARPayment__Status.DataField = "ARPayment__Status";
                    ARPayment__Status.Items.Add("R", "Credit Hold");
                    ARPayment__Status.Items.Add("W", "Pending Processing");
                    ARPayment__Status.Items.Add("H", "On Hold");
                    ARPayment__Status.Items.Add("B", "Balanced");
                    ARPayment__Status.Items.Add("V", "Voided");
                    ARPayment__Status.Items.Add("S", "Scheduled");
                    ARPayment__Status.Items.Add("N", "Open");
                    ARPayment__Status.Items.Add("C", "Closed");
                    ARPayment__Status.Items.Add("P", "Pending Print");
                    ARPayment__Status.Items.Add("E", "Pending Email");
                    ARPayment__Status.Items.Add("Z", "Reserved");
                    ARPayment__Status.Items.Add("D", "Pending Approval");
                    ARPayment__Status.Items.Add("J", "Rejected");
                    ARPayment__Status.Items.Add("L", "Canceled");
                    ExtRefNbr = new PXTextEdit("ctl00_phG_tab_t8_detgrid_ei", "Payment Ref.", grid.Locator, "ExtRefNbr");
                    ExtRefNbr.DataField = "ExtRefNbr";
                    PaymentMethodID = new Selector("_ctl00_phG_tab_t8_detgrid_lv0_edPaymentMethodID", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    CashAccountID = new Selector("_ctl00_phG_tab_t8_detgrid_lv0_edCashAccountID", "Cash Account", grid.Locator, "CashAccountID");
                    CashAccountID.DataField = "CashAccountID";
                    CuryOrigDocAmt = new PXNumberEdit("ctl00_phG_tab_t8_detgrid_en", "Payment Amount", grid.Locator, "CuryOrigDocAmt");
                    CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                    ARPayment__CuryID = new Selector("_ctl00_phG_tab_t8_detgrid_lv0_es", "Currency", grid.Locator, "ARPayment__CuryID");
                    ARPayment__CuryID.DataField = "ARPayment__CuryID";
                    ExternalTransaction__ProcStatus = new DropDown("_ctl00_phG_tab_t8_detgrid_lv0_ec", "Proc. Status", grid.Locator, "ExternalTransaction__ProcStatus");
                    ExternalTransaction__ProcStatus.DataField = "ExternalTransaction__ProcStatus";
                    ExternalTransaction__ProcStatus.Items.Add("AUF", "Pre-Authorization Failed");
                    ExternalTransaction__ProcStatus.Items.Add("CAF", "Capture Failed");
                    ExternalTransaction__ProcStatus.Items.Add("VDF", "Voiding failed");
                    ExternalTransaction__ProcStatus.Items.Add("CDF", "Refund Failed");
                    ExternalTransaction__ProcStatus.Items.Add("AUS", "Pre-Authorized");
                    ExternalTransaction__ProcStatus.Items.Add("CAS", "Captured");
                    ExternalTransaction__ProcStatus.Items.Add("VDS", "Voided");
                    ExternalTransaction__ProcStatus.Items.Add("CDS", "Refunded");
                    ExternalTransaction__ProcStatus.Items.Add("AUH", "Held for Review (Authorization)");
                    ExternalTransaction__ProcStatus.Items.Add("CAH", "Held for Review (Capture)");
                    ExternalTransaction__ProcStatus.Items.Add("VDH", "Held for Review (Void)");
                    ExternalTransaction__ProcStatus.Items.Add("CDH", "Held for Review (Refund)");
                    ExternalTransaction__ProcStatus.Items.Add("AUD", "Pre-Authorization Declined");
                    ExternalTransaction__ProcStatus.Items.Add("CAD", "Capture Declined");
                    ExternalTransaction__ProcStatus.Items.Add("VDD", "Voiding Declined");
                    ExternalTransaction__ProcStatus.Items.Add("CDD", "Refund Declined");
                    ExternalTransaction__ProcStatus.Items.Add("AUE", "Pre-Authorization Expired");
                    ExternalTransaction__ProcStatus.Items.Add("UKN", "Unknown");
                    CanVoid = new CheckBox("ctl00_phG_tab_t8_detgrid_ef", "CanVoid", grid.Locator, "CanVoid");
                    CanVoid.DataField = "CanVoid";
                    CanCapture = new CheckBox("ctl00_phG_tab_t8_detgrid_ef", "CanCapture", grid.Locator, "CanCapture");
                    CanCapture.DataField = "CanCapture";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t8_detgrid_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                    AdjdOrderType = new PXTextEdit("_ctl00_phG_tab_t8_detgrid_lv0_edAdjdOrderType", "Order Type", grid.Locator, "AdjdOrderType");
                    AdjdOrderType.DataField = "AdjdOrderType";
                    AdjdOrderNbr = new PXTextEdit("_ctl00_phG_tab_t8_detgrid_lv0_edAdjdOrderNbr", "Order Nbr.", grid.Locator, "AdjdOrderNbr");
                    AdjdOrderNbr.DataField = "AdjdOrderNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter AdjgDocType { get; }
				public SelectorColumnFilter AdjgRefNbr { get; }
				public PXNumberEditColumnFilter CuryAdjdAmt { get; }
				public PXNumberEditColumnFilter CuryAdjdBilledAmt { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public DropDownColumnFilter ARPayment__Status { get; }
				public PXTextEditColumnFilter ExtRefNbr { get; }
				public SelectorColumnFilter PaymentMethodID { get; }
				public SelectorColumnFilter CashAccountID { get; }
				public PXNumberEditColumnFilter CuryOrigDocAmt { get; }
				public SelectorColumnFilter ARPayment__CuryID { get; }
				public DropDownColumnFilter ExternalTransaction__ProcStatus { get; }
				public CheckBoxColumnFilter CanVoid { get; }
				public CheckBoxColumnFilter CanCapture { get; }
				public PXNumberEditColumnFilter RecordID { get; }
				public PXTextEditColumnFilter AdjdOrderType { get; }
				public PXTextEditColumnFilter AdjdOrderNbr { get; }
                
                public c_grid_header(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    AdjgDocType = new DropDownColumnFilter(grid.Row.AdjgDocType);
                    AdjgRefNbr = new SelectorColumnFilter(grid.Row.AdjgRefNbr);
                    CuryAdjdAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjdAmt);
                    CuryAdjdBilledAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjdBilledAmt);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    ARPayment__Status = new DropDownColumnFilter(grid.Row.ARPayment__Status);
                    ExtRefNbr = new PXTextEditColumnFilter(grid.Row.ExtRefNbr);
                    PaymentMethodID = new SelectorColumnFilter(grid.Row.PaymentMethodID);
                    CashAccountID = new SelectorColumnFilter(grid.Row.CashAccountID);
                    CuryOrigDocAmt = new PXNumberEditColumnFilter(grid.Row.CuryOrigDocAmt);
                    ARPayment__CuryID = new SelectorColumnFilter(grid.Row.ARPayment__CuryID);
                    ExternalTransaction__ProcStatus = new DropDownColumnFilter(grid.Row.ExternalTransaction__ProcStatus);
                    CanVoid = new CheckBoxColumnFilter(grid.Row.CanVoid);
                    CanCapture = new CheckBoxColumnFilter(grid.Row.CanCapture);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                    AdjdOrderType = new PXTextEditColumnFilter(grid.Row.AdjdOrderType);
                    AdjdOrderNbr = new PXTextEditColumnFilter(grid.Row.AdjdOrderNbr);
                }
            }
        }
        
        public class c_adjustments_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AdjdOrderType { get; }
			public Label AdjdOrderTypeLabel { get; }
			public DropDown ARPayment__DocType { get; }
			public Label ARPayment__DocTypeLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public PXTextEdit AdjdOrderNbr { get; }
			public Label AdjdOrderNbrLabel { get; }
			public Selector ARPayment__RefNbr { get; }
			public Label ARPayment__RefNbrLabel { get; }
			public DropDown AdjgDocType { get; }
			public Label AdjgDocTypeLabel { get; }
			public DropDown ARPayment__Status { get; }
			public Label ARPayment__StatusLabel { get; }
			public Selector AdjgRefNbr { get; }
			public Label AdjgRefNbrLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public PXTextEdit ARPayment__ExtRefNbr { get; }
			public Label ARPayment__ExtRefNbrLabel { get; }
			public PXNumberEdit CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public PXNumberEdit CuryAdjdAmt { get; }
			public Label CuryAdjdAmtLabel { get; }
			public PXNumberEdit CuryAdjdBilledAmt { get; }
			public Label CuryAdjdBilledAmtLabel { get; }
			public PXNumberEdit AdjAmt { get; }
			public Label AdjAmtLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_adjustments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AdjdOrderType = new PXTextEdit("ctl00_phG_tab_t8_detgrid_lv0_edAdjdOrderType", "Order Type", locator, null);
                AdjdOrderTypeLabel = new Label(AdjdOrderType);
                AdjdOrderType.DataField = "AdjdOrderType";
                ARPayment__DocType = new DropDown("ctl00_phG_tab_t8_detgrid_lv0_edARPayment__DocType", "Type", locator, null);
                ARPayment__DocTypeLabel = new Label(ARPayment__DocType);
                ARPayment__DocType.DataField = "ARPayment__DocType";
                ARPayment__DocType.Items.Add("PMT", "Payment");
                ARPayment__DocType.Items.Add("CRM", "Credit Memo");
                ARPayment__DocType.Items.Add("PPM", "Prepayment");
                ARPayment__DocType.Items.Add("REF", "Customer Refund");
                ARPayment__DocType.Items.Add("VRF", "Voided Refund");
                ARPayment__DocType.Items.Add("RPM", "Voided Payment");
                ARPayment__DocType.Items.Add("SMB", "Balance WO");
                ARPayment__DocType.Items.Add("CSL", "Cash Sale");
                ARPayment__DocType.Items.Add("RCS", "Cash Return");
                PaymentMethodID = new Selector("ctl00_phG_tab_t8_detgrid_lv0_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                AdjdOrderNbr = new PXTextEdit("ctl00_phG_tab_t8_detgrid_lv0_edAdjdOrderNbr", "Order Nbr.", locator, null);
                AdjdOrderNbrLabel = new Label(AdjdOrderNbr);
                AdjdOrderNbr.DataField = "AdjdOrderNbr";
                ARPayment__RefNbr = new Selector("ctl00_phG_tab_t8_detgrid_lv0_edARPayment__RefNbr", "Reference Nbr.", locator, null);
                ARPayment__RefNbrLabel = new Label(ARPayment__RefNbr);
                ARPayment__RefNbr.DataField = "ARPayment__RefNbr";
                AdjgDocType = new DropDown("ctl00_phG_tab_t8_detgrid_lv0_edAdjgDocType", "Doc. Type", locator, null);
                AdjgDocTypeLabel = new Label(AdjgDocType);
                AdjgDocType.DataField = "AdjgDocType";
                AdjgDocType.Items.Add("PMT", "Payment");
                AdjgDocType.Items.Add("CRM", "Credit Memo");
                AdjgDocType.Items.Add("PPM", "Prepayment");
                ARPayment__Status = new DropDown("ctl00_phG_tab_t8_detgrid_lv0_edARPayment__Status", "Status", locator, null);
                ARPayment__StatusLabel = new Label(ARPayment__Status);
                ARPayment__Status.DataField = "ARPayment__Status";
                ARPayment__Status.Items.Add("R", "Credit Hold");
                ARPayment__Status.Items.Add("W", "Pending Processing");
                ARPayment__Status.Items.Add("H", "On Hold");
                ARPayment__Status.Items.Add("B", "Balanced");
                ARPayment__Status.Items.Add("V", "Voided");
                ARPayment__Status.Items.Add("S", "Scheduled");
                ARPayment__Status.Items.Add("N", "Open");
                ARPayment__Status.Items.Add("C", "Closed");
                ARPayment__Status.Items.Add("P", "Pending Print");
                ARPayment__Status.Items.Add("E", "Pending Email");
                ARPayment__Status.Items.Add("Z", "Reserved");
                ARPayment__Status.Items.Add("D", "Pending Approval");
                ARPayment__Status.Items.Add("J", "Rejected");
                ARPayment__Status.Items.Add("L", "Canceled");
                AdjgRefNbr = new Selector("ctl00_phG_tab_t8_detgrid_lv0_edAdjgRefNbr", "Reference Nbr.", locator, null);
                AdjgRefNbrLabel = new Label(AdjgRefNbr);
                AdjgRefNbr.DataField = "AdjgRefNbr";
                CashAccountID = new Selector("ctl00_phG_tab_t8_detgrid_lv0_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                ARPayment__ExtRefNbr = new PXTextEdit("ctl00_phG_tab_t8_detgrid_lv0_edARPayment__ExtRefNbr", "Payment Ref.", locator, null);
                ARPayment__ExtRefNbrLabel = new Label(ARPayment__ExtRefNbr);
                ARPayment__ExtRefNbr.DataField = "ARPayment__ExtRefNbr";
                CustomerID = new PXNumberEdit("ctl00_phG_tab_t8_detgrid_lv0_edCustomerID", "Customer ID", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                CuryAdjdAmt = new PXNumberEdit("ctl00_phG_tab_t8_detgrid_lv0_edCuryAdjdAmt", "Applied To Order", locator, null);
                CuryAdjdAmtLabel = new Label(CuryAdjdAmt);
                CuryAdjdAmt.DataField = "CuryAdjdAmt";
                CuryAdjdBilledAmt = new PXNumberEdit("ctl00_phG_tab_t8_detgrid_lv0_edCuryAdjdBilledAmt", "Transferred to Invoice", locator, null);
                CuryAdjdBilledAmtLabel = new Label(CuryAdjdBilledAmt);
                CuryAdjdBilledAmt.DataField = "CuryAdjdBilledAmt";
                AdjAmt = new PXNumberEdit("ctl00_phG_tab_t8_detgrid_lv0_edAdjAmt", "AdjAmt", locator, null);
                AdjAmtLabel = new Label(AdjAmt);
                AdjAmt.DataField = "AdjAmt";
                CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t8_detgrid_lv0_edCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                Es = new Selector("ctl00_phG_tab_t8_detgrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t8_detgrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "Adjustments";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ARPayment__RefNbrEdit()
            {
                Buttons.ARPayment__RefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ARPayment__RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ARPayment__RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_detgrid_lv0_edARPayment__RefNbr\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "ARPayment__RefNbrEdit", "ctl00_phG_tab_t8_detgrid_lv0");
                    ARPayment__RefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_rrdistribution_griddistribution : Grid<c_rrdistribution_griddistribution.c_grid_row, c_rrdistribution_griddistribution.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public c_rrdistribution_griddistribution(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t11_RUTROTForm_gridDistribution");
                DataMemberName = "RRDistribution";
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'Refresh\']" +
                            "", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'AdjustCol" +
                            "umns\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PageFirst" +
                            "\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PagePrev\'" +
                            "]", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PageNext\'" +
                            "]", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PageLast\'" +
                            "]", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit PersonalID { get; }
			public PXNumberEdit CuryAmount { get; }
			public CheckBox Extra { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_rrdistribution_griddistribution grid) : 
                        base(grid)
                {
                    PersonalID = new PXTextEdit("_ctl00_phG_tab_t11_RUTROTForm_gridDistribution_lv0_edPersonalID", "Personal ID", grid.Locator, "PersonalID");
                    PersonalID.DataField = "PersonalID";
                    CuryAmount = new PXNumberEdit("_ctl00_phG_tab_t11_RUTROTForm_gridDistribution_lv0_edAmount", "Amount", grid.Locator, "CuryAmount");
                    CuryAmount.DataField = "CuryAmount";
                    Extra = new CheckBox("ctl00_phG_tab_t11_RUTROTForm_gridDistribution", "Extra", grid.Locator, "Extra");
                    Extra.DataField = "Extra";
                    DocType = new PXTextEdit("ctl00_phG_tab_t11_RUTROTForm_gridDistribution_ei", "DocType", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t11_RUTROTForm_gridDistribution_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_gridDistribution_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter PersonalID { get; }
				public PXNumberEditColumnFilter CuryAmount { get; }
				public CheckBoxColumnFilter Extra { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_rrdistribution_griddistribution grid) : 
                        base(grid)
                {
                    PersonalID = new PXTextEditColumnFilter(grid.Row.PersonalID);
                    CuryAmount = new PXNumberEditColumnFilter(grid.Row.CuryAmount);
                    Extra = new CheckBoxColumnFilter(grid.Row.Extra);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_rrdistribution_lv0 : Container
        {
            
			public PXTextEdit PersonalID { get; }
			public Label PersonalIDLabel { get; }
			public PXNumberEdit CuryAmount { get; }
			public Label CuryAmountLabel { get; }
            
            public c_rrdistribution_lv0(string locator, string name) : 
                    base(locator, name)
            {
                PersonalID = new PXTextEdit("ctl00_phG_tab_t11_RUTROTForm_gridDistribution_lv0_edPersonalID", "Personal ID", locator, null);
                PersonalIDLabel = new Label(PersonalID);
                PersonalID.DataField = "PersonalID";
                CuryAmount = new PXNumberEdit("ctl00_phG_tab_t11_RUTROTForm_gridDistribution_lv0_edAmount", "Amount", locator, null);
                CuryAmountLabel = new Label(CuryAmount);
                CuryAmount.DataField = "CuryAmount";
                DataMemberName = "RRDistribution";
            }
        }
        
        public class c_sitestatusfilter_formsitesstatus : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Inventory { get; }
			public Label InventoryLabel { get; }
			public PXTextEdit BarCode { get; }
			public Label BarCodeLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector ItemClass { get; }
			public Label ItemClassLabel { get; }
			public Selector SubItem { get; }
			public Label SubItemLabel { get; }
			public GroupBox Mode { get; }
			public Label ModeLabel { get; }
			public CheckBox OnlyAvailable { get; }
			public Label OnlyAvailableLabel { get; }
			public CheckBox DropShipSales { get; }
			public Label DropShipSalesLabel { get; }
			public DateSelector HistoryDate { get; }
			public Label HistoryDateLabel { get; }
            
            public c_sitestatusfilter_formsitesstatus(string locator, string name) : 
                    base(locator, name)
            {
                Inventory = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edInventory", "Inventory", locator, null);
                InventoryLabel = new Label(Inventory);
                Inventory.DataField = "Inventory";
                BarCode = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edBarCode", "Bar Code", locator, null);
                BarCodeLabel = new Label(BarCode);
                BarCode.DataField = "BarCode";
                SiteID = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                ItemClass = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edItemClassID", "Item Class", locator, null);
                ItemClassLabel = new Label(ItemClass);
                ItemClass.DataField = "ItemClass";
                SubItem = new Selector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edSubItem", "Sub Item", locator, null);
                SubItemLabel = new Label(SubItem);
                SubItem.DataField = "SubItem";
                Mode = new GroupBox("ctl00_phG_PanelAddSiteStatus_formSitesStatus_gpMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                OnlyAvailable = new CheckBox("ctl00_phG_PanelAddSiteStatus_formSitesStatus_chkOnlyAvailable", "Only Available", locator, null);
                OnlyAvailableLabel = new Label(OnlyAvailable);
                OnlyAvailable.DataField = "OnlyAvailable";
                DropShipSales = new CheckBox("ctl00_phG_PanelAddSiteStatus_formSitesStatus_chkDropShipSales", "Drop Ship Sales", locator, null);
                DropShipSalesLabel = new Label(DropShipSales);
                DropShipSales.DataField = "DropShipSales";
                HistoryDate = new DateSelector("ctl00_phG_PanelAddSiteStatus_formSitesStatus_edHistoryDate", "History Date", locator, null);
                HistoryDateLabel = new Label(HistoryDate);
                HistoryDate.DataField = "HistoryDate";
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
			public Selector ItemClassID { get; }
			public InputLocalizable ItemClassDescription { get; }
			public PXTextEdit PriceClassID { get; }
			public PXTextEdit PriceClassDescription { get; }
			public Selector PreferredVendorID { get; }
			public PXTextEdit PreferredVendorDescription { get; }
			public Selector InventoryCD { get; }
			public Selector SubItemID { get; }
			public PXTextEdit SubItemCD { get; }
			public InputLocalizable Descr { get; }
			public Selector SalesUnit { get; }
			public PXNumberEdit QtyAvailSale { get; }
			public PXNumberEdit QtyOnHandSale { get; }
			public PXTextEdit CuryID { get; }
			public PXNumberEdit QtyLastSale { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public DateSelector LastSalesDate { get; }
			public PXNumberEdit DropShipLastQty { get; }
			public PXNumberEdit DropShipCuryUnitPrice { get; }
			public DateSelector DropShipLastDate { get; }
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
                    SiteCD = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "SiteCD", grid.Locator, "SiteCD");
                    SiteCD.DataField = "SiteCD";
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
                    SubItemCD = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "SubItemCD", grid.Locator, "SubItemCD");
                    SubItemCD.DataField = "SubItemCD";
                    Descr = new InputLocalizable("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    SalesUnit = new Selector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_es", "Sales Unit", grid.Locator, "SalesUnit");
                    SalesUnit.DataField = "SalesUnit";
                    QtyAvailSale = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. Available", grid.Locator, "QtyAvailSale");
                    QtyAvailSale.DataField = "QtyAvailSale";
                    QtyOnHandSale = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. On Hand", grid.Locator, "QtyOnHandSale");
                    QtyOnHandSale.DataField = "QtyOnHandSale";
                    CuryID = new PXTextEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_em", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    QtyLastSale = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. Last Sales", grid.Locator, "QtyLastSale");
                    QtyLastSale.DataField = "QtyLastSale";
                    CuryUnitPrice = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Last Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    LastSalesDate = new DateSelector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_ed20", "Last Sales Date", grid.Locator, "LastSalesDate");
                    LastSalesDate.DataField = "LastSalesDate";
                    DropShipLastQty = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Qty. of Last Drop Ship", grid.Locator, "DropShipLastQty");
                    DropShipLastQty.DataField = "DropShipLastQty";
                    DropShipCuryUnitPrice = new PXNumberEdit("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_en", "Unit Price of Last Drop Ship", grid.Locator, "DropShipCuryUnitPrice");
                    DropShipCuryUnitPrice.DataField = "DropShipCuryUnitPrice";
                    DropShipLastDate = new DateSelector("_ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_ed23", "Date of Last Drop Ship", grid.Locator, "DropShipLastDate");
                    DropShipLastDate.DataField = "DropShipLastDate";
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
				public PXTextEditColumnFilter SiteCD { get; }
				public SelectorColumnFilter ItemClassID { get; }
				public PXTextEditColumnFilter ItemClassDescription { get; }
				public PXTextEditColumnFilter PriceClassID { get; }
				public PXTextEditColumnFilter PriceClassDescription { get; }
				public SelectorColumnFilter PreferredVendorID { get; }
				public PXTextEditColumnFilter PreferredVendorDescription { get; }
				public SelectorColumnFilter InventoryCD { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter SubItemCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter SalesUnit { get; }
				public PXNumberEditColumnFilter QtyAvailSale { get; }
				public PXNumberEditColumnFilter QtyOnHandSale { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter QtyLastSale { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public DateSelectorColumnFilter LastSalesDate { get; }
				public PXNumberEditColumnFilter DropShipLastQty { get; }
				public PXNumberEditColumnFilter DropShipCuryUnitPrice { get; }
				public DateSelectorColumnFilter DropShipLastDate { get; }
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
                    SiteCD = new PXTextEditColumnFilter(grid.Row.SiteCD);
                    ItemClassID = new SelectorColumnFilter(grid.Row.ItemClassID);
                    ItemClassDescription = new PXTextEditColumnFilter(grid.Row.ItemClassDescription);
                    PriceClassID = new PXTextEditColumnFilter(grid.Row.PriceClassID);
                    PriceClassDescription = new PXTextEditColumnFilter(grid.Row.PriceClassDescription);
                    PreferredVendorID = new SelectorColumnFilter(grid.Row.PreferredVendorID);
                    PreferredVendorDescription = new PXTextEditColumnFilter(grid.Row.PreferredVendorDescription);
                    InventoryCD = new SelectorColumnFilter(grid.Row.InventoryCD);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SubItemCD = new PXTextEditColumnFilter(grid.Row.SubItemCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    SalesUnit = new SelectorColumnFilter(grid.Row.SalesUnit);
                    QtyAvailSale = new PXNumberEditColumnFilter(grid.Row.QtyAvailSale);
                    QtyOnHandSale = new PXNumberEditColumnFilter(grid.Row.QtyOnHandSale);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    QtyLastSale = new PXNumberEditColumnFilter(grid.Row.QtyLastSale);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    LastSalesDate = new DateSelectorColumnFilter(grid.Row.LastSalesDate);
                    DropShipLastQty = new PXNumberEditColumnFilter(grid.Row.DropShipLastQty);
                    DropShipCuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.DropShipCuryUnitPrice);
                    DropShipLastDate = new DateSelectorColumnFilter(grid.Row.DropShipLastDate);
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
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
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
                Ed = new DateSelector("ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
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
                    Add = new Button("ctl00_phG_PanelAddSiteStatus_PXButton5", "Add", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddSiteStatus_PXButton4", "Add & Close", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddSiteStatus_PXButton6", "Cancel", "ctl00_phG_PanelAddSiteStatus_gripSiteStatus_lv0");
                }
            }
        }
        
        public class c_carrierrates_gridrates : Grid<c_carrierrates_gridrates.c_grid_row, c_carrierrates_gridrates.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_carrierrates_gridrates(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelCarrierRates_gridRates");
                DataMemberName = "CarrierRates";
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
            
            public virtual void RefreshRates()
            {
                ToolBar.RefreshRates.Click();
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid RefreshRates { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    RefreshRates = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'RefreshRates\']", "Refresh Rates", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridRates");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit Method { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit Amount { get; }
			public PXNumberEdit DaysInTransit { get; }
			public DateSelector DeliveryDate { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_carrierrates_gridrates grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelCarrierRates_gridRates_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    Method = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridRates_ei", "Code", grid.Locator, "Method");
                    Method.DataField = "Method";
                    Description = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridRates_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    Amount = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridRates_en", "Amount", grid.Locator, "Amount");
                    Amount.DataField = "Amount";
                    DaysInTransit = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridRates_en", "Days in Transit", grid.Locator, "DaysInTransit");
                    DaysInTransit.DataField = "DaysInTransit";
                    DeliveryDate = new DateSelector("_ctl00_phG_PanelCarrierRates_gridRates_lv0_ed5", "Delivery Date", grid.Locator, "DeliveryDate");
                    DeliveryDate.DataField = "DeliveryDate";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridRates_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter Method { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXNumberEditColumnFilter Amount { get; }
				public PXNumberEditColumnFilter DaysInTransit { get; }
				public DateSelectorColumnFilter DeliveryDate { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_carrierrates_gridrates grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    Method = new PXTextEditColumnFilter(grid.Row.Method);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    Amount = new PXNumberEditColumnFilter(grid.Row.Amount);
                    DaysInTransit = new PXNumberEditColumnFilter(grid.Row.DaysInTransit);
                    DeliveryDate = new DateSelectorColumnFilter(grid.Row.DeliveryDate);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_carrierrates_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_carrierrates_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_PanelCarrierRates_gridRates_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "CarrierRates";
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackages_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
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
        
        public class c_quickprocessparameters_fromquickprocess : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public GroupBox ShipDateMode { get; }
			public Label ShipDateModeLabel { get; }
			public DateSelector ShipDate { get; }
			public Label ShipDateLabel { get; }
			public CheckBox PrintWithDeviceHub { get; }
			public Label PrintWithDeviceHubLabel { get; }
			public CheckBox DefinePrinterManually { get; }
			public Label DefinePrinterManuallyLabel { get; }
			public Selector PrinterID { get; }
			public Label PrinterIDLabel { get; }
			public PXTextEdit NumberOfCopies { get; }
			public Label NumberOfCopiesLabel { get; }
			public CheckBox GreenStatus { get; }
			public Label GreenStatusLabel { get; }
			public CheckBox YellowStatus { get; }
			public Label YellowStatusLabel { get; }
			public CheckBox RedStatus { get; }
			public Label RedStatusLabel { get; }
			public PXTextEdit AvailabilityMessage { get; }
			public Label AvailabilityMessageLabel { get; }
			public CheckBox CreateShipment { get; }
			public Label CreateShipmentLabel { get; }
			public CheckBox PrintPickList { get; }
			public Label PrintPickListLabel { get; }
			public CheckBox ConfirmShipment { get; }
			public Label ConfirmShipmentLabel { get; }
			public CheckBox PrintLabels { get; }
			public Label PrintLabelsLabel { get; }
			public CheckBox PrintConfirmation { get; }
			public Label PrintConfirmationLabel { get; }
			public CheckBox UpdateIN { get; }
			public Label UpdateINLabel { get; }
			public CheckBox PrepareInvoiceFromShipment { get; }
			public Label PrepareInvoiceFromShipmentLabel { get; }
			public CheckBox PrepareInvoice { get; }
			public Label PrepareInvoiceLabel { get; }
			public CheckBox PrintInvoice { get; }
			public Label PrintInvoiceLabel { get; }
			public CheckBox EmailInvoice { get; }
			public Label EmailInvoiceLabel { get; }
			public CheckBox ReleaseInvoice { get; }
			public Label ReleaseInvoiceLabel { get; }
            
            public c_quickprocessparameters_fromquickprocess(string locator, string name) : 
                    base(locator, name)
            {
                SiteID = new Selector("ctl00_phG_PXSmartPanel1_fromQuickProcess_edSiteID", "Warehouse ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                ShipDateMode = new GroupBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_gbShipDate", "Ship Date Mode", locator, null);
                ShipDateModeLabel = new Label(ShipDateMode);
                ShipDateMode.DataField = "ShipDateMode";
                ShipDate = new DateSelector("ctl00_phG_PXSmartPanel1_fromQuickProcess_gbShipDate_edShipDate", "Ship Date", locator, null);
                ShipDateLabel = new Label(ShipDate);
                ShipDate.DataField = "ShipDate";
                PrintWithDeviceHub = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrintWithDeviceHub", "Print with DeviceHub", locator, null);
                PrintWithDeviceHubLabel = new Label(PrintWithDeviceHub);
                PrintWithDeviceHub.DataField = "PrintWithDeviceHub";
                DefinePrinterManually = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_PXDefinePrinterAutomatically", "Define Printers Manually", locator, null);
                DefinePrinterManuallyLabel = new Label(DefinePrinterManually);
                DefinePrinterManually.DataField = "DefinePrinterManually";
                PrinterID = new Selector("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrinterID", "Printer", locator, null);
                PrinterIDLabel = new Label(PrinterID);
                PrinterID.DataField = "PrinterID";
                NumberOfCopies = new PXTextEdit("ctl00_phG_PXSmartPanel1_fromQuickProcess_edNumberOfCopies", "Number of Copies", locator, null);
                NumberOfCopiesLabel = new Label(NumberOfCopies);
                NumberOfCopies.DataField = "NumberOfCopies";
                GreenStatus = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edGreenStatus", "Green Status", locator, null);
                GreenStatusLabel = new Label(GreenStatus);
                GreenStatus.DataField = "GreenStatus";
                YellowStatus = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edYellowStatus", "Yellow Status", locator, null);
                YellowStatusLabel = new Label(YellowStatus);
                YellowStatus.DataField = "YellowStatus";
                RedStatus = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edRedStatus", "Red Status", locator, null);
                RedStatusLabel = new Label(RedStatus);
                RedStatus.DataField = "RedStatus";
                AvailabilityMessage = new PXTextEdit("ctl00_phG_PXSmartPanel1_fromQuickProcess_edAvailMsg", "Availability Message", locator, null);
                AvailabilityMessageLabel = new Label(AvailabilityMessage);
                AvailabilityMessage.DataField = "AvailabilityMessage";
                CreateShipment = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edCreateShipment", "Create Shipment", locator, null);
                CreateShipmentLabel = new Label(CreateShipment);
                CreateShipment.DataField = "CreateShipment";
                PrintPickList = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrintPickList", "Print Pick List", locator, null);
                PrintPickListLabel = new Label(PrintPickList);
                PrintPickList.DataField = "PrintPickList";
                ConfirmShipment = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edConfirmShipment", "Confirm Shipment", locator, null);
                ConfirmShipmentLabel = new Label(ConfirmShipment);
                ConfirmShipment.DataField = "ConfirmShipment";
                PrintLabels = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrintLabels", "Print Labels", locator, null);
                PrintLabelsLabel = new Label(PrintLabels);
                PrintLabels.DataField = "PrintLabels";
                PrintConfirmation = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrintShipmentConfirmation", "Print Shipment Confirmation", locator, null);
                PrintConfirmationLabel = new Label(PrintConfirmation);
                PrintConfirmation.DataField = "PrintConfirmation";
                UpdateIN = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edUpdateIN", "Update IN", locator, null);
                UpdateINLabel = new Label(UpdateIN);
                UpdateIN.DataField = "UpdateIN";
                PrepareInvoiceFromShipment = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrepareInvoiceFromShipment", "Prepare Invoice", locator, null);
                PrepareInvoiceFromShipmentLabel = new Label(PrepareInvoiceFromShipment);
                PrepareInvoiceFromShipment.DataField = "PrepareInvoiceFromShipment";
                PrepareInvoice = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrepareInvoice", "Prepare Invoice", locator, null);
                PrepareInvoiceLabel = new Label(PrepareInvoice);
                PrepareInvoice.DataField = "PrepareInvoice";
                PrintInvoice = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edPrintInvoice", "Print Invoice", locator, null);
                PrintInvoiceLabel = new Label(PrintInvoice);
                PrintInvoice.DataField = "PrintInvoice";
                EmailInvoice = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edEmailInvoice", "Email Invoice", locator, null);
                EmailInvoiceLabel = new Label(EmailInvoice);
                EmailInvoice.DataField = "EmailInvoice";
                ReleaseInvoice = new CheckBox("ctl00_phG_PXSmartPanel1_fromQuickProcess_edReleaseInvoice", "Release Invoice", locator, null);
                ReleaseInvoiceLabel = new Label(ReleaseInvoice);
                ReleaseInvoice.DataField = "ReleaseInvoice";
                DataMemberName = "QuickProcessParameters";
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
                    Ok = new Button("ctl00_phG_PXSmartPanel1_PXProcess", "OK", "ctl00_phG_PXSmartPanel1_fromQuickProcess");
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
        
        public class c_lssoline_lotseropts_optform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit UnassignedQty { get; }
			public Label UnassignedQtyLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXTextEdit StartNumVal { get; }
			public Label StartNumValLabel { get; }
            
            public c_lssoline_lotseropts_optform(string locator, string name) : 
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
                DataMemberName = "LSSOLine_lotseropts";
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
        
        public class c_quickpayment_createpaymentformview : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit CuryOrigDocAmt { get; }
			public Label CuryOrigDocAmtLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public PXTextEdit DocDesc { get; }
			public Label DocDescLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public CheckBox NewCard { get; }
			public Label NewCardLabel { get; }
			public CheckBox SaveCard { get; }
			public Label SaveCardLabel { get; }
			public Selector PMInstanceID { get; }
			public Label PMInstanceIDLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Label ExtRefNbrLabel { get; }
            
            public c_quickpayment_createpaymentformview(string locator, string name) : 
                    base(locator, name)
            {
                CuryOrigDocAmt = new PXNumberEdit("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edCuryOrigDocAmt", "Cury Orig Doc Amt", locator, null);
                CuryOrigDocAmtLabel = new Label(CuryOrigDocAmt);
                CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                CuryID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edCuryID", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                DocDesc = new PXTextEdit("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edDocDesc", "Doc Desc", locator, null);
                DocDescLabel = new Label(DocDesc);
                DocDesc.DataField = "DocDesc";
                PaymentMethodID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_selPaymentMethodID", "Payment Method ID", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                NewCard = new CheckBox("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_chkNewCard", "New Card", locator, null);
                NewCardLabel = new Label(NewCard);
                NewCard.DataField = "NewCard";
                SaveCard = new CheckBox("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_chkSaveCard", "Save Card", locator, null);
                SaveCardLabel = new Label(SaveCard);
                SaveCard.DataField = "SaveCard";
                PMInstanceID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edPMInstanceID", "PM Instance ID", locator, null);
                PMInstanceIDLabel = new Label(PMInstanceID);
                PMInstanceID.DataField = "PMInstanceID";
                CashAccountID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edCashAccountID", "Cash Account ID", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                ProcessingCenterID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edProcessingCenterID", "Processing Center ID", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                ExtRefNbr = new PXTextEdit("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edExtRefNbr", "Ext Ref Nbr", locator, null);
                ExtRefNbrLabel = new Label(ExtRefNbr);
                ExtRefNbr.DataField = "ExtRefNbr";
                DataMemberName = "QuickPayment";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CreatePaymentCaptureButton()
            {
                Buttons.CreatePaymentCaptureButton.Click();
            }
            
            public virtual void CreatePaymentAuthorizeButton()
            {
                Buttons.CreatePaymentAuthorizeButton.Click();
            }
            
            public virtual void CreatePaymentOKButton()
            {
                Buttons.CreatePaymentOKButton.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CreatePaymentCaptureButton { get; }
			public Button CreatePaymentAuthorizeButton { get; }
			public Button CreatePaymentOKButton { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    CreatePaymentCaptureButton = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentCaptureButton", "CreatePaymentCaptureButton", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                    CreatePaymentAuthorizeButton = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentAuthorizeButton", "CreatePaymentAuthorizeButton", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                    CreatePaymentOKButton = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentOKButton", "CreatePaymentOKButton", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                    Cancel = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentCancelButton", "Cancel", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                }
            }
        }
        
        public class c_importexternaltran_importpaymentformview : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit TranNumber { get; }
			public Label TranNumberLabel { get; }
			public Selector ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
            
            public c_importexternaltran_importpaymentformview(string locator, string name) : 
                    base(locator, name)
            {
                TranNumber = new PXTextEdit("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView_edTranNumber", "Tran Number", locator, null);
                TranNumberLabel = new Label(TranNumber);
                TranNumber.DataField = "TranNumber";
                ProcessingCenterID = new Selector("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView_edProcessingCenterID", "Processing Center ID", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                DataMemberName = "ImportExternalTran";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ImportPaymentCreateButton()
            {
                Buttons.ImportPaymentCreateButton.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ImportPaymentCreateButton { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    ImportPaymentCreateButton = new Button("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentCreateButton", "ImportPaymentCreateButton", "ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView");
                    Cancel = new Button("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentCancelButton", "Cancel", "ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView");
                }
            }
        }
        
        public class c_orderestimaterecords_gridestimates : Grid<c_orderestimaterecords_gridestimates.c_grid_row, c_orderestimaterecords_gridestimates.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_orderestimaterecords_gridestimates(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_gridEstimates");
                DataMemberName = "OrderEstimateRecords";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_gridEstimates_fe_gf", "FilterForm");
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
            
            public virtual void AddEstimate()
            {
                ToolBar.AddEstimate.Click();
            }
            
            public virtual void QuickEstimate()
            {
                ToolBar.QuickEstimate.Click();
            }
            
            public virtual void RemoveEstimate()
            {
                ToolBar.RemoveEstimate.Click();
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
			public ToolBarButtonGrid AddEstimate { get; }
			public ToolBarButtonGrid QuickEstimate { get; }
			public ToolBarButtonGrid RemoveEstimate { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    AddEstimate = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'AddEstimate\']", "AddEstimate", locator, null);
                    QuickEstimate = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'QuickEstimate\']", "Quick Estimate", locator, null);
                    RemoveEstimate = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'RemoveEstimate\']", "Remove", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridEstimates_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector BranchID { get; }
			public Selector AMEstimateItem__InventoryCD { get; }
			public PXTextEdit AMEstimateItem__ItemDesc { get; }
			public Selector AMEstimateItem__SubItemID { get; }
			public Selector AMEstimateItem__SiteID { get; }
			public Selector AMEstimateItem__UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public Selector EstimateID { get; }
			public Selector RevisionID { get; }
			public Selector TaxCategoryID { get; }
			public Selector AMEstimateItem__OwnerID { get; }
			public Selector AMEstimateItem__EngineerID { get; }
			public DateSelector AMEstimateItem__RequestDate { get; }
			public DateSelector AMEstimateItem__PromiseDate { get; }
			public Selector AMEstimateItem__EstimateClassID { get; }
                
                public c_grid_row(c_orderestimaterecords_gridestimates grid) : 
                        base(grid)
                {
                    BranchID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstBranch", "Branch ID", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    AMEstimateItem__InventoryCD = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstInventoryCD", "AM Estimate Item __ Inventory CD", grid.Locator, "AMEstimateItem__InventoryCD");
                    AMEstimateItem__InventoryCD.DataField = "AMEstimateItem__InventoryCD";
                    AMEstimateItem__ItemDesc = new PXTextEdit("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstItemDesc", "AM Estimate Item __ Item Desc", grid.Locator, "AMEstimateItem__ItemDesc");
                    AMEstimateItem__ItemDesc.DataField = "AMEstimateItem__ItemDesc";
                    AMEstimateItem__SubItemID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_EstimateSubItemID", "AM Estimate Item __ Sub Item ID", grid.Locator, "AMEstimateItem__SubItemID");
                    AMEstimateItem__SubItemID.DataField = "AMEstimateItem__SubItemID";
                    AMEstimateItem__SiteID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstSiteID", "AM Estimate Item __ Site ID", grid.Locator, "AMEstimateItem__SiteID");
                    AMEstimateItem__SiteID.DataField = "AMEstimateItem__SiteID";
                    AMEstimateItem__UOM = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstUOM", "AM Estimate Item __ UOM", grid.Locator, "AMEstimateItem__UOM");
                    AMEstimateItem__UOM.DataField = "AMEstimateItem__UOM";
                    OrderQty = new PXNumberEdit("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstOrderQty", "Order Qty", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    CuryUnitPrice = new PXNumberEdit("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstCuryUnitPrice", "Cury Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    CuryExtPrice = new PXNumberEdit("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstCuryExtPrice", "Cury Ext Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    EstimateID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstEstimateID", "Estimate ID", grid.Locator, "EstimateID");
                    EstimateID.DataField = "EstimateID";
                    RevisionID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstRevisionID", "Revision ID", grid.Locator, "RevisionID");
                    RevisionID.DataField = "RevisionID";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstTaxCategoryID", "Tax Category ID", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    AMEstimateItem__OwnerID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstOwnerID", "AM Estimate Item __ Owner ID", grid.Locator, "AMEstimateItem__OwnerID");
                    AMEstimateItem__OwnerID.DataField = "AMEstimateItem__OwnerID";
                    AMEstimateItem__EngineerID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstEngineerID", "AM Estimate Item __ Engineer ID", grid.Locator, "AMEstimateItem__EngineerID");
                    AMEstimateItem__EngineerID.DataField = "AMEstimateItem__EngineerID";
                    AMEstimateItem__RequestDate = new DateSelector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstRequestDate", "AM Estimate Item __ Request Date", grid.Locator, "AMEstimateItem__RequestDate");
                    AMEstimateItem__RequestDate.DataField = "AMEstimateItem__RequestDate";
                    AMEstimateItem__PromiseDate = new DateSelector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstPromiseDate", "AM Estimate Item __ Promise Date", grid.Locator, "AMEstimateItem__PromiseDate");
                    AMEstimateItem__PromiseDate.DataField = "AMEstimateItem__PromiseDate";
                    AMEstimateItem__EstimateClassID = new Selector("_ctl00_phG_tab_t1_gridEstimates_lv0_edEstEstimateClassID", "AM Estimate Item __ Estimate Class ID", grid.Locator, "AMEstimateItem__EstimateClassID");
                    AMEstimateItem__EstimateClassID.DataField = "AMEstimateItem__EstimateClassID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter BranchID { get; }
				public SelectorColumnFilter AMEstimateItem__InventoryCD { get; }
				public PXTextEditColumnFilter AMEstimateItem__ItemDesc { get; }
				public SelectorColumnFilter AMEstimateItem__SubItemID { get; }
				public SelectorColumnFilter AMEstimateItem__SiteID { get; }
				public SelectorColumnFilter AMEstimateItem__UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public SelectorColumnFilter EstimateID { get; }
				public SelectorColumnFilter RevisionID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public SelectorColumnFilter AMEstimateItem__OwnerID { get; }
				public SelectorColumnFilter AMEstimateItem__EngineerID { get; }
				public DateSelectorColumnFilter AMEstimateItem__RequestDate { get; }
				public DateSelectorColumnFilter AMEstimateItem__PromiseDate { get; }
				public SelectorColumnFilter AMEstimateItem__EstimateClassID { get; }
                
                public c_grid_header(c_orderestimaterecords_gridestimates grid) : 
                        base(grid)
                {
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    AMEstimateItem__InventoryCD = new SelectorColumnFilter(grid.Row.AMEstimateItem__InventoryCD);
                    AMEstimateItem__ItemDesc = new PXTextEditColumnFilter(grid.Row.AMEstimateItem__ItemDesc);
                    AMEstimateItem__SubItemID = new SelectorColumnFilter(grid.Row.AMEstimateItem__SubItemID);
                    AMEstimateItem__SiteID = new SelectorColumnFilter(grid.Row.AMEstimateItem__SiteID);
                    AMEstimateItem__UOM = new SelectorColumnFilter(grid.Row.AMEstimateItem__UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    EstimateID = new SelectorColumnFilter(grid.Row.EstimateID);
                    RevisionID = new SelectorColumnFilter(grid.Row.RevisionID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    AMEstimateItem__OwnerID = new SelectorColumnFilter(grid.Row.AMEstimateItem__OwnerID);
                    AMEstimateItem__EngineerID = new SelectorColumnFilter(grid.Row.AMEstimateItem__EngineerID);
                    AMEstimateItem__RequestDate = new DateSelectorColumnFilter(grid.Row.AMEstimateItem__RequestDate);
                    AMEstimateItem__PromiseDate = new DateSelectorColumnFilter(grid.Row.AMEstimateItem__PromiseDate);
                    AMEstimateItem__EstimateClassID = new SelectorColumnFilter(grid.Row.AMEstimateItem__EstimateClassID);
                }
            }
        }
        
        public class c_orderestimaterecords_lv0 : Container
        {
            
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector AMEstimateItem__InventoryCD { get; }
			public Label AMEstimateItem__InventoryCDLabel { get; }
			public PXTextEdit AMEstimateItem__ItemDesc { get; }
			public Label AMEstimateItem__ItemDescLabel { get; }
			public Selector AMEstimateItem__SubItemID { get; }
			public Label AMEstimateItem__SubItemIDLabel { get; }
			public Selector AMEstimateItem__SiteID { get; }
			public Label AMEstimateItem__SiteIDLabel { get; }
			public Selector AMEstimateItem__UOM { get; }
			public Label AMEstimateItem__UOMLabel { get; }
			public PXNumberEdit OrderQty { get; }
			public Label OrderQtyLabel { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public Label CuryUnitPriceLabel { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public Label CuryExtPriceLabel { get; }
			public Selector EstimateID { get; }
			public Label EstimateIDLabel { get; }
			public Selector RevisionID { get; }
			public Label RevisionIDLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector AMEstimateItem__OwnerID { get; }
			public Label AMEstimateItem__OwnerIDLabel { get; }
			public Selector AMEstimateItem__EngineerID { get; }
			public Label AMEstimateItem__EngineerIDLabel { get; }
			public DateSelector AMEstimateItem__RequestDate { get; }
			public Label AMEstimateItem__RequestDateLabel { get; }
			public DateSelector AMEstimateItem__PromiseDate { get; }
			public Label AMEstimateItem__PromiseDateLabel { get; }
			public Selector AMEstimateItem__EstimateClassID { get; }
			public Label AMEstimateItem__EstimateClassIDLabel { get; }
            
            public c_orderestimaterecords_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BranchID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstBranch", "Branch ID", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                AMEstimateItem__InventoryCD = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstInventoryCD", "AM Estimate Item __ Inventory CD", locator, null);
                AMEstimateItem__InventoryCDLabel = new Label(AMEstimateItem__InventoryCD);
                AMEstimateItem__InventoryCD.DataField = "AMEstimateItem__InventoryCD";
                AMEstimateItem__ItemDesc = new PXTextEdit("ctl00_phG_tab_t1_gridEstimates_lv0_edEstItemDesc", "AM Estimate Item __ Item Desc", locator, null);
                AMEstimateItem__ItemDescLabel = new Label(AMEstimateItem__ItemDesc);
                AMEstimateItem__ItemDesc.DataField = "AMEstimateItem__ItemDesc";
                AMEstimateItem__SubItemID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_EstimateSubItemID", "AM Estimate Item __ Sub Item ID", locator, null);
                AMEstimateItem__SubItemIDLabel = new Label(AMEstimateItem__SubItemID);
                AMEstimateItem__SubItemID.DataField = "AMEstimateItem__SubItemID";
                AMEstimateItem__SiteID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstSiteID", "AM Estimate Item __ Site ID", locator, null);
                AMEstimateItem__SiteIDLabel = new Label(AMEstimateItem__SiteID);
                AMEstimateItem__SiteID.DataField = "AMEstimateItem__SiteID";
                AMEstimateItem__UOM = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstUOM", "AM Estimate Item __ UOM", locator, null);
                AMEstimateItem__UOMLabel = new Label(AMEstimateItem__UOM);
                AMEstimateItem__UOM.DataField = "AMEstimateItem__UOM";
                OrderQty = new PXNumberEdit("ctl00_phG_tab_t1_gridEstimates_lv0_edEstOrderQty", "Order Qty", locator, null);
                OrderQtyLabel = new Label(OrderQty);
                OrderQty.DataField = "OrderQty";
                CuryUnitPrice = new PXNumberEdit("ctl00_phG_tab_t1_gridEstimates_lv0_edEstCuryUnitPrice", "Cury Unit Price", locator, null);
                CuryUnitPriceLabel = new Label(CuryUnitPrice);
                CuryUnitPrice.DataField = "CuryUnitPrice";
                CuryExtPrice = new PXNumberEdit("ctl00_phG_tab_t1_gridEstimates_lv0_edEstCuryExtPrice", "Cury Ext Price", locator, null);
                CuryExtPriceLabel = new Label(CuryExtPrice);
                CuryExtPrice.DataField = "CuryExtPrice";
                EstimateID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstEstimateID", "Estimate ID", locator, null);
                EstimateIDLabel = new Label(EstimateID);
                EstimateID.DataField = "EstimateID";
                RevisionID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstRevisionID", "Revision ID", locator, null);
                RevisionIDLabel = new Label(RevisionID);
                RevisionID.DataField = "RevisionID";
                TaxCategoryID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstTaxCategoryID", "Tax Category ID", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                AMEstimateItem__OwnerID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstOwnerID", "AM Estimate Item __ Owner ID", locator, null);
                AMEstimateItem__OwnerIDLabel = new Label(AMEstimateItem__OwnerID);
                AMEstimateItem__OwnerID.DataField = "AMEstimateItem__OwnerID";
                AMEstimateItem__EngineerID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstEngineerID", "AM Estimate Item __ Engineer ID", locator, null);
                AMEstimateItem__EngineerIDLabel = new Label(AMEstimateItem__EngineerID);
                AMEstimateItem__EngineerID.DataField = "AMEstimateItem__EngineerID";
                AMEstimateItem__RequestDate = new DateSelector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstRequestDate", "AM Estimate Item __ Request Date", locator, null);
                AMEstimateItem__RequestDateLabel = new Label(AMEstimateItem__RequestDate);
                AMEstimateItem__RequestDate.DataField = "AMEstimateItem__RequestDate";
                AMEstimateItem__PromiseDate = new DateSelector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstPromiseDate", "AM Estimate Item __ Promise Date", locator, null);
                AMEstimateItem__PromiseDateLabel = new Label(AMEstimateItem__PromiseDate);
                AMEstimateItem__PromiseDate.DataField = "AMEstimateItem__PromiseDate";
                AMEstimateItem__EstimateClassID = new Selector("ctl00_phG_tab_t1_gridEstimates_lv0_edEstEstimateClassID", "AM Estimate Item __ Estimate Class ID", locator, null);
                AMEstimateItem__EstimateClassIDLabel = new Label(AMEstimateItem__EstimateClassID);
                AMEstimateItem__EstimateClassID.DataField = "AMEstimateItem__EstimateClassID";
                DataMemberName = "OrderEstimateRecords";
            }
        }
        
        public class c_selectedestimaterecord_quickestimateform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector EstimateID { get; }
			public Label EstimateIDLabel { get; }
			public Selector RevisionID { get; }
			public Label RevisionIDLabel { get; }
			public Selector InventoryCD { get; }
			public Label InventoryCDLabel { get; }
			public CheckBox IsNonInventory { get; }
			public Label IsNonInventoryLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public PXTextEdit ItemDesc { get; }
			public Label ItemDescLabel { get; }
			public Selector EstimateClassID { get; }
			public Label EstimateClassIDLabel { get; }
			public PXNumberEdit FixedLaborCost { get; }
			public Label FixedLaborCostLabel { get; }
			public CheckBox FixedLaborOverride { get; }
			public Label FixedLaborOverrideLabel { get; }
			public PXNumberEdit VariableLaborCost { get; }
			public Label VariableLaborCostLabel { get; }
			public CheckBox VariableLaborOverride { get; }
			public Label VariableLaborOverrideLabel { get; }
			public PXNumberEdit MachineCost { get; }
			public Label MachineCostLabel { get; }
			public CheckBox MachineOverride { get; }
			public Label MachineOverrideLabel { get; }
			public PXNumberEdit MaterialCost { get; }
			public Label MaterialCostLabel { get; }
			public CheckBox MaterialOverride { get; }
			public Label MaterialOverrideLabel { get; }
			public PXNumberEdit ToolCost { get; }
			public Label ToolCostLabel { get; }
			public CheckBox ToolOverride { get; }
			public Label ToolOverrideLabel { get; }
			public PXNumberEdit FixedOverheadCost { get; }
			public Label FixedOverheadCostLabel { get; }
			public CheckBox FixedOverheadOverride { get; }
			public Label FixedOverheadOverrideLabel { get; }
			public PXNumberEdit VariableOverheadCost { get; }
			public Label VariableOverheadCostLabel { get; }
			public CheckBox VariableOverheadOverride { get; }
			public Label VariableOverheadOverrideLabel { get; }
			public PXNumberEdit SubcontractCost { get; }
			public Label SubcontractCostLabel { get; }
			public CheckBox SubcontractOverride { get; }
			public Label SubcontractOverrideLabel { get; }
			public PXNumberEdit ExtCostDisplay { get; }
			public Label ExtCostDisplayLabel { get; }
			public PXNumberEdit ReferenceMaterialCost { get; }
			public Label ReferenceMaterialCostLabel { get; }
			public PXNumberEdit OrderQty { get; }
			public Label OrderQtyLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public Label CuryUnitCostLabel { get; }
			public PXNumberEdit MarkupPct { get; }
			public Label MarkupPctLabel { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public Label CuryUnitPriceLabel { get; }
			public CheckBox PriceOverride { get; }
			public Label PriceOverrideLabel { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public Label CuryExtPriceLabel { get; }
            
            public c_selectedestimaterecord_quickestimateform(string locator, string name) : 
                    base(locator, name)
            {
                EstimateID = new Selector("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickEstimateID", "Estimate ID", locator, null);
                EstimateIDLabel = new Label(EstimateID);
                EstimateID.DataField = "EstimateID";
                RevisionID = new Selector("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickRevisionID", "Revision ID", locator, null);
                RevisionIDLabel = new Label(RevisionID);
                RevisionID.DataField = "RevisionID";
                InventoryCD = new Selector("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelInventoryCD", "Inventory CD", locator, null);
                InventoryCDLabel = new Label(InventoryCD);
                InventoryCD.DataField = "InventoryCD";
                IsNonInventory = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelIsNonInventory", "Is Non Inventory", locator, null);
                IsNonInventoryLabel = new Label(IsNonInventory);
                IsNonInventory.DataField = "IsNonInventory";
                SubItemID = new Selector("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edSubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                SiteID = new Selector("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                ItemDesc = new PXTextEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelItemDesc", "Item Desc", locator, null);
                ItemDescLabel = new Label(ItemDesc);
                ItemDesc.DataField = "ItemDesc";
                EstimateClassID = new Selector("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelEstimateClassID", "Estimate Class ID", locator, null);
                EstimateClassIDLabel = new Label(EstimateClassID);
                EstimateClassID.DataField = "EstimateClassID";
                FixedLaborCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edFixedLaborCost", "Fixed Labor Cost", locator, null);
                FixedLaborCostLabel = new Label(FixedLaborCost);
                FixedLaborCost.DataField = "FixedLaborCost";
                FixedLaborOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edFixedLaborOverride", "Fixed Labor Override", locator, null);
                FixedLaborOverrideLabel = new Label(FixedLaborOverride);
                FixedLaborOverride.DataField = "FixedLaborOverride";
                VariableLaborCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edVariableLaborCost", "Variable Labor Cost", locator, null);
                VariableLaborCostLabel = new Label(VariableLaborCost);
                VariableLaborCost.DataField = "VariableLaborCost";
                VariableLaborOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edVariableLaborOverride", "Variable Labor Override", locator, null);
                VariableLaborOverrideLabel = new Label(VariableLaborOverride);
                VariableLaborOverride.DataField = "VariableLaborOverride";
                MachineCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edMachineCost", "Machine Cost", locator, null);
                MachineCostLabel = new Label(MachineCost);
                MachineCost.DataField = "MachineCost";
                MachineOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edMachineOverride", "Machine Override", locator, null);
                MachineOverrideLabel = new Label(MachineOverride);
                MachineOverride.DataField = "MachineOverride";
                MaterialCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edMaterialCost", "Material Cost", locator, null);
                MaterialCostLabel = new Label(MaterialCost);
                MaterialCost.DataField = "MaterialCost";
                MaterialOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edMaterialOverride", "Material Override", locator, null);
                MaterialOverrideLabel = new Label(MaterialOverride);
                MaterialOverride.DataField = "MaterialOverride";
                ToolCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edToolCost", "Tool Cost", locator, null);
                ToolCostLabel = new Label(ToolCost);
                ToolCost.DataField = "ToolCost";
                ToolOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edToolOverride", "Tool Override", locator, null);
                ToolOverrideLabel = new Label(ToolOverride);
                ToolOverride.DataField = "ToolOverride";
                FixedOverheadCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edFixedOverheadCost", "Fixed Overhead Cost", locator, null);
                FixedOverheadCostLabel = new Label(FixedOverheadCost);
                FixedOverheadCost.DataField = "FixedOverheadCost";
                FixedOverheadOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edFixedOverheadOverride", "Fixed Overhead Override", locator, null);
                FixedOverheadOverrideLabel = new Label(FixedOverheadOverride);
                FixedOverheadOverride.DataField = "FixedOverheadOverride";
                VariableOverheadCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edVariableOverheadCost", "Variable Overhead Cost", locator, null);
                VariableOverheadCostLabel = new Label(VariableOverheadCost);
                VariableOverheadCost.DataField = "VariableOverheadCost";
                VariableOverheadOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edVariableOverheadOverride", "Variable Overhead Override", locator, null);
                VariableOverheadOverrideLabel = new Label(VariableOverheadOverride);
                VariableOverheadOverride.DataField = "VariableOverheadOverride";
                SubcontractCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edSubcontractCost", "Subcontract Cost", locator, null);
                SubcontractCostLabel = new Label(SubcontractCost);
                SubcontractCost.DataField = "SubcontractCost";
                SubcontractOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edSubcontractOverride", "Subcontract Override", locator, null);
                SubcontractOverrideLabel = new Label(SubcontractOverride);
                SubcontractOverride.DataField = "SubcontractOverride";
                ExtCostDisplay = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edCuryExtCost", "Ext Cost Display", locator, null);
                ExtCostDisplayLabel = new Label(ExtCostDisplay);
                ExtCostDisplay.DataField = "ExtCostDisplay";
                ReferenceMaterialCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edReferenceMaterialCost", "Reference Material Cost", locator, null);
                ReferenceMaterialCostLabel = new Label(ReferenceMaterialCost);
                ReferenceMaterialCost.DataField = "ReferenceMaterialCost";
                OrderQty = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickOrderQty", "Order Qty", locator, null);
                OrderQtyLabel = new Label(OrderQty);
                OrderQty.DataField = "OrderQty";
                UOM = new Selector("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                CuryUnitCost = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickCuryUnitCost", "Cury Unit Cost", locator, null);
                CuryUnitCostLabel = new Label(CuryUnitCost);
                CuryUnitCost.DataField = "CuryUnitCost";
                MarkupPct = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickMarkupPct", "Markup Pct", locator, null);
                MarkupPctLabel = new Label(MarkupPct);
                MarkupPct.DataField = "MarkupPct";
                CuryUnitPrice = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickCuryUnitPrice", "Cury Unit Price", locator, null);
                CuryUnitPriceLabel = new Label(CuryUnitPrice);
                CuryUnitPrice.DataField = "CuryUnitPrice";
                PriceOverride = new CheckBox("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_edQuick1", "Price Override", locator, null);
                PriceOverrideLabel = new Label(PriceOverride);
                PriceOverride.DataField = "PriceOverride";
                CuryExtPrice = new PXNumberEdit("ctl00_phG_QuickEstimatePanel_QuickEstimateForm_panelQuickCuryExtPrice", "Cury Ext Price", locator, null);
                CuryExtPriceLabel = new Label(CuryExtPrice);
                CuryExtPrice.DataField = "CuryExtPrice";
                DataMemberName = "SelectedEstimateRecord";
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
                    Ok = new Button("ctl00_phG_QuickEstimatePanel_QuickEstButton1", "OK", "ctl00_phG_QuickEstimatePanel_QuickEstimateForm");
                    Cancel = new Button("ctl00_phG_QuickEstimatePanel_QuickEstButton2", "Cancel", "ctl00_phG_QuickEstimatePanel_QuickEstimateForm");
                }
            }
        }
        
        public class c_orderestimateitemfilter_estimateaddform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector EstimateID { get; }
			public Label EstimateIDLabel { get; }
			public CheckBox AddExisting { get; }
			public Label AddExistingLabel { get; }
			public Selector RevisionID { get; }
			public Label RevisionIDLabel { get; }
			public Selector InventoryCD { get; }
			public Label InventoryCDLabel { get; }
			public CheckBox IsNonInventory { get; }
			public Label IsNonInventoryLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public PXTextEdit ItemDesc { get; }
			public Label ItemDescLabel { get; }
			public Selector EstimateClassID { get; }
			public Label EstimateClassIDLabel { get; }
			public Selector ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
            
            public c_orderestimateitemfilter_estimateaddform(string locator, string name) : 
                    base(locator, name)
            {
                EstimateID = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_panelEstimateID", "Estimate ID", locator, null);
                EstimateIDLabel = new Label(EstimateID);
                EstimateID.DataField = "EstimateID";
                AddExisting = new CheckBox("ctl00_phG_AddEstimatePanel_estimateAddForm_panelAddExisting", "Add Existing", locator, null);
                AddExistingLabel = new Label(AddExisting);
                AddExisting.DataField = "AddExisting";
                RevisionID = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_panelRevisionID", "Revision ID", locator, null);
                RevisionIDLabel = new Label(RevisionID);
                RevisionID.DataField = "RevisionID";
                InventoryCD = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_panelInventoryCD", "Inventory CD", locator, null);
                InventoryCDLabel = new Label(InventoryCD);
                InventoryCD.DataField = "InventoryCD";
                IsNonInventory = new CheckBox("ctl00_phG_AddEstimatePanel_estimateAddForm_panelEstimateIsNonInventory", "Is Non Inventory", locator, null);
                IsNonInventoryLabel = new Label(IsNonInventory);
                IsNonInventory.DataField = "IsNonInventory";
                SubItemID = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_edSubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                SiteID = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_edSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                ItemDesc = new PXTextEdit("ctl00_phG_AddEstimatePanel_estimateAddForm_panelItemDesc", "Item Desc", locator, null);
                ItemDescLabel = new Label(ItemDesc);
                ItemDesc.DataField = "ItemDesc";
                EstimateClassID = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_panelEstimateClassID", "Estimate Class ID", locator, null);
                EstimateClassIDLabel = new Label(EstimateClassID);
                EstimateClassID.DataField = "EstimateClassID";
                ItemClassID = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_panelItemClassID", "Item Class ID", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                UOM = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_panelEstimateUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                BranchID = new Selector("ctl00_phG_AddEstimatePanel_estimateAddForm_panelBranchID", "Branch ID", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                DataMemberName = "OrderEstimateItemFilter";
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
                    Ok = new Button("ctl00_phG_AddEstimatePanel_AddEstButton1", "OK", "ctl00_phG_AddEstimatePanel_estimateAddForm");
                    Cancel = new Button("ctl00_phG_AddEstimatePanel_AddEstButton2", "Cancel", "ctl00_phG_AddEstimatePanel_estimateAddForm");
                }
            }
        }
        
        public class c_createserviceorderfilter_formcreateserviceorder : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SrvOrdType { get; }
			public Label SrvOrdTypeLabel { get; }
			public Selector AssignedEmpID { get; }
			public Label AssignedEmpIDLabel { get; }
			public DateSelector SLAETA_Date { get; }
			public Label SLAETA_DateLabel { get; }
			public DateSelector SLAETA_Time { get; }
			public Label SLAETA_TimeLabel { get; }
            
            public c_createserviceorderfilter_formcreateserviceorder(string locator, string name) : 
                    base(locator, name)
            {
                SrvOrdType = new Selector("ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder_edSrvOrdType", "Srv Ord Type", locator, null);
                SrvOrdTypeLabel = new Label(SrvOrdType);
                SrvOrdType.DataField = "SrvOrdType";
                AssignedEmpID = new Selector("ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder_edAssignedEmpID", "Assigned Emp ID", locator, null);
                AssignedEmpIDLabel = new Label(AssignedEmpID);
                AssignedEmpID.DataField = "AssignedEmpID";
                SLAETA_Date = new DateSelector("ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder_edSLAETA_Date", "SLAETA _ Date", locator, null);
                SLAETA_DateLabel = new Label(SLAETA_Date);
                SLAETA_Date.DataField = "SLAETA_Date";
                SLAETA_Time = new DateSelector("ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder_edSLAETA_Time", "SLAETA _ Time", locator, null);
                SLAETA_TimeLabel = new Label(SLAETA_Time);
                SLAETA_Time.DataField = "SLAETA_Time";
                DataMemberName = "CreateServiceOrderFilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void SrvOrdTypeEdit()
            {
                Buttons.SrvOrdTypeEdit.Click();
            }
            
            public virtual void AssignedEmpIDEdit()
            {
                Buttons.AssignedEmpIDEdit.Click();
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
                
			public Button SrvOrdTypeEdit { get; }
			public Button AssignedEmpIDEdit { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    SrvOrdTypeEdit = new Button("css=div[id=\'ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder_edSrvOrdType" +
                            "\'] div[class=\'editBtnCont\'] > div > div", "SrvOrdTypeEdit", "ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder");
                    SrvOrdTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AssignedEmpIDEdit = new Button("css=div[id=\'ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder_edAssignedEm" +
                            "pID\'] div[class=\'editBtnCont\'] > div > div", "AssignedEmpIDEdit", "ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder");
                    AssignedEmpIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    Ok = new Button("ctl00_phG_panelCreateServiceOrder_btnSave2", "OK", "ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder");
                    Cancel = new Button("ctl00_phG_panelCreateServiceOrder_btnCancel2", "Cancel", "ctl00_phG_panelCreateServiceOrder_formCreateServiceOrder");
                }
            }
        }
        
        public class c_workflowview_workflowfictivediagram : Container
        {
            
            public PxButtonCollection Buttons;
            
			public UnknownControl Layout { get; }
			public Label LayoutLabel { get; }
            
            public c_workflowview_workflowfictivediagram(string locator, string name) : 
                    base(locator, name)
            {
                Layout = new UnknownControl("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram_diagram", "Layout", locator, null);
                LayoutLabel = new Label(Layout);
                Layout.DataField = "Layout";
                DataMemberName = "WorkflowView";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Customize { get; }
                
                public PxButtonCollection()
                {
                    Customize = new Button("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_PXButtonCustomize", "Customize", "ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram");
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
        
        public class c_processingresults : Container
        {
            
			public Label Content { get; }
            
            public c_processingresults(string locator, string name) : 
                    base(locator, name)
            {
                Content = new Label("ctl00_phDS_ds_pnlQuickInfo_cont", "Content", locator, null);
                DataMemberName = null;
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
