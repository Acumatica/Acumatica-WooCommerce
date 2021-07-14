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
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ACBC.Tests.Wrappers
{
    
    
    public class BC301000_BCSyncHistoryMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_masterview_form MasterView_form { get; } = new c_masterview_form("ctl00_phF_form", "MasterView_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_detailsview_grid DetailsView_grid { get; } = new c_detailsview_grid("ctl00_phG_grid", "DetailsView_grid");
        protected c_detailsview_lv0 DetailsView_lv0 { get; } = new c_detailsview_lv0("ctl00_phG_grid_lv0", "DetailsView_lv0");
        protected c_statuseditpanel_cstformview17 StatusEditPanel_CstFormView17 { get; } = new c_statuseditpanel_cstformview17("ctl00_phG_CstSmartPanel16_CstFormView17", "StatusEditPanel_CstFormView17");
        protected c_statusdetailspanel_gridrecorddetails StatusDetailsPanel_gridRecordDetails { get; } = new c_statusdetailspanel_gridrecorddetails("ctl00_phG_PXDetailsPanel_gridRecordDetails", "StatusDetailsPanel_gridRecordDetails");
        protected c_statusdetailspanel_lv0 StatusDetailsPanel_lv0 { get; } = new c_statusdetailspanel_lv0("ctl00_phG_PXDetailsPanel_gridRecordDetails_lv0", "StatusDetailsPanel_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public BC301000_BCSyncHistoryMaint()
        {
            ScreenId = "BC301000";
            ScreenUrl = "/Pages/BC/BC301000.aspx";
            ToolBar = new PxToolBar(null);
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
        
        public virtual void Refresh()
        {
            ToolBar.Refresh.Click();
        }
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Sync()
        {
            ToolBar.Sync.Click();
        }
        
        public virtual void Sync(bool status, string message = null)
        {
            ToolBar.Sync.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Sync.Click();
        }
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void Skip()
        {
            ToolBar.Skip.Click();
        }
        
        public virtual void SetSynced()
        {
            ToolBar.SetSynced.Click();
        }
        
        public virtual void NavigateEntity()
        {
            ToolBar.NavigateEntity.Click();
        }
        
        public virtual void StatusAddAction()
        {
            ToolBar.StatusAddAction.Click();
        }
        
        public virtual void StatusEditAction()
        {
            ToolBar.StatusEditAction.Click();
        }
        
        public virtual void StatusDetailsAction()
        {
            ToolBar.StatusDetailsAction.Click();
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
			public ToolBarButton Refresh { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Sync { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton Skip { get; }
			public ToolBarButton SetSynced { get; }
			public ToolBarButton NavigateEntity { get; }
			public ToolBarButton StatusAddAction { get; }
			public ToolBarButton StatusEditAction { get; }
			public ToolBarButton StatusDetailsAction { get; }
			public ToolBarButton Adjust { get; }
			public ToolBarButton Export { get; }
			public ToolBarButton Filter { get; }
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
                Refresh = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Save\']", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Sync = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'sync\']", "Sync", locator, null);
                Sync.WaitAction = Wait.WaitForLongOperationToComplete;
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'delete\']", "Delete", locator, null);
                Skip = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'skip\']", "Skip", locator, null);
                SetSynced = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'setSynced\']", "Set Synced", locator, null);
                NavigateEntity = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'navigateEntity\']", "Navigate Entity", locator, null);
                StatusAddAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'statusAddAction\']", "Add New", locator, null);
                StatusEditAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'statusEditAction\']", "Edit", locator, null);
                StatusDetailsAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'statusDetailsAction\']", "View Details", locator, null);
                Adjust = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                Export = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                Filter = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_masterview_form : Container
        {
            
			public Selector BindingID { get; }
			public Label BindingIDLabel { get; }
			public DropDown EntityType { get; }
			public Label EntityTypeLabel { get; }
            
            public c_masterview_form(string locator, string name) : 
                    base(locator, name)
            {
                BindingID = new Selector("ctl00_phF_form_CstPXSelector13", "Store", locator, null);
                BindingIDLabel = new Label(BindingID);
                BindingID.DataField = "BindingID";
                EntityType = new DropDown("ctl00_phF_form_CstPXDropDown2", "Entity", locator, null);
                EntityTypeLabel = new Label(EntityType);
                EntityType.DataField = "EntityType";
                EntityType.Items.Add("CU", "Customer");
                EntityType.Items.Add("AD", "Customer Location");
                EntityType.Items.Add("IN", "Stock Item");
                EntityType.Items.Add("NS", "Non-Stock Item");
                EntityType.Items.Add("VP", "Template Item");
                EntityType.Items.Add("PI", "Product Image");
                EntityType.Items.Add("PA", "Product Availability");
                EntityType.Items.Add("SO", "Sales Order");
                EntityType.Items.Add("PY", "Payment");
                EntityType.Items.Add("SH", "Shipment");
                EntityType.Items.Add("OR", "Refunds");
                DataMemberName = "MasterView";
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
        
        public class c_detailsview_grid : Grid<c_detailsview_grid.c_grid_row, c_detailsview_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_detailsview_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_grid");
                DataMemberName = "DetailsView";
                FilterForm = new c_grid_filter("ctl00_phG_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void AllRecords()
            {
                ToolBar.AllRecords.Click();
            }
            
            public virtual void PendingFailed()
            {
                ToolBar.PendingFailed.Click();
            }
            
            public virtual void Failed()
            {
                ToolBar.Failed.Click();
            }
            
            public virtual void Synchronized()
            {
                ToolBar.Synchronized.Click();
            }
            
            public virtual void Skipped()
            {
                ToolBar.Skipped.Click();
            }
            
            public virtual void Aborted()
            {
                ToolBar.Aborted.Click();
            }
            
            public virtual void Deleted()
            {
                ToolBar.Deleted.Click();
            }
            
            public virtual void Filtered()
            {
                ToolBar.Filtered.Click();
            }
            
            public virtual void Invalid()
            {
                ToolBar.Invalid.Click();
            }
            
            public virtual void Inactive()
            {
                ToolBar.Inactive.Click();
            }
            
            public virtual void Edit()
            {
                ToolBar.Edit.Click();
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
                
			public ToolBarButtonGrid AllRecords { get; }
			public ToolBarButtonGrid PendingFailed { get; }
			public ToolBarButtonGrid Failed { get; }
			public ToolBarButtonGrid Synchronized { get; }
			public ToolBarButtonGrid Skipped { get; }
			public ToolBarButtonGrid Aborted { get; }
			public ToolBarButtonGrid Deleted { get; }
			public ToolBarButtonGrid Filtered { get; }
			public ToolBarButtonGrid Invalid { get; }
			public ToolBarButtonGrid Inactive { get; }
			public ToolBarButtonGrid Edit { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    AllRecords = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div[data-cmd=\'all\']", "All Records", locator, null);
                    PendingFailed = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Pendi" +
                            "ng & Failed\")", "Pending & Failed", locator, null);
                    Failed = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Faile" +
                            "d\")", "Failed", locator, null);
                    Synchronized = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Synch" +
                            "ronized\")", "Synchronized", locator, null);
                    Skipped = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Skipp" +
                            "ed\")", "Skipped", locator, null);
                    Aborted = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Abort" +
                            "ed\")", "Aborted", locator, null);
                    Deleted = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Delet" +
                            "ed\")", "Deleted", locator, null);
                    Filtered = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Filte" +
                            "red\")", "Filtered", locator, null);
                    Invalid = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Inval" +
                            "id\")", "Invalid", locator, null);
                    Inactive = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div.toolsBtn > div[data-type=\'button\']:textEqual(\"Inact" +
                            "ive\")", "Inactive", locator, null);
                    Edit = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div[data-cmd=\'edit\']", "Edit", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public Selector SyncID { get; }
			public DropDown ConnectorType { get; }
			public DropDown EntityType { get; }
			public Selector BindingID { get; }
			public PXTextEdit LocalID { get; }
			public PXTextEdit Source { get; }
			public PXTextEdit ExternID { get; }
			public DropDown Status { get; }
			public CheckBox PendingSync { get; }
			public DropDown BCEntity__PrimarySystem { get; }
			public DropDown BCEntity__Direction { get; }
			public DateSelector LocalTS { get; }
			public DateSelector ExternTS { get; }
			public PXTextEdit ExternHash { get; }
			public PXTextEdit LastErrorMessage { get; }
			public DropDown LastOperation { get; }
			public DateSelector LastOperationTS { get; }
			public PXNumberEdit AttemptCount { get; }
			public CheckBox BCEntity__IsActive { get; }
                
                public c_grid_row(c_detailsview_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_grid_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    SyncID = new Selector("_ctl00_phG_grid_lv0_es", "Sync Record ID", grid.Locator, "SyncID");
                    SyncID.DataField = "SyncID";
                    ConnectorType = new DropDown("_ctl00_phG_grid_lv0_ec", "Connector", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    ConnectorType.Items.Add("BCC", "BigCommerce");
                    ConnectorType.Items.Add("SPC", "Shopify");
                    EntityType = new DropDown("_ctl00_phG_grid_lv0_ec", "Entity", grid.Locator, "EntityType");
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
                    BindingID = new Selector("_ctl00_phG_grid_lv0_es", "Store", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                    LocalID = new PXTextEdit("ctl00_phG_grid", "Ref. Note ID", grid.Locator, "LocalID");
                    LocalID.DataField = "LocalID";
                    Source = new PXTextEdit("ctl00_phG_grid_ei", "Local ID", grid.Locator, "Source");
                    Source.DataField = "Source";
                    ExternID = new PXTextEdit("ctl00_phG_grid_ei", "External ID", grid.Locator, "ExternID");
                    ExternID.DataField = "ExternID";
                    Status = new DropDown("_ctl00_phG_grid_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("F", "Failed");
                    Status.Items.Add("P", "Pending");
                    Status.Items.Add("D", "Synchronized");
                    Status.Items.Add("A", "Aborted");
                    Status.Items.Add("S", "Skipped");
                    Status.Items.Add("L", "Deleted");
                    Status.Items.Add("N", "Invalid");
                    Status.Items.Add("O", "Filtered");
                    PendingSync = new CheckBox("ctl00_phG_grid", "Pending Sync", grid.Locator, "PendingSync");
                    PendingSync.DataField = "PendingSync";
                    BCEntity__PrimarySystem = new DropDown("_ctl00_phG_grid_lv0_ec", "Primary System", grid.Locator, "BCEntity__PrimarySystem");
                    BCEntity__PrimarySystem.DataField = "BCEntity__PrimarySystem";
                    BCEntity__PrimarySystem.Items.Add("L", "Local");
                    BCEntity__PrimarySystem.Items.Add("E", "External");
                    BCEntity__Direction = new DropDown("_ctl00_phG_grid_lv0_ec", "Sync Direction", grid.Locator, "BCEntity__Direction");
                    BCEntity__Direction.DataField = "BCEntity__Direction";
                    BCEntity__Direction.Items.Add("B", "Bidirectional");
                    BCEntity__Direction.Items.Add("I", "Import");
                    BCEntity__Direction.Items.Add("E", "Export");
                    LocalTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit10", "Last Locally Modified", grid.Locator, "LocalTS");
                    LocalTS.DataField = "LocalTS";
                    ExternTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit8", "Last Externally  Modified", grid.Locator, "ExternTS");
                    ExternTS.DataField = "ExternTS";
                    ExternHash = new PXTextEdit("ctl00_phG_grid_ei", "External Hash", grid.Locator, "ExternHash");
                    ExternHash.DataField = "ExternHash";
                    LastErrorMessage = new PXTextEdit("ctl00_phG_grid_ei", "Last Error", grid.Locator, "LastErrorMessage");
                    LastErrorMessage.DataField = "LastErrorMessage";
                    LastOperation = new DropDown("_ctl00_phG_grid_lv0_ec", "Last Operation", grid.Locator, "LastOperation");
                    LastOperation.DataField = "LastOperation";
                    LastOperation.Items.Add("LI", "Inserted Locally");
                    LastOperation.Items.Add("LU", "Updated Locally");
                    LastOperation.Items.Add("LD", "Deleted Locally");
                    LastOperation.Items.Add("LC", "Modified Locally");
                    LastOperation.Items.Add("LF", "Failed to Save Locally");
                    LastOperation.Items.Add("LO", "Conflict Resolved by Override Locally");
                    LastOperation.Items.Add("EI", "Inserted Externally");
                    LastOperation.Items.Add("EU", "Updated Externally");
                    LastOperation.Items.Add("ED", "Deleted Externally");
                    LastOperation.Items.Add("EC", "Modified Externally");
                    LastOperation.Items.Add("EF", "Failed to Save Externally");
                    LastOperation.Items.Add("EO", "Conflict Resolved by Override Externally");
                    LastOperation.Items.Add("SF", "Sync Failed");
                    LastOperation.Items.Add("MS", "Manually Synchronized");
                    LastOperation.Items.Add("FR", "Forced to Resync");
                    LastOperation.Items.Add("NF", "Not Found");
                    LastOperation.Items.Add("CF", "Sync Settings Reconfigured");
                    LastOperation.Items.Add("SK", "Skipped from Sync");
                    LastOperation.Items.Add("RS", "Filtering Applied");
                    LastOperationTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit9", "Last Attempt", grid.Locator, "LastOperationTS");
                    LastOperationTS.DataField = "LastOperationTS";
                    AttemptCount = new PXNumberEdit("ctl00_phG_grid_en", "Attempts Count", grid.Locator, "AttemptCount");
                    AttemptCount.DataField = "AttemptCount";
                    BCEntity__IsActive = new CheckBox("ctl00_phG_grid", "Active", grid.Locator, "BCEntity__IsActive");
                    BCEntity__IsActive.DataField = "BCEntity__IsActive";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter SyncID { get; }
				public DropDownColumnFilter ConnectorType { get; }
				public DropDownColumnFilter EntityType { get; }
				public SelectorColumnFilter BindingID { get; }
				public PXTextEditColumnFilter LocalID { get; }
				public PXTextEditColumnFilter Source { get; }
				public PXTextEditColumnFilter ExternID { get; }
				public DropDownColumnFilter Status { get; }
				public CheckBoxColumnFilter PendingSync { get; }
				public DropDownColumnFilter BCEntity__PrimarySystem { get; }
				public DropDownColumnFilter BCEntity__Direction { get; }
				public DateSelectorColumnFilter LocalTS { get; }
				public DateSelectorColumnFilter ExternTS { get; }
				public PXTextEditColumnFilter ExternHash { get; }
				public PXTextEditColumnFilter LastErrorMessage { get; }
				public DropDownColumnFilter LastOperation { get; }
				public DateSelectorColumnFilter LastOperationTS { get; }
				public PXNumberEditColumnFilter AttemptCount { get; }
				public CheckBoxColumnFilter BCEntity__IsActive { get; }
                
                public c_grid_header(c_detailsview_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    SyncID = new SelectorColumnFilter(grid.Row.SyncID);
                    ConnectorType = new DropDownColumnFilter(grid.Row.ConnectorType);
                    EntityType = new DropDownColumnFilter(grid.Row.EntityType);
                    BindingID = new SelectorColumnFilter(grid.Row.BindingID);
                    LocalID = new PXTextEditColumnFilter(grid.Row.LocalID);
                    Source = new PXTextEditColumnFilter(grid.Row.Source);
                    ExternID = new PXTextEditColumnFilter(grid.Row.ExternID);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    PendingSync = new CheckBoxColumnFilter(grid.Row.PendingSync);
                    BCEntity__PrimarySystem = new DropDownColumnFilter(grid.Row.BCEntity__PrimarySystem);
                    BCEntity__Direction = new DropDownColumnFilter(grid.Row.BCEntity__Direction);
                    LocalTS = new DateSelectorColumnFilter(grid.Row.LocalTS);
                    ExternTS = new DateSelectorColumnFilter(grid.Row.ExternTS);
                    ExternHash = new PXTextEditColumnFilter(grid.Row.ExternHash);
                    LastErrorMessage = new PXTextEditColumnFilter(grid.Row.LastErrorMessage);
                    LastOperation = new DropDownColumnFilter(grid.Row.LastOperation);
                    LastOperationTS = new DateSelectorColumnFilter(grid.Row.LastOperationTS);
                    AttemptCount = new PXNumberEditColumnFilter(grid.Row.AttemptCount);
                    BCEntity__IsActive = new CheckBoxColumnFilter(grid.Row.BCEntity__IsActive);
                }
            }
        }
        
        public class c_detailsview_lv0 : Container
        {
            
			public DateSelector ExternTS { get; }
			public Label ExternTSLabel { get; }
			public DateSelector LastOperationTS { get; }
			public Label LastOperationTSLabel { get; }
			public DateSelector LocalTS { get; }
			public Label LocalTSLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_detailsview_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ExternTS = new DateSelector("ctl00_phG_grid_lv0_CstPXDateTimeEdit8", "Last Externally  Modified", locator, null);
                ExternTSLabel = new Label(ExternTS);
                ExternTS.DataField = "ExternTS";
                LastOperationTS = new DateSelector("ctl00_phG_grid_lv0_CstPXDateTimeEdit9", "Last Attempt", locator, null);
                LastOperationTSLabel = new Label(LastOperationTS);
                LastOperationTS.DataField = "LastOperationTS";
                LocalTS = new DateSelector("ctl00_phG_grid_lv0_CstPXDateTimeEdit10", "Last Locally Modified", locator, null);
                LocalTSLabel = new Label(LocalTS);
                LocalTS.DataField = "LocalTS";
                Es = new Selector("ctl00_phG_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "DetailsView";
            }
        }
        
        public class c_statuseditpanel_cstformview17 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown ConnectorType { get; }
			public Label ConnectorTypeLabel { get; }
			public Selector BindingID { get; }
			public Label BindingIDLabel { get; }
			public DropDown EntityType { get; }
			public Label EntityTypeLabel { get; }
			public Selector LocalID { get; }
			public Label LocalIDLabel { get; }
			public PXTextEdit ExternID { get; }
			public Label ExternIDLabel { get; }
			public CheckBox NeedSync { get; }
			public Label NeedSyncLabel { get; }
            
            public c_statuseditpanel_cstformview17(string locator, string name) : 
                    base(locator, name)
            {
                ConnectorType = new DropDown("ctl00_phG_CstSmartPanel16_CstFormView17_CstPXDropDown20", "Connector", locator, null);
                ConnectorTypeLabel = new Label(ConnectorType);
                ConnectorType.DataField = "ConnectorType";
                ConnectorType.Items.Add("BCC", "BigCommerce");
                ConnectorType.Items.Add("SPC", "Shopify");
                BindingID = new Selector("ctl00_phG_CstSmartPanel16_CstFormView17_CstPXSelector19", "Store", locator, null);
                BindingIDLabel = new Label(BindingID);
                BindingID.DataField = "BindingID";
                EntityType = new DropDown("ctl00_phG_CstSmartPanel16_CstFormView17_CstPXDropDown21", "Entity", locator, null);
                EntityTypeLabel = new Label(EntityType);
                EntityType.DataField = "EntityType";
                EntityType.Items.Add("CU", "Customer");
                EntityType.Items.Add("IN", "Stock Item");
                EntityType.Items.Add("NS", "Non-Stock Item");
                EntityType.Items.Add("VP", "Template Item");
                EntityType.Items.Add("SO", "Sales Order");
                EntityType.Items.Add("PY", "Payment");
                EntityType.Items.Add("SH", "Shipment");
                LocalID = new Selector("ctl00_phG_CstSmartPanel16_CstFormView17_CstPXNumberEdit23", "Local ID", locator, null);
                LocalIDLabel = new Label(LocalID);
                LocalID.DataField = "LocalID";
                ExternID = new PXTextEdit("ctl00_phG_CstSmartPanel16_CstFormView17_CstPXTextEdit22", "External ID", locator, null);
                ExternIDLabel = new Label(ExternID);
                ExternID.DataField = "ExternID";
                NeedSync = new CheckBox("ctl00_phG_CstSmartPanel16_CstFormView17_CstPXCheckBox24", "Need to Sync", locator, null);
                NeedSyncLabel = new Label(NeedSync);
                NeedSync.DataField = "NeedSync";
                DataMemberName = "StatusEditPanel";
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
                    Ok = new Button("ctl00_phG_CstSmartPanel16_CstFormView17_CstButton28", "OK", "ctl00_phG_CstSmartPanel16_CstFormView17");
                }
            }
        }
        
        public class c_statusdetailspanel_gridrecorddetails : Grid<c_statusdetailspanel_gridrecorddetails.c_grid_row, c_statusdetailspanel_gridrecorddetails.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_statusdetailspanel_gridrecorddetails(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXDetailsPanel_gridRecordDetails");
                DataMemberName = "StatusDetailsPanel";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PXDetailsPanel_gridRecordDetails_fe_gf", "FilterForm");
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_at_tlb div[data-cmd=\'AdjustColumn" +
                            "s\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXDetailsPanel_gridRecordDetails_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_PXDetailsPanel_CstButton28", "OK", "ctl00_phG_PXDetailsPanel_gridRecordDetails");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit LocalID { get; }
			public PXTextEdit ExternID { get; }
			public DropDown EntityType { get; }
			public PXNumberEdit DetailID { get; }
                
                public c_grid_row(c_statusdetailspanel_gridrecorddetails grid) : 
                        base(grid)
                {
                    LocalID = new PXTextEdit("ctl00_phG_PXDetailsPanel_gridRecordDetails_ei", "Local ID", grid.Locator, "LocalID");
                    LocalID.DataField = "LocalID";
                    ExternID = new PXTextEdit("ctl00_phG_PXDetailsPanel_gridRecordDetails_ei", "External ID", grid.Locator, "ExternID");
                    ExternID.DataField = "ExternID";
                    EntityType = new DropDown("_ctl00_phG_PXDetailsPanel_gridRecordDetails_lv0_ec", "Entity Type", grid.Locator, "EntityType");
                    EntityType.DataField = "EntityType";
                    EntityType.Items.Add("PC", "Customer Price Class");
                    EntityType.Items.Add("CU", "Customer");
                    EntityType.Items.Add("AD", "Customer Location");
                    EntityType.Items.Add("SC", "Sales Category");
                    EntityType.Items.Add("IN", "Stock Item");
                    EntityType.Items.Add("PV", "Product Video");
                    EntityType.Items.Add("NS", "Non-Stock Item");
                    EntityType.Items.Add("VP", "Template Item");
                    EntityType.Items.Add("PO", "Product Option");
                    EntityType.Items.Add("PU", "Product Option Value");
                    EntityType.Items.Add("VR", "Variant");
                    EntityType.Items.Add("SP", "Base Sales Price");
                    EntityType.Items.Add("PL", "Price List");
                    EntityType.Items.Add("PI", "Product Image");
                    EntityType.Items.Add("PA", "Product Availability");
                    EntityType.Items.Add("SO", "Sales Order");
                    EntityType.Items.Add("OL", "Sales Order Line");
                    EntityType.Items.Add("OA", "Sales Order Address");
                    EntityType.Items.Add("PY", "Payment");
                    EntityType.Items.Add("SH", "Shipment");
                    EntityType.Items.Add("SL", "Shipment Line");
                    EntityType.Items.Add("BL", "Shipment Line Box");
                    EntityType.Items.Add("OR", "Refunds");
                    EntityType.Items.Add("CR", "Customer Refund Order");
                    DetailID = new PXNumberEdit("ctl00_phG_PXDetailsPanel_gridRecordDetails_en", "Detail ID", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter LocalID { get; }
				public PXTextEditColumnFilter ExternID { get; }
				public DropDownColumnFilter EntityType { get; }
				public PXNumberEditColumnFilter DetailID { get; }
                
                public c_grid_header(c_statusdetailspanel_gridrecorddetails grid) : 
                        base(grid)
                {
                    LocalID = new PXTextEditColumnFilter(grid.Row.LocalID);
                    ExternID = new PXTextEditColumnFilter(grid.Row.ExternID);
                    EntityType = new DropDownColumnFilter(grid.Row.EntityType);
                    DetailID = new PXNumberEditColumnFilter(grid.Row.DetailID);
                }
            }
        }
        
        public class c_statusdetailspanel_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Ec { get; }
            
            public c_statusdetailspanel_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ec = new DropDown("ctl00_phG_PXDetailsPanel_gridRecordDetails_lv0_ec", "Ec", locator, null);
                DataMemberName = "StatusDetailsPanel";
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
                    Ok = new Button("ctl00_phG_PXDetailsPanel_CstButton28", "OK", "ctl00_phG_PXDetailsPanel_gridRecordDetails_lv0");
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
