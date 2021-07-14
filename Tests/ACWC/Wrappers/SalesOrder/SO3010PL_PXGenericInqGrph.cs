using System;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.QuickSearch;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.Pivot;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;

namespace ACSC.Tests.Wrappers.SalesOrder
{
    
    
    public class SO3010PL_PXGenericInqGrph : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_filter_form Filter_form { get; } = new c_filter_form("ctl00_phF_form", "Filter_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_results_grid Results_grid { get; } = new c_results_grid("ctl00_phG_grid", "Results_grid");
        protected c_results_lv0 Results_lv0 { get; } = new c_results_lv0("ctl00_phG_grid_lv0", "Results_lv0");
        protected c_addnewkeys_grdkeys AddNewKeys_grdKeys { get; } = new c_addnewkeys_grdkeys("ctl00_phG_dlgEnterKeys_grdKeys", "AddNewKeys_grdKeys");
        protected c_addnewkeys_lv0 AddNewKeys_lv0 { get; } = new c_addnewkeys_lv0("ctl00_phG_dlgEnterKeys_grdKeys_lv0", "AddNewKeys_lv0");
        protected c_fields_grdfields Fields_grdFields { get; } = new c_fields_grdfields("ctl00_phG_dlgUpdateParams_grdFields", "Fields_grdFields");
        protected c_fields_lv0 Fields_lv0 { get; } = new c_fields_lv0("ctl00_phG_dlgUpdateParams_grdFields_lv0", "Fields_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_pivot_grid Pivot_Grid { get; } = new c_pivot_grid("ctl00_phG_grid_pivotT", "Pivot_Grid");
        
        public SO3010PL_PXGenericInqGrph()
        {
            ScreenId = "SO3010PL";
            ScreenUrl = "/GenericInquiry/GenericInquiry.aspx?id=9f714d02-272b-45b9-bc1b-6deff3d1b7d3";
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
        
        public virtual void Insert()
        {
            ToolBar.Insert.Click();
        }
        
        public virtual void EditDetail()
        {
            ToolBar.EditDetail.Click();
        }
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void Adjust()
        {
            ToolBar.Adjust.Click();
        }
        
        public virtual void Export()
        {
            ToolBar.Export.Click();
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
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton Refresh { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton EditDetail { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton Adjust { get; }
			public ToolBarButton Export { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                Refresh = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'insert\']", "New Record", locator, null);
                EditDetail = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'editDetail\']", "Edit Record", locator, null);
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'button\']", "Actions", locator, null);
                Adjust = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                Export = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_filter_form : Container
        {
            
            public c_filter_form(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "Filter";
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
        
        public class c_results_grid : Grid<c_results_grid.c_grid_row, c_results_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_results_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_grid");
                DataMemberName = "Results";
                QuickSearch = new QuickSearch("ctl00_phG_grid_tf_fb", "QuickSearch", locator, null);
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
            
            public virtual void EditPivot()
            {
                ToolBar.EditPivot.Click();
            }
            
            public virtual void Filter()
            {
                ToolBar.Filter.Click();
            }
            
            public virtual void FilterSave()
            {
                ToolBar.FilterSave.Click();
            }
            
            public virtual void More()
            {
                ToolBar.More.Click();
            }
            
            public virtual void FilterSave1()
            {
                ToolBar.FilterSave1.Click();
            }
            
            public virtual void FilterSavePivot()
            {
                ToolBar.FilterSavePivot.Click();
            }
            
            public virtual void FilterRemove()
            {
                ToolBar.FilterRemove.Click();
            }
            
            public virtual void CollapseAll()
            {
                ToolBar.CollapseAll.Click();
            }
            
            public virtual void ExpandAll()
            {
                ToolBar.ExpandAll.Click();
            }
            
            public virtual void YPageFirst()
            {
                ToolBar.YPageFirst.Click();
            }
            
            public virtual void YPagePrev()
            {
                ToolBar.YPagePrev.Click();
            }
            
            public virtual void YPageNext()
            {
                ToolBar.YPageNext.Click();
            }
            
            public virtual void YPageLast()
            {
                ToolBar.YPageLast.Click();
            }
            
            public virtual void XPageFirst()
            {
                ToolBar.XPageFirst.Click();
            }
            
            public virtual void XPagePrev()
            {
                ToolBar.XPagePrev.Click();
            }
            
            public virtual void XPageNext()
            {
                ToolBar.XPageNext.Click();
            }
            
            public virtual void XPageLast()
            {
                ToolBar.XPageLast.Click();
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
			public ToolBarButtonGrid EditPivot { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid FilterSave { get; }
			public ToolBarButtonGrid More { get; }
			public ToolBarButtonGrid FilterSave1 { get; }
			public ToolBarButtonGrid FilterSavePivot { get; }
			public ToolBarButtonGrid FilterRemove { get; }
			public ToolBarButtonGrid CollapseAll { get; }
			public ToolBarButtonGrid ExpandAll { get; }
			public ToolBarButtonGrid YPageFirst { get; }
			public ToolBarButtonGrid YPagePrev { get; }
			public ToolBarButtonGrid YPageNext { get; }
			public ToolBarButtonGrid YPageLast { get; }
			public ToolBarButtonGrid XPageFirst { get; }
			public ToolBarButtonGrid XPagePrev { get; }
			public ToolBarButtonGrid XPageNext { get; }
			public ToolBarButtonGrid XPageLast { get; }
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
                    EditPivot = new ToolBarButtonGrid("css=#ctl00_phG_grid_tf div[data-cmd=\'EditPivot\']", "Edit pivot table", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_grid_tf div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    FilterSave = new ToolBarButtonGrid("css=#ctl00_phG_grid_tf div[data-cmd=\'FilterSave\']", "Save", locator, null);
                    More = new ToolBarButtonGrid("css=#ctl00_phG_grid_tf div[data-cmd=\'more\']", "...", locator, null);
                    FilterSave1 = new ToolBarButtonGrid("css=div#ctl00_phG_grid_tf_menumore li[data-cmd=\'FilterSave\']", "Save As", locator, More);
                    FilterSavePivot = new ToolBarButtonGrid("css=div#ctl00_phG_grid_tf_menumore li[data-cmd=\'FilterSavePivot\']", "Save As Pivot", locator, More);
                    FilterRemove = new ToolBarButtonGrid("css=div#ctl00_phG_grid_tf_menumore li[data-cmd=\'FilterRemove\']", "Remove", locator, More);
                    CollapseAll = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'CollapseAll\']", "Collapse All", locator, null);
                    ExpandAll = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'ExpandAll\']", "Expand All", locator, null);
                    YPageFirst = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPageFirst\']", "YPageFirst", locator, null);
                    YPagePrev = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPagePrev\']", "YPagePrev", locator, null);
                    YPageNext = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPageNext\']", "YPageNext", locator, null);
                    YPageLast = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPageLast\']", "YPageLast", locator, null);
                    XPageFirst = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPageFirst\']", "XPageFirst", locator, null);
                    XPagePrev = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPagePrev\']", "XPagePrev", locator, null);
                    XPageNext = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPageNext\']", "XPageNext", locator, null);
                    XPageLast = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPageLast\']", "XPageLast", locator, null);
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
			public PXNumberEdit Row { get; }
			public Selector SOOrder_orderType { get; }
			public DropDown SOOrder_behavior { get; }
			public Selector SOOrder_orderNbr { get; }
			public DropDown SOOrder_status { get; }
			public DateSelector SOOrder_orderDate { get; }
			public DateSelector SOOrder_requestDate { get; }
			public DateSelector SOOrder_shipDate { get; }
			public Selector SOOrder_finPeriodID { get; }
			public Selector SOOrder_customerID { get; }
			public Selector SOOrder_customerID_description { get; }
			public PXTextEdit SOOrder_orderDesc { get; }
			public PXTextEdit SOOrder_customerOrderNbr { get; }
			public PXTextEdit SOOrder_extRefNbr { get; }
			public Selector SOOrder_projectID { get; }
			public Selector SOOrder_salesPersonID { get; }
			public PXNumberEdit SOOrder_orderQty { get; }
			public PXNumberEdit SOOrder_curyOrderTotal { get; }
			public PXNumberEdit SOOrder_curyTaxTotal { get; }
			public Selector SOOrder_curyID { get; }
			public Selector SOOrder_ownerID { get; }
			public Selector SOOrder_branchID { get; }
			public Selector SOOrder_branchID_description { get; }
			public Selector SOOrder_createdByID { get; }
			public DateSelector SOOrder_createdDateTime { get; }
			public Selector SOOrder_lastModifiedByID { get; }
			public DateSelector SOOrder_lastModifiedDateTime { get; }
			public PXTextEdit PMProject_BaseType { get; }
			public Selector PMProject_ContractCD { get; }
			public Selector BAccountR_AcctCD { get; }
			public Selector Customer_AcctCD { get; }
			public Selector Branch_BranchCD { get; }
                
                public c_grid_row(c_results_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_grid_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    Row = new PXNumberEdit("ctl00_phG_grid_en", "Row Number", grid.Locator, "Row");
                    Row.DataField = "Row";
                    SOOrder_orderType = new Selector("_ctl00_phG_grid_lv0_es", "Order Type", grid.Locator, "SOOrder_orderType");
                    SOOrder_orderType.DataField = "SOOrder_orderType";
                    SOOrder_behavior = new DropDown("_ctl00_phG_grid_lv0_ec", "Behavior", grid.Locator, "SOOrder_behavior");
                    SOOrder_behavior.DataField = "SOOrder_behavior";
                    SOOrder_behavior.Items.Add("SO", "Sales Order");
                    SOOrder_behavior.Items.Add("IN", "Invoice");
                    SOOrder_behavior.Items.Add("QT", "Quote");
                    SOOrder_behavior.Items.Add("CM", "Credit Memo");
                    SOOrder_behavior.Items.Add("RM", "RMA Order");
                    SOOrder_orderNbr = new Selector("_ctl00_phG_grid_lv0_es", "Order Nbr.", grid.Locator, "SOOrder_orderNbr");
                    SOOrder_orderNbr.DataField = "SOOrder_orderNbr";
                    SOOrder_status = new DropDown("_ctl00_phG_grid_lv0_ec", "Status", grid.Locator, "SOOrder_status");
                    SOOrder_status.DataField = "SOOrder_status";
                    SOOrder_status.Items.Add("N", "Open");
                    SOOrder_status.Items.Add("H", "On Hold");
                    SOOrder_status.Items.Add("P", "Pending Approval");
                    SOOrder_status.Items.Add("V", "Rejected");
                    SOOrder_status.Items.Add("R", "Credit Hold");
                    SOOrder_status.Items.Add("C", "Completed");
                    SOOrder_status.Items.Add("L", "Canceled");
                    SOOrder_status.Items.Add("B", "Back Order");
                    SOOrder_status.Items.Add("S", "Shipping");
                    SOOrder_status.Items.Add("I", "Invoiced");
                    SOOrder_orderDate = new DateSelector("_ctl00_phG_grid_lv0_ed8", "Date", grid.Locator, "SOOrder_orderDate");
                    SOOrder_orderDate.DataField = "SOOrder_orderDate";
                    SOOrder_requestDate = new DateSelector("_ctl00_phG_grid_lv0_ed9", "Requested On", grid.Locator, "SOOrder_requestDate");
                    SOOrder_requestDate.DataField = "SOOrder_requestDate";
                    SOOrder_shipDate = new DateSelector("_ctl00_phG_grid_lv0_ed10", "Sched. Shipment", grid.Locator, "SOOrder_shipDate");
                    SOOrder_shipDate.DataField = "SOOrder_shipDate";
                    SOOrder_finPeriodID = new Selector("_ctl00_phG_grid_lv0_es", "Post Period", grid.Locator, "SOOrder_finPeriodID");
                    SOOrder_finPeriodID.DataField = "SOOrder_finPeriodID";
                    SOOrder_customerID = new Selector("_ctl00_phG_grid_lv0_es", "Customer", grid.Locator, "SOOrder_customerID");
                    SOOrder_customerID.DataField = "SOOrder_customerID";
                    SOOrder_customerID_description = new Selector("_ctl00_phG_grid_lv0_es", "Customer Name", grid.Locator, "SOOrder_customerID_description");
                    SOOrder_customerID_description.DataField = "SOOrder_customerID_description";
                    SOOrder_orderDesc = new PXTextEdit("ctl00_phG_grid_ei", "Description", grid.Locator, "SOOrder_orderDesc");
                    SOOrder_orderDesc.DataField = "SOOrder_orderDesc";
                    SOOrder_customerOrderNbr = new PXTextEdit("ctl00_phG_grid_ei", "Customer Order Nbr.", grid.Locator, "SOOrder_customerOrderNbr");
                    SOOrder_customerOrderNbr.DataField = "SOOrder_customerOrderNbr";
                    SOOrder_extRefNbr = new PXTextEdit("ctl00_phG_grid_ei", "Payment Ref.", grid.Locator, "SOOrder_extRefNbr");
                    SOOrder_extRefNbr.DataField = "SOOrder_extRefNbr";
                    SOOrder_projectID = new Selector("_ctl00_phG_grid_lv0_es", "Project", grid.Locator, "SOOrder_projectID");
                    SOOrder_projectID.DataField = "SOOrder_projectID";
                    SOOrder_salesPersonID = new Selector("_ctl00_phG_grid_lv0_es", "Default Salesperson", grid.Locator, "SOOrder_salesPersonID");
                    SOOrder_salesPersonID.DataField = "SOOrder_salesPersonID";
                    SOOrder_orderQty = new PXNumberEdit("ctl00_phG_grid_en", "Ordered Qty.", grid.Locator, "SOOrder_orderQty");
                    SOOrder_orderQty.DataField = "SOOrder_orderQty";
                    SOOrder_curyOrderTotal = new PXNumberEdit("ctl00_phG_grid_en", "Order Total", grid.Locator, "SOOrder_curyOrderTotal");
                    SOOrder_curyOrderTotal.DataField = "SOOrder_curyOrderTotal";
                    SOOrder_curyTaxTotal = new PXNumberEdit("ctl00_phG_grid_en", "Tax Total", grid.Locator, "SOOrder_curyTaxTotal");
                    SOOrder_curyTaxTotal.DataField = "SOOrder_curyTaxTotal";
                    SOOrder_curyID = new Selector("_ctl00_phG_grid_lv0_es", "Currency", grid.Locator, "SOOrder_curyID");
                    SOOrder_curyID.DataField = "SOOrder_curyID";
                    SOOrder_ownerID = new Selector("_ctl00_phG_grid_lv0_es", "Owner", grid.Locator, "SOOrder_ownerID");
                    SOOrder_ownerID.DataField = "SOOrder_ownerID";
                    SOOrder_branchID = new Selector("_ctl00_phG_grid_lv0_es", "Branch", grid.Locator, "SOOrder_branchID");
                    SOOrder_branchID.DataField = "SOOrder_branchID";
                    SOOrder_branchID_description = new Selector("_ctl00_phG_grid_lv0_es", "Branch Name", grid.Locator, "SOOrder_branchID_description");
                    SOOrder_branchID_description.DataField = "SOOrder_branchID_description";
                    SOOrder_createdByID = new Selector("_ctl00_phG_grid_lv0_es", "Created By", grid.Locator, "SOOrder_createdByID");
                    SOOrder_createdByID.DataField = "SOOrder_createdByID";
                    SOOrder_createdDateTime = new DateSelector("_ctl00_phG_grid_lv0_ed27", "Created On", grid.Locator, "SOOrder_createdDateTime");
                    SOOrder_createdDateTime.DataField = "SOOrder_createdDateTime";
                    SOOrder_lastModifiedByID = new Selector("_ctl00_phG_grid_lv0_es", "Last Modified By", grid.Locator, "SOOrder_lastModifiedByID");
                    SOOrder_lastModifiedByID.DataField = "SOOrder_lastModifiedByID";
                    SOOrder_lastModifiedDateTime = new DateSelector("_ctl00_phG_grid_lv0_ed29", "Last Modified On", grid.Locator, "SOOrder_lastModifiedDateTime");
                    SOOrder_lastModifiedDateTime.DataField = "SOOrder_lastModifiedDateTime";
                    PMProject_BaseType = new PXTextEdit("ctl00_phG_grid_ei", "Base Type", grid.Locator, "PMProject_BaseType");
                    PMProject_BaseType.DataField = "PMProject_BaseType";
                    PMProject_ContractCD = new Selector("_ctl00_phG_grid_lv0_es", "Project ID", grid.Locator, "PMProject_ContractCD");
                    PMProject_ContractCD.DataField = "PMProject_ContractCD";
                    BAccountR_AcctCD = new Selector("_ctl00_phG_grid_lv0_es", "Account ID", grid.Locator, "BAccountR_AcctCD");
                    BAccountR_AcctCD.DataField = "BAccountR_AcctCD";
                    Customer_AcctCD = new Selector("_ctl00_phG_grid_lv0_es", "Customer ID", grid.Locator, "Customer_AcctCD");
                    Customer_AcctCD.DataField = "Customer_AcctCD";
                    Branch_BranchCD = new Selector("_ctl00_phG_grid_lv0_es", "Branch ID", grid.Locator, "Branch_BranchCD");
                    Branch_BranchCD.DataField = "Branch_BranchCD";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter Row { get; }
				public SelectorColumnFilter SOOrder_orderType { get; }
				public DropDownColumnFilter SOOrder_behavior { get; }
				public SelectorColumnFilter SOOrder_orderNbr { get; }
				public DropDownColumnFilter SOOrder_status { get; }
				public DateSelectorColumnFilter SOOrder_orderDate { get; }
				public DateSelectorColumnFilter SOOrder_requestDate { get; }
				public DateSelectorColumnFilter SOOrder_shipDate { get; }
				public SelectorColumnFilter SOOrder_finPeriodID { get; }
				public SelectorColumnFilter SOOrder_customerID { get; }
				public SelectorColumnFilter SOOrder_customerID_description { get; }
				public PXTextEditColumnFilter SOOrder_orderDesc { get; }
				public PXTextEditColumnFilter SOOrder_customerOrderNbr { get; }
				public PXTextEditColumnFilter SOOrder_extRefNbr { get; }
				public SelectorColumnFilter SOOrder_projectID { get; }
				public SelectorColumnFilter SOOrder_salesPersonID { get; }
				public PXNumberEditColumnFilter SOOrder_orderQty { get; }
				public PXNumberEditColumnFilter SOOrder_curyOrderTotal { get; }
				public PXNumberEditColumnFilter SOOrder_curyTaxTotal { get; }
				public SelectorColumnFilter SOOrder_curyID { get; }
				public SelectorColumnFilter SOOrder_ownerID { get; }
				public SelectorColumnFilter SOOrder_branchID { get; }
				public SelectorColumnFilter SOOrder_branchID_description { get; }
				public SelectorColumnFilter SOOrder_createdByID { get; }
				public DateSelectorColumnFilter SOOrder_createdDateTime { get; }
				public SelectorColumnFilter SOOrder_lastModifiedByID { get; }
				public DateSelectorColumnFilter SOOrder_lastModifiedDateTime { get; }
				public PXTextEditColumnFilter PMProject_BaseType { get; }
				public SelectorColumnFilter PMProject_ContractCD { get; }
				public SelectorColumnFilter BAccountR_AcctCD { get; }
				public SelectorColumnFilter Customer_AcctCD { get; }
				public SelectorColumnFilter Branch_BranchCD { get; }
                
                public c_grid_header(c_results_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    Row = new PXNumberEditColumnFilter(grid.Row.Row);
                    SOOrder_orderType = new SelectorColumnFilter(grid.Row.SOOrder_orderType);
                    SOOrder_behavior = new DropDownColumnFilter(grid.Row.SOOrder_behavior);
                    SOOrder_orderNbr = new SelectorColumnFilter(grid.Row.SOOrder_orderNbr);
                    SOOrder_status = new DropDownColumnFilter(grid.Row.SOOrder_status);
                    SOOrder_orderDate = new DateSelectorColumnFilter(grid.Row.SOOrder_orderDate);
                    SOOrder_requestDate = new DateSelectorColumnFilter(grid.Row.SOOrder_requestDate);
                    SOOrder_shipDate = new DateSelectorColumnFilter(grid.Row.SOOrder_shipDate);
                    SOOrder_finPeriodID = new SelectorColumnFilter(grid.Row.SOOrder_finPeriodID);
                    SOOrder_customerID = new SelectorColumnFilter(grid.Row.SOOrder_customerID);
                    SOOrder_customerID_description = new SelectorColumnFilter(grid.Row.SOOrder_customerID_description);
                    SOOrder_orderDesc = new PXTextEditColumnFilter(grid.Row.SOOrder_orderDesc);
                    SOOrder_customerOrderNbr = new PXTextEditColumnFilter(grid.Row.SOOrder_customerOrderNbr);
                    SOOrder_extRefNbr = new PXTextEditColumnFilter(grid.Row.SOOrder_extRefNbr);
                    SOOrder_projectID = new SelectorColumnFilter(grid.Row.SOOrder_projectID);
                    SOOrder_salesPersonID = new SelectorColumnFilter(grid.Row.SOOrder_salesPersonID);
                    SOOrder_orderQty = new PXNumberEditColumnFilter(grid.Row.SOOrder_orderQty);
                    SOOrder_curyOrderTotal = new PXNumberEditColumnFilter(grid.Row.SOOrder_curyOrderTotal);
                    SOOrder_curyTaxTotal = new PXNumberEditColumnFilter(grid.Row.SOOrder_curyTaxTotal);
                    SOOrder_curyID = new SelectorColumnFilter(grid.Row.SOOrder_curyID);
                    SOOrder_ownerID = new SelectorColumnFilter(grid.Row.SOOrder_ownerID);
                    SOOrder_branchID = new SelectorColumnFilter(grid.Row.SOOrder_branchID);
                    SOOrder_branchID_description = new SelectorColumnFilter(grid.Row.SOOrder_branchID_description);
                    SOOrder_createdByID = new SelectorColumnFilter(grid.Row.SOOrder_createdByID);
                    SOOrder_createdDateTime = new DateSelectorColumnFilter(grid.Row.SOOrder_createdDateTime);
                    SOOrder_lastModifiedByID = new SelectorColumnFilter(grid.Row.SOOrder_lastModifiedByID);
                    SOOrder_lastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.SOOrder_lastModifiedDateTime);
                    PMProject_BaseType = new PXTextEditColumnFilter(grid.Row.PMProject_BaseType);
                    PMProject_ContractCD = new SelectorColumnFilter(grid.Row.PMProject_ContractCD);
                    BAccountR_AcctCD = new SelectorColumnFilter(grid.Row.BAccountR_AcctCD);
                    Customer_AcctCD = new SelectorColumnFilter(grid.Row.Customer_AcctCD);
                    Branch_BranchCD = new SelectorColumnFilter(grid.Row.Branch_BranchCD);
                }
            }
        }
        
        public class c_results_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_results_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_grid_lv0_ec", "Ec", locator, null);
                DataMemberName = "Results";
            }
        }
        
        public class c_addnewkeys_grdkeys : Grid<c_addnewkeys_grdkeys.c_grid_row, c_addnewkeys_grdkeys.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_addnewkeys_grdkeys(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_dlgEnterKeys_grdKeys");
                DataMemberName = "AddNewKeys";
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
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_dlgEnterKeys_grdKeys_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_dlgEnterKeys_grdKeys_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_dlgEnterKeys_grdKeys_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_dlgEnterKeys_grdKeys_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Cancel { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfFirst0", "First", "ctl00_phG_dlgEnterKeys_grdKeys");
                    Prev = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfPrev0", "Prev", "ctl00_phG_dlgEnterKeys_grdKeys");
                    Next = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfNext0", "Next", "ctl00_phG_dlgEnterKeys_grdKeys");
                    Last = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfLast0", "Last", "ctl00_phG_dlgEnterKeys_grdKeys");
                    Cancel = new Button("ctl00_phG_dlgEnterKeys_btnCancelAddNew", "Cancel", "ctl00_phG_dlgEnterKeys_grdKeys");
                    Finish = new Button("ctl00_phG_dlgEnterKeys_btnFinishAddNew", "Finish", "ctl00_phG_dlgEnterKeys_grdKeys");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit FieldName { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Value { get; }
                
                public c_grid_row(c_addnewkeys_grdkeys grid) : 
                        base(grid)
                {
                    FieldName = new PXTextEdit("ctl00_phG_dlgEnterKeys_grdKeys_ei", "FieldName", grid.Locator, "FieldName");
                    FieldName.DataField = "FieldName";
                    DisplayName = new PXTextEdit("ctl00_phG_dlgEnterKeys_grdKeys_ei", "Key", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Value = new PXTextEdit("ctl00_phG_dlgEnterKeys_grdKeys_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter FieldName { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Value { get; }
                
                public c_grid_header(c_addnewkeys_grdkeys grid) : 
                        base(grid)
                {
                    FieldName = new PXTextEditColumnFilter(grid.Row.FieldName);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                }
            }
        }
        
        public class c_addnewkeys_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_addnewkeys_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_dlgEnterKeys_grdKeys_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_dlgEnterKeys_grdKeys_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_dlgEnterKeys_grdKeys_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_dlgEnterKeys_grdKeys_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "AddNewKeys";
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
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Cancel { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfFirst0", "First", "ctl00_phG_dlgEnterKeys_grdKeys_lv0");
                    Prev = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfPrev0", "Prev", "ctl00_phG_dlgEnterKeys_grdKeys_lv0");
                    Next = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfNext0", "Next", "ctl00_phG_dlgEnterKeys_grdKeys_lv0");
                    Last = new Button("ctl00_phG_dlgEnterKeys_grdKeys_lfLast0", "Last", "ctl00_phG_dlgEnterKeys_grdKeys_lv0");
                    Cancel = new Button("ctl00_phG_dlgEnterKeys_btnCancelAddNew", "Cancel", "ctl00_phG_dlgEnterKeys_grdKeys_lv0");
                    Finish = new Button("ctl00_phG_dlgEnterKeys_btnFinishAddNew", "Finish", "ctl00_phG_dlgEnterKeys_grdKeys_lv0");
                }
            }
        }
        
        public class c_fields_grdfields : Grid<c_fields_grdfields.c_grid_row, c_fields_grdfields.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_fields_grdfields(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "Fields";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_dlgUpdateParams_grdFields_fe_gf", "FilterForm");
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
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Cancel { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfFirst0", "First", "ctl00_phG_dlgUpdateParams_grdFields");
                    Prev = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfPrev0", "Prev", "ctl00_phG_dlgUpdateParams_grdFields");
                    Next = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfNext0", "Next", "ctl00_phG_dlgUpdateParams_grdFields");
                    Last = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfLast0", "Last", "ctl00_phG_dlgUpdateParams_grdFields");
                    Cancel = new Button("ctl00_phG_dlgUpdateParams_btnCancelMassUpdates", "Cancel", "ctl00_phG_dlgUpdateParams_grdFields");
                    Finish = new Button("ctl00_phG_dlgUpdateParams_btnFinishMassUpdates", "Finish", "ctl00_phG_dlgUpdateParams_grdFields");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit FieldName { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Value { get; }
                
                public c_grid_row(c_fields_grdfields grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_dlgUpdateParams_grdFields_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    FieldName = new PXTextEdit("ctl00_phG_dlgUpdateParams_grdFields_ei", "FieldName", grid.Locator, "FieldName");
                    FieldName.DataField = "FieldName";
                    DisplayName = new PXTextEdit("ctl00_phG_dlgUpdateParams_grdFields_ei", "Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Value = new PXTextEdit("ctl00_phG_dlgUpdateParams_grdFields_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter FieldName { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Value { get; }
                
                public c_grid_header(c_fields_grdfields grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    FieldName = new PXTextEditColumnFilter(grid.Row.FieldName);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                }
            }
        }
        
        public class c_fields_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_fields_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_dlgUpdateParams_grdFields_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_dlgUpdateParams_grdFields_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_dlgUpdateParams_grdFields_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_dlgUpdateParams_grdFields_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Fields";
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
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Cancel { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfFirst0", "First", "ctl00_phG_dlgUpdateParams_grdFields_lv0");
                    Prev = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfPrev0", "Prev", "ctl00_phG_dlgUpdateParams_grdFields_lv0");
                    Next = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfNext0", "Next", "ctl00_phG_dlgUpdateParams_grdFields_lv0");
                    Last = new Button("ctl00_phG_dlgUpdateParams_grdFields_lfLast0", "Last", "ctl00_phG_dlgUpdateParams_grdFields_lv0");
                    Cancel = new Button("ctl00_phG_dlgUpdateParams_btnCancelMassUpdates", "Cancel", "ctl00_phG_dlgUpdateParams_grdFields_lv0");
                    Finish = new Button("ctl00_phG_dlgUpdateParams_btnFinishMassUpdates", "Finish", "ctl00_phG_dlgUpdateParams_grdFields_lv0");
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
        
        public class c_pivot_grid : PivotTable<c_pivot_grid.c_pivot_filters, c_pivot_grid.c_pivot_rows, c_pivot_grid.c_pivot_columns, c_pivot_grid.c_pivot_values>
        {
            
            public PxToolBar ToolBar;
            
            public c_pivot_grid(String locator, String name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_grid_pivotT");
            }
            
            public virtual void CollapseAll()
            {
                ToolBar.CollapseAll.Click();
            }
            
            public virtual void ExpandAll()
            {
                ToolBar.ExpandAll.Click();
            }
            
            public virtual void YPageFirst()
            {
                ToolBar.YPageFirst.Click();
            }
            
            public virtual void YPagePrev()
            {
                ToolBar.YPagePrev.Click();
            }
            
            public virtual void YPageNext()
            {
                ToolBar.YPageNext.Click();
            }
            
            public virtual void YPageLast()
            {
                ToolBar.YPageLast.Click();
            }
            
            public virtual void XPageFirst()
            {
                ToolBar.XPageFirst.Click();
            }
            
            public virtual void XPagePrev()
            {
                ToolBar.XPagePrev.Click();
            }
            
            public virtual void XPageNext()
            {
                ToolBar.XPageNext.Click();
            }
            
            public virtual void XPageLast()
            {
                ToolBar.XPageLast.Click();
            }
            
            public class c_pivot_filters : PivotFilters
            {
                
                public c_pivot_filters(string locator, PivotTableBase pivotTable) : 
                        base(locator, pivotTable)
                {
                }
            }
            
            public class c_pivot_rows : PivotRows
            {
                
                public c_pivot_rows(string locator, PivotTableBase pivotTable) : 
                        base(locator, pivotTable)
                {
                }
            }
            
            public class c_pivot_columns : PivotColumns
            {
                
                public c_pivot_columns(string locator, PivotTableBase pivotTable) : 
                        base(locator, pivotTable)
                {
                }
            }
            
            public class c_pivot_values : PivotValues
            {
                
                public c_pivot_values(string locator, PivotTableBase pivotTable) : 
                        base(locator, pivotTable)
                {
                }
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid CollapseAll { get; }
			public ToolBarButtonGrid ExpandAll { get; }
			public ToolBarButtonGrid YPageFirst { get; }
			public ToolBarButtonGrid YPagePrev { get; }
			public ToolBarButtonGrid YPageNext { get; }
			public ToolBarButtonGrid YPageLast { get; }
			public ToolBarButtonGrid XPageFirst { get; }
			public ToolBarButtonGrid XPagePrev { get; }
			public ToolBarButtonGrid XPageNext { get; }
			public ToolBarButtonGrid XPageLast { get; }
                
                public PxToolBar(string locator)
                {
                    CollapseAll = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'CollapseAll\']", "Collapse All", locator, null);
                    ExpandAll = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'ExpandAll\']", "Expand All", locator, null);
                    YPageFirst = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPageFirst\']", "YPageFirst", locator, null);
                    YPagePrev = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPagePrev\']", "YPagePrev", locator, null);
                    YPageNext = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPageNext\']", "YPageNext", locator, null);
                    YPageLast = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'YPageLast\']", "YPageLast", locator, null);
                    XPageFirst = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPageFirst\']", "XPageFirst", locator, null);
                    XPagePrev = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPagePrev\']", "XPagePrev", locator, null);
                    XPageNext = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPageNext\']", "XPageNext", locator, null);
                    XPageLast = new ToolBarButtonGrid("css=#ctl00_phG_grid_pivotT_tlbB div[data-cmd=\'XPageLast\']", "XPageLast", locator, null);
                }
            }
        }
    }
}
