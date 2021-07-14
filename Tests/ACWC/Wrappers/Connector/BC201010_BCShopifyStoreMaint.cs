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
    
    
    public class BC201010_BCShopifyStoreMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_bindings_form Bindings_form { get; } = new c_bindings_form("ctl00_phF_form", "Bindings_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_entities_cstpxgrid60 Entities_CstPXGrid60 { get; } = new c_entities_cstpxgrid60("ctl00_phG_tab_t1_CstPXGrid60", "Entities_CstPXGrid60");
        protected c_entities_lv0 Entities_lv0 { get; } = new c_entities_lv0("ctl00_phG_tab_t1_CstPXGrid60_lv0", "Entities_lv0");
        protected c_currentstore_tab CurrentStore_tab { get; } = new c_currentstore_tab("ctl00_phG_tab", "CurrentStore_tab");
        protected c_currentbindingshopify_tab CurrentBindingShopify_tab { get; } = new c_currentbindingshopify_tab("ctl00_phG_tab", "CurrentBindingShopify_tab");
        protected c_currentbinding_tab CurrentBinding_tab { get; } = new c_currentbinding_tab("ctl00_phG_tab", "CurrentBinding_tab");
        protected c_locations_gridlocations Locations_gridLocations { get; } = new c_locations_gridlocations("ctl00_phG_tab_t3_gridLocations", "Locations_gridLocations");
        protected c_locations_lv0 Locations_lv0 { get; } = new c_locations_lv0("ctl00_phG_tab_t3_gridLocations_lv0", "Locations_lv0");
        protected c_paymentmethods_paymentsmethods PaymentMethods_PaymentsMethods { get; } = new c_paymentmethods_paymentsmethods("ctl00_phG_tab_t5_PaymentsMethods", "PaymentMethods_PaymentsMethods");
        protected c_paymentmethods_lv0 PaymentMethods_lv0 { get; } = new c_paymentmethods_lv0("ctl00_phG_tab_t5_PaymentsMethods_lv0", "PaymentMethods_lv0");
        protected c_multicurrency_multicurrency MultiCurrency_MultiCurrency { get; } = new c_multicurrency_multicurrency("ctl00_phG_tab_t5_MultiCurrency", "MultiCurrency_MultiCurrency");
        protected c_multicurrency_lv0 MultiCurrency_lv0 { get; } = new c_multicurrency_lv0("ctl00_phG_tab_t5_MultiCurrency_lv0", "MultiCurrency_lv0");
        protected c_shippingmappings_shippingmappings ShippingMappings_ShippingMappings { get; } = new c_shippingmappings_shippingmappings("ctl00_phG_tab_t4_ShippingMappings", "ShippingMappings_ShippingMappings");
        protected c_shippingmappings_lv0 ShippingMappings_lv0 { get; } = new c_shippingmappings_lv0("ctl00_phG_tab_t4_ShippingMappings_lv0", "ShippingMappings_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public BC201010_BCShopifyStoreMaint()
        {
            ScreenId = "BC201010";
            ScreenUrl = "/Pages/BC/BC201010.aspx";
            ToolBar = new PxToolBar(null);
        }
        
        public virtual BC201010_BCShopifyStoreMaint ReadOne(Gate gate, string ConnectorType, string BindingName)
        {
            new BiObject<BC201010_BCShopifyStoreMaint>(gate).ReadOne(this, ConnectorType, BindingName);
            return this;
        }
        
        public virtual BC201010_BCShopifyStoreMaint ReadOne(string ConnectorType, string BindingName)
        {
            return this.ReadOne(ApiConnection.Source, ConnectorType, BindingName);
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
        
        public virtual void TestConnection()
        {
            ToolBar.TestConnection.Click();
        }
        
        public virtual void TestConnection(bool status, string message = null)
        {
            ToolBar.TestConnection.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.TestConnection.Click();
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
			public ToolBarButton TestConnection { get; }
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
                TestConnection = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'testConnection\']", "Test Connection", locator, null);
                TestConnection.WaitAction = Wait.WaitForLongOperationToComplete;
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_bindings_form : Container
        {
            
			public DropDown ConnectorType { get; }
			public Label ConnectorTypeLabel { get; }
			public Selector BindingName { get; }
			public Label BindingNameLabel { get; }
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
            
            public c_bindings_form(string locator, string name) : 
                    base(locator, name)
            {
                ConnectorType = new DropDown("ctl00_phF_form_CstPXDropDown16", "Connector", locator, null);
                ConnectorTypeLabel = new Label(ConnectorType);
                ConnectorType.DataField = "ConnectorType";
                ConnectorType.Items.Add("BCC", "BigCommerce");
                ConnectorType.Items.Add("SPC", "Shopify");
                BindingName = new Selector("ctl00_phF_form_CstPXSelector17", "Store Name", locator, null);
                BindingNameLabel = new Label(BindingName);
                BindingName.DataField = "BindingName";
                IsActive = new CheckBox("ctl00_phF_form_CstPXCheckBox67", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                IsDefault = new CheckBox("ctl00_phF_form_CstPXCheckBox68", "Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                DataMemberName = "Bindings";
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
        
        public class c_entities_cstpxgrid60 : Grid<c_entities_cstpxgrid60.c_grid_row, c_entities_cstpxgrid60.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_entities_cstpxgrid60(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_CstPXGrid60");
                DataMemberName = "Entities";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_CstPXGrid60_fe_gf", "FilterForm");
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_CstPXGrid60_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsActive { get; }
			public DropDown EntityType { get; }
			public DropDown Direction { get; }
			public DropDown PrimarySystem { get; }
			public DropDown ImportRealTimeStatus { get; }
			public DropDown ExportRealTimeStatus { get; }
			public DropDown RealTimeMode { get; }
			public PXNumberEdit MaxAttemptCount { get; }
			public DropDown ConnectorType { get; }
			public Selector BindingID { get; }
                
                public c_grid_row(c_entities_cstpxgrid60 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsActive = new CheckBox("ctl00_phG_tab_t1_CstPXGrid60_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    EntityType = new DropDown("_ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Entity", grid.Locator, "EntityType");
                    EntityType.DataField = "EntityType";
                    EntityType.Items.Add("PC", "Customer Price Class");
                    EntityType.Items.Add("CU", "Customer");
                    EntityType.Items.Add("AD", "Customer Location");
                    EntityType.Items.Add("SC", "Sales Category");
                    EntityType.Items.Add("IN", "Stock Item");
                    EntityType.Items.Add("NS", "Non-Stock Item");
                    EntityType.Items.Add("VP", "Template Item");
                    EntityType.Items.Add("SP", "Base Sales Price");
                    EntityType.Items.Add("PL", "Price List");
                    EntityType.Items.Add("PI", "Product Image");
                    EntityType.Items.Add("PA", "Product Availability");
                    EntityType.Items.Add("SO", "Sales Order");
                    EntityType.Items.Add("PY", "Payment");
                    EntityType.Items.Add("SH", "Shipment");
                    EntityType.Items.Add("OR", "Refunds");
                    Direction = new DropDown("_ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Sync Direction", grid.Locator, "Direction");
                    Direction.DataField = "Direction";
                    Direction.Items.Add("B", "Bidirectional");
                    Direction.Items.Add("I", "Import");
                    Direction.Items.Add("E", "Export");
                    PrimarySystem = new DropDown("_ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Primary System", grid.Locator, "PrimarySystem");
                    PrimarySystem.DataField = "PrimarySystem";
                    PrimarySystem.Items.Add("L", "Local");
                    PrimarySystem.Items.Add("E", "External");
                    ImportRealTimeStatus = new DropDown("_ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Real-Time Import", grid.Locator, "ImportRealTimeStatus");
                    ImportRealTimeStatus.DataField = "ImportRealTimeStatus";
                    ImportRealTimeStatus.Items.Add("R", "Running");
                    ImportRealTimeStatus.Items.Add("S", "Stopped");
                    ImportRealTimeStatus.Items.Add("E", "Stopped Due to an Error");
                    ImportRealTimeStatus.Items.Add("N", "Not Supported");
                    ExportRealTimeStatus = new DropDown("_ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Real-Time Export", grid.Locator, "ExportRealTimeStatus");
                    ExportRealTimeStatus.DataField = "ExportRealTimeStatus";
                    ExportRealTimeStatus.Items.Add("R", "Running");
                    ExportRealTimeStatus.Items.Add("S", "Stopped");
                    ExportRealTimeStatus.Items.Add("E", "Stopped Due to an Error");
                    ExportRealTimeStatus.Items.Add("N", "Not Supported");
                    RealTimeMode = new DropDown("_ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Real-Time Mode", grid.Locator, "RealTimeMode");
                    RealTimeMode.DataField = "RealTimeMode";
                    RealTimeMode.Items.Add("F", "Prepare");
                    RealTimeMode.Items.Add("S", "Prepare & Process");
                    MaxAttemptCount = new PXNumberEdit("_ctl00_phG_tab_t1_CstPXGrid60_lv0_CstPXNumberEdit70", "Max. Number of Failed Attempts", grid.Locator, "MaxAttemptCount");
                    MaxAttemptCount.DataField = "MaxAttemptCount";
                    ConnectorType = new DropDown("_ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Connector", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    ConnectorType.Items.Add("BCC", "BigCommerce");
                    ConnectorType.Items.Add("SPC", "Shopify");
                    BindingID = new Selector("_ctl00_phG_tab_t1_CstPXGrid60_lv0_es", "Store", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public DropDownColumnFilter EntityType { get; }
				public DropDownColumnFilter Direction { get; }
				public DropDownColumnFilter PrimarySystem { get; }
				public DropDownColumnFilter ImportRealTimeStatus { get; }
				public DropDownColumnFilter ExportRealTimeStatus { get; }
				public DropDownColumnFilter RealTimeMode { get; }
				public PXNumberEditColumnFilter MaxAttemptCount { get; }
				public DropDownColumnFilter ConnectorType { get; }
				public SelectorColumnFilter BindingID { get; }
                
                public c_grid_header(c_entities_cstpxgrid60 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    EntityType = new DropDownColumnFilter(grid.Row.EntityType);
                    Direction = new DropDownColumnFilter(grid.Row.Direction);
                    PrimarySystem = new DropDownColumnFilter(grid.Row.PrimarySystem);
                    ImportRealTimeStatus = new DropDownColumnFilter(grid.Row.ImportRealTimeStatus);
                    ExportRealTimeStatus = new DropDownColumnFilter(grid.Row.ExportRealTimeStatus);
                    RealTimeMode = new DropDownColumnFilter(grid.Row.RealTimeMode);
                    MaxAttemptCount = new PXNumberEditColumnFilter(grid.Row.MaxAttemptCount);
                    ConnectorType = new DropDownColumnFilter(grid.Row.ConnectorType);
                    BindingID = new SelectorColumnFilter(grid.Row.BindingID);
                }
            }
        }
        
        public class c_entities_lv0 : Container
        {
            
			public PXNumberEdit MaxAttemptCount { get; }
			public Label MaxAttemptCountLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_entities_lv0(string locator, string name) : 
                    base(locator, name)
            {
                MaxAttemptCount = new PXNumberEdit("ctl00_phG_tab_t1_CstPXGrid60_lv0_CstPXNumberEdit70", "Max. Number of Failed Attempts", locator, null);
                MaxAttemptCountLabel = new Label(MaxAttemptCount);
                MaxAttemptCount.DataField = "MaxAttemptCount";
                Ec = new DropDown("ctl00_phG_tab_t1_CstPXGrid60_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t1_CstPXGrid60_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t1_CstPXGrid60_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Em = new Selector("ctl00_phG_tab_t1_CstPXGrid60_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Entities";
            }
        }
        
        public class c_currentstore_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CustomerClassID { get; }
			public Label CustomerClassIDLabel { get; }
			public Selector CustomerTemplate { get; }
			public Label CustomerTemplateLabel { get; }
			public Selector CustomerNumberingID { get; }
			public Label CustomerNumberingIDLabel { get; }
			public Selector LocationTemplate { get; }
			public Label LocationTemplateLabel { get; }
			public Selector LocationNumberingID { get; }
			public Label LocationNumberingIDLabel { get; }
			public Selector InventoryNumberingID { get; }
			public Label InventoryNumberingIDLabel { get; }
			public Selector InventoryTemplate { get; }
			public Label InventoryTemplateLabel { get; }
			public Selector GuestCustomerID { get; }
			public Label GuestCustomerIDLabel { get; }
			public Selector StockItemClassID { get; }
			public Label StockItemClassIDLabel { get; }
			public Selector NonStockItemClassID { get; }
			public Label NonStockItemClassIDLabel { get; }
			public DropDown Availability { get; }
			public Label AvailabilityLabel { get; }
			public DropDown NotAvailMode { get; }
			public Label NotAvailModeLabel { get; }
			public DropDown AvailabilityCalcRule { get; }
			public Label AvailabilityCalcRuleLabel { get; }
			public DropDown WarehouseMode { get; }
			public Label WarehouseModeLabel { get; }
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector ReturnOrderType { get; }
			public Label ReturnOrderTypeLabel { get; }
			public Selector RefundAmountItemID { get; }
			public Label RefundAmountItemIDLabel { get; }
			public Selector ReasonCode { get; }
			public Label ReasonCodeLabel { get; }
			public DropDown OrderTimeZone { get; }
			public Label OrderTimeZoneLabel { get; }
			public DropDown PostDiscounts { get; }
			public Label PostDiscountsLabel { get; }
			public DropDown SyncTaxes { get; }
			public Label SyncTaxesLabel { get; }
			public Selector PrimaryTaxZoneID { get; }
			public Label PrimaryTaxZoneIDLabel { get; }
			public Selector DefaultTaxZoneID { get; }
			public Label DefaultTaxZoneIDLabel { get; }
			public Selector TaxSubstitutionListID { get; }
			public Label TaxSubstitutionListIDLabel { get; }
			public Selector TaxCategorySubstitutionListID { get; }
			public Label TaxCategorySubstitutionListIDLabel { get; }
            
            public c_currentstore_tab(string locator, string name) : 
                    base(locator, name)
            {
                CustomerClassID = new Selector("ctl00_phG_tab_t2_edCustomerClassID", "Customer Class", locator, null);
                CustomerClassIDLabel = new Label(CustomerClassID);
                CustomerClassID.DataField = "CustomerClassID";
                CustomerTemplate = new Selector("ctl00_phG_tab_t2_CstPXSegmentMask28", "Customer Numbering Template", locator, null);
                CustomerTemplateLabel = new Label(CustomerTemplate);
                CustomerTemplate.DataField = "CustomerTemplate";
                CustomerNumberingID = new Selector("ctl00_phG_tab_t2_CstPXSelector27", "Customer Autonumbering", locator, null);
                CustomerNumberingIDLabel = new Label(CustomerNumberingID);
                CustomerNumberingID.DataField = "CustomerNumberingID";
                LocationTemplate = new Selector("ctl00_phG_tab_t2_CstPXSegmentMask32", "Location Numbering Template", locator, null);
                LocationTemplateLabel = new Label(LocationTemplate);
                LocationTemplate.DataField = "LocationTemplate";
                LocationNumberingID = new Selector("ctl00_phG_tab_t2_CstPXSelector31", "Location Autonumbering", locator, null);
                LocationNumberingIDLabel = new Label(LocationNumberingID);
                LocationNumberingID.DataField = "LocationNumberingID";
                InventoryNumberingID = new Selector("ctl00_phG_tab_t2_CstPXSelector29", "Inventory Numbering", locator, null);
                InventoryNumberingIDLabel = new Label(InventoryNumberingID);
                InventoryNumberingID.DataField = "InventoryNumberingID";
                InventoryTemplate = new Selector("ctl00_phG_tab_t2_CstPXSegmentMask30", "Inventory Template", locator, null);
                InventoryTemplateLabel = new Label(InventoryTemplate);
                InventoryTemplate.DataField = "InventoryTemplate";
                GuestCustomerID = new Selector("ctl00_phG_tab_t2_CstPXSegmentMask49", "Generic Guest Customer", locator, null);
                GuestCustomerIDLabel = new Label(GuestCustomerID);
                GuestCustomerID.DataField = "GuestCustomerID";
                StockItemClassID = new Selector("ctl00_phG_tab_t3_CstPXSelector10", "Stock Item Class", locator, null);
                StockItemClassIDLabel = new Label(StockItemClassID);
                StockItemClassID.DataField = "StockItemClassID";
                NonStockItemClassID = new Selector("ctl00_phG_tab_t3_CstPXSelector9", "Non-Stock Item Class", locator, null);
                NonStockItemClassIDLabel = new Label(NonStockItemClassID);
                NonStockItemClassID.DataField = "NonStockItemClassID";
                Availability = new DropDown("ctl00_phG_tab_t3_CstPXDropDown57", "Default Availability", locator, null);
                AvailabilityLabel = new Label(Availability);
                Availability.DataField = "Availability";
                Availability.Items.Add("T", "Available - Track Qty");
                Availability.Items.Add("S", "Available - Don\'t Track Qty");
                Availability.Items.Add("P", "Pre-Order");
                Availability.Items.Add("D", "Disabled");
                NotAvailMode = new DropDown("ctl00_phG_tab_t3_CstPXDropDown58", "When Qty Unavailable", locator, null);
                NotAvailModeLabel = new Label(NotAvailMode);
                NotAvailMode.DataField = "NotAvailMode";
                NotAvailMode.Items.Add("N", "Do Nothing");
                NotAvailMode.Items.Add("D", "Set as Disabled");
                NotAvailMode.Items.Add("P", "Set as Pre-Order");
                AvailabilityCalcRule = new DropDown("ctl00_phG_tab_t3_CstPXDropDown45", "Availability Mode", locator, null);
                AvailabilityCalcRuleLabel = new Label(AvailabilityCalcRule);
                AvailabilityCalcRule.DataField = "AvailabilityCalcRule";
                AvailabilityCalcRule.Items.Add("A", "Available");
                AvailabilityCalcRule.Items.Add("S", "Available for Shipping");
                AvailabilityCalcRule.Items.Add("H", "On Hand");
                WarehouseMode = new DropDown("ctl00_phG_tab_t3_CstPXDropDown71", "Warehouse Mode", locator, null);
                WarehouseModeLabel = new Label(WarehouseMode);
                WarehouseMode.DataField = "WarehouseMode";
                WarehouseMode.Items.Add("A", "All");
                WarehouseMode.Items.Add("S", "Specific");
                OrderType = new Selector("ctl00_phG_tab_t4_edOrderTpe", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                ReturnOrderType = new Selector("ctl00_phG_tab_t4_edReturnOrderType", "Return Order Type", locator, null);
                ReturnOrderTypeLabel = new Label(ReturnOrderType);
                ReturnOrderType.DataField = "ReturnOrderType";
                RefundAmountItemID = new Selector("ctl00_phG_tab_t4_edRefundItem", "Refund Amount Item", locator, null);
                RefundAmountItemIDLabel = new Label(RefundAmountItemID);
                RefundAmountItemID.DataField = "RefundAmountItemID";
                ReasonCode = new Selector("ctl00_phG_tab_t4_edReasonCode", "Refund Reason Code", locator, null);
                ReasonCodeLabel = new Label(ReasonCode);
                ReasonCode.DataField = "ReasonCode";
                OrderTimeZone = new DropDown("ctl00_phG_tab_t4_edTimeZone", "Order Time Zone", locator, null);
                OrderTimeZoneLabel = new Label(OrderTimeZone);
                OrderTimeZone.DataField = "OrderTimeZone";
                OrderTimeZone.Items.Add("GMTM1200A", "(GMT-12:00) International Date Line West");
                OrderTimeZone.Items.Add("GMTM1000A", "(GMT-10:00) Hawaii");
                OrderTimeZone.Items.Add("GMTM0900A", "(GMT-09:00) Alaska");
                OrderTimeZone.Items.Add("GMTM0800A", "(GMT-08:00) Pacific Time (US & Canada)");
                OrderTimeZone.Items.Add("GMTM0800G", "(GMT-08:00) Tijuana, Baja California");
                OrderTimeZone.Items.Add("GMTM0700A", "(GMT-07:00) Arizona");
                OrderTimeZone.Items.Add("GMTM0700G", "(GMT-07:00) Chihuahua, La Paz, Mazatlan");
                OrderTimeZone.Items.Add("GMTM0700S", "(GMT-07:00) Mountain Time (US & Canada)");
                OrderTimeZone.Items.Add("GMTM0600A", "(GMT-06:00) Central America");
                OrderTimeZone.Items.Add("GMTM0600G", "(GMT-06:00) Central Time (US & Canada)");
                OrderTimeZone.Items.Add("GMTM0600M", "(GMT-06:00) Guadalajara, Mexico City, Monterrey");
                OrderTimeZone.Items.Add("GMTM0600Y", "(GMT-06:00) Saskatchewan");
                OrderTimeZone.Items.Add("GMTM0500A", "(GMT-05:00) Bogota, Lima, Quito, Rio Branco");
                OrderTimeZone.Items.Add("GMTM0500G", "(GMT-05:00) Eastern Time (US & Canada)");
                OrderTimeZone.Items.Add("GMTM0500M", "(GMT-05:00) Indiana (East)");
                OrderTimeZone.Items.Add("GMTM0400A", "(GMT-04:00) Atlantic Time (Canada)");
                OrderTimeZone.Items.Add("GMTM0400Y", "(GMT-04:00) Caracas");
                OrderTimeZone.Items.Add("GMTM0400G", "(GMT-04:00) La Paz");
                OrderTimeZone.Items.Add("GMTM0400M", "(GMT-04:00) Manaus");
                OrderTimeZone.Items.Add("GMTM0400S", "(GMT-04:00) Santiago");
                OrderTimeZone.Items.Add("GMTM0330A", "(GMT-03:30) Newfoundland");
                OrderTimeZone.Items.Add("GMTM0300A", "(GMT-03:00) Brasilia");
                OrderTimeZone.Items.Add("GMTM0300G", "(GMT-03:00) Buenos Aires, Georgetown");
                OrderTimeZone.Items.Add("GMTM0300M", "(GMT-03:00) Greenland");
                OrderTimeZone.Items.Add("GMTM0300S", "(GMT-03:00) Montevideo");
                OrderTimeZone.Items.Add("GMTM0200A", "(GMT-02:00) Mid-Atlantic");
                OrderTimeZone.Items.Add("GMTM0100A", "(GMT-01:00) Azores");
                OrderTimeZone.Items.Add("GMTM0100M", "(GMT-01:00) Cape Verde Is.");
                OrderTimeZone.Items.Add("GMTE0000A", "(GMT) Casablanca");
                OrderTimeZone.Items.Add("GMTE0000K", "(GMT) Greenwich Mean Time : Dublin, Edinburgh, Lisbon, London");
                OrderTimeZone.Items.Add("GMTE0000B", "(GMT) Monrovia, Reykjavik");
                OrderTimeZone.Items.Add("GMTE0000U", "(GMT) Universal Standard Time");
                OrderTimeZone.Items.Add("GMTP0100A", "(GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna");
                OrderTimeZone.Items.Add("GMTP0100G", "(GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague");
                OrderTimeZone.Items.Add("GMTP0100M", "(GMT+01:00) Brussels, Copenhagen, Madrid, Paris");
                OrderTimeZone.Items.Add("GMTP0100S", "(GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb");
                OrderTimeZone.Items.Add("GMTP0100Y", "(GMT+01:00) West Central Africa");
                OrderTimeZone.Items.Add("GMTP0200A", "(GMT+02:00) Amman");
                OrderTimeZone.Items.Add("GMTP0200D", "(GMT+02:00) Athens, Bucharest, Istanbul");
                OrderTimeZone.Items.Add("GMTP0200G", "(GMT+02:00) Beirut");
                OrderTimeZone.Items.Add("GMTP0200J", "(GMT+02:00) Cairo");
                OrderTimeZone.Items.Add("GMTP0200M", "(GMT+02:00) Harare, Pretoria");
                OrderTimeZone.Items.Add("GMTP0200P", "(GMT+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius");
                OrderTimeZone.Items.Add("GMTP0200S", "(GMT+02:00) Jerusalem");
                OrderTimeZone.Items.Add("GMTP0200V", "(GMT+02:00) Minsk");
                OrderTimeZone.Items.Add("GMTP0200Y", "(GMT+02:00) Windhoek");
                OrderTimeZone.Items.Add("GMTP0300A", "(GMT+03:00) Baghdad");
                OrderTimeZone.Items.Add("GMTP0300G", "(GMT+03:00) Kuwait, Riyadh");
                OrderTimeZone.Items.Add("GMTP0300M", "(GMT+03:00) Moscow, St. Petersburg, Volgograd");
                OrderTimeZone.Items.Add("GMTP0300S", "(GMT+03:00) Nairobi");
                OrderTimeZone.Items.Add("GMTP0330A", "(GMT+03:30) Tehran");
                OrderTimeZone.Items.Add("GMTP0400A", "(GMT+04:00) Abu Dhabi, Muscat");
                OrderTimeZone.Items.Add("GMTP0400G", "(GMT+04:00) Baku");
                OrderTimeZone.Items.Add("GMTP0400M", "(GMT+04:00) Caucasus Standard Time");
                OrderTimeZone.Items.Add("GMTP0400Y", "(GMT+04:00) Tbilisi");
                OrderTimeZone.Items.Add("GMTP0400S", "(GMT+04:00) Yerevan");
                OrderTimeZone.Items.Add("GMTP0430A", "(GMT+04:30) Kabul");
                OrderTimeZone.Items.Add("GMTP0500A", "(GMT+05:00) Ekaterinburg");
                OrderTimeZone.Items.Add("GMTP0500M", "(GMT+05:00) Islamabad, Karachi");
                OrderTimeZone.Items.Add("GMTP0500N", "(GMT+05:00) Tashkent");
                OrderTimeZone.Items.Add("GMTP0530A", "(GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi");
                OrderTimeZone.Items.Add("GMTP0530M", "(GMT+05:30) Sri Jayawardenepura");
                OrderTimeZone.Items.Add("GMTP0545A", "(GMT+05:45) Kathmandu");
                OrderTimeZone.Items.Add("GMTP0600M", "(GMT+06:00) Astana");
                OrderTimeZone.Items.Add("GMTP0600N", "(GMT+06:00) Dhaka");
                OrderTimeZone.Items.Add("GMTP0630A", "(GMT+06:30) Yangon (Rangoon)");
                OrderTimeZone.Items.Add("GMTP0700N", "(GMT+07:00) Almaty, Novosibirsk");
                OrderTimeZone.Items.Add("GMTP0700A", "(GMT+07:00) Bangkok, Hanoi, Jakarta");
                OrderTimeZone.Items.Add("GMTP0700M", "(GMT+07:00) Krasnoyarsk");
                OrderTimeZone.Items.Add("GMTP0800A", "(GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi");
                OrderTimeZone.Items.Add("GMTP0800G", "(GMT+08:00) Irkutsk, Ulaan Bataar");
                OrderTimeZone.Items.Add("GMTP0800M", "(GMT+08:00) Kuala Lumpur, Singapore");
                OrderTimeZone.Items.Add("GMTP0800S", "(GMT+08:00) Perth");
                OrderTimeZone.Items.Add("GMTP0800Y", "(GMT+08:00) Taipei");
                OrderTimeZone.Items.Add("GMTP0900A", "(GMT+09:00) Osaka, Sapporo, Tokyo");
                OrderTimeZone.Items.Add("GMTP0900G", "(GMT+09:00) Seoul");
                OrderTimeZone.Items.Add("GMTP0900M", "(GMT+09:00) Yakutsk");
                OrderTimeZone.Items.Add("GMTP0930A", "(GMT+09:30) Adelaide");
                OrderTimeZone.Items.Add("GMTP0930M", "(GMT+09:30) Darwin");
                OrderTimeZone.Items.Add("GMTP1000A", "(GMT+10:00) Brisbane");
                OrderTimeZone.Items.Add("GMTP1000G", "(GMT+10:00) Canberra, Melbourne, Sydney");
                OrderTimeZone.Items.Add("GMTP1000M", "(GMT+10:00) Guam, Port Moresby");
                OrderTimeZone.Items.Add("GMTP1000S", "(GMT+10:00) Hobart");
                OrderTimeZone.Items.Add("GMTP1000Y", "(GMT+10:00) Vladivostok");
                OrderTimeZone.Items.Add("GMTP1100A", "(GMT+11:00) Magadan");
                OrderTimeZone.Items.Add("GMTP1100B", "(GMT+11:00) Solomon Is., New Caledonia");
                OrderTimeZone.Items.Add("GMTP1200A", "(GMT+12:00) Auckland, Wellington");
                OrderTimeZone.Items.Add("GMTP1200K", "(GMT+12:00) Fiji");
                OrderTimeZone.Items.Add("GMTP1200G", "(GMT+12:00) Kamchatka, Marshall Is.");
                OrderTimeZone.Items.Add("GMTP1300M", "(GMT+13:00) Midway Island, Samoa");
                OrderTimeZone.Items.Add("GMTP1300A", "(GMT+13:00) Nuku\'alofa");
                PostDiscounts = new DropDown("ctl00_phG_tab_t4_CstPXDropDown80", "Show Discounts In", locator, null);
                PostDiscountsLabel = new Label(PostDiscounts);
                PostDiscounts.DataField = "PostDiscounts";
                PostDiscounts.Items.Add("L", "Line Discount");
                PostDiscounts.Items.Add("D", "Document Discount");
                SyncTaxes = new DropDown("ctl00_phG_tab_t4_CstPXDropDown117", "Synchronize Taxes", locator, null);
                SyncTaxesLabel = new Label(SyncTaxes);
                SyncTaxes.DataField = "SyncTaxes";
                SyncTaxes.Items.Add("N", "Do Not Synchronize");
                SyncTaxes.Items.Add("M", "Synchronize Manually");
                SyncTaxes.Items.Add("A", "Synchronize Automatically");
                PrimaryTaxZoneID = new Selector("ctl00_phG_tab_t4_PXSelector1", "Primary Tax Zone", locator, null);
                PrimaryTaxZoneIDLabel = new Label(PrimaryTaxZoneID);
                PrimaryTaxZoneID.DataField = "PrimaryTaxZoneID";
                DefaultTaxZoneID = new Selector("ctl00_phG_tab_t4_CstPXSelector118", "Default Tax Zone", locator, null);
                DefaultTaxZoneIDLabel = new Label(DefaultTaxZoneID);
                DefaultTaxZoneID.DataField = "DefaultTaxZoneID";
                TaxSubstitutionListID = new Selector("ctl00_phG_tab_t4_PXSelector2", "Tax Substitution List", locator, null);
                TaxSubstitutionListIDLabel = new Label(TaxSubstitutionListID);
                TaxSubstitutionListID.DataField = "TaxSubstitutionListID";
                TaxCategorySubstitutionListID = new Selector("ctl00_phG_tab_t4_PXSelector3", "Tax Category Substitution List", locator, null);
                TaxCategorySubstitutionListIDLabel = new Label(TaxCategorySubstitutionListID);
                TaxCategorySubstitutionListID.DataField = "TaxCategorySubstitutionListID";
                DataMemberName = "CurrentStore";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CustomerClassIDEdit()
            {
                Buttons.CustomerClassIDEdit.Click();
            }
            
            public virtual void CustomerNumberingIDEdit()
            {
                Buttons.CustomerNumberingIDEdit.Click();
            }
            
            public virtual void LocationNumberingIDEdit()
            {
                Buttons.LocationNumberingIDEdit.Click();
            }
            
            public virtual void InventoryNumberingIDEdit()
            {
                Buttons.InventoryNumberingIDEdit.Click();
            }
            
            public virtual void GuestCustomerIDEdit()
            {
                Buttons.GuestCustomerIDEdit.Click();
            }
            
            public virtual void StockItemClassIDEdit()
            {
                Buttons.StockItemClassIDEdit.Click();
            }
            
            public virtual void NonStockItemClassIDEdit()
            {
                Buttons.NonStockItemClassIDEdit.Click();
            }
            
            public virtual void CurrentBindingBranchIDEdit()
            {
                Buttons.CurrentBindingBranchIDEdit.Click();
            }
            
            public virtual void OrderTypeEdit()
            {
                Buttons.OrderTypeEdit.Click();
            }
            
            public virtual void ReturnOrderTypeEdit()
            {
                Buttons.ReturnOrderTypeEdit.Click();
            }
            
            public virtual void RefundAmountItemIDEdit()
            {
                Buttons.RefundAmountItemIDEdit.Click();
            }
            
            public virtual void ReasonCodeEdit()
            {
                Buttons.ReasonCodeEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CustomerClassIDEdit { get; }
			public Button CustomerNumberingIDEdit { get; }
			public Button LocationNumberingIDEdit { get; }
			public Button InventoryNumberingIDEdit { get; }
			public Button GuestCustomerIDEdit { get; }
			public Button StockItemClassIDEdit { get; }
			public Button NonStockItemClassIDEdit { get; }
			public Button CurrentBindingBranchIDEdit { get; }
			public Button OrderTypeEdit { get; }
			public Button ReturnOrderTypeEdit { get; }
			public Button RefundAmountItemIDEdit { get; }
			public Button ReasonCodeEdit { get; }
                
                public PxButtonCollection()
                {
                    CustomerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edCustomerClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "CustomerClassIDEdit", "ctl00_phG_tab");
                    CustomerClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CustomerNumberingIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_CstPXSelector27\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "CustomerNumberingIDEdit", "ctl00_phG_tab");
                    CustomerNumberingIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    LocationNumberingIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_CstPXSelector31\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LocationNumberingIDEdit", "ctl00_phG_tab");
                    LocationNumberingIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    InventoryNumberingIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_CstPXSelector29\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "InventoryNumberingIDEdit", "ctl00_phG_tab");
                    InventoryNumberingIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    GuestCustomerIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_CstPXSegmentMask49\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "GuestCustomerIDEdit", "ctl00_phG_tab");
                    GuestCustomerIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    StockItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_CstPXSelector10\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "StockItemClassIDEdit", "ctl00_phG_tab");
                    StockItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    NonStockItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_CstPXSelector9\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "NonStockItemClassIDEdit", "ctl00_phG_tab");
                    NonStockItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CurrentBindingBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edBranchID\'] div[class=\'editBtnCont\'] > div > div", "CurrentBinding.BranchIDEdit", "ctl00_phG_tab");
                    CurrentBindingBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    OrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edOrderTpe\'] div[class=\'editBtnCont\'] > div > div", "OrderTypeEdit", "ctl00_phG_tab");
                    OrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ReturnOrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edReturnOrderType\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "ReturnOrderTypeEdit", "ctl00_phG_tab");
                    ReturnOrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    RefundAmountItemIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edRefundItem\'] div[class=\'editBtnCont\'] > div > div", "RefundAmountItemIDEdit", "ctl00_phG_tab");
                    RefundAmountItemIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ReasonCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edReasonCode\'] div[class=\'editBtnCont\'] > div > div", "ReasonCodeEdit", "ctl00_phG_tab");
                    ReasonCodeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_currentbindingshopify_tab : Container
        {
            
			public PXTextEdit ShopifyApiBaseUrl { get; }
			public Label ShopifyApiBaseUrlLabel { get; }
			public PXTextEdit ShopifyApiKey { get; }
			public Label ShopifyApiKeyLabel { get; }
			public PXTextEdit ShopifyApiPassword { get; }
			public Label ShopifyApiPasswordLabel { get; }
			public PXTextEdit StoreSharedSecret { get; }
			public Label StoreSharedSecretLabel { get; }
			public DropDown ShopifyStorePlan { get; }
			public Label ShopifyStorePlanLabel { get; }
			public PXTextEdit ShopifyStoreUrl { get; }
			public Label ShopifyStoreUrlLabel { get; }
			public PXTextEdit ShopifyDefaultCurrency { get; }
			public Label ShopifyDefaultCurrencyLabel { get; }
			public PXTextEdit ShopifySupportCurrencies { get; }
			public Label ShopifySupportCurrenciesLabel { get; }
			public PXTextEdit ShopifyStoreTimeZone { get; }
			public Label ShopifyStoreTimeZoneLabel { get; }
			public DropDown CombineCategoriesToTags { get; }
			public Label CombineCategoriesToTagsLabel { get; }
            
            public c_currentbindingshopify_tab(string locator, string name) : 
                    base(locator, name)
            {
                ShopifyApiBaseUrl = new PXTextEdit("ctl00_phG_tab_t0_edShopifyApiBaseUrl", "Store Admin URL", locator, null);
                ShopifyApiBaseUrlLabel = new Label(ShopifyApiBaseUrl);
                ShopifyApiBaseUrl.DataField = "ShopifyApiBaseUrl";
                ShopifyApiKey = new PXTextEdit("ctl00_phG_tab_t0_edShopifyApiKey", "API Key", locator, null);
                ShopifyApiKeyLabel = new Label(ShopifyApiKey);
                ShopifyApiKey.DataField = "ShopifyApiKey";
                ShopifyApiPassword = new PXTextEdit("ctl00_phG_tab_t0_edShopifyApiPassword", "API Password", locator, null);
                ShopifyApiPasswordLabel = new Label(ShopifyApiPassword);
                ShopifyApiPassword.DataField = "ShopifyApiPassword";
                StoreSharedSecret = new PXTextEdit("ctl00_phG_tab_t0_edStoreSharedSecret", "Shared Secret", locator, null);
                StoreSharedSecretLabel = new Label(StoreSharedSecret);
                StoreSharedSecret.DataField = "StoreSharedSecret";
                ShopifyStorePlan = new DropDown("ctl00_phG_tab_t0_pdd_ShopifyStorePlan", "Store Plan", locator, null);
                ShopifyStorePlanLabel = new Label(ShopifyStorePlan);
                ShopifyStorePlan.DataField = "ShopifyStorePlan";
                ShopifyStorePlan.Items.Add("LP", "Shopify Lite");
                ShopifyStorePlan.Items.Add("BP", "Basic Shopify");
                ShopifyStorePlan.Items.Add("NP", "Shopify");
                ShopifyStorePlan.Items.Add("AP", "Advanced Shopify");
                ShopifyStorePlan.Items.Add("PP", "Shopify Plus");
                ShopifyStoreUrl = new PXTextEdit("ctl00_phG_tab_t0_txShopifyStoreUrl", "Store URL", locator, null);
                ShopifyStoreUrlLabel = new Label(ShopifyStoreUrl);
                ShopifyStoreUrl.DataField = "ShopifyStoreUrl";
                ShopifyDefaultCurrency = new PXTextEdit("ctl00_phG_tab_t0_txShopifyDefaultCurrency", "Default Currency", locator, null);
                ShopifyDefaultCurrencyLabel = new Label(ShopifyDefaultCurrency);
                ShopifyDefaultCurrency.DataField = "ShopifyDefaultCurrency";
                ShopifySupportCurrencies = new PXTextEdit("ctl00_phG_tab_t0_txShopifySupportCurrencies", "Supported Currencies", locator, null);
                ShopifySupportCurrenciesLabel = new Label(ShopifySupportCurrencies);
                ShopifySupportCurrencies.DataField = "ShopifySupportCurrencies";
                ShopifyStoreTimeZone = new PXTextEdit("ctl00_phG_tab_t0_txShopifyStoreTimeZone", "Store Time Zone", locator, null);
                ShopifyStoreTimeZoneLabel = new Label(ShopifyStoreTimeZone);
                ShopifyStoreTimeZone.DataField = "ShopifyStoreTimeZone";
                CombineCategoriesToTags = new DropDown("ctl00_phG_tab_t3_ddCombineCategoriesToTags", "Sales Category Export", locator, null);
                CombineCategoriesToTagsLabel = new Label(CombineCategoriesToTags);
                CombineCategoriesToTags.DataField = "CombineCategoriesToTags";
                CombineCategoriesToTags.Items.Add("N", "Do Nothing");
                CombineCategoriesToTags.Items.Add("E", "Sync Sales Categories to Product Tags");
                DataMemberName = "CurrentBindingShopify";
            }
        }
        
        public class c_currentbinding_tab : Container
        {
            
			public Selector LocaleName { get; }
			public Label LocaleNameLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
            
            public c_currentbinding_tab(string locator, string name) : 
                    base(locator, name)
            {
                LocaleName = new Selector("ctl00_phG_tab_t0_CstPXSelectorLocaleName", "Locale", locator, null);
                LocaleNameLabel = new Label(LocaleName);
                LocaleName.DataField = "LocaleName";
                BranchID = new Selector("ctl00_phG_tab_t4_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                DataMemberName = "CurrentBinding";
            }
        }
        
        public class c_locations_gridlocations : Grid<c_locations_gridlocations.c_grid_row, c_locations_gridlocations.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_locations_gridlocations(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_gridLocations");
                DataMemberName = "Locations";
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
            
            public virtual void StockItemClassIDEdit()
            {
                Buttons.StockItemClassIDEdit.Click();
            }
            
            public virtual void NonStockItemClassIDEdit()
            {
                Buttons.NonStockItemClassIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridLocations_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridLocations_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridLocations_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridLocations_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button StockItemClassIDEdit { get; }
			public Button NonStockItemClassIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    StockItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_CstPXSelector10\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "StockItemClassIDEdit", "ctl00_phG_tab_t3_gridLocations");
                    StockItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    NonStockItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_CstPXSelector9\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "NonStockItemClassIDEdit", "ctl00_phG_tab_t3_gridLocations");
                    NonStockItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t3_gridLocations_lfFirst0", "First", "ctl00_phG_tab_t3_gridLocations");
                    Prev = new Button("ctl00_phG_tab_t3_gridLocations_lfPrev0", "Prev", "ctl00_phG_tab_t3_gridLocations");
                    Next = new Button("ctl00_phG_tab_t3_gridLocations_lfNext0", "Next", "ctl00_phG_tab_t3_gridLocations");
                    Last = new Button("ctl00_phG_tab_t3_gridLocations_lfLast0", "Last", "ctl00_phG_tab_t3_gridLocations");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SiteID { get; }
			public Selector LocationID { get; }
			public PXNumberEdit BCLocationsID { get; }
                
                public c_grid_row(c_locations_gridlocations grid) : 
                        base(grid)
                {
                    SiteID = new Selector("_ctl00_phG_tab_t3_gridLocations_lv0_CstPXSelector73", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new Selector("_ctl00_phG_tab_t3_gridLocations_lv0_edLocationIDD", "Location ID", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    BCLocationsID = new PXNumberEdit("ctl00_phG_tab_t3_gridLocations_en", "BCLocationsID", grid.Locator, "BCLocationsID");
                    BCLocationsID.DataField = "BCLocationsID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXNumberEditColumnFilter BCLocationsID { get; }
                
                public c_grid_header(c_locations_gridlocations grid) : 
                        base(grid)
                {
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    BCLocationsID = new PXNumberEditColumnFilter(grid.Row.BCLocationsID);
                }
            }
        }
        
        public class c_locations_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
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
                LocationID = new Selector("ctl00_phG_tab_t3_gridLocations_lv0_edLocationIDD", "Location ID", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                Description = new PXTextEdit("ctl00_phG_tab_t3_gridLocations_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                SiteID = new Selector("ctl00_phG_tab_t3_gridLocations_lv0_CstPXSelector73", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                Es = new Selector("ctl00_phG_tab_t3_gridLocations_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t3_gridLocations_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t3_gridLocations_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t3_gridLocations_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Locations";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void StockItemClassIDEdit()
            {
                Buttons.StockItemClassIDEdit.Click();
            }
            
            public virtual void NonStockItemClassIDEdit()
            {
                Buttons.NonStockItemClassIDEdit.Click();
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
                
			public Button StockItemClassIDEdit { get; }
			public Button NonStockItemClassIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    StockItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_CstPXSelector10\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "StockItemClassIDEdit", "ctl00_phG_tab_t3_gridLocations_lv0");
                    StockItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    NonStockItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_CstPXSelector9\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "NonStockItemClassIDEdit", "ctl00_phG_tab_t3_gridLocations_lv0");
                    NonStockItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t3_gridLocations_lfFirst0", "First", "ctl00_phG_tab_t3_gridLocations_lv0");
                    Prev = new Button("ctl00_phG_tab_t3_gridLocations_lfPrev0", "Prev", "ctl00_phG_tab_t3_gridLocations_lv0");
                    Next = new Button("ctl00_phG_tab_t3_gridLocations_lfNext0", "Next", "ctl00_phG_tab_t3_gridLocations_lv0");
                    Last = new Button("ctl00_phG_tab_t3_gridLocations_lfLast0", "Last", "ctl00_phG_tab_t3_gridLocations_lv0");
                }
            }
        }
        
        public class c_paymentmethods_paymentsmethods : Grid<c_paymentmethods_paymentsmethods.c_grid_row, c_paymentmethods_paymentsmethods.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_paymentmethods_paymentsmethods(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_PaymentsMethods");
                DataMemberName = "PaymentMethods";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_PaymentsMethods_fe_gf", "FilterForm");
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
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PaymentsMethods_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PaymentsMethods_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PaymentsMethods_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PaymentsMethods_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PaymentsMethods_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PaymentsMethods_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PaymentsMethods_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfFirst0", "First", "ctl00_phG_tab_t5_PaymentsMethods");
                    Prev = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfPrev0", "Prev", "ctl00_phG_tab_t5_PaymentsMethods");
                    Next = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfNext0", "Next", "ctl00_phG_tab_t5_PaymentsMethods");
                    Last = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfLast0", "Last", "ctl00_phG_tab_t5_PaymentsMethods");
                    First1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfFirst0", "First", "ctl00_phG_tab_t5_PaymentsMethods");
                    Prev1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfPrev0", "Prev", "ctl00_phG_tab_t5_PaymentsMethods");
                    Next1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfNext0", "Next", "ctl00_phG_tab_t5_PaymentsMethods");
                    Last1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfLast0", "Last", "ctl00_phG_tab_t5_PaymentsMethods");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public PXTextEdit StorePaymentMethod { get; }
			public Selector PaymentMethodID { get; }
			public Selector CashAccountID { get; }
			public PXTextEdit CuryID { get; }
			public CheckBox ReleasePayments { get; }
			public Selector ProcessingCenterID { get; }
			public PXNumberEdit PaymentMappingID { get; }
                
                public c_grid_row(c_paymentmethods_paymentsmethods grid) : 
                        base(grid)
                {
                    Active = new CheckBox("ctl00_phG_tab_t5_PaymentsMethods_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    StorePaymentMethod = new PXTextEdit("ctl00_phG_tab_t5_PaymentsMethods_ei", "Store Payment Method", grid.Locator, "StorePaymentMethod");
                    StorePaymentMethod.DataField = "StorePaymentMethod";
                    PaymentMethodID = new Selector("_ctl00_phG_tab_t5_PaymentsMethods_lv0_es", "Payment Method ID", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    CashAccountID = new Selector("_ctl00_phG_tab_t5_PaymentsMethods_lv0_CstPXSelector112", "Cash Account", grid.Locator, "CashAccountID");
                    CashAccountID.DataField = "CashAccountID";
                    CuryID = new PXTextEdit("ctl00_phG_tab_t5_PaymentsMethods_ei", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    ReleasePayments = new CheckBox("ctl00_phG_tab_t5_PaymentsMethods_ef", "Release Payments", grid.Locator, "ReleasePayments");
                    ReleasePayments.DataField = "ReleasePayments";
                    ProcessingCenterID = new Selector("_ctl00_phG_tab_t5_PaymentsMethods_lv0_es", "Proc. Center ID", grid.Locator, "ProcessingCenterID");
                    ProcessingCenterID.DataField = "ProcessingCenterID";
                    PaymentMappingID = new PXNumberEdit("ctl00_phG_tab_t5_PaymentsMethods_en", "PaymentMappingID", grid.Locator, "PaymentMappingID");
                    PaymentMappingID.DataField = "PaymentMappingID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public PXTextEditColumnFilter StorePaymentMethod { get; }
				public SelectorColumnFilter PaymentMethodID { get; }
				public SelectorColumnFilter CashAccountID { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public CheckBoxColumnFilter ReleasePayments { get; }
				public SelectorColumnFilter ProcessingCenterID { get; }
				public PXNumberEditColumnFilter PaymentMappingID { get; }
                
                public c_grid_header(c_paymentmethods_paymentsmethods grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    StorePaymentMethod = new PXTextEditColumnFilter(grid.Row.StorePaymentMethod);
                    PaymentMethodID = new SelectorColumnFilter(grid.Row.PaymentMethodID);
                    CashAccountID = new SelectorColumnFilter(grid.Row.CashAccountID);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    ReleasePayments = new CheckBoxColumnFilter(grid.Row.ReleasePayments);
                    ProcessingCenterID = new SelectorColumnFilter(grid.Row.ProcessingCenterID);
                    PaymentMappingID = new PXNumberEditColumnFilter(grid.Row.PaymentMappingID);
                }
            }
        }
        
        public class c_paymentmethods_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_paymentmethods_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CashAccountID = new Selector("ctl00_phG_tab_t5_PaymentsMethods_lv0_CstPXSelector112", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                Es = new Selector("ctl00_phG_tab_t5_PaymentsMethods_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t5_PaymentsMethods_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t5_PaymentsMethods_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t5_PaymentsMethods_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "PaymentMethods";
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
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfFirst0", "First", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                    Prev = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfPrev0", "Prev", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                    Next = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfNext0", "Next", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                    Last = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfLast0", "Last", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                    First1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfFirst0", "First", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfPrev0", "Prev", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                    Next1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfNext0", "Next", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                    Last1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfLast0", "Last", "ctl00_phG_tab_t5_PaymentsMethods_lv0");
                }
            }
        }
        
        public class c_multicurrency_multicurrency : Grid<c_multicurrency_multicurrency.c_grid_row, c_multicurrency_multicurrency.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_multicurrency_multicurrency(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_MultiCurrency");
                DataMemberName = "MultiCurrency";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_MultiCurrency_fe_gf", "FilterForm");
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
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_MultiCurrency_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_MultiCurrency_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_MultiCurrency_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_MultiCurrency_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_MultiCurrency_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_MultiCurrency_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_MultiCurrency_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfFirst0", "First", "ctl00_phG_tab_t5_MultiCurrency");
                    Prev = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfPrev0", "Prev", "ctl00_phG_tab_t5_MultiCurrency");
                    Next = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfNext0", "Next", "ctl00_phG_tab_t5_MultiCurrency");
                    Last = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfLast0", "Last", "ctl00_phG_tab_t5_MultiCurrency");
                    First1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfFirst0", "First", "ctl00_phG_tab_t5_MultiCurrency");
                    Prev1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfPrev0", "Prev", "ctl00_phG_tab_t5_MultiCurrency");
                    Next1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfNext0", "Next", "ctl00_phG_tab_t5_MultiCurrency");
                    Last1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfLast0", "Last", "ctl00_phG_tab_t5_MultiCurrency");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector CashAccountID { get; }
			public PXTextEdit CuryID { get; }
			public Selector BindingID { get; }
			public PXNumberEdit PaymentMappingID { get; }
                
                public c_grid_row(c_multicurrency_multicurrency grid) : 
                        base(grid)
                {
                    CashAccountID = new Selector("_ctl00_phG_tab_t5_MultiCurrency_lv0_CstPXSelector111", "Cash Account", grid.Locator, "CashAccountID");
                    CashAccountID.DataField = "CashAccountID";
                    CuryID = new PXTextEdit("ctl00_phG_tab_t5_MultiCurrency_ei", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    BindingID = new Selector("_ctl00_phG_tab_t5_MultiCurrency_lv0_es", "Store", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                    PaymentMappingID = new PXNumberEdit("ctl00_phG_tab_t5_MultiCurrency_en", "PaymentMappingID", grid.Locator, "PaymentMappingID");
                    PaymentMappingID.DataField = "PaymentMappingID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter CashAccountID { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public SelectorColumnFilter BindingID { get; }
				public PXNumberEditColumnFilter PaymentMappingID { get; }
                
                public c_grid_header(c_multicurrency_multicurrency grid) : 
                        base(grid)
                {
                    CashAccountID = new SelectorColumnFilter(grid.Row.CashAccountID);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    BindingID = new SelectorColumnFilter(grid.Row.BindingID);
                    PaymentMappingID = new PXNumberEditColumnFilter(grid.Row.PaymentMappingID);
                }
            }
        }
        
        public class c_multicurrency_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CashAccount { get; }
			public Label CashAccountLabel { get; }
			public PXTextEdit Currency { get; }
			public Label CurrencyLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_multicurrency_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CashAccount = new Selector("ctl00_phG_tab_t5_MultiCurrency_lv0_CstPXSelector108", "Cash Account", locator, null);
                CashAccountLabel = new Label(CashAccount);
                CashAccount.DataField = "CashAccount";
                Currency = new PXTextEdit("ctl00_phG_tab_t5_MultiCurrency_lv0_CstPXTextEdit110", "Currency", locator, null);
                CurrencyLabel = new Label(Currency);
                Currency.DataField = "Currency";
                CashAccountID = new Selector("ctl00_phG_tab_t5_MultiCurrency_lv0_CstPXSelector111", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                Es = new Selector("ctl00_phG_tab_t5_MultiCurrency_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "MultiCurrency";
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
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfFirst0", "First", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                    Prev = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfPrev0", "Prev", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                    Next = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfNext0", "Next", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                    Last = new Button("ctl00_phG_tab_t5_PaymentsMethods_lfLast0", "Last", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                    First1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfFirst0", "First", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfPrev0", "Prev", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                    Next1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfNext0", "Next", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                    Last1 = new Button("ctl00_phG_tab_t5_MultiCurrency_lfLast0", "Last", "ctl00_phG_tab_t5_MultiCurrency_lv0");
                }
            }
        }
        
        public class c_shippingmappings_shippingmappings : Grid<c_shippingmappings_shippingmappings.c_grid_row, c_shippingmappings_shippingmappings.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_shippingmappings_shippingmappings(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_ShippingMappings");
                DataMemberName = "ShippingMappings";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_ShippingMappings_fe_gf", "FilterForm");
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
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void OrderTypeEdit()
            {
                Buttons.OrderTypeEdit.Click();
            }
            
            public virtual void ReturnOrderTypeEdit()
            {
                Buttons.ReturnOrderTypeEdit.Click();
            }
            
            public virtual void RefundAmountItemIDEdit()
            {
                Buttons.RefundAmountItemIDEdit.Click();
            }
            
            public virtual void ReasonCodeEdit()
            {
                Buttons.ReasonCodeEdit.Click();
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
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_ShippingMappings_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_ShippingMappings_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_ShippingMappings_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_ShippingMappings_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_ShippingMappings_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_ShippingMappings_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_ShippingMappings_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderTypeEdit { get; }
			public Button ReturnOrderTypeEdit { get; }
			public Button RefundAmountItemIDEdit { get; }
			public Button ReasonCodeEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    OrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edOrderTpe\'] div[class=\'editBtnCont\'] > div > div", "OrderTypeEdit", "ctl00_phG_tab_t4_ShippingMappings");
                    OrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ReturnOrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edReturnOrderType\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "ReturnOrderTypeEdit", "ctl00_phG_tab_t4_ShippingMappings");
                    ReturnOrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    RefundAmountItemIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edRefundItem\'] div[class=\'editBtnCont\'] > div > div", "RefundAmountItemIDEdit", "ctl00_phG_tab_t4_ShippingMappings");
                    RefundAmountItemIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ReasonCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edReasonCode\'] div[class=\'editBtnCont\'] > div > div", "ReasonCodeEdit", "ctl00_phG_tab_t4_ShippingMappings");
                    ReasonCodeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t4_ShippingMappings_lfFirst0", "First", "ctl00_phG_tab_t4_ShippingMappings");
                    Prev = new Button("ctl00_phG_tab_t4_ShippingMappings_lfPrev0", "Prev", "ctl00_phG_tab_t4_ShippingMappings");
                    Next = new Button("ctl00_phG_tab_t4_ShippingMappings_lfNext0", "Next", "ctl00_phG_tab_t4_ShippingMappings");
                    Last = new Button("ctl00_phG_tab_t4_ShippingMappings_lfLast0", "Last", "ctl00_phG_tab_t4_ShippingMappings");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ShippingZone { get; }
			public PXTextEdit ShippingMethod { get; }
			public Selector CarrierID { get; }
			public Selector ZoneID { get; }
			public Selector ShipTermsID { get; }
			public PXNumberEdit ShippingMappingID { get; }
                
                public c_grid_row(c_shippingmappings_shippingmappings grid) : 
                        base(grid)
                {
                    ShippingZone = new PXTextEdit("ctl00_phG_tab_t4_ShippingMappings_ei", "Store Shipping Zone", grid.Locator, "ShippingZone");
                    ShippingZone.DataField = "ShippingZone";
                    ShippingMethod = new PXTextEdit("ctl00_phG_tab_t4_ShippingMappings_ei", "Store Shipping Method", grid.Locator, "ShippingMethod");
                    ShippingMethod.DataField = "ShippingMethod";
                    CarrierID = new Selector("_ctl00_phG_tab_t4_ShippingMappings_lv0_es", "Ship Via", grid.Locator, "CarrierID");
                    CarrierID.DataField = "CarrierID";
                    ZoneID = new Selector("_ctl00_phG_tab_t4_ShippingMappings_lv0_es", "Shipping Zone", grid.Locator, "ZoneID");
                    ZoneID.DataField = "ZoneID";
                    ShipTermsID = new Selector("_ctl00_phG_tab_t4_ShippingMappings_lv0_es", "Ship Terms", grid.Locator, "ShipTermsID");
                    ShipTermsID.DataField = "ShipTermsID";
                    ShippingMappingID = new PXNumberEdit("ctl00_phG_tab_t4_ShippingMappings_en", "ShippingMappingID", grid.Locator, "ShippingMappingID");
                    ShippingMappingID.DataField = "ShippingMappingID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ShippingZone { get; }
				public PXTextEditColumnFilter ShippingMethod { get; }
				public SelectorColumnFilter CarrierID { get; }
				public SelectorColumnFilter ZoneID { get; }
				public SelectorColumnFilter ShipTermsID { get; }
				public PXNumberEditColumnFilter ShippingMappingID { get; }
                
                public c_grid_header(c_shippingmappings_shippingmappings grid) : 
                        base(grid)
                {
                    ShippingZone = new PXTextEditColumnFilter(grid.Row.ShippingZone);
                    ShippingMethod = new PXTextEditColumnFilter(grid.Row.ShippingMethod);
                    CarrierID = new SelectorColumnFilter(grid.Row.CarrierID);
                    ZoneID = new SelectorColumnFilter(grid.Row.ZoneID);
                    ShipTermsID = new SelectorColumnFilter(grid.Row.ShipTermsID);
                    ShippingMappingID = new PXNumberEditColumnFilter(grid.Row.ShippingMappingID);
                }
            }
        }
        
        public class c_shippingmappings_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_shippingmappings_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t4_ShippingMappings_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t4_ShippingMappings_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t4_ShippingMappings_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t4_ShippingMappings_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ShippingMappings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderTypeEdit()
            {
                Buttons.OrderTypeEdit.Click();
            }
            
            public virtual void ReturnOrderTypeEdit()
            {
                Buttons.ReturnOrderTypeEdit.Click();
            }
            
            public virtual void RefundAmountItemIDEdit()
            {
                Buttons.RefundAmountItemIDEdit.Click();
            }
            
            public virtual void ReasonCodeEdit()
            {
                Buttons.ReasonCodeEdit.Click();
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
                
			public Button OrderTypeEdit { get; }
			public Button ReturnOrderTypeEdit { get; }
			public Button RefundAmountItemIDEdit { get; }
			public Button ReasonCodeEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    OrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edOrderTpe\'] div[class=\'editBtnCont\'] > div > div", "OrderTypeEdit", "ctl00_phG_tab_t4_ShippingMappings_lv0");
                    OrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ReturnOrderTypeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edReturnOrderType\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "ReturnOrderTypeEdit", "ctl00_phG_tab_t4_ShippingMappings_lv0");
                    ReturnOrderTypeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    RefundAmountItemIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edRefundItem\'] div[class=\'editBtnCont\'] > div > div", "RefundAmountItemIDEdit", "ctl00_phG_tab_t4_ShippingMappings_lv0");
                    RefundAmountItemIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ReasonCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edReasonCode\'] div[class=\'editBtnCont\'] > div > div", "ReasonCodeEdit", "ctl00_phG_tab_t4_ShippingMappings_lv0");
                    ReasonCodeEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t4_ShippingMappings_lfFirst0", "First", "ctl00_phG_tab_t4_ShippingMappings_lv0");
                    Prev = new Button("ctl00_phG_tab_t4_ShippingMappings_lfPrev0", "Prev", "ctl00_phG_tab_t4_ShippingMappings_lv0");
                    Next = new Button("ctl00_phG_tab_t4_ShippingMappings_lfNext0", "Next", "ctl00_phG_tab_t4_ShippingMappings_lv0");
                    Last = new Button("ctl00_phG_tab_t4_ShippingMappings_lfLast0", "Last", "ctl00_phG_tab_t4_ShippingMappings_lv0");
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
    }
}
