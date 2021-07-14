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
    
    
    public class BC501500_BCProcessData : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_processfilter_form ProcessFilter_form { get; } = new c_processfilter_form("ctl00_phF_form", "ProcessFilter_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_processingview_griddetails ProcessingView_gridDetails { get; } = new c_processingview_griddetails("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails", "ProcessingView_gridDetails");
        protected c_statuses_grid Statuses_grid { get; } = new c_statuses_grid("ctl00_phG_grid", "Statuses_grid");
        protected c_statuses_lv0 Statuses_lv0 { get; } = new c_statuses_lv0("ctl00_phG_grid_lv0", "Statuses_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_processing Processing { get; } = new c_processing("ctl00_usrCaption_ProcessingDialogs_PanelProgress", "Processing");
        
        public BC501500_BCProcessData()
        {
            ScreenId = "BC501500";
            ScreenUrl = "/Pages/BC/BC501500.aspx";
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
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Process()
        {
            ToolBar.Process.Click();
        }
        
        public virtual void Process(bool status, string message = null)
        {
            ToolBar.Process.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Process.Click();
        }
        
        public virtual void ProcessAll()
        {
            ToolBar.ProcessAll.Click();
        }
        
        public virtual void ProcessAll(bool status, string message = null)
        {
            ToolBar.ProcessAll.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ProcessAll.Click();
        }
        
        public virtual void ScheduleAddHidden()
        {
            ToolBar.ScheduleAddHidden.Click();
        }
        
        public virtual void ScheduleViewHidden()
        {
            ToolBar.ScheduleViewHidden.Click();
        }
        
        public virtual void ScheduleHistoryHidden()
        {
            ToolBar.ScheduleHistoryHidden.Click();
        }
        
        public virtual void Schedules()
        {
            ToolBar.Schedules.Click();
        }
        
        public virtual void ScheduleAdd()
        {
            ToolBar.ScheduleAdd.Click();
        }
        
        public virtual void ScheduleView()
        {
            ToolBar.ScheduleView.Click();
        }
        
        public virtual void ScheduleHistory()
        {
            ToolBar.ScheduleHistory.Click();
        }
        
        public virtual void Skip()
        {
            ToolBar.Skip.Click();
        }
        
        public virtual void SetSynced()
        {
            ToolBar.SetSynced.Click();
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
			public ToolBarButton Cancel { get; }
			public ToolBarButton Process { get; }
			public ToolBarButton ProcessAll { get; }
			public ToolBarButton ScheduleAddHidden { get; }
			public ToolBarButton ScheduleViewHidden { get; }
			public ToolBarButton ScheduleHistoryHidden { get; }
			public ToolBarButton Schedules { get; }
			public ToolBarButton ScheduleAdd { get; }
			public ToolBarButton ScheduleView { get; }
			public ToolBarButton ScheduleHistory { get; }
			public ToolBarButton Skip { get; }
			public ToolBarButton SetSynced { get; }
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
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Process = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Process\']", "Process", locator, null);
                Process.WaitAction = Wait.WaitForLongOperationToComplete;
                ProcessAll = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ProcessAll\']", "Process All", locator, null);
                ProcessAll.WaitAction = Wait.WaitForLongOperationToComplete;
                ScheduleAddHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'_ScheduleAdd_\']", "Add", locator, null);
                ScheduleViewHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'_ScheduleView_\']", "View", locator, null);
                ScheduleHistoryHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'_ScheduleHistory_\']", "History", locator, null);
                Schedules = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div.toolsBtn[tooltip=\'Schedules\']", "Schedules", locator, null);
                ScheduleAdd = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleAdd_\']", "Add", locator, Schedules);
                ScheduleView = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleView_\']", "View", locator, Schedules);
                ScheduleHistory = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleHistory_\']", "History", locator, Schedules);
                Skip = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'skip\']", "Skip", locator, null);
                SetSynced = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'setSynced\']", "Set Synced", locator, null);
                Adjust = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                Export = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                Filter = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_processfilter_form : Container
        {
            
			public Selector BindingID { get; }
			public Label BindingIDLabel { get; }
			public DropDown EntityType { get; }
			public Label EntityTypeLabel { get; }
            
            public c_processfilter_form(string locator, string name) : 
                    base(locator, name)
            {
                BindingID = new Selector("ctl00_phF_form_CstPXSelector1", "Store", locator, null);
                BindingIDLabel = new Label(BindingID);
                BindingID.DataField = "BindingID";
                EntityType = new DropDown("ctl00_phF_form_CstPXDropDown7", "Entity", locator, null);
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
                DataMemberName = "ProcessFilter";
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
        
        public class c_processingview_griddetails : Grid<c_processingview_griddetails.c_grid_row, c_processingview_griddetails.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_processingview_griddetails(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails");
                DataMemberName = "ProcessingView";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_fe_gf", "FilterForm");
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
            
            public virtual void CancelProcessing()
            {
                Buttons.CancelProcessing.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_at_tlb div[data" +
                            "-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_at_tlb div[data" +
                            "-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_at_tlb div[data" +
                            "-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_at_tlb div[data" +
                            "-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ab_tlb div[data" +
                            "-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ab_tlb div[data" +
                            "-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ab_tlb div[data" +
                            "-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ab_tlb div[data" +
                            "-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ab_tlb div[data" +
                            "-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CancelProcessing { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    CancelProcessing = new Button("ctl00_usrCaption_ProcessingDialogs_PanelProgress_BtnCancelProcessing", "Cancel Processing", "ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails");
                    Close = new Button("ctl00_usrCaption_ProcessingDialogs_PanelProgress_BtnDone", "Close", "ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit ProcessingStatus { get; }
			public PXTextEdit ProcessingMessage { get; }
			public DropDown ConnectorType { get; }
			public Selector BindingID { get; }
			public DropDown EntityType { get; }
			public DropDown BCEntity__PrimarySystem { get; }
			public DropDown BCEntity__Direction { get; }
			public PXTextEdit Source { get; }
			public PXTextEdit ExternID { get; }
			public DropDown Status { get; }
			public PXTextEdit LastErrorMessage { get; }
			public DropDown LastOperation { get; }
			public DateSelector LocalTS { get; }
			public DateSelector ExternTS { get; }
			public Selector SyncID { get; }
			public DateSelector LastOperationTS { get; }
                
                public c_grid_row(c_processingview_griddetails grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ProcessingStatus = new PXTextEdit("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ei", "Status", grid.Locator, "ProcessingStatus");
                    ProcessingStatus.DataField = "ProcessingStatus";
                    ProcessingMessage = new PXTextEdit("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ei", "Message", grid.Locator, "ProcessingMessage");
                    ProcessingMessage.DataField = "ProcessingMessage";
                    ConnectorType = new DropDown("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_ec", "Connector", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    ConnectorType.Items.Add("BCC", "BigCommerce");
                    ConnectorType.Items.Add("SPC", "Shopify");
                    BindingID = new Selector("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_es", "Store", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
                    EntityType = new DropDown("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_ec", "Entity", grid.Locator, "EntityType");
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
                    BCEntity__PrimarySystem = new DropDown("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_ec", "Primary System", grid.Locator, "BCEntity__PrimarySystem");
                    BCEntity__PrimarySystem.DataField = "BCEntity__PrimarySystem";
                    BCEntity__PrimarySystem.Items.Add("L", "Local");
                    BCEntity__PrimarySystem.Items.Add("E", "External");
                    BCEntity__Direction = new DropDown("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_ec", "Sync Direction", grid.Locator, "BCEntity__Direction");
                    BCEntity__Direction.DataField = "BCEntity__Direction";
                    BCEntity__Direction.Items.Add("B", "Bidirectional");
                    BCEntity__Direction.Items.Add("I", "Import");
                    BCEntity__Direction.Items.Add("E", "Export");
                    Source = new PXTextEdit("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ei", "Local ID", grid.Locator, "Source");
                    Source.DataField = "Source";
                    ExternID = new PXTextEdit("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ei", "External ID", grid.Locator, "ExternID");
                    ExternID.DataField = "ExternID";
                    Status = new DropDown("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("F", "Failed");
                    Status.Items.Add("P", "Pending");
                    Status.Items.Add("D", "Synchronized");
                    Status.Items.Add("A", "Aborted");
                    Status.Items.Add("S", "Skipped");
                    Status.Items.Add("L", "Deleted");
                    Status.Items.Add("N", "Invalid");
                    Status.Items.Add("O", "Filtered");
                    LastErrorMessage = new PXTextEdit("ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_ei", "Last Error", grid.Locator, "LastErrorMessage");
                    LastErrorMessage.DataField = "LastErrorMessage";
                    LastOperation = new DropDown("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_ec", "Last Operation", grid.Locator, "LastOperation");
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
                    LocalTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit6", "Last Locally Modified", grid.Locator, "LocalTS");
                    LocalTS.DataField = "LocalTS";
                    ExternTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit4", "Last Externally  Modified", grid.Locator, "ExternTS");
                    ExternTS.DataField = "ExternTS";
                    SyncID = new Selector("_ctl00_usrCaption_ProcessingDialogs_PanelProgress_gridDetails_lv0_es", "Sync Record ID", grid.Locator, "SyncID");
                    SyncID.DataField = "SyncID";
                    LastOperationTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit5", "Last Attempt", grid.Locator, "LastOperationTS");
                    LastOperationTS.DataField = "LastOperationTS";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter ProcessingStatus { get; }
				public PXTextEditColumnFilter ProcessingMessage { get; }
				public DropDownColumnFilter ConnectorType { get; }
				public SelectorColumnFilter BindingID { get; }
				public DropDownColumnFilter EntityType { get; }
				public DropDownColumnFilter BCEntity__PrimarySystem { get; }
				public DropDownColumnFilter BCEntity__Direction { get; }
				public PXTextEditColumnFilter Source { get; }
				public PXTextEditColumnFilter ExternID { get; }
				public DropDownColumnFilter Status { get; }
				public PXTextEditColumnFilter LastErrorMessage { get; }
				public DropDownColumnFilter LastOperation { get; }
				public DateSelectorColumnFilter LocalTS { get; }
				public DateSelectorColumnFilter ExternTS { get; }
				public SelectorColumnFilter SyncID { get; }
				public DateSelectorColumnFilter LastOperationTS { get; }
                
                public c_grid_header(c_processingview_griddetails grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ProcessingStatus = new PXTextEditColumnFilter(grid.Row.ProcessingStatus);
                    ProcessingMessage = new PXTextEditColumnFilter(grid.Row.ProcessingMessage);
                    ConnectorType = new DropDownColumnFilter(grid.Row.ConnectorType);
                    BindingID = new SelectorColumnFilter(grid.Row.BindingID);
                    EntityType = new DropDownColumnFilter(grid.Row.EntityType);
                    BCEntity__PrimarySystem = new DropDownColumnFilter(grid.Row.BCEntity__PrimarySystem);
                    BCEntity__Direction = new DropDownColumnFilter(grid.Row.BCEntity__Direction);
                    Source = new PXTextEditColumnFilter(grid.Row.Source);
                    ExternID = new PXTextEditColumnFilter(grid.Row.ExternID);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    LastErrorMessage = new PXTextEditColumnFilter(grid.Row.LastErrorMessage);
                    LastOperation = new DropDownColumnFilter(grid.Row.LastOperation);
                    LocalTS = new DateSelectorColumnFilter(grid.Row.LocalTS);
                    ExternTS = new DateSelectorColumnFilter(grid.Row.ExternTS);
                    SyncID = new SelectorColumnFilter(grid.Row.SyncID);
                    LastOperationTS = new DateSelectorColumnFilter(grid.Row.LastOperationTS);
                }
            }
        }
        
        public class c_statuses_grid : Grid<c_statuses_grid.c_grid_row, c_statuses_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_statuses_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_grid");
                DataMemberName = "Statuses";
                FilterForm = new c_grid_filter("ctl00_phG_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void AllRecords()
            {
                ToolBar.AllRecords.Click();
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
			public DropDown ConnectorType { get; }
			public Selector BindingID { get; }
			public DropDown EntityType { get; }
			public DropDown BCEntity__PrimarySystem { get; }
			public DropDown BCEntity__Direction { get; }
			public PXTextEdit Source { get; }
			public PXTextEdit ExternID { get; }
			public DropDown Status { get; }
			public PXTextEdit LastErrorMessage { get; }
			public DropDown LastOperation { get; }
			public DateSelector LocalTS { get; }
			public DateSelector ExternTS { get; }
			public Selector SyncID { get; }
			public DateSelector LastOperationTS { get; }
                
                public c_grid_row(c_statuses_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_grid_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    ConnectorType = new DropDown("_ctl00_phG_grid_lv0_ec", "Connector", grid.Locator, "ConnectorType");
                    ConnectorType.DataField = "ConnectorType";
                    ConnectorType.Items.Add("BCC", "BigCommerce");
                    ConnectorType.Items.Add("SPC", "Shopify");
                    BindingID = new Selector("_ctl00_phG_grid_lv0_es", "Store", grid.Locator, "BindingID");
                    BindingID.DataField = "BindingID";
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
                    BCEntity__PrimarySystem = new DropDown("_ctl00_phG_grid_lv0_ec", "Primary System", grid.Locator, "BCEntity__PrimarySystem");
                    BCEntity__PrimarySystem.DataField = "BCEntity__PrimarySystem";
                    BCEntity__PrimarySystem.Items.Add("L", "Local");
                    BCEntity__PrimarySystem.Items.Add("E", "External");
                    BCEntity__Direction = new DropDown("_ctl00_phG_grid_lv0_ec", "Sync Direction", grid.Locator, "BCEntity__Direction");
                    BCEntity__Direction.DataField = "BCEntity__Direction";
                    BCEntity__Direction.Items.Add("B", "Bidirectional");
                    BCEntity__Direction.Items.Add("I", "Import");
                    BCEntity__Direction.Items.Add("E", "Export");
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
                    LocalTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit6", "Last Locally Modified", grid.Locator, "LocalTS");
                    LocalTS.DataField = "LocalTS";
                    ExternTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit4", "Last Externally  Modified", grid.Locator, "ExternTS");
                    ExternTS.DataField = "ExternTS";
                    SyncID = new Selector("_ctl00_phG_grid_lv0_es", "Sync Record ID", grid.Locator, "SyncID");
                    SyncID.DataField = "SyncID";
                    LastOperationTS = new DateSelector("_ctl00_phG_grid_lv0_CstPXDateTimeEdit5", "Last Attempt", grid.Locator, "LastOperationTS");
                    LastOperationTS.DataField = "LastOperationTS";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter ConnectorType { get; }
				public SelectorColumnFilter BindingID { get; }
				public DropDownColumnFilter EntityType { get; }
				public DropDownColumnFilter BCEntity__PrimarySystem { get; }
				public DropDownColumnFilter BCEntity__Direction { get; }
				public PXTextEditColumnFilter Source { get; }
				public PXTextEditColumnFilter ExternID { get; }
				public DropDownColumnFilter Status { get; }
				public PXTextEditColumnFilter LastErrorMessage { get; }
				public DropDownColumnFilter LastOperation { get; }
				public DateSelectorColumnFilter LocalTS { get; }
				public DateSelectorColumnFilter ExternTS { get; }
				public SelectorColumnFilter SyncID { get; }
				public DateSelectorColumnFilter LastOperationTS { get; }
                
                public c_grid_header(c_statuses_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    ConnectorType = new DropDownColumnFilter(grid.Row.ConnectorType);
                    BindingID = new SelectorColumnFilter(grid.Row.BindingID);
                    EntityType = new DropDownColumnFilter(grid.Row.EntityType);
                    BCEntity__PrimarySystem = new DropDownColumnFilter(grid.Row.BCEntity__PrimarySystem);
                    BCEntity__Direction = new DropDownColumnFilter(grid.Row.BCEntity__Direction);
                    Source = new PXTextEditColumnFilter(grid.Row.Source);
                    ExternID = new PXTextEditColumnFilter(grid.Row.ExternID);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    LastErrorMessage = new PXTextEditColumnFilter(grid.Row.LastErrorMessage);
                    LastOperation = new DropDownColumnFilter(grid.Row.LastOperation);
                    LocalTS = new DateSelectorColumnFilter(grid.Row.LocalTS);
                    ExternTS = new DateSelectorColumnFilter(grid.Row.ExternTS);
                    SyncID = new SelectorColumnFilter(grid.Row.SyncID);
                    LastOperationTS = new DateSelectorColumnFilter(grid.Row.LastOperationTS);
                }
            }
        }
        
        public class c_statuses_lv0 : Container
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
            
            public c_statuses_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ExternTS = new DateSelector("ctl00_phG_grid_lv0_CstPXDateTimeEdit4", "Last Externally  Modified", locator, null);
                ExternTSLabel = new Label(ExternTS);
                ExternTS.DataField = "ExternTS";
                LastOperationTS = new DateSelector("ctl00_phG_grid_lv0_CstPXDateTimeEdit5", "Last Attempt", locator, null);
                LastOperationTSLabel = new Label(LastOperationTS);
                LastOperationTS.DataField = "LastOperationTS";
                LocalTS = new DateSelector("ctl00_phG_grid_lv0_CstPXDateTimeEdit6", "Last Locally Modified", locator, null);
                LocalTSLabel = new Label(LocalTS);
                LocalTS.DataField = "LocalTS";
                Es = new Selector("ctl00_phG_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Statuses";
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
        
        public class c_processing : Container
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_processing(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ViewProcessingResults";
                ToolBar = new PxToolBar("ctl00_usrCaption_ProcessingDialogs_PanelProgress");
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Processed()
            {
                ToolBar.Processed.Click();
            }
            
            public virtual void Errors()
            {
                ToolBar.Errors.Click();
            }
            
            public virtual void Warnings()
            {
                ToolBar.Warnings.Click();
            }
            
            public virtual void Remains()
            {
                ToolBar.Remains.Click();
            }
            
            public virtual void Total()
            {
                ToolBar.Total.Click();
            }
            
            public virtual void CancelProcessing()
            {
                Buttons.CancelProcessing.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButton Processed { get; }
			public ToolBarButton Errors { get; }
			public ToolBarButton Warnings { get; }
			public ToolBarButton Remains { get; }
			public ToolBarButton Total { get; }
                
                public PxToolBar(string locator)
                {
                    Processed = new ToolBarButton("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_ToolbarProcessing div[data-" +
                            "cmd=\'Processed\']", "Processed", locator, null);
                    Errors = new ToolBarButton("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_ToolbarProcessing div[data-" +
                            "cmd=\'Errors\']", "Errors", locator, null);
                    Warnings = new ToolBarButton("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_ToolbarProcessing div[data-" +
                            "cmd=\'Warnings\']", "Warnings", locator, null);
                    Remains = new ToolBarButton("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_ToolbarProcessing div[data-" +
                            "cmd=\'Remains\']", "Remains", locator, null);
                    Total = new ToolBarButton("css=#ctl00_usrCaption_ProcessingDialogs_PanelProgress_ToolbarProcessing div[data-" +
                            "cmd=\'Total\']", "Total", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CancelProcessing { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    CancelProcessing = new Button("ctl00_usrCaption_ProcessingDialogs_PanelProgress_BtnCancelProcessing", "Cancel Processing", "ctl00_usrCaption_ProcessingDialogs_PanelProgress");
                    Close = new Button("ctl00_usrCaption_ProcessingDialogs_PanelProgress_BtnDone", "Close", "ctl00_usrCaption_ProcessingDialogs_PanelProgress");
                }
            }
        }
    }
}
