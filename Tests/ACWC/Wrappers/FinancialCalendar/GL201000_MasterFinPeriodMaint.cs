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
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.RichTextEdit;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Wait;

namespace ACSC.Tests.Wrappers.FinancialCalendar
{
    
    
    public class GL201000_MasterFinPeriodMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_fiscalyear_form FiscalYear_form { get; } = new c_fiscalyear_form("ctl00_phF_form", "FiscalYear_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_savedialog_saveprm SaveDialog_SavePrm { get; } = new c_savedialog_saveprm("ctl00_phG_spSaveDlg_SavePrm", "SaveDialog_SavePrm");
        protected c_periods_grid Periods_grid { get; } = new c_periods_grid("ctl00_phG_grid", "Periods_grid");
        protected c_periods_lv0 Periods_lv0 { get; } = new c_periods_lv0("ctl00_phG_grid_lv0", "Periods_lv0");
        protected c_generateparams_genparams GenerateParams_GenParams { get; } = new c_generateparams_genparams("ctl00_phG_spGenParams_GenParams", "GenerateParams_GenParams");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public GL201000_MasterFinPeriodMaint()
        {
            ScreenId = "GL201000";
            ScreenUrl = "/Pages/GL/GL201000.aspx";
            ToolBar = new PxToolBar(null);
        }
        
        public virtual GL201000_MasterFinPeriodMaint ReadOne(Gate gate, string Year)
        {
            new BiObject<GL201000_MasterFinPeriodMaint>(gate).ReadOne(this, Year);
            return this;
        }
        
        public virtual GL201000_MasterFinPeriodMaint ReadOne(string Year)
        {
            return this.ReadOne(ApiConnection.Source, Year);
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
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void Prev()
        {
            ToolBar.Prev.Click();
        }
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void ElapsedTime()
        {
            ToolBar.ElapsedTime.Click();
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
        
        public virtual void First()
        {
            ToolBar.First.Click();
        }
        
        public virtual void Previous()
        {
            ToolBar.Previous.Click();
        }
        
        public virtual void Next1()
        {
            ToolBar.Next1.Click();
        }
        
        public virtual void Last()
        {
            ToolBar.Last.Click();
        }
        
        public virtual void GenerateYears()
        {
            ToolBar.GenerateYears.Click();
        }
        
        public virtual void GenerateYears(bool status, string message = null)
        {
            ToolBar.GenerateYears.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.GenerateYears.Click();
        }
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void Open()
        {
            ToolBar.Open.Click();
        }
        
        public virtual void Close()
        {
            ToolBar.Close.Click();
        }
        
        public virtual void Lock()
        {
            ToolBar.Lock.Click();
        }
        
        public virtual void Deactivate()
        {
            ToolBar.Deactivate.Click();
        }
        
        public virtual void Reopen()
        {
            ToolBar.Reopen.Click();
        }
        
        public virtual void Unlock()
        {
            ToolBar.Unlock.Click();
        }
        
        public virtual void OpenHidden()
        {
            ToolBar.OpenHidden.Click();
        }
        
        public virtual void CloseHidden()
        {
            ToolBar.CloseHidden.Click();
        }
        
        public virtual void LockHidden()
        {
            ToolBar.LockHidden.Click();
        }
        
        public virtual void DeactivateHidden()
        {
            ToolBar.DeactivateHidden.Click();
        }
        
        public virtual void ReopenHidden()
        {
            ToolBar.ReopenHidden.Click();
        }
        
        public virtual void UnlockHidden()
        {
            ToolBar.UnlockHidden.Click();
        }
        
        public virtual void LongRun1()
        {
            ToolBar.LongRun1.Click();
        }
        
        public virtual void ElapsedTime1()
        {
            ToolBar.ElapsedTime1.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton Favorites { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Prev { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Previous { get; }
			public ToolBarButton Next1 { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton GenerateYears { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton Open { get; }
			public ToolBarButton Close { get; }
			public ToolBarButton Lock { get; }
			public ToolBarButton Deactivate { get; }
			public ToolBarButton Reopen { get; }
			public ToolBarButton Unlock { get; }
			public ToolBarButton OpenHidden { get; }
			public ToolBarButton CloseHidden { get; }
			public ToolBarButton LockHidden { get; }
			public ToolBarButton DeactivateHidden { get; }
			public ToolBarButton ReopenHidden { get; }
			public ToolBarButton UnlockHidden { get; }
			public ToolBarButton LongRun1 { get; }
			public ToolBarButton ElapsedTime1 { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Help", locator, null);
                Next = new ToolBarButton("css=#ctl00_usrCaption_shareColumnsDlg_shareColumsDS_ToolBar div[data-cmd=\'next\']", "next", locator, null);
                Prev = new ToolBarButton("css=#ctl00_usrCaption_shareColumnsDlg_shareColumsDS_ToolBar div[data-cmd=\'prev\']", "prev", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_usrCaption_shareColumnsDlg_shareColumsDS_ToolBar div[data-cmd=\'LongRun" +
                        "\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_usrCaption_shareColumnsDlg_shareColumsDS_ToolBar div[data-cmd=\'Elapsed" +
                        "Time\']", "Elapsed time", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Save\']", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Insert\']", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Delete\']", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The selected financial year will be deleted.");
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'First\']", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Previous\']", "Go to Previous Record (PgUp)", locator, null);
                Next1 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Next\']", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Last\']", "Go to Last Record", locator, null);
                GenerateYears = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'generateYears\']", "Generate Calendar", locator, null);
                //GenerateYears.WaitAction = Wait.WaitForLongOperationToComplete;
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                Open = new ToolBarButton("css=li[data-cmd=\'ActionsMenu@open\']", "Open Periods", locator, Actions);
                Close = new ToolBarButton("css=li[data-cmd=\'ActionsMenu@close\']", "Close Periods", locator, Actions);
                Lock = new ToolBarButton("css=li[data-cmd=\'ActionsMenu@lock\']", "Lock Periods", locator, Actions);
                Deactivate = new ToolBarButton("css=li[data-cmd=\'ActionsMenu@deactivate\']", "Deactivate Periods", locator, Actions);
                Reopen = new ToolBarButton("css=li[data-cmd=\'ActionsMenu@reopen\']", "Reopen Periods", locator, Actions);
                Unlock = new ToolBarButton("css=li[data-cmd=\'ActionsMenu@unlock\']", "Unlock Periods", locator, Actions);
                OpenHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'open\']", "Open Periods", locator, null);
                CloseHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'close\']", "Close Periods", locator, null);
                LockHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'lock\']", "Lock Periods", locator, null);
                DeactivateHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'deactivate\']", "Deactivate Periods", locator, null);
                ReopenHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'reopen\']", "Reopen Periods", locator, null);
                UnlockHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'unlock\']", "Unlock Periods", locator, null);
                LongRun1 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime1 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_fiscalyear_form : Container
        {
            
			public Selector Year { get; }
			public Label YearLabel { get; }
			public DateSelector StartDate { get; }
			public Label StartDateLabel { get; }
			public PXNumberEdit FinPeriods { get; }
			public Label FinPeriodsLabel { get; }
			public CheckBox CustomPeriods { get; }
			public Label CustomPeriodsLabel { get; }
            
            public c_fiscalyear_form(string locator, string name) : 
                    base(locator, name)
            {
                Year = new Selector("ctl00_phF_form_edYear", "Financial Year", locator, null);
                YearLabel = new Label(Year);
                Year.DataField = "Year";
                StartDate = new DateSelector("ctl00_phF_form_edStartDate", "Start Date", locator, null);
                StartDateLabel = new Label(StartDate);
                StartDate.DataField = "StartDate";
                FinPeriods = new PXNumberEdit("ctl00_phF_form_edFinPeriods", "Number of Periods", locator, null);
                FinPeriodsLabel = new Label(FinPeriods);
                FinPeriods.DataField = "FinPeriods";
                CustomPeriods = new CheckBox("ctl00_phF_form_CustomPeriods", "User-Defined Periods", locator, null);
                CustomPeriodsLabel = new Label(CustomPeriods);
                CustomPeriods.DataField = "CustomPeriods";
                DataMemberName = "FiscalYear";
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
                    Selected = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "Included", grid.Locator, "Selected");
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
                    Delete.ConfirmAction = () => Alert.AlertToException("The selected financial year will be deleted.");
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
                    Included = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Username = new Selector("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    DisplayName = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Display Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Email = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Guest = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "Guest Account", grid.Locator, "Guest");
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
        
        public class c_savedialog_saveprm : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Message { get; }
			public Label MessageLabel { get; }
			public DropDown Method { get; }
			public Label MethodLabel { get; }
			public CheckBox MoveDayOfWeek { get; }
			public Label MoveDayOfWeekLabel { get; }
			public RichTextEdit MethodDescription { get; }
			public Label MethodDescriptionLabel { get; }
            
            public c_savedialog_saveprm(string locator, string name) : 
                    base(locator, name)
            {
                Message = new PXTextEdit("ctl00_phG_spSaveDlg_SavePrm_edMessage", "Message", locator, null);
                MessageLabel = new Label(Message);
                Message.DataField = "Message";
                Method = new DropDown("ctl00_phG_spSaveDlg_SavePrm_edMethod", "Method", locator, null);
                MethodLabel = new Label(Method);
                Method.DataField = "Method";
                MoveDayOfWeek = new CheckBox("ctl00_phG_spSaveDlg_SavePrm_edMoveDayOfWeek", "Move Day Of Week", locator, null);
                MoveDayOfWeekLabel = new Label(MoveDayOfWeek);
                MoveDayOfWeek.DataField = "MoveDayOfWeek";
                MethodDescription = new RichTextEdit("ctl00_phG_spSaveDlg_SavePrm_edMethodDescription", "Method Description", locator, null);
                MethodDescriptionLabel = new Label(MethodDescription);
                MethodDescription.DataField = "MethodDescription";
                DataMemberName = "SaveDialog";
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
                    Ok = new Button("ctl00_phG_spSaveDlg_cbOk", "OK", "ctl00_phG_spSaveDlg_SavePrm");
                    Cancel = new Button("ctl00_phG_spSaveDlg_cbCancel", "Cancel", "ctl00_phG_spSaveDlg_SavePrm");
                }
            }
        }
        
        public class c_periods_grid : Grid<c_periods_grid.c_grid_row, c_periods_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_periods_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_grid");
                DataMemberName = "Periods";
                FilterForm = new c_grid_filter("ctl00_phG_grid_fe_gf", "FilterForm");
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
            
            public virtual void CreatePeriods()
            {
                ToolBar.CreatePeriods.Click();
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
			public ToolBarButtonGrid CreatePeriods { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The selected financial year will be deleted.");
                    CreatePeriods = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_tlb div[data-cmd=\'cmdAutoFill\']", "Create Periods", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit FinPeriodID { get; }
			public DateSelector StartDateUI { get; }
			public DateSelector EndDateUI { get; }
			public PXNumberEdit Length { get; }
			public InputLocalizable Descr { get; }
			public DropDown Status { get; }
			public CheckBox IsAdjustment { get; }
			public CheckBox APClosed { get; }
			public CheckBox ARClosed { get; }
			public CheckBox INClosed { get; }
			public CheckBox Closed { get; }
			public CheckBox CAClosed { get; }
			public CheckBox FAClosed { get; }
                
                public c_grid_row(c_periods_grid grid) : 
                        base(grid)
                {
                    FinPeriodID = new PXTextEdit("ctl00_phG_grid_em", "Financial Period ID", grid.Locator, "FinPeriodID");
                    FinPeriodID.DataField = "FinPeriodID";
                    StartDateUI = new DateSelector("_ctl00_phG_grid_lv0_ed1", "Start Date", grid.Locator, "StartDateUI");
                    StartDateUI.DataField = "StartDateUI";
                    EndDateUI = new DateSelector("_ctl00_phG_grid_lv0_EndDateUI", "End Date", grid.Locator, "EndDateUI");
                    EndDateUI.DataField = "EndDateUI";
                    Length = new PXNumberEdit("ctl00_phG_grid_en", "Length (Days)", grid.Locator, "Length");
                    Length.DataField = "Length";
                    Descr = new InputLocalizable("ctl00_phG_grid_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    Status = new DropDown("_ctl00_phG_grid_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("Inactive", "Inactive");
                    Status.Items.Add("Open", "Open");
                    Status.Items.Add("Closed", "Closed");
                    Status.Items.Add("Locked", "Locked");
                    IsAdjustment = new CheckBox("ctl00_phG_grid", "Adjustment Period", grid.Locator, "IsAdjustment");
                    IsAdjustment.DataField = "IsAdjustment";
                    APClosed = new CheckBox("ctl00_phG_grid", "Closed in AP", grid.Locator, "APClosed");
                    APClosed.DataField = "APClosed";
                    ARClosed = new CheckBox("ctl00_phG_grid", "Closed in AR", grid.Locator, "ARClosed");
                    ARClosed.DataField = "ARClosed";
                    INClosed = new CheckBox("ctl00_phG_grid", "Closed in IN", grid.Locator, "INClosed");
                    INClosed.DataField = "INClosed";
                    Closed = new CheckBox("ctl00_phG_grid", "Closed in GL", grid.Locator, "Closed");
                    Closed.DataField = "Closed";
                    CAClosed = new CheckBox("ctl00_phG_grid", "Closed in CA", grid.Locator, "CAClosed");
                    CAClosed.DataField = "CAClosed";
                    FAClosed = new CheckBox("ctl00_phG_grid", "Closed in FA", grid.Locator, "FAClosed");
                    FAClosed.DataField = "FAClosed";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter FinPeriodID { get; }
				public DateSelectorColumnFilter StartDateUI { get; }
				public DateSelectorColumnFilter EndDateUI { get; }
				public PXNumberEditColumnFilter Length { get; }
				public PXTextEditColumnFilter Descr { get; }
				public DropDownColumnFilter Status { get; }
				public CheckBoxColumnFilter IsAdjustment { get; }
				public CheckBoxColumnFilter APClosed { get; }
				public CheckBoxColumnFilter ARClosed { get; }
				public CheckBoxColumnFilter INClosed { get; }
				public CheckBoxColumnFilter Closed { get; }
				public CheckBoxColumnFilter CAClosed { get; }
				public CheckBoxColumnFilter FAClosed { get; }
                
                public c_grid_header(c_periods_grid grid) : 
                        base(grid)
                {
                    FinPeriodID = new PXTextEditColumnFilter(grid.Row.FinPeriodID);
                    StartDateUI = new DateSelectorColumnFilter(grid.Row.StartDateUI);
                    EndDateUI = new DateSelectorColumnFilter(grid.Row.EndDateUI);
                    Length = new PXNumberEditColumnFilter(grid.Row.Length);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    IsAdjustment = new CheckBoxColumnFilter(grid.Row.IsAdjustment);
                    APClosed = new CheckBoxColumnFilter(grid.Row.APClosed);
                    ARClosed = new CheckBoxColumnFilter(grid.Row.ARClosed);
                    INClosed = new CheckBoxColumnFilter(grid.Row.INClosed);
                    Closed = new CheckBoxColumnFilter(grid.Row.Closed);
                    CAClosed = new CheckBoxColumnFilter(grid.Row.CAClosed);
                    FAClosed = new CheckBoxColumnFilter(grid.Row.FAClosed);
                }
            }
        }
        
        public class c_periods_lv0 : Container
        {
            
			public DateSelector EndDateUI { get; }
			public Label EndDateUILabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_periods_lv0(string locator, string name) : 
                    base(locator, name)
            {
                EndDateUI = new DateSelector("ctl00_phG_grid_lv0_EndDateUI", "End Date", locator, null);
                EndDateUILabel = new Label(EndDateUI);
                EndDateUI.DataField = "EndDateUI";
                Ed = new DateSelector("ctl00_phG_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_grid_lv0_ec", "Ec", locator, null);
                DataMemberName = "Periods";
            }
        }
        
        public class c_generateparams_genparams : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FirstFinYear { get; }
			public Label FirstFinYearLabel { get; }
			public PXTextEdit LastFinYear { get; }
			public Label LastFinYearLabel { get; }
			public PXTextEdit FromYear { get; }
			public Label FromYearLabel { get; }
			public PXTextEdit ToYear { get; }
			public Label ToYearLabel { get; }
            
            public c_generateparams_genparams(string locator, string name) : 
                    base(locator, name)
            {
                FirstFinYear = new PXTextEdit("ctl00_phG_spGenParams_GenParams_edFirstYear", "First Fin Year", locator, null);
                FirstFinYearLabel = new Label(FirstFinYear);
                FirstFinYear.DataField = "FirstFinYear";
                LastFinYear = new PXTextEdit("ctl00_phG_spGenParams_GenParams_edLastYear", "Last Fin Year", locator, null);
                LastFinYearLabel = new Label(LastFinYear);
                LastFinYear.DataField = "LastFinYear";
                FromYear = new PXTextEdit("ctl00_phG_spGenParams_GenParams_edFromYear", "From Year", locator, null);
                FromYearLabel = new Label(FromYear);
                FromYear.DataField = "FromYear";
                ToYear = new PXTextEdit("ctl00_phG_spGenParams_GenParams_edToYear", "To Year", locator, null);
                ToYearLabel = new Label(ToYear);
                ToYear.DataField = "ToYear";
                DataMemberName = "GenerateParams";
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
                    Ok = new Button("ctl00_phG_spGenParams_cbOk2", "OK", "ctl00_phG_spGenParams_GenParams");
                    Cancel = new Button("ctl00_phG_spGenParams_cbCancel2", "Cancel", "ctl00_phG_spGenParams_GenParams");
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
