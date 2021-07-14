using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.GroupBox;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Wait;

namespace ACSC.Tests.Wrappers.Customer
{
    
    
    public class CS207500_CarrierMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        protected c_carrier_form Carrier_form { get; } = new c_carrier_form("ctl00_phF_form", "Carrier_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_carriercurrent_tab CarrierCurrent_tab { get; } = new c_carriercurrent_tab("ctl00_phG_tab", "CarrierCurrent_tab");
        protected c_freightrates_gridfreightrates FreightRates_gridFreightRates { get; } = new c_freightrates_gridfreightrates("ctl00_phG_tab_t1_gridFreightRates", "FreightRates_gridFreightRates");
        protected c_freightrates_lv0 FreightRates_lv0 { get; } = new c_freightrates_lv0("ctl00_phG_tab_t1_gridFreightRates_lv0", "FreightRates_lv0");
        protected c_carrierpackages_gridcarrierpackages CarrierPackages_gridCarrierPackages { get; } = new c_carrierpackages_gridcarrierpackages("ctl00_phG_tab_t2_gridCarrierPackages", "CarrierPackages_gridCarrierPackages");
        protected c_carrierpackages_lv0 CarrierPackages_lv0 { get; } = new c_carrierpackages_lv0("ctl00_phG_tab_t2_gridCarrierPackages_lv0", "CarrierPackages_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public CS207500_CarrierMaint()
        {
            ScreenId = "CS207500";
            ScreenUrl = "/Pages/CS/CS207500.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual CS207500_CarrierMaint ReadOne(Gate gate, string CarrierID)
        {
            new BiObject<CS207500_CarrierMaint>(gate).ReadOne(this, CarrierID);
            return this;
        }
        
        public virtual CS207500_CarrierMaint ReadOne(string CarrierID)
        {
            return this.ReadOne(ApiConnection.Source, CarrierID);
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
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
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
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                FilesMenuShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
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
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CancelClose\']", "Discard Changes and Close", locator, null);
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'SaveClose\']", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
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
        
        public class c_carrier_form : Container
        {
            
			public Selector CarrierID { get; }
			public Label CarrierIDLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public CheckBox IsExternal { get; }
			public Label IsExternalLabel { get; }
            
            public c_carrier_form(string locator, string name) : 
                    base(locator, name)
            {
                CarrierID = new Selector("ctl00_phF_form_edCarrierID", "Ship Via", locator, null);
                CarrierIDLabel = new Label(CarrierID);
                CarrierID.DataField = "CarrierID";
                Description = new PXTextEdit("ctl00_phF_form_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                IsExternal = new CheckBox("ctl00_phF_form_chkIsExternal", "External Plug-in", locator, null);
                IsExternalLabel = new Label(IsExternal);
                IsExternal.DataField = "IsExternal";
                DataMemberName = "Carrier";
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
        
        public class c_carriercurrent_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CalendarID { get; }
			public Label CalendarIDLabel { get; }
			public Selector CarrierPluginID { get; }
			public Label CarrierPluginIDLabel { get; }
			public DropDown CalcMethod { get; }
			public Label CalcMethodLabel { get; }
			public Selector PluginMethod { get; }
			public Label PluginMethodLabel { get; }
			public PXNumberEdit BaseRate { get; }
			public Label BaseRateLabel { get; }
			public CheckBox IsCommonCarrier { get; }
			public Label IsCommonCarrierLabel { get; }
			public CheckBox CalcFreightOnReturn { get; }
			public Label CalcFreightOnReturnLabel { get; }
			public CheckBox ConfirmationRequired { get; }
			public Label ConfirmationRequiredLabel { get; }
			public CheckBox PackageRequired { get; }
			public Label PackageRequiredLabel { get; }
			public CheckBox ReturnLabel { get; }
			public Label ReturnLabelLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector FreightSalesAcctID { get; }
			public Label FreightSalesAcctIDLabel { get; }
			public Selector FreightSalesSubID { get; }
			public Label FreightSalesSubIDLabel { get; }
			public Selector FreightExpenseAcctID { get; }
			public Label FreightExpenseAcctIDLabel { get; }
			public Selector FreightExpenseSubID { get; }
			public Label FreightExpenseSubIDLabel { get; }
			public CheckBox ValidatePackedQty { get; }
			public Label ValidatePackedQtyLabel { get; }
			public CheckBox IsExternalShippingApplication { get; }
			public Label IsExternalShippingApplicationLabel { get; }
			public DropDown ShippingApplicationType { get; }
			public Label ShippingApplicationTypeLabel { get; }
            
            public c_carriercurrent_tab(string locator, string name) : 
                    base(locator, name)
            {
                CalendarID = new Selector("ctl00_phG_tab_t0_edCalendarID", "Calendar", locator, null);
                CalendarIDLabel = new Label(CalendarID);
                CalendarID.DataField = "CalendarID";
                CarrierPluginID = new Selector("ctl00_phG_tab_t0_edCarrierPluginID", "Carrier", locator, null);
                CarrierPluginIDLabel = new Label(CarrierPluginID);
                CarrierPluginID.DataField = "CarrierPluginID";
                CalcMethod = new DropDown("ctl00_phG_tab_t0_edCalcMethod", "Calculation Method", locator, null);
                CalcMethodLabel = new Label(CalcMethod);
                CalcMethod.DataField = "CalcMethod";
                CalcMethod.Items.Add("P", "Per Unit");
                CalcMethod.Items.Add("N", "Net");
                CalcMethod.Items.Add("M", "Manual");
                PluginMethod = new Selector("ctl00_phG_tab_t0_edPluginMethod", "Service Method", locator, null);
                PluginMethodLabel = new Label(PluginMethod);
                PluginMethod.DataField = "PluginMethod";
                BaseRate = new PXNumberEdit("ctl00_phG_tab_t0_edBaseRate", "Base Rate", locator, null);
                BaseRateLabel = new Label(BaseRate);
                BaseRate.DataField = "BaseRate";
                IsCommonCarrier = new CheckBox("ctl00_phG_tab_t0_chkIsCommonCarrier", "Common Carrier", locator, null);
                IsCommonCarrierLabel = new Label(IsCommonCarrier);
                IsCommonCarrier.DataField = "IsCommonCarrier";
                CalcFreightOnReturn = new CheckBox("ctl00_phG_tab_t0_chkCalcFreightOnReturn", "Calculate Freight on Returns", locator, null);
                CalcFreightOnReturnLabel = new Label(CalcFreightOnReturn);
                CalcFreightOnReturn.DataField = "CalcFreightOnReturn";
                ConfirmationRequired = new CheckBox("ctl00_phG_tab_t0_chkConfirmationRequired", "Confirmation for Each Box Is Required", locator, null);
                ConfirmationRequiredLabel = new Label(ConfirmationRequired);
                ConfirmationRequired.DataField = "ConfirmationRequired";
                PackageRequired = new CheckBox("ctl00_phG_tab_t0_chkPackageRequired", "At least one Package Is Required", locator, null);
                PackageRequiredLabel = new Label(PackageRequired);
                PackageRequired.DataField = "PackageRequired";
                ReturnLabel = new CheckBox("ctl00_phG_tab_t0_chkReturnLabel", "Generate Return Label Automatically", locator, null);
                ReturnLabelLabel = new Label(ReturnLabel);
                ReturnLabel.DataField = "ReturnLabel";
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                FreightSalesAcctID = new Selector("ctl00_phG_tab_t0_edFreightSalesAcctID", "Freight Sales Account", locator, null);
                FreightSalesAcctIDLabel = new Label(FreightSalesAcctID);
                FreightSalesAcctID.DataField = "FreightSalesAcctID";
                FreightSalesSubID = new Selector("ctl00_phG_tab_t0_edFreightSalesSubID", "Freight Sales Sub.", locator, null);
                FreightSalesSubIDLabel = new Label(FreightSalesSubID);
                FreightSalesSubID.DataField = "FreightSalesSubID";
                FreightExpenseAcctID = new Selector("ctl00_phG_tab_t0_edFreightExpenseAcctID", "Freight Expense Account", locator, null);
                FreightExpenseAcctIDLabel = new Label(FreightExpenseAcctID);
                FreightExpenseAcctID.DataField = "FreightExpenseAcctID";
                FreightExpenseSubID = new Selector("ctl00_phG_tab_t0_edFreightExpenseSubID", "Freight Expense Sub.", locator, null);
                FreightExpenseSubIDLabel = new Label(FreightExpenseSubID);
                FreightExpenseSubID.DataField = "FreightExpenseSubID";
                ValidatePackedQty = new CheckBox("ctl00_phG_tab_t3_chkValidatePackedQty", "Validate Packed Quantities on Shipment Confirmation", locator, null);
                ValidatePackedQtyLabel = new Label(ValidatePackedQty);
                ValidatePackedQty.DataField = "ValidatePackedQty";
                IsExternalShippingApplication = new CheckBox("ctl00_phG_tab_t3_chkIsExternalShippingApplication", "Use External Shipping Application", locator, null);
                IsExternalShippingApplicationLabel = new Label(IsExternalShippingApplication);
                IsExternalShippingApplication.DataField = "IsExternalShippingApplication";
                ShippingApplicationType = new DropDown("ctl00_phG_tab_t3_edShippingApplicationType", "Shipping Application", locator, null);
                ShippingApplicationTypeLabel = new Label(ShippingApplicationType);
                ShippingApplicationType.DataField = "ShippingApplicationType";
                ShippingApplicationType.Items.Add("UPS", "UPS WorldShip");
                ShippingApplicationType.Items.Add("FED", "FedEx Ship Manager");
                DataMemberName = "CarrierCurrent";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CalendarIDEdit()
            {
                Buttons.CalendarIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CalendarIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    CalendarIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edCalendarID\'] div[class=\'editBtnCont\'] > div > div", "CalendarIDEdit", "ctl00_phG_tab");
                    CalendarIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_freightrates_gridfreightrates : Grid<c_freightrates_gridfreightrates.c_grid_row, c_freightrates_gridfreightrates.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_freightrates_gridfreightrates(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_gridFreightRates");
                DataMemberName = "FreightRates";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_gridFreightRates_fe_gf", "FilterForm");
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
            
            public virtual void ZoneIDEdit()
            {
                Buttons.ZoneIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridFreightRates_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ZoneIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_gridFreightRates_lv0_edZoneID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "ZoneIDEdit", "ctl00_phG_tab_t1_gridFreightRates");
                    ZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXNumberEdit Weight { get; }
			public PXNumberEdit Volume { get; }
			public Selector ZoneID { get; }
			public PXNumberEdit Rate { get; }
			public PXTextEdit CarrierID { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_freightrates_gridfreightrates grid) : 
                        base(grid)
                {
                    Weight = new PXNumberEdit("_ctl00_phG_tab_t1_gridFreightRates_lv0_edWeight", "Weight", grid.Locator, "Weight");
                    Weight.DataField = "Weight";
                    Volume = new PXNumberEdit("_ctl00_phG_tab_t1_gridFreightRates_lv0_edVolume", "Volume", grid.Locator, "Volume");
                    Volume.DataField = "Volume";
                    ZoneID = new Selector("_ctl00_phG_tab_t1_gridFreightRates_lv0_edZoneID", "Zone ID", grid.Locator, "ZoneID");
                    ZoneID.DataField = "ZoneID";
                    Rate = new PXNumberEdit("_ctl00_phG_tab_t1_gridFreightRates_lv0_edRate", "Rate", grid.Locator, "Rate");
                    Rate.DataField = "Rate";
                    CarrierID = new PXTextEdit("ctl00_phG_tab_t1_gridFreightRates_em", "CarrierID", grid.Locator, "CarrierID");
                    CarrierID.DataField = "CarrierID";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t1_gridFreightRates_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXNumberEditColumnFilter Weight { get; }
				public PXNumberEditColumnFilter Volume { get; }
				public SelectorColumnFilter ZoneID { get; }
				public PXNumberEditColumnFilter Rate { get; }
				public PXTextEditColumnFilter CarrierID { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_freightrates_gridfreightrates grid) : 
                        base(grid)
                {
                    Weight = new PXNumberEditColumnFilter(grid.Row.Weight);
                    Volume = new PXNumberEditColumnFilter(grid.Row.Volume);
                    ZoneID = new SelectorColumnFilter(grid.Row.ZoneID);
                    Rate = new PXNumberEditColumnFilter(grid.Row.Rate);
                    CarrierID = new PXTextEditColumnFilter(grid.Row.CarrierID);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_freightrates_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit Weight { get; }
			public Label WeightLabel { get; }
			public PXNumberEdit Volume { get; }
			public Label VolumeLabel { get; }
			public Selector ZoneID { get; }
			public Label ZoneIDLabel { get; }
			public PXNumberEdit Rate { get; }
			public Label RateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_freightrates_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Weight = new PXNumberEdit("ctl00_phG_tab_t1_gridFreightRates_lv0_edWeight", "Weight", locator, null);
                WeightLabel = new Label(Weight);
                Weight.DataField = "Weight";
                Volume = new PXNumberEdit("ctl00_phG_tab_t1_gridFreightRates_lv0_edVolume", "Volume", locator, null);
                VolumeLabel = new Label(Volume);
                Volume.DataField = "Volume";
                ZoneID = new Selector("ctl00_phG_tab_t1_gridFreightRates_lv0_edZoneID", "Zone ID", locator, null);
                ZoneIDLabel = new Label(ZoneID);
                ZoneID.DataField = "ZoneID";
                Rate = new PXNumberEdit("ctl00_phG_tab_t1_gridFreightRates_lv0_edRate", "Rate", locator, null);
                RateLabel = new Label(Rate);
                Rate.DataField = "Rate";
                Es = new Selector("ctl00_phG_tab_t1_gridFreightRates_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "FreightRates";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ZoneIDEdit()
            {
                Buttons.ZoneIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ZoneIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_gridFreightRates_lv0_edZoneID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "ZoneIDEdit", "ctl00_phG_tab_t1_gridFreightRates_lv0");
                    ZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_carrierpackages_gridcarrierpackages : Grid<c_carrierpackages_gridcarrierpackages.c_grid_row, c_carrierpackages_gridcarrierpackages.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_carrierpackages_gridcarrierpackages(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_gridCarrierPackages");
                DataMemberName = "CarrierPackages";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_gridCarrierPackages_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridCarrierPackages_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector BoxID { get; }
			public PXTextEdit CSBox__Description { get; }
			public PXNumberEdit CSBox__BoxWeight { get; }
			public PXNumberEdit CSBox__MaxWeight { get; }
			public Selector CommonSetup__WeightUOM { get; }
			public PXNumberEdit CSBox__MaxVolume { get; }
			public Selector CommonSetup__VolumeUOM { get; }
			public PXNumberEdit CSBox__Length { get; }
			public PXNumberEdit CSBox__Width { get; }
			public PXNumberEdit CSBox__Height { get; }
			public PXTextEdit CarrierID { get; }
                
                public c_grid_row(c_carrierpackages_gridcarrierpackages grid) : 
                        base(grid)
                {
                    BoxID = new Selector("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edBoxID", "Box ID", grid.Locator, "BoxID");
                    BoxID.DataField = "BoxID";
                    CSBox__Description = new PXTextEdit("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Description", "Description", grid.Locator, "CSBox__Description");
                    CSBox__Description.DataField = "CSBox__Description";
                    CSBox__BoxWeight = new PXNumberEdit("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__BoxWeight", "Box Weight", grid.Locator, "CSBox__BoxWeight");
                    CSBox__BoxWeight.DataField = "CSBox__BoxWeight";
                    CSBox__MaxWeight = new PXNumberEdit("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__MaxWeight", "Max. Weight", grid.Locator, "CSBox__MaxWeight");
                    CSBox__MaxWeight.DataField = "CSBox__MaxWeight";
                    CommonSetup__WeightUOM = new Selector("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_es", "Weight UOM", grid.Locator, "CommonSetup__WeightUOM");
                    CommonSetup__WeightUOM.DataField = "CommonSetup__WeightUOM";
                    CSBox__MaxVolume = new PXNumberEdit("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__MaxVolume", "Max Volume", grid.Locator, "CSBox__MaxVolume");
                    CSBox__MaxVolume.DataField = "CSBox__MaxVolume";
                    CommonSetup__VolumeUOM = new Selector("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_es", "Volume UOM", grid.Locator, "CommonSetup__VolumeUOM");
                    CommonSetup__VolumeUOM.DataField = "CommonSetup__VolumeUOM";
                    CSBox__Length = new PXNumberEdit("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Length", "Length", grid.Locator, "CSBox__Length");
                    CSBox__Length.DataField = "CSBox__Length";
                    CSBox__Width = new PXNumberEdit("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Width", "Width", grid.Locator, "CSBox__Width");
                    CSBox__Width.DataField = "CSBox__Width";
                    CSBox__Height = new PXNumberEdit("_ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Height", "Height", grid.Locator, "CSBox__Height");
                    CSBox__Height.DataField = "CSBox__Height";
                    CarrierID = new PXTextEdit("ctl00_phG_tab_t2_gridCarrierPackages_ei", "CarrierID", grid.Locator, "CarrierID");
                    CarrierID.DataField = "CarrierID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter BoxID { get; }
				public PXTextEditColumnFilter CSBox__Description { get; }
				public PXNumberEditColumnFilter CSBox__BoxWeight { get; }
				public PXNumberEditColumnFilter CSBox__MaxWeight { get; }
				public SelectorColumnFilter CommonSetup__WeightUOM { get; }
				public PXNumberEditColumnFilter CSBox__MaxVolume { get; }
				public SelectorColumnFilter CommonSetup__VolumeUOM { get; }
				public PXNumberEditColumnFilter CSBox__Length { get; }
				public PXNumberEditColumnFilter CSBox__Width { get; }
				public PXNumberEditColumnFilter CSBox__Height { get; }
				public PXTextEditColumnFilter CarrierID { get; }
                
                public c_grid_header(c_carrierpackages_gridcarrierpackages grid) : 
                        base(grid)
                {
                    BoxID = new SelectorColumnFilter(grid.Row.BoxID);
                    CSBox__Description = new PXTextEditColumnFilter(grid.Row.CSBox__Description);
                    CSBox__BoxWeight = new PXNumberEditColumnFilter(grid.Row.CSBox__BoxWeight);
                    CSBox__MaxWeight = new PXNumberEditColumnFilter(grid.Row.CSBox__MaxWeight);
                    CommonSetup__WeightUOM = new SelectorColumnFilter(grid.Row.CommonSetup__WeightUOM);
                    CSBox__MaxVolume = new PXNumberEditColumnFilter(grid.Row.CSBox__MaxVolume);
                    CommonSetup__VolumeUOM = new SelectorColumnFilter(grid.Row.CommonSetup__VolumeUOM);
                    CSBox__Length = new PXNumberEditColumnFilter(grid.Row.CSBox__Length);
                    CSBox__Width = new PXNumberEditColumnFilter(grid.Row.CSBox__Width);
                    CSBox__Height = new PXNumberEditColumnFilter(grid.Row.CSBox__Height);
                    CarrierID = new PXTextEditColumnFilter(grid.Row.CarrierID);
                }
            }
        }
        
        public class c_carrierpackages_lv0 : Container
        {
            
			public Selector BoxID { get; }
			public Label BoxIDLabel { get; }
			public PXTextEdit CSBox__Description { get; }
			public Label CSBox__DescriptionLabel { get; }
			public PXNumberEdit CSBox__BoxWeight { get; }
			public Label CSBox__BoxWeightLabel { get; }
			public PXNumberEdit CSBox__MaxWeight { get; }
			public Label CSBox__MaxWeightLabel { get; }
			public PXNumberEdit CSBox__MaxVolume { get; }
			public Label CSBox__MaxVolumeLabel { get; }
			public PXNumberEdit CSBox__Length { get; }
			public Label CSBox__LengthLabel { get; }
			public PXNumberEdit CSBox__Width { get; }
			public Label CSBox__WidthLabel { get; }
			public PXNumberEdit CSBox__Height { get; }
			public Label CSBox__HeightLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_carrierpackages_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BoxID = new Selector("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edBoxID", "Box ID", locator, null);
                BoxIDLabel = new Label(BoxID);
                BoxID.DataField = "BoxID";
                CSBox__Description = new PXTextEdit("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Description", "Description", locator, null);
                CSBox__DescriptionLabel = new Label(CSBox__Description);
                CSBox__Description.DataField = "CSBox__Description";
                CSBox__BoxWeight = new PXNumberEdit("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__BoxWeight", "Box Weight", locator, null);
                CSBox__BoxWeightLabel = new Label(CSBox__BoxWeight);
                CSBox__BoxWeight.DataField = "CSBox__BoxWeight";
                CSBox__MaxWeight = new PXNumberEdit("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__MaxWeight", "Max. Weight", locator, null);
                CSBox__MaxWeightLabel = new Label(CSBox__MaxWeight);
                CSBox__MaxWeight.DataField = "CSBox__MaxWeight";
                CSBox__MaxVolume = new PXNumberEdit("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__MaxVolume", "Max Volume", locator, null);
                CSBox__MaxVolumeLabel = new Label(CSBox__MaxVolume);
                CSBox__MaxVolume.DataField = "CSBox__MaxVolume";
                CSBox__Length = new PXNumberEdit("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Length", "Length", locator, null);
                CSBox__LengthLabel = new Label(CSBox__Length);
                CSBox__Length.DataField = "CSBox__Length";
                CSBox__Width = new PXNumberEdit("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Width", "Width", locator, null);
                CSBox__WidthLabel = new Label(CSBox__Width);
                CSBox__Width.DataField = "CSBox__Width";
                CSBox__Height = new PXNumberEdit("ctl00_phG_tab_t2_gridCarrierPackages_lv0_edCSBox__Height", "Height", locator, null);
                CSBox__HeightLabel = new Label(CSBox__Height);
                CSBox__Height.DataField = "CSBox__Height";
                Es = new Selector("ctl00_phG_tab_t2_gridCarrierPackages_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "CarrierPackages";
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
