using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.GroupBox;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;

namespace ACSC.Tests.Wrappers.TemplateItem
{
    
    
    public class CS100000_FeaturesMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_features_form Features_form { get; } = new c_features_form("ctl00_phF_form", "Features_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public CS100000_FeaturesMaint()
        {
            ScreenId = "CS100000";
            ScreenUrl = "/Pages/CS/CS100000.aspx";
            ToolBar = new PxToolBar(null);
        }
        
        public virtual CS100000_FeaturesMaint ReadOne(Gate gate, string Status)
        {
            new BiObject<CS100000_FeaturesMaint>(gate).ReadOne(this, Status);
            return this;
        }
        
        public virtual CS100000_FeaturesMaint ReadOne(string Status)
        {
            return this.ReadOne(ApiConnection.Source, Status);
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
        
        public virtual void SaveClose()
        {
            ToolBar.SaveClose.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Insert()
        {
            ToolBar.Insert.Click();
        }
        
        public virtual void RequestValidation()
        {
            ToolBar.RequestValidation.Click();
        }
        
        public virtual void CancelRequest()
        {
            ToolBar.CancelRequest.Click();
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
			public ToolBarButton SaveClose { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton RequestValidation { get; }
			public ToolBarButton CancelRequest { get; }
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
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'SaveClose\']", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'insert\']", "Modify", locator, null);
                RequestValidation = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'requestValidation\']", "Enable", locator, null);
                CancelRequest = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'cancelRequest\']", "Cancel Validation Request", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_features_form : Container
        {
            
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public DateSelector ValidUntill { get; }
			public Label ValidUntillLabel { get; }
			public PXTextEdit LicenseID { get; }
			public Label LicenseIDLabel { get; }
			public CheckBox FinancialModule { get; }
			public Label FinancialModuleLabel { get; }
			public CheckBox FinancialStandard { get; }
			public Label FinancialStandardLabel { get; }
			public CheckBox Branch { get; }
			public Label BranchLabel { get; }
			public CheckBox AccountLocations { get; }
			public Label AccountLocationsLabel { get; }
			public CheckBox Multicurrency { get; }
			public Label MulticurrencyLabel { get; }
			public CheckBox CentralizedPeriodsManagement { get; }
			public Label CentralizedPeriodsManagementLabel { get; }
			public CheckBox SupportBreakQty { get; }
			public Label SupportBreakQtyLabel { get; }
			public CheckBox Prebooking { get; }
			public Label PrebookingLabel { get; }
			public CheckBox TaxEntryFromGL { get; }
			public Label TaxEntryFromGLLabel { get; }
			public CheckBox VATReporting { get; }
			public Label VATReportingLabel { get; }
			public CheckBox Reporting1099 { get; }
			public Label Reporting1099Label { get; }
			public CheckBox NetGrossEntryMode { get; }
			public Label NetGrossEntryModeLabel { get; }
			public CheckBox InvoiceRounding { get; }
			public Label InvoiceRoundingLabel { get; }
			public CheckBox ExpenseManagement { get; }
			public Label ExpenseManagementLabel { get; }
			public CheckBox FinancialAdvanced { get; }
			public Label FinancialAdvancedLabel { get; }
			public CheckBox SubAccount { get; }
			public Label SubAccountLabel { get; }
			public CheckBox AllocationTemplates { get; }
			public Label AllocationTemplatesLabel { get; }
			public CheckBox InterBranch { get; }
			public Label InterBranchLabel { get; }
			public CheckBox MultipleCalendarsSupport { get; }
			public Label MultipleCalendarsSupportLabel { get; }
			public CheckBox GLConsolidation { get; }
			public Label GLConsolidationLabel { get; }
			public CheckBox FinStatementCurTranslation { get; }
			public Label FinStatementCurTranslationLabel { get; }
			public CheckBox CustomerDiscounts { get; }
			public Label CustomerDiscountsLabel { get; }
			public CheckBox VendorDiscounts { get; }
			public Label VendorDiscountsLabel { get; }
			public CheckBox Commissions { get; }
			public Label CommissionsLabel { get; }
			public CheckBox OverdueFinCharges { get; }
			public Label OverdueFinChargesLabel { get; }
			public CheckBox DunningLetter { get; }
			public Label DunningLetterLabel { get; }
			public CheckBox DefferedRevenue { get; }
			public Label DefferedRevenueLabel { get; }
			public CheckBox ASC606 { get; }
			public Label ASC606Label { get; }
			public CheckBox ParentChildAccount { get; }
			public Label ParentChildAccountLabel { get; }
			public CheckBox Retainage { get; }
			public Label RetainageLabel { get; }
			public CheckBox PaymentsByLines { get; }
			public Label PaymentsByLinesLabel { get; }
			public CheckBox ContractManagement { get; }
			public Label ContractManagementLabel { get; }
			public CheckBox FixedAsset { get; }
			public Label FixedAssetLabel { get; }
			public CheckBox MiscModule { get; }
			public Label MiscModuleLabel { get; }
			public CheckBox TimeReportingModule { get; }
			public Label TimeReportingModuleLabel { get; }
			public CheckBox ApprovalWorkflow { get; }
			public Label ApprovalWorkflowLabel { get; }
			public CheckBox FieldLevelLogging { get; }
			public Label FieldLevelLoggingLabel { get; }
			public CheckBox RowLevelSecurity { get; }
			public Label RowLevelSecurityLabel { get; }
			public CheckBox ScheduleModule { get; }
			public Label ScheduleModuleLabel { get; }
			public CheckBox NotificationModule { get; }
			public Label NotificationModuleLabel { get; }
			public CheckBox AutomationModule { get; }
			public Label AutomationModuleLabel { get; }
			public CheckBox DeviceHub { get; }
			public Label DeviceHubLabel { get; }
			public CheckBox GDPRCompliance { get; }
			public Label GDPRComplianceLabel { get; }
			public CheckBox SecureBusinessDate { get; }
			public Label SecureBusinessDateLabel { get; }
			public CheckBox DistributionModule { get; }
			public Label DistributionModuleLabel { get; }
			public CheckBox Inventory { get; }
			public Label InventoryLabel { get; }
			public CheckBox MultipleUnitMeasure { get; }
			public Label MultipleUnitMeasureLabel { get; }
			public CheckBox LotSerialTracking { get; }
			public Label LotSerialTrackingLabel { get; }
			public CheckBox BlanketPO { get; }
			public Label BlanketPOLabel { get; }
			public CheckBox DropShipments { get; }
			public Label DropShipmentsLabel { get; }
			public CheckBox Warehouse { get; }
			public Label WarehouseLabel { get; }
			public CheckBox WarehouseLocation { get; }
			public Label WarehouseLocationLabel { get; }
			public CheckBox Replenishment { get; }
			public Label ReplenishmentLabel { get; }
			public CheckBox MatrixItem { get; }
			public Label MatrixItemLabel { get; }
			public CheckBox SubItem { get; }
			public Label SubItemLabel { get; }
			public CheckBox AutoPackaging { get; }
			public Label AutoPackagingLabel { get; }
			public CheckBox KitAssemblies { get; }
			public Label KitAssembliesLabel { get; }
			public CheckBox AdvancedPhysicalCounts { get; }
			public Label AdvancedPhysicalCountsLabel { get; }
			public CheckBox SOToPOLink { get; }
			public Label SOToPOLinkLabel { get; }
			public CheckBox UserDefinedOrderTypes { get; }
			public Label UserDefinedOrderTypesLabel { get; }
			public CheckBox PurchaseRequisitions { get; }
			public Label PurchaseRequisitionsLabel { get; }
			public CheckBox AdvancedSOInvoices { get; }
			public Label AdvancedSOInvoicesLabel { get; }
			public CheckBox VendorRelations { get; }
			public Label VendorRelationsLabel { get; }
			public CheckBox AdvancedFulfillment { get; }
			public Label AdvancedFulfillmentLabel { get; }
			public CheckBox WMSFulfillment { get; }
			public Label WMSFulfillmentLabel { get; }
			public CheckBox WMSAdvancedPicking { get; }
			public Label WMSAdvancedPickingLabel { get; }
			public CheckBox WMSReceiving { get; }
			public Label WMSReceivingLabel { get; }
			public CheckBox WMSInventory { get; }
			public Label WMSInventoryLabel { get; }
			public CheckBox WMSCartTracking { get; }
			public Label WMSCartTrackingLabel { get; }
			public CheckBox CustomerModule { get; }
			public Label CustomerModuleLabel { get; }
			public CheckBox CaseManagement { get; }
			public Label CaseManagementLabel { get; }
			public CheckBox ContactDuplicate { get; }
			public Label ContactDuplicateLabel { get; }
			public CheckBox SalesQuotes { get; }
			public Label SalesQuotesLabel { get; }
			public CheckBox OutlookIntegration { get; }
			public Label OutlookIntegrationLabel { get; }
			public CheckBox ProjectAccounting { get; }
			public Label ProjectAccountingLabel { get; }
			public CheckBox ProjectModule { get; }
			public Label ProjectModuleLabel { get; }
			public CheckBox ChangeOrder { get; }
			public Label ChangeOrderLabel { get; }
			public CheckBox ChangeRequest { get; }
			public Label ChangeRequestLabel { get; }
			public CheckBox BudgetForecast { get; }
			public Label BudgetForecastLabel { get; }
			public CheckBox CostCodes { get; }
			public Label CostCodesLabel { get; }
			public CheckBox ProjectQuotes { get; }
			public Label ProjectQuotesLabel { get; }
			public CheckBox ProjectMultiCurrency { get; }
			public Label ProjectMultiCurrencyLabel { get; }
			public CheckBox Construction { get; }
			public Label ConstructionLabel { get; }
			public CheckBox ConstructionProjectManagement { get; }
			public Label ConstructionProjectManagementLabel { get; }
			public CheckBox PortalModule { get; }
			public Label PortalModuleLabel { get; }
			public CheckBox B2BOrdering { get; }
			public Label B2BOrderingLabel { get; }
			public CheckBox PortalCaseManagement { get; }
			public Label PortalCaseManagementLabel { get; }
			public CheckBox PortalFinancials { get; }
			public Label PortalFinancialsLabel { get; }
			public CheckBox ServiceManagementModule { get; }
			public Label ServiceManagementModuleLabel { get; }
			public CheckBox ServiceManagementStaffMembersPack { get; }
			public Label ServiceManagementStaffMembersPackLabel { get; }
			public CheckBox ServiceManagementStaffMembersPack10 { get; }
			public Label ServiceManagementStaffMembersPack10Label { get; }
			public CheckBox ServiceManagementStaffMembersPack50 { get; }
			public Label ServiceManagementStaffMembersPack50Label { get; }
			public CheckBox ServiceManagementStaffMembersPackUnlimited { get; }
			public Label ServiceManagementStaffMembersPackUnlimitedLabel { get; }
			public CheckBox EquipmentManagementModule { get; }
			public Label EquipmentManagementModuleLabel { get; }
			public CheckBox RouteManagementModule { get; }
			public Label RouteManagementModuleLabel { get; }
			public CheckBox RouteManagementVehiclesPack { get; }
			public Label RouteManagementVehiclesPackLabel { get; }
			public CheckBox RouteManagementVehiclesPack10 { get; }
			public Label RouteManagementVehiclesPack10Label { get; }
			public CheckBox RouteManagementVehiclesPack50 { get; }
			public Label RouteManagementVehiclesPack50Label { get; }
			public CheckBox RouteManagementVehiclesPackUnlimited { get; }
			public Label RouteManagementVehiclesPackUnlimitedLabel { get; }
			public CheckBox CommerceIntegration { get; }
			public Label CommerceIntegrationLabel { get; }
			public CheckBox PayrollModule { get; }
			public Label PayrollModuleLabel { get; }
			public CheckBox IntegrationModule { get; }
			public Label IntegrationModuleLabel { get; }
			public CheckBox CarrierIntegration { get; }
			public Label CarrierIntegrationLabel { get; }
			public CheckBox ExchangeIntegration { get; }
			public Label ExchangeIntegrationLabel { get; }
			public CheckBox AvalaraTax { get; }
			public Label AvalaraTaxLabel { get; }
			public CheckBox AddressValidation { get; }
			public Label AddressValidationLabel { get; }
			public CheckBox SalesforceIntegration { get; }
			public Label SalesforceIntegrationLabel { get; }
			public CheckBox HubSpotIntegration { get; }
			public Label HubSpotIntegrationLabel { get; }
			public CheckBox ProcoreIntegration { get; }
			public Label ProcoreIntegrationLabel { get; }
			public CheckBox ImageRecognition { get; }
			public Label ImageRecognitionLabel { get; }
			public CheckBox RouteOptimizer { get; }
			public Label RouteOptimizerLabel { get; }
			public CheckBox Manufacturing { get; }
			public Label ManufacturingLabel { get; }
			public CheckBox ManufacturingMRP { get; }
			public Label ManufacturingMRPLabel { get; }
			public CheckBox ManufacturingProductConfigurator { get; }
			public Label ManufacturingProductConfiguratorLabel { get; }
			public CheckBox ManufacturingEstimating { get; }
			public Label ManufacturingEstimatingLabel { get; }
			public CheckBox ManufacturingAdvancedPlanning { get; }
			public Label ManufacturingAdvancedPlanningLabel { get; }
			public CheckBox AdvancedAuthentication { get; }
			public Label AdvancedAuthenticationLabel { get; }
			public CheckBox TwoFactorAuthentication { get; }
			public Label TwoFactorAuthenticationLabel { get; }
			public CheckBox GoogleAndMicrosoftSSO { get; }
			public Label GoogleAndMicrosoftSSOLabel { get; }
			public CheckBox ActiveDirectoryAndOtherExternalSSO { get; }
			public Label ActiveDirectoryAndOtherExternalSSOLabel { get; }
            
            public c_features_form(string locator, string name) : 
                    base(locator, name)
            {
                Status = new DropDown("ctl00_phF_form_Status", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("0", "Validated");
                Status.Items.Add("1", "Failed Validation");
                Status.Items.Add("2", "Pending Validation");
                Status.Items.Add("3", "Pending Activation");
                ValidUntill = new DateSelector("ctl00_phF_form_edValidUntill", "Next Validation Date", locator, null);
                ValidUntillLabel = new Label(ValidUntill);
                ValidUntill.DataField = "ValidUntill";
                LicenseID = new PXTextEdit("ctl00_phF_form_edLicnseID", "License ID", locator, null);
                LicenseIDLabel = new Label(LicenseID);
                LicenseID.DataField = "LicenseID";
                FinancialModule = new CheckBox("ctl00_phF_form_FinancialModule", "Finance", locator, null);
                FinancialModuleLabel = new Label(FinancialModule);
                FinancialModule.DataField = "FinancialModule";
                FinancialStandard = new CheckBox("ctl00_phF_form_FinancialStandard", "Standard Financials", locator, null);
                FinancialStandardLabel = new Label(FinancialStandard);
                FinancialStandard.DataField = "FinancialStandard";
                Branch = new CheckBox("ctl00_phF_form_Branch", "Multi-Branch Support", locator, null);
                BranchLabel = new Label(Branch);
                Branch.DataField = "Branch";
                AccountLocations = new CheckBox("ctl00_phF_form_AccountLocations", "Business Account Locations", locator, null);
                AccountLocationsLabel = new Label(AccountLocations);
                AccountLocations.DataField = "AccountLocations";
                Multicurrency = new CheckBox("ctl00_phF_form_Multicurrency", "Multi-Currency Accounting", locator, null);
                MulticurrencyLabel = new Label(Multicurrency);
                Multicurrency.DataField = "Multicurrency";
                CentralizedPeriodsManagement = new CheckBox("ctl00_phF_form_CentralizedPeriodsManagement", "Centralized Period Management", locator, null);
                CentralizedPeriodsManagementLabel = new Label(CentralizedPeriodsManagement);
                CentralizedPeriodsManagement.DataField = "CentralizedPeriodsManagement";
                SupportBreakQty = new CheckBox("ctl00_phF_form_SupportBreakQty", "Volume Pricing", locator, null);
                SupportBreakQtyLabel = new Label(SupportBreakQty);
                SupportBreakQty.DataField = "SupportBreakQty";
                Prebooking = new CheckBox("ctl00_phF_form_Prebooking", "Expense Reclassification", locator, null);
                PrebookingLabel = new Label(Prebooking);
                Prebooking.DataField = "Prebooking";
                TaxEntryFromGL = new CheckBox("ctl00_phF_form_TaxEntryFromGL", "Tax Entry from GL Module", locator, null);
                TaxEntryFromGLLabel = new Label(TaxEntryFromGL);
                TaxEntryFromGL.DataField = "TaxEntryFromGL";
                VATReporting = new CheckBox("ctl00_phF_form_VATReporting", "VAT Reporting", locator, null);
                VATReportingLabel = new Label(VATReporting);
                VATReporting.DataField = "VATReporting";
                Reporting1099 = new CheckBox("ctl00_phF_form_Reporting1099", "1099 Reporting", locator, null);
                Reporting1099Label = new Label(Reporting1099);
                Reporting1099.DataField = "Reporting1099";
                NetGrossEntryMode = new CheckBox("ctl00_phF_form_NetGrossEntryMode", "Net/Gross Entry Mode", locator, null);
                NetGrossEntryModeLabel = new Label(NetGrossEntryMode);
                NetGrossEntryMode.DataField = "NetGrossEntryMode";
                InvoiceRounding = new CheckBox("ctl00_phF_form_InvoiceRounding", "Invoice Rounding", locator, null);
                InvoiceRoundingLabel = new Label(InvoiceRounding);
                InvoiceRounding.DataField = "InvoiceRounding";
                ExpenseManagement = new CheckBox("ctl00_phF_form_ExpenseManagement", "Expense Management", locator, null);
                ExpenseManagementLabel = new Label(ExpenseManagement);
                ExpenseManagement.DataField = "ExpenseManagement";
                FinancialAdvanced = new CheckBox("ctl00_phF_form_FinancialAdvanced", "Advanced Financials", locator, null);
                FinancialAdvancedLabel = new Label(FinancialAdvanced);
                FinancialAdvanced.DataField = "FinancialAdvanced";
                SubAccount = new CheckBox("ctl00_phF_form_SubAccount", "Subaccounts", locator, null);
                SubAccountLabel = new Label(SubAccount);
                SubAccount.DataField = "SubAccount";
                AllocationTemplates = new CheckBox("ctl00_phF_form_AllocationTemplates", "General Ledger Allocation Templates", locator, null);
                AllocationTemplatesLabel = new Label(AllocationTemplates);
                AllocationTemplates.DataField = "AllocationTemplates";
                InterBranch = new CheckBox("ctl00_phF_form_InterBranch", "Inter-Branch Transactions", locator, null);
                InterBranchLabel = new Label(InterBranch);
                InterBranch.DataField = "InterBranch";
                MultipleCalendarsSupport = new CheckBox("ctl00_phF_form_MultipleCalendarsSupport", "Multiple Calendar Support", locator, null);
                MultipleCalendarsSupportLabel = new Label(MultipleCalendarsSupport);
                MultipleCalendarsSupport.DataField = "MultipleCalendarsSupport";
                GLConsolidation = new CheckBox("ctl00_phF_form_GLConsolidation", "General Ledger Consolidation", locator, null);
                GLConsolidationLabel = new Label(GLConsolidation);
                GLConsolidation.DataField = "GLConsolidation";
                FinStatementCurTranslation = new CheckBox("ctl00_phF_form_FinStatementCurTranslation", "Translation of Financial Statements", locator, null);
                FinStatementCurTranslationLabel = new Label(FinStatementCurTranslation);
                FinStatementCurTranslation.DataField = "FinStatementCurTranslation";
                CustomerDiscounts = new CheckBox("ctl00_phF_form_CustomerDiscounts", "Customer Discounts", locator, null);
                CustomerDiscountsLabel = new Label(CustomerDiscounts);
                CustomerDiscounts.DataField = "CustomerDiscounts";
                VendorDiscounts = new CheckBox("ctl00_phF_form_VendorDiscounts", "Vendor Discounts", locator, null);
                VendorDiscountsLabel = new Label(VendorDiscounts);
                VendorDiscounts.DataField = "VendorDiscounts";
                Commissions = new CheckBox("ctl00_phF_form_Commissions", "Commissions", locator, null);
                CommissionsLabel = new Label(Commissions);
                Commissions.DataField = "Commissions";
                OverdueFinCharges = new CheckBox("ctl00_phF_form_OverdueFinCharges", "Overdue Charges", locator, null);
                OverdueFinChargesLabel = new Label(OverdueFinCharges);
                OverdueFinCharges.DataField = "OverdueFinCharges";
                DunningLetter = new CheckBox("ctl00_phF_form_DunningLetter", "Dunning Letter Management", locator, null);
                DunningLetterLabel = new Label(DunningLetter);
                DunningLetter.DataField = "DunningLetter";
                DefferedRevenue = new CheckBox("ctl00_phF_form_DefferedRevenue", "Deferred Revenue Management", locator, null);
                DefferedRevenueLabel = new Label(DefferedRevenue);
                DefferedRevenue.DataField = "DefferedRevenue";
                ASC606 = new CheckBox("ctl00_phF_form_ASC606", "Revenue Recognition by IFRS 15/ASC 606", locator, null);
                ASC606Label = new Label(ASC606);
                ASC606.DataField = "ASC606";
                ParentChildAccount = new CheckBox("ctl00_phF_form_ParentChildAccount", "Parent-Child Customer Relationship", locator, null);
                ParentChildAccountLabel = new Label(ParentChildAccount);
                ParentChildAccount.DataField = "ParentChildAccount";
                Retainage = new CheckBox("ctl00_phF_form_Retainage", "Retainage Support", locator, null);
                RetainageLabel = new Label(Retainage);
                Retainage.DataField = "Retainage";
                PaymentsByLines = new CheckBox("ctl00_phF_form_PaymentsByLines", "Payment Application by Line", locator, null);
                PaymentsByLinesLabel = new Label(PaymentsByLines);
                PaymentsByLines.DataField = "PaymentsByLines";
                ContractManagement = new CheckBox("ctl00_phF_form_ContractManagement", "Contract Management", locator, null);
                ContractManagementLabel = new Label(ContractManagement);
                ContractManagement.DataField = "ContractManagement";
                FixedAsset = new CheckBox("ctl00_phF_form_FixedAsset", "Fixed Asset Management", locator, null);
                FixedAssetLabel = new Label(FixedAsset);
                FixedAsset.DataField = "FixedAsset";
                MiscModule = new CheckBox("ctl00_phF_form_MiscModule", "Monitoring & Automation", locator, null);
                MiscModuleLabel = new Label(MiscModule);
                MiscModule.DataField = "MiscModule";
                TimeReportingModule = new CheckBox("ctl00_phF_form_TimeReportingModule", "Time Reporting on Activity", locator, null);
                TimeReportingModuleLabel = new Label(TimeReportingModule);
                TimeReportingModule.DataField = "TimeReportingModule";
                ApprovalWorkflow = new CheckBox("ctl00_phF_form_ApprovalWorkflow", "Approval Workflow", locator, null);
                ApprovalWorkflowLabel = new Label(ApprovalWorkflow);
                ApprovalWorkflow.DataField = "ApprovalWorkflow";
                FieldLevelLogging = new CheckBox("ctl00_phF_form_FieldLevelLogging", "Field-Level Audit", locator, null);
                FieldLevelLoggingLabel = new Label(FieldLevelLogging);
                FieldLevelLogging.DataField = "FieldLevelLogging";
                RowLevelSecurity = new CheckBox("ctl00_phF_form_RowLevelSecurity", "Row-Level Security", locator, null);
                RowLevelSecurityLabel = new Label(RowLevelSecurity);
                RowLevelSecurity.DataField = "RowLevelSecurity";
                ScheduleModule = new CheckBox("ctl00_phF_form_ScheduleModule", "Scheduled Processing", locator, null);
                ScheduleModuleLabel = new Label(ScheduleModule);
                ScheduleModule.DataField = "ScheduleModule";
                NotificationModule = new CheckBox("ctl00_phF_form_NotificationModule", "Change Notifications", locator, null);
                NotificationModuleLabel = new Label(NotificationModule);
                NotificationModule.DataField = "NotificationModule";
                AutomationModule = new CheckBox("ctl00_phF_form_AutomationModule", "Workflow Automation", locator, null);
                AutomationModuleLabel = new Label(AutomationModule);
                AutomationModule.DataField = "AutomationModule";
                DeviceHub = new CheckBox("ctl00_phF_form_DeviceHub", "DeviceHub", locator, null);
                DeviceHubLabel = new Label(DeviceHub);
                DeviceHub.DataField = "DeviceHub";
                GDPRCompliance = new CheckBox("ctl00_phF_form_GDPRCompliance", "GDPR Compliance Tools", locator, null);
                GDPRComplianceLabel = new Label(GDPRCompliance);
                GDPRCompliance.DataField = "GDPRCompliance";
                SecureBusinessDate = new CheckBox("ctl00_phF_form_SecureBusinessDate", "Secure Business Date", locator, null);
                SecureBusinessDateLabel = new Label(SecureBusinessDate);
                SecureBusinessDate.DataField = "SecureBusinessDate";
                DistributionModule = new CheckBox("ctl00_phF_form_DistributionModule", "Inventory and Order Management", locator, null);
                DistributionModuleLabel = new Label(DistributionModule);
                DistributionModule.DataField = "DistributionModule";
                Inventory = new CheckBox("ctl00_phF_form_Inventory", "Inventory", locator, null);
                InventoryLabel = new Label(Inventory);
                Inventory.DataField = "Inventory";
                MultipleUnitMeasure = new CheckBox("ctl00_phF_form_MultipleUnitMeasure", "Multiple Units of Measure", locator, null);
                MultipleUnitMeasureLabel = new Label(MultipleUnitMeasure);
                MultipleUnitMeasure.DataField = "MultipleUnitMeasure";
                LotSerialTracking = new CheckBox("ctl00_phF_form_LotSerialTracking", "Lot and Serial Tracking", locator, null);
                LotSerialTrackingLabel = new Label(LotSerialTracking);
                LotSerialTracking.DataField = "LotSerialTracking";
                BlanketPO = new CheckBox("ctl00_phF_form_BlanketPO", "Blanket and Standard Purchase Orders", locator, null);
                BlanketPOLabel = new Label(BlanketPO);
                BlanketPO.DataField = "BlanketPO";
                DropShipments = new CheckBox("ctl00_phF_form_DropShipments", "Drop Shipments", locator, null);
                DropShipmentsLabel = new Label(DropShipments);
                DropShipments.DataField = "DropShipments";
                Warehouse = new CheckBox("ctl00_phF_form_Warehouse", "Multiple Warehouses", locator, null);
                WarehouseLabel = new Label(Warehouse);
                Warehouse.DataField = "Warehouse";
                WarehouseLocation = new CheckBox("ctl00_phF_form_WarehouseLocation", "Multiple Warehouse Locations", locator, null);
                WarehouseLocationLabel = new Label(WarehouseLocation);
                WarehouseLocation.DataField = "WarehouseLocation";
                Replenishment = new CheckBox("ctl00_phF_form_Replenishment", "Inventory Replenishment", locator, null);
                ReplenishmentLabel = new Label(Replenishment);
                Replenishment.DataField = "Replenishment";
                MatrixItem = new CheckBox("ctl00_phF_form_MatrixItem", "Matrix Items", locator, null);
                MatrixItemLabel = new Label(MatrixItem);
                MatrixItem.DataField = "MatrixItem";
                SubItem = new CheckBox("ctl00_phF_form_SubItem", "Inventory Subitems", locator, null);
                SubItemLabel = new Label(SubItem);
                SubItem.DataField = "SubItem";
                AutoPackaging = new CheckBox("ctl00_phF_form_AutoPackaging", "Automatic Packaging", locator, null);
                AutoPackagingLabel = new Label(AutoPackaging);
                AutoPackaging.DataField = "AutoPackaging";
                KitAssemblies = new CheckBox("ctl00_phF_form_KitAssemblies", "Kit Assembly", locator, null);
                KitAssembliesLabel = new Label(KitAssemblies);
                KitAssemblies.DataField = "KitAssemblies";
                AdvancedPhysicalCounts = new CheckBox("ctl00_phF_form_AdvancedPhysicalCounts", "Advanced Physical Count", locator, null);
                AdvancedPhysicalCountsLabel = new Label(AdvancedPhysicalCounts);
                AdvancedPhysicalCounts.DataField = "AdvancedPhysicalCounts";
                SOToPOLink = new CheckBox("ctl00_phF_form_SOToPOLink", "Sales Order to Purchase Order Link", locator, null);
                SOToPOLinkLabel = new Label(SOToPOLink);
                SOToPOLink.DataField = "SOToPOLink";
                UserDefinedOrderTypes = new CheckBox("ctl00_phF_form_UserDefinedOrderTypes", "Custom Order Types", locator, null);
                UserDefinedOrderTypesLabel = new Label(UserDefinedOrderTypes);
                UserDefinedOrderTypes.DataField = "UserDefinedOrderTypes";
                PurchaseRequisitions = new CheckBox("ctl00_phF_form_PurchaseRequisitions", "Purchase Requisitions", locator, null);
                PurchaseRequisitionsLabel = new Label(PurchaseRequisitions);
                PurchaseRequisitions.DataField = "PurchaseRequisitions";
                AdvancedSOInvoices = new CheckBox("ctl00_phF_form_AdvancedSOInvoices", "Advanced SO Invoices", locator, null);
                AdvancedSOInvoicesLabel = new Label(AdvancedSOInvoices);
                AdvancedSOInvoices.DataField = "AdvancedSOInvoices";
                VendorRelations = new CheckBox("ctl00_phF_form_VendorRelations", "Vendor Relations", locator, null);
                VendorRelationsLabel = new Label(VendorRelations);
                VendorRelations.DataField = "VendorRelations";
                AdvancedFulfillment = new CheckBox("ctl00_phF_form_AdvancedFulfillment", "Warehouse Management", locator, null);
                AdvancedFulfillmentLabel = new Label(AdvancedFulfillment);
                AdvancedFulfillment.DataField = "AdvancedFulfillment";
                WMSFulfillment = new CheckBox("ctl00_phF_form_WMSFulfillment", "Fulfillment", locator, null);
                WMSFulfillmentLabel = new Label(WMSFulfillment);
                WMSFulfillment.DataField = "WMSFulfillment";
                WMSAdvancedPicking = new CheckBox("ctl00_phF_form_WMSAdvancedPicking", "Advanced Picking", locator, null);
                WMSAdvancedPickingLabel = new Label(WMSAdvancedPicking);
                WMSAdvancedPicking.DataField = "WMSAdvancedPicking";
                WMSReceiving = new CheckBox("ctl00_phF_form_WMSReceiving", "Receiving", locator, null);
                WMSReceivingLabel = new Label(WMSReceiving);
                WMSReceiving.DataField = "WMSReceiving";
                WMSInventory = new CheckBox("ctl00_phF_form_WMSInventory", "Inventory Operations", locator, null);
                WMSInventoryLabel = new Label(WMSInventory);
                WMSInventory.DataField = "WMSInventory";
                WMSCartTracking = new CheckBox("ctl00_phF_form_WMSCartTracking", "Cart Tracking", locator, null);
                WMSCartTrackingLabel = new Label(WMSCartTracking);
                WMSCartTracking.DataField = "WMSCartTracking";
                CustomerModule = new CheckBox("ctl00_phF_form_CustomerModule", "Customer Management", locator, null);
                CustomerModuleLabel = new Label(CustomerModule);
                CustomerModule.DataField = "CustomerModule";
                CaseManagement = new CheckBox("ctl00_phF_form_CaseManagement", "Case Management", locator, null);
                CaseManagementLabel = new Label(CaseManagement);
                CaseManagement.DataField = "CaseManagement";
                ContactDuplicate = new CheckBox("ctl00_phF_form_ContactDuplicate", "Lead/Contact Duplicate Validation", locator, null);
                ContactDuplicateLabel = new Label(ContactDuplicate);
                ContactDuplicate.DataField = "ContactDuplicate";
                SalesQuotes = new CheckBox("ctl00_phF_form_SalesQuotes", "Sales Quotes", locator, null);
                SalesQuotesLabel = new Label(SalesQuotes);
                SalesQuotes.DataField = "SalesQuotes";
                OutlookIntegration = new CheckBox("ctl00_phF_form_OutlookIntegration", "Outlook Integration", locator, null);
                OutlookIntegrationLabel = new Label(OutlookIntegration);
                OutlookIntegration.DataField = "OutlookIntegration";
                ProjectAccounting = new CheckBox("ctl00_phF_form_ProjectAccounting", "Projects", locator, null);
                ProjectAccountingLabel = new Label(ProjectAccounting);
                ProjectAccounting.DataField = "ProjectAccounting";
                ProjectModule = new CheckBox("ctl00_phF_form_ProjectModule", "Project Accounting", locator, null);
                ProjectModuleLabel = new Label(ProjectModule);
                ProjectModule.DataField = "ProjectModule";
                ChangeOrder = new CheckBox("ctl00_phF_form_ChangeOrder", "Change Orders", locator, null);
                ChangeOrderLabel = new Label(ChangeOrder);
                ChangeOrder.DataField = "ChangeOrder";
                ChangeRequest = new CheckBox("ctl00_phF_form_ChangeRequest", "Change Requests", locator, null);
                ChangeRequestLabel = new Label(ChangeRequest);
                ChangeRequest.DataField = "ChangeRequest";
                BudgetForecast = new CheckBox("ctl00_phF_form_BudgetForecast", "Budget Forecast", locator, null);
                BudgetForecastLabel = new Label(BudgetForecast);
                BudgetForecast.DataField = "BudgetForecast";
                CostCodes = new CheckBox("ctl00_phF_form_CostCodes", "Cost Codes", locator, null);
                CostCodesLabel = new Label(CostCodes);
                CostCodes.DataField = "CostCodes";
                ProjectQuotes = new CheckBox("ctl00_phF_form_ProjectQuotes", "Project Quotes", locator, null);
                ProjectQuotesLabel = new Label(ProjectQuotes);
                ProjectQuotes.DataField = "ProjectQuotes";
                ProjectMultiCurrency = new CheckBox("ctl00_phF_form_ProjectMultiCurrency", "Multi-Currency Projects", locator, null);
                ProjectMultiCurrencyLabel = new Label(ProjectMultiCurrency);
                ProjectMultiCurrency.DataField = "ProjectMultiCurrency";
                Construction = new CheckBox("ctl00_phF_form_Construction", "Construction", locator, null);
                ConstructionLabel = new Label(Construction);
                Construction.DataField = "Construction";
                ConstructionProjectManagement = new CheckBox("ctl00_phF_form_ConstructionProjectManagement", "Construction Project Management", locator, null);
                ConstructionProjectManagementLabel = new Label(ConstructionProjectManagement);
                ConstructionProjectManagement.DataField = "ConstructionProjectManagement";
                PortalModule = new CheckBox("ctl00_phF_form_PortalModule", "Customer Portal", locator, null);
                PortalModuleLabel = new Label(PortalModule);
                PortalModule.DataField = "PortalModule";
                B2BOrdering = new CheckBox("ctl00_phF_form_B2BOrdering", "B2B Ordering", locator, null);
                B2BOrderingLabel = new Label(B2BOrdering);
                B2BOrdering.DataField = "B2BOrdering";
                PortalCaseManagement = new CheckBox("ctl00_phF_form_PortalCaseManagement", "Case Management on Portal", locator, null);
                PortalCaseManagementLabel = new Label(PortalCaseManagement);
                PortalCaseManagement.DataField = "PortalCaseManagement";
                PortalFinancials = new CheckBox("ctl00_phF_form_PortalFinancials", "Financials on Portal", locator, null);
                PortalFinancialsLabel = new Label(PortalFinancials);
                PortalFinancials.DataField = "PortalFinancials";
                ServiceManagementModule = new CheckBox("ctl00_phF_form_ServiceManagementModule", "Service Management", locator, null);
                ServiceManagementModuleLabel = new Label(ServiceManagementModule);
                ServiceManagementModule.DataField = "ServiceManagementModule";
                ServiceManagementStaffMembersPack = new CheckBox("ctl00_phF_form_ServiceManagementStaffMembersPack", "Staff Member Pack", locator, null);
                ServiceManagementStaffMembersPackLabel = new Label(ServiceManagementStaffMembersPack);
                ServiceManagementStaffMembersPack.DataField = "ServiceManagementStaffMembersPack";
                ServiceManagementStaffMembersPack10 = new CheckBox("ctl00_phF_form_ServiceManagementStaffMembersPack10", "10 Staff Members", locator, null);
                ServiceManagementStaffMembersPack10Label = new Label(ServiceManagementStaffMembersPack10);
                ServiceManagementStaffMembersPack10.DataField = "ServiceManagementStaffMembersPack10";
                ServiceManagementStaffMembersPack50 = new CheckBox("ctl00_phF_form_ServiceManagementStaffMembersPack50", "50 Staff Members", locator, null);
                ServiceManagementStaffMembersPack50Label = new Label(ServiceManagementStaffMembersPack50);
                ServiceManagementStaffMembersPack50.DataField = "ServiceManagementStaffMembersPack50";
                ServiceManagementStaffMembersPackUnlimited = new CheckBox("ctl00_phF_form_ServiceManagementStaffMembersPackUnlimited", "Unlimited Staff Members", locator, null);
                ServiceManagementStaffMembersPackUnlimitedLabel = new Label(ServiceManagementStaffMembersPackUnlimited);
                ServiceManagementStaffMembersPackUnlimited.DataField = "ServiceManagementStaffMembersPackUnlimited";
                EquipmentManagementModule = new CheckBox("ctl00_phF_form_EquipmentManagementModule", "Equipment Management", locator, null);
                EquipmentManagementModuleLabel = new Label(EquipmentManagementModule);
                EquipmentManagementModule.DataField = "EquipmentManagementModule";
                RouteManagementModule = new CheckBox("ctl00_phF_form_RouteManagementModule", "Route Management", locator, null);
                RouteManagementModuleLabel = new Label(RouteManagementModule);
                RouteManagementModule.DataField = "RouteManagementModule";
                RouteManagementVehiclesPack = new CheckBox("ctl00_phF_form_RouteManagementVehiclesPack", "Vehicle Pack", locator, null);
                RouteManagementVehiclesPackLabel = new Label(RouteManagementVehiclesPack);
                RouteManagementVehiclesPack.DataField = "RouteManagementVehiclesPack";
                RouteManagementVehiclesPack10 = new CheckBox("ctl00_phF_form_RouteManagementVehiclesPack10", "10 Vehicles", locator, null);
                RouteManagementVehiclesPack10Label = new Label(RouteManagementVehiclesPack10);
                RouteManagementVehiclesPack10.DataField = "RouteManagementVehiclesPack10";
                RouteManagementVehiclesPack50 = new CheckBox("ctl00_phF_form_RouteManagementVehiclesPack50", "50 Vehicles", locator, null);
                RouteManagementVehiclesPack50Label = new Label(RouteManagementVehiclesPack50);
                RouteManagementVehiclesPack50.DataField = "RouteManagementVehiclesPack50";
                RouteManagementVehiclesPackUnlimited = new CheckBox("ctl00_phF_form_RouteManagementVehiclesPackUnlimited", "Unlimited Vehicles", locator, null);
                RouteManagementVehiclesPackUnlimitedLabel = new Label(RouteManagementVehiclesPackUnlimited);
                RouteManagementVehiclesPackUnlimited.DataField = "RouteManagementVehiclesPackUnlimited";
                CommerceIntegration = new CheckBox("ctl00_phF_form_CommerceIntegration", "Commerce Integration", locator, null);
                CommerceIntegrationLabel = new Label(CommerceIntegration);
                CommerceIntegration.DataField = "CommerceIntegration";
                PayrollModule = new CheckBox("ctl00_phF_form_PayrollModule", "Payroll", locator, null);
                PayrollModuleLabel = new Label(PayrollModule);
                PayrollModule.DataField = "PayrollModule";
                IntegrationModule = new CheckBox("ctl00_phF_form_IntegrationModule", "Third Party Integrations", locator, null);
                IntegrationModuleLabel = new Label(IntegrationModule);
                IntegrationModule.DataField = "IntegrationModule";
                CarrierIntegration = new CheckBox("ctl00_phF_form_CarrierIntegration", "Shipping Carrier Integration", locator, null);
                CarrierIntegrationLabel = new Label(CarrierIntegration);
                CarrierIntegration.DataField = "CarrierIntegration";
                ExchangeIntegration = new CheckBox("ctl00_phF_form_ExchangeIntegration", "Exchange Integration", locator, null);
                ExchangeIntegrationLabel = new Label(ExchangeIntegration);
                ExchangeIntegration.DataField = "ExchangeIntegration";
                AvalaraTax = new CheckBox("ctl00_phF_form_AvalaraTax", "External Tax Calculation Integration", locator, null);
                AvalaraTaxLabel = new Label(AvalaraTax);
                AvalaraTax.DataField = "AvalaraTax";
                AddressValidation = new CheckBox("ctl00_phF_form_AddressValidation", "Address Validation Integration", locator, null);
                AddressValidationLabel = new Label(AddressValidation);
                AddressValidation.DataField = "AddressValidation";
                SalesforceIntegration = new CheckBox("ctl00_phF_form_SalesforceIntegration", "Salesforce Integration", locator, null);
                SalesforceIntegrationLabel = new Label(SalesforceIntegration);
                SalesforceIntegration.DataField = "SalesforceIntegration";
                HubSpotIntegration = new CheckBox("ctl00_phF_form_HubSpotIntegration", "HubSpot Integration", locator, null);
                HubSpotIntegrationLabel = new Label(HubSpotIntegration);
                HubSpotIntegration.DataField = "HubSpotIntegration";
                ProcoreIntegration = new CheckBox("ctl00_phF_form_ProcoreIntegration", "Procore Integration", locator, null);
                ProcoreIntegrationLabel = new Label(ProcoreIntegration);
                ProcoreIntegration.DataField = "ProcoreIntegration";
                ImageRecognition = new CheckBox("ctl00_phF_form_ImageRecognition", "Image Recognition Service", locator, null);
                ImageRecognitionLabel = new Label(ImageRecognition);
                ImageRecognition.DataField = "ImageRecognition";
                RouteOptimizer = new CheckBox("ctl00_phF_form_RouteOptimizer", "Workwave Route Optimization", locator, null);
                RouteOptimizerLabel = new Label(RouteOptimizer);
                RouteOptimizer.DataField = "RouteOptimizer";
                Manufacturing = new CheckBox("ctl00_phF_form_Manufacturing", "Manufacturing Suite", locator, null);
                ManufacturingLabel = new Label(Manufacturing);
                Manufacturing.DataField = "Manufacturing";
                ManufacturingMRP = new CheckBox("ctl00_phF_form_ManufacturingMRP", "Material Requirements Planning", locator, null);
                ManufacturingMRPLabel = new Label(ManufacturingMRP);
                ManufacturingMRP.DataField = "ManufacturingMRP";
                ManufacturingProductConfigurator = new CheckBox("ctl00_phF_form_ManufacturingProductConfigurator", "Product Configurator", locator, null);
                ManufacturingProductConfiguratorLabel = new Label(ManufacturingProductConfigurator);
                ManufacturingProductConfigurator.DataField = "ManufacturingProductConfigurator";
                ManufacturingEstimating = new CheckBox("ctl00_phF_form_ManufacturingEstimating", "Estimating", locator, null);
                ManufacturingEstimatingLabel = new Label(ManufacturingEstimating);
                ManufacturingEstimating.DataField = "ManufacturingEstimating";
                ManufacturingAdvancedPlanning = new CheckBox("ctl00_phF_form_ManufacturingAdvancedPlanning", "Advanced Planning and Scheduling", locator, null);
                ManufacturingAdvancedPlanningLabel = new Label(ManufacturingAdvancedPlanning);
                ManufacturingAdvancedPlanning.DataField = "ManufacturingAdvancedPlanning";
                AdvancedAuthentication = new CheckBox("ctl00_phF_form_AdvancedAuthentication", "Advanced Authentication", locator, null);
                AdvancedAuthenticationLabel = new Label(AdvancedAuthentication);
                AdvancedAuthentication.DataField = "AdvancedAuthentication";
                TwoFactorAuthentication = new CheckBox("ctl00_phF_form_TwoFactorAuthentication", "Two-Factor Authentication", locator, null);
                TwoFactorAuthenticationLabel = new Label(TwoFactorAuthentication);
                TwoFactorAuthentication.DataField = "TwoFactorAuthentication";
                GoogleAndMicrosoftSSO = new CheckBox("ctl00_phF_form_GoogleAndMicrosoftSSO", "Google and Microsoft SSO", locator, null);
                GoogleAndMicrosoftSSOLabel = new Label(GoogleAndMicrosoftSSO);
                GoogleAndMicrosoftSSO.DataField = "GoogleAndMicrosoftSSO";
                ActiveDirectoryAndOtherExternalSSO = new CheckBox("ctl00_phF_form_ActiveDirectoryAndOtherExternalSSO", "Active Directory and Other External SSO", locator, null);
                ActiveDirectoryAndOtherExternalSSOLabel = new Label(ActiveDirectoryAndOtherExternalSSO);
                ActiveDirectoryAndOtherExternalSSO.DataField = "ActiveDirectoryAndOtherExternalSSO";
                DataMemberName = "Features";
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
            
            public virtual void ComboBoxValues()
            {
                Buttons.ComboBoxValues.Click();
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
                
			public Button ComboBoxValues { get; }
			public Button Customize { get; }
			public Button Actions { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    ComboBoxValues = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1_P" +
                            "XButton1", "Combo Box Values", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
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
    }
}
