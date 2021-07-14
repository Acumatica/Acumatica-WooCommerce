using Api;
using Controls;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.EmailEdit;
using Controls.Editors.LinkEdit;
using Controls.Editors.QuickSearch;
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
using Controls.RichTextEdit;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class AR303000_CustomerMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_baccount_baccount BAccount_BAccount { get; } = new c_baccount_baccount("ctl00_phF_BAccount", "BAccount_BAccount");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_currentcustomer_tab CurrentCustomer_tab { get; } = new c_currentcustomer_tab("ctl00_phG_tab", "CurrentCustomer_tab");
        protected c_locations_grdlocations Locations_grdLocations { get; } = new c_locations_grdlocations("ctl00_phG_tab_t4_grdLocations", "Locations_grdLocations");
        protected c_locations_lv0 Locations_lv0 { get; } = new c_locations_lv0("ctl00_phG_tab_t4_grdLocations_lv0", "Locations_lv0");
        protected c_deflocation_deflocation DefLocation_DefLocation { get; } = new c_deflocation_deflocation("ctl00_phG_tab_t3_DefLocation", "DefLocation_DefLocation");
        protected c_deflocation_deflocationaccount DefLocation_DefLocationAccount { get; } = new c_deflocation_deflocationaccount("ctl00_phG_tab_t11_DefLocationAccount", "DefLocation_DefLocationAccount");
        protected c_deflocation_formretainage DefLocation_formRetainage { get; } = new c_deflocation_formretainage("ctl00_phG_tab_t11_formRetainage", "DefLocation_formRetainage");
        protected c_billaddress_billaddress BillAddress_BillAddress { get; } = new c_billaddress_billaddress("ctl00_phG_tab_t2_BillAddress", "BillAddress_BillAddress");
        protected c_defaddress_defaddress DefAddress_DefAddress { get; } = new c_defaddress_defaddress("ctl00_phG_tab_t0_DefAddress", "DefAddress_DefAddress");
        protected c_deflocationaddress_deflocationaddress DefLocationAddress_DefLocationAddress { get; } = new c_deflocationaddress_deflocationaddress("ctl00_phG_tab_t3_DefLocation_DefLocationAddress", "DefLocationAddress_DefLocationAddress");
        protected c_billcontact_billcontact BillContact_BillContact { get; } = new c_billcontact_billcontact("ctl00_phG_tab_t2_BillContact", "BillContact_BillContact");
        protected c_contacts_grdcontacts Contacts_grdContacts { get; } = new c_contacts_grdcontacts("ctl00_phG_tab_t6_grdContacts", "Contacts_grdContacts");
        protected c_contacts_lv0 Contacts_lv0 { get; } = new c_contacts_lv0("ctl00_phG_tab_t6_grdContacts_lv0", "Contacts_lv0");
        protected c_defcontact_defcontact1 DefContact_DefContact1 { get; } = new c_defcontact_defcontact1("ctl00_phG_tab_t0_DefContact1", "DefContact_DefContact1");
        protected c_defcontact_defcontact2 DefContact_DefContact2 { get; } = new c_defcontact_defcontact2("ctl00_phG_tab_t0_DefContact2", "DefContact_DefContact2");
        protected c_deflocationcontact_deflocationcontact DefLocationContact_DefLocationContact { get; } = new c_deflocationcontact_deflocationcontact("ctl00_phG_tab_t3_DefLocation_DefLocationContact", "DefLocationContact_DefLocationContact");
        protected c_primarycontactcurrent_frmprimarycontact PrimaryContactCurrent_frmPrimaryContact { get; } = new c_primarycontactcurrent_frmprimarycontact("ctl00_phG_tab_t0_frmPrimaryContact", "PrimaryContactCurrent_frmPrimaryContact");
        protected c_salespersons_pxgrid1 SalesPersons_PXGrid1 { get; } = new c_salespersons_pxgrid1("ctl00_phG_tab_t7_PXGrid1", "SalesPersons_PXGrid1");
        protected c_salespersons_lv0 SalesPersons_lv0 { get; } = new c_salespersons_lv0("ctl00_phG_tab_t7_PXGrid1_lv0", "SalesPersons_lv0");
        protected c_customerbalance_customerbalance CustomerBalance_CustomerBalance { get; } = new c_customerbalance_customerbalance("ctl00_phG_tab_t1_CustomerBalance", "CustomerBalance_CustomerBalance");
        protected c_carriers_pxgridaccounts Carriers_PXGridAccounts { get; } = new c_carriers_pxgridaccounts("ctl00_phG_tab_t3_DefLocation_PXGridAccounts", "Carriers_PXGridAccounts");
        protected c_carriers_lv0 Carriers_lv0 { get; } = new c_carriers_lv0("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0", "Carriers_lv0");
        protected c_answers_pxgridanswers Answers_PXGridAnswers { get; } = new c_answers_pxgridanswers("ctl00_phG_tab_t9_PXGridAnswers", "Answers_PXGridAnswers");
        protected c_answers_lv0 Answers_lv0 { get; } = new c_answers_lv0("ctl00_phG_tab_t9_PXGridAnswers_lv0", "Answers_lv0");
        protected c_activities_activities_grid Activities_Activities_grid { get; } = new c_activities_activities_grid("ctl00_phG_tab_t10_gridActivities_Activities_grid", "Activities_Activities_grid");
        protected c_activities_lv0 Activities_lv0 { get; } = new c_activities_lv0("ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0", "Activities_lv0");
        protected c_activities_preview_activities_form Activities_Preview_Activities_form { get; } = new c_activities_preview_activities_form("ctl00_phG_tab_t10_gridActivities_Activities_form", "Activities$Preview_Activities_form");
        protected c_notificationsources_gridns NotificationSources_gridNS { get; } = new c_notificationsources_gridns("ctl00_phG_tab_t12_sp1_gridNS", "NotificationSources_gridNS");
        protected c_notificationsources_lv0 NotificationSources_lv0 { get; } = new c_notificationsources_lv0("ctl00_phG_tab_t12_sp1_gridNS_lv0", "NotificationSources_lv0");
        protected c_notificationrecipients_gridnr NotificationRecipients_gridNR { get; } = new c_notificationrecipients_gridnr("ctl00_phG_tab_t12_sp1_gridNR", "NotificationRecipients_gridNR");
        protected c_notificationrecipients_lv0 NotificationRecipients_lv0 { get; } = new c_notificationrecipients_lv0("ctl00_phG_tab_t12_sp1_gridNR_lv0", "NotificationRecipients_lv0");
        protected c_ondemandstatementdialog_formondemandstatement OnDemandStatementDialog_formOnDemandStatement { get; } = new c_ondemandstatementdialog_formondemandstatement("ctl00_phF_pnlOnDemandStatement_formOnDemandStatement", "OnDemandStatementDialog_formOnDemandStatement");
        protected c_childaccounts_gridchildaccounts ChildAccounts_gridChildAccounts { get; } = new c_childaccounts_gridchildaccounts("ctl00_phG_tab_t8_gridChildAccounts", "ChildAccounts_gridChildAccounts");
        protected c_childaccounts_lv0 ChildAccounts_lv0 { get; } = new c_childaccounts_lv0("ctl00_phG_tab_t8_gridChildAccounts_lv0", "ChildAccounts_lv0");
        protected c_contactinfo_formcreatecontact ContactInfo_formCreateContact { get; } = new c_contactinfo_formcreatecontact("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact", "ContactInfo_formCreateContact");
        protected c_contactinfo_tabcreatecontact ContactInfo_tabCreateContact { get; } = new c_contactinfo_tabcreatecontact("ctl00_phG_PanelCreateContact_tabCreateContact", "ContactInfo_tabCreateContact");
        protected c_contactinfoattributes_grdcontactinfoattributes ContactInfoAttributes_grdContactInfoAttributes { get; } = new c_contactinfoattributes_grdcontactinfoattributes("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes", "ContactInfoAttributes_grdContactInfoAttributes");
        protected c_contactinfoattributes_lv0 ContactInfoAttributes_lv0 { get; } = new c_contactinfoattributes_lv0("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0", "ContactInfoAttributes_lv0");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_defpaymentmethodinstance_defpaymentmethodinstance DefPaymentMethodInstance_DefPaymentMethodInstance { get; } = new c_defpaymentmethodinstance_defpaymentmethodinstance("ctl00_phG_tab_t2_DefPaymentMethodInstance", "DefPaymentMethodInstance_DefPaymentMethodInstance");
        protected c_paymentmethods_grdpaymentmethods PaymentMethods_grdPaymentMethods { get; } = new c_paymentmethods_grdpaymentmethods("ctl00_phG_tab_t5_grdPaymentMethods", "PaymentMethods_grdPaymentMethods");
        protected c_paymentmethods_lv0 PaymentMethods_lv0 { get; } = new c_paymentmethods_lv0("ctl00_phG_tab_t5_grdPaymentMethods_lv0", "PaymentMethods_lv0");
        protected c_defpaymentmethodinstancedetails_grdpminstancedetails DefPaymentMethodInstanceDetails_grdPMInstanceDetails { get; } = new c_defpaymentmethodinstancedetails_grdpminstancedetails("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails", "DefPaymentMethodInstanceDetails_grdPMInstanceDetails");
        protected c_defpaymentmethodinstancedetails_lv0 DefPaymentMethodInstanceDetails_lv0 { get; } = new c_defpaymentmethodinstancedetails_lv0("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0", "DefPaymentMethodInstanceDetails_lv0");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phF_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_compliancedocuments_grdcompliancedocuments ComplianceDocuments_grdComplianceDocuments { get; } = new c_compliancedocuments_grdcompliancedocuments("ctl00_phG_tab_t14_grdComplianceDocuments", "ComplianceDocuments_grdComplianceDocuments");
        protected c_compliancedocuments_lv0 ComplianceDocuments_lv0 { get; } = new c_compliancedocuments_lv0("ctl00_phG_tab_t14_grdComplianceDocuments_lv0", "ComplianceDocuments_lv0");
        protected c_customerbillingcycles_gridbillingcycles CustomerBillingCycles_gridBillingCycles { get; } = new c_customerbillingcycles_gridbillingcycles("ctl00_phG_tab_t13_gridBillingCycles", "CustomerBillingCycles_gridBillingCycles");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_BAccount_t1", "Attributes");
        
        public AR303000_CustomerMaint()
        {
            ScreenId = "AR303000";
            ScreenUrl = "/Pages/AR/AR303000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AR303000_CustomerMaint ReadOne(Gate gate, string AcctCD)
        {
            new BiObject<AR303000_CustomerMaint>(gate).ReadOne(this, AcctCD);
            return this;
        }
        
        public virtual AR303000_CustomerMaint ReadOne(string AcctCD)
        {
            return this.ReadOne(ApiConnection.Source, AcctCD);
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
        
        public virtual void ViewAllActivities()
        {
            ToolBar.ViewAllActivities.Click();
        }
        
        public virtual void ViewBusnessAccount()
        {
            ToolBar.ViewBusnessAccount.Click();
        }
        
        public virtual void GenerateOnDemandStatementHidden()
        {
            ToolBar.GenerateOnDemandStatementHidden.Click();
        }
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void NewInvoiceMemo()
        {
            ToolBar.NewInvoiceMemo.Click();
        }
        
        public virtual void NewSalesOrder()
        {
            ToolBar.NewSalesOrder.Click();
        }
        
        public virtual void NewPayment()
        {
            ToolBar.NewPayment.Click();
        }
        
        public virtual void WriteOffBalance()
        {
            ToolBar.WriteOffBalance.Click();
        }
        
        public virtual void ExtendToVendor()
        {
            ToolBar.ExtendToVendor.Click();
        }
        
        public virtual void ViewRestrictionGroups()
        {
            ToolBar.ViewRestrictionGroups.Click();
        }
        
        public virtual void GenerateOnDemandStatement()
        {
            ToolBar.GenerateOnDemandStatement.Click();
        }
        
        public virtual void RegenerateLastStatement()
        {
            ToolBar.RegenerateLastStatement.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void ViewVendor()
        {
            ToolBar.ViewVendor.Click();
        }
        
        public virtual void CreateContact()
        {
            ToolBar.CreateContact.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void Inquiries()
        {
            ToolBar.Inquiries.Click();
        }
        
        public virtual void CustomerDocuments()
        {
            ToolBar.CustomerDocuments.Click();
        }
        
        public virtual void StatementForCustomer()
        {
            ToolBar.StatementForCustomer.Click();
        }
        
        public virtual void SalesPrice()
        {
            ToolBar.SalesPrice.Click();
        }
        
        public virtual void Reports()
        {
            ToolBar.Reports.Click();
        }
        
        public virtual void ARBalanceByCustomer()
        {
            ToolBar.ARBalanceByCustomer.Click();
        }
        
        public virtual void CustomerHistory()
        {
            ToolBar.CustomerHistory.Click();
        }
        
        public virtual void ARAgedPastDue()
        {
            ToolBar.ARAgedPastDue.Click();
        }
        
        public virtual void ARAgedOutstanding()
        {
            ToolBar.ARAgedOutstanding.Click();
        }
        
        public virtual void ARRegister()
        {
            ToolBar.ARRegister.Click();
        }
        
        public virtual void CustomerDetails()
        {
            ToolBar.CustomerDetails.Click();
        }
        
        public virtual void CustomerStatement()
        {
            ToolBar.CustomerStatement.Click();
        }
        
        public virtual void ChangeIDHidden()
        {
            ToolBar.ChangeIDHidden.Click();
        }
        
        public virtual void RefreshContact()
        {
            ToolBar.RefreshContact.Click();
        }
        
        public virtual void ViewContact()
        {
            ToolBar.ViewContact.Click();
        }
        
        public virtual void CreateContactRedirect()
        {
            ToolBar.CreateContactRedirect.Click();
        }
        
        public virtual void RefreshLocation()
        {
            ToolBar.RefreshLocation.Click();
        }
        
        public virtual void ViewLocation()
        {
            ToolBar.ViewLocation.Click();
        }
        
        public virtual void AddNewPrimaryContact()
        {
            ToolBar.AddNewPrimaryContact.Click();
        }
        
        public virtual void NewContact()
        {
            ToolBar.NewContact.Click();
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
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton ViewBusnessAccount { get; }
			public ToolBarButton GenerateOnDemandStatementHidden { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton NewInvoiceMemo { get; }
			public ToolBarButton NewSalesOrder { get; }
			public ToolBarButton NewPayment { get; }
			public ToolBarButton WriteOffBalance { get; }
			public ToolBarButton ExtendToVendor { get; }
			public ToolBarButton ViewRestrictionGroups { get; }
			public ToolBarButton GenerateOnDemandStatement { get; }
			public ToolBarButton RegenerateLastStatement { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton ViewVendor { get; }
			public ToolBarButton CreateContact { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton Inquiries { get; }
			public ToolBarButton CustomerDocuments { get; }
			public ToolBarButton StatementForCustomer { get; }
			public ToolBarButton SalesPrice { get; }
			public ToolBarButton Reports { get; }
			public ToolBarButton ARBalanceByCustomer { get; }
			public ToolBarButton CustomerHistory { get; }
			public ToolBarButton ARAgedPastDue { get; }
			public ToolBarButton ARAgedOutstanding { get; }
			public ToolBarButton ARRegister { get; }
			public ToolBarButton CustomerDetails { get; }
			public ToolBarButton CustomerStatement { get; }
			public ToolBarButton ChangeIDHidden { get; }
			public ToolBarButton RefreshContact { get; }
			public ToolBarButton ViewContact { get; }
			public ToolBarButton CreateContactRedirect { get; }
			public ToolBarButton RefreshLocation { get; }
			public ToolBarButton ViewLocation { get; }
			public ToolBarButton AddNewPrimaryContact { get; }
			public ToolBarButton NewContact { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
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
                ViewAllActivities = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewAllActivities\']", "View Activities", locator, null);
                ViewBusnessAccount = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewBusnessAccount\']", "View Account", locator, null);
                GenerateOnDemandStatementHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'GenerateOnDemandStatement\']", "Generate Statement on Demand", locator, null);
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                NewInvoiceMemo = new ToolBarButton("css=li[data-cmd=\'Action@NewInvoiceMemo\']", "New Invoice/Memo", locator, Actions);
                NewSalesOrder = new ToolBarButton("css=li[data-cmd=\'Action@NewSalesOrder\']", "New Sales Order", locator, Actions);
                NewPayment = new ToolBarButton("css=li[data-cmd=\'Action@NewPayment\']", "New Payment", locator, Actions);
                WriteOffBalance = new ToolBarButton("css=li[data-cmd=\'Action@WriteOffBalance\']", "Write Off Balance", locator, Actions);
                ExtendToVendor = new ToolBarButton("css=li[data-cmd=\'Action@ExtendToVendor\']", "Extend to Vendor", locator, Actions);
                ViewRestrictionGroups = new ToolBarButton("css=li[data-cmd=\'Action@ViewRestrictionGroups\']", "View Restriction Groups", locator, Actions);
                GenerateOnDemandStatement = new ToolBarButton("css=li[data-cmd=\'Action@GenerateOnDemandStatement\']", "Generate Statement on Demand", locator, Actions);
                RegenerateLastStatement = new ToolBarButton("css=li[data-cmd=\'Action@RegenerateLastStatement\']", "Regenerate Last Statement", locator, Actions);
                ValidateAddresses = new ToolBarButton("css=li[data-cmd=\'Action@ValidateAddresses\']", "Validate Addresses", locator, Actions);
                ViewVendor = new ToolBarButton("css=li[data-cmd=\'Action@ViewVendor\']", "View Vendor", locator, Actions);
                CreateContact = new ToolBarButton("css=li[data-cmd=\'Action@CreateContact\']", "Create Contact", locator, Actions);
                ChangeID = new ToolBarButton("css=li[data-cmd=\'Action@ChangeID\']", "Change ID", locator, Actions);
                Inquiries = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Inquiries\") > div[data-type=\'drop\']", "Inquiries", locator, null);
                CustomerDocuments = new ToolBarButton("css=li[data-cmd=\'Inquiry@CustomerDocuments\']", "Customer Details", locator, Inquiries);
                StatementForCustomer = new ToolBarButton("css=li[data-cmd=\'Inquiry@StatementForCustomer\']", "Customer Statement History", locator, Inquiries);
                SalesPrice = new ToolBarButton("css=li[data-cmd=\'Inquiry@SalesPrice\']", "Sales Prices", locator, Inquiries);
                Reports = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                ARBalanceByCustomer = new ToolBarButton("css=li[data-cmd=\'Report@ARBalanceByCustomer\']", "AR Balance by Customer", locator, Reports);
                CustomerHistory = new ToolBarButton("css=li[data-cmd=\'Report@CustomerHistory\']", "Customer History", locator, Reports);
                ARAgedPastDue = new ToolBarButton("css=li[data-cmd=\'Report@ARAgedPastDue\']", "AR Aging", locator, Reports);
                ARAgedOutstanding = new ToolBarButton("css=li[data-cmd=\'Report@ARAgedOutstanding\']", "AR Coming Due", locator, Reports);
                ARRegister = new ToolBarButton("css=li[data-cmd=\'Report@ARRegister\']", "AR Register", locator, Reports);
                CustomerDetails = new ToolBarButton("css=li[data-cmd=\'Report@CustomerDetails\']", "Customer Profile", locator, Reports);
                CustomerStatement = new ToolBarButton("css=li[data-cmd=\'Report@CustomerStatement\']", "Customer Statement", locator, Reports);
                ChangeIDHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ChangeID\']", "Change ID", locator, null);
                RefreshContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'refreshContact\']", "refreshContact", locator, null);
                ViewContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'viewContact\']", "Contact Details", locator, null);
                CreateContactRedirect = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'createContactRedirect\']", "Create Contact with Redirect", locator, null);
                RefreshLocation = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'refreshLocation\']", "refreshLocation", locator, null);
                ViewLocation = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'viewLocation\']", "Location Details", locator, null);
                AddNewPrimaryContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'addNewPrimaryContact\']", "New Contact", locator, null);
                NewContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'NewContact\']", "Add Contact", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_baccount_baccount : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector AcctCD { get; }
			public Label AcctCDLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public Selector CustomerClassID { get; }
			public Label CustomerClassIDLabel { get; }
			public CheckBox ChkServiceManagement { get; }
			public Label ChkServiceManagementLabel { get; }
            
            public c_baccount_baccount(string locator, string name) : 
                    base(locator, name)
            {
                AcctCD = new Selector("ctl00_phF_BAccount_t0_edAcctCD", "Customer ID", locator, null);
                AcctCDLabel = new Label(AcctCD);
                AcctCD.DataField = "AcctCD";
                Status = new DropDown("ctl00_phF_BAccount_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("A", "Active");
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("C", "Credit Hold");
                Status.Items.Add("I", "Inactive");
                Status.Items.Add("T", "One-Time");
                CustomerClassID = new Selector("ctl00_phF_BAccount_t0_edCustomerClassID", "Customer Class", locator, null);
                CustomerClassIDLabel = new Label(CustomerClassID);
                CustomerClassID.DataField = "CustomerClassID";
                ChkServiceManagement = new CheckBox("ctl00_phF_BAccount_t0_chkServiceManagement", "chkServiceManagement", locator, null);
                ChkServiceManagementLabel = new Label(ChkServiceManagement);
                ChkServiceManagement.DataField = "ChkServiceManagement";
                DataMemberName = "BAccount";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CustomerClassIDEdit()
            {
                Buttons.CustomerClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CustomerClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    CustomerClassIDEdit = new Button("css=div[id=\'ctl00_phF_BAccount_t0_edCustomerClassID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "CustomerClassIDEdit", "ctl00_phF_BAccount");
                    CustomerClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c_currentcustomer_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AcctName { get; }
			public Label AcctNameLabel { get; }
			public PXTextEdit AcctReferenceNbr { get; }
			public Label AcctReferenceNbrLabel { get; }
			public Selector LocaleName { get; }
			public Label LocaleNameLabel { get; }
			public Selector PrimaryContactID { get; }
			public Label PrimaryContactIDLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public Selector StatementCycleId { get; }
			public Label StatementCycleIdLabel { get; }
			public PXBranchSelector COrgBAccountID { get; }
			public Label COrgBAccountIDLabel { get; }
			public CheckBox AutoApplyPayments { get; }
			public Label AutoApplyPaymentsLabel { get; }
			public CheckBox FinChargeApply { get; }
			public Label FinChargeApplyLabel { get; }
			public CheckBox SmallBalanceAllow { get; }
			public Label SmallBalanceAllowLabel { get; }
			public PXNumberEdit SmallBalanceLimit { get; }
			public Label SmallBalanceLimitLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBox AllowOverrideCury { get; }
			public Label AllowOverrideCuryLabel { get; }
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public CheckBox AllowOverrideRate { get; }
			public Label AllowOverrideRateLabel { get; }
			public CheckBox PaymentsByLinesAllowed { get; }
			public Label PaymentsByLinesAllowedLabel { get; }
			public CheckBox RetainageApply { get; }
			public Label RetainageApplyLabel { get; }
			public PXNumberEdit RetainagePct { get; }
			public Label RetainagePctLabel { get; }
			public DropDown CreditRule { get; }
			public Label CreditRuleLabel { get; }
			public PXNumberEdit CreditLimit { get; }
			public Label CreditLimitLabel { get; }
			public PXNumberEdit CreditDaysPastDue { get; }
			public Label CreditDaysPastDueLabel { get; }
			public CheckBox OverrideBillAddress { get; }
			public Label OverrideBillAddressLabel { get; }
			public CheckBox OverrideBillContact { get; }
			public Label OverrideBillContactLabel { get; }
			public CheckBox RequireCustomerSignature { get; }
			public Label RequireCustomerSignatureLabel { get; }
			public Selector BillingCycleID { get; }
			public Label BillingCycleIDLabel { get; }
			public DropDown SendInvoicesTo { get; }
			public Label SendInvoicesToLabel { get; }
			public DropDown BillShipmentSource { get; }
			public Label BillShipmentSourceLabel { get; }
			public DropDown DefaultBillingCustomerSource { get; }
			public Label DefaultBillingCustomerSourceLabel { get; }
			public Selector BillCustomerID { get; }
			public Label BillCustomerIDLabel { get; }
			public Selector BillLocationID { get; }
			public Label BillLocationIDLabel { get; }
			public Selector ParentBAccountID { get; }
			public Label ParentBAccountIDLabel { get; }
			public CheckBox ConsolidateToParent { get; }
			public Label ConsolidateToParentLabel { get; }
			public CheckBox ConsolidateStatements { get; }
			public Label ConsolidateStatementsLabel { get; }
			public CheckBox SharedCreditPolicy { get; }
			public Label SharedCreditPolicyLabel { get; }
			public CheckBox MailInvoices { get; }
			public Label MailInvoicesLabel { get; }
			public CheckBox PrintInvoices { get; }
			public Label PrintInvoicesLabel { get; }
			public CheckBox MailDunningLetters { get; }
			public Label MailDunningLettersLabel { get; }
			public CheckBox PrintDunningLetters { get; }
			public Label PrintDunningLettersLabel { get; }
			public CheckBox SendStatementByEmail { get; }
			public Label SendStatementByEmailLabel { get; }
			public CheckBox PrintStatements { get; }
			public Label PrintStatementsLabel { get; }
			public DropDown StatementType { get; }
			public Label StatementTypeLabel { get; }
			public CheckBox PrintCuryStatements { get; }
			public Label PrintCuryStatementsLabel { get; }
			public Selector DefPaymentMethodID { get; }
			public Label DefPaymentMethodIDLabel { get; }
			public Selector DiscTakenAcctID { get; }
			public Label DiscTakenAcctIDLabel { get; }
			public Selector DiscTakenSubID { get; }
			public Label DiscTakenSubIDLabel { get; }
			public Selector PrepaymentAcctID { get; }
			public Label PrepaymentAcctIDLabel { get; }
			public Selector PrepaymentSubID { get; }
			public Label PrepaymentSubIDLabel { get; }
			public Selector COGSAcctID { get; }
			public Label COGSAcctIDLabel { get; }
			public Selector COGSSubID { get; }
			public Label COGSSubIDLabel { get; }
			public Label EdDefContactlblPhone1_ { get; }
			public Label EdDefContactlblPhone2_ { get; }
			public Label EdDefContactlblFax_ { get; }
			public Label LblDefContactAccountEmail_ { get; }
			public Label LblPrimaryContactName_ { get; }
			public Label LblPrmCntPhone1_ { get; }
			public Label LblPrmCntPhone2_ { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
			public Label LblPhone1_2 { get; }
			public Label LblPhone2_2 { get; }
			public Label LblFax_2 { get; }
            
            public c_currentcustomer_tab(string locator, string name) : 
                    base(locator, name)
            {
                AcctName = new PXTextEdit("ctl00_phG_tab_t0_edAcctName", "Account Name", locator, null);
                AcctNameLabel = new Label(AcctName);
                AcctName.DataField = "AcctName";
                AcctReferenceNbr = new PXTextEdit("ctl00_phG_tab_t0_edExtRefNbr", "Ext Ref Nbr", locator, null);
                AcctReferenceNbrLabel = new Label(AcctReferenceNbr);
                AcctReferenceNbr.DataField = "AcctReferenceNbr";
                LocaleName = new Selector("ctl00_phG_tab_t0_edLocaleName", "Locale", locator, null);
                LocaleNameLabel = new Label(LocaleName);
                LocaleName.DataField = "LocaleName";
                PrimaryContactID = new Selector("ctl00_phG_tab_t0_edPrmCntID", "Name", locator, null);
                PrimaryContactIDLabel = new Label(PrimaryContactID);
                PrimaryContactID.DataField = "PrimaryContactID";
                TermsID = new Selector("ctl00_phG_tab_t1_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                StatementCycleId = new Selector("ctl00_phG_tab_t1_edStatementCycleId", "Statement Cycle ID", locator, null);
                StatementCycleIdLabel = new Label(StatementCycleId);
                StatementCycleId.DataField = "StatementCycleId";
                COrgBAccountID = new PXBranchSelector("ctl00_phG_tab_t1_edCOrgBAccountID", "Restrict Visibility To", locator, null);
                COrgBAccountIDLabel = new Label(COrgBAccountID);
                COrgBAccountID.DataField = "COrgBAccountID";
                AutoApplyPayments = new CheckBox("ctl00_phG_tab_t1_chkAutoApplyPayments", "Auto-Apply Payments", locator, null);
                AutoApplyPaymentsLabel = new Label(AutoApplyPayments);
                AutoApplyPayments.DataField = "AutoApplyPayments";
                FinChargeApply = new CheckBox("ctl00_phG_tab_t1_chkFinChargeApply", "Apply Overdue Charges", locator, null);
                FinChargeApplyLabel = new Label(FinChargeApply);
                FinChargeApply.DataField = "FinChargeApply";
                SmallBalanceAllow = new CheckBox("ctl00_phG_tab_t1_chkSmallBalanceAllow", "Enable Write-Offs", locator, null);
                SmallBalanceAllowLabel = new Label(SmallBalanceAllow);
                SmallBalanceAllow.DataField = "SmallBalanceAllow";
                SmallBalanceLimit = new PXNumberEdit("ctl00_phG_tab_t1_edSmallBalanceLimit", "Write-Off Limit", locator, null);
                SmallBalanceLimitLabel = new Label(SmallBalanceLimit);
                SmallBalanceLimit.DataField = "SmallBalanceLimit";
                CuryID = new Selector("ctl00_phG_tab_t1_edCuryID", "Currency ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                AllowOverrideCury = new CheckBox("ctl00_phG_tab_t1_chkAllowOverrideCury", "Enable Currency Override", locator, null);
                AllowOverrideCuryLabel = new Label(AllowOverrideCury);
                AllowOverrideCury.DataField = "AllowOverrideCury";
                CuryRateTypeID = new Selector("ctl00_phG_tab_t1_edCuryRateTypeID", "Curr. Rate Type", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                AllowOverrideRate = new CheckBox("ctl00_phG_tab_t1_chkAllowOverrideRate", "Enable Rate Override", locator, null);
                AllowOverrideRateLabel = new Label(AllowOverrideRate);
                AllowOverrideRate.DataField = "AllowOverrideRate";
                PaymentsByLinesAllowed = new CheckBox("ctl00_phG_tab_t1_chkPaymentsByLinesAllowed", "Pay by Line", locator, null);
                PaymentsByLinesAllowedLabel = new Label(PaymentsByLinesAllowed);
                PaymentsByLinesAllowed.DataField = "PaymentsByLinesAllowed";
                RetainageApply = new CheckBox("ctl00_phG_tab_t1_edRetainageApply", "Apply Retainage", locator, null);
                RetainageApplyLabel = new Label(RetainageApply);
                RetainageApply.DataField = "RetainageApply";
                RetainagePct = new PXNumberEdit("ctl00_phG_tab_t1_edRetainagePct", "Retainage Percent", locator, null);
                RetainagePctLabel = new Label(RetainagePct);
                RetainagePct.DataField = "RetainagePct";
                CreditRule = new DropDown("ctl00_phG_tab_t1_edCreditRule", "Credit Verification", locator, null);
                CreditRuleLabel = new Label(CreditRule);
                CreditRule.DataField = "CreditRule";
                CreditRule.Items.Add("D", "Days Past Due");
                CreditRule.Items.Add("C", "Credit Limit");
                CreditRule.Items.Add("B", "Limit and Days Past Due");
                CreditRule.Items.Add("N", "Disabled");
                CreditLimit = new PXNumberEdit("ctl00_phG_tab_t1_edCreditLimit", "Credit Limit", locator, null);
                CreditLimitLabel = new Label(CreditLimit);
                CreditLimit.DataField = "CreditLimit";
                CreditDaysPastDue = new PXNumberEdit("ctl00_phG_tab_t1_edCreditDaysPastDue", "Credit Days Past Due", locator, null);
                CreditDaysPastDueLabel = new Label(CreditDaysPastDue);
                CreditDaysPastDue.DataField = "CreditDaysPastDue";
                OverrideBillAddress = new CheckBox("ctl00_phG_tab_t2_chkOverrideBillAddress", "Override", locator, null);
                OverrideBillAddressLabel = new Label(OverrideBillAddress);
                OverrideBillAddress.DataField = "OverrideBillAddress";
                OverrideBillContact = new CheckBox("ctl00_phG_tab_t2_chkOverrideBillContact", "Override", locator, null);
                OverrideBillContactLabel = new Label(OverrideBillContact);
                OverrideBillContact.DataField = "OverrideBillContact";
                RequireCustomerSignature = new CheckBox("ctl00_phG_tab_t2_edRequireCustomerSignature", "Require Customer Signature on Mobile App", locator, null);
                RequireCustomerSignatureLabel = new Label(RequireCustomerSignature);
                RequireCustomerSignature.DataField = "RequireCustomerSignature";
                BillingCycleID = new Selector("ctl00_phG_tab_t2_edBillingCycleID1", "Billing Cycle", locator, null);
                BillingCycleIDLabel = new Label(BillingCycleID);
                BillingCycleID.DataField = "BillingCycleID";
                SendInvoicesTo = new DropDown("ctl00_phG_tab_t2_edSendInvoicesTo", "Bill-To Address", locator, null);
                SendInvoicesToLabel = new Label(SendInvoicesTo);
                SendInvoicesTo.DataField = "SendInvoicesTo";
                BillShipmentSource = new DropDown("ctl00_phG_tab_t2_edBillShipmentSource", "Ship-To Address", locator, null);
                BillShipmentSourceLabel = new Label(BillShipmentSource);
                BillShipmentSource.DataField = "BillShipmentSource";
                DefaultBillingCustomerSource = new DropDown("ctl00_phG_tab_t2_edDefaultBillingCustomerSource", "Default Billing Customer", locator, null);
                DefaultBillingCustomerSourceLabel = new Label(DefaultBillingCustomerSource);
                DefaultBillingCustomerSource.DataField = "DefaultBillingCustomerSource";
                BillCustomerID = new Selector("ctl00_phG_tab_t2_edBillCustomerID", "Billing Customer", locator, null);
                BillCustomerIDLabel = new Label(BillCustomerID);
                BillCustomerID.DataField = "BillCustomerID";
                BillLocationID = new Selector("ctl00_phG_tab_t2_edBillLocationID", "Billing Location", locator, null);
                BillLocationIDLabel = new Label(BillLocationID);
                BillLocationID.DataField = "BillLocationID";
                ParentBAccountID = new Selector("ctl00_phG_tab_t2_edParentBAccountID", "Parent Account", locator, null);
                ParentBAccountIDLabel = new Label(ParentBAccountID);
                ParentBAccountID.DataField = "ParentBAccountID";
                ConsolidateToParent = new CheckBox("ctl00_phG_tab_t2_edConsolidateToParent", "Consolidate Balance", locator, null);
                ConsolidateToParentLabel = new Label(ConsolidateToParent);
                ConsolidateToParent.DataField = "ConsolidateToParent";
                ConsolidateStatements = new CheckBox("ctl00_phG_tab_t2_edConsolidateStatements", "Consolidate Statements", locator, null);
                ConsolidateStatementsLabel = new Label(ConsolidateStatements);
                ConsolidateStatements.DataField = "ConsolidateStatements";
                SharedCreditPolicy = new CheckBox("ctl00_phG_tab_t2_edSharedCreditPolicy", "Share Credit Policy", locator, null);
                SharedCreditPolicyLabel = new Label(SharedCreditPolicy);
                SharedCreditPolicy.DataField = "SharedCreditPolicy";
                MailInvoices = new CheckBox("ctl00_phG_tab_t2_chkMailInvoices", "Send Invoices by Email", locator, null);
                MailInvoicesLabel = new Label(MailInvoices);
                MailInvoices.DataField = "MailInvoices";
                PrintInvoices = new CheckBox("ctl00_phG_tab_t2_chkPrintInvoices", "Print Invoices", locator, null);
                PrintInvoicesLabel = new Label(PrintInvoices);
                PrintInvoices.DataField = "PrintInvoices";
                MailDunningLetters = new CheckBox("ctl00_phG_tab_t2_chkMailDunningLetters", "Send Dunning Letters by Email", locator, null);
                MailDunningLettersLabel = new Label(MailDunningLetters);
                MailDunningLetters.DataField = "MailDunningLetters";
                PrintDunningLetters = new CheckBox("ctl00_phG_tab_t2_chkPrintDunningLetters", "Print Dunning Letters", locator, null);
                PrintDunningLettersLabel = new Label(PrintDunningLetters);
                PrintDunningLetters.DataField = "PrintDunningLetters";
                SendStatementByEmail = new CheckBox("ctl00_phG_tab_t2_chkSendStatementByEmails", "Send Statements by Email", locator, null);
                SendStatementByEmailLabel = new Label(SendStatementByEmail);
                SendStatementByEmail.DataField = "SendStatementByEmail";
                PrintStatements = new CheckBox("ctl00_phG_tab_t2_chkPrintStatements", "Print Statements", locator, null);
                PrintStatementsLabel = new Label(PrintStatements);
                PrintStatements.DataField = "PrintStatements";
                StatementType = new DropDown("ctl00_phG_tab_t2_edStatementType", "Statement Type", locator, null);
                StatementTypeLabel = new Label(StatementType);
                StatementType.DataField = "StatementType";
                StatementType.Items.Add("O", "Open Item");
                StatementType.Items.Add("B", "Balance Brought Forward");
                PrintCuryStatements = new CheckBox("ctl00_phG_tab_t2_chkPrintCuryStatements", "Multi-Currency Statements", locator, null);
                PrintCuryStatementsLabel = new Label(PrintCuryStatements);
                PrintCuryStatements.DataField = "PrintCuryStatements";
                DefPaymentMethodID = new Selector("ctl00_phG_tab_t2_edDefPaymentMethodID", "Default Payment Method", locator, null);
                DefPaymentMethodIDLabel = new Label(DefPaymentMethodID);
                DefPaymentMethodID.DataField = "DefPaymentMethodID";
                DiscTakenAcctID = new Selector("ctl00_phG_tab_t11_edDiscTakenAcctID", "Cash Discount Account", locator, null);
                DiscTakenAcctIDLabel = new Label(DiscTakenAcctID);
                DiscTakenAcctID.DataField = "DiscTakenAcctID";
                DiscTakenSubID = new Selector("ctl00_phG_tab_t11_edDiscTakenSubID", "Cash Discount Sub.", locator, null);
                DiscTakenSubIDLabel = new Label(DiscTakenSubID);
                DiscTakenSubID.DataField = "DiscTakenSubID";
                PrepaymentAcctID = new Selector("ctl00_phG_tab_t11_edPrepaymentAcctID", "Prepayment Account", locator, null);
                PrepaymentAcctIDLabel = new Label(PrepaymentAcctID);
                PrepaymentAcctID.DataField = "PrepaymentAcctID";
                PrepaymentSubID = new Selector("ctl00_phG_tab_t11_edPrepaymentSubID", "Prepayment Sub.", locator, null);
                PrepaymentSubIDLabel = new Label(PrepaymentSubID);
                PrepaymentSubID.DataField = "PrepaymentSubID";
                COGSAcctID = new Selector("ctl00_phG_tab_t11_edCOGSAcctID", "COGS Account", locator, null);
                COGSAcctIDLabel = new Label(COGSAcctID);
                COGSAcctID.DataField = "COGSAcctID";
                COGSSubID = new Selector("ctl00_phG_tab_t11_edCOGSSubID", "COGS Sub.", locator, null);
                COGSSubIDLabel = new Label(COGSSubID);
                COGSSubID.DataField = "COGSSubID";
                EdDefContactlblPhone1_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone1", "Ed Def Contactlbl Phone 1_", locator, null);
                EdDefContactlblPhone2_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone2", "Ed Def Contactlbl Phone 2_", locator, null);
                EdDefContactlblFax_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblFax", "Ed Def Contactlbl Fax _", locator, null);
                LblDefContactAccountEmail_ = new Label("ctl00_phG_tab_t0_DefContact1_lblDefContactAccountEmail", "Account Email:", locator, null);
                LblPrimaryContactName_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrimaryContactName", "Name:", locator, null);
                LblPrmCntPhone1_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone1", "Lbl Prm Cnt Phone 1_", locator, null);
                LblPrmCntPhone2_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone2", "Lbl Prm Cnt Phone 2_", locator, null);
                LblPhone1_ = new Label("ctl00_phG_tab_t2_BillContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t2_BillContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t2_BillContact_lblFax", "Lbl Fax _", locator, null);
                LblPhone1_2 = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone1", "Lbl Phone 1_2", locator, null);
                LblPhone2_2 = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone2", "Lbl Phone 2_2", locator, null);
                LblFax_2 = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblFax", "Lbl Fax _2", locator, null);
                DataMemberName = "CurrentCustomer";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public virtual void StatementCycleIdEdit()
            {
                Buttons.StatementCycleIdEdit.Click();
            }
            
            public virtual void BillingCycleIDEdit()
            {
                Buttons.BillingCycleIDEdit.Click();
            }
            
            public virtual void ParentBAccountIDEdit()
            {
                Buttons.ParentBAccountIDEdit.Click();
            }
            
            public virtual void DiscTakenSubIDEdit()
            {
                Buttons.DiscTakenSubIDEdit.Click();
            }
            
            public virtual void PrepaymentSubIDEdit()
            {
                Buttons.PrepaymentSubIDEdit.Click();
            }
            
            public virtual void COGSAcctIDEdit()
            {
                Buttons.COGSAcctIDEdit.Click();
            }
            
            public virtual void COGSSubIDEdit()
            {
                Buttons.COGSSubIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PrimaryContactIDEdit { get; }
			public Button TermsIDEdit { get; }
			public Button StatementCycleIdEdit { get; }
			public Button BillingCycleIDEdit { get; }
			public Button ParentBAccountIDEdit { get; }
			public Button DiscTakenSubIDEdit { get; }
			public Button PrepaymentSubIDEdit { get; }
			public Button COGSAcctIDEdit { get; }
			public Button COGSSubIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab");
                    PrimaryContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab");
                    TermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    StatementCycleIdEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edStatementCycleId\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "StatementCycleIdEdit", "ctl00_phG_tab");
                    StatementCycleIdEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    BillingCycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edBillingCycleID1\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "BillingCycleIDEdit", "ctl00_phG_tab");
                    BillingCycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ParentBAccountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edParentBAccountID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "ParentBAccountIDEdit", "ctl00_phG_tab");
                    ParentBAccountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DiscTakenSubIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_edDiscTakenSubID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "DiscTakenSubIDEdit", "ctl00_phG_tab");
                    DiscTakenSubIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PrepaymentSubIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_edPrepaymentSubID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "PrepaymentSubIDEdit", "ctl00_phG_tab");
                    PrepaymentSubIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    COGSAcctIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_edCOGSAcctID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "COGSAcctIDEdit", "ctl00_phG_tab");
                    COGSAcctIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    COGSSubIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_edCOGSSubID\'] div[class=\'editBtnCont\'] > div > div", "COGSSubIDEdit", "ctl00_phG_tab");
                    COGSSubIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_locations_grdlocations : Grid<c_locations_grdlocations.c_grid_row, c_locations_grdlocations.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_locations_grdlocations(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_grdLocations");
                DataMemberName = "Locations";
                PredefinedFilter = new DropDown("ctl00_phG_tab_t4_grdLocations_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                QuickSearch = new QuickSearch("ctl00_phG_tab_t4_grdLocations_at_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_grdLocations_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void NewLocation()
            {
                ToolBar.NewLocation.Click();
            }
            
            public virtual void LocationDetails()
            {
                ToolBar.LocationDetails.Click();
            }
            
            public virtual void SetDefaultLocation()
            {
                ToolBar.SetDefaultLocation.Click();
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
			public ToolBarButtonGrid NewLocation { get; }
			public ToolBarButtonGrid LocationDetails { get; }
			public ToolBarButtonGrid SetDefaultLocation { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    NewLocation = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'NewLocation\']", "Add New Location", locator, null);
                    LocationDetails = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'cmdViewLocation\']", "Location Details", locator, null);
                    SetDefaultLocation = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'SetDefaultLocation\']", "Set as Default", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdLocations_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsActive { get; }
			public Selector LocationCD { get; }
			public PXTextEdit Descr { get; }
			public CheckBox IsDefault { get; }
			public PXTextEdit Address__City { get; }
			public Selector Address__State { get; }
			public Selector Address__CountryID { get; }
			public PXTextEdit Address__PostalCode { get; }
			public PXTextEdit Address__State_description { get; }
			public PXTextEdit Address__CountryID_description { get; }
			public Selector CPriceClassID { get; }
			public PXTextEdit CreatedByID_Description { get; }
			public DateSelector CreatedDateTime { get; }
			public PXTextEdit LastModifiedByID_Description { get; }
			public DateSelector LastModifiedDateTime { get; }
			public Selector CDefProjectID { get; }
			public PXTextEdit TaxRegistrationID { get; }
			public Selector CTaxZoneID { get; }
			public DropDown CTaxCalcMode { get; }
			public PXTextEdit CAvalaraExemptionNumber { get; }
			public DropDown CAvalaraCustomerUsageType { get; }
			public Selector CSiteID { get; }
			public Selector CCarrierID { get; }
			public Selector CShipTermsID { get; }
			public Selector CShipZoneID { get; }
			public Selector CFOBPointID { get; }
			public PXTextEdit CResedential { get; }
			public PXTextEdit CSaturdayDelivery { get; }
			public PXTextEdit CInsurance { get; }
			public DropDown CShipComplete { get; }
			public PXNumberEdit COrderPriority { get; }
			public PXNumberEdit CLeadTime { get; }
			public Selector CCalendarID { get; }
			public Selector CSalesAcctID { get; }
			public Selector CSalesSubID { get; }
			public Selector CARAccountID { get; }
			public Selector CARSubID { get; }
			public Selector CDiscountAcctID { get; }
			public Selector CDiscountSubID { get; }
			public Selector CFreightAcctID { get; }
			public Selector CFreightSubID { get; }
			public Selector CBranchID { get; }
			public PXTextEdit CBranchID_description { get; }
			public PXNumberEdit BAccountID { get; }
                
                public c_grid_row(c_locations_grdlocations grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsActive = new CheckBox("ctl00_phG_tab_t4_grdLocations_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    LocationCD = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Location ID", grid.Locator, "LocationCD");
                    LocationCD.DataField = "LocationCD";
                    Descr = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Location Name", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    IsDefault = new CheckBox("ctl00_phG_tab_t4_grdLocations", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    Address__City = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "City", grid.Locator, "Address__City");
                    Address__City.DataField = "Address__City";
                    Address__State = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "State", grid.Locator, "Address__State");
                    Address__State.DataField = "Address__State";
                    Address__CountryID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Country", grid.Locator, "Address__CountryID");
                    Address__CountryID.DataField = "Address__CountryID";
                    Address__PostalCode = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Postal Code", grid.Locator, "Address__PostalCode");
                    Address__PostalCode.DataField = "Address__PostalCode";
                    Address__State_description = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "State Name", grid.Locator, "Address__State_description");
                    Address__State_description.DataField = "Address__State_description";
                    Address__CountryID_description = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Country Name", grid.Locator, "Address__CountryID_description");
                    Address__CountryID_description.DataField = "Address__CountryID_description";
                    CPriceClassID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Price Class", grid.Locator, "CPriceClassID");
                    CPriceClassID.DataField = "CPriceClassID";
                    CreatedByID_Description = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Created By", grid.Locator, "CreatedByID_Description");
                    CreatedByID_Description.DataField = "CreatedByID_Description";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t4_grdLocations_lv0_ed14", "CreatedDateTime", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    LastModifiedByID_Description = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Last Modified By", grid.Locator, "LastModifiedByID_Description");
                    LastModifiedByID_Description.DataField = "LastModifiedByID_Description";
                    LastModifiedDateTime = new DateSelector("_ctl00_phG_tab_t4_grdLocations_lv0_ed16", "LastModifiedDateTime", grid.Locator, "LastModifiedDateTime");
                    LastModifiedDateTime.DataField = "LastModifiedDateTime";
                    CDefProjectID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Default Project", grid.Locator, "CDefProjectID");
                    CDefProjectID.DataField = "CDefProjectID";
                    TaxRegistrationID = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Tax Registration ID", grid.Locator, "TaxRegistrationID");
                    TaxRegistrationID.DataField = "TaxRegistrationID";
                    CTaxZoneID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Tax Zone", grid.Locator, "CTaxZoneID");
                    CTaxZoneID.DataField = "CTaxZoneID";
                    CTaxCalcMode = new DropDown("_ctl00_phG_tab_t4_grdLocations_lv0_ec", "Tax Calculation Mode", grid.Locator, "CTaxCalcMode");
                    CTaxCalcMode.DataField = "CTaxCalcMode";
                    CTaxCalcMode.Items.Add("T", "Tax Settings");
                    CTaxCalcMode.Items.Add("G", "Gross");
                    CTaxCalcMode.Items.Add("N", "Net");
                    CAvalaraExemptionNumber = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Tax Exemption Number", grid.Locator, "CAvalaraExemptionNumber");
                    CAvalaraExemptionNumber.DataField = "CAvalaraExemptionNumber";
                    CAvalaraCustomerUsageType = new DropDown("_ctl00_phG_tab_t4_grdLocations_lv0_ec", "Entity Usage Type", grid.Locator, "CAvalaraCustomerUsageType");
                    CAvalaraCustomerUsageType.DataField = "CAvalaraCustomerUsageType";
                    CAvalaraCustomerUsageType.Items.Add("A", "Federal Government");
                    CAvalaraCustomerUsageType.Items.Add("B", "State/Local Govt.");
                    CAvalaraCustomerUsageType.Items.Add("C", "Tribal Government");
                    CAvalaraCustomerUsageType.Items.Add("D", "Foreign Diplomat");
                    CAvalaraCustomerUsageType.Items.Add("E", "Charitable Organization");
                    CAvalaraCustomerUsageType.Items.Add("F", "Religious");
                    CAvalaraCustomerUsageType.Items.Add("G", "Resale");
                    CAvalaraCustomerUsageType.Items.Add("H", "Agricultural Production");
                    CAvalaraCustomerUsageType.Items.Add("I", "Industrial Prod/Mfg.");
                    CAvalaraCustomerUsageType.Items.Add("J", "Direct Pay Permit");
                    CAvalaraCustomerUsageType.Items.Add("K", "Direct Mail");
                    CAvalaraCustomerUsageType.Items.Add("L", "Other");
                    CAvalaraCustomerUsageType.Items.Add("M", "Education");
                    CAvalaraCustomerUsageType.Items.Add("N", "Local Government");
                    CAvalaraCustomerUsageType.Items.Add("P", "Commercial Aquaculture");
                    CAvalaraCustomerUsageType.Items.Add("Q", "Commercial Fishery");
                    CAvalaraCustomerUsageType.Items.Add("R", "Non-resident");
                    CAvalaraCustomerUsageType.Items.Add("0", "Default");
                    CSiteID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Warehouse", grid.Locator, "CSiteID");
                    CSiteID.DataField = "CSiteID";
                    CCarrierID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Ship Via", grid.Locator, "CCarrierID");
                    CCarrierID.DataField = "CCarrierID";
                    CShipTermsID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Shipping Terms", grid.Locator, "CShipTermsID");
                    CShipTermsID.DataField = "CShipTermsID";
                    CShipZoneID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Shipping Zone", grid.Locator, "CShipZoneID");
                    CShipZoneID.DataField = "CShipZoneID";
                    CFOBPointID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "FOB Point", grid.Locator, "CFOBPointID");
                    CFOBPointID.DataField = "CFOBPointID";
                    CResedential = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ef", "Residential Delivery", grid.Locator, "CResedential");
                    CResedential.DataField = "CResedential";
                    CSaturdayDelivery = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ef", "Saturday Delivery", grid.Locator, "CSaturdayDelivery");
                    CSaturdayDelivery.DataField = "CSaturdayDelivery";
                    CInsurance = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ef", "Insurance", grid.Locator, "CInsurance");
                    CInsurance.DataField = "CInsurance";
                    CShipComplete = new DropDown("_ctl00_phG_tab_t4_grdLocations_lv0_ec", "Shipping Rule", grid.Locator, "CShipComplete");
                    CShipComplete.DataField = "CShipComplete";
                    CShipComplete.Items.Add("C", "Ship Complete");
                    CShipComplete.Items.Add("B", "Back Order Allowed");
                    CShipComplete.Items.Add("L", "Cancel Remainder");
                    COrderPriority = new PXNumberEdit("ctl00_phG_tab_t4_grdLocations_en", "Order Priority", grid.Locator, "COrderPriority");
                    COrderPriority.DataField = "COrderPriority";
                    CLeadTime = new PXNumberEdit("ctl00_phG_tab_t4_grdLocations_en", "Lead Time (Days)", grid.Locator, "CLeadTime");
                    CLeadTime.DataField = "CLeadTime";
                    CCalendarID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Calendar", grid.Locator, "CCalendarID");
                    CCalendarID.DataField = "CCalendarID";
                    CSalesAcctID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Sales Account", grid.Locator, "CSalesAcctID");
                    CSalesAcctID.DataField = "CSalesAcctID";
                    CSalesSubID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Sales Sub.", grid.Locator, "CSalesSubID");
                    CSalesSubID.DataField = "CSalesSubID";
                    CARAccountID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "AR Account", grid.Locator, "CARAccountID");
                    CARAccountID.DataField = "CARAccountID";
                    CARSubID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "AR Sub.", grid.Locator, "CARSubID");
                    CARSubID.DataField = "CARSubID";
                    CDiscountAcctID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Discount Account", grid.Locator, "CDiscountAcctID");
                    CDiscountAcctID.DataField = "CDiscountAcctID";
                    CDiscountSubID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Discount Sub.", grid.Locator, "CDiscountSubID");
                    CDiscountSubID.DataField = "CDiscountSubID";
                    CFreightAcctID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Freight Account", grid.Locator, "CFreightAcctID");
                    CFreightAcctID.DataField = "CFreightAcctID";
                    CFreightSubID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Freight Sub.", grid.Locator, "CFreightSubID");
                    CFreightSubID.DataField = "CFreightSubID";
                    CBranchID = new Selector("_ctl00_phG_tab_t4_grdLocations_lv0_es", "Default Branch", grid.Locator, "CBranchID");
                    CBranchID.DataField = "CBranchID";
                    CBranchID_description = new PXTextEdit("ctl00_phG_tab_t4_grdLocations_ei", "Branch Name", grid.Locator, "CBranchID_description");
                    CBranchID_description.DataField = "CBranchID_description";
                    BAccountID = new PXNumberEdit("ctl00_phG_tab_t4_grdLocations_en", "BAccountID", grid.Locator, "BAccountID");
                    BAccountID.DataField = "BAccountID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public SelectorColumnFilter LocationCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public PXTextEditColumnFilter Address__City { get; }
				public SelectorColumnFilter Address__State { get; }
				public SelectorColumnFilter Address__CountryID { get; }
				public PXTextEditColumnFilter Address__PostalCode { get; }
				public PXTextEditColumnFilter Address__State_description { get; }
				public PXTextEditColumnFilter Address__CountryID_description { get; }
				public SelectorColumnFilter CPriceClassID { get; }
				public PXTextEditColumnFilter CreatedByID_Description { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXTextEditColumnFilter LastModifiedByID_Description { get; }
				public DateSelectorColumnFilter LastModifiedDateTime { get; }
				public SelectorColumnFilter CDefProjectID { get; }
				public PXTextEditColumnFilter TaxRegistrationID { get; }
				public SelectorColumnFilter CTaxZoneID { get; }
				public DropDownColumnFilter CTaxCalcMode { get; }
				public PXTextEditColumnFilter CAvalaraExemptionNumber { get; }
				public DropDownColumnFilter CAvalaraCustomerUsageType { get; }
				public SelectorColumnFilter CSiteID { get; }
				public SelectorColumnFilter CCarrierID { get; }
				public SelectorColumnFilter CShipTermsID { get; }
				public SelectorColumnFilter CShipZoneID { get; }
				public SelectorColumnFilter CFOBPointID { get; }
				public PXTextEditColumnFilter CResedential { get; }
				public PXTextEditColumnFilter CSaturdayDelivery { get; }
				public PXTextEditColumnFilter CInsurance { get; }
				public DropDownColumnFilter CShipComplete { get; }
				public PXNumberEditColumnFilter COrderPriority { get; }
				public PXNumberEditColumnFilter CLeadTime { get; }
				public SelectorColumnFilter CCalendarID { get; }
				public SelectorColumnFilter CSalesAcctID { get; }
				public SelectorColumnFilter CSalesSubID { get; }
				public SelectorColumnFilter CARAccountID { get; }
				public SelectorColumnFilter CARSubID { get; }
				public SelectorColumnFilter CDiscountAcctID { get; }
				public SelectorColumnFilter CDiscountSubID { get; }
				public SelectorColumnFilter CFreightAcctID { get; }
				public SelectorColumnFilter CFreightSubID { get; }
				public SelectorColumnFilter CBranchID { get; }
				public PXTextEditColumnFilter CBranchID_description { get; }
				public PXNumberEditColumnFilter BAccountID { get; }
                
                public c_grid_header(c_locations_grdlocations grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    LocationCD = new SelectorColumnFilter(grid.Row.LocationCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    Address__City = new PXTextEditColumnFilter(grid.Row.Address__City);
                    Address__State = new SelectorColumnFilter(grid.Row.Address__State);
                    Address__CountryID = new SelectorColumnFilter(grid.Row.Address__CountryID);
                    Address__PostalCode = new PXTextEditColumnFilter(grid.Row.Address__PostalCode);
                    Address__State_description = new PXTextEditColumnFilter(grid.Row.Address__State_description);
                    Address__CountryID_description = new PXTextEditColumnFilter(grid.Row.Address__CountryID_description);
                    CPriceClassID = new SelectorColumnFilter(grid.Row.CPriceClassID);
                    CreatedByID_Description = new PXTextEditColumnFilter(grid.Row.CreatedByID_Description);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    LastModifiedByID_Description = new PXTextEditColumnFilter(grid.Row.LastModifiedByID_Description);
                    LastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.LastModifiedDateTime);
                    CDefProjectID = new SelectorColumnFilter(grid.Row.CDefProjectID);
                    TaxRegistrationID = new PXTextEditColumnFilter(grid.Row.TaxRegistrationID);
                    CTaxZoneID = new SelectorColumnFilter(grid.Row.CTaxZoneID);
                    CTaxCalcMode = new DropDownColumnFilter(grid.Row.CTaxCalcMode);
                    CAvalaraExemptionNumber = new PXTextEditColumnFilter(grid.Row.CAvalaraExemptionNumber);
                    CAvalaraCustomerUsageType = new DropDownColumnFilter(grid.Row.CAvalaraCustomerUsageType);
                    CSiteID = new SelectorColumnFilter(grid.Row.CSiteID);
                    CCarrierID = new SelectorColumnFilter(grid.Row.CCarrierID);
                    CShipTermsID = new SelectorColumnFilter(grid.Row.CShipTermsID);
                    CShipZoneID = new SelectorColumnFilter(grid.Row.CShipZoneID);
                    CFOBPointID = new SelectorColumnFilter(grid.Row.CFOBPointID);
                    CResedential = new PXTextEditColumnFilter(grid.Row.CResedential);
                    CSaturdayDelivery = new PXTextEditColumnFilter(grid.Row.CSaturdayDelivery);
                    CInsurance = new PXTextEditColumnFilter(grid.Row.CInsurance);
                    CShipComplete = new DropDownColumnFilter(grid.Row.CShipComplete);
                    COrderPriority = new PXNumberEditColumnFilter(grid.Row.COrderPriority);
                    CLeadTime = new PXNumberEditColumnFilter(grid.Row.CLeadTime);
                    CCalendarID = new SelectorColumnFilter(grid.Row.CCalendarID);
                    CSalesAcctID = new SelectorColumnFilter(grid.Row.CSalesAcctID);
                    CSalesSubID = new SelectorColumnFilter(grid.Row.CSalesSubID);
                    CARAccountID = new SelectorColumnFilter(grid.Row.CARAccountID);
                    CARSubID = new SelectorColumnFilter(grid.Row.CARSubID);
                    CDiscountAcctID = new SelectorColumnFilter(grid.Row.CDiscountAcctID);
                    CDiscountSubID = new SelectorColumnFilter(grid.Row.CDiscountSubID);
                    CFreightAcctID = new SelectorColumnFilter(grid.Row.CFreightAcctID);
                    CFreightSubID = new SelectorColumnFilter(grid.Row.CFreightSubID);
                    CBranchID = new SelectorColumnFilter(grid.Row.CBranchID);
                    CBranchID_description = new PXTextEditColumnFilter(grid.Row.CBranchID_description);
                    BAccountID = new PXNumberEditColumnFilter(grid.Row.BAccountID);
                }
            }
        }
        
        public class c_locations_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_locations_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t4_grdLocations_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t4_grdLocations_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t4_grdLocations_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t4_grdLocations_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Locations";
            }
        }
        
        public class c_deflocation_deflocation : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideAddress { get; }
			public Label OverrideAddressLabel { get; }
			public CheckBox OverrideContact { get; }
			public Label OverrideContactLabel { get; }
			public Selector CBranchID { get; }
			public Label CBranchIDLabel { get; }
			public Selector CPriceClassID { get; }
			public Label CPriceClassIDLabel { get; }
			public Selector CDefProjectID { get; }
			public Label CDefProjectIDLabel { get; }
			public PXTextEdit TaxRegistrationID { get; }
			public Label TaxRegistrationIDLabel { get; }
			public Selector CTaxZoneID { get; }
			public Label CTaxZoneIDLabel { get; }
			public DropDown CTaxCalcMode { get; }
			public Label CTaxCalcModeLabel { get; }
			public PXTextEdit CAvalaraExemptionNumber { get; }
			public Label CAvalaraExemptionNumberLabel { get; }
			public DropDown CAvalaraCustomerUsageType { get; }
			public Label CAvalaraCustomerUsageTypeLabel { get; }
			public Selector CSiteID { get; }
			public Label CSiteIDLabel { get; }
			public Selector CCarrierID { get; }
			public Label CCarrierIDLabel { get; }
			public Selector CShipTermsID { get; }
			public Label CShipTermsIDLabel { get; }
			public Selector CShipZoneID { get; }
			public Label CShipZoneIDLabel { get; }
			public Selector CFOBPointID { get; }
			public Label CFOBPointIDLabel { get; }
			public CheckBox CResedential { get; }
			public Label CResedentialLabel { get; }
			public CheckBox CSaturdayDelivery { get; }
			public Label CSaturdayDeliveryLabel { get; }
			public CheckBox CInsurance { get; }
			public Label CInsuranceLabel { get; }
			public DropDown CShipComplete { get; }
			public Label CShipCompleteLabel { get; }
			public PXNumberEdit COrderPriority { get; }
			public Label COrderPriorityLabel { get; }
			public PXNumberEdit CLeadTime { get; }
			public Label CLeadTimeLabel { get; }
			public Selector CCalendarID { get; }
			public Label CCalendarIDLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
            
            public c_deflocation_deflocation(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkOverrideAddress", "Override", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                OverrideContact = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkOverrideContact", "Override", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                CBranchID = new Selector("ctl00_phG_tab_t3_DefLocation_edCBranchID", "Default Branch", locator, null);
                CBranchIDLabel = new Label(CBranchID);
                CBranchID.DataField = "CBranchID";
                CPriceClassID = new Selector("ctl00_phG_tab_t3_DefLocation_edCPriceClassID", "Price Class", locator, null);
                CPriceClassIDLabel = new Label(CPriceClassID);
                CPriceClassID.DataField = "CPriceClassID";
                CDefProjectID = new Selector("ctl00_phG_tab_t3_DefLocation_edCDefProjectID", "Default Project", locator, null);
                CDefProjectIDLabel = new Label(CDefProjectID);
                CDefProjectID.DataField = "CDefProjectID";
                TaxRegistrationID = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_edTaxRegistrationID", "Tax Registration ID", locator, null);
                TaxRegistrationIDLabel = new Label(TaxRegistrationID);
                TaxRegistrationID.DataField = "TaxRegistrationID";
                CTaxZoneID = new Selector("ctl00_phG_tab_t3_DefLocation_edCTaxZoneID", "Tax Zone", locator, null);
                CTaxZoneIDLabel = new Label(CTaxZoneID);
                CTaxZoneID.DataField = "CTaxZoneID";
                CTaxCalcMode = new DropDown("ctl00_phG_tab_t3_DefLocation_edCTaxCalcMode", "Tax Calculation Mode", locator, null);
                CTaxCalcModeLabel = new Label(CTaxCalcMode);
                CTaxCalcMode.DataField = "CTaxCalcMode";
                CTaxCalcMode.Items.Add("T", "Tax Settings");
                CTaxCalcMode.Items.Add("G", "Gross");
                CTaxCalcMode.Items.Add("N", "Net");
                CAvalaraExemptionNumber = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_edCAvalaraExemptionNumber", "Tax Exemption Number", locator, null);
                CAvalaraExemptionNumberLabel = new Label(CAvalaraExemptionNumber);
                CAvalaraExemptionNumber.DataField = "CAvalaraExemptionNumber";
                CAvalaraCustomerUsageType = new DropDown("ctl00_phG_tab_t3_DefLocation_edCAvalaraCustomerUsageType", "Entity Usage Type", locator, null);
                CAvalaraCustomerUsageTypeLabel = new Label(CAvalaraCustomerUsageType);
                CAvalaraCustomerUsageType.DataField = "CAvalaraCustomerUsageType";
                CAvalaraCustomerUsageType.Items.Add("A", "Federal Government");
                CAvalaraCustomerUsageType.Items.Add("B", "State/Local Govt.");
                CAvalaraCustomerUsageType.Items.Add("C", "Tribal Government");
                CAvalaraCustomerUsageType.Items.Add("D", "Foreign Diplomat");
                CAvalaraCustomerUsageType.Items.Add("E", "Charitable Organization");
                CAvalaraCustomerUsageType.Items.Add("F", "Religious");
                CAvalaraCustomerUsageType.Items.Add("G", "Resale");
                CAvalaraCustomerUsageType.Items.Add("H", "Agricultural Production");
                CAvalaraCustomerUsageType.Items.Add("I", "Industrial Prod/Mfg.");
                CAvalaraCustomerUsageType.Items.Add("J", "Direct Pay Permit");
                CAvalaraCustomerUsageType.Items.Add("K", "Direct Mail");
                CAvalaraCustomerUsageType.Items.Add("L", "Other");
                CAvalaraCustomerUsageType.Items.Add("M", "Education");
                CAvalaraCustomerUsageType.Items.Add("N", "Local Government");
                CAvalaraCustomerUsageType.Items.Add("P", "Commercial Aquaculture");
                CAvalaraCustomerUsageType.Items.Add("Q", "Commercial Fishery");
                CAvalaraCustomerUsageType.Items.Add("R", "Non-resident");
                CAvalaraCustomerUsageType.Items.Add("0", "Default");
                CSiteID = new Selector("ctl00_phG_tab_t3_DefLocation_edCSiteID", "Warehouse", locator, null);
                CSiteIDLabel = new Label(CSiteID);
                CSiteID.DataField = "CSiteID";
                CCarrierID = new Selector("ctl00_phG_tab_t3_DefLocation_edCarrierID", "Ship Via", locator, null);
                CCarrierIDLabel = new Label(CCarrierID);
                CCarrierID.DataField = "CCarrierID";
                CShipTermsID = new Selector("ctl00_phG_tab_t3_DefLocation_edShipTermsID", "Shipping Terms", locator, null);
                CShipTermsIDLabel = new Label(CShipTermsID);
                CShipTermsID.DataField = "CShipTermsID";
                CShipZoneID = new Selector("ctl00_phG_tab_t3_DefLocation_edShipZoneID", "Shipping Zone", locator, null);
                CShipZoneIDLabel = new Label(CShipZoneID);
                CShipZoneID.DataField = "CShipZoneID";
                CFOBPointID = new Selector("ctl00_phG_tab_t3_DefLocation_edFOBPointID", "FOB Point", locator, null);
                CFOBPointIDLabel = new Label(CFOBPointID);
                CFOBPointID.DataField = "CFOBPointID";
                CResedential = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkResedential", "Residential Delivery", locator, null);
                CResedentialLabel = new Label(CResedential);
                CResedential.DataField = "CResedential";
                CSaturdayDelivery = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkSaturdayDelivery", "Saturday Delivery", locator, null);
                CSaturdayDeliveryLabel = new Label(CSaturdayDelivery);
                CSaturdayDelivery.DataField = "CSaturdayDelivery";
                CInsurance = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkInsurance", "Insurance", locator, null);
                CInsuranceLabel = new Label(CInsurance);
                CInsurance.DataField = "CInsurance";
                CShipComplete = new DropDown("ctl00_phG_tab_t3_DefLocation_edCShipComplete", "Shipping Rule", locator, null);
                CShipCompleteLabel = new Label(CShipComplete);
                CShipComplete.DataField = "CShipComplete";
                CShipComplete.Items.Add("C", "Ship Complete");
                CShipComplete.Items.Add("B", "Back Order Allowed");
                CShipComplete.Items.Add("L", "Cancel Remainder");
                COrderPriority = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_edCOrderPriority", "Order Priority", locator, null);
                COrderPriorityLabel = new Label(COrderPriority);
                COrderPriority.DataField = "COrderPriority";
                CLeadTime = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_edLeadTime", "Lead Time (Days)", locator, null);
                CLeadTimeLabel = new Label(CLeadTime);
                CLeadTime.DataField = "CLeadTime";
                CCalendarID = new Selector("ctl00_phG_tab_t3_DefLocation_edCCalendarID", "Calendar", locator, null);
                CCalendarIDLabel = new Label(CCalendarID);
                CCalendarID.DataField = "CCalendarID";
                LblPhone1_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblFax", "Lbl Fax _", locator, null);
                DataMemberName = "DefLocation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CBranchIDEdit()
            {
                Buttons.CBranchIDEdit.Click();
            }
            
            public virtual void CPriceClassIDEdit()
            {
                Buttons.CPriceClassIDEdit.Click();
            }
            
            public virtual void CDefProjectIDEdit()
            {
                Buttons.CDefProjectIDEdit.Click();
            }
            
            public virtual void CTaxZoneIDEdit()
            {
                Buttons.CTaxZoneIDEdit.Click();
            }
            
            public virtual void CSiteIDEdit()
            {
                Buttons.CSiteIDEdit.Click();
            }
            
            public virtual void CCarrierIDEdit()
            {
                Buttons.CCarrierIDEdit.Click();
            }
            
            public virtual void CShipTermsIDEdit()
            {
                Buttons.CShipTermsIDEdit.Click();
            }
            
            public virtual void CShipZoneIDEdit()
            {
                Buttons.CShipZoneIDEdit.Click();
            }
            
            public virtual void CFOBPointIDEdit()
            {
                Buttons.CFOBPointIDEdit.Click();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
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
                
			public Button CBranchIDEdit { get; }
			public Button CPriceClassIDEdit { get; }
			public Button CDefProjectIDEdit { get; }
			public Button CTaxZoneIDEdit { get; }
			public Button CSiteIDEdit { get; }
			public Button CCarrierIDEdit { get; }
			public Button CShipTermsIDEdit { get; }
			public Button CShipZoneIDEdit { get; }
			public Button CFOBPointIDEdit { get; }
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    CBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CBranchIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CPriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCPriceClassID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CPriceClassIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CPriceClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CDefProjectIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCDefProjectID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CDefProjectIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CDefProjectIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCTaxZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CTaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCSiteID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "CSiteIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCarrierID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CCarrierIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "CShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CShipTermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CShipZoneIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CShipZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    CFOBPointIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation");
                    First = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfFirst0", "First", "ctl00_phG_tab_t3_DefLocation");
                    Prev = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfPrev0", "Prev", "ctl00_phG_tab_t3_DefLocation");
                    Next = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfNext0", "Next", "ctl00_phG_tab_t3_DefLocation");
                    Last = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfLast0", "Last", "ctl00_phG_tab_t3_DefLocation");
                }
            }
        }
        
        public class c_deflocation_deflocationaccount : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CARAccountID { get; }
			public Label CARAccountIDLabel { get; }
			public Selector CARSubID { get; }
			public Label CARSubIDLabel { get; }
			public Selector CSalesAcctID { get; }
			public Label CSalesAcctIDLabel { get; }
			public Selector CSalesSubID { get; }
			public Label CSalesSubIDLabel { get; }
			public Selector CDiscountAcctID { get; }
			public Label CDiscountAcctIDLabel { get; }
			public Selector CDiscountSubID { get; }
			public Label CDiscountSubIDLabel { get; }
			public Selector CFreightAcctID { get; }
			public Label CFreightAcctIDLabel { get; }
			public Selector CFreightSubID { get; }
			public Label CFreightSubIDLabel { get; }
            
            public c_deflocation_deflocationaccount(string locator, string name) : 
                    base(locator, name)
            {
                CARAccountID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCARAccountID", "AR Account", locator, null);
                CARAccountIDLabel = new Label(CARAccountID);
                CARAccountID.DataField = "CARAccountID";
                CARSubID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCARSubID", "AR Sub.", locator, null);
                CARSubIDLabel = new Label(CARSubID);
                CARSubID.DataField = "CARSubID";
                CSalesAcctID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCSalesAcctID", "Sales Account", locator, null);
                CSalesAcctIDLabel = new Label(CSalesAcctID);
                CSalesAcctID.DataField = "CSalesAcctID";
                CSalesSubID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCSalesSubID", "Sales Sub.", locator, null);
                CSalesSubIDLabel = new Label(CSalesSubID);
                CSalesSubID.DataField = "CSalesSubID";
                CDiscountAcctID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCDiscountAcctID", "Discount Account", locator, null);
                CDiscountAcctIDLabel = new Label(CDiscountAcctID);
                CDiscountAcctID.DataField = "CDiscountAcctID";
                CDiscountSubID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCDiscountSubID", "Discount Sub.", locator, null);
                CDiscountSubIDLabel = new Label(CDiscountSubID);
                CDiscountSubID.DataField = "CDiscountSubID";
                CFreightAcctID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCFreightAcctID", "Freight Account", locator, null);
                CFreightAcctIDLabel = new Label(CFreightAcctID);
                CFreightAcctID.DataField = "CFreightAcctID";
                CFreightSubID = new Selector("ctl00_phG_tab_t11_DefLocationAccount_edCFreightSubID", "Freight Sub.", locator, null);
                CFreightSubIDLabel = new Label(CFreightSubID);
                CFreightSubID.DataField = "CFreightSubID";
                DataMemberName = "DefLocation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CARSubIDEdit()
            {
                Buttons.CARSubIDEdit.Click();
            }
            
            public virtual void CSalesSubIDEdit()
            {
                Buttons.CSalesSubIDEdit.Click();
            }
            
            public virtual void CDiscountSubIDEdit()
            {
                Buttons.CDiscountSubIDEdit.Click();
            }
            
            public virtual void CFreightSubIDEdit()
            {
                Buttons.CFreightSubIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CARSubIDEdit { get; }
			public Button CSalesSubIDEdit { get; }
			public Button CDiscountSubIDEdit { get; }
			public Button CFreightSubIDEdit { get; }
                
                public PxButtonCollection()
                {
                    CARSubIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_DefLocationAccount_edCARSubID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "CARSubIDEdit", "ctl00_phG_tab_t11_DefLocationAccount");
                    CARSubIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CSalesSubIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_DefLocationAccount_edCSalesSubID\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "CSalesSubIDEdit", "ctl00_phG_tab_t11_DefLocationAccount");
                    CSalesSubIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CDiscountSubIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_DefLocationAccount_edCDiscountSubID\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "CDiscountSubIDEdit", "ctl00_phG_tab_t11_DefLocationAccount");
                    CDiscountSubIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CFreightSubIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_DefLocationAccount_edCFreightSubID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "CFreightSubIDEdit", "ctl00_phG_tab_t11_DefLocationAccount");
                    CFreightSubIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_deflocation_formretainage : Container
        {
            
			public Selector CRetainageAcctID { get; }
			public Label CRetainageAcctIDLabel { get; }
			public Selector CRetainageSubID { get; }
			public Label CRetainageSubIDLabel { get; }
            
            public c_deflocation_formretainage(string locator, string name) : 
                    base(locator, name)
            {
                CRetainageAcctID = new Selector("ctl00_phG_tab_t11_formRetainage_edCRetainageAcctID", "Retainage Receivable Account", locator, null);
                CRetainageAcctIDLabel = new Label(CRetainageAcctID);
                CRetainageAcctID.DataField = "CRetainageAcctID";
                CRetainageSubID = new Selector("ctl00_phG_tab_t11_formRetainage_edCRetainageSubID", "Retainage Receivable Sub.", locator, null);
                CRetainageSubIDLabel = new Label(CRetainageSubID);
                CRetainageSubID.DataField = "CRetainageSubID";
                DataMemberName = "DefLocation";
            }
        }
        
        public class c_billaddress_billaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_billaddress_billaddress(string locator, string name) : 
                    base(locator, name)
            {
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t2_BillAddress_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t2_BillAddress_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t2_BillAddress_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                State = new Selector("ctl00_phG_tab_t2_BillAddress_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t2_BillAddress_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                CountryID = new Selector("ctl00_phG_tab_t2_BillAddress_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                IsValidated = new CheckBox("ctl00_phG_tab_t2_BillAddress_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "BillAddress";
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
            
            public virtual void BillingCycleIDEdit()
            {
                Buttons.BillingCycleIDEdit.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button BillingCycleIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_BillAddress_btnBillingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_BillAddress");
                    ViewonMap = new Button("ctl00_phG_tab_t2_BillAddress_btnViewBillAddressOnMap", "View on Map", "ctl00_phG_tab_t2_BillAddress");
                    BillingCycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edBillingCycleID1\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "BillingCycleIDEdit", "ctl00_phG_tab_t2_BillAddress");
                    BillingCycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfFirst0", "First", "ctl00_phG_tab_t2_BillAddress");
                    Prev = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_BillAddress");
                    Next = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfNext0", "Next", "ctl00_phG_tab_t2_BillAddress");
                    Last = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfLast0", "Last", "ctl00_phG_tab_t2_BillAddress");
                }
            }
        }
        
        public class c_defaddress_defaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_defaddress_defaddress(string locator, string name) : 
                    base(locator, name)
            {
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                State = new Selector("ctl00_phG_tab_t0_DefAddress_edDefAddressState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                CountryID = new Selector("ctl00_phG_tab_t0_DefAddress_edDefAddressCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                IsValidated = new CheckBox("ctl00_phG_tab_t0_DefAddress_edDefAddressIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "DefAddress";
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
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_DefAddress");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefAddress");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_DefAddress");
                    PrimaryContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_deflocationaddress_deflocationaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_deflocationaddress_deflocationaddress(string locator, string name) : 
                    base(locator, name)
            {
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                State = new Selector("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                CountryID = new Selector("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                IsValidated = new CheckBox("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "DefLocationAddress";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void CBranchIDEdit()
            {
                Buttons.CBranchIDEdit.Click();
            }
            
            public virtual void CPriceClassIDEdit()
            {
                Buttons.CPriceClassIDEdit.Click();
            }
            
            public virtual void CDefProjectIDEdit()
            {
                Buttons.CDefProjectIDEdit.Click();
            }
            
            public virtual void CTaxZoneIDEdit()
            {
                Buttons.CTaxZoneIDEdit.Click();
            }
            
            public virtual void CCarrierIDEdit()
            {
                Buttons.CCarrierIDEdit.Click();
            }
            
            public virtual void CShipTermsIDEdit()
            {
                Buttons.CShipTermsIDEdit.Click();
            }
            
            public virtual void CShipZoneIDEdit()
            {
                Buttons.CShipZoneIDEdit.Click();
            }
            
            public virtual void CFOBPointIDEdit()
            {
                Buttons.CFOBPointIDEdit.Click();
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
                
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button CBranchIDEdit { get; }
			public Button CPriceClassIDEdit { get; }
			public Button CDefProjectIDEdit { get; }
			public Button CTaxZoneIDEdit { get; }
			public Button CCarrierIDEdit { get; }
			public Button CShipTermsIDEdit { get; }
			public Button CShipZoneIDEdit { get; }
			public Button CFOBPointIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CBranchIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CPriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCPriceClassID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CPriceClassIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CPriceClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CDefProjectIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCDefProjectID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CDefProjectIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CDefProjectIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCTaxZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CTaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCarrierID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CCarrierIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "CShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CShipTermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CShipZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CShipZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    CFOBPointIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfFirst0", "First", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    Prev = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfPrev0", "Prev", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    Next = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfNext0", "Next", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    Last = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfLast0", "Last", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                }
            }
        }
        
        public class c_billcontact_billcontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public DropDown FaxType { get; }
			public Label FaxTypeLabel { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
            
            public c_billcontact_billcontact(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t2_BillContact_edFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t2_BillContact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1Type = new DropDown("ctl00_phG_tab_t2_BillContact_Phone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t2_BillContact_PXMaskEdit1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t2_BillContact_Phone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t2_BillContact_PXMaskEdit2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                FaxType = new DropDown("ctl00_phG_tab_t2_BillContact_FaxType", "Fax Type", locator, null);
                FaxTypeLabel = new Label(FaxType);
                FaxType.DataField = "FaxType";
                FaxType.Items.Add("B1", "Business 1");
                FaxType.Items.Add("B2", "Business 2");
                FaxType.Items.Add("B3", "Business 3");
                FaxType.Items.Add("C", "Cell");
                FaxType.Items.Add("BA1", "Assistant");
                FaxType.Items.Add("BF", "Fax");
                FaxType.Items.Add("H1", "Home");
                FaxType.Items.Add("HF", "Home Fax");
                Fax = new PXTextEdit("ctl00_phG_tab_t2_BillContact_PXMaskEdit3", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t2_BillContact_edEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t2_BillContact_edWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                LblPhone1_ = new Label("ctl00_phG_tab_t2_BillContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t2_BillContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t2_BillContact_lblFax", "Lbl Fax _", locator, null);
                DataMemberName = "BillContact";
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
            
            public virtual void BillingCycleIDEdit()
            {
                Buttons.BillingCycleIDEdit.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button BillingCycleIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_BillAddress_btnBillingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_BillContact");
                    ViewonMap = new Button("ctl00_phG_tab_t2_BillAddress_btnViewBillAddressOnMap", "View on Map", "ctl00_phG_tab_t2_BillContact");
                    BillingCycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edBillingCycleID1\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "BillingCycleIDEdit", "ctl00_phG_tab_t2_BillContact");
                    BillingCycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfFirst0", "First", "ctl00_phG_tab_t2_BillContact");
                    Prev = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_BillContact");
                    Next = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfNext0", "Next", "ctl00_phG_tab_t2_BillContact");
                    Last = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfLast0", "Last", "ctl00_phG_tab_t2_BillContact");
                }
            }
        }
        
        public class c_contacts_grdcontacts : Grid<c_contacts_grdcontacts.c_grid_row, c_contacts_grdcontacts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_contacts_grdcontacts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_grdContacts");
                DataMemberName = "Contacts";
                PredefinedFilter = new DropDown("ctl00_phG_tab_t6_grdContacts_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                QuickSearch = new QuickSearch("ctl00_phG_tab_t6_grdContacts_at_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_grdContacts_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void CreateContact()
            {
                ToolBar.CreateContact.Click();
            }
            
            public virtual void CreateContact(bool status, string message = null)
            {
                ToolBar.CreateContact.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
                ToolBar.CreateContact.Click();
            }
            
            public virtual void ContactDetails()
            {
                ToolBar.ContactDetails.Click();
            }
            
            public virtual void MakeContactPrimary()
            {
                ToolBar.MakeContactPrimary.Click();
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
			public ToolBarButtonGrid CreateContact { get; }
			public ToolBarButtonGrid ContactDetails { get; }
			public ToolBarButtonGrid MakeContactPrimary { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    CreateContact = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'CreateContact\']", "Add New Contact", locator, null);
                    CreateContact.WaitAction = Wait.WaitForLongOperationToComplete;
                    ContactDetails = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'cmdViewContact\']", "Contact Details", locator, null);
                    MakeContactPrimary = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'MakeContactPrimary\']", "Set as Primary", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdContacts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsActive { get; }
			public Selector DisplayName { get; }
			public PXTextEdit Salutation { get; }
			public CheckBox IsPrimary { get; }
			public PXTextEdit EMail { get; }
			public PXTextEdit Phone1 { get; }
			public Selector OwnerID { get; }
			public PXTextEdit FullName { get; }
			public Selector ClassID { get; }
			public DateSelector LastModifiedDateTime { get; }
			public DateSelector CreatedDateTime { get; }
			public DropDown Source { get; }
			public DateSelector AssignDate { get; }
			public DropDown DuplicateStatus { get; }
			public PXTextEdit Phone2 { get; }
			public PXTextEdit Phone3 { get; }
			public DateSelector DateOfBirth { get; }
			public PXTextEdit Fax { get; }
			public DropDown Gender { get; }
			public DropDown Method { get; }
			public CheckBox NoCall { get; }
			public CheckBox NoEMail { get; }
			public CheckBox NoFax { get; }
			public CheckBox NoMail { get; }
			public CheckBox NoMarketing { get; }
			public CheckBox NoMassMail { get; }
			public Selector CampaignID { get; }
			public DropDown Phone1Type { get; }
			public DropDown Phone2Type { get; }
			public DropDown Phone3Type { get; }
			public DropDown FaxType { get; }
			public DropDown MaritalStatus { get; }
			public PXTextEdit Spouse { get; }
			public DropDown Status { get; }
			public DropDown Resolution { get; }
			public Selector LanguageID { get; }
			public Selector Address__CountryID { get; }
			public Selector Address__State { get; }
			public PXTextEdit Address__City { get; }
			public PXTextEdit Address__AddressLine1 { get; }
			public PXTextEdit Address__AddressLine2 { get; }
			public PXTextEdit Address__PostalCode { get; }
			public CheckBox CanBeMadePrimary { get; }
			public PXNumberEdit ContactID { get; }
                
                public c_grid_row(c_contacts_grdcontacts grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsActive = new CheckBox("ctl00_phG_tab_t6_grdContacts_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    DisplayName = new Selector("_ctl00_phG_tab_t6_grdContacts_lv0_es", "Contact", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Salutation = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Job Title", grid.Locator, "Salutation");
                    Salutation.DataField = "Salutation";
                    IsPrimary = new CheckBox("ctl00_phG_tab_t6_grdContacts", "Primary", grid.Locator, "IsPrimary");
                    IsPrimary.DataField = "IsPrimary";
                    EMail = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Email", grid.Locator, "EMail");
                    EMail.DataField = "EMail";
                    Phone1 = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Phone 1", grid.Locator, "Phone1");
                    Phone1.DataField = "Phone1";
                    OwnerID = new Selector("_ctl00_phG_tab_t6_grdContacts_lv0_es", "Owner", grid.Locator, "OwnerID");
                    OwnerID.DataField = "OwnerID";
                    FullName = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Account Name", grid.Locator, "FullName");
                    FullName.DataField = "FullName";
                    ClassID = new Selector("_ctl00_phG_tab_t6_grdContacts_lv0_es", "Class ID", grid.Locator, "ClassID");
                    ClassID.DataField = "ClassID";
                    LastModifiedDateTime = new DateSelector("_ctl00_phG_tab_t6_grdContacts_lv0_ed11", "Last Modified On", grid.Locator, "LastModifiedDateTime");
                    LastModifiedDateTime.DataField = "LastModifiedDateTime";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t6_grdContacts_lv0_ed12", "Created On", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    Source = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Source", grid.Locator, "Source");
                    Source.DataField = "Source";
                    Source.Items.Add("S", "Organic Search");
                    Source.Items.Add("C", "Campaign");
                    Source.Items.Add("R", "Referral");
                    Source.Items.Add("O", "Other");
                    Source.Items.Add("W", "Web");
                    Source.Items.Add("H", "Phone Inquiry");
                    Source.Items.Add("L", "Purchased List");
                    AssignDate = new DateSelector("_ctl00_phG_tab_t6_grdContacts_lv0_ed14", "Assignment Date", grid.Locator, "AssignDate");
                    AssignDate.DataField = "AssignDate";
                    DuplicateStatus = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Duplicate", grid.Locator, "DuplicateStatus");
                    DuplicateStatus.DataField = "DuplicateStatus";
                    DuplicateStatus.Items.Add("NV", "Not Validated");
                    DuplicateStatus.Items.Add("VA", "Validated");
                    DuplicateStatus.Items.Add("PD", "Possible Duplicate");
                    DuplicateStatus.Items.Add("DD", "Duplicated");
                    Phone2 = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Phone 2", grid.Locator, "Phone2");
                    Phone2.DataField = "Phone2";
                    Phone3 = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Phone 3", grid.Locator, "Phone3");
                    Phone3.DataField = "Phone3";
                    DateOfBirth = new DateSelector("_ctl00_phG_tab_t6_grdContacts_lv0_ed18", "Date Of Birth", grid.Locator, "DateOfBirth");
                    DateOfBirth.DataField = "DateOfBirth";
                    Fax = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Fax", grid.Locator, "Fax");
                    Fax.DataField = "Fax";
                    Gender = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Gender", grid.Locator, "Gender");
                    Gender.DataField = "Gender";
                    Gender.Items.Add("M", "Male");
                    Gender.Items.Add("F", "Female");
                    Method = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Contact Method", grid.Locator, "Method");
                    Method.DataField = "Method";
                    Method.Items.Add("A", "Any");
                    Method.Items.Add("E", "Email");
                    Method.Items.Add("M", "Mail");
                    Method.Items.Add("F", "Fax");
                    Method.Items.Add("P", "Phone");
                    NoCall = new CheckBox("ctl00_phG_tab_t6_grdContacts_ef", "Do Not Call", grid.Locator, "NoCall");
                    NoCall.DataField = "NoCall";
                    NoEMail = new CheckBox("ctl00_phG_tab_t6_grdContacts_ef", "Do Not Email", grid.Locator, "NoEMail");
                    NoEMail.DataField = "NoEMail";
                    NoFax = new CheckBox("ctl00_phG_tab_t6_grdContacts_ef", "Do Not Fax", grid.Locator, "NoFax");
                    NoFax.DataField = "NoFax";
                    NoMail = new CheckBox("ctl00_phG_tab_t6_grdContacts_ef", "Do Not Mail", grid.Locator, "NoMail");
                    NoMail.DataField = "NoMail";
                    NoMarketing = new CheckBox("ctl00_phG_tab_t6_grdContacts_ef", "No Marketing", grid.Locator, "NoMarketing");
                    NoMarketing.DataField = "NoMarketing";
                    NoMassMail = new CheckBox("ctl00_phG_tab_t6_grdContacts_ef", "No Mass Mail", grid.Locator, "NoMassMail");
                    NoMassMail.DataField = "NoMassMail";
                    CampaignID = new Selector("_ctl00_phG_tab_t6_grdContacts_lv0_es", "Source Campaign", grid.Locator, "CampaignID");
                    CampaignID.DataField = "CampaignID";
                    Phone1Type = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Phone 1 Type", grid.Locator, "Phone1Type");
                    Phone1Type.DataField = "Phone1Type";
                    Phone1Type.Items.Add("B1", "Business 1");
                    Phone1Type.Items.Add("B2", "Business 2");
                    Phone1Type.Items.Add("B3", "Business 3");
                    Phone1Type.Items.Add("C", "Cell");
                    Phone1Type.Items.Add("BA1", "Assistant");
                    Phone1Type.Items.Add("BF", "Fax");
                    Phone1Type.Items.Add("H1", "Home");
                    Phone1Type.Items.Add("HF", "Home Fax");
                    Phone2Type = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Phone 2 Type", grid.Locator, "Phone2Type");
                    Phone2Type.DataField = "Phone2Type";
                    Phone2Type.Items.Add("B1", "Business 1");
                    Phone2Type.Items.Add("B2", "Business 2");
                    Phone2Type.Items.Add("B3", "Business 3");
                    Phone2Type.Items.Add("C", "Cell");
                    Phone2Type.Items.Add("BA1", "Assistant");
                    Phone2Type.Items.Add("BF", "Fax");
                    Phone2Type.Items.Add("H1", "Home");
                    Phone2Type.Items.Add("HF", "Home Fax");
                    Phone3Type = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Phone 3 Type", grid.Locator, "Phone3Type");
                    Phone3Type.DataField = "Phone3Type";
                    Phone3Type.Items.Add("B1", "Business 1");
                    Phone3Type.Items.Add("B2", "Business 2");
                    Phone3Type.Items.Add("B3", "Business 3");
                    Phone3Type.Items.Add("C", "Cell");
                    Phone3Type.Items.Add("BA1", "Assistant");
                    Phone3Type.Items.Add("BF", "Fax");
                    Phone3Type.Items.Add("H1", "Home");
                    Phone3Type.Items.Add("HF", "Home Fax");
                    FaxType = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Fax Type", grid.Locator, "FaxType");
                    FaxType.DataField = "FaxType";
                    FaxType.Items.Add("B1", "Business 1");
                    FaxType.Items.Add("B2", "Business 2");
                    FaxType.Items.Add("B3", "Business 3");
                    FaxType.Items.Add("C", "Cell");
                    FaxType.Items.Add("BA1", "Assistant");
                    FaxType.Items.Add("BF", "Fax");
                    FaxType.Items.Add("H1", "Home");
                    FaxType.Items.Add("HF", "Home Fax");
                    MaritalStatus = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Marital Status", grid.Locator, "MaritalStatus");
                    MaritalStatus.DataField = "MaritalStatus";
                    MaritalStatus.Items.Add("S", "Single");
                    MaritalStatus.Items.Add("M", "Married");
                    MaritalStatus.Items.Add("D", "Divorced");
                    MaritalStatus.Items.Add("W", "Widowed");
                    Spouse = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Spouse/Partner Name", grid.Locator, "Spouse");
                    Spouse.DataField = "Spouse";
                    Status = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Resolution = new DropDown("_ctl00_phG_tab_t6_grdContacts_lv0_ec", "Reason", grid.Locator, "Resolution");
                    Resolution.DataField = "Resolution";
                    Resolution.Items.Add("AS", "Assign");
                    Resolution.Items.Add("IN", "In Process");
                    Resolution.Items.Add("OU", "Nurture");
                    Resolution.Items.Add("CA", "Abandoned");
                    Resolution.Items.Add("CD", "Duplicate");
                    Resolution.Items.Add("CL", "Unable to contact");
                    Resolution.Items.Add("EX", "External");
                    Resolution.Items.Add("RJ", "Disqualified");
                    Resolution.Items.Add("CU", "Unknown");
                    LanguageID = new Selector("_ctl00_phG_tab_t6_grdContacts_lv0_es", "Language/Locale", grid.Locator, "LanguageID");
                    LanguageID.DataField = "LanguageID";
                    Address__CountryID = new Selector("_ctl00_phG_tab_t6_grdContacts_lv0_es", "Country", grid.Locator, "Address__CountryID");
                    Address__CountryID.DataField = "Address__CountryID";
                    Address__State = new Selector("_ctl00_phG_tab_t6_grdContacts_lv0_es", "State", grid.Locator, "Address__State");
                    Address__State.DataField = "Address__State";
                    Address__City = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "City", grid.Locator, "Address__City");
                    Address__City.DataField = "Address__City";
                    Address__AddressLine1 = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Address Line 1", grid.Locator, "Address__AddressLine1");
                    Address__AddressLine1.DataField = "Address__AddressLine1";
                    Address__AddressLine2 = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Address Line 2", grid.Locator, "Address__AddressLine2");
                    Address__AddressLine2.DataField = "Address__AddressLine2";
                    Address__PostalCode = new PXTextEdit("ctl00_phG_tab_t6_grdContacts_ei", "Postal Code", grid.Locator, "Address__PostalCode");
                    Address__PostalCode.DataField = "Address__PostalCode";
                    CanBeMadePrimary = new CheckBox("ctl00_phG_tab_t6_grdContacts", "Can be made Primary", grid.Locator, "CanBeMadePrimary");
                    CanBeMadePrimary.DataField = "CanBeMadePrimary";
                    ContactID = new PXNumberEdit("ctl00_phG_tab_t6_grdContacts_en", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public SelectorColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Salutation { get; }
				public CheckBoxColumnFilter IsPrimary { get; }
				public PXTextEditColumnFilter EMail { get; }
				public PXTextEditColumnFilter Phone1 { get; }
				public SelectorColumnFilter OwnerID { get; }
				public PXTextEditColumnFilter FullName { get; }
				public SelectorColumnFilter ClassID { get; }
				public DateSelectorColumnFilter LastModifiedDateTime { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public DropDownColumnFilter Source { get; }
				public DateSelectorColumnFilter AssignDate { get; }
				public DropDownColumnFilter DuplicateStatus { get; }
				public PXTextEditColumnFilter Phone2 { get; }
				public PXTextEditColumnFilter Phone3 { get; }
				public DateSelectorColumnFilter DateOfBirth { get; }
				public PXTextEditColumnFilter Fax { get; }
				public DropDownColumnFilter Gender { get; }
				public DropDownColumnFilter Method { get; }
				public CheckBoxColumnFilter NoCall { get; }
				public CheckBoxColumnFilter NoEMail { get; }
				public CheckBoxColumnFilter NoFax { get; }
				public CheckBoxColumnFilter NoMail { get; }
				public CheckBoxColumnFilter NoMarketing { get; }
				public CheckBoxColumnFilter NoMassMail { get; }
				public SelectorColumnFilter CampaignID { get; }
				public DropDownColumnFilter Phone1Type { get; }
				public DropDownColumnFilter Phone2Type { get; }
				public DropDownColumnFilter Phone3Type { get; }
				public DropDownColumnFilter FaxType { get; }
				public DropDownColumnFilter MaritalStatus { get; }
				public PXTextEditColumnFilter Spouse { get; }
				public InputColumnFilter Status { get; }
				public DropDownColumnFilter Resolution { get; }
				public SelectorColumnFilter LanguageID { get; }
				public SelectorColumnFilter Address__CountryID { get; }
				public SelectorColumnFilter Address__State { get; }
				public PXTextEditColumnFilter Address__City { get; }
				public PXTextEditColumnFilter Address__AddressLine1 { get; }
				public PXTextEditColumnFilter Address__AddressLine2 { get; }
				public PXTextEditColumnFilter Address__PostalCode { get; }
				public CheckBoxColumnFilter CanBeMadePrimary { get; }
				public PXNumberEditColumnFilter ContactID { get; }
                
                public c_grid_header(c_contacts_grdcontacts grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    DisplayName = new SelectorColumnFilter(grid.Row.DisplayName);
                    Salutation = new PXTextEditColumnFilter(grid.Row.Salutation);
                    IsPrimary = new CheckBoxColumnFilter(grid.Row.IsPrimary);
                    EMail = new PXTextEditColumnFilter(grid.Row.EMail);
                    Phone1 = new PXTextEditColumnFilter(grid.Row.Phone1);
                    OwnerID = new SelectorColumnFilter(grid.Row.OwnerID);
                    FullName = new PXTextEditColumnFilter(grid.Row.FullName);
                    ClassID = new SelectorColumnFilter(grid.Row.ClassID);
                    LastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.LastModifiedDateTime);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    Source = new DropDownColumnFilter(grid.Row.Source);
                    AssignDate = new DateSelectorColumnFilter(grid.Row.AssignDate);
                    DuplicateStatus = new DropDownColumnFilter(grid.Row.DuplicateStatus);
                    Phone2 = new PXTextEditColumnFilter(grid.Row.Phone2);
                    Phone3 = new PXTextEditColumnFilter(grid.Row.Phone3);
                    DateOfBirth = new DateSelectorColumnFilter(grid.Row.DateOfBirth);
                    Fax = new PXTextEditColumnFilter(grid.Row.Fax);
                    Gender = new DropDownColumnFilter(grid.Row.Gender);
                    Method = new DropDownColumnFilter(grid.Row.Method);
                    NoCall = new CheckBoxColumnFilter(grid.Row.NoCall);
                    NoEMail = new CheckBoxColumnFilter(grid.Row.NoEMail);
                    NoFax = new CheckBoxColumnFilter(grid.Row.NoFax);
                    NoMail = new CheckBoxColumnFilter(grid.Row.NoMail);
                    NoMarketing = new CheckBoxColumnFilter(grid.Row.NoMarketing);
                    NoMassMail = new CheckBoxColumnFilter(grid.Row.NoMassMail);
                    CampaignID = new SelectorColumnFilter(grid.Row.CampaignID);
                    Phone1Type = new DropDownColumnFilter(grid.Row.Phone1Type);
                    Phone2Type = new DropDownColumnFilter(grid.Row.Phone2Type);
                    Phone3Type = new DropDownColumnFilter(grid.Row.Phone3Type);
                    FaxType = new DropDownColumnFilter(grid.Row.FaxType);
                    MaritalStatus = new DropDownColumnFilter(grid.Row.MaritalStatus);
                    Spouse = new PXTextEditColumnFilter(grid.Row.Spouse);
                    Status = new InputColumnFilter(grid.Row.Status);
                    Resolution = new DropDownColumnFilter(grid.Row.Resolution);
                    LanguageID = new SelectorColumnFilter(grid.Row.LanguageID);
                    Address__CountryID = new SelectorColumnFilter(grid.Row.Address__CountryID);
                    Address__State = new SelectorColumnFilter(grid.Row.Address__State);
                    Address__City = new PXTextEditColumnFilter(grid.Row.Address__City);
                    Address__AddressLine1 = new PXTextEditColumnFilter(grid.Row.Address__AddressLine1);
                    Address__AddressLine2 = new PXTextEditColumnFilter(grid.Row.Address__AddressLine2);
                    Address__PostalCode = new PXTextEditColumnFilter(grid.Row.Address__PostalCode);
                    CanBeMadePrimary = new CheckBoxColumnFilter(grid.Row.CanBeMadePrimary);
                    ContactID = new PXNumberEditColumnFilter(grid.Row.ContactID);
                }
            }
        }
        
        public class c_contacts_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_contacts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t6_grdContacts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_grdContacts_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_grdContacts_lv0_ec", "Ec", locator, null);
                DataMemberName = "Contacts";
            }
        }
        
        public class c_defcontact_defcontact1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public DropDown FaxType { get; }
			public Label FaxTypeLabel { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public Label EdDefContactlblPhone1_ { get; }
			public Label EdDefContactlblPhone2_ { get; }
			public Label EdDefContactlblFax_ { get; }
			public Label LblDefContactAccountEmail_ { get; }
            
            public c_defcontact_defcontact1(string locator, string name) : 
                    base(locator, name)
            {
                Phone1Type = new DropDown("ctl00_phG_tab_t0_DefContact1_edDefContactPhone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t0_DefContact1_edDefContactPXMaskEdit1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t0_DefContact1_edDefContactPhone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t0_DefContact1_edDefContactPXMaskEdit2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                FaxType = new DropDown("ctl00_phG_tab_t0_DefContact1_edDefContactFaxType", "Fax Type", locator, null);
                FaxTypeLabel = new Label(FaxType);
                FaxType.DataField = "FaxType";
                FaxType.Items.Add("B1", "Business 1");
                FaxType.Items.Add("B2", "Business 2");
                FaxType.Items.Add("B3", "Business 3");
                FaxType.Items.Add("C", "Cell");
                FaxType.Items.Add("BA1", "Assistant");
                FaxType.Items.Add("BF", "Fax");
                FaxType.Items.Add("H1", "Home");
                FaxType.Items.Add("HF", "Home Fax");
                Fax = new PXTextEdit("ctl00_phG_tab_t0_DefContact1_edDefContactPXMaskEdit3", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t0_DefContact1_edDefContactEMail", "Account Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t0_DefContact1_edDefContactWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                EdDefContactlblPhone1_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone1", "Ed Def Contactlbl Phone 1_", locator, null);
                EdDefContactlblPhone2_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone2", "Ed Def Contactlbl Phone 2_", locator, null);
                EdDefContactlblFax_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblFax", "Ed Def Contactlbl Fax _", locator, null);
                LblDefContactAccountEmail_ = new Label("ctl00_phG_tab_t0_DefContact1_lblDefContactAccountEmail", "Account Email:", locator, null);
                DataMemberName = "DefContact";
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
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_DefContact1");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefContact1");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_DefContact1");
                    PrimaryContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_defcontact_defcontact2 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox ConsentAgreement { get; }
			public Label ConsentAgreementLabel { get; }
			public DateSelector ConsentDate { get; }
			public Label ConsentDateLabel { get; }
			public DateSelector ConsentExpirationDate { get; }
			public Label ConsentExpirationDateLabel { get; }
            
            public c_defcontact_defcontact2(string locator, string name) : 
                    base(locator, name)
            {
                ConsentAgreement = new CheckBox("ctl00_phG_tab_t0_DefContact2_edDefContactConsentAgreement", "Consented to the Processing of Personal Data", locator, null);
                ConsentAgreementLabel = new Label(ConsentAgreement);
                ConsentAgreement.DataField = "ConsentAgreement";
                ConsentDate = new DateSelector("ctl00_phG_tab_t0_DefContact2_edDefContactConsentDate", "Date of Consent", locator, null);
                ConsentDateLabel = new Label(ConsentDate);
                ConsentDate.DataField = "ConsentDate";
                ConsentExpirationDate = new DateSelector("ctl00_phG_tab_t0_DefContact2_edDefContactConsentExpirationDate", "Consent Expires", locator, null);
                ConsentExpirationDateLabel = new Label(ConsentExpirationDate);
                ConsentExpirationDate.DataField = "ConsentExpirationDate";
                DataMemberName = "DefContact";
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
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_DefContact2");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefContact2");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_DefContact2");
                    PrimaryContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_deflocationcontact_deflocationcontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public DropDown FaxType { get; }
			public Label FaxTypeLabel { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
            
            public c_deflocationcontact_deflocationcontact(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1Type = new DropDown("ctl00_phG_tab_t3_DefLocation_DefLocationContact_Phone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_PXMaskEdit1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t3_DefLocation_DefLocationContact_Phone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_PXMaskEdit2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                FaxType = new DropDown("ctl00_phG_tab_t3_DefLocation_DefLocationContact_FaxType", "Fax Type", locator, null);
                FaxTypeLabel = new Label(FaxType);
                FaxType.DataField = "FaxType";
                FaxType.Items.Add("B1", "Business 1");
                FaxType.Items.Add("B2", "Business 2");
                FaxType.Items.Add("B3", "Business 3");
                FaxType.Items.Add("C", "Cell");
                FaxType.Items.Add("BA1", "Assistant");
                FaxType.Items.Add("BF", "Fax");
                FaxType.Items.Add("H1", "Home");
                FaxType.Items.Add("HF", "Home Fax");
                Fax = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_PXMaskEdit3", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                LblPhone1_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblFax", "Lbl Fax _", locator, null);
                DataMemberName = "DefLocationContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void CBranchIDEdit()
            {
                Buttons.CBranchIDEdit.Click();
            }
            
            public virtual void CPriceClassIDEdit()
            {
                Buttons.CPriceClassIDEdit.Click();
            }
            
            public virtual void CDefProjectIDEdit()
            {
                Buttons.CDefProjectIDEdit.Click();
            }
            
            public virtual void CTaxZoneIDEdit()
            {
                Buttons.CTaxZoneIDEdit.Click();
            }
            
            public virtual void CCarrierIDEdit()
            {
                Buttons.CCarrierIDEdit.Click();
            }
            
            public virtual void CShipTermsIDEdit()
            {
                Buttons.CShipTermsIDEdit.Click();
            }
            
            public virtual void CShipZoneIDEdit()
            {
                Buttons.CShipZoneIDEdit.Click();
            }
            
            public virtual void CFOBPointIDEdit()
            {
                Buttons.CFOBPointIDEdit.Click();
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
                
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button CBranchIDEdit { get; }
			public Button CPriceClassIDEdit { get; }
			public Button CDefProjectIDEdit { get; }
			public Button CTaxZoneIDEdit { get; }
			public Button CCarrierIDEdit { get; }
			public Button CShipTermsIDEdit { get; }
			public Button CShipZoneIDEdit { get; }
			public Button CFOBPointIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CBranchIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CPriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCPriceClassID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CPriceClassIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CPriceClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CDefProjectIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCDefProjectID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CDefProjectIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CDefProjectIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCTaxZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CTaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCarrierID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CCarrierIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "CShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CShipTermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CShipZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CShipZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    CFOBPointIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfFirst0", "First", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    Prev = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfPrev0", "Prev", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    Next = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfNext0", "Next", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    Last = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfLast0", "Last", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                }
            }
        }
        
        public class c_primarycontactcurrent_frmprimarycontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FirstName { get; }
			public Label FirstNameLabel { get; }
			public PXTextEdit LastName { get; }
			public Label LastNameLabel { get; }
			public PXTextEdit Salutation { get; }
			public Label SalutationLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public CheckBox ConsentAgreement { get; }
			public Label ConsentAgreementLabel { get; }
			public DateSelector ConsentDate { get; }
			public Label ConsentDateLabel { get; }
			public DateSelector ConsentExpirationDate { get; }
			public Label ConsentExpirationDateLabel { get; }
			public Label LblPrimaryContactName_ { get; }
			public Label LblPrmCntPhone1_ { get; }
			public Label LblPrmCntPhone2_ { get; }
            
            public c_primarycontactcurrent_frmprimarycontact(string locator, string name) : 
                    base(locator, name)
            {
                FirstName = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntFirstName", "Name", locator, null);
                FirstNameLabel = new Label(FirstName);
                FirstName.DataField = "FirstName";
                LastName = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntLastName", "Last Name", locator, null);
                LastNameLabel = new Label(LastName);
                LastName.DataField = "LastName";
                Salutation = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntJobTitle", "Job Title", locator, null);
                SalutationLabel = new Label(Salutation);
                Salutation.DataField = "Salutation";
                EMail = new EmailEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntEmail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                Phone1Type = new DropDown("ctl00_phG_tab_t0_frmPrimaryContact_ddPrmCntPhone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_mePrmCntPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t0_frmPrimaryContact_ddPrmCntPhone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_mePrmCntPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                ConsentAgreement = new CheckBox("ctl00_phG_tab_t0_frmPrimaryContact_cbPrmCntConsent", "Consented to the Processing of Personal Data", locator, null);
                ConsentAgreementLabel = new Label(ConsentAgreement);
                ConsentAgreement.DataField = "ConsentAgreement";
                ConsentDate = new DateSelector("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntConsentDate", "Date of Consent", locator, null);
                ConsentDateLabel = new Label(ConsentDate);
                ConsentDate.DataField = "ConsentDate";
                ConsentExpirationDate = new DateSelector("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntConsentExpDate", "Consent Expires", locator, null);
                ConsentExpirationDateLabel = new Label(ConsentExpirationDate);
                ConsentExpirationDate.DataField = "ConsentExpirationDate";
                LblPrimaryContactName_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrimaryContactName", "Name:", locator, null);
                LblPrmCntPhone1_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone1", "Lbl Prm Cnt Phone 1_", locator, null);
                LblPrmCntPhone2_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone2", "Lbl Prm Cnt Phone 2_", locator, null);
                DataMemberName = "PrimaryContactCurrent";
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
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_frmPrimaryContact");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_frmPrimaryContact");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_frmPrimaryContact");
                    PrimaryContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_salespersons_pxgrid1 : Grid<c_salespersons_pxgrid1.c_grid_row, c_salespersons_pxgrid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_salespersons_pxgrid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_PXGrid1");
                DataMemberName = "SalesPersons";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_PXGrid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGrid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SalesPersonID { get; }
			public PXTextEdit SalesPersonID_SalesPerson_descr { get; }
			public Selector LocationID { get; }
			public PXTextEdit LocationID_description { get; }
			public PXNumberEdit CommisionPct { get; }
			public CheckBox IsDefault { get; }
                
                public c_grid_row(c_salespersons_pxgrid1 grid) : 
                        base(grid)
                {
                    SalesPersonID = new Selector("_ctl00_phG_tab_t7_PXGrid1_lv0_edSalesPersonID", "Salesperson ID", grid.Locator, "SalesPersonID");
                    SalesPersonID.DataField = "SalesPersonID";
                    SalesPersonID_SalesPerson_descr = new PXTextEdit("ctl00_phG_tab_t7_PXGrid1_ei", "Name", grid.Locator, "SalesPersonID_SalesPerson_descr");
                    SalesPersonID_SalesPerson_descr.DataField = "SalesPersonID_SalesPerson_descr";
                    LocationID = new Selector("_ctl00_phG_tab_t7_PXGrid1_lv0_edLocationID", "Location ID", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    LocationID_description = new PXTextEdit("_ctl00_phG_tab_t7_PXGrid1_lv0_edLocation_descr", "Location Name", grid.Locator, "LocationID_description");
                    LocationID_description.DataField = "LocationID_description";
                    CommisionPct = new PXNumberEdit("_ctl00_phG_tab_t7_PXGrid1_lv0_edCommisionPct", "Commission %", grid.Locator, "CommisionPct");
                    CommisionPct.DataField = "CommisionPct";
                    IsDefault = new CheckBox("ctl00_phG_tab_t7_PXGrid1_ef", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SalesPersonID { get; }
				public PXTextEditColumnFilter SalesPersonID_SalesPerson_descr { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXTextEditColumnFilter LocationID_description { get; }
				public PXNumberEditColumnFilter CommisionPct { get; }
				public CheckBoxColumnFilter IsDefault { get; }
                
                public c_grid_header(c_salespersons_pxgrid1 grid) : 
                        base(grid)
                {
                    SalesPersonID = new SelectorColumnFilter(grid.Row.SalesPersonID);
                    SalesPersonID_SalesPerson_descr = new PXTextEditColumnFilter(grid.Row.SalesPersonID_SalesPerson_descr);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    LocationID_description = new PXTextEditColumnFilter(grid.Row.LocationID_description);
                    CommisionPct = new PXNumberEditColumnFilter(grid.Row.CommisionPct);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                }
            }
        }
        
        public class c_salespersons_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SalesPersonID { get; }
			public Label SalesPersonIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public PXTextEdit LocationID_description { get; }
			public Label LocationID_descriptionLabel { get; }
			public PXNumberEdit CommisionPct { get; }
			public Label CommisionPctLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_salespersons_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SalesPersonID = new Selector("ctl00_phG_tab_t7_PXGrid1_lv0_edSalesPersonID", "Salesperson ID", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                LocationID = new Selector("ctl00_phG_tab_t7_PXGrid1_lv0_edLocationID", "Location ID", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                LocationID_description = new PXTextEdit("ctl00_phG_tab_t7_PXGrid1_lv0_edLocation_descr", "Location Name", locator, null);
                LocationID_descriptionLabel = new Label(LocationID_description);
                LocationID_description.DataField = "LocationID_description";
                CommisionPct = new PXNumberEdit("ctl00_phG_tab_t7_PXGrid1_lv0_edCommisionPct", "Commission %", locator, null);
                CommisionPctLabel = new Label(CommisionPct);
                CommisionPct.DataField = "CommisionPct";
                Es = new Selector("ctl00_phG_tab_t7_PXGrid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SalesPersons";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void SalesPersonIDEdit()
            {
                Buttons.SalesPersonIDEdit.Click();
            }
            
            public virtual void LocationIDEdit()
            {
                Buttons.LocationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button SalesPersonIDEdit { get; }
			public Button LocationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    SalesPersonIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_PXGrid1_lv0_edSalesPersonID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "SalesPersonIDEdit", "ctl00_phG_tab_t7_PXGrid1_lv0");
                    SalesPersonIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    LocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t7_PXGrid1_lv0_edLocationID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "LocationIDEdit", "ctl00_phG_tab_t7_PXGrid1_lv0");
                    LocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_customerbalance_customerbalance : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit UnreleasedBalance { get; }
			public Label UnreleasedBalanceLabel { get; }
			public PXNumberEdit OpenOrdersBalance { get; }
			public Label OpenOrdersBalanceLabel { get; }
			public PXNumberEdit RemainingCreditLimit { get; }
			public Label RemainingCreditLimitLabel { get; }
			public DateSelector OldInvoiceDate { get; }
			public Label OldInvoiceDateLabel { get; }
			public PXNumberEdit Balance { get; }
			public Label BalanceLabel { get; }
			public PXNumberEdit ConsolidatedBalance { get; }
			public Label ConsolidatedBalanceLabel { get; }
			public PXNumberEdit SignedDepositsBalance { get; }
			public Label SignedDepositsBalanceLabel { get; }
			public PXNumberEdit RetainageBalance { get; }
			public Label RetainageBalanceLabel { get; }
            
            public c_customerbalance_customerbalance(string locator, string name) : 
                    base(locator, name)
            {
                UnreleasedBalance = new PXNumberEdit("ctl00_phG_tab_t1_CustomerBalance_edUnreleasedBalance", "Unreleased Balance", locator, null);
                UnreleasedBalanceLabel = new Label(UnreleasedBalance);
                UnreleasedBalance.DataField = "UnreleasedBalance";
                OpenOrdersBalance = new PXNumberEdit("ctl00_phG_tab_t1_CustomerBalance_edOpenOrdersBalance", "Open Orders Balance", locator, null);
                OpenOrdersBalanceLabel = new Label(OpenOrdersBalance);
                OpenOrdersBalance.DataField = "OpenOrdersBalance";
                RemainingCreditLimit = new PXNumberEdit("ctl00_phG_tab_t1_CustomerBalance_edRemainingCreditLimit", "Remaining Credit Limit", locator, null);
                RemainingCreditLimitLabel = new Label(RemainingCreditLimit);
                RemainingCreditLimit.DataField = "RemainingCreditLimit";
                OldInvoiceDate = new DateSelector("ctl00_phG_tab_t1_CustomerBalance_edOldInvoiceDate", "First Due Date", locator, null);
                OldInvoiceDateLabel = new Label(OldInvoiceDate);
                OldInvoiceDate.DataField = "OldInvoiceDate";
                Balance = new PXNumberEdit("ctl00_phF_BAccount_t0_CustomerBalance_edBalance", "Balance", locator, null);
                BalanceLabel = new Label(Balance);
                Balance.DataField = "Balance";
                ConsolidatedBalance = new PXNumberEdit("ctl00_phF_BAccount_t0_CustomerBalance_edConsolidatedBalance", "Consolidated Balance", locator, null);
                ConsolidatedBalanceLabel = new Label(ConsolidatedBalance);
                ConsolidatedBalance.DataField = "ConsolidatedBalance";
                SignedDepositsBalance = new PXNumberEdit("ctl00_phF_BAccount_t0_CustomerBalance_edSignedDepositsBalance", "Prepayment Balance", locator, null);
                SignedDepositsBalanceLabel = new Label(SignedDepositsBalance);
                SignedDepositsBalance.DataField = "SignedDepositsBalance";
                RetainageBalance = new PXNumberEdit("ctl00_phF_BAccount_t0_CustomerBalance_edRetainageBalance", "Retained Balance", locator, null);
                RetainageBalanceLabel = new Label(RetainageBalance);
                RetainageBalance.DataField = "RetainageBalance";
                DataMemberName = "CustomerBalance";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public virtual void StatementCycleIdEdit()
            {
                Buttons.StatementCycleIdEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TermsIDEdit { get; }
			public Button StatementCycleIdEdit { get; }
                
                public PxButtonCollection()
                {
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab_t1_CustomerBalance");
                    TermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    StatementCycleIdEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edStatementCycleId\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "StatementCycleIdEdit", "ctl00_phG_tab_t1_CustomerBalance");
                    StatementCycleIdEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_carriers_pxgridaccounts : Grid<c_carriers_pxgridaccounts.c_grid_row, c_carriers_pxgridaccounts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_carriers_pxgridaccounts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                DataMemberName = "Carriers";
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
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void CBranchIDEdit()
            {
                Buttons.CBranchIDEdit.Click();
            }
            
            public virtual void CPriceClassIDEdit()
            {
                Buttons.CPriceClassIDEdit.Click();
            }
            
            public virtual void CDefProjectIDEdit()
            {
                Buttons.CDefProjectIDEdit.Click();
            }
            
            public virtual void CTaxZoneIDEdit()
            {
                Buttons.CTaxZoneIDEdit.Click();
            }
            
            public virtual void CCarrierIDEdit()
            {
                Buttons.CCarrierIDEdit.Click();
            }
            
            public virtual void CShipTermsIDEdit()
            {
                Buttons.CShipTermsIDEdit.Click();
            }
            
            public virtual void CShipZoneIDEdit()
            {
                Buttons.CShipZoneIDEdit.Click();
            }
            
            public virtual void CFOBPointIDEdit()
            {
                Buttons.CFOBPointIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_DefLocation_PXGridAccounts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_DefLocation_PXGridAccounts_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_DefLocation_PXGridAccounts_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_DefLocation_PXGridAccounts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button CBranchIDEdit { get; }
			public Button CPriceClassIDEdit { get; }
			public Button CDefProjectIDEdit { get; }
			public Button CTaxZoneIDEdit { get; }
			public Button CCarrierIDEdit { get; }
			public Button CShipTermsIDEdit { get; }
			public Button CShipZoneIDEdit { get; }
			public Button CFOBPointIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CBranchIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CPriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCPriceClassID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CPriceClassIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CPriceClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CDefProjectIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCDefProjectID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CDefProjectIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CDefProjectIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCTaxZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CTaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCarrierID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CCarrierIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "CShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CShipTermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CShipZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CShipZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    CFOBPointIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfFirst0", "First", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    Prev = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfPrev0", "Prev", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    Next = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfNext0", "Next", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                    Last = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfLast0", "Last", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsActive { get; }
			public Selector CarrierPluginID { get; }
			public PXTextEdit CarrierAccount { get; }
			public PXTextEdit PostalCode { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_carriers_pxgridaccounts grid) : 
                        base(grid)
                {
                    IsActive = new CheckBox("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    CarrierPluginID = new Selector("_ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0_es", "Carrier", grid.Locator, "CarrierPluginID");
                    CarrierPluginID.DataField = "CarrierPluginID";
                    CarrierAccount = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_ei", "Carrier Account", grid.Locator, "CarrierAccount");
                    CarrierAccount.DataField = "CarrierAccount";
                    PostalCode = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_ei", "Postal Code", grid.Locator, "PostalCode");
                    PostalCode.DataField = "PostalCode";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsActive { get; }
				public SelectorColumnFilter CarrierPluginID { get; }
				public PXTextEditColumnFilter CarrierAccount { get; }
				public PXTextEditColumnFilter PostalCode { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_carriers_pxgridaccounts grid) : 
                        base(grid)
                {
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    CarrierPluginID = new SelectorColumnFilter(grid.Row.CarrierPluginID);
                    CarrierAccount = new PXTextEditColumnFilter(grid.Row.CarrierAccount);
                    PostalCode = new PXTextEditColumnFilter(grid.Row.PostalCode);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_carriers_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_carriers_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Carriers";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void CBranchIDEdit()
            {
                Buttons.CBranchIDEdit.Click();
            }
            
            public virtual void CPriceClassIDEdit()
            {
                Buttons.CPriceClassIDEdit.Click();
            }
            
            public virtual void CDefProjectIDEdit()
            {
                Buttons.CDefProjectIDEdit.Click();
            }
            
            public virtual void CTaxZoneIDEdit()
            {
                Buttons.CTaxZoneIDEdit.Click();
            }
            
            public virtual void CCarrierIDEdit()
            {
                Buttons.CCarrierIDEdit.Click();
            }
            
            public virtual void CShipTermsIDEdit()
            {
                Buttons.CShipTermsIDEdit.Click();
            }
            
            public virtual void CShipZoneIDEdit()
            {
                Buttons.CShipZoneIDEdit.Click();
            }
            
            public virtual void CFOBPointIDEdit()
            {
                Buttons.CFOBPointIDEdit.Click();
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
                
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button CBranchIDEdit { get; }
			public Button CPriceClassIDEdit { get; }
			public Button CDefProjectIDEdit { get; }
			public Button CTaxZoneIDEdit { get; }
			public Button CCarrierIDEdit { get; }
			public Button CShipTermsIDEdit { get; }
			public Button CShipZoneIDEdit { get; }
			public Button CFOBPointIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CBranchIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CPriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCPriceClassID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CPriceClassIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CPriceClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CDefProjectIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCDefProjectID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "CDefProjectIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CDefProjectIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCTaxZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CTaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edCarrierID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "CCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CCarrierIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "CShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CShipTermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CShipZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CShipZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CShipZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "CFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    CFOBPointIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfFirst0", "First", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    Prev = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfPrev0", "Prev", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    Next = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfNext0", "Next", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                    Last = new Button("ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lfLast0", "Last", "ctl00_phG_tab_t3_DefLocation_PXGridAccounts_lv0");
                }
            }
        }
        
        public class c_answers_pxgridanswers : Grid<c_answers_pxgridanswers.c_grid_row, c_answers_pxgridanswers.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_answers_pxgridanswers(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_PXGridAnswers");
                DataMemberName = "Answers";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t9_PXGridAnswers_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_PXGridAnswers_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector AttributeID { get; }
			public CheckBox IsRequired { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit RefNoteID { get; }
                
                public c_grid_row(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new Selector("_ctl00_phG_tab_t9_PXGridAnswers_lv0_es", "Attribute", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    IsRequired = new CheckBox("ctl00_phG_tab_t9_PXGridAnswers", "Required", grid.Locator, "isRequired");
                    IsRequired.DataField = "isRequired";
                    Value = new PXTextEdit("ctl00_phG_tab_t9_PXGridAnswers_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t9_PXGridAnswers_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter AttributeID { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
                
                public c_grid_header(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                }
            }
        }
        
        public class c_answers_lv0 : Container
        {
            
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
                Es = new Selector("ctl00_phG_tab_t9_PXGridAnswers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t9_PXGridAnswers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t9_PXGridAnswers_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t9_PXGridAnswers_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Answers";
            }
        }
        
        public class c_activities_activities_grid : Grid<c_activities_activities_grid.c_grid_row, c_activities_activities_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_activities_activities_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t10_gridActivities_Activities_grid");
                DataMemberName = "Activities";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t10_gridActivities_Activities_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void AddTask()
            {
                ToolBar.AddTask.Click();
            }
            
            public virtual void AddEvent()
            {
                ToolBar.AddEvent.Click();
            }
            
            public virtual void AddEmail()
            {
                ToolBar.AddEmail.Click();
            }
            
            public virtual void AddActivity()
            {
                ToolBar.AddActivity.Click();
            }
            
            public virtual void AddNote()
            {
                ToolBar.AddNote.Click();
            }
            
            public virtual void AddChat()
            {
                ToolBar.AddChat.Click();
            }
            
            public virtual void AddAppointment()
            {
                ToolBar.AddAppointment.Click();
            }
            
            public virtual void ES()
            {
                ToolBar.ES.Click();
            }
            
            public virtual void AddMessage()
            {
                ToolBar.AddMessage.Click();
            }
            
            public virtual void AddPhoneCall()
            {
                ToolBar.AddPhoneCall.Click();
            }
            
            public virtual void AddWorkItem()
            {
                ToolBar.AddWorkItem.Click();
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
			public ToolBarButtonGrid AddTask { get; }
			public ToolBarButtonGrid AddEvent { get; }
			public ToolBarButtonGrid AddEmail { get; }
			public ToolBarButtonGrid AddActivity { get; }
			public ToolBarButtonGrid AddNote { get; }
			public ToolBarButtonGrid AddChat { get; }
			public ToolBarButtonGrid AddAppointment { get; }
			public ToolBarButtonGrid ES { get; }
			public ToolBarButtonGrid AddMessage { get; }
			public ToolBarButtonGrid AddPhoneCall { get; }
			public ToolBarButtonGrid AddWorkItem { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'Refres" +
                            "h\']", "Refresh", locator, null);
                    AddTask = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAdd" +
                            "Task\']", "Add Task", locator, null);
                    AddEvent = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAdd" +
                            "Event\']", "Add Event", locator, null);
                    AddEmail = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAdd" +
                            "Email\']", "Add Email", locator, null);
                    AddActivity = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAdd" +
                            "Activity\']", "Add Activity", locator, null);
                    AddNote = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb_menucmdAddActivit" +
                            "y li[data-cmd=\'NewActivity@N    \']", "Add Note", locator, AddActivity);
                    AddChat = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb_menucmdAddActivit" +
                            "y li[data-cmd=\'NewActivity@C    \']", "Add Chat", locator, AddActivity);
                    AddAppointment = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb_menucmdAddActivit" +
                            "y li[data-cmd=\'NewActivity@E    \']", "Add Appointment", locator, AddActivity);
                    ES = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb_menucmdAddActivit" +
                            "y li[data-cmd=\'NewActivity@ES   \']", "Add Escalation", locator, AddActivity);
                    AddMessage = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb_menucmdAddActivit" +
                            "y li[data-cmd=\'NewActivity@M    \']", "Add Message", locator, AddActivity);
                    AddPhoneCall = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb_menucmdAddActivit" +
                            "y li[data-cmd=\'NewActivity@P    \']", "Add Phone Call", locator, AddActivity);
                    AddWorkItem = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb_menucmdAddActivit" +
                            "y li[data-cmd=\'NewActivity@W    \']", "Add Work Item", locator, AddActivity);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'Adjust" +
                            "Columns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'Export" +
                            "Excel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageFi" +
                            "rst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PagePr" +
                            "ev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageNe" +
                            "xt\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageLa" +
                            "st\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit IsCompleteIcon { get; }
			public PXTextEdit PriorityIcon { get; }
			public PXTextEdit CRReminder__ReminderIcon { get; }
			public PXTextEdit ClassIcon { get; }
			public PXTextEdit ClassInfo { get; }
			public PXTextEdit RefNoteID { get; }
			public Selector Subject { get; }
			public DropDown UIStatus { get; }
			public CheckBox Released { get; }
			public DateSelector StartDate { get; }
			public DateSelector CreatedDateTime { get; }
			public DropDown TimeSpent { get; }
			public Selector CreatedByID { get; }
			public PXTextEdit CreatedByID_Creator_Username { get; }
			public Selector WorkgroupID { get; }
			public Selector OwnerID { get; }
			public Selector ProjectID { get; }
			public Selector ProjectTaskID { get; }
			public PXTextEdit Source { get; }
			public PXTextEdit NoteID { get; }
                
                public c_grid_row(c_activities_activities_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsCompleteIcon = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "Complete Icon", grid.Locator, "IsCompleteIcon");
                    IsCompleteIcon.DataField = "IsCompleteIcon";
                    PriorityIcon = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "Priority Icon", grid.Locator, "PriorityIcon");
                    PriorityIcon.DataField = "PriorityIcon";
                    CRReminder__ReminderIcon = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "Reminder Icon", grid.Locator, "CRReminder__ReminderIcon");
                    CRReminder__ReminderIcon.DataField = "CRReminder__ReminderIcon";
                    ClassIcon = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "Class Icon", grid.Locator, "ClassIcon");
                    ClassIcon.DataField = "ClassIcon";
                    ClassInfo = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "Type", grid.Locator, "ClassInfo");
                    ClassInfo.DataField = "ClassInfo";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                    Subject = new Selector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_es", "Summary", grid.Locator, "Subject");
                    Subject.DataField = "Subject";
                    UIStatus = new DropDown("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_ec", "Status", grid.Locator, "UIStatus");
                    UIStatus.DataField = "UIStatus";
                    UIStatus.Items.Add("DR", "Draft");
                    UIStatus.Items.Add("OP", "Open");
                    UIStatus.Items.Add("IP", "Processing");
                    UIStatus.Items.Add("CD", "Completed");
                    UIStatus.Items.Add("AP", "Approved");
                    UIStatus.Items.Add("RJ", "Rejected");
                    UIStatus.Items.Add("CL", "Canceled");
                    UIStatus.Items.Add("PA", "Pending Approval");
                    UIStatus.Items.Add("RL", "Released");
                    Released = new CheckBox("ctl00_phG_tab_t10_gridActivities_Activities_grid", "Released", grid.Locator, "Released");
                    Released.DataField = "Released";
                    StartDate = new DateSelector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_ed11", "Start Date", grid.Locator, "StartDate");
                    StartDate.DataField = "StartDate";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_ed12", "Created At", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    TimeSpent = new DropDown("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_ec", "Time Spent", grid.Locator, "TimeSpent");
                    TimeSpent.DataField = "TimeSpent";
                    TimeSpent.Items.Add("0", "00:00");
                    TimeSpent.Items.Add("30", "00:30");
                    TimeSpent.Items.Add("60", "01:00");
                    TimeSpent.Items.Add("90", "01:30");
                    TimeSpent.Items.Add("120", "02:00");
                    TimeSpent.Items.Add("150", "02:30");
                    TimeSpent.Items.Add("180", "03:00");
                    TimeSpent.Items.Add("210", "03:30");
                    TimeSpent.Items.Add("240", "04:00");
                    TimeSpent.Items.Add("270", "04:30");
                    TimeSpent.Items.Add("300", "05:00");
                    TimeSpent.Items.Add("330", "05:30");
                    TimeSpent.Items.Add("360", "06:00");
                    TimeSpent.Items.Add("390", "06:30");
                    TimeSpent.Items.Add("420", "07:00");
                    TimeSpent.Items.Add("450", "07:30");
                    TimeSpent.Items.Add("480", "08:00");
                    TimeSpent.Items.Add("510", "08:30");
                    TimeSpent.Items.Add("540", "09:00");
                    TimeSpent.Items.Add("570", "09:30");
                    TimeSpent.Items.Add("600", "10:00");
                    TimeSpent.Items.Add("630", "10:30");
                    TimeSpent.Items.Add("660", "11:00");
                    TimeSpent.Items.Add("690", "11:30");
                    TimeSpent.Items.Add("720", "12:00");
                    TimeSpent.Items.Add("750", "12:30");
                    TimeSpent.Items.Add("780", "13:00");
                    TimeSpent.Items.Add("810", "13:30");
                    TimeSpent.Items.Add("840", "14:00");
                    TimeSpent.Items.Add("870", "14:30");
                    TimeSpent.Items.Add("900", "15:00");
                    TimeSpent.Items.Add("930", "15:30");
                    TimeSpent.Items.Add("960", "16:00");
                    TimeSpent.Items.Add("990", "16:30");
                    TimeSpent.Items.Add("1020", "17:00");
                    TimeSpent.Items.Add("1050", "17:30");
                    TimeSpent.Items.Add("1080", "18:00");
                    TimeSpent.Items.Add("1110", "18:30");
                    TimeSpent.Items.Add("1140", "19:00");
                    TimeSpent.Items.Add("1170", "19:30");
                    TimeSpent.Items.Add("1200", "20:00");
                    TimeSpent.Items.Add("1230", "20:30");
                    TimeSpent.Items.Add("1260", "21:00");
                    TimeSpent.Items.Add("1290", "21:30");
                    TimeSpent.Items.Add("1320", "22:00");
                    TimeSpent.Items.Add("1350", "22:30");
                    TimeSpent.Items.Add("1380", "23:00");
                    TimeSpent.Items.Add("1410", "23:30");
                    CreatedByID = new Selector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_es", "CreatedByID", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CreatedByID_Creator_Username = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "Created By", grid.Locator, "CreatedByID_Creator_Username");
                    CreatedByID_Creator_Username.DataField = "CreatedByID_Creator_Username";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    OwnerID = new Selector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_es", "Owner", grid.Locator, "OwnerID");
                    OwnerID.DataField = "OwnerID";
                    ProjectID = new Selector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_es", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    ProjectTaskID = new Selector("_ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_es", "Project Task", grid.Locator, "ProjectTaskID");
                    ProjectTaskID.DataField = "ProjectTaskID";
                    Source = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "Related Entity Description", grid.Locator, "Source");
                    Source.DataField = "Source";
                    NoteID = new PXTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_grid_ei", "NoteID", grid.Locator, "NoteID");
                    NoteID.DataField = "NoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter IsCompleteIcon { get; }
				public PXTextEditColumnFilter PriorityIcon { get; }
				public PXTextEditColumnFilter CRReminder__ReminderIcon { get; }
				public PXTextEditColumnFilter ClassIcon { get; }
				public PXTextEditColumnFilter ClassInfo { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
				public SelectorColumnFilter Subject { get; }
				public DropDownColumnFilter UIStatus { get; }
				public CheckBoxColumnFilter Released { get; }
				public DateSelectorColumnFilter StartDate { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public DropDownColumnFilter TimeSpent { get; }
				public SelectorColumnFilter CreatedByID { get; }
				public PXTextEditColumnFilter CreatedByID_Creator_Username { get; }
				public SelectorColumnFilter WorkgroupID { get; }
				public SelectorColumnFilter OwnerID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter ProjectTaskID { get; }
				public PXTextEditColumnFilter Source { get; }
				public PXTextEditColumnFilter NoteID { get; }
                
                public c_grid_header(c_activities_activities_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsCompleteIcon = new PXTextEditColumnFilter(grid.Row.IsCompleteIcon);
                    PriorityIcon = new PXTextEditColumnFilter(grid.Row.PriorityIcon);
                    CRReminder__ReminderIcon = new PXTextEditColumnFilter(grid.Row.CRReminder__ReminderIcon);
                    ClassIcon = new PXTextEditColumnFilter(grid.Row.ClassIcon);
                    ClassInfo = new PXTextEditColumnFilter(grid.Row.ClassInfo);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                    Subject = new SelectorColumnFilter(grid.Row.Subject);
                    UIStatus = new DropDownColumnFilter(grid.Row.UIStatus);
                    Released = new CheckBoxColumnFilter(grid.Row.Released);
                    StartDate = new DateSelectorColumnFilter(grid.Row.StartDate);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    TimeSpent = new DropDownColumnFilter(grid.Row.TimeSpent);
                    CreatedByID = new SelectorColumnFilter(grid.Row.CreatedByID);
                    CreatedByID_Creator_Username = new PXTextEditColumnFilter(grid.Row.CreatedByID_Creator_Username);
                    WorkgroupID = new SelectorColumnFilter(grid.Row.WorkgroupID);
                    OwnerID = new SelectorColumnFilter(grid.Row.OwnerID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    ProjectTaskID = new SelectorColumnFilter(grid.Row.ProjectTaskID);
                    Source = new PXTextEditColumnFilter(grid.Row.Source);
                    NoteID = new PXTextEditColumnFilter(grid.Row.NoteID);
                }
            }
        }
        
        public class c_activities_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_activities_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t10_gridActivities_Activities_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Activities";
            }
        }
        
        public class c_activities_preview_activities_form : Container
        {
            
			public RichTextEdit Body { get; }
			public Label BodyLabel { get; }
            
            public c_activities_preview_activities_form(string locator, string name) : 
                    base(locator, name)
            {
                Body = new RichTextEdit("ctl00_phG_tab_t10_gridActivities_Activities_form_edBody", "Body", locator, null);
                BodyLabel = new Label(Body);
                Body.DataField = "body";
                DataMemberName = "Activities$Preview";
            }
        }
        
        public class c_notificationsources_gridns : Grid<c_notificationsources_gridns.c_grid_row, c_notificationsources_gridns.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notificationsources_gridns(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t12_sp1_gridNS");
                DataMemberName = "NotificationSources";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t12_sp1_gridNS_fe_gf", "FilterForm");
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
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t12_sp1_gridNS");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public CheckBox OverrideSource { get; }
			public Selector SetupID { get; }
			public Selector NBranchID { get; }
			public Selector EMailAccountID { get; }
			public Selector ReportID { get; }
			public Selector NotificationID { get; }
			public DropDown Format { get; }
			public DropDown RecipientsBehavior { get; }
			public PXNumberEdit SourceID { get; }
                
                public c_grid_row(c_notificationsources_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phG_tab_t12_sp1_gridNS_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    OverrideSource = new CheckBox("ctl00_phG_tab_t12_sp1_gridNS_ef", "Overridden", grid.Locator, "OverrideSource");
                    OverrideSource.DataField = "OverrideSource";
                    SetupID = new Selector("_ctl00_phG_tab_t12_sp1_gridNS_lv0_edSetupID", "Mailing ID", grid.Locator, "SetupID");
                    SetupID.DataField = "SetupID";
                    NBranchID = new Selector("_ctl00_phG_tab_t12_sp1_gridNS_lv0_edNBranchID", "Branch", grid.Locator, "NBranchID");
                    NBranchID.DataField = "NBranchID";
                    EMailAccountID = new Selector("_ctl00_phG_tab_t12_sp1_gridNS_lv0_edEMailAccountID", "Email Account", grid.Locator, "EMailAccountID");
                    EMailAccountID.DataField = "EMailAccountID";
                    ReportID = new Selector("_ctl00_phG_tab_t12_sp1_gridNS_lv0_edReportID", "Report", grid.Locator, "ReportID");
                    ReportID.DataField = "ReportID";
                    NotificationID = new Selector("_ctl00_phG_tab_t12_sp1_gridNS_lv0_edNotificationID", "Notification Template", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                    Format = new DropDown("_ctl00_phG_tab_t12_sp1_gridNS_lv0_edFormat", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    RecipientsBehavior = new DropDown("_ctl00_phG_tab_t12_sp1_gridNS_lv0_ec", "Recipients", grid.Locator, "RecipientsBehavior");
                    RecipientsBehavior.DataField = "RecipientsBehavior";
                    RecipientsBehavior.Items.Add("O", "Override Recipients");
                    RecipientsBehavior.Items.Add("A", "Add Recipients");
                    SourceID = new PXNumberEdit("ctl00_phG_tab_t12_sp1_gridNS_en", "SourceID", grid.Locator, "SourceID");
                    SourceID.DataField = "SourceID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter OverrideSource { get; }
				public SelectorColumnFilter SetupID { get; }
				public SelectorColumnFilter NBranchID { get; }
				public SelectorColumnFilter EMailAccountID { get; }
				public SelectorColumnFilter ReportID { get; }
				public SelectorColumnFilter NotificationID { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter RecipientsBehavior { get; }
				public PXNumberEditColumnFilter SourceID { get; }
                
                public c_grid_header(c_notificationsources_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    OverrideSource = new CheckBoxColumnFilter(grid.Row.OverrideSource);
                    SetupID = new SelectorColumnFilter(grid.Row.SetupID);
                    NBranchID = new SelectorColumnFilter(grid.Row.NBranchID);
                    EMailAccountID = new SelectorColumnFilter(grid.Row.EMailAccountID);
                    ReportID = new SelectorColumnFilter(grid.Row.ReportID);
                    NotificationID = new SelectorColumnFilter(grid.Row.NotificationID);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    RecipientsBehavior = new DropDownColumnFilter(grid.Row.RecipientsBehavior);
                    SourceID = new PXNumberEditColumnFilter(grid.Row.SourceID);
                }
            }
        }
        
        public class c_notificationsources_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Format { get; }
			public Label FormatLabel { get; }
			public Selector NBranchID { get; }
			public Label NBranchIDLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public Selector SetupID { get; }
			public Label SetupIDLabel { get; }
			public Selector ReportID { get; }
			public Label ReportIDLabel { get; }
			public Selector NotificationID { get; }
			public Label NotificationIDLabel { get; }
			public Selector EMailAccountID { get; }
			public Label EMailAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notificationsources_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Format = new DropDown("ctl00_phG_tab_t12_sp1_gridNS_lv0_edFormat", "Format", locator, null);
                FormatLabel = new Label(Format);
                Format.DataField = "Format";
                Format.Items.Add("H", "Html");
                Format.Items.Add("E", "Excel");
                Format.Items.Add("P", "PDF");
                NBranchID = new Selector("ctl00_phG_tab_t12_sp1_gridNS_lv0_edNBranchID", "Branch", locator, null);
                NBranchIDLabel = new Label(NBranchID);
                NBranchID.DataField = "NBranchID";
                Active = new CheckBox("ctl00_phG_tab_t12_sp1_gridNS_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                SetupID = new Selector("ctl00_phG_tab_t12_sp1_gridNS_lv0_edSetupID", "Mailing ID", locator, null);
                SetupIDLabel = new Label(SetupID);
                SetupID.DataField = "SetupID";
                ReportID = new Selector("ctl00_phG_tab_t12_sp1_gridNS_lv0_edReportID", "Report", locator, null);
                ReportIDLabel = new Label(ReportID);
                ReportID.DataField = "ReportID";
                NotificationID = new Selector("ctl00_phG_tab_t12_sp1_gridNS_lv0_edNotificationID", "Notification Template", locator, null);
                NotificationIDLabel = new Label(NotificationID);
                NotificationID.DataField = "NotificationID";
                EMailAccountID = new Selector("ctl00_phG_tab_t12_sp1_gridNS_lv0_edEMailAccountID", "Email Account", locator, null);
                EMailAccountIDLabel = new Label(EMailAccountID);
                EMailAccountID.DataField = "EMailAccountID";
                Es = new Selector("ctl00_phG_tab_t12_sp1_gridNS_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t12_sp1_gridNS_lv0_ec", "Ec", locator, null);
                DataMemberName = "NotificationSources";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t12_sp1_gridNS_lv0");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_notificationrecipients_gridnr : Grid<c_notificationrecipients_gridnr.c_grid_row, c_notificationrecipients_gridnr.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notificationrecipients_gridnr(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t12_sp1_gridNR");
                DataMemberName = "NotificationRecipients";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t12_sp1_gridNR_fe_gf", "FilterForm");
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
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_sp1_gridNR_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t12_sp1_gridNR");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public DropDown ContactType { get; }
			public PXNumberEdit OriginalContactID { get; }
			public Selector ContactID { get; }
			public PXTextEdit Email { get; }
			public DropDown Format { get; }
			public DropDown AddTo { get; }
			public PXNumberEdit NotificationID { get; }
                
                public c_grid_row(c_notificationrecipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBox("ctl00_phG_tab_t12_sp1_gridNR_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    ContactType = new DropDown("_ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactType", "Contact Type", grid.Locator, "ContactType");
                    ContactType.DataField = "ContactType";
                    ContactType.Items.Add("P", "Primary");
                    ContactType.Items.Add("B", "Billing");
                    ContactType.Items.Add("S", "Shipping");
                    ContactType.Items.Add("E", "Employee");
                    ContactType.Items.Add("C", "Contact");
                    OriginalContactID = new PXNumberEdit("ctl00_phG_tab_t12_sp1_gridNR_en", "OriginalContactID", grid.Locator, "OriginalContactID");
                    OriginalContactID.DataField = "OriginalContactID";
                    ContactID = new Selector("_ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactID", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    Email = new PXTextEdit("ctl00_phG_tab_t12_sp1_gridNR_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Format = new DropDown("_ctl00_phG_tab_t12_sp1_gridNR_lv0_ec", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    AddTo = new DropDown("_ctl00_phG_tab_t12_sp1_gridNR_lv0_ec", "Add To", grid.Locator, "AddTo");
                    AddTo.DataField = "AddTo";
                    AddTo.Items.Add("T", "To");
                    AddTo.Items.Add("C", "Cc");
                    AddTo.Items.Add("B", "Bcc");
                    NotificationID = new PXNumberEdit("ctl00_phG_tab_t12_sp1_gridNR_en", "NotificationID", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public DropDownColumnFilter ContactType { get; }
				public PXNumberEditColumnFilter OriginalContactID { get; }
				public SelectorColumnFilter ContactID { get; }
				public PXTextEditColumnFilter Email { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter AddTo { get; }
				public PXNumberEditColumnFilter NotificationID { get; }
                
                public c_grid_header(c_notificationrecipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    ContactType = new DropDownColumnFilter(grid.Row.ContactType);
                    OriginalContactID = new PXNumberEditColumnFilter(grid.Row.OriginalContactID);
                    ContactID = new SelectorColumnFilter(grid.Row.ContactID);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    AddTo = new DropDownColumnFilter(grid.Row.AddTo);
                    NotificationID = new PXNumberEditColumnFilter(grid.Row.NotificationID);
                }
            }
        }
        
        public class c_notificationrecipients_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown ContactType { get; }
			public Label ContactTypeLabel { get; }
			public Selector ContactID { get; }
			public Label ContactIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notificationrecipients_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ContactType = new DropDown("ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactType", "Contact Type", locator, null);
                ContactTypeLabel = new Label(ContactType);
                ContactType.DataField = "ContactType";
                ContactType.Items.Add("P", "Primary");
                ContactType.Items.Add("B", "Billing");
                ContactType.Items.Add("S", "Shipping");
                ContactType.Items.Add("E", "Employee");
                ContactType.Items.Add("C", "Contact");
                ContactID = new Selector("ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactID", "Contact ID", locator, null);
                ContactIDLabel = new Label(ContactID);
                ContactID.DataField = "ContactID";
                Es = new Selector("ctl00_phG_tab_t12_sp1_gridNR_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t12_sp1_gridNR_lv0_ec", "Ec", locator, null);
                DataMemberName = "NotificationRecipients";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t12_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t12_sp1_gridNR_lv0");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_ondemandstatementdialog_formondemandstatement : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector StatementDate { get; }
			public Label StatementDateLabel { get; }
            
            public c_ondemandstatementdialog_formondemandstatement(string locator, string name) : 
                    base(locator, name)
            {
                StatementDate = new DateSelector("ctl00_phF_pnlOnDemandStatement_formOnDemandStatement_dteStatementDate", "Statement Date", locator, null);
                StatementDateLabel = new Label(StatementDate);
                StatementDate.DataField = "StatementDate";
                DataMemberName = "OnDemandStatementDialog";
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
                    Ok = new Button("ctl00_phF_pnlOnDemandStatement_btnOK1", "OK", "ctl00_phF_pnlOnDemandStatement_formOnDemandStatement");
                }
            }
        }
        
        public class c_childaccounts_gridchildaccounts : Grid<c_childaccounts_gridchildaccounts.c_grid_row, c_childaccounts_gridchildaccounts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_childaccounts_gridchildaccounts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_gridChildAccounts");
                DataMemberName = "ChildAccounts";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t8_gridChildAccounts_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridChildAccounts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector CustomerID { get; }
			public PXTextEdit CustomerName { get; }
			public PXNumberEdit Balance { get; }
			public PXNumberEdit SignedDepositsBalance { get; }
			public PXNumberEdit UnreleasedBalance { get; }
			public PXNumberEdit OpenOrdersBalance { get; }
			public DateSelector OldInvoiceDate { get; }
			public CheckBox ConsolidateToParent { get; }
			public CheckBox ConsolidateStatements { get; }
			public CheckBox SharedCreditPolicy { get; }
			public Selector StatementCycleId { get; }
                
                public c_grid_row(c_childaccounts_gridchildaccounts grid) : 
                        base(grid)
                {
                    CustomerID = new Selector("_ctl00_phG_tab_t8_gridChildAccounts_lv0_edChildCustomerID", "Customer", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    CustomerName = new PXTextEdit("ctl00_phG_tab_t8_gridChildAccounts_ei", "Customer Name", grid.Locator, "CustomerName");
                    CustomerName.DataField = "CustomerName";
                    Balance = new PXNumberEdit("ctl00_phG_tab_t8_gridChildAccounts_en", "Balance", grid.Locator, "Balance");
                    Balance.DataField = "Balance";
                    SignedDepositsBalance = new PXNumberEdit("ctl00_phG_tab_t8_gridChildAccounts_en", "Prepayment Balance", grid.Locator, "SignedDepositsBalance");
                    SignedDepositsBalance.DataField = "SignedDepositsBalance";
                    UnreleasedBalance = new PXNumberEdit("ctl00_phG_tab_t8_gridChildAccounts_en", "Unreleased Balance", grid.Locator, "UnreleasedBalance");
                    UnreleasedBalance.DataField = "UnreleasedBalance";
                    OpenOrdersBalance = new PXNumberEdit("ctl00_phG_tab_t8_gridChildAccounts_en", "Open Orders Balance", grid.Locator, "OpenOrdersBalance");
                    OpenOrdersBalance.DataField = "OpenOrdersBalance";
                    OldInvoiceDate = new DateSelector("_ctl00_phG_tab_t8_gridChildAccounts_lv0_ed6", "First Due Date", grid.Locator, "OldInvoiceDate");
                    OldInvoiceDate.DataField = "OldInvoiceDate";
                    ConsolidateToParent = new CheckBox("ctl00_phG_tab_t8_gridChildAccounts", "Consolidate Balance", grid.Locator, "ConsolidateToParent");
                    ConsolidateToParent.DataField = "ConsolidateToParent";
                    ConsolidateStatements = new CheckBox("ctl00_phG_tab_t8_gridChildAccounts", "Consolidate Statements", grid.Locator, "ConsolidateStatements");
                    ConsolidateStatements.DataField = "ConsolidateStatements";
                    SharedCreditPolicy = new CheckBox("ctl00_phG_tab_t8_gridChildAccounts", "Share Credit Policy", grid.Locator, "SharedCreditPolicy");
                    SharedCreditPolicy.DataField = "SharedCreditPolicy";
                    StatementCycleId = new Selector("_ctl00_phG_tab_t8_gridChildAccounts_lv0_es", "Statement Cycle", grid.Locator, "StatementCycleId");
                    StatementCycleId.DataField = "StatementCycleId";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter CustomerID { get; }
				public PXTextEditColumnFilter CustomerName { get; }
				public PXNumberEditColumnFilter Balance { get; }
				public PXNumberEditColumnFilter SignedDepositsBalance { get; }
				public PXNumberEditColumnFilter UnreleasedBalance { get; }
				public PXNumberEditColumnFilter OpenOrdersBalance { get; }
				public DateSelectorColumnFilter OldInvoiceDate { get; }
				public CheckBoxColumnFilter ConsolidateToParent { get; }
				public CheckBoxColumnFilter ConsolidateStatements { get; }
				public CheckBoxColumnFilter SharedCreditPolicy { get; }
				public SelectorColumnFilter StatementCycleId { get; }
                
                public c_grid_header(c_childaccounts_gridchildaccounts grid) : 
                        base(grid)
                {
                    CustomerID = new SelectorColumnFilter(grid.Row.CustomerID);
                    CustomerName = new PXTextEditColumnFilter(grid.Row.CustomerName);
                    Balance = new PXNumberEditColumnFilter(grid.Row.Balance);
                    SignedDepositsBalance = new PXNumberEditColumnFilter(grid.Row.SignedDepositsBalance);
                    UnreleasedBalance = new PXNumberEditColumnFilter(grid.Row.UnreleasedBalance);
                    OpenOrdersBalance = new PXNumberEditColumnFilter(grid.Row.OpenOrdersBalance);
                    OldInvoiceDate = new DateSelectorColumnFilter(grid.Row.OldInvoiceDate);
                    ConsolidateToParent = new CheckBoxColumnFilter(grid.Row.ConsolidateToParent);
                    ConsolidateStatements = new CheckBoxColumnFilter(grid.Row.ConsolidateStatements);
                    SharedCreditPolicy = new CheckBoxColumnFilter(grid.Row.SharedCreditPolicy);
                    StatementCycleId = new SelectorColumnFilter(grid.Row.StatementCycleId);
                }
            }
        }
        
        public class c_childaccounts_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_childaccounts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CustomerID = new Selector("ctl00_phG_tab_t8_gridChildAccounts_lv0_edChildCustomerID", "Customer", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                Es = new Selector("ctl00_phG_tab_t8_gridChildAccounts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t8_gridChildAccounts_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "ChildAccounts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CustomerIDEdit()
            {
                Buttons.CustomerIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CustomerIDEdit { get; }
                
                public PxButtonCollection()
                {
                    CustomerIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_gridChildAccounts_lv0_edChildCustomerID\'] div[class=" +
                            "\'editBtnCont\'] > div > div", "CustomerIDEdit", "ctl00_phG_tab_t8_gridChildAccounts_lv0");
                    CustomerIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_contactinfo_formcreatecontact : Container
        {
            
			public PXTextEdit FirstName { get; }
			public Label FirstNameLabel { get; }
			public PXTextEdit LastName { get; }
			public Label LastNameLabel { get; }
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Salutation { get; }
			public Label SalutationLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public PXTextEdit Email { get; }
			public Label EmailLabel { get; }
			public Selector ContactClass { get; }
			public Label ContactClassLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
            
            public c_contactinfo_formcreatecontact(string locator, string name) : 
                    base(locator, name)
            {
                FirstName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edFirstName", "First Name", locator, null);
                FirstNameLabel = new Label(FirstName);
                FirstName.DataField = "FirstName";
                LastName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edLastName", "Last Name", locator, null);
                LastNameLabel = new Label(LastName);
                LastName.DataField = "LastName";
                FullName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edFullName", "Full Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Salutation = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edSalutation", "Salutation", locator, null);
                SalutationLabel = new Label(Salutation);
                Salutation.DataField = "Salutation";
                Phone1Type = new DropDown("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1 = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2 = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                Email = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                ContactClass = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edContactClass" +
                        "", "Contact Class", locator, null);
                ContactClassLabel = new Label(ContactClass);
                ContactClass.DataField = "ContactClass";
                LblPhone1_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone2", "Lbl Phone 2_", locator, null);
                DataMemberName = "ContactInfo";
            }
        }
        
        public class c_contactinfo_tabcreatecontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
            
            public c_contactinfo_tabcreatecontact(string locator, string name) : 
                    base(locator, name)
            {
                LblPhone1_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone2", "Lbl Phone 2_", locator, null);
                DataMemberName = "ContactInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
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
            
            public virtual void Createandreview()
            {
                Buttons.Createandreview.Click();
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
                
			public Button Unnamed { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Createandreview { get; }
			public Button Create { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_oi", "", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfFirst" +
                            "0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfPrev0" +
                            "", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfNext0" +
                            "", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfLast0" +
                            "", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Createandreview = new Button("ctl00_phG_PanelCreateContact_CreateContactBtnReview", "Create and review", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Create = new Button("ctl00_phG_PanelCreateContact_CreateContactBtnConvert", "Create", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Cancel = new Button("ctl00_phG_PanelCreateContact_CreateContactBtnCancel", "Cancel", "ctl00_phG_PanelCreateContact_tabCreateContact");
                }
            }
        }
        
        public class c_contactinfoattributes_grdcontactinfoattributes : Grid<c_contactinfoattributes_grdcontactinfoattributes.c_grid_row, c_contactinfoattributes_grdcontactinfoattributes.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_contactinfoattributes_grdcontactinfoattributes(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ContactInfoAttributes";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_fe_gf", "FilterForm");
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
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfFirst" +
                            "0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfPrev0" +
                            "", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfNext0" +
                            "", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfLast0" +
                            "", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit Name { get; }
			public PXTextEdit CacheName { get; }
                
                public c_grid_row(c_contactinfoattributes_grdcontactinfoattributes grid) : 
                        base(grid)
                {
                    DisplayName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Value = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Name = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    CacheName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "CacheName", grid.Locator, "CacheName");
                    CacheName.DataField = "CacheName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Name { get; }
				public PXTextEditColumnFilter CacheName { get; }
                
                public c_grid_header(c_contactinfoattributes_grdcontactinfoattributes grid) : 
                        base(grid)
                {
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    CacheName = new PXTextEditColumnFilter(grid.Row.CacheName);
                }
            }
        }
        
        public class c_contactinfoattributes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_contactinfoattributes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ContactInfoAttributes";
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
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfFirst" +
                            "0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfPrev0" +
                            "", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfNext0" +
                            "", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfLast0" +
                            "", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
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
        
        public class c_defpaymentmethodinstance_defpaymentmethodinstance : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CCProcessingCenterID { get; }
			public Label CCProcessingCenterIDLabel { get; }
			public Selector CustomerCCPID { get; }
			public Label CustomerCCPIDLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
            
            public c_defpaymentmethodinstance_defpaymentmethodinstance(string locator, string name) : 
                    base(locator, name)
            {
                CCProcessingCenterID = new Selector("ctl00_phG_tab_t2_DefPaymentMethodInstance_edProcessingCenter", "Proc. Center ID", locator, null);
                CCProcessingCenterIDLabel = new Label(CCProcessingCenterID);
                CCProcessingCenterID.DataField = "CCProcessingCenterID";
                CustomerCCPID = new Selector("ctl00_phG_tab_t2_DefPaymentMethodInstance_edCustomerCCPID", "Customer Profile ID", locator, null);
                CustomerCCPIDLabel = new Label(CustomerCCPID);
                CustomerCCPID.DataField = "CustomerCCPID";
                CashAccountID = new Selector("ctl00_phG_tab_t2_DefPaymentMethodInstance_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                Descr = new InputLocalizable("ctl00_phG_tab_t2_DefPaymentMethodInstance_edDescr", "Card/Account Nbr.", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                DataMemberName = "DefPaymentMethodInstance";
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
            
            public virtual void BillingCycleIDEdit()
            {
                Buttons.BillingCycleIDEdit.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button BillingCycleIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_BillAddress_btnBillingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefPaymentMethodInstance");
                    ViewonMap = new Button("ctl00_phG_tab_t2_BillAddress_btnViewBillAddressOnMap", "View on Map", "ctl00_phG_tab_t2_DefPaymentMethodInstance");
                    BillingCycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edBillingCycleID1\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "BillingCycleIDEdit", "ctl00_phG_tab_t2_DefPaymentMethodInstance");
                    BillingCycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefPaymentMethodInstance");
                    Prev = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefPaymentMethodInstance");
                    Next = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefPaymentMethodInstance");
                    Last = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefPaymentMethodInstance");
                }
            }
        }
        
        public class c_paymentmethods_grdpaymentmethods : Grid<c_paymentmethods_grdpaymentmethods.c_grid_row, c_paymentmethods_grdpaymentmethods.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_paymentmethods_grdpaymentmethods(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_grdPaymentMethods");
                DataMemberName = "PaymentMethods";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_grdPaymentMethods_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void AddPaymentMethod()
            {
                ToolBar.AddPaymentMethod.Click();
            }
            
            public virtual void ViewPaymentMethod()
            {
                ToolBar.ViewPaymentMethod.Click();
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
			public ToolBarButtonGrid AddPaymentMethod { get; }
			public ToolBarButtonGrid ViewPaymentMethod { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    AddPaymentMethod = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_at_tlb div[data-cmd=\'AddPaymentMethod\']", "Add Payment Method", locator, null);
                    ViewPaymentMethod = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_at_tlb div[data-cmd=\'cmdViewPaymentMethod" +
                            "\']", "View Payment Method", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdPaymentMethods_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsDefault { get; }
			public PXTextEdit PaymentMethodID { get; }
			public InputLocalizable Descr { get; }
			public Selector CashAccountID { get; }
			public CheckBox IsActive { get; }
			public CheckBox IsCustomerPaymentMethod { get; }
			public PXNumberEdit PMInstanceID { get; }
                
                public c_grid_row(c_paymentmethods_grdpaymentmethods grid) : 
                        base(grid)
                {
                    IsDefault = new CheckBox("ctl00_phG_tab_t5_grdPaymentMethods_ef", "Is Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    PaymentMethodID = new PXTextEdit("ctl00_phG_tab_t5_grdPaymentMethods_ei", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    Descr = new InputLocalizable("ctl00_phG_tab_t5_grdPaymentMethods_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    CashAccountID = new Selector("_ctl00_phG_tab_t5_grdPaymentMethods_lv0_es", "Cash Account", grid.Locator, "CashAccountID");
                    CashAccountID.DataField = "CashAccountID";
                    IsActive = new CheckBox("ctl00_phG_tab_t5_grdPaymentMethods", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    IsCustomerPaymentMethod = new CheckBox("ctl00_phG_tab_t5_grdPaymentMethods", "Override", grid.Locator, "IsCustomerPaymentMethod");
                    IsCustomerPaymentMethod.DataField = "IsCustomerPaymentMethod";
                    PMInstanceID = new PXNumberEdit("ctl00_phG_tab_t5_grdPaymentMethods_en", "PMInstanceID", grid.Locator, "PMInstanceID");
                    PMInstanceID.DataField = "PMInstanceID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsDefault { get; }
				public PXTextEditColumnFilter PaymentMethodID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter CashAccountID { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public CheckBoxColumnFilter IsCustomerPaymentMethod { get; }
				public PXNumberEditColumnFilter PMInstanceID { get; }
                
                public c_grid_header(c_paymentmethods_grdpaymentmethods grid) : 
                        base(grid)
                {
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    PaymentMethodID = new PXTextEditColumnFilter(grid.Row.PaymentMethodID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    CashAccountID = new SelectorColumnFilter(grid.Row.CashAccountID);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    IsCustomerPaymentMethod = new CheckBoxColumnFilter(grid.Row.IsCustomerPaymentMethod);
                    PMInstanceID = new PXNumberEditColumnFilter(grid.Row.PMInstanceID);
                }
            }
        }
        
        public class c_paymentmethods_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_paymentmethods_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t5_grdPaymentMethods_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "PaymentMethods";
            }
        }
        
        public class c_defpaymentmethodinstancedetails_grdpminstancedetails : Grid<c_defpaymentmethodinstancedetails_grdpminstancedetails.c_grid_row, c_defpaymentmethodinstancedetails_grdpminstancedetails.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_defpaymentmethodinstancedetails_grdpminstancedetails(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "DefPaymentMethodInstanceDetails";
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
            
            public virtual void BillingCycleIDEdit()
            {
                Buttons.BillingCycleIDEdit.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button BillingCycleIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_BillAddress_btnBillingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails");
                    ViewonMap = new Button("ctl00_phG_tab_t2_BillAddress_btnViewBillAddressOnMap", "View on Map", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails");
                    BillingCycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edBillingCycleID1\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "BillingCycleIDEdit", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails");
                    BillingCycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails");
                    Prev = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails");
                    Next = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails");
                    Last = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit DetailID_PaymentMethodDetail_descr { get; }
			public PXTextEdit Value { get; }
			public PXNumberEdit PMInstanceID { get; }
			public PXTextEdit PaymentMethodID { get; }
			public Selector DetailID { get; }
                
                public c_grid_row(c_defpaymentmethodinstancedetails_grdpminstancedetails grid) : 
                        base(grid)
                {
                    DetailID_PaymentMethodDetail_descr = new PXTextEdit("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_ei", "Description", grid.Locator, "DetailID_PaymentMethodDetail_descr");
                    DetailID_PaymentMethodDetail_descr.DataField = "DetailID_PaymentMethodDetail_descr";
                    Value = new PXTextEdit("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    PMInstanceID = new PXNumberEdit("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_en", "PMInstanceID", grid.Locator, "PMInstanceID");
                    PMInstanceID.DataField = "PMInstanceID";
                    PaymentMethodID = new PXTextEdit("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_ei", "PaymentMethodID", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    DetailID = new Selector("_ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0_es", "Description", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter DetailID_PaymentMethodDetail_descr { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXNumberEditColumnFilter PMInstanceID { get; }
				public PXTextEditColumnFilter PaymentMethodID { get; }
				public SelectorColumnFilter DetailID { get; }
                
                public c_grid_header(c_defpaymentmethodinstancedetails_grdpminstancedetails grid) : 
                        base(grid)
                {
                    DetailID_PaymentMethodDetail_descr = new PXTextEditColumnFilter(grid.Row.DetailID_PaymentMethodDetail_descr);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    PMInstanceID = new PXNumberEditColumnFilter(grid.Row.PMInstanceID);
                    PaymentMethodID = new PXTextEditColumnFilter(grid.Row.PaymentMethodID);
                    DetailID = new SelectorColumnFilter(grid.Row.DetailID);
                }
            }
        }
        
        public class c_defpaymentmethodinstancedetails_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_defpaymentmethodinstancedetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "DefPaymentMethodInstanceDetails";
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
            
            public virtual void BillingCycleIDEdit()
            {
                Buttons.BillingCycleIDEdit.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button BillingCycleIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_BillAddress_btnBillingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0");
                    ViewonMap = new Button("ctl00_phG_tab_t2_BillAddress_btnViewBillAddressOnMap", "View on Map", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0");
                    BillingCycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edBillingCycleID1\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "BillingCycleIDEdit", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0");
                    BillingCycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0");
                    Prev = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0");
                    Next = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0");
                    Last = new Button("ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefPaymentMethodInstance_grdPMInstanceDetails_lv0");
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
                CD = new Selector("ctl00_phF_pnlChangeID_formChangeID_edAcctCD", "Customer ID", locator, null);
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
        
        public class c_compliancedocuments_grdcompliancedocuments : Grid<c_compliancedocuments_grdcompliancedocuments.c_grid_row, c_compliancedocuments_grdcompliancedocuments.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_compliancedocuments_grdcompliancedocuments(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t14_grdComplianceDocuments");
                DataMemberName = "ComplianceDocuments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t14_grdComplianceDocuments_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_at_tlb div[data-cmd=\'AdjustColumns\'" +
                            "]", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_grdComplianceDocuments_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
			public PXTextEdit ProjectID { get; }
			public Selector CostTaskID { get; }
			public Selector RevenueTaskID { get; }
			public Selector CostCodeID { get; }
			public PXTextEdit VendorID { get; }
			public PXTextEdit VendorName { get; }
			public Selector BillID { get; }
			public PXTextEdit BillAmount { get; }
			public PXTextEdit CustomerID { get; }
			public Selector ApCheckID { get; }
			public PXTextEdit CheckNumber { get; }
			public Selector ArPaymentID { get; }
			public PXTextEdit CertificateNumber { get; }
			public PXTextEdit CreatedByID { get; }
			public PXTextEdit CustomerName { get; }
			public PXTextEdit AccountID { get; }
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
                    ExpirationDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Expiration Date", grid.Locator, "ExpirationDate");
                    ExpirationDate.DataField = "ExpirationDate";
                    DocumentType = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Document Type", grid.Locator, "DocumentType");
                    DocumentType.DataField = "DocumentType";
                    CreationDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Creation Date", grid.Locator, "CreationDate");
                    CreationDate.DataField = "CreationDate";
                    Status = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Required = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    Received = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Received", grid.Locator, "Received");
                    Received.DataField = "Received";
                    ReceivedDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Received Date", grid.Locator, "ReceivedDate");
                    ReceivedDate.DataField = "ReceivedDate";
                    IsProcessed = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Is Processed", grid.Locator, "IsProcessed");
                    IsProcessed.DataField = "IsProcessed";
                    IsVoided = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Is Voided", grid.Locator, "IsVoided");
                    IsVoided.DataField = "IsVoided";
                    IsCreatedAutomatically = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Is Created Automatically", grid.Locator, "IsCreatedAutomatically");
                    IsCreatedAutomatically.DataField = "IsCreatedAutomatically";
                    SentDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Sent Date", grid.Locator, "SentDate");
                    SentDate.DataField = "SentDate";
                    ProjectID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Project ID", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    CostTaskID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", grid.Locator, "CostTaskID");
                    CostTaskID.DataField = "CostTaskID";
                    RevenueTaskID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", grid.Locator, "RevenueTaskID");
                    RevenueTaskID.DataField = "RevenueTaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    VendorID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorName = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Vendor Name", grid.Locator, "VendorName");
                    VendorName.DataField = "VendorName";
                    BillID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edBillID", "Bill ID", grid.Locator, "BillID");
                    BillID.DataField = "BillID";
                    BillAmount = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Bill Amount", grid.Locator, "BillAmount");
                    BillAmount.DataField = "BillAmount";
                    CustomerID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Customer ID", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    ApCheckID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", grid.Locator, "ApCheckID");
                    ApCheckID.DataField = "ApCheckID";
                    CheckNumber = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Check Number", grid.Locator, "CheckNumber");
                    CheckNumber.DataField = "CheckNumber";
                    ArPaymentID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", grid.Locator, "ArPaymentID");
                    ArPaymentID.DataField = "ArPaymentID";
                    CertificateNumber = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Certificate Number", grid.Locator, "CertificateNumber");
                    CertificateNumber.DataField = "CertificateNumber";
                    CreatedByID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Created By ID", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CustomerName = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Customer Name", grid.Locator, "CustomerName");
                    CustomerName.DataField = "CustomerName";
                    AccountID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Account ID", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    DateIssued = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Date Issued", grid.Locator, "DateIssued");
                    DateIssued.DataField = "DateIssued";
                    EffectiveDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Effective Date", grid.Locator, "EffectiveDate");
                    EffectiveDate.DataField = "EffectiveDate";
                    InsuranceCompany = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Insurance Company", grid.Locator, "InsuranceCompany");
                    InsuranceCompany.DataField = "InsuranceCompany";
                    InvoiceAmount = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Invoice Amount", grid.Locator, "InvoiceAmount");
                    InvoiceAmount.DataField = "InvoiceAmount";
                    InvoiceID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", grid.Locator, "InvoiceID");
                    InvoiceID.DataField = "InvoiceID";
                    IsExpired = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Is Expired", grid.Locator, "IsExpired");
                    IsExpired.DataField = "IsExpired";
                    IsRequiredJointCheck = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Is Required Joint Check", grid.Locator, "IsRequiredJointCheck");
                    IsRequiredJointCheck.DataField = "IsRequiredJointCheck";
                    JointAmount = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Joint Amount", grid.Locator, "JointAmount");
                    JointAmount.DataField = "JointAmount";
                    JointRelease = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Joint Release", grid.Locator, "JointRelease");
                    JointRelease.DataField = "JointRelease";
                    JointReleaseReceived = new CheckBox("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Joint Release Received", grid.Locator, "JointReleaseReceived");
                    JointReleaseReceived.DataField = "JointReleaseReceived";
                    JointVendorInternalId = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Joint Vendor Internal Id", grid.Locator, "JointVendorInternalId");
                    JointVendorInternalId.DataField = "JointVendorInternalId";
                    JointVendorExternalName = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Joint Vendor External Name", grid.Locator, "JointVendorExternalName");
                    JointVendorExternalName.DataField = "JointVendorExternalName";
                    LastModifiedByID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Last Modified By ID", grid.Locator, "LastModifiedByID");
                    LastModifiedByID.DataField = "LastModifiedByID";
                    LienWaiverAmount = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Lien Waiver Amount", grid.Locator, "LienWaiverAmount");
                    LienWaiverAmount.DataField = "LienWaiverAmount";
                    Limit = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Limit", grid.Locator, "Limit");
                    Limit.DataField = "Limit";
                    MethodSent = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Method Sent", grid.Locator, "MethodSent");
                    MethodSent.DataField = "MethodSent";
                    PaymentDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Payment Date", grid.Locator, "PaymentDate");
                    PaymentDate.DataField = "PaymentDate";
                    ArPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Ar Payment Method ID", grid.Locator, "ArPaymentMethodID");
                    ArPaymentMethodID.DataField = "ArPaymentMethodID";
                    ApPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Ap Payment Method ID", grid.Locator, "ApPaymentMethodID");
                    ApPaymentMethodID.DataField = "ApPaymentMethodID";
                    Policy = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Policy", grid.Locator, "Policy");
                    Policy.DataField = "Policy";
                    ProjectTransactionID = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", grid.Locator, "ProjectTransactionID");
                    ProjectTransactionID.DataField = "ProjectTransactionID";
                    PurchaseOrder = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", grid.Locator, "PurchaseOrder");
                    PurchaseOrder.DataField = "PurchaseOrder";
                    PurchaseOrderLineItem = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", grid.Locator, "PurchaseOrderLineItem");
                    PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                    Subcontract = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", grid.Locator, "Subcontract");
                    Subcontract.DataField = "Subcontract";
                    SubcontractLineItem = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", grid.Locator, "SubcontractLineItem");
                    SubcontractLineItem.DataField = "SubcontractLineItem";
                    ChangeOrderNumber = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", grid.Locator, "ChangeOrderNumber");
                    ChangeOrderNumber.DataField = "ChangeOrderNumber";
                    ReceiptDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Receipt Date", grid.Locator, "ReceiptDate");
                    ReceiptDate.DataField = "ReceiptDate";
                    ReceiveDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Receive Date", grid.Locator, "ReceiveDate");
                    ReceiveDate.DataField = "ReceiveDate";
                    ReceivedBy = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Received By", grid.Locator, "ReceivedBy");
                    ReceivedBy.DataField = "ReceivedBy";
                    SecondaryVendorID = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Secondary Vendor ID", grid.Locator, "SecondaryVendorID");
                    SecondaryVendorID.DataField = "SecondaryVendorID";
                    SecondaryVendorName = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Secondary Vendor Name", grid.Locator, "SecondaryVendorName");
                    SecondaryVendorName.DataField = "SecondaryVendorName";
                    SourceType = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Source Type", grid.Locator, "SourceType");
                    SourceType.DataField = "SourceType";
                    SponsorOrganization = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Sponsor Organization", grid.Locator, "SponsorOrganization");
                    SponsorOrganization.DataField = "SponsorOrganization";
                    ThroughDate = new PXTextEdit("ctl00_phG_tab_t14_grdComplianceDocuments_ei", "Through Date", grid.Locator, "ThroughDate");
                    ThroughDate.DataField = "ThroughDate";
                    DocumentTypeValue = new Selector("_ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", grid.Locator, "DocumentTypeValue");
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
				public PXTextEditColumnFilter ProjectID { get; }
				public SelectorColumnFilter CostTaskID { get; }
				public SelectorColumnFilter RevenueTaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public PXTextEditColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorName { get; }
				public InputColumnFilter BillID { get; }
				public PXTextEditColumnFilter BillAmount { get; }
				public PXTextEditColumnFilter CustomerID { get; }
				public InputColumnFilter ApCheckID { get; }
				public PXTextEditColumnFilter CheckNumber { get; }
				public InputColumnFilter ArPaymentID { get; }
				public PXTextEditColumnFilter CertificateNumber { get; }
				public PXTextEditColumnFilter CreatedByID { get; }
				public PXTextEditColumnFilter CustomerName { get; }
				public PXTextEditColumnFilter AccountID { get; }
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
                    ProjectID = new PXTextEditColumnFilter(grid.Row.ProjectID);
                    CostTaskID = new SelectorColumnFilter(grid.Row.CostTaskID);
                    RevenueTaskID = new SelectorColumnFilter(grid.Row.RevenueTaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    VendorID = new PXTextEditColumnFilter(grid.Row.VendorID);
                    VendorName = new PXTextEditColumnFilter(grid.Row.VendorName);
                    BillID = new InputColumnFilter(grid.Row.BillID);
                    BillAmount = new PXTextEditColumnFilter(grid.Row.BillAmount);
                    CustomerID = new PXTextEditColumnFilter(grid.Row.CustomerID);
                    ApCheckID = new InputColumnFilter(grid.Row.ApCheckID);
                    CheckNumber = new PXTextEditColumnFilter(grid.Row.CheckNumber);
                    ArPaymentID = new InputColumnFilter(grid.Row.ArPaymentID);
                    CertificateNumber = new PXTextEditColumnFilter(grid.Row.CertificateNumber);
                    CreatedByID = new PXTextEditColumnFilter(grid.Row.CreatedByID);
                    CustomerName = new PXTextEditColumnFilter(grid.Row.CustomerName);
                    AccountID = new PXTextEditColumnFilter(grid.Row.AccountID);
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
            
            public c_compliancedocuments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CostCodeID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                DocumentTypeValue = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", locator, null);
                DocumentTypeValueLabel = new Label(DocumentTypeValue);
                DocumentTypeValue.DataField = "DocumentTypeValue";
                BillID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edBillID", "Bill ID", locator, null);
                BillIDLabel = new Label(BillID);
                BillID.DataField = "BillID";
                InvoiceID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", locator, null);
                InvoiceIDLabel = new Label(InvoiceID);
                InvoiceID.DataField = "InvoiceID";
                ApCheckID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", locator, null);
                ApCheckIDLabel = new Label(ApCheckID);
                ApCheckID.DataField = "ApCheckID";
                ArPaymentID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", locator, null);
                ArPaymentIDLabel = new Label(ArPaymentID);
                ArPaymentID.DataField = "ArPaymentID";
                ProjectTransactionID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", locator, null);
                ProjectTransactionIDLabel = new Label(ProjectTransactionID);
                ProjectTransactionID.DataField = "ProjectTransactionID";
                PurchaseOrder = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", locator, null);
                PurchaseOrderLabel = new Label(PurchaseOrder);
                PurchaseOrder.DataField = "PurchaseOrder";
                PurchaseOrderLineItem = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", locator, null);
                PurchaseOrderLineItemLabel = new Label(PurchaseOrderLineItem);
                PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                Subcontract = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", locator, null);
                SubcontractLabel = new Label(Subcontract);
                Subcontract.DataField = "Subcontract";
                SubcontractLineItem = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", locator, null);
                SubcontractLineItemLabel = new Label(SubcontractLineItem);
                SubcontractLineItem.DataField = "SubcontractLineItem";
                ChangeOrderNumber = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", locator, null);
                ChangeOrderNumberLabel = new Label(ChangeOrderNumber);
                ChangeOrderNumber.DataField = "ChangeOrderNumber";
                CostTaskID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", locator, null);
                CostTaskIDLabel = new Label(CostTaskID);
                CostTaskID.DataField = "CostTaskID";
                RevenueTaskID = new Selector("ctl00_phG_tab_t14_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", locator, null);
                RevenueTaskIDLabel = new Label(RevenueTaskID);
                RevenueTaskID.DataField = "RevenueTaskID";
                DataMemberName = "ComplianceDocuments";
            }
        }
        
        public class c_customerbillingcycles_gridbillingcycles : Grid<c_customerbillingcycles_gridbillingcycles.c_grid_row, c_customerbillingcycles_gridbillingcycles.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_customerbillingcycles_gridbillingcycles(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t13_gridBillingCycles");
                DataMemberName = "CustomerBillingCycles";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t13_gridBillingCycles_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_gridBillingCycles_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit SrvOrdType { get; }
			public PXTextEdit BillingCycleID { get; }
			public PXTextEdit SendInvoicesTo { get; }
			public PXTextEdit BillShipmentSource { get; }
			public PXTextEdit FrequencyType { get; }
			public PXTextEdit WeeklyFrequency { get; }
			public PXTextEdit MonthlyFrequency { get; }
                
                public c_grid_row(c_customerbillingcycles_gridbillingcycles grid) : 
                        base(grid)
                {
                    SrvOrdType = new PXTextEdit("ctl00_phG_tab_t13_gridBillingCycles_ei", "Srv Ord Type", grid.Locator, "SrvOrdType");
                    SrvOrdType.DataField = "SrvOrdType";
                    BillingCycleID = new PXTextEdit("ctl00_phG_tab_t13_gridBillingCycles_ei", "Billing Cycle ID", grid.Locator, "BillingCycleID");
                    BillingCycleID.DataField = "BillingCycleID";
                    SendInvoicesTo = new PXTextEdit("ctl00_phG_tab_t13_gridBillingCycles_ei", "Send Invoices To", grid.Locator, "SendInvoicesTo");
                    SendInvoicesTo.DataField = "SendInvoicesTo";
                    BillShipmentSource = new PXTextEdit("ctl00_phG_tab_t13_gridBillingCycles_ei", "Bill Shipment Source", grid.Locator, "BillShipmentSource");
                    BillShipmentSource.DataField = "BillShipmentSource";
                    FrequencyType = new PXTextEdit("ctl00_phG_tab_t13_gridBillingCycles_ei", "Frequency Type", grid.Locator, "FrequencyType");
                    FrequencyType.DataField = "FrequencyType";
                    WeeklyFrequency = new PXTextEdit("ctl00_phG_tab_t13_gridBillingCycles_ei", "Weekly Frequency", grid.Locator, "WeeklyFrequency");
                    WeeklyFrequency.DataField = "WeeklyFrequency";
                    MonthlyFrequency = new PXTextEdit("ctl00_phG_tab_t13_gridBillingCycles_ei", "Monthly Frequency", grid.Locator, "MonthlyFrequency");
                    MonthlyFrequency.DataField = "MonthlyFrequency";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter SrvOrdType { get; }
				public PXTextEditColumnFilter BillingCycleID { get; }
				public PXTextEditColumnFilter SendInvoicesTo { get; }
				public PXTextEditColumnFilter BillShipmentSource { get; }
				public PXTextEditColumnFilter FrequencyType { get; }
				public PXTextEditColumnFilter WeeklyFrequency { get; }
				public PXTextEditColumnFilter MonthlyFrequency { get; }
                
                public c_grid_header(c_customerbillingcycles_gridbillingcycles grid) : 
                        base(grid)
                {
                    SrvOrdType = new PXTextEditColumnFilter(grid.Row.SrvOrdType);
                    BillingCycleID = new PXTextEditColumnFilter(grid.Row.BillingCycleID);
                    SendInvoicesTo = new PXTextEditColumnFilter(grid.Row.SendInvoicesTo);
                    BillShipmentSource = new PXTextEditColumnFilter(grid.Row.BillShipmentSource);
                    FrequencyType = new PXTextEditColumnFilter(grid.Row.FrequencyType);
                    WeeklyFrequency = new PXTextEditColumnFilter(grid.Row.WeeklyFrequency);
                    MonthlyFrequency = new PXTextEditColumnFilter(grid.Row.MonthlyFrequency);
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
