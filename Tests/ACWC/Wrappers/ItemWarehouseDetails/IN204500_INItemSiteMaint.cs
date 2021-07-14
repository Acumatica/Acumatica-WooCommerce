using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Editors.TreeSelector;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ACBC.Tests.Wrappers
{
    
    
    public class IN204500_INItemSiteMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        protected c_itemsiterecord_form Itemsiterecord_form { get; } = new c_itemsiterecord_form("ctl00_phF_form", "itemsiterecord_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_itemsitesettings_tab Itemsitesettings_tab { get; } = new c_itemsitesettings_tab("ctl00_phG_tab", "itemsitesettings_tab");
        protected c_subitemrecords_subrepgrid Subitemrecords_subrepgrid { get; } = new c_subitemrecords_subrepgrid("ctl00_phG_tab_t2_subRepGrid", "subitemrecords_subRepGrid");
        protected c_subitemrecords_lv0 Subitemrecords_lv0 { get; } = new c_subitemrecords_lv0("ctl00_phG_tab_t2_subRepGrid_lv0", "subitemrecords_lv0");
        protected c_preferredvendoritem_preferredform PreferredVendorItem_preferredForm { get; } = new c_preferredvendoritem_preferredform("ctl00_phG_tab_t1_preferredForm", "PreferredVendorItem_preferredForm");
        protected c_amsubitemdefaults_amgridamsubitemdefault AMSubItemDefaults_AMGridAMSubItemDefault { get; } = new c_amsubitemdefaults_amgridamsubitemdefault("ctl00_phG_tab_t4_AMGridAMSubItemDefault", "AMSubItemDefaults_AMGridAMSubItemDefault");
        protected c_amsubitemdefaults_lv0 AMSubItemDefaults_lv0 { get; } = new c_amsubitemdefaults_lv0("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0", "AMSubItemDefaults_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public IN204500_INItemSiteMaint()
        {
            ScreenId = "IN204500";
            ScreenUrl = "/Pages/IN/IN204500.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual IN204500_INItemSiteMaint ReadOne(Gate gate, string InventoryID, string SiteID)
        {
            new BiObject<IN204500_INItemSiteMaint>(gate).ReadOne(this, InventoryID, SiteID);
            return this;
        }
        
        public virtual IN204500_INItemSiteMaint ReadOne(string InventoryID, string SiteID)
        {
            return this.ReadOne(ApiConnection.Source, InventoryID, SiteID);
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
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton ManageAttributes { get; }
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
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                ActivityShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'ActivityShow\']", "Activities", locator, null);
                FilesMenuShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
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
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_itemsiterecord_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public DropDown SiteStatus { get; }
			public Label SiteStatusLabel { get; }
			public CheckBox ProductManagerOverride { get; }
			public Label ProductManagerOverrideLabel { get; }
			public TreeSelector ProductWorkgroupID { get; }
			public Label ProductWorkgroupIDLabel { get; }
			public Selector ProductManagerID { get; }
			public Label ProductManagerIDLabel { get; }
            
            public c_itemsiterecord_form(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phF_form_t0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SiteID = new Selector("ctl00_phF_form_t0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                SiteStatus = new DropDown("ctl00_phF_form_t0_edSiteStatus", "Status", locator, null);
                SiteStatusLabel = new Label(SiteStatus);
                SiteStatus.DataField = "SiteStatus";
                SiteStatus.Items.Add("AC", "Active");
                SiteStatus.Items.Add("IN", "Inactive");
                ProductManagerOverride = new CheckBox("ctl00_phF_form_t0_chkProductManagerOverride", "Override Product Manager", locator, null);
                ProductManagerOverrideLabel = new Label(ProductManagerOverride);
                ProductManagerOverride.DataField = "ProductManagerOverride";
                ProductWorkgroupID = new TreeSelector("ctl00_phF_form_t0_edProductWorkgroupID", "Product Workgroup", locator, null);
                ProductWorkgroupIDLabel = new Label(ProductWorkgroupID);
                ProductWorkgroupID.DataField = "ProductWorkgroupID";
                ProductManagerID = new Selector("ctl00_phF_form_t0_edProductManagerID", "Product Manager", locator, null);
                ProductManagerIDLabel = new Label(ProductManagerID);
                ProductManagerID.DataField = "ProductManagerID";
                DataMemberName = "itemsiterecord";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void SiteIDEdit()
            {
                Buttons.SiteIDEdit.Click();
            }
            
            public virtual void ProductManagerIDEdit()
            {
                Buttons.ProductManagerIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
			public Button SiteIDEdit { get; }
			public Button ProductManagerIDEdit { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edInventoryID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "InventoryIDEdit", "ctl00_phF_form");
                    InventoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SiteIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edSiteID\'] div[class=\'editBtnCont\'] > div > div", "SiteIDEdit", "ctl00_phF_form");
                    SiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ProductManagerIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edProductManagerID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "ProductManagerIDEdit", "ctl00_phF_form");
                    ProductManagerIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c_itemsitesettings_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector DfltShipLocationID { get; }
			public Label DfltShipLocationIDLabel { get; }
			public Selector DfltReceiptLocationID { get; }
			public Label DfltReceiptLocationIDLabel { get; }
			public CheckBox ABCCodeOverride { get; }
			public Label ABCCodeOverrideLabel { get; }
			public Selector ABCCodeID { get; }
			public Label ABCCodeIDLabel { get; }
			public CheckBox ABCCodeIsFixed { get; }
			public Label ABCCodeIsFixedLabel { get; }
			public CheckBox MovementClassOverride { get; }
			public Label MovementClassOverrideLabel { get; }
			public Selector MovementClassID { get; }
			public Label MovementClassIDLabel { get; }
			public CheckBox MovementClassIsFixed { get; }
			public Label MovementClassIsFixedLabel { get; }
			public Selector CountryOfOrigin { get; }
			public Label CountryOfOriginLabel { get; }
			public CheckBox OverrideInvtAcctSub { get; }
			public Label OverrideInvtAcctSubLabel { get; }
			public Selector InvtAcctID { get; }
			public Label InvtAcctIDLabel { get; }
			public Selector InvtSubID { get; }
			public Label InvtSubIDLabel { get; }
			public Selector ReplenishmentClassID { get; }
			public Label ReplenishmentClassIDLabel { get; }
			public CheckBox ReplenishmentPolicyOverride { get; }
			public Label ReplenishmentPolicyOverrideLabel { get; }
			public Selector ReplenishmentPolicyID { get; }
			public Label ReplenishmentPolicyIDLabel { get; }
			public DropDown ReplenishmentSource { get; }
			public Label ReplenishmentSourceLabel { get; }
			public DropDown ReplenishmentMethod { get; }
			public Label ReplenishmentMethodLabel { get; }
			public Selector ReplenishmentSourceSiteID { get; }
			public Label ReplenishmentSourceSiteIDLabel { get; }
			public PXNumberEdit MaxShelfLife { get; }
			public Label MaxShelfLifeLabel { get; }
			public CheckBox MaxShelfLifeOverride { get; }
			public Label MaxShelfLifeOverrideLabel { get; }
			public DateSelector LaunchDate { get; }
			public Label LaunchDateLabel { get; }
			public CheckBox LaunchDateOverride { get; }
			public Label LaunchDateOverrideLabel { get; }
			public DateSelector TerminationDate { get; }
			public Label TerminationDateLabel { get; }
			public CheckBox TerminationDateOverride { get; }
			public Label TerminationDateOverrideLabel { get; }
			public PXNumberEdit ServiceLevelPct { get; }
			public Label ServiceLevelPctLabel { get; }
			public CheckBox ServiceLevelOverride { get; }
			public Label ServiceLevelOverrideLabel { get; }
			public PXNumberEdit SafetyStock { get; }
			public Label SafetyStockLabel { get; }
			public CheckBox SafetyStockOverride { get; }
			public Label SafetyStockOverrideLabel { get; }
			public PXNumberEdit MinQty { get; }
			public Label MinQtyLabel { get; }
			public CheckBox MinQtyOverride { get; }
			public Label MinQtyOverrideLabel { get; }
			public PXNumberEdit MaxQty { get; }
			public Label MaxQtyLabel { get; }
			public CheckBox MaxQtyOverride { get; }
			public Label MaxQtyOverrideLabel { get; }
			public PXNumberEdit TransferERQ { get; }
			public Label TransferERQLabel { get; }
			public CheckBox TransferERQOverride { get; }
			public Label TransferERQOverrideLabel { get; }
			public PXNumberEdit DemandPerDayAverage { get; }
			public Label DemandPerDayAverageLabel { get; }
			public PXNumberEdit DemandPerDaySTDEV { get; }
			public Label DemandPerDaySTDEVLabel { get; }
			public PXNumberEdit LeadTimeAverage { get; }
			public Label LeadTimeAverageLabel { get; }
			public PXNumberEdit LeadTimeSTDEV { get; }
			public Label LeadTimeSTDEVLabel { get; }
			public PXNumberEdit SafetyStockSuggested { get; }
			public Label SafetyStockSuggestedLabel { get; }
			public PXNumberEdit MinQtySuggested { get; }
			public Label MinQtySuggestedLabel { get; }
			public DateSelector LastForecastDate { get; }
			public Label LastForecastDateLabel { get; }
			public CheckBox PreferredVendorOverride { get; }
			public Label PreferredVendorOverrideLabel { get; }
			public Selector PreferredVendorID { get; }
			public Label PreferredVendorIDLabel { get; }
			public Selector PreferredVendorLocationID { get; }
			public Label PreferredVendorLocationIDLabel { get; }
			public Selector InventoryItem__DefaultSubItemID { get; }
			public Label InventoryItem__DefaultSubItemIDLabel { get; }
			public CheckBox SubItemOverride { get; }
			public Label SubItemOverrideLabel { get; }
			public CheckBox StdCostOverride { get; }
			public Label StdCostOverrideLabel { get; }
			public PXNumberEdit LastStdCost { get; }
			public Label LastStdCostLabel { get; }
			public PXNumberEdit StdCost { get; }
			public Label StdCostLabel { get; }
			public DateSelector StdCostDate { get; }
			public Label StdCostDateLabel { get; }
			public PXNumberEdit PendingStdCost { get; }
			public Label PendingStdCostLabel { get; }
			public DateSelector PendingStdCostDate { get; }
			public Label PendingStdCostDateLabel { get; }
			public TreeSelector PriceWorkgroupID { get; }
			public Label PriceWorkgroupIDLabel { get; }
			public Selector PriceManagerID { get; }
			public Label PriceManagerIDLabel { get; }
			public CheckBox Commissionable { get; }
			public Label CommissionableLabel { get; }
			public CheckBox MarkupPctOverride { get; }
			public Label MarkupPctOverrideLabel { get; }
			public PXNumberEdit MarkupPct { get; }
			public Label MarkupPctLabel { get; }
			public CheckBox RecPriceOverride { get; }
			public Label RecPriceOverrideLabel { get; }
			public PXNumberEdit RecPrice { get; }
			public Label RecPriceLabel { get; }
			public PXNumberEdit LastCost { get; }
			public Label LastCostLabel { get; }
			public PXNumberEdit AvgCost { get; }
			public Label AvgCostLabel { get; }
			public PXNumberEdit MinCost { get; }
			public Label MinCostLabel { get; }
			public PXNumberEdit MaxCost { get; }
			public Label MaxCostLabel { get; }
			public Selector AMBOMID { get; }
			public Label AMBOMIDLabel { get; }
			public Selector AMPlanningBOMID { get; }
			public Label AMPlanningBOMIDLabel { get; }
			public Selector AMConfigurationID { get; }
			public Label AMConfigurationIDLabel { get; }
			public PXNumberEdit AMGroupWindow { get; }
			public Label AMGroupWindowLabel { get; }
			public CheckBox AMGroupWindowOverride { get; }
			public Label AMGroupWindowOverrideLabel { get; }
			public DropDown AMReplenishmentSource { get; }
			public Label AMReplenishmentSourceLabel { get; }
			public CheckBox AMReplenishmentPolicyOverride { get; }
			public Label AMReplenishmentPolicyOverrideLabel { get; }
			public PXNumberEdit AMSafetyStock { get; }
			public Label AMSafetyStockLabel { get; }
			public CheckBox AMSafetyStockOverride { get; }
			public Label AMSafetyStockOverrideLabel { get; }
			public PXNumberEdit AMMinQty { get; }
			public Label AMMinQtyLabel { get; }
			public CheckBox AMMinQtyOverride { get; }
			public Label AMMinQtyOverrideLabel { get; }
			public PXNumberEdit AMMinOrdQty { get; }
			public Label AMMinOrdQtyLabel { get; }
			public CheckBox AMMinOrdQtyOverride { get; }
			public Label AMMinOrdQtyOverrideLabel { get; }
			public PXNumberEdit AMMaxOrdQty { get; }
			public Label AMMaxOrdQtyLabel { get; }
			public CheckBox AMMaxOrdQtyOverride { get; }
			public Label AMMaxOrdQtyOverrideLabel { get; }
			public PXNumberEdit AMLotSize { get; }
			public Label AMLotSizeLabel { get; }
			public CheckBox AMLotSizeOverride { get; }
			public Label AMLotSizeOverrideLabel { get; }
			public PXNumberEdit AMMFGLeadTime { get; }
			public Label AMMFGLeadTimeLabel { get; }
			public CheckBox AMMFGLeadTimeOverride { get; }
			public Label AMMFGLeadTimeOverrideLabel { get; }
			public CheckBox AMScrapOverride { get; }
			public Label AMScrapOverrideLabel { get; }
			public Selector AMScrapSiteID { get; }
			public Label AMScrapSiteIDLabel { get; }
			public Selector AMScrapLocationID { get; }
			public Label AMScrapLocationIDLabel { get; }
            
            public c_itemsitesettings_tab(string locator, string name) : 
                    base(locator, name)
            {
                DfltShipLocationID = new Selector("ctl00_phG_tab_t0_edDfltShipLocationID", "Default Issue From", locator, null);
                DfltShipLocationIDLabel = new Label(DfltShipLocationID);
                DfltShipLocationID.DataField = "DfltShipLocationID";
                DfltReceiptLocationID = new Selector("ctl00_phG_tab_t0_edDfltReceiptLocationID", "Default Receipt To", locator, null);
                DfltReceiptLocationIDLabel = new Label(DfltReceiptLocationID);
                DfltReceiptLocationID.DataField = "DfltReceiptLocationID";
                ABCCodeOverride = new CheckBox("ctl00_phG_tab_t0_chkABCCodeOverride", "ABC Code Override", locator, null);
                ABCCodeOverrideLabel = new Label(ABCCodeOverride);
                ABCCodeOverride.DataField = "ABCCodeOverride";
                ABCCodeID = new Selector("ctl00_phG_tab_t0_edABCCodeID", "ABC Code", locator, null);
                ABCCodeIDLabel = new Label(ABCCodeID);
                ABCCodeID.DataField = "ABCCodeID";
                ABCCodeIsFixed = new CheckBox("ctl00_phG_tab_t0_chkABCCodeIsFixed", "Fixed ABC Code", locator, null);
                ABCCodeIsFixedLabel = new Label(ABCCodeIsFixed);
                ABCCodeIsFixed.DataField = "ABCCodeIsFixed";
                MovementClassOverride = new CheckBox("ctl00_phG_tab_t0_chkMovementClassOverride", "Movement Class Override", locator, null);
                MovementClassOverrideLabel = new Label(MovementClassOverride);
                MovementClassOverride.DataField = "MovementClassOverride";
                MovementClassID = new Selector("ctl00_phG_tab_t0_edMovementClassID", "Movement Class", locator, null);
                MovementClassIDLabel = new Label(MovementClassID);
                MovementClassID.DataField = "MovementClassID";
                MovementClassIsFixed = new CheckBox("ctl00_phG_tab_t0_chkMovementClassIsFixed", "Fixed Movement Class", locator, null);
                MovementClassIsFixedLabel = new Label(MovementClassIsFixed);
                MovementClassIsFixed.DataField = "MovementClassIsFixed";
                CountryOfOrigin = new Selector("ctl00_phG_tab_t0_edCountryOfOrigin", "Country Of Origin", locator, null);
                CountryOfOriginLabel = new Label(CountryOfOrigin);
                CountryOfOrigin.DataField = "CountryOfOrigin";
                OverrideInvtAcctSub = new CheckBox("ctl00_phG_tab_t0_chkOverrideInvtAcctSub", "Override Inventory Account/Sub.", locator, null);
                OverrideInvtAcctSubLabel = new Label(OverrideInvtAcctSub);
                OverrideInvtAcctSub.DataField = "OverrideInvtAcctSub";
                InvtAcctID = new Selector("ctl00_phG_tab_t0_edInvtAcctID", "Inventory Account", locator, null);
                InvtAcctIDLabel = new Label(InvtAcctID);
                InvtAcctID.DataField = "InvtAcctID";
                InvtSubID = new Selector("ctl00_phG_tab_t0_edInvtSubID", "Inventory Sub.", locator, null);
                InvtSubIDLabel = new Label(InvtSubID);
                InvtSubID.DataField = "InvtSubID";
                ReplenishmentClassID = new Selector("ctl00_phG_tab_t1_edReplenishmentClassID", "Replenishment Class", locator, null);
                ReplenishmentClassIDLabel = new Label(ReplenishmentClassID);
                ReplenishmentClassID.DataField = "ReplenishmentClassID";
                ReplenishmentPolicyOverride = new CheckBox("ctl00_phG_tab_t1_chkReplenishmentPolicyOverride", "Override Replenishment Settings", locator, null);
                ReplenishmentPolicyOverrideLabel = new Label(ReplenishmentPolicyOverride);
                ReplenishmentPolicyOverride.DataField = "ReplenishmentPolicyOverride";
                ReplenishmentPolicyID = new Selector("ctl00_phG_tab_t1_edReplenishmentPolicyID", "Seasonality", locator, null);
                ReplenishmentPolicyIDLabel = new Label(ReplenishmentPolicyID);
                ReplenishmentPolicyID.DataField = "ReplenishmentPolicyID";
                ReplenishmentSource = new DropDown("ctl00_phG_tab_t1_edReplenishmentSource", "Replenishment Source", locator, null);
                ReplenishmentSourceLabel = new Label(ReplenishmentSource);
                ReplenishmentSource.DataField = "ReplenishmentSource";
                ReplenishmentSource.Items.Add("N", "None");
                ReplenishmentSource.Items.Add("P", "Purchase");
                ReplenishmentSource.Items.Add("M", "Manufacturing");
                ReplenishmentSource.Items.Add("T", "Transfer");
                ReplenishmentSource.Items.Add("D", "Drop-Shipment");
                ReplenishmentSource.Items.Add("O", "Purchase to Order");
                ReplenishmentMethod = new DropDown("ctl00_phG_tab_t1_edReplenishmentMethod", "Replenishment Method", locator, null);
                ReplenishmentMethodLabel = new Label(ReplenishmentMethod);
                ReplenishmentMethod.DataField = "ReplenishmentMethod";
                ReplenishmentMethod.Items.Add("N", "None");
                ReplenishmentMethod.Items.Add("M", "Min./Max.");
                ReplenishmentMethod.Items.Add("F", "Fixed Reorder Qty");
                ReplenishmentSourceSiteID = new Selector("ctl00_phG_tab_t1_edReplenishmentSourceSiteID", "Replenishment Warehouse", locator, null);
                ReplenishmentSourceSiteIDLabel = new Label(ReplenishmentSourceSiteID);
                ReplenishmentSourceSiteID.DataField = "ReplenishmentSourceSiteID";
                MaxShelfLife = new PXNumberEdit("ctl00_phG_tab_t1_edMaxShelfLife", "Max. Shelf Life (Days)", locator, null);
                MaxShelfLifeLabel = new Label(MaxShelfLife);
                MaxShelfLife.DataField = "MaxShelfLife";
                MaxShelfLifeOverride = new CheckBox("ctl00_phG_tab_t1_chkMaxShelfLifeOverride", "Override", locator, null);
                MaxShelfLifeOverrideLabel = new Label(MaxShelfLifeOverride);
                MaxShelfLifeOverride.DataField = "MaxShelfLifeOverride";
                LaunchDate = new DateSelector("ctl00_phG_tab_t1_edLaunchDate", "Launch Date", locator, null);
                LaunchDateLabel = new Label(LaunchDate);
                LaunchDate.DataField = "LaunchDate";
                LaunchDateOverride = new CheckBox("ctl00_phG_tab_t1_chkLaunchDateOverride", "Override", locator, null);
                LaunchDateOverrideLabel = new Label(LaunchDateOverride);
                LaunchDateOverride.DataField = "LaunchDateOverride";
                TerminationDate = new DateSelector("ctl00_phG_tab_t1_edTerminationDate", "Termination Date", locator, null);
                TerminationDateLabel = new Label(TerminationDate);
                TerminationDate.DataField = "TerminationDate";
                TerminationDateOverride = new CheckBox("ctl00_phG_tab_t1_chkTerminationDateOverride", "Override", locator, null);
                TerminationDateOverrideLabel = new Label(TerminationDateOverride);
                TerminationDateOverride.DataField = "TerminationDateOverride";
                ServiceLevelPct = new PXNumberEdit("ctl00_phG_tab_t1_edServiceLevelPct", "Service Level (%)", locator, null);
                ServiceLevelPctLabel = new Label(ServiceLevelPct);
                ServiceLevelPct.DataField = "ServiceLevelPct";
                ServiceLevelOverride = new CheckBox("ctl00_phG_tab_t1_chkServiceLevelOverride", "Override", locator, null);
                ServiceLevelOverrideLabel = new Label(ServiceLevelOverride);
                ServiceLevelOverride.DataField = "ServiceLevelOverride";
                SafetyStock = new PXNumberEdit("ctl00_phG_tab_t1_edSafetyStock", "Safety Stock", locator, null);
                SafetyStockLabel = new Label(SafetyStock);
                SafetyStock.DataField = "SafetyStock";
                SafetyStockOverride = new CheckBox("ctl00_phG_tab_t1_chkSafetyStockOverride", "Override", locator, null);
                SafetyStockOverrideLabel = new Label(SafetyStockOverride);
                SafetyStockOverride.DataField = "SafetyStockOverride";
                MinQty = new PXNumberEdit("ctl00_phG_tab_t1_edMinQty", "Reorder Point", locator, null);
                MinQtyLabel = new Label(MinQty);
                MinQty.DataField = "MinQty";
                MinQtyOverride = new CheckBox("ctl00_phG_tab_t1_chkMinQtyOverride", "Override", locator, null);
                MinQtyOverrideLabel = new Label(MinQtyOverride);
                MinQtyOverride.DataField = "MinQtyOverride";
                MaxQty = new PXNumberEdit("ctl00_phG_tab_t1_edMaxQty", "Max Qty.", locator, null);
                MaxQtyLabel = new Label(MaxQty);
                MaxQty.DataField = "MaxQty";
                MaxQtyOverride = new CheckBox("ctl00_phG_tab_t1_chkMaxQtyOverride", "Override", locator, null);
                MaxQtyOverrideLabel = new Label(MaxQtyOverride);
                MaxQtyOverride.DataField = "MaxQtyOverride";
                TransferERQ = new PXNumberEdit("ctl00_phG_tab_t1_edTransferERQ", "Transfer ERQ", locator, null);
                TransferERQLabel = new Label(TransferERQ);
                TransferERQ.DataField = "TransferERQ";
                TransferERQOverride = new CheckBox("ctl00_phG_tab_t1_chkTransferERQOverride", "Override", locator, null);
                TransferERQOverrideLabel = new Label(TransferERQOverride);
                TransferERQOverride.DataField = "TransferERQOverride";
                DemandPerDayAverage = new PXNumberEdit("ctl00_phG_tab_t1_edDemandPerDayAverage", "Daily Demand Forecast", locator, null);
                DemandPerDayAverageLabel = new Label(DemandPerDayAverage);
                DemandPerDayAverage.DataField = "DemandPerDayAverage";
                DemandPerDaySTDEV = new PXNumberEdit("ctl00_phG_tab_t1_edDemandPerDaySTDEV", "Daily Demand Forecast Error(STDEV)", locator, null);
                DemandPerDaySTDEVLabel = new Label(DemandPerDaySTDEV);
                DemandPerDaySTDEV.DataField = "DemandPerDaySTDEV";
                LeadTimeAverage = new PXNumberEdit("ctl00_phG_tab_t1_edLeadTimeAverage", "Lead Time Average", locator, null);
                LeadTimeAverageLabel = new Label(LeadTimeAverage);
                LeadTimeAverage.DataField = "LeadTimeAverage";
                LeadTimeSTDEV = new PXNumberEdit("ctl00_phG_tab_t1_edLeadTimeSTDEV", "Lead Time STDEV", locator, null);
                LeadTimeSTDEVLabel = new Label(LeadTimeSTDEV);
                LeadTimeSTDEV.DataField = "LeadTimeSTDEV";
                SafetyStockSuggested = new PXNumberEdit("ctl00_phG_tab_t1_edSafetyStockSuggested", "Safety Stock Suggested", locator, null);
                SafetyStockSuggestedLabel = new Label(SafetyStockSuggested);
                SafetyStockSuggested.DataField = "SafetyStockSuggested";
                MinQtySuggested = new PXNumberEdit("ctl00_phG_tab_t1_edMinQtySuggested", "Reorder Point Suggested", locator, null);
                MinQtySuggestedLabel = new Label(MinQtySuggested);
                MinQtySuggested.DataField = "MinQtySuggested";
                LastForecastDate = new DateSelector("ctl00_phG_tab_t1_edLastForecastDate", "Last Forecast Date", locator, null);
                LastForecastDateLabel = new Label(LastForecastDate);
                LastForecastDate.DataField = "LastForecastDate";
                PreferredVendorOverride = new CheckBox("ctl00_phG_tab_t1_chkPreferredVendorOverride", "Override Preferred Vendor", locator, null);
                PreferredVendorOverrideLabel = new Label(PreferredVendorOverride);
                PreferredVendorOverride.DataField = "PreferredVendorOverride";
                PreferredVendorID = new Selector("ctl00_phG_tab_t1_edPreferredVendorID", "Preferred Vendor", locator, null);
                PreferredVendorIDLabel = new Label(PreferredVendorID);
                PreferredVendorID.DataField = "PreferredVendorID";
                PreferredVendorLocationID = new Selector("ctl00_phG_tab_t1_edPreferredVendorLocationID", "Preferred Location", locator, null);
                PreferredVendorLocationIDLabel = new Label(PreferredVendorLocationID);
                PreferredVendorLocationID.DataField = "PreferredVendorLocationID";
                InventoryItem__DefaultSubItemID = new Selector("ctl00_phG_tab_t1_edInventoryItem__DefaultSubItemID", "Default Subitem", locator, null);
                InventoryItem__DefaultSubItemIDLabel = new Label(InventoryItem__DefaultSubItemID);
                InventoryItem__DefaultSubItemID.DataField = "InventoryItem__DefaultSubItemID";
                SubItemOverride = new CheckBox("ctl00_phG_tab_t2_chkSubItemOverride", "Override", locator, null);
                SubItemOverrideLabel = new Label(SubItemOverride);
                SubItemOverride.DataField = "SubItemOverride";
                StdCostOverride = new CheckBox("ctl00_phG_tab_t3_chkStdCostOverride", "Override Std. Cost", locator, null);
                StdCostOverrideLabel = new Label(StdCostOverride);
                StdCostOverride.DataField = "StdCostOverride";
                LastStdCost = new PXNumberEdit("ctl00_phG_tab_t3_edLastStdCost", "Last Cost", locator, null);
                LastStdCostLabel = new Label(LastStdCost);
                LastStdCost.DataField = "LastStdCost";
                StdCost = new PXNumberEdit("ctl00_phG_tab_t3_edStdCost", "Current Cost", locator, null);
                StdCostLabel = new Label(StdCost);
                StdCost.DataField = "StdCost";
                StdCostDate = new DateSelector("ctl00_phG_tab_t3_edStdCostDate", "Effective Date", locator, null);
                StdCostDateLabel = new Label(StdCostDate);
                StdCostDate.DataField = "StdCostDate";
                PendingStdCost = new PXNumberEdit("ctl00_phG_tab_t3_edPendingStdCost", "Pending Cost", locator, null);
                PendingStdCostLabel = new Label(PendingStdCost);
                PendingStdCost.DataField = "PendingStdCost";
                PendingStdCostDate = new DateSelector("ctl00_phG_tab_t3_edPendingStdCostDate", "Pending Cost Date", locator, null);
                PendingStdCostDateLabel = new Label(PendingStdCostDate);
                PendingStdCostDate.DataField = "PendingStdCostDate";
                PriceWorkgroupID = new TreeSelector("ctl00_phG_tab_t3_edPriceWorkgroupID", "Price Workgroup", locator, null);
                PriceWorkgroupIDLabel = new Label(PriceWorkgroupID);
                PriceWorkgroupID.DataField = "PriceWorkgroupID";
                PriceManagerID = new Selector("ctl00_phG_tab_t3_edPriceManagerID", "Price Manager", locator, null);
                PriceManagerIDLabel = new Label(PriceManagerID);
                PriceManagerID.DataField = "PriceManagerID";
                Commissionable = new CheckBox("ctl00_phG_tab_t3_chkCommisionable", "Subject to Commission", locator, null);
                CommissionableLabel = new Label(Commissionable);
                Commissionable.DataField = "Commissionable";
                MarkupPctOverride = new CheckBox("ctl00_phG_tab_t3_chkMarkupPctOverride", "Override Markup %", locator, null);
                MarkupPctOverrideLabel = new Label(MarkupPctOverride);
                MarkupPctOverride.DataField = "MarkupPctOverride";
                MarkupPct = new PXNumberEdit("ctl00_phG_tab_t3_edMarkupPct", "Markup %", locator, null);
                MarkupPctLabel = new Label(MarkupPct);
                MarkupPct.DataField = "MarkupPct";
                RecPriceOverride = new CheckBox("ctl00_phG_tab_t3_chkRecPriceOverride", "Override Price", locator, null);
                RecPriceOverrideLabel = new Label(RecPriceOverride);
                RecPriceOverride.DataField = "RecPriceOverride";
                RecPrice = new PXNumberEdit("ctl00_phG_tab_t3_edRecPrice", "MSRP", locator, null);
                RecPriceLabel = new Label(RecPrice);
                RecPrice.DataField = "RecPrice";
                LastCost = new PXNumberEdit("ctl00_phG_tab_t3_edLastCost", "Last Cost", locator, null);
                LastCostLabel = new Label(LastCost);
                LastCost.DataField = "LastCost";
                AvgCost = new PXNumberEdit("ctl00_phG_tab_t3_edAvgCost", "Average Cost", locator, null);
                AvgCostLabel = new Label(AvgCost);
                AvgCost.DataField = "AvgCost";
                MinCost = new PXNumberEdit("ctl00_phG_tab_t3_edMinCost", "Min. Cost", locator, null);
                MinCostLabel = new Label(MinCost);
                MinCost.DataField = "MinCost";
                MaxCost = new PXNumberEdit("ctl00_phG_tab_t3_edMaxCost", "Max. Cost", locator, null);
                MaxCostLabel = new Label(MaxCost);
                MaxCost.DataField = "MaxCost";
                AMBOMID = new Selector("ctl00_phG_tab_t4_edAMBOMID", "Default BOM ID", locator, null);
                AMBOMIDLabel = new Label(AMBOMID);
                AMBOMID.DataField = "AMBOMID";
                AMPlanningBOMID = new Selector("ctl00_phG_tab_t4_edAMPlanningBOMID", "Planning BOM ID", locator, null);
                AMPlanningBOMIDLabel = new Label(AMPlanningBOMID);
                AMPlanningBOMID.DataField = "AMPlanningBOMID";
                AMConfigurationID = new Selector("ctl00_phG_tab_t4_edAMConfigurationID", "Configuration ID", locator, null);
                AMConfigurationIDLabel = new Label(AMConfigurationID);
                AMConfigurationID.DataField = "AMConfigurationID";
                AMGroupWindow = new PXNumberEdit("ctl00_phG_tab_t4_edAMGroupWindow", "Group Planning", locator, null);
                AMGroupWindowLabel = new Label(AMGroupWindow);
                AMGroupWindow.DataField = "AMGroupWindow";
                AMGroupWindowOverride = new CheckBox("ctl00_phG_tab_t4_chkAMGroupWindowOverride", "Override", locator, null);
                AMGroupWindowOverrideLabel = new Label(AMGroupWindowOverride);
                AMGroupWindowOverride.DataField = "AMGroupWindowOverride";
                AMReplenishmentSource = new DropDown("ctl00_phG_tab_t4_edAMReplenishmentSource", "Source", locator, null);
                AMReplenishmentSourceLabel = new Label(AMReplenishmentSource);
                AMReplenishmentSource.DataField = "AMReplenishmentSource";
                AMReplenishmentPolicyOverride = new CheckBox("ctl00_phG_tab_t4_chkAMReplenishmentPolicyOverride", "Override", locator, null);
                AMReplenishmentPolicyOverrideLabel = new Label(AMReplenishmentPolicyOverride);
                AMReplenishmentPolicyOverride.DataField = "AMReplenishmentPolicyOverride";
                AMSafetyStock = new PXNumberEdit("ctl00_phG_tab_t4_edAMSafetyStock", "Safety Stock", locator, null);
                AMSafetyStockLabel = new Label(AMSafetyStock);
                AMSafetyStock.DataField = "AMSafetyStock";
                AMSafetyStockOverride = new CheckBox("ctl00_phG_tab_t4_chkAMSafetyStockOverride", "Override", locator, null);
                AMSafetyStockOverrideLabel = new Label(AMSafetyStockOverride);
                AMSafetyStockOverride.DataField = "AMSafetyStockOverride";
                AMMinQty = new PXNumberEdit("ctl00_phG_tab_t4_edAMMinQty", "Reorder Point", locator, null);
                AMMinQtyLabel = new Label(AMMinQty);
                AMMinQty.DataField = "AMMinQty";
                AMMinQtyOverride = new CheckBox("ctl00_phG_tab_t4_chkAMMinQtyOverride", "Override", locator, null);
                AMMinQtyOverrideLabel = new Label(AMMinQtyOverride);
                AMMinQtyOverride.DataField = "AMMinQtyOverride";
                AMMinOrdQty = new PXNumberEdit("ctl00_phG_tab_t4_edAMMinOrdQty", "Min Order Qty", locator, null);
                AMMinOrdQtyLabel = new Label(AMMinOrdQty);
                AMMinOrdQty.DataField = "AMMinOrdQty";
                AMMinOrdQtyOverride = new CheckBox("ctl00_phG_tab_t4_chkAMMinOrdQtyOverride", "Override", locator, null);
                AMMinOrdQtyOverrideLabel = new Label(AMMinOrdQtyOverride);
                AMMinOrdQtyOverride.DataField = "AMMinOrdQtyOverride";
                AMMaxOrdQty = new PXNumberEdit("ctl00_phG_tab_t4_edAMMaxOrdQty", "Max Order Qty", locator, null);
                AMMaxOrdQtyLabel = new Label(AMMaxOrdQty);
                AMMaxOrdQty.DataField = "AMMaxOrdQty";
                AMMaxOrdQtyOverride = new CheckBox("ctl00_phG_tab_t4_chkAMMaxOrdQtyOverride", "Override", locator, null);
                AMMaxOrdQtyOverrideLabel = new Label(AMMaxOrdQtyOverride);
                AMMaxOrdQtyOverride.DataField = "AMMaxOrdQtyOverride";
                AMLotSize = new PXNumberEdit("ctl00_phG_tab_t4_edAMLotSize", "Lot Size", locator, null);
                AMLotSizeLabel = new Label(AMLotSize);
                AMLotSize.DataField = "AMLotSize";
                AMLotSizeOverride = new CheckBox("ctl00_phG_tab_t4_chkAMLotSizeOverride", "Override", locator, null);
                AMLotSizeOverrideLabel = new Label(AMLotSizeOverride);
                AMLotSizeOverride.DataField = "AMLotSizeOverride";
                AMMFGLeadTime = new PXNumberEdit("ctl00_phG_tab_t4_edAMMFGLeadTime", "MFG Lead Time", locator, null);
                AMMFGLeadTimeLabel = new Label(AMMFGLeadTime);
                AMMFGLeadTime.DataField = "AMMFGLeadTime";
                AMMFGLeadTimeOverride = new CheckBox("ctl00_phG_tab_t4_chkAMMFGLeadTimeOverride", "Override", locator, null);
                AMMFGLeadTimeOverrideLabel = new Label(AMMFGLeadTimeOverride);
                AMMFGLeadTimeOverride.DataField = "AMMFGLeadTimeOverride";
                AMScrapOverride = new CheckBox("ctl00_phG_tab_t4_edAMScrapOverride", "Scrap Override", locator, null);
                AMScrapOverrideLabel = new Label(AMScrapOverride);
                AMScrapOverride.DataField = "AMScrapOverride";
                AMScrapSiteID = new Selector("ctl00_phG_tab_t4_edAMScrapSiteID", "Scrap Warehouse", locator, null);
                AMScrapSiteIDLabel = new Label(AMScrapSiteID);
                AMScrapSiteID.DataField = "AMScrapSiteID";
                AMScrapLocationID = new Selector("ctl00_phG_tab_t4_edAMScrapLocationID", "Location", locator, null);
                AMScrapLocationIDLabel = new Label(AMScrapLocationID);
                AMScrapLocationID.DataField = "AMScrapLocationID";
                DataMemberName = "itemsitesettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DfltShipLocationIDEdit()
            {
                Buttons.DfltShipLocationIDEdit.Click();
            }
            
            public virtual void DfltReceiptLocationIDEdit()
            {
                Buttons.DfltReceiptLocationIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public virtual void InvtAcctIDEdit()
            {
                Buttons.InvtAcctIDEdit.Click();
            }
            
            public virtual void PreferredVendorIDEdit()
            {
                Buttons.PreferredVendorIDEdit.Click();
            }
            
            public virtual void PriceManagerIDEdit()
            {
                Buttons.PriceManagerIDEdit.Click();
            }
            
            public virtual void AMBOMIDEdit()
            {
                Buttons.AMBOMIDEdit.Click();
            }
            
            public virtual void AMPlanningBOMIDEdit()
            {
                Buttons.AMPlanningBOMIDEdit.Click();
            }
            
            public virtual void AMConfigurationIDEdit()
            {
                Buttons.AMConfigurationIDEdit.Click();
            }
            
            public virtual void AMScrapSiteIDEdit()
            {
                Buttons.AMScrapSiteIDEdit.Click();
            }
            
            public virtual void AMScrapLocationIDEdit()
            {
                Buttons.AMScrapLocationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DfltShipLocationIDEdit { get; }
			public Button DfltReceiptLocationIDEdit { get; }
			public Button MovementClassIDEdit { get; }
			public Button InvtAcctIDEdit { get; }
			public Button PreferredVendorIDEdit { get; }
			public Button PriceManagerIDEdit { get; }
			public Button AMBOMIDEdit { get; }
			public Button AMPlanningBOMIDEdit { get; }
			public Button AMConfigurationIDEdit { get; }
			public Button AMScrapSiteIDEdit { get; }
			public Button AMScrapLocationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DfltShipLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edDfltShipLocationID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "DfltShipLocationIDEdit", "ctl00_phG_tab");
                    DfltShipLocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DfltReceiptLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edDfltReceiptLocationID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DfltReceiptLocationIDEdit", "ctl00_phG_tab");
                    DfltReceiptLocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab");
                    MovementClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    InvtAcctIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edInvtAcctID\'] div[class=\'editBtnCont\'] > div > div", "InvtAcctIDEdit", "ctl00_phG_tab");
                    InvtAcctIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PreferredVendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edPreferredVendorID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "PreferredVendorIDEdit", "ctl00_phG_tab");
                    PreferredVendorIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PriceManagerIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_edPriceManagerID\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "PriceManagerIDEdit", "ctl00_phG_tab");
                    PriceManagerIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMBOMIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMBOMID\'] div[class=\'editBtnCont\'] > div > div", "AMBOMIDEdit", "ctl00_phG_tab");
                    AMBOMIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMPlanningBOMIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMPlanningBOMID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "AMPlanningBOMIDEdit", "ctl00_phG_tab");
                    AMPlanningBOMIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMConfigurationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMConfigurationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMConfigurationIDEdit", "ctl00_phG_tab");
                    AMConfigurationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMScrapSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMScrapSiteID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "AMScrapSiteIDEdit", "ctl00_phG_tab");
                    AMScrapSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMScrapLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMScrapLocationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMScrapLocationIDEdit", "ctl00_phG_tab");
                    AMScrapLocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_subitemrecords_subrepgrid : Grid<c_subitemrecords_subrepgrid.c_grid_row, c_subitemrecords_subrepgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_subitemrecords_subrepgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_subRepGrid");
                DataMemberName = "subitemrecords";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_subRepGrid_fe_gf", "FilterForm");
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
            
            public virtual void UpdateReplenishment()
            {
                ToolBar.UpdateReplenishment.Click();
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
			public ToolBarButtonGrid UpdateReplenishment { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    UpdateReplenishment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_at_tlb div[data-cmd=\'UpdateReplenishment\']", "Default Settings", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_subRepGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SubItemID { get; }
			public PXNumberEdit SafetyStock { get; }
			public PXNumberEdit MinQty { get; }
			public PXNumberEdit MaxQty { get; }
			public PXNumberEdit TransferERQ { get; }
			public PXNumberEdit SafetyStockSuggested { get; }
			public PXNumberEdit MinQtySuggested { get; }
			public PXNumberEdit MaxQtySuggested { get; }
			public PXNumberEdit DemandPerDayAverage { get; }
			public PXNumberEdit DemandPerDaySTDEV { get; }
			public DropDown ItemStatus { get; }
			public Selector InventoryID { get; }
			public Selector SiteID { get; }
                
                public c_grid_row(c_subitemrecords_subrepgrid grid) : 
                        base(grid)
                {
                    SubItemID = new Selector("_ctl00_phG_tab_t2_subRepGrid_lv0_edSubRSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SafetyStock = new PXNumberEdit("_ctl00_phG_tab_t2_subRepGrid_lv0_edSubRSafetyStock", "Safety Stock", grid.Locator, "SafetyStock");
                    SafetyStock.DataField = "SafetyStock";
                    MinQty = new PXNumberEdit("_ctl00_phG_tab_t2_subRepGrid_lv0_edSubRMinQty", "Reorder Point", grid.Locator, "MinQty");
                    MinQty.DataField = "MinQty";
                    MaxQty = new PXNumberEdit("_ctl00_phG_tab_t2_subRepGrid_lv0_edSubRMaxQty", "Max Qty.", grid.Locator, "MaxQty");
                    MaxQty.DataField = "MaxQty";
                    TransferERQ = new PXNumberEdit("_ctl00_phG_tab_t2_subRepGrid_lv0_edSubRTransferERQ", "Transfer ERQ", grid.Locator, "TransferERQ");
                    TransferERQ.DataField = "TransferERQ";
                    SafetyStockSuggested = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_en", "Safety Stock Suggested", grid.Locator, "SafetyStockSuggested");
                    SafetyStockSuggested.DataField = "SafetyStockSuggested";
                    MinQtySuggested = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_en", "Reorder Point Suggested", grid.Locator, "MinQtySuggested");
                    MinQtySuggested.DataField = "MinQtySuggested";
                    MaxQtySuggested = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_en", "Max Qty Suggested", grid.Locator, "MaxQtySuggested");
                    MaxQtySuggested.DataField = "MaxQtySuggested";
                    DemandPerDayAverage = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_en", "Daily Demand Forecast", grid.Locator, "DemandPerDayAverage");
                    DemandPerDayAverage.DataField = "DemandPerDayAverage";
                    DemandPerDaySTDEV = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_en", "Daily Demand Forecast Error(STDEV)", grid.Locator, "DemandPerDaySTDEV");
                    DemandPerDaySTDEV.DataField = "DemandPerDaySTDEV";
                    ItemStatus = new DropDown("_ctl00_phG_tab_t2_subRepGrid_lv0_ec", "Status", grid.Locator, "ItemStatus");
                    ItemStatus.DataField = "ItemStatus";
                    ItemStatus.Items.Add("AC", "Active");
                    ItemStatus.Items.Add("NS", "No Sales");
                    ItemStatus.Items.Add("NP", "No Purchases");
                    ItemStatus.Items.Add("NR", "No Request");
                    ItemStatus.Items.Add("IN", "Inactive");
                    InventoryID = new Selector("_ctl00_phG_tab_t2_subRepGrid_lv0_edSubRInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SiteID = new Selector("_ctl00_phG_tab_t2_subRepGrid_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SubItemID { get; }
				public PXNumberEditColumnFilter SafetyStock { get; }
				public PXNumberEditColumnFilter MinQty { get; }
				public PXNumberEditColumnFilter MaxQty { get; }
				public PXNumberEditColumnFilter TransferERQ { get; }
				public PXNumberEditColumnFilter SafetyStockSuggested { get; }
				public PXNumberEditColumnFilter MinQtySuggested { get; }
				public PXNumberEditColumnFilter MaxQtySuggested { get; }
				public PXNumberEditColumnFilter DemandPerDayAverage { get; }
				public PXNumberEditColumnFilter DemandPerDaySTDEV { get; }
				public DropDownColumnFilter ItemStatus { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SiteID { get; }
                
                public c_grid_header(c_subitemrecords_subrepgrid grid) : 
                        base(grid)
                {
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SafetyStock = new PXNumberEditColumnFilter(grid.Row.SafetyStock);
                    MinQty = new PXNumberEditColumnFilter(grid.Row.MinQty);
                    MaxQty = new PXNumberEditColumnFilter(grid.Row.MaxQty);
                    TransferERQ = new PXNumberEditColumnFilter(grid.Row.TransferERQ);
                    SafetyStockSuggested = new PXNumberEditColumnFilter(grid.Row.SafetyStockSuggested);
                    MinQtySuggested = new PXNumberEditColumnFilter(grid.Row.MinQtySuggested);
                    MaxQtySuggested = new PXNumberEditColumnFilter(grid.Row.MaxQtySuggested);
                    DemandPerDayAverage = new PXNumberEditColumnFilter(grid.Row.DemandPerDayAverage);
                    DemandPerDaySTDEV = new PXNumberEditColumnFilter(grid.Row.DemandPerDaySTDEV);
                    ItemStatus = new DropDownColumnFilter(grid.Row.ItemStatus);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                }
            }
        }
        
        public class c_subitemrecords_lv0 : Container
        {
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public PXNumberEdit SafetyStock { get; }
			public Label SafetyStockLabel { get; }
			public PXNumberEdit MinQty { get; }
			public Label MinQtyLabel { get; }
			public PXNumberEdit MaxQty { get; }
			public Label MaxQtyLabel { get; }
			public PXNumberEdit TransferERQ { get; }
			public Label TransferERQLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_subitemrecords_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t2_subRepGrid_lv0_edSubRInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SubItemID = new Selector("ctl00_phG_tab_t2_subRepGrid_lv0_edSubRSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                SafetyStock = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_lv0_edSubRSafetyStock", "Safety Stock", locator, null);
                SafetyStockLabel = new Label(SafetyStock);
                SafetyStock.DataField = "SafetyStock";
                MinQty = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_lv0_edSubRMinQty", "Reorder Point", locator, null);
                MinQtyLabel = new Label(MinQty);
                MinQty.DataField = "MinQty";
                MaxQty = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_lv0_edSubRMaxQty", "Max Qty.", locator, null);
                MaxQtyLabel = new Label(MaxQty);
                MaxQty.DataField = "MaxQty";
                TransferERQ = new PXNumberEdit("ctl00_phG_tab_t2_subRepGrid_lv0_edSubRTransferERQ", "Transfer ERQ", locator, null);
                TransferERQLabel = new Label(TransferERQ);
                TransferERQ.DataField = "TransferERQ";
                Es = new Selector("ctl00_phG_tab_t2_subRepGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t2_subRepGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "subitemrecords";
            }
        }
        
        public class c_preferredvendoritem_preferredform : Container
        {
            
			public PXNumberEdit VLeadTime { get; }
			public Label VLeadTimeLabel { get; }
			public PXNumberEdit AddLeadTimeDays { get; }
			public Label AddLeadTimeDaysLabel { get; }
			public PXNumberEdit MinOrdFreq { get; }
			public Label MinOrdFreqLabel { get; }
			public PXNumberEdit MinOrdQty { get; }
			public Label MinOrdQtyLabel { get; }
			public PXNumberEdit MaxOrdQty { get; }
			public Label MaxOrdQtyLabel { get; }
			public PXNumberEdit LotSize { get; }
			public Label LotSizeLabel { get; }
			public PXNumberEdit ERQ { get; }
			public Label ERQLabel { get; }
            
            public c_preferredvendoritem_preferredform(string locator, string name) : 
                    base(locator, name)
            {
                VLeadTime = new PXNumberEdit("ctl00_phG_tab_t1_preferredForm_edVLeadTime", "Vendor Lead Time (Days)", locator, null);
                VLeadTimeLabel = new Label(VLeadTime);
                VLeadTime.DataField = "VLeadTime";
                AddLeadTimeDays = new PXNumberEdit("ctl00_phG_tab_t1_preferredForm_edAddLeadTimeDays", "Add. Lead Time (Days)", locator, null);
                AddLeadTimeDaysLabel = new Label(AddLeadTimeDays);
                AddLeadTimeDays.DataField = "AddLeadTimeDays";
                MinOrdFreq = new PXNumberEdit("ctl00_phG_tab_t1_preferredForm_edMinOrdFreq", "Min. Order Freq.(Days)", locator, null);
                MinOrdFreqLabel = new Label(MinOrdFreq);
                MinOrdFreq.DataField = "MinOrdFreq";
                MinOrdQty = new PXNumberEdit("ctl00_phG_tab_t1_preferredForm_edMinOrdQty", "Min. Order Qty.", locator, null);
                MinOrdQtyLabel = new Label(MinOrdQty);
                MinOrdQty.DataField = "MinOrdQty";
                MaxOrdQty = new PXNumberEdit("ctl00_phG_tab_t1_preferredForm_edMaxOrdQty", "Max Order Qty.", locator, null);
                MaxOrdQtyLabel = new Label(MaxOrdQty);
                MaxOrdQty.DataField = "MaxOrdQty";
                LotSize = new PXNumberEdit("ctl00_phG_tab_t1_preferredForm_edLotSize", "Lot Size", locator, null);
                LotSizeLabel = new Label(LotSize);
                LotSize.DataField = "LotSize";
                ERQ = new PXNumberEdit("ctl00_phG_tab_t1_preferredForm_edERQ", "EOQ", locator, null);
                ERQLabel = new Label(ERQ);
                ERQ.DataField = "ERQ";
                DataMemberName = "PreferredVendorItem";
            }
        }
        
        public class c_amsubitemdefaults_amgridamsubitemdefault : Grid<c_amsubitemdefaults_amgridamsubitemdefault.c_grid_row, c_amsubitemdefaults_amgridamsubitemdefault.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_amsubitemdefaults_amgridamsubitemdefault(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "AMSubItemDefaults";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AMBOMIDEdit()
            {
                Buttons.AMBOMIDEdit.Click();
            }
            
            public virtual void AMPlanningBOMIDEdit()
            {
                Buttons.AMPlanningBOMIDEdit.Click();
            }
            
            public virtual void AMConfigurationIDEdit()
            {
                Buttons.AMConfigurationIDEdit.Click();
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
                
			public Button AMBOMIDEdit { get; }
			public Button AMPlanningBOMIDEdit { get; }
			public Button AMConfigurationIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AMBOMIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMBOMID\'] div[class=\'editBtnCont\'] > div > div", "AMBOMIDEdit", "ctl00_phG_tab_t4_AMGridAMSubItemDefault");
                    AMBOMIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMPlanningBOMIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMPlanningBOMID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "AMPlanningBOMIDEdit", "ctl00_phG_tab_t4_AMGridAMSubItemDefault");
                    AMPlanningBOMIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMConfigurationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMConfigurationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMConfigurationIDEdit", "ctl00_phG_tab_t4_AMGridAMSubItemDefault");
                    AMConfigurationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfFirst0", "First", "ctl00_phG_tab_t4_AMGridAMSubItemDefault");
                    Prev = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfPrev0", "Prev", "ctl00_phG_tab_t4_AMGridAMSubItemDefault");
                    Next = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfNext0", "Next", "ctl00_phG_tab_t4_AMGridAMSubItemDefault");
                    Last = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfLast0", "Last", "ctl00_phG_tab_t4_AMGridAMSubItemDefault");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SubItemID { get; }
			public Selector BOMID { get; }
			public Selector PlanningBOMID { get; }
                
                public c_grid_row(c_amsubitemdefaults_amgridamsubitemdefault grid) : 
                        base(grid)
                {
                    SubItemID = new Selector("_ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0_edSubItemAMSubItemID", "Sub Item ID", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    BOMID = new Selector("_ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0_edSubItemAMBOMID", "BOMID", grid.Locator, "BOMID");
                    BOMID.DataField = "BOMID";
                    PlanningBOMID = new Selector("_ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0_edSubItemAMPlanningBOMID", "Planning BOMID", grid.Locator, "PlanningBOMID");
                    PlanningBOMID.DataField = "PlanningBOMID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter BOMID { get; }
				public SelectorColumnFilter PlanningBOMID { get; }
                
                public c_grid_header(c_amsubitemdefaults_amgridamsubitemdefault grid) : 
                        base(grid)
                {
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    BOMID = new SelectorColumnFilter(grid.Row.BOMID);
                    PlanningBOMID = new SelectorColumnFilter(grid.Row.PlanningBOMID);
                }
            }
        }
        
        public class c_amsubitemdefaults_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector BOMID { get; }
			public Label BOMIDLabel { get; }
			public Selector PlanningBOMID { get; }
			public Label PlanningBOMIDLabel { get; }
            
            public c_amsubitemdefaults_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SubItemID = new Selector("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0_edSubItemAMSubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                BOMID = new Selector("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0_edSubItemAMBOMID", "BOMID", locator, null);
                BOMIDLabel = new Label(BOMID);
                BOMID.DataField = "BOMID";
                PlanningBOMID = new Selector("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0_edSubItemAMPlanningBOMID", "Planning BOMID", locator, null);
                PlanningBOMIDLabel = new Label(PlanningBOMID);
                PlanningBOMID.DataField = "PlanningBOMID";
                DataMemberName = "AMSubItemDefaults";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AMBOMIDEdit()
            {
                Buttons.AMBOMIDEdit.Click();
            }
            
            public virtual void AMPlanningBOMIDEdit()
            {
                Buttons.AMPlanningBOMIDEdit.Click();
            }
            
            public virtual void AMConfigurationIDEdit()
            {
                Buttons.AMConfigurationIDEdit.Click();
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
                
			public Button AMBOMIDEdit { get; }
			public Button AMPlanningBOMIDEdit { get; }
			public Button AMConfigurationIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AMBOMIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMBOMID\'] div[class=\'editBtnCont\'] > div > div", "AMBOMIDEdit", "ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0");
                    AMBOMIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMPlanningBOMIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMPlanningBOMID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "AMPlanningBOMIDEdit", "ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0");
                    AMPlanningBOMIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    AMConfigurationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_edAMConfigurationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMConfigurationIDEdit", "ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0");
                    AMConfigurationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfFirst0", "First", "ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0");
                    Prev = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfPrev0", "Prev", "ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0");
                    Next = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfNext0", "Next", "ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0");
                    Last = new Button("ctl00_phG_tab_t4_AMGridAMSubItemDefault_lfLast0", "Last", "ctl00_phG_tab_t4_AMGridAMSubItemDefault_lv0");
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
