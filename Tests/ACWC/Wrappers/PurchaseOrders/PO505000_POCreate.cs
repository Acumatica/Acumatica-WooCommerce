using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.QuickSearch;
using Controls.Editors.Selector;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.Wait;

namespace ACSC.Tests.Wrappers.PurchaseOrders
{
    
    
    public class PO505000_POCreate : Wrapper
    {
        
        public PxToolBar ToolBar;
        
			public QuickSearch QuickSearch { get; }
        protected c_filter_form Filter_form { get; } = new c_filter_form("ctl00_phF_form", "Filter_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_fixeddemand_grid FixedDemand_grid { get; } = new c_fixeddemand_grid("ctl00_phG_grid", "FixedDemand_grid");
        protected c_fixeddemand_lv0 FixedDemand_lv0 { get; } = new c_fixeddemand_lv0("ctl00_phG_grid_lv0", "FixedDemand_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public PO505000_POCreate()
        {
            ScreenId = "PO505000";
            ScreenUrl = "/Pages/PO/PO505000.aspx";
            ToolBar = new PxToolBar(null);
            QuickSearch = new QuickSearch("ctl00_phDS_ds_ToolBar_fb", "QuickSearch", null, null);
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
        
        public virtual void Refresh()
        {
            ToolBar.Refresh.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void ViewDocument()
        {
            ToolBar.ViewDocument.Click();
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
        
        public virtual void InventorySummary()
        {
            ToolBar.InventorySummary.Click();
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
			public ToolBarButton Refresh { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton ViewDocument { get; }
			public ToolBarButton Process { get; }
			public ToolBarButton ProcessAll { get; }
			public ToolBarButton ScheduleAddHidden { get; }
			public ToolBarButton ScheduleViewHidden { get; }
			public ToolBarButton ScheduleHistoryHidden { get; }
			public ToolBarButton Schedules { get; }
			public ToolBarButton ScheduleAdd { get; }
			public ToolBarButton ScheduleView { get; }
			public ToolBarButton ScheduleHistory { get; }
			public ToolBarButton InventorySummary { get; }
			public ToolBarButton Adjust { get; }
			public ToolBarButton Export { get; }
			public ToolBarButton Filter { get; }
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
                Refresh = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                ViewDocument = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewDocument\']", "Edit Record", locator, null);
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
                InventorySummary = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'InventorySummary\']", "Inventory Summary", locator, null);
                Adjust = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                Export = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                Filter = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                LongRun1 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime1 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_filter_form : Container
        {
            
			public DateSelector PurchDate { get; }
			public Label PurchDateLabel { get; }
			public Selector OwnerID { get; }
			public Label OwnerIDLabel { get; }
			public CheckBox MyOwner { get; }
			public Label MyOwnerLabel { get; }
			public Selector WorkGroupID { get; }
			public Label WorkGroupIDLabel { get; }
			public CheckBox MyWorkGroup { get; }
			public Label MyWorkGroupLabel { get; }
			public Selector ItemClassCD { get; }
			public Label ItemClassCDLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public DateSelector RequestedOnDate { get; }
			public Label RequestedOnDateLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector SrvOrdType { get; }
			public Label SrvOrdTypeLabel { get; }
			public Selector ServiceOrderRefNbr { get; }
			public Label ServiceOrderRefNbrLabel { get; }
			public PXNumberEdit OrderTotal { get; }
			public Label OrderTotalLabel { get; }
			public PXNumberEdit OrderWeight { get; }
			public Label OrderWeightLabel { get; }
			public PXNumberEdit OrderVolume { get; }
			public Label OrderVolumeLabel { get; }
            
            public c_filter_form(string locator, string name) : 
                    base(locator, name)
            {
                PurchDate = new DateSelector("ctl00_phF_form_edPurchDate", "Creation Date", locator, null);
                PurchDateLabel = new Label(PurchDate);
                PurchDate.DataField = "PurchDate";
                OwnerID = new Selector("ctl00_phF_form_edOwnerID", "Product Manager", locator, null);
                OwnerIDLabel = new Label(OwnerID);
                OwnerID.DataField = "OwnerID";
                MyOwner = new CheckBox("ctl00_phF_form_chkMyOwner", "Me", locator, null);
                MyOwnerLabel = new Label(MyOwner);
                MyOwner.DataField = "MyOwner";
                WorkGroupID = new Selector("ctl00_phF_form_edWorkGroupID", "Product  Workgroup", locator, null);
                WorkGroupIDLabel = new Label(WorkGroupID);
                WorkGroupID.DataField = "WorkGroupID";
                MyWorkGroup = new CheckBox("ctl00_phF_form_chkMyWorkGroup", "My", locator, null);
                MyWorkGroupLabel = new Label(MyWorkGroup);
                MyWorkGroup.DataField = "MyWorkGroup";
                ItemClassCD = new Selector("ctl00_phF_form_edItemClassCD", "Item Class ID", locator, null);
                ItemClassCDLabel = new Label(ItemClassCD);
                ItemClassCD.DataField = "ItemClassCD";
                InventoryID = new Selector("ctl00_phF_form_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SiteID = new Selector("ctl00_phF_form_edSiteID", "Warehouse ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                RequestedOnDate = new DateSelector("ctl00_phF_form_edRequestedOnDate", "Requested On", locator, null);
                RequestedOnDateLabel = new Label(RequestedOnDate);
                RequestedOnDate.DataField = "RequestedOnDate";
                VendorID = new Selector("ctl00_phF_form_edVendorID", "Vendor", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                CustomerID = new Selector("ctl00_phF_form_edCustomerID", "Customer", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                OrderType = new Selector("ctl00_phF_form_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phF_form_edOrderNbr", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                SrvOrdType = new Selector("ctl00_phF_form_edSrvOrdType", "Service Order Type", locator, null);
                SrvOrdTypeLabel = new Label(SrvOrdType);
                SrvOrdType.DataField = "SrvOrdType";
                ServiceOrderRefNbr = new Selector("ctl00_phF_form_edserviceOrderRefNbr", "Service Order Nbr.", locator, null);
                ServiceOrderRefNbrLabel = new Label(ServiceOrderRefNbr);
                ServiceOrderRefNbr.DataField = "serviceOrderRefNbr";
                OrderTotal = new PXNumberEdit("ctl00_phF_form_edOrderTotal", "Total", locator, null);
                OrderTotalLabel = new Label(OrderTotal);
                OrderTotal.DataField = "OrderTotal";
                OrderWeight = new PXNumberEdit("ctl00_phF_form_edOrderWeight", "Weight", locator, null);
                OrderWeightLabel = new Label(OrderWeight);
                OrderWeight.DataField = "OrderWeight";
                OrderVolume = new PXNumberEdit("ctl00_phF_form_edOrderVolume", "Volume", locator, null);
                OrderVolumeLabel = new Label(OrderVolume);
                OrderVolume.DataField = "OrderVolume";
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
        
        public class c_fixeddemand_grid : Grid<c_fixeddemand_grid.c_grid_row, c_fixeddemand_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_fixeddemand_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_grid");
                DataMemberName = "FixedDemand";
                FilterForm = new c_grid_filter("ctl00_phG_grid_fe_gf", "FilterForm");
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
                
			public CheckBox Selected { get; }
			public PXTextEdit PlanType_INPlanType_descr { get; }
			public Selector InventoryID { get; }
			public PXTextEdit InventoryID_InventoryItem_descr { get; }
			public Selector SubItemID { get; }
			public Selector POSiteID { get; }
			public PXTextEdit POSiteID_description { get; }
			public Selector SourceSiteID { get; }
			public PXTextEdit SourceSiteDescr { get; }
			public PXTextEdit UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public DateSelector PlanDate { get; }
			public Selector VendorID { get; }
			public PXTextEdit VendorID_Vendor_acctName { get; }
			public Selector VendorLocationID { get; }
			public PXNumberEdit Location__vLeadTime { get; }
			public PXNumberEdit AddLeadTimeDays { get; }
			public Selector Vendor__TermsID { get; }
			public PXTextEdit Location__vCarrierID { get; }
			public PXNumberEdit EffPrice { get; }
			public PXNumberEdit ExtCost { get; }
			public Selector Vendor__CuryID { get; }
			public Selector SOOrder__CustomerID { get; }
			public PXTextEdit SOOrder__CustomerID_BAccountR_acctName { get; }
			public Selector SOOrder__CustomerLocationID { get; }
			public PXNumberEdit SOLine__UnitPrice { get; }
			public Selector SOLine__UOM { get; }
			public Selector SOOrder__OrderNbr { get; }
			public Selector FSRefNbr { get; }
			public PXNumberEdit ExtWeight { get; }
			public PXNumberEdit ExtVolume { get; }
			public PXNumberEdit PlanID { get; }
                
                public c_grid_row(c_fixeddemand_grid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_grid", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    PlanType_INPlanType_descr = new PXTextEdit("ctl00_phG_grid_ei", "Plan Type", grid.Locator, "PlanType_INPlanType_descr");
                    PlanType_INPlanType_descr.DataField = "PlanType_INPlanType_descr";
                    InventoryID = new Selector("_ctl00_phG_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    InventoryID_InventoryItem_descr = new PXTextEdit("ctl00_phG_grid_ei", "Item Description", grid.Locator, "InventoryID_InventoryItem_descr");
                    InventoryID_InventoryItem_descr.DataField = "InventoryID_InventoryItem_descr";
                    SubItemID = new Selector("_ctl00_phG_grid_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    POSiteID = new Selector("_ctl00_phG_grid_lv0_edPOSiteID", "Warehouse", grid.Locator, "POSiteID");
                    POSiteID.DataField = "POSiteID";
                    POSiteID_description = new PXTextEdit("ctl00_phG_grid_ei", "Warehouse Description", grid.Locator, "POSiteID_description");
                    POSiteID_description.DataField = "POSiteID_description";
                    SourceSiteID = new Selector("_ctl00_phG_grid_lv0_edSourceSiteID", "Demand Warehouse", grid.Locator, "SourceSiteID");
                    SourceSiteID.DataField = "SourceSiteID";
                    SourceSiteDescr = new PXTextEdit("ctl00_phG_grid_ei", "Demand Warehouse Description", grid.Locator, "SourceSiteDescr");
                    SourceSiteDescr.DataField = "SourceSiteDescr";
                    UOM = new PXTextEdit("ctl00_phG_grid_ei", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrderQty = new PXNumberEdit("ctl00_phG_grid_en", "Quantity", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    PlanDate = new DateSelector("_ctl00_phG_grid_lv0_edPlanDate", "Requested On", grid.Locator, "PlanDate");
                    PlanDate.DataField = "PlanDate";
                    VendorID = new Selector("_ctl00_phG_grid_lv0_edVendorID", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorID_Vendor_acctName = new PXTextEdit("ctl00_phG_grid_ei", "Vendor Name", grid.Locator, "VendorID_Vendor_acctName");
                    VendorID_Vendor_acctName.DataField = "VendorID_Vendor_acctName";
                    VendorLocationID = new Selector("_ctl00_phG_grid_lv0_edVendorLocationID", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    Location__vLeadTime = new PXNumberEdit("ctl00_phG_grid_en", "Lead Time (Days)", grid.Locator, "Location__vLeadTime");
                    Location__vLeadTime.DataField = "Location__vLeadTime";
                    AddLeadTimeDays = new PXNumberEdit("ctl00_phG_grid_en", "Add. Lead Time (Days)", grid.Locator, "AddLeadTimeDays");
                    AddLeadTimeDays.DataField = "AddLeadTimeDays";
                    Vendor__TermsID = new Selector("_ctl00_phG_grid_lv0_es", "Terms", grid.Locator, "Vendor__TermsID");
                    Vendor__TermsID.DataField = "Vendor__TermsID";
                    Location__vCarrierID = new PXTextEdit("ctl00_phG_grid_em", "Ship Via", grid.Locator, "Location__vCarrierID");
                    Location__vCarrierID.DataField = "Location__vCarrierID";
                    EffPrice = new PXNumberEdit("ctl00_phG_grid_en", "Vendor Price", grid.Locator, "effPrice");
                    EffPrice.DataField = "effPrice";
                    ExtCost = new PXNumberEdit("ctl00_phG_grid_en", "Extended Amt.", grid.Locator, "ExtCost");
                    ExtCost.DataField = "ExtCost";
                    Vendor__CuryID = new Selector("_ctl00_phG_grid_lv0_es", "Currency ID", grid.Locator, "Vendor__CuryID");
                    Vendor__CuryID.DataField = "Vendor__CuryID";
                    SOOrder__CustomerID = new Selector("_ctl00_phG_grid_lv0_edCustomerID", "Customer", grid.Locator, "SOOrder__CustomerID");
                    SOOrder__CustomerID.DataField = "SOOrder__CustomerID";
                    SOOrder__CustomerID_BAccountR_acctName = new PXTextEdit("ctl00_phG_grid_ei", "Customer Name", grid.Locator, "SOOrder__CustomerID_BAccountR_acctName");
                    SOOrder__CustomerID_BAccountR_acctName.DataField = "SOOrder__CustomerID_BAccountR_acctName";
                    SOOrder__CustomerLocationID = new Selector("_ctl00_phG_grid_lv0_es", "Customer Location", grid.Locator, "SOOrder__CustomerLocationID");
                    SOOrder__CustomerLocationID.DataField = "SOOrder__CustomerLocationID";
                    SOLine__UnitPrice = new PXNumberEdit("ctl00_phG_grid_en", "Customer Price", grid.Locator, "SOLine__UnitPrice");
                    SOLine__UnitPrice.DataField = "SOLine__UnitPrice";
                    SOLine__UOM = new Selector("_ctl00_phG_grid_lv0_es", "Customer UOM", grid.Locator, "SOLine__UOM");
                    SOLine__UOM.DataField = "SOLine__UOM";
                    SOOrder__OrderNbr = new Selector("_ctl00_phG_grid_lv0_edSOOrderNbr", "Order Nbr.", grid.Locator, "SOOrder__OrderNbr");
                    SOOrder__OrderNbr.DataField = "SOOrder__OrderNbr";
                    FSRefNbr = new Selector("_ctl00_phG_grid_lv0_edFSRefNbr", "Service Order Nbr.", grid.Locator, "FSRefNbr");
                    FSRefNbr.DataField = "FSRefNbr";
                    ExtWeight = new PXNumberEdit("ctl00_phG_grid_en", "Weight", grid.Locator, "ExtWeight");
                    ExtWeight.DataField = "ExtWeight";
                    ExtVolume = new PXNumberEdit("ctl00_phG_grid_en", "Volume", grid.Locator, "ExtVolume");
                    ExtVolume.DataField = "ExtVolume";
                    PlanID = new PXNumberEdit("ctl00_phG_grid_en", "PlanID", grid.Locator, "PlanID");
                    PlanID.DataField = "PlanID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter PlanType_INPlanType_descr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter InventoryID_InventoryItem_descr { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter POSiteID { get; }
				public PXTextEditColumnFilter POSiteID_description { get; }
				public SelectorColumnFilter SourceSiteID { get; }
				public PXTextEditColumnFilter SourceSiteDescr { get; }
				public PXTextEditColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public DateSelectorColumnFilter PlanDate { get; }
				public SelectorColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorID_Vendor_acctName { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public PXNumberEditColumnFilter Location__vLeadTime { get; }
				public PXNumberEditColumnFilter AddLeadTimeDays { get; }
				public SelectorColumnFilter Vendor__TermsID { get; }
				public PXTextEditColumnFilter Location__vCarrierID { get; }
				public PXNumberEditColumnFilter EffPrice { get; }
				public PXNumberEditColumnFilter ExtCost { get; }
				public SelectorColumnFilter Vendor__CuryID { get; }
				public SelectorColumnFilter SOOrder__CustomerID { get; }
				public PXTextEditColumnFilter SOOrder__CustomerID_BAccountR_acctName { get; }
				public SelectorColumnFilter SOOrder__CustomerLocationID { get; }
				public PXNumberEditColumnFilter SOLine__UnitPrice { get; }
				public SelectorColumnFilter SOLine__UOM { get; }
				public SelectorColumnFilter SOOrder__OrderNbr { get; }
				public InputColumnFilter FSRefNbr { get; }
				public PXNumberEditColumnFilter ExtWeight { get; }
				public PXNumberEditColumnFilter ExtVolume { get; }
				public PXNumberEditColumnFilter PlanID { get; }
                
                public c_grid_header(c_fixeddemand_grid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    PlanType_INPlanType_descr = new PXTextEditColumnFilter(grid.Row.PlanType_INPlanType_descr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    InventoryID_InventoryItem_descr = new PXTextEditColumnFilter(grid.Row.InventoryID_InventoryItem_descr);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    POSiteID = new SelectorColumnFilter(grid.Row.POSiteID);
                    POSiteID_description = new PXTextEditColumnFilter(grid.Row.POSiteID_description);
                    SourceSiteID = new SelectorColumnFilter(grid.Row.SourceSiteID);
                    SourceSiteDescr = new PXTextEditColumnFilter(grid.Row.SourceSiteDescr);
                    UOM = new PXTextEditColumnFilter(grid.Row.UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    PlanDate = new DateSelectorColumnFilter(grid.Row.PlanDate);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    VendorID_Vendor_acctName = new PXTextEditColumnFilter(grid.Row.VendorID_Vendor_acctName);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    Location__vLeadTime = new PXNumberEditColumnFilter(grid.Row.Location__vLeadTime);
                    AddLeadTimeDays = new PXNumberEditColumnFilter(grid.Row.AddLeadTimeDays);
                    Vendor__TermsID = new SelectorColumnFilter(grid.Row.Vendor__TermsID);
                    Location__vCarrierID = new PXTextEditColumnFilter(grid.Row.Location__vCarrierID);
                    EffPrice = new PXNumberEditColumnFilter(grid.Row.EffPrice);
                    ExtCost = new PXNumberEditColumnFilter(grid.Row.ExtCost);
                    Vendor__CuryID = new SelectorColumnFilter(grid.Row.Vendor__CuryID);
                    SOOrder__CustomerID = new SelectorColumnFilter(grid.Row.SOOrder__CustomerID);
                    SOOrder__CustomerID_BAccountR_acctName = new PXTextEditColumnFilter(grid.Row.SOOrder__CustomerID_BAccountR_acctName);
                    SOOrder__CustomerLocationID = new SelectorColumnFilter(grid.Row.SOOrder__CustomerLocationID);
                    SOLine__UnitPrice = new PXNumberEditColumnFilter(grid.Row.SOLine__UnitPrice);
                    SOLine__UOM = new SelectorColumnFilter(grid.Row.SOLine__UOM);
                    SOOrder__OrderNbr = new SelectorColumnFilter(grid.Row.SOOrder__OrderNbr);
                    FSRefNbr = new InputColumnFilter(grid.Row.FSRefNbr);
                    ExtWeight = new PXNumberEditColumnFilter(grid.Row.ExtWeight);
                    ExtVolume = new PXNumberEditColumnFilter(grid.Row.ExtVolume);
                    PlanID = new PXNumberEditColumnFilter(grid.Row.PlanID);
                }
            }
        }
        
        public class c_fixeddemand_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector POSiteID { get; }
			public Label POSiteIDLabel { get; }
			public Selector SourceSiteID { get; }
			public Label SourceSiteIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public DateSelector PlanDate { get; }
			public Label PlanDateLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector SOOrder__CustomerID { get; }
			public Label SOOrder__CustomerIDLabel { get; }
			public Selector SOOrder__OrderNbr { get; }
			public Label SOOrder__OrderNbrLabel { get; }
			public Selector FSRefNbr { get; }
			public Label FSRefNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_fixeddemand_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                POSiteID = new Selector("ctl00_phG_grid_lv0_edPOSiteID", "Warehouse", locator, null);
                POSiteIDLabel = new Label(POSiteID);
                POSiteID.DataField = "POSiteID";
                SourceSiteID = new Selector("ctl00_phG_grid_lv0_edSourceSiteID", "Demand Warehouse", locator, null);
                SourceSiteIDLabel = new Label(SourceSiteID);
                SourceSiteID.DataField = "SourceSiteID";
                VendorLocationID = new Selector("ctl00_phG_grid_lv0_edVendorLocationID", "Location", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                PlanDate = new DateSelector("ctl00_phG_grid_lv0_edPlanDate", "Requested On", locator, null);
                PlanDateLabel = new Label(PlanDate);
                PlanDate.DataField = "PlanDate";
                VendorID = new Selector("ctl00_phG_grid_lv0_edVendorID", "Vendor", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                SOOrder__CustomerID = new Selector("ctl00_phG_grid_lv0_edCustomerID", "Customer", locator, null);
                SOOrder__CustomerIDLabel = new Label(SOOrder__CustomerID);
                SOOrder__CustomerID.DataField = "SOOrder__CustomerID";
                SOOrder__OrderNbr = new Selector("ctl00_phG_grid_lv0_edSOOrderNbr", "Order Nbr.", locator, null);
                SOOrder__OrderNbrLabel = new Label(SOOrder__OrderNbr);
                SOOrder__OrderNbr.DataField = "SOOrder__OrderNbr";
                FSRefNbr = new Selector("ctl00_phG_grid_lv0_edFSRefNbr", "Service Order Nbr.", locator, null);
                FSRefNbrLabel = new Label(FSRefNbr);
                FSRefNbr.DataField = "FSRefNbr";
                Es = new Selector("ctl00_phG_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "FixedDemand";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void POSiteIDEdit()
            {
                Buttons.POSiteIDEdit.Click();
            }
            
            public virtual void SourceSiteIDEdit()
            {
                Buttons.SourceSiteIDEdit.Click();
            }
            
            public virtual void SOOrder__CustomerIDEdit()
            {
                Buttons.SOOrder__CustomerIDEdit.Click();
            }
            
            public virtual void SOOrder__OrderNbrEdit()
            {
                Buttons.SOOrder__OrderNbrEdit.Click();
            }
            
            public virtual void FSRefNbrEdit()
            {
                Buttons.FSRefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
			public Button POSiteIDEdit { get; }
			public Button SourceSiteIDEdit { get; }
			public Button SOOrder__CustomerIDEdit { get; }
			public Button SOOrder__OrderNbrEdit { get; }
			public Button FSRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_grid_lv0_edInventoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "InventoryIDEdit", "ctl00_phG_grid_lv0");
                    InventoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    POSiteIDEdit = new Button("css=div[id=\'ctl00_phG_grid_lv0_edPOSiteID\'] div[class=\'editBtnCont\'] > div > div", "POSiteIDEdit", "ctl00_phG_grid_lv0");
                    POSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SourceSiteIDEdit = new Button("css=div[id=\'ctl00_phG_grid_lv0_edSourceSiteID\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "SourceSiteIDEdit", "ctl00_phG_grid_lv0");
                    SourceSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SOOrder__CustomerIDEdit = new Button("css=div[id=\'ctl00_phG_grid_lv0_edCustomerID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "SOOrder__CustomerIDEdit", "ctl00_phG_grid_lv0");
                    SOOrder__CustomerIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SOOrder__OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_grid_lv0_edSOOrderNbr\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "SOOrder__OrderNbrEdit", "ctl00_phG_grid_lv0");
                    SOOrder__OrderNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    FSRefNbrEdit = new Button("css=div[id=\'ctl00_phG_grid_lv0_edFSRefNbr\'] div[class=\'editBtnCont\'] > div > div", "FSRefNbrEdit", "ctl00_phG_grid_lv0");
                    FSRefNbrEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
