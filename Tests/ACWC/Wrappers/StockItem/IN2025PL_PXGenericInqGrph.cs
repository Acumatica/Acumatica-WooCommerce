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
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.Pivot;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;

namespace ACSC.Tests.Wrappers.StockItem
{
    
    
    public class IN2025PL_PXGenericInqGrph : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
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
        
        public IN2025PL_PXGenericInqGrph()
        {
            ScreenId = "IN2025PL";
            ScreenUrl = "/GenericInquiry/GenericInquiry.aspx?id=e4352bbd-a53a-42c4-9b96-e9f0fda070c7";
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
			public Selector InventoryItem_inventoryCD { get; }
			public Selector InventoryItem_descr { get; }
			public DropDown InventoryItem_itemType { get; }
			public CheckBox InventoryItem_kitItem { get; }
			public Selector InventoryItem_itemClassID { get; }
			public PXTextEdit InventoryItem_postClassID { get; }
			public Selector InventoryItem_taxCategoryID { get; }
			public Selector InventoryItem_lotSerClassID { get; }
			public DropDown InventoryItem_valMethod { get; }
			public Selector InventoryItem_dfltSiteID { get; }
			public Selector InventoryItem_baseUnit { get; }
			public Selector InventoryItem_salesUnit { get; }
			public Selector InventoryItem_purchaseUnit { get; }
			public PXNumberEdit InventoryItem_basePrice { get; }
			public PXNumberEdit InventoryItem_stdCost { get; }
			public PXNumberEdit InventoryItem_pendingStdCost { get; }
			public PXNumberEdit InventoryItem_markupPct { get; }
			public Selector InventoryItem_preferredVendorID { get; }
			public Selector InventoryItem_movementClassID { get; }
			public Selector InventoryItem_priceClassID { get; }
			public Selector InventoryItem_priceWorkgroupID { get; }
			public Selector InventoryItem_priceManagerID { get; }
			public Selector InventoryItem_productWorkgroupID { get; }
			public Selector InventoryItem_productManagerID { get; }
			public DropDown InventoryItem_itemStatus { get; }
			public Selector InventoryItem_createdByID { get; }
			public DateSelector InventoryItem_createdDateTime { get; }
			public Selector InventoryItem_lastModifiedByID { get; }
			public DateSelector InventoryItem_lastModifiedDateTime { get; }
			public Selector INItemClass_ItemClassCD { get; }
			public Selector BAccountR_AcctCD { get; }
                
                public c_grid_row(c_results_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_grid_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    Row = new PXNumberEdit("ctl00_phG_grid_en", "Row Number", grid.Locator, "Row");
                    Row.DataField = "Row";
                    InventoryItem_inventoryCD = new Selector("_ctl00_phG_grid_lv0_es", "Inventory ID", grid.Locator, "InventoryItem_inventoryCD");
                    InventoryItem_inventoryCD.DataField = "InventoryItem_inventoryCD";
                    InventoryItem_descr = new Selector("_ctl00_phG_grid_lv0_es", "Description", grid.Locator, "InventoryItem_descr");
                    InventoryItem_descr.DataField = "InventoryItem_descr";
                    InventoryItem_itemType = new DropDown("_ctl00_phG_grid_lv0_ec", "Type", grid.Locator, "InventoryItem_itemType");
                    InventoryItem_itemType.DataField = "InventoryItem_itemType";
                    InventoryItem_itemType.Items.Add("F", "Finished Good");
                    InventoryItem_itemType.Items.Add("M", "Component Part");
                    InventoryItem_itemType.Items.Add("A", "Subassembly");
                    InventoryItem_itemType.Items.Add("N", "Non-Stock Item");
                    InventoryItem_itemType.Items.Add("L", "Labor");
                    InventoryItem_itemType.Items.Add("S", "Service");
                    InventoryItem_itemType.Items.Add("C", "Charge");
                    InventoryItem_itemType.Items.Add("E", "Expense");
                    InventoryItem_kitItem = new CheckBox("ctl00_phG_grid", "Is a Kit", grid.Locator, "InventoryItem_kitItem");
                    InventoryItem_kitItem.DataField = "InventoryItem_kitItem";
                    InventoryItem_itemClassID = new Selector("_ctl00_phG_grid_lv0_es", "Item Class", grid.Locator, "InventoryItem_itemClassID");
                    InventoryItem_itemClassID.DataField = "InventoryItem_itemClassID";
                    InventoryItem_postClassID = new PXTextEdit("ctl00_phG_grid_em", "Posting Class", grid.Locator, "InventoryItem_postClassID");
                    InventoryItem_postClassID.DataField = "InventoryItem_postClassID";
                    InventoryItem_taxCategoryID = new Selector("_ctl00_phG_grid_lv0_es", "Tax Category", grid.Locator, "InventoryItem_taxCategoryID");
                    InventoryItem_taxCategoryID.DataField = "InventoryItem_taxCategoryID";
                    InventoryItem_lotSerClassID = new Selector("_ctl00_phG_grid_lv0_es", "Lot/Serial Class", grid.Locator, "InventoryItem_lotSerClassID");
                    InventoryItem_lotSerClassID.DataField = "InventoryItem_lotSerClassID";
                    InventoryItem_valMethod = new DropDown("_ctl00_phG_grid_lv0_ec", "Valuation Method", grid.Locator, "InventoryItem_valMethod");
                    InventoryItem_valMethod.DataField = "InventoryItem_valMethod";
                    InventoryItem_valMethod.Items.Add("T", "Standard");
                    InventoryItem_valMethod.Items.Add("A", "Average");
                    InventoryItem_valMethod.Items.Add("F", "FIFO");
                    InventoryItem_valMethod.Items.Add("S", "Specific");
                    InventoryItem_dfltSiteID = new Selector("_ctl00_phG_grid_lv0_es", "Default Warehouse", grid.Locator, "InventoryItem_dfltSiteID");
                    InventoryItem_dfltSiteID.DataField = "InventoryItem_dfltSiteID";
                    InventoryItem_baseUnit = new Selector("_ctl00_phG_grid_lv0_es", "Base Unit", grid.Locator, "InventoryItem_baseUnit");
                    InventoryItem_baseUnit.DataField = "InventoryItem_baseUnit";
                    InventoryItem_salesUnit = new Selector("_ctl00_phG_grid_lv0_es", "Sales Unit", grid.Locator, "InventoryItem_salesUnit");
                    InventoryItem_salesUnit.DataField = "InventoryItem_salesUnit";
                    InventoryItem_purchaseUnit = new Selector("_ctl00_phG_grid_lv0_es", "Purchase Unit", grid.Locator, "InventoryItem_purchaseUnit");
                    InventoryItem_purchaseUnit.DataField = "InventoryItem_purchaseUnit";
                    InventoryItem_basePrice = new PXNumberEdit("ctl00_phG_grid_en", "Default Price", grid.Locator, "InventoryItem_basePrice");
                    InventoryItem_basePrice.DataField = "InventoryItem_basePrice";
                    InventoryItem_stdCost = new PXNumberEdit("ctl00_phG_grid_en", "Current Cost", grid.Locator, "InventoryItem_stdCost");
                    InventoryItem_stdCost.DataField = "InventoryItem_stdCost";
                    InventoryItem_pendingStdCost = new PXNumberEdit("ctl00_phG_grid_en", "Pending Cost", grid.Locator, "InventoryItem_pendingStdCost");
                    InventoryItem_pendingStdCost.DataField = "InventoryItem_pendingStdCost";
                    InventoryItem_markupPct = new PXNumberEdit("ctl00_phG_grid_en", "Markup %", grid.Locator, "InventoryItem_markupPct");
                    InventoryItem_markupPct.DataField = "InventoryItem_markupPct";
                    InventoryItem_preferredVendorID = new Selector("_ctl00_phG_grid_lv0_es", "Preferred Vendor", grid.Locator, "InventoryItem_preferredVendorID");
                    InventoryItem_preferredVendorID.DataField = "InventoryItem_preferredVendorID";
                    InventoryItem_movementClassID = new Selector("_ctl00_phG_grid_lv0_es", "Movement Class", grid.Locator, "InventoryItem_movementClassID");
                    InventoryItem_movementClassID.DataField = "InventoryItem_movementClassID";
                    InventoryItem_priceClassID = new Selector("_ctl00_phG_grid_lv0_es", "Price Class", grid.Locator, "InventoryItem_priceClassID");
                    InventoryItem_priceClassID.DataField = "InventoryItem_priceClassID";
                    InventoryItem_priceWorkgroupID = new Selector("_ctl00_phG_grid_lv0_es", "Price Workgroup", grid.Locator, "InventoryItem_priceWorkgroupID");
                    InventoryItem_priceWorkgroupID.DataField = "InventoryItem_priceWorkgroupID";
                    InventoryItem_priceManagerID = new Selector("_ctl00_phG_grid_lv0_es", "Price Manager", grid.Locator, "InventoryItem_priceManagerID");
                    InventoryItem_priceManagerID.DataField = "InventoryItem_priceManagerID";
                    InventoryItem_productWorkgroupID = new Selector("_ctl00_phG_grid_lv0_es", "Product Workgroup", grid.Locator, "InventoryItem_productWorkgroupID");
                    InventoryItem_productWorkgroupID.DataField = "InventoryItem_productWorkgroupID";
                    InventoryItem_productManagerID = new Selector("_ctl00_phG_grid_lv0_es", "Product Manager", grid.Locator, "InventoryItem_productManagerID");
                    InventoryItem_productManagerID.DataField = "InventoryItem_productManagerID";
                    InventoryItem_itemStatus = new DropDown("_ctl00_phG_grid_lv0_ec", "Item Status", grid.Locator, "InventoryItem_itemStatus");
                    InventoryItem_itemStatus.DataField = "InventoryItem_itemStatus";
                    InventoryItem_itemStatus.Items.Add("AC", "Active");
                    InventoryItem_itemStatus.Items.Add("NS", "No Sales");
                    InventoryItem_itemStatus.Items.Add("NP", "No Purchases");
                    InventoryItem_itemStatus.Items.Add("NR", "No Request");
                    InventoryItem_itemStatus.Items.Add("IN", "Inactive");
                    InventoryItem_itemStatus.Items.Add("DE", "Marked for Deletion");
                    InventoryItem_createdByID = new Selector("_ctl00_phG_grid_lv0_es", "Created By", grid.Locator, "InventoryItem_createdByID");
                    InventoryItem_createdByID.DataField = "InventoryItem_createdByID";
                    InventoryItem_createdDateTime = new DateSelector("_ctl00_phG_grid_lv0_ed30", "Created On", grid.Locator, "InventoryItem_createdDateTime");
                    InventoryItem_createdDateTime.DataField = "InventoryItem_createdDateTime";
                    InventoryItem_lastModifiedByID = new Selector("_ctl00_phG_grid_lv0_es", "Last Modified By", grid.Locator, "InventoryItem_lastModifiedByID");
                    InventoryItem_lastModifiedByID.DataField = "InventoryItem_lastModifiedByID";
                    InventoryItem_lastModifiedDateTime = new DateSelector("_ctl00_phG_grid_lv0_ed32", "Last Modified On", grid.Locator, "InventoryItem_lastModifiedDateTime");
                    InventoryItem_lastModifiedDateTime.DataField = "InventoryItem_lastModifiedDateTime";
                    INItemClass_ItemClassCD = new Selector("_ctl00_phG_grid_lv0_es", "Class ID", grid.Locator, "INItemClass_ItemClassCD");
                    INItemClass_ItemClassCD.DataField = "INItemClass_ItemClassCD";
                    BAccountR_AcctCD = new Selector("_ctl00_phG_grid_lv0_es", "Account ID", grid.Locator, "BAccountR_AcctCD");
                    BAccountR_AcctCD.DataField = "BAccountR_AcctCD";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter Row { get; }
				public SelectorColumnFilter InventoryItem_inventoryCD { get; }
				public InputColumnFilter InventoryItem_descr { get; }
				public DropDownColumnFilter InventoryItem_itemType { get; }
				public CheckBoxColumnFilter InventoryItem_kitItem { get; }
				public SelectorColumnFilter InventoryItem_itemClassID { get; }
				public PXTextEditColumnFilter InventoryItem_postClassID { get; }
				public SelectorColumnFilter InventoryItem_taxCategoryID { get; }
				public SelectorColumnFilter InventoryItem_lotSerClassID { get; }
				public DropDownColumnFilter InventoryItem_valMethod { get; }
				public SelectorColumnFilter InventoryItem_dfltSiteID { get; }
				public SelectorColumnFilter InventoryItem_baseUnit { get; }
				public SelectorColumnFilter InventoryItem_salesUnit { get; }
				public SelectorColumnFilter InventoryItem_purchaseUnit { get; }
				public PXNumberEditColumnFilter InventoryItem_basePrice { get; }
				public PXNumberEditColumnFilter InventoryItem_stdCost { get; }
				public PXNumberEditColumnFilter InventoryItem_pendingStdCost { get; }
				public PXNumberEditColumnFilter InventoryItem_markupPct { get; }
				public SelectorColumnFilter InventoryItem_preferredVendorID { get; }
				public SelectorColumnFilter InventoryItem_movementClassID { get; }
				public SelectorColumnFilter InventoryItem_priceClassID { get; }
				public SelectorColumnFilter InventoryItem_priceWorkgroupID { get; }
				public SelectorColumnFilter InventoryItem_priceManagerID { get; }
				public SelectorColumnFilter InventoryItem_productWorkgroupID { get; }
				public SelectorColumnFilter InventoryItem_productManagerID { get; }
				public DropDownColumnFilter InventoryItem_itemStatus { get; }
				public SelectorColumnFilter InventoryItem_createdByID { get; }
				public DateSelectorColumnFilter InventoryItem_createdDateTime { get; }
				public SelectorColumnFilter InventoryItem_lastModifiedByID { get; }
				public DateSelectorColumnFilter InventoryItem_lastModifiedDateTime { get; }
				public SelectorColumnFilter INItemClass_ItemClassCD { get; }
				public SelectorColumnFilter BAccountR_AcctCD { get; }
                
                public c_grid_header(c_results_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    Row = new PXNumberEditColumnFilter(grid.Row.Row);
                    InventoryItem_inventoryCD = new SelectorColumnFilter(grid.Row.InventoryItem_inventoryCD);
                    InventoryItem_descr = new InputColumnFilter(grid.Row.InventoryItem_descr);
                    InventoryItem_itemType = new DropDownColumnFilter(grid.Row.InventoryItem_itemType);
                    InventoryItem_kitItem = new CheckBoxColumnFilter(grid.Row.InventoryItem_kitItem);
                    InventoryItem_itemClassID = new SelectorColumnFilter(grid.Row.InventoryItem_itemClassID);
                    InventoryItem_postClassID = new PXTextEditColumnFilter(grid.Row.InventoryItem_postClassID);
                    InventoryItem_taxCategoryID = new SelectorColumnFilter(grid.Row.InventoryItem_taxCategoryID);
                    InventoryItem_lotSerClassID = new SelectorColumnFilter(grid.Row.InventoryItem_lotSerClassID);
                    InventoryItem_valMethod = new DropDownColumnFilter(grid.Row.InventoryItem_valMethod);
                    InventoryItem_dfltSiteID = new SelectorColumnFilter(grid.Row.InventoryItem_dfltSiteID);
                    InventoryItem_baseUnit = new SelectorColumnFilter(grid.Row.InventoryItem_baseUnit);
                    InventoryItem_salesUnit = new SelectorColumnFilter(grid.Row.InventoryItem_salesUnit);
                    InventoryItem_purchaseUnit = new SelectorColumnFilter(grid.Row.InventoryItem_purchaseUnit);
                    InventoryItem_basePrice = new PXNumberEditColumnFilter(grid.Row.InventoryItem_basePrice);
                    InventoryItem_stdCost = new PXNumberEditColumnFilter(grid.Row.InventoryItem_stdCost);
                    InventoryItem_pendingStdCost = new PXNumberEditColumnFilter(grid.Row.InventoryItem_pendingStdCost);
                    InventoryItem_markupPct = new PXNumberEditColumnFilter(grid.Row.InventoryItem_markupPct);
                    InventoryItem_preferredVendorID = new SelectorColumnFilter(grid.Row.InventoryItem_preferredVendorID);
                    InventoryItem_movementClassID = new SelectorColumnFilter(grid.Row.InventoryItem_movementClassID);
                    InventoryItem_priceClassID = new SelectorColumnFilter(grid.Row.InventoryItem_priceClassID);
                    InventoryItem_priceWorkgroupID = new SelectorColumnFilter(grid.Row.InventoryItem_priceWorkgroupID);
                    InventoryItem_priceManagerID = new SelectorColumnFilter(grid.Row.InventoryItem_priceManagerID);
                    InventoryItem_productWorkgroupID = new SelectorColumnFilter(grid.Row.InventoryItem_productWorkgroupID);
                    InventoryItem_productManagerID = new SelectorColumnFilter(grid.Row.InventoryItem_productManagerID);
                    InventoryItem_itemStatus = new DropDownColumnFilter(grid.Row.InventoryItem_itemStatus);
                    InventoryItem_createdByID = new SelectorColumnFilter(grid.Row.InventoryItem_createdByID);
                    InventoryItem_createdDateTime = new DateSelectorColumnFilter(grid.Row.InventoryItem_createdDateTime);
                    InventoryItem_lastModifiedByID = new SelectorColumnFilter(grid.Row.InventoryItem_lastModifiedByID);
                    InventoryItem_lastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.InventoryItem_lastModifiedDateTime);
                    INItemClass_ItemClassCD = new SelectorColumnFilter(grid.Row.INItemClass_ItemClassCD);
                    BAccountR_AcctCD = new SelectorColumnFilter(grid.Row.BAccountR_AcctCD);
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
