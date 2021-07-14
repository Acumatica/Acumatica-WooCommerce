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


namespace ACBC.Tests.Wrappers
{
    
    
    public class IN203000_TemplateInventoryItemMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_allscreens_screensgrid AllScreens_screensGrid { get; } = new c_allscreens_screensgrid("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid", "AllScreens_screensGrid");
        protected c_pages_articlesgrid Pages_articlesGrid { get; } = new c_pages_articlesgrid("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid", "Pages_articlesGrid");
        protected c_pages_lv0 Pages_lv0 { get; } = new c_pages_lv0("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0", "Pages_lv0");
        protected c_fileswithsize_filessearchgrid FilesWithSize_filesSearchGrid { get; } = new c_fileswithsize_filessearchgrid("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid", "FilesWithSize_filesSearchGrid");
        protected c_fileswithsize_lv0 FilesWithSize_lv0 { get; } = new c_fileswithsize_lv0("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0", "FilesWithSize_lv0");
        protected c_item_form Item_form { get; } = new c_item_form("ctl00_phF_form", "Item_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_itemsettings_tab ItemSettings_tab { get; } = new c_itemsettings_tab("ctl00_phG_tab", "ItemSettings_tab");
        protected c_itemclass_tab ItemClass_tab { get; } = new c_itemclass_tab("ctl00_phG_tab", "ItemClass_tab");
        protected c_itemunits_gridunits Itemunits_gridunits { get; } = new c_itemunits_gridunits("ctl00_phG_tab_t0_gridUnits", "itemunits_gridUnits");
        protected c_itemunits_lv0 Itemunits_lv0 { get; } = new c_itemunits_lv0("ctl00_phG_tab_t0_gridUnits_lv0", "itemunits_lv0");
        protected c_vendoritems_pxgridvendoritems VendorItems_PXGridVendorItems { get; } = new c_vendoritems_pxgridvendoritems("ctl00_phG_tab_t3_PXGridVendorItems", "VendorItems_PXGridVendorItems");
        protected c_vendoritems_lv0 VendorItems_lv0 { get; } = new c_vendoritems_lv0("ctl00_phG_tab_t3_PXGridVendorItems_lv0", "VendorItems_lv0");
        protected c_answers_pxgridanswers Answers_PXGridAnswers { get; } = new c_answers_pxgridanswers("ctl00_phG_tab_t6_PXGridAnswers", "Answers_PXGridAnswers");
        protected c_answers_lv0 Answers_lv0 { get; } = new c_answers_lv0("ctl00_phG_tab_t6_PXGridAnswers_lv0", "Answers_lv0");
        protected c_category_pxgridcategory Category_PXGridCategory { get; } = new c_category_pxgridcategory("ctl00_phG_tab_t1_PXGridCategory", "Category_PXGridCategory");
        protected c_category_lv0 Category_lv0 { get; } = new c_category_lv0("ctl00_phG_tab_t1_PXGridCategory_lv0", "Category_lv0");
        protected c_boxes_pxgridboxes Boxes_PXGridBoxes { get; } = new c_boxes_pxgridboxes("ctl00_phG_tab_t1_PXGridBoxes", "Boxes_PXGridBoxes");
        protected c_boxes_lv0 Boxes_lv0 { get; } = new c_boxes_lv0("ctl00_phG_tab_t1_PXGridBoxes_lv0", "Boxes_lv0");
        protected c_idgenerationrules_pxgrididgenerationrules IdGenerationRules_PXGridIdGenerationRules { get; } = new c_idgenerationrules_pxgrididgenerationrules("ctl00_phG_tab_t6_PXGridIdGenerationRules", "IdGenerationRules_PXGridIdGenerationRules");
        protected c_idgenerationrules_lv0 IdGenerationRules_lv0 { get; } = new c_idgenerationrules_lv0("ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0", "IdGenerationRules_lv0");
        protected c_descriptiongenerationrules_pxgriddescriptiongenerationrules DescriptionGenerationRules_PXGridDescriptionGenerationRules { get; } = new c_descriptiongenerationrules_pxgriddescriptiongenerationrules("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules", "DescriptionGenerationRules_PXGridDescriptionGenerationRules");
        protected c_descriptiongenerationrules_lv0 DescriptionGenerationRules_lv0 { get; } = new c_descriptiongenerationrules_lv0("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0", "DescriptionGenerationRules_lv0");
        protected c_inventoryfileurls_gridinventoryfileurls InventoryFileUrls_gridInventoryFileUrls { get; } = new c_inventoryfileurls_gridinventoryfileurls("ctl00_phG_tab_t9_gridInventoryFileUrls", "InventoryFileUrls_gridInventoryFileUrls");
        protected c_inventoryfileurls_lv0 InventoryFileUrls_lv0 { get; } = new c_inventoryfileurls_lv0("ctl00_phG_tab_t9_gridInventoryFileUrls_lv0", "InventoryFileUrls_lv0");
        protected c_vendorinventory_updateprice_formeffectivedate VendorInventory_UpdatePrice_formEffectiveDate { get; } = new c_vendorinventory_updateprice_formeffectivedate("ctl00_phG_pnlUpdatePrice_formEffectiveDate", "VendorInventory$UpdatePrice_formEffectiveDate");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phF_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_matrixitems_grdmatrixitems MatrixItems_grdMatrixItems { get; } = new c_matrixitems_grdmatrixitems("ctl00_phG_tab_t8_grdMatrixItems", "MatrixItems_grdMatrixItems");
        protected c_matrixitems_lv0 MatrixItems_lv0 { get; } = new c_matrixitems_lv0("ctl00_phG_tab_t8_grdMatrixItems_lv0", "MatrixItems_lv0");
        protected c_header_pxformview1 Header_PXFormView1 { get; } = new c_header_pxformview1("ctl00_phG_tab_t7_PXFormView1", "Header_PXFormView1");
        protected c_additionalattributes_matrixattributes AdditionalAttributes_MatrixAttributes { get; } = new c_additionalattributes_matrixattributes("ctl00_phG_tab_t7_MatrixAttributes", "AdditionalAttributes_MatrixAttributes");
        protected c_additionalattributes_lv0 AdditionalAttributes_lv0 { get; } = new c_additionalattributes_lv0("ctl00_phG_tab_t7_MatrixAttributes_lv0", "AdditionalAttributes_lv0");
        protected c_matrix_matrixmatrix Matrix_MatrixMatrix { get; } = new c_matrix_matrixmatrix("ctl00_phG_tab_t7_MatrixMatrix", "Matrix_MatrixMatrix");
        protected c_matrixitemsforcreation_grdcreate MatrixItemsForCreation_grdCreate { get; } = new c_matrixitemsforcreation_grdcreate("ctl00_phG_tab_t7_popupCreate_grdCreate", "MatrixItemsForCreation_grdCreate");
        protected c_matrixitemsforcreation_lv0 MatrixItemsForCreation_lv0 { get; } = new c_matrixitemsforcreation_lv0("ctl00_phG_tab_t7_popupCreate_grdCreate_lv0", "MatrixItemsForCreation_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_itemsettings_filesgrid ItemSettings_filesGrid { get; } = new c_itemsettings_filesgrid("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid", "ItemSettings_filesGrid");
        
        public IN203000_TemplateInventoryItemMaint()
        {
            ScreenId = "IN203000";
            ScreenUrl = "/Pages/IN/IN203000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual IN203000_TemplateInventoryItemMaint ReadOne(Gate gate, string InventoryCD)
        {
            new BiObject<IN203000_TemplateInventoryItemMaint>(gate).ReadOne(this, InventoryCD);
            return this;
        }
        
        public virtual IN203000_TemplateInventoryItemMaint ReadOne(string InventoryCD)
        {
            return this.ReadOne(ApiConnection.Source, InventoryCD);
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
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void First()
        {
            ToolBar.First.Click();
        }
        
        public virtual void Prev()
        {
            ToolBar.Prev.Click();
        }
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void Last()
        {
            ToolBar.Last.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void ViewRelatedItem()
        {
            ToolBar.ViewRelatedItem.Click();
        }
        
        public virtual void ApplyToItems()
        {
            ToolBar.ApplyToItems.Click();
        }
        
        public virtual void ApplyToItems(bool status, string message = null)
        {
            ToolBar.ApplyToItems.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ApplyToItems.Click();
        }
        
        public virtual void MatrixGridCellChanged()
        {
            ToolBar.MatrixGridCellChanged.Click();
        }
        
        public virtual void CreateMatrixItems()
        {
            ToolBar.CreateMatrixItems.Click();
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
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton CancelClose { get; }
			public ToolBarButton SaveClose { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton Clipboard { get; }
			public ToolBarButton CopyDocument { get; }
			public ToolBarButton PasteDocument { get; }
			public ToolBarButton SaveTemplate { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Prev { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton ViewRelatedItem { get; }
			public ToolBarButton ApplyToItems { get; }
			public ToolBarButton MatrixGridCellChanged { get; }
			public ToolBarButton CreateMatrixItems { get; }
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
                Clipboard = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div.toolsBtn[tooltip=\'Clipboard\']", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=li[data-cmd=\'Edit@CopyDocument\']", "Copy", locator, Clipboard);
                PasteDocument = new ToolBarButton("css=li[data-cmd=\'Edit@PasteDocument\']", "Paste", locator, Clipboard);
                SaveTemplate = new ToolBarButton("css=li[data-cmd=\'Edit@SaveTemplate\']", "Save as Template...", locator, Clipboard);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Delete\']", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'First\']", "Go to First Record", locator, null);
                Prev = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Prev\']", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Next\']", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Last\']", "Go to Last Record", locator, null);
                ChangeID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ChangeID\']", "Change ID", locator, null);
                ViewRelatedItem = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewRelatedItem\']", "View Related Item", locator, null);
                ApplyToItems = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ApplyToItems\']", "Apply to Matrix Items", locator, null);
                ApplyToItems.WaitAction = Wait.WaitForLongOperationToComplete;
                MatrixGridCellChanged = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'matrixGridCellChanged\']", "matrixGridCellChanged", locator, null);
                CreateMatrixItems = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CreateMatrixItems\']", "Create Matrix Items", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_allscreens_screensgrid : Grid<c_allscreens_screensgrid.c_grid_row, c_allscreens_screensgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_allscreens_screensgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid");
                DataMemberName = "AllScreens";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_at_tlb div[da" +
                            "ta-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_at_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Title { get; }
			public PXTextEdit ScreenID { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit Url { get; }
                
                public c_grid_row(c_allscreens_screensgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Title", grid.Locator, "Title");
                    Title.DataField = "Title";
                    ScreenID = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "ScreenID", grid.Locator, "ScreenID");
                    ScreenID.DataField = "ScreenID";
                    Module = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    Url = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Url", grid.Locator, "Url");
                    Url.DataField = "Url";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Title { get; }
				public PXTextEditColumnFilter ScreenID { get; }
				public PXTextEditColumnFilter Module { get; }
				public PXTextEditColumnFilter Url { get; }
                
                public c_grid_header(c_allscreens_screensgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEditColumnFilter(grid.Row.Title);
                    ScreenID = new PXTextEditColumnFilter(grid.Row.ScreenID);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    Url = new PXTextEditColumnFilter(grid.Row.Url);
                }
            }
        }
        
        public class c_pages_articlesgrid : Grid<c_pages_articlesgrid.c_grid_row, c_pages_articlesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_pages_articlesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid");
                DataMemberName = "Pages";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_at_tlb div[" +
                            "data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_at_tlb div[" +
                            "data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div[" +
                            "data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Title { get; }
			public PXTextEdit WikiPageParent__Title { get; }
			public DateSelector CreatedDateTime { get; }
			public PXTextEdit PageID { get; }
                
                public c_grid_row(c_pages_articlesgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "Title", grid.Locator, "Title");
                    Title.DataField = "Title";
                    WikiPageParent__Title = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "Title", grid.Locator, "WikiPageParent__Title");
                    WikiPageParent__Title.DataField = "WikiPageParent__Title";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0_ed2", "Create", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    PageID = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "PageID", grid.Locator, "PageID");
                    PageID.DataField = "PageID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Title { get; }
				public PXTextEditColumnFilter WikiPageParent__Title { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXTextEditColumnFilter PageID { get; }
                
                public c_grid_header(c_pages_articlesgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEditColumnFilter(grid.Row.Title);
                    WikiPageParent__Title = new PXTextEditColumnFilter(grid.Row.WikiPageParent__Title);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    PageID = new PXTextEditColumnFilter(grid.Row.PageID);
                }
            }
        }
        
        public class c_pages_lv0 : Container
        {
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_pages_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "Pages";
            }
        }
        
        public class c_fileswithsize_filessearchgrid : Grid<c_fileswithsize_filessearchgrid.c_grid_row, c_fileswithsize_filessearchgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_fileswithsize_filessearchgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid");
                DataMemberName = "FilesWithSize";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_at_tlb d" +
                            "iv[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_at_tlb d" +
                            "iv[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb d" +
                            "iv[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector Name { get; }
			public PXTextEdit Size { get; }
			public PXTextEdit Comment { get; }
			public PXTextEdit FileID { get; }
                
                public c_grid_row(c_fileswithsize_filessearchgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Name = new Selector("_ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0_es", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Size = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "Size (kb)", grid.Locator, "Size");
                    Size.DataField = "Size";
                    Comment = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                    FileID = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "File", grid.Locator, "FileID");
                    FileID.DataField = "FileID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter Name { get; }
				public PXTextEditColumnFilter Size { get; }
				public PXTextEditColumnFilter Comment { get; }
				public PXTextEditColumnFilter FileID { get; }
                
                public c_grid_header(c_fileswithsize_filessearchgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Name = new SelectorColumnFilter(grid.Row.Name);
                    Size = new PXTextEditColumnFilter(grid.Row.Size);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                    FileID = new PXTextEditColumnFilter(grid.Row.FileID);
                }
            }
        }
        
        public class c_fileswithsize_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_fileswithsize_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "FilesWithSize";
            }
        }
        
        public class c_item_form : Container
        {
            
			public Selector InventoryCD { get; }
			public Label InventoryCDLabel { get; }
			public CheckBox StkItem { get; }
			public Label StkItemLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
            
            public c_item_form(string locator, string name) : 
                    base(locator, name)
            {
                InventoryCD = new Selector("ctl00_phF_form_edInventoryCD", "Template ID", locator, null);
                InventoryCDLabel = new Label(InventoryCD);
                InventoryCD.DataField = "InventoryCD";
                StkItem = new CheckBox("ctl00_phF_form_edStkItem", "Stock Item", locator, null);
                StkItemLabel = new Label(StkItem);
                StkItem.DataField = "StkItem";
                Descr = new InputLocalizable("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                DataMemberName = "Item";
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
        
        public class c_itemsettings_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown ItemStatus { get; }
			public Label ItemStatusLabel { get; }
			public Selector ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public DropDown ItemType { get; }
			public Label ItemTypeLabel { get; }
			public DropDown ValMethod { get; }
			public Label ValMethodLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector PostClassID { get; }
			public Label PostClassIDLabel { get; }
			public Selector LotSerClassID { get; }
			public Label LotSerClassIDLabel { get; }
			public Selector CountryOfOrigin { get; }
			public Label CountryOfOriginLabel { get; }
			public CheckBox NonStockReceipt { get; }
			public Label NonStockReceiptLabel { get; }
			public CheckBox NonStockShip { get; }
			public Label NonStockShipLabel { get; }
			public DropDown CompletePOLine { get; }
			public Label CompletePOLineLabel { get; }
			public PXTextEdit EstimatedDuration { get; }
			public Label EstimatedDurationLabel { get; }
			public Selector DfltSiteID { get; }
			public Label DfltSiteIDLabel { get; }
			public Selector DfltShipLocationID { get; }
			public Label DfltShipLocationIDLabel { get; }
			public Selector DfltReceiptLocationID { get; }
			public Label DfltReceiptLocationIDLabel { get; }
			public Selector DefaultSubItemID { get; }
			public Label DefaultSubItemIDLabel { get; }
			public CheckBox DefaultSubItemOnEntry { get; }
			public Label DefaultSubItemOnEntryLabel { get; }
			public Selector BaseUnit { get; }
			public Label BaseUnitLabel { get; }
			public CheckBox DecimalBaseUnit { get; }
			public Label DecimalBaseUnitLabel { get; }
			public Selector SalesUnit { get; }
			public Label SalesUnitLabel { get; }
			public CheckBox DecimalSalesUnit { get; }
			public Label DecimalSalesUnitLabel { get; }
			public Selector PurchaseUnit { get; }
			public Label PurchaseUnitLabel { get; }
			public CheckBox DecimalPurchaseUnit { get; }
			public Label DecimalPurchaseUnitLabel { get; }
			public Selector CycleID { get; }
			public Label CycleIDLabel { get; }
			public Selector ABCCodeID { get; }
			public Label ABCCodeIDLabel { get; }
			public CheckBox ABCCodeIsFixed { get; }
			public Label ABCCodeIsFixedLabel { get; }
			public Selector MovementClassID { get; }
			public Label MovementClassIDLabel { get; }
			public CheckBox MovementClassIsFixed { get; }
			public Label MovementClassIsFixedLabel { get; }
			public PXNumberEdit BaseItemWeight { get; }
			public Label BaseItemWeightLabel { get; }
			public Selector WeightUOM { get; }
			public Label WeightUOMLabel { get; }
			public PXNumberEdit BaseItemVolume { get; }
			public Label BaseItemVolumeLabel { get; }
			public Selector VolumeUOM { get; }
			public Label VolumeUOMLabel { get; }
			public PXTextEdit HSTariffCode { get; }
			public Label HSTariffCodeLabel { get; }
			public PXNumberEdit UndershipThreshold { get; }
			public Label UndershipThresholdLabel { get; }
			public PXNumberEdit OvershipThreshold { get; }
			public Label OvershipThresholdLabel { get; }
			public DropDown PackageOption { get; }
			public Label PackageOptionLabel { get; }
			public CheckBox PackSeparately { get; }
			public Label PackSeparatelyLabel { get; }
			public Selector PriceClassID { get; }
			public Label PriceClassIDLabel { get; }
			public Selector PriceWorkgroupID { get; }
			public Label PriceWorkgroupIDLabel { get; }
			public Selector PriceManagerID { get; }
			public Label PriceManagerIDLabel { get; }
			public CheckBox Commisionable { get; }
			public Label CommisionableLabel { get; }
			public PXNumberEdit MinGrossProfitPct { get; }
			public Label MinGrossProfitPctLabel { get; }
			public PXNumberEdit MarkupPct { get; }
			public Label MarkupPctLabel { get; }
			public PXNumberEdit RecPrice { get; }
			public Label RecPriceLabel { get; }
			public PXNumberEdit BasePrice { get; }
			public Label BasePriceLabel { get; }
			public PXNumberEdit PendingStdCost { get; }
			public Label PendingStdCostLabel { get; }
			public DateSelector PendingStdCostDate { get; }
			public Label PendingStdCostDateLabel { get; }
			public PXNumberEdit StdCost { get; }
			public Label StdCostLabel { get; }
			public DateSelector StdCostDate { get; }
			public Label StdCostDateLabel { get; }
			public PXNumberEdit LastStdCost { get; }
			public Label LastStdCostLabel { get; }
			public CheckBox AccrueCost { get; }
			public Label AccrueCostLabel { get; }
			public DropDown CostBasis { get; }
			public Label CostBasisLabel { get; }
			public PXNumberEdit PercentOfSalesPrice { get; }
			public Label PercentOfSalesPriceLabel { get; }
			public Selector DfltEarningType { get; }
			public Label DfltEarningTypeLabel { get; }
			public Selector InvtAcctID { get; }
			public Label InvtAcctIDLabel { get; }
			public Selector ExpenseAccrualAcctID { get; }
			public Label ExpenseAccrualAcctIDLabel { get; }
			public Selector InvtSubID { get; }
			public Label InvtSubIDLabel { get; }
			public Selector ExpenseAccrualSubID { get; }
			public Label ExpenseAccrualSubIDLabel { get; }
			public Selector ReasonCodeSubID { get; }
			public Label ReasonCodeSubIDLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public Selector COGSAcctID { get; }
			public Label COGSAcctIDLabel { get; }
			public Selector ExpenseAcctID { get; }
			public Label ExpenseAcctIDLabel { get; }
			public Selector COGSSubID { get; }
			public Label COGSSubIDLabel { get; }
			public Selector ExpenseSubID { get; }
			public Label ExpenseSubIDLabel { get; }
			public Selector StdCstVarAcctID { get; }
			public Label StdCstVarAcctIDLabel { get; }
			public Selector StdCstVarSubID { get; }
			public Label StdCstVarSubIDLabel { get; }
			public Selector StdCstRevAcctID { get; }
			public Label StdCstRevAcctIDLabel { get; }
			public Selector StdCstRevSubID { get; }
			public Label StdCstRevSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public Selector PPVAcctID { get; }
			public Label PPVAcctIDLabel { get; }
			public Selector PPVSubID { get; }
			public Label PPVSubIDLabel { get; }
			public Selector LCVarianceAcctID { get; }
			public Label LCVarianceAcctIDLabel { get; }
			public Selector LCVarianceSubID { get; }
			public Label LCVarianceSubIDLabel { get; }
			public Selector DeferralAcctID { get; }
			public Label DeferralAcctIDLabel { get; }
			public Selector DeferralSubID { get; }
			public Label DeferralSubIDLabel { get; }
			public RichTextEdit Body { get; }
			public Label BodyLabel { get; }
			public Selector DefaultColumnMatrixAttributeID { get; }
			public Label DefaultColumnMatrixAttributeIDLabel { get; }
			public Selector DefaultRowMatrixAttributeID { get; }
			public Label DefaultRowMatrixAttributeIDLabel { get; }
			public DropDown Visibility { get; }
			public Label VisibilityLabel { get; }
			public DropDown Availability { get; }
			public Label AvailabilityLabel { get; }
			public DropDown NotAvailMode { get; }
			public Label NotAvailModeLabel { get; }
			public PXTextEdit CustomURL { get; }
			public Label CustomURLLabel { get; }
			public InputLocalizable PageTitle { get; }
			public Label PageTitleLabel { get; }
			public InputLocalizable ShortDescription { get; }
			public Label ShortDescriptionLabel { get; }
			public InputLocalizable SearchKeywords { get; }
			public Label SearchKeywordsLabel { get; }
			public InputLocalizable MetaKeywords { get; }
			public Label MetaKeywordsLabel { get; }
			public InputLocalizable MetaDescription { get; }
			public Label MetaDescriptionLabel { get; }
			public Label Ctl08_ { get; }
			public Label Ctl21_ { get; }
			public Label Pixwidth_ { get; }
			public Label Pixcaption_ { get; }
			public Label Ctl34_ { get; }
            
            public c_itemsettings_tab(string locator, string name) : 
                    base(locator, name)
            {
                ItemStatus = new DropDown("ctl00_phG_tab_t0_edItemStatus", "Item Status", locator, null);
                ItemStatusLabel = new Label(ItemStatus);
                ItemStatus.DataField = "ItemStatus";
                ItemStatus.Items.Add("AC", "Active");
                ItemStatus.Items.Add("NS", "No Sales");
                ItemStatus.Items.Add("NP", "No Purchases");
                ItemStatus.Items.Add("NR", "No Request");
                ItemStatus.Items.Add("IN", "Inactive");
                ItemStatus.Items.Add("DE", "Marked for Deletion");
                ItemClassID = new Selector("ctl00_phG_tab_t0_edItemClassID", "Item Class", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                ItemType = new DropDown("ctl00_phG_tab_t0_edItemType", "Type", locator, null);
                ItemTypeLabel = new Label(ItemType);
                ItemType.DataField = "ItemType";
                ItemType.Items.Add("F", "Finished Good");
                ItemType.Items.Add("M", "Component Part");
                ItemType.Items.Add("A", "Subassembly");
                ValMethod = new DropDown("ctl00_phG_tab_t0_edValMethod", "Valuation Method", locator, null);
                ValMethodLabel = new Label(ValMethod);
                ValMethod.DataField = "ValMethod";
                ValMethod.Items.Add("T", "Standard");
                ValMethod.Items.Add("A", "Average");
                ValMethod.Items.Add("F", "FIFO");
                ValMethod.Items.Add("S", "Specific");
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                PostClassID = new Selector("ctl00_phG_tab_t0_edPostClassID", "Posting Class", locator, null);
                PostClassIDLabel = new Label(PostClassID);
                PostClassID.DataField = "PostClassID";
                LotSerClassID = new Selector("ctl00_phG_tab_t0_edLotSerClassID", "Lot/Serial Class", locator, null);
                LotSerClassIDLabel = new Label(LotSerClassID);
                LotSerClassID.DataField = "LotSerClassID";
                CountryOfOrigin = new Selector("ctl00_phG_tab_t0_edCountryOfOrigin", "Country Of Origin", locator, null);
                CountryOfOriginLabel = new Label(CountryOfOrigin);
                CountryOfOrigin.DataField = "CountryOfOrigin";
                NonStockReceipt = new CheckBox("ctl00_phG_tab_t0_chkNonStockReceipt", "Require Receipt", locator, null);
                NonStockReceiptLabel = new Label(NonStockReceipt);
                NonStockReceipt.DataField = "NonStockReceipt";
                NonStockShip = new CheckBox("ctl00_phG_tab_t0_chkNonStockShip", "Require Shipment", locator, null);
                NonStockShipLabel = new Label(NonStockShip);
                NonStockShip.DataField = "NonStockShip";
                CompletePOLine = new DropDown("ctl00_phG_tab_t0_edCompletePOLine", "Close PO Line", locator, null);
                CompletePOLineLabel = new Label(CompletePOLine);
                CompletePOLine.DataField = "CompletePOLine";
                CompletePOLine.Items.Add("A", "By Amount");
                CompletePOLine.Items.Add("Q", "By Quantity");
                EstimatedDuration = new PXTextEdit("ctl00_phG_tab_t0_edEstimatedDuration", "Estimated Duration", locator, null);
                EstimatedDurationLabel = new Label(EstimatedDuration);
                EstimatedDuration.DataField = "EstimatedDuration";
                DfltSiteID = new Selector("ctl00_phG_tab_t0_edDfltSiteID", "Default Warehouse", locator, null);
                DfltSiteIDLabel = new Label(DfltSiteID);
                DfltSiteID.DataField = "DfltSiteID";
                DfltShipLocationID = new Selector("ctl00_phG_tab_t0_edDfltShipLocationID", "Default Issue From", locator, null);
                DfltShipLocationIDLabel = new Label(DfltShipLocationID);
                DfltShipLocationID.DataField = "DfltShipLocationID";
                DfltReceiptLocationID = new Selector("ctl00_phG_tab_t0_edDfltReceiptLocationID", "Default Receipt To", locator, null);
                DfltReceiptLocationIDLabel = new Label(DfltReceiptLocationID);
                DfltReceiptLocationID.DataField = "DfltReceiptLocationID";
                DefaultSubItemID = new Selector("ctl00_phG_tab_t0_edDefaultSubItemID", "Default Subitem", locator, null);
                DefaultSubItemIDLabel = new Label(DefaultSubItemID);
                DefaultSubItemID.DataField = "DefaultSubItemID";
                DefaultSubItemOnEntry = new CheckBox("ctl00_phG_tab_t0_chkDefaultSubItemOnEntry", "Use On Entry", locator, null);
                DefaultSubItemOnEntryLabel = new Label(DefaultSubItemOnEntry);
                DefaultSubItemOnEntry.DataField = "DefaultSubItemOnEntry";
                BaseUnit = new Selector("ctl00_phG_tab_t0_edBaseUnit", "Base Unit", locator, null);
                BaseUnitLabel = new Label(BaseUnit);
                BaseUnit.DataField = "BaseUnit";
                DecimalBaseUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalBaseUnit", "Divisible Unit", locator, null);
                DecimalBaseUnitLabel = new Label(DecimalBaseUnit);
                DecimalBaseUnit.DataField = "DecimalBaseUnit";
                SalesUnit = new Selector("ctl00_phG_tab_t0_edSalesUnit", "Sales Unit", locator, null);
                SalesUnitLabel = new Label(SalesUnit);
                SalesUnit.DataField = "SalesUnit";
                DecimalSalesUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalSalesUnit", "Divisible Unit", locator, null);
                DecimalSalesUnitLabel = new Label(DecimalSalesUnit);
                DecimalSalesUnit.DataField = "DecimalSalesUnit";
                PurchaseUnit = new Selector("ctl00_phG_tab_t0_edPurchaseUnit", "Purchase Unit", locator, null);
                PurchaseUnitLabel = new Label(PurchaseUnit);
                PurchaseUnit.DataField = "PurchaseUnit";
                DecimalPurchaseUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalPurchaseUnit", "Divisible Unit", locator, null);
                DecimalPurchaseUnitLabel = new Label(DecimalPurchaseUnit);
                DecimalPurchaseUnit.DataField = "DecimalPurchaseUnit";
                CycleID = new Selector("ctl00_phG_tab_t0_edPICycleID", "PI Cycle", locator, null);
                CycleIDLabel = new Label(CycleID);
                CycleID.DataField = "CycleID";
                ABCCodeID = new Selector("ctl00_phG_tab_t0_edABCCodeID", "ABC Code", locator, null);
                ABCCodeIDLabel = new Label(ABCCodeID);
                ABCCodeID.DataField = "ABCCodeID";
                ABCCodeIsFixed = new CheckBox("ctl00_phG_tab_t0_chkABCCodeIsFixed", "Fixed ABC Code", locator, null);
                ABCCodeIsFixedLabel = new Label(ABCCodeIsFixed);
                ABCCodeIsFixed.DataField = "ABCCodeIsFixed";
                MovementClassID = new Selector("ctl00_phG_tab_t0_edMovementClassID", "Movement Class", locator, null);
                MovementClassIDLabel = new Label(MovementClassID);
                MovementClassID.DataField = "MovementClassID";
                MovementClassIsFixed = new CheckBox("ctl00_phG_tab_t0_chkMovementClassIsFixed", "Fixed Movement Class", locator, null);
                MovementClassIsFixedLabel = new Label(MovementClassIsFixed);
                MovementClassIsFixed.DataField = "MovementClassIsFixed";
                BaseItemWeight = new PXNumberEdit("ctl00_phG_tab_t1_edBaseItemWeight", "Weight", locator, null);
                BaseItemWeightLabel = new Label(BaseItemWeight);
                BaseItemWeight.DataField = "BaseItemWeight";
                WeightUOM = new Selector("ctl00_phG_tab_t1_edWeightUOM", "Weight UOM", locator, null);
                WeightUOMLabel = new Label(WeightUOM);
                WeightUOM.DataField = "WeightUOM";
                BaseItemVolume = new PXNumberEdit("ctl00_phG_tab_t1_edBaseItemVolume", "Volume", locator, null);
                BaseItemVolumeLabel = new Label(BaseItemVolume);
                BaseItemVolume.DataField = "BaseItemVolume";
                VolumeUOM = new Selector("ctl00_phG_tab_t1_edVolumeUOM", "Volume UOM", locator, null);
                VolumeUOMLabel = new Label(VolumeUOM);
                VolumeUOM.DataField = "VolumeUOM";
                HSTariffCode = new PXTextEdit("ctl00_phG_tab_t1_edHSTariffCode", "Tariff Code", locator, null);
                HSTariffCodeLabel = new Label(HSTariffCode);
                HSTariffCode.DataField = "HSTariffCode";
                UndershipThreshold = new PXNumberEdit("ctl00_phG_tab_t1_edUndershipThreshold", "Undership Threshold (%)", locator, null);
                UndershipThresholdLabel = new Label(UndershipThreshold);
                UndershipThreshold.DataField = "UndershipThreshold";
                OvershipThreshold = new PXNumberEdit("ctl00_phG_tab_t1_edOvershipThreshold", "Overship Threshold (%)", locator, null);
                OvershipThresholdLabel = new Label(OvershipThreshold);
                OvershipThreshold.DataField = "OvershipThreshold";
                PackageOption = new DropDown("ctl00_phG_tab_t1_edPackageOption", "Packaging Option", locator, null);
                PackageOptionLabel = new Label(PackageOption);
                PackageOption.DataField = "PackageOption";
                PackageOption.Items.Add("N", "Manual");
                PackageOption.Items.Add("W", "By Weight");
                PackageOption.Items.Add("Q", "By Quantity");
                PackageOption.Items.Add("V", "By Weight & Volume");
                PackSeparately = new CheckBox("ctl00_phG_tab_t1_edPackSeparately", "Pack Separately", locator, null);
                PackSeparatelyLabel = new Label(PackSeparately);
                PackSeparately.DataField = "PackSeparately";
                PriceClassID = new Selector("ctl00_phG_tab_t2_edPriceClassID", "Price Class", locator, null);
                PriceClassIDLabel = new Label(PriceClassID);
                PriceClassID.DataField = "PriceClassID";
                PriceWorkgroupID = new Selector("ctl00_phG_tab_t2_edPriceWorkgroupID", "Price Workgroup", locator, null);
                PriceWorkgroupIDLabel = new Label(PriceWorkgroupID);
                PriceWorkgroupID.DataField = "PriceWorkgroupID";
                PriceManagerID = new Selector("ctl00_phG_tab_t2_edPriceManagerID", "Price Manager", locator, null);
                PriceManagerIDLabel = new Label(PriceManagerID);
                PriceManagerID.DataField = "PriceManagerID";
                Commisionable = new CheckBox("ctl00_phG_tab_t2_chkCommisionable", "Subject to Commission", locator, null);
                CommisionableLabel = new Label(Commisionable);
                Commisionable.DataField = "Commisionable";
                MinGrossProfitPct = new PXNumberEdit("ctl00_phG_tab_t2_edMinGrossProfitPct", "Min. Markup %", locator, null);
                MinGrossProfitPctLabel = new Label(MinGrossProfitPct);
                MinGrossProfitPct.DataField = "MinGrossProfitPct";
                MarkupPct = new PXNumberEdit("ctl00_phG_tab_t2_edMarkupPct", "Markup %", locator, null);
                MarkupPctLabel = new Label(MarkupPct);
                MarkupPct.DataField = "MarkupPct";
                RecPrice = new PXNumberEdit("ctl00_phG_tab_t2_edRecPrice", "MSRP", locator, null);
                RecPriceLabel = new Label(RecPrice);
                RecPrice.DataField = "RecPrice";
                BasePrice = new PXNumberEdit("ctl00_phG_tab_t2_edBasePrice", "Default Price", locator, null);
                BasePriceLabel = new Label(BasePrice);
                BasePrice.DataField = "BasePrice";
                PendingStdCost = new PXNumberEdit("ctl00_phG_tab_t2_edPendingStdCost", "Pending Cost", locator, null);
                PendingStdCostLabel = new Label(PendingStdCost);
                PendingStdCost.DataField = "PendingStdCost";
                PendingStdCostDate = new DateSelector("ctl00_phG_tab_t2_edPendingStdCostDate", "Pending Cost Date", locator, null);
                PendingStdCostDateLabel = new Label(PendingStdCostDate);
                PendingStdCostDate.DataField = "PendingStdCostDate";
                StdCost = new PXNumberEdit("ctl00_phG_tab_t2_edStdCost", "Current Cost", locator, null);
                StdCostLabel = new Label(StdCost);
                StdCost.DataField = "StdCost";
                StdCostDate = new DateSelector("ctl00_phG_tab_t2_edStdCostDate", "Effective Date", locator, null);
                StdCostDateLabel = new Label(StdCostDate);
                StdCostDate.DataField = "StdCostDate";
                LastStdCost = new PXNumberEdit("ctl00_phG_tab_t2_edLastStdCost", "Last Cost", locator, null);
                LastStdCostLabel = new Label(LastStdCost);
                LastStdCost.DataField = "LastStdCost";
                AccrueCost = new CheckBox("ctl00_phG_tab_t2_chkAccrueCost", "Accrue Cost", locator, null);
                AccrueCostLabel = new Label(AccrueCost);
                AccrueCost.DataField = "AccrueCost";
                CostBasis = new DropDown("ctl00_phG_tab_t2_edCostBasis", "Cost Based On", locator, null);
                CostBasisLabel = new Label(CostBasis);
                CostBasis.DataField = "CostBasis";
                CostBasis.Items.Add("S", "Standard Cost");
                CostBasis.Items.Add("M", "Markup %");
                CostBasis.Items.Add("P", "Percentage of Sales Price");
                PercentOfSalesPrice = new PXNumberEdit("ctl00_phG_tab_t2_edPercentOfSalesPrice", "Percent of Sales Price", locator, null);
                PercentOfSalesPriceLabel = new Label(PercentOfSalesPrice);
                PercentOfSalesPrice.DataField = "PercentOfSalesPrice";
                DfltEarningType = new Selector("ctl00_phG_tab_t2_edDfltEarningType", "Earning Type", locator, null);
                DfltEarningTypeLabel = new Label(DfltEarningType);
                DfltEarningType.DataField = "DfltEarningType";
                InvtAcctID = new Selector("ctl00_phG_tab_t4_edInvtAcctID", "Inventory Account", locator, null);
                InvtAcctIDLabel = new Label(InvtAcctID);
                InvtAcctID.DataField = "InvtAcctID";
                ExpenseAccrualAcctID = new Selector("ctl00_phG_tab_t4_edNonStockInvtAcctID", "Expense Accrual Account", locator, null);
                ExpenseAccrualAcctIDLabel = new Label(ExpenseAccrualAcctID);
                ExpenseAccrualAcctID.DataField = "ExpenseAccrualAcctID";
                InvtSubID = new Selector("ctl00_phG_tab_t4_edInvtSubID", "Inventory Sub.", locator, null);
                InvtSubIDLabel = new Label(InvtSubID);
                InvtSubID.DataField = "InvtSubID";
                ExpenseAccrualSubID = new Selector("ctl00_phG_tab_t4_edNonStockInvtSubID", "Expense Accrual Sub.", locator, null);
                ExpenseAccrualSubIDLabel = new Label(ExpenseAccrualSubID);
                ExpenseAccrualSubID.DataField = "ExpenseAccrualSubID";
                ReasonCodeSubID = new Selector("ctl00_phG_tab_t4_edReasonCodeSubID", "Reason Code Sub.", locator, null);
                ReasonCodeSubIDLabel = new Label(ReasonCodeSubID);
                ReasonCodeSubID.DataField = "ReasonCodeSubID";
                SalesAcctID = new Selector("ctl00_phG_tab_t4_edSalesAcctID", "Sales Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t4_edSalesSubID", "Sales Sub.", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                COGSAcctID = new Selector("ctl00_phG_tab_t4_edCOGSAcctID", "COGS Account", locator, null);
                COGSAcctIDLabel = new Label(COGSAcctID);
                COGSAcctID.DataField = "COGSAcctID";
                ExpenseAcctID = new Selector("ctl00_phG_tab_t4_edNonStockCOGSAcctID", "Expense Account", locator, null);
                ExpenseAcctIDLabel = new Label(ExpenseAcctID);
                ExpenseAcctID.DataField = "ExpenseAcctID";
                COGSSubID = new Selector("ctl00_phG_tab_t4_edCOGSSubID", "COGS Sub.", locator, null);
                COGSSubIDLabel = new Label(COGSSubID);
                COGSSubID.DataField = "COGSSubID";
                ExpenseSubID = new Selector("ctl00_phG_tab_t4_edNonStockCOGSSubID", "Expense Sub.", locator, null);
                ExpenseSubIDLabel = new Label(ExpenseSubID);
                ExpenseSubID.DataField = "ExpenseSubID";
                StdCstVarAcctID = new Selector("ctl00_phG_tab_t4_edStdCstVarAcctID", "Standard Cost Variance Account", locator, null);
                StdCstVarAcctIDLabel = new Label(StdCstVarAcctID);
                StdCstVarAcctID.DataField = "StdCstVarAcctID";
                StdCstVarSubID = new Selector("ctl00_phG_tab_t4_edStdCstVarSubID", "Standard Cost Variance Sub.", locator, null);
                StdCstVarSubIDLabel = new Label(StdCstVarSubID);
                StdCstVarSubID.DataField = "StdCstVarSubID";
                StdCstRevAcctID = new Selector("ctl00_phG_tab_t4_edStdCstRevAcctID", "Standard Cost Revaluation Account", locator, null);
                StdCstRevAcctIDLabel = new Label(StdCstRevAcctID);
                StdCstRevAcctID.DataField = "StdCstRevAcctID";
                StdCstRevSubID = new Selector("ctl00_phG_tab_t4_edStdCstRevSubID", "Standard Cost Revaluation Sub.", locator, null);
                StdCstRevSubIDLabel = new Label(StdCstRevSubID);
                StdCstRevSubID.DataField = "StdCstRevSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t4_edPOAccrualAcctID", "PO Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t4_edPOAccrualSubID", "PO Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                PPVAcctID = new Selector("ctl00_phG_tab_t4_edPPVAcctID", "Purchase Price Variance Account", locator, null);
                PPVAcctIDLabel = new Label(PPVAcctID);
                PPVAcctID.DataField = "PPVAcctID";
                PPVSubID = new Selector("ctl00_phG_tab_t4_edPPVSubID", "Purchase Price Variance Sub.", locator, null);
                PPVSubIDLabel = new Label(PPVSubID);
                PPVSubID.DataField = "PPVSubID";
                LCVarianceAcctID = new Selector("ctl00_phG_tab_t4_edLCVarianceAcctID", "Landed Cost Variance Account", locator, null);
                LCVarianceAcctIDLabel = new Label(LCVarianceAcctID);
                LCVarianceAcctID.DataField = "LCVarianceAcctID";
                LCVarianceSubID = new Selector("ctl00_phG_tab_t4_edLCVarianceSubID", "Landed Cost Variance Sub.", locator, null);
                LCVarianceSubIDLabel = new Label(LCVarianceSubID);
                LCVarianceSubID.DataField = "LCVarianceSubID";
                DeferralAcctID = new Selector("ctl00_phG_tab_t4_edDeferralAcctID", "Deferral Account", locator, null);
                DeferralAcctIDLabel = new Label(DeferralAcctID);
                DeferralAcctID.DataField = "DeferralAcctID";
                DeferralSubID = new Selector("ctl00_phG_tab_t4_edDeferralSubID", "Deferral Sub.", locator, null);
                DeferralSubIDLabel = new Label(DeferralSubID);
                DeferralSubID.DataField = "DeferralSubID";
                Body = new RichTextEdit("ctl00_phG_tab_t5_edBody", "Body", locator, null);
                BodyLabel = new Label(Body);
                Body.DataField = "Body";
                DefaultColumnMatrixAttributeID = new Selector("ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID", "Default Column Attribute ID", locator, null);
                DefaultColumnMatrixAttributeIDLabel = new Label(DefaultColumnMatrixAttributeID);
                DefaultColumnMatrixAttributeID.DataField = "DefaultColumnMatrixAttributeID";
                DefaultRowMatrixAttributeID = new Selector("ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID", "Default Row Attribute ID", locator, null);
                DefaultRowMatrixAttributeIDLabel = new Label(DefaultRowMatrixAttributeID);
                DefaultRowMatrixAttributeID.DataField = "DefaultRowMatrixAttributeID";
                Visibility = new DropDown("ctl00_phG_tab_t9_edVisibility", "Visibility", locator, null);
                VisibilityLabel = new Label(Visibility);
                Visibility.DataField = "Visibility";
                Visibility.Items.Add("V", "Visible");
                Visibility.Items.Add("F", "Featured");
                Visibility.Items.Add("I", "Invisible");
                Availability = new DropDown("ctl00_phG_tab_t9_edAvailability", "Availability", locator, null);
                AvailabilityLabel = new Label(Availability);
                Availability.DataField = "Availability";
                Availability.Items.Add("X", "Store Default");
                Availability.Items.Add("T", "Available - Track Qty");
                Availability.Items.Add("S", "Available - Don\'t Track Qty");
                Availability.Items.Add("P", "Pre-Order");
                Availability.Items.Add("D", "Disabled");
                NotAvailMode = new DropDown("ctl00_phG_tab_t9_edNotAvailMode", "When Qty Unavailable", locator, null);
                NotAvailModeLabel = new Label(NotAvailMode);
                NotAvailMode.DataField = "NotAvailMode";
                NotAvailMode.Items.Add("X", "Store Default");
                NotAvailMode.Items.Add("N", "Do Nothing");
                NotAvailMode.Items.Add("D", "Set as Disabled");
                NotAvailMode.Items.Add("P", "Set as Pre-Order");
                CustomURL = new PXTextEdit("ctl00_phG_tab_t9_edCustomURL", "Custom URL", locator, null);
                CustomURLLabel = new Label(CustomURL);
                CustomURL.DataField = "CustomURL";
                PageTitle = new InputLocalizable("ctl00_phG_tab_t9_edPageTitle", "Page Title", locator, null);
                PageTitleLabel = new Label(PageTitle);
                PageTitle.DataField = "PageTitle";
                ShortDescription = new InputLocalizable("ctl00_phG_tab_t9_edShortDescription", "Short Description", locator, null);
                ShortDescriptionLabel = new Label(ShortDescription);
                ShortDescription.DataField = "ShortDescription";
                SearchKeywords = new InputLocalizable("ctl00_phG_tab_t9_edSearchKeywords", "Search Keywords", locator, null);
                SearchKeywordsLabel = new Label(SearchKeywords);
                SearchKeywords.DataField = "SearchKeywords";
                MetaKeywords = new InputLocalizable("ctl00_phG_tab_t9_edMetaKeywords", "Meta Keywords", locator, null);
                MetaKeywordsLabel = new Label(MetaKeywords);
                MetaKeywords.DataField = "MetaKeywords";
                MetaDescription = new InputLocalizable("ctl00_phG_tab_t9_edMetaDescription", "Meta Description", locator, null);
                MetaDescriptionLabel = new Label(MetaDescription);
                MetaDescription.DataField = "MetaDescription";
                Ctl08_ = new Label("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_ctl08", "Enter file URL here", locator, null);
                Ctl21_ = new Label("ctl00_phG_tab_t5_edBody_insi2_splitter_rpnl_ctl21", "Enter image URL:", locator, null);
                Pixwidth_ = new Label("ctl00_phG_tab_t5_edBody_imgprops_pixwidth", "Width", locator, null);
                Pixcaption_ = new Label("ctl00_phG_tab_t5_edBody_imgprops_pixcaption", "Caption", locator, null);
                Ctl34_ = new Label("ctl00_phG_tab_t5_edBody_imgprops_ctl34", "px", locator, null);
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Confirmation()
            {
                Buttons.Confirmation.Click();
            }
            
            public virtual void ItemClassIDEdit()
            {
                Buttons.ItemClassIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void LotSerClassIDEdit()
            {
                Buttons.LotSerClassIDEdit.Click();
            }
            
            public virtual void DfltSiteIDEdit()
            {
                Buttons.DfltSiteIDEdit.Click();
            }
            
            public virtual void DfltShipLocationIDEdit()
            {
                Buttons.DfltShipLocationIDEdit.Click();
            }
            
            public virtual void DfltReceiptLocationIDEdit()
            {
                Buttons.DfltReceiptLocationIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
            }
            
            public virtual void CycleIDEdit()
            {
                Buttons.CycleIDEdit.Click();
            }
            
            public virtual void ABCCodeIDEdit()
            {
                Buttons.ABCCodeIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirmation { get; }
			public Button ItemClassIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button DfltSiteIDEdit { get; }
			public Button DfltShipLocationIDEdit { get; }
			public Button DfltReceiptLocationIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button CycleIDEdit { get; }
			public Button ABCCodeIDEdit { get; }
			public Button MovementClassIDEdit { get; }
			public Button PriceClassIDEdit { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Confirmation = new Button("ctl00_phG_tab_t7_popupCreate_btnCreateUpdate", "Confirmation", "ctl00_phG_tab");
                    ItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edItemClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "ItemClassIDEdit", "ctl00_phG_tab");
                    ItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab");
                    PostClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edLotSerClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LotSerClassIDEdit", "ctl00_phG_tab");
                    LotSerClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DfltSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edDfltSiteID\'] div[class=\'editBtnCont\'] > div > div", "DfltSiteIDEdit", "ctl00_phG_tab");
                    DfltSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DfltShipLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edDfltShipLocationID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "DfltShipLocationIDEdit", "ctl00_phG_tab");
                    DfltShipLocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DfltReceiptLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edDfltReceiptLocationID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DfltReceiptLocationIDEdit", "ctl00_phG_tab");
                    DfltReceiptLocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab");
                    BaseUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab");
                    SalesUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab");
                    PurchaseUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    CycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPICycleID\'] div[class=\'editBtnCont\'] > div > div", "CycleIDEdit", "ctl00_phG_tab");
                    CycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ABCCodeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edABCCodeID\'] div[class=\'editBtnCont\'] > div > div", "ABCCodeIDEdit", "ctl00_phG_tab");
                    ABCCodeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab");
                    MovementClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab");
                    PriceClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_tab");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_tab");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_itemclass_tab : Container
        {
            
			public CheckBox Mem_RouteService { get; }
			public Label Mem_RouteServiceLabel { get; }
            
            public c_itemclass_tab(string locator, string name) : 
                    base(locator, name)
            {
                Mem_RouteService = new CheckBox("ctl00_phG_tab_t0_edRouteService", "Route Service", locator, null);
                Mem_RouteServiceLabel = new Label(Mem_RouteService);
                Mem_RouteService.DataField = "Mem_RouteService";
                DataMemberName = "ItemClass";
            }
        }
        
        public class c_itemunits_gridunits : Grid<c_itemunits_gridunits.c_grid_row, c_itemunits_gridunits.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_itemunits_gridunits(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_gridUnits");
                DataMemberName = "itemunits";
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
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void LotSerClassIDEdit()
            {
                Buttons.LotSerClassIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
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
            
            public virtual void CycleIDEdit()
            {
                Buttons.CycleIDEdit.Click();
            }
            
            public virtual void ABCCodeIDEdit()
            {
                Buttons.ABCCodeIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button CycleIDEdit { get; }
			public Button ABCCodeIDEdit { get; }
			public Button MovementClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    PostClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edLotSerClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LotSerClassIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    LotSerClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    BaseUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    SalesUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    PurchaseUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_tab_t0_gridUnits");
                    Prev = new Button("ctl00_phG_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridUnits");
                    Next = new Button("ctl00_phG_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_tab_t0_gridUnits");
                    Last = new Button("ctl00_phG_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_tab_t0_gridUnits");
                    CycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPICycleID\'] div[class=\'editBtnCont\'] > div > div", "CycleIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    CycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ABCCodeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edABCCodeID\'] div[class=\'editBtnCont\'] > div > div", "ABCCodeIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    ABCCodeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    MovementClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown UnitType { get; }
			public PXNumberEdit ItemClassID { get; }
			public PXNumberEdit InventoryID { get; }
			public PXTextEdit FromUnit { get; }
			public DropDown UnitMultDiv { get; }
			public PXNumberEdit UnitRate { get; }
			public PXTextEdit SampleToUnit { get; }
			public PXNumberEdit PriceAdjustmentMultiplier { get; }
			public Selector ToUnit { get; }
                
                public c_grid_row(c_itemunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDown("_ctl00_phG_tab_t0_gridUnits_lv0_ec", "Unit Type", grid.Locator, "UnitType");
                    UnitType.DataField = "UnitType";
                    UnitType.Items.Add("1", "Inventory Item");
                    UnitType.Items.Add("2", "Item Class");
                    UnitType.Items.Add("3", "Global");
                    ItemClassID = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    InventoryID = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    FromUnit = new PXTextEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", grid.Locator, "FromUnit");
                    FromUnit.DataField = "FromUnit";
                    UnitMultDiv = new DropDown("_ctl00_phG_tab_t0_gridUnits_lv0_ec", "Multiply/Divide", grid.Locator, "UnitMultDiv");
                    UnitMultDiv.DataField = "UnitMultDiv";
                    UnitMultDiv.Items.Add("M", "Multiply");
                    UnitMultDiv.Items.Add("D", "Divide");
                    UnitRate = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", grid.Locator, "UnitRate");
                    UnitRate.DataField = "UnitRate";
                    SampleToUnit = new PXTextEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", grid.Locator, "SampleToUnit");
                    SampleToUnit.DataField = "SampleToUnit";
                    PriceAdjustmentMultiplier = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_en", "Price Adjustment Multiplier", grid.Locator, "PriceAdjustmentMultiplier");
                    PriceAdjustmentMultiplier.DataField = "PriceAdjustmentMultiplier";
                    ToUnit = new Selector("_ctl00_phG_tab_t0_gridUnits_lv0_es", "To Unit", grid.Locator, "ToUnit");
                    ToUnit.DataField = "ToUnit";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter UnitType { get; }
				public PXNumberEditColumnFilter ItemClassID { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter FromUnit { get; }
				public DropDownColumnFilter UnitMultDiv { get; }
				public PXNumberEditColumnFilter UnitRate { get; }
				public PXTextEditColumnFilter SampleToUnit { get; }
				public PXNumberEditColumnFilter PriceAdjustmentMultiplier { get; }
				public SelectorColumnFilter ToUnit { get; }
                
                public c_grid_header(c_itemunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDownColumnFilter(grid.Row.UnitType);
                    ItemClassID = new PXNumberEditColumnFilter(grid.Row.ItemClassID);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    FromUnit = new PXTextEditColumnFilter(grid.Row.FromUnit);
                    UnitMultDiv = new DropDownColumnFilter(grid.Row.UnitMultDiv);
                    UnitRate = new PXNumberEditColumnFilter(grid.Row.UnitRate);
                    SampleToUnit = new PXTextEditColumnFilter(grid.Row.SampleToUnit);
                    PriceAdjustmentMultiplier = new PXNumberEditColumnFilter(grid.Row.PriceAdjustmentMultiplier);
                    ToUnit = new SelectorColumnFilter(grid.Row.ToUnit);
                }
            }
        }
        
        public class c_itemunits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public PXNumberEdit InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public PXTextEdit FromUnit { get; }
			public Label FromUnitLabel { get; }
			public PXTextEdit SampleToUnit { get; }
			public Label SampleToUnitLabel { get; }
			public PXNumberEdit UnitRate { get; }
			public Label UnitRateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_itemunits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ItemClassID = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                InventoryID = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                FromUnit = new PXTextEdit("ctl00_phG_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", locator, null);
                FromUnitLabel = new Label(FromUnit);
                FromUnit.DataField = "FromUnit";
                SampleToUnit = new PXTextEdit("ctl00_phG_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", locator, null);
                SampleToUnitLabel = new Label(SampleToUnit);
                SampleToUnit.DataField = "SampleToUnit";
                UnitRate = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", locator, null);
                UnitRateLabel = new Label(UnitRate);
                UnitRate.DataField = "UnitRate";
                Es = new Selector("ctl00_phG_tab_t0_gridUnits_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t0_gridUnits_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_gridUnits_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t0_gridUnits_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "itemunits";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void LotSerClassIDEdit()
            {
                Buttons.LotSerClassIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
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
            
            public virtual void CycleIDEdit()
            {
                Buttons.CycleIDEdit.Click();
            }
            
            public virtual void ABCCodeIDEdit()
            {
                Buttons.ABCCodeIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button CycleIDEdit { get; }
			public Button ABCCodeIDEdit { get; }
			public Button MovementClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    PostClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edLotSerClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LotSerClassIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    LotSerClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    BaseUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    SalesUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    PurchaseUnitEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    First = new Button("ctl00_phG_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Next = new Button("ctl00_phG_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Last = new Button("ctl00_phG_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_tab_t0_gridUnits_lv0");
                    CycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPICycleID\'] div[class=\'editBtnCont\'] > div > div", "CycleIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    CycleIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ABCCodeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edABCCodeID\'] div[class=\'editBtnCont\'] > div > div", "ABCCodeIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    ABCCodeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    MovementClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_vendoritems_pxgridvendoritems : Grid<c_vendoritems_pxgridvendoritems.c_grid_row, c_vendoritems_pxgridvendoritems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_vendoritems_pxgridvendoritems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_PXGridVendorItems");
                DataMemberName = "VendorItems";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_PXGridVendorItems_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_PXGridVendorItems_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public CheckBox IsDefault { get; }
			public Selector VendorID { get; }
			public PXTextEdit Vendor__AcctName { get; }
			public Selector VendorLocationID { get; }
			public Selector Location__VSiteID { get; }
			public Selector SubItemID { get; }
			public Selector PurchaseUnit { get; }
			public PXNumberEdit Location__VLeadTime { get; }
			public CheckBox OverrideSettings { get; }
			public PXNumberEdit AddLeadTimeDays { get; }
			public PXNumberEdit MinOrdFreq { get; }
			public PXNumberEdit MinOrdQty { get; }
			public PXNumberEdit MaxOrdQty { get; }
			public PXNumberEdit LotSize { get; }
			public PXNumberEdit ERQ { get; }
			public Selector CuryID { get; }
			public PXNumberEdit LastPrice { get; }
			public PXNumberEdit PrepaymentPct { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_vendoritems_pxgridvendoritems grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_vp_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    IsDefault = new CheckBox("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_chkIsDefault", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    VendorID = new Selector("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendorID", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    Vendor__AcctName = new PXTextEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendor__AcctName", "Vendor Name", grid.Locator, "Vendor__AcctName");
                    Vendor__AcctName.DataField = "Vendor__AcctName";
                    VendorLocationID = new Selector("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendorLocationID", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    Location__VSiteID = new Selector("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLocation__VSiteID", "Warehouse", grid.Locator, "Location__VSiteID");
                    Location__VSiteID.DataField = "Location__VSiteID";
                    SubItemID = new Selector("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_vp_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    PurchaseUnit = new Selector("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_es", "Purchase Unit", grid.Locator, "PurchaseUnit");
                    PurchaseUnit.DataField = "PurchaseUnit";
                    Location__VLeadTime = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLocation__VLeadTime", "Lead Time (Days)", grid.Locator, "Location__VLeadTime");
                    Location__VLeadTime.DataField = "Location__VLeadTime";
                    OverrideSettings = new CheckBox("ctl00_phG_tab_t3_PXGridVendorItems_ef", "Override", grid.Locator, "OverrideSettings");
                    OverrideSettings.DataField = "OverrideSettings";
                    AddLeadTimeDays = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edAddLeadTimeDays", "Add. Lead Time (Days)", grid.Locator, "AddLeadTimeDays");
                    AddLeadTimeDays.DataField = "AddLeadTimeDays";
                    MinOrdFreq = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edMinOrdFreq", "Min. Order Freq.(Days)", grid.Locator, "MinOrdFreq");
                    MinOrdFreq.DataField = "MinOrdFreq";
                    MinOrdQty = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edMinOrdQty", "Min. Order Qty.", grid.Locator, "MinOrdQty");
                    MinOrdQty.DataField = "MinOrdQty";
                    MaxOrdQty = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edMaxOrdQty", "Max Order Qty.", grid.Locator, "MaxOrdQty");
                    MaxOrdQty.DataField = "MaxOrdQty";
                    LotSize = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLotSize", "Lot Size", grid.Locator, "LotSize");
                    LotSize.DataField = "LotSize";
                    ERQ = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edERQ", "EOQ", grid.Locator, "ERQ");
                    ERQ.DataField = "ERQ";
                    CuryID = new Selector("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edCuryID", "Currency ID", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    LastPrice = new PXNumberEdit("_ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLastPrice", "Last Vendor Price", grid.Locator, "LastPrice");
                    LastPrice.DataField = "LastPrice";
                    PrepaymentPct = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_en", "Prepayment Percent", grid.Locator, "PrepaymentPct");
                    PrepaymentPct.DataField = "PrepaymentPct";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public SelectorColumnFilter VendorID { get; }
				public PXTextEditColumnFilter Vendor__AcctName { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public InputColumnFilter Location__VSiteID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter PurchaseUnit { get; }
				public PXNumberEditColumnFilter Location__VLeadTime { get; }
				public CheckBoxColumnFilter OverrideSettings { get; }
				public PXNumberEditColumnFilter AddLeadTimeDays { get; }
				public PXNumberEditColumnFilter MinOrdFreq { get; }
				public PXNumberEditColumnFilter MinOrdQty { get; }
				public PXNumberEditColumnFilter MaxOrdQty { get; }
				public PXNumberEditColumnFilter LotSize { get; }
				public PXNumberEditColumnFilter ERQ { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter LastPrice { get; }
				public PXNumberEditColumnFilter PrepaymentPct { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_vendoritems_pxgridvendoritems grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    Vendor__AcctName = new PXTextEditColumnFilter(grid.Row.Vendor__AcctName);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    Location__VSiteID = new InputColumnFilter(grid.Row.Location__VSiteID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    PurchaseUnit = new SelectorColumnFilter(grid.Row.PurchaseUnit);
                    Location__VLeadTime = new PXNumberEditColumnFilter(grid.Row.Location__VLeadTime);
                    OverrideSettings = new CheckBoxColumnFilter(grid.Row.OverrideSettings);
                    AddLeadTimeDays = new PXNumberEditColumnFilter(grid.Row.AddLeadTimeDays);
                    MinOrdFreq = new PXNumberEditColumnFilter(grid.Row.MinOrdFreq);
                    MinOrdQty = new PXNumberEditColumnFilter(grid.Row.MinOrdQty);
                    MaxOrdQty = new PXNumberEditColumnFilter(grid.Row.MaxOrdQty);
                    LotSize = new PXNumberEditColumnFilter(grid.Row.LotSize);
                    ERQ = new PXNumberEditColumnFilter(grid.Row.ERQ);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    LastPrice = new PXNumberEditColumnFilter(grid.Row.LastPrice);
                    PrepaymentPct = new PXNumberEditColumnFilter(grid.Row.PrepaymentPct);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_vendoritems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector Location__VSiteID { get; }
			public Label Location__VSiteIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public PXNumberEdit AddLeadTimeDays { get; }
			public Label AddLeadTimeDaysLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
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
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public PXNumberEdit LastPrice { get; }
			public Label LastPriceLabel { get; }
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public PXTextEdit Vendor__AcctName { get; }
			public Label Vendor__AcctNameLabel { get; }
			public PXNumberEdit Location__VLeadTime { get; }
			public Label Location__VLeadTimeLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_vendoritems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                VendorID = new Selector("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendorID", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                SubItemID = new Selector("ctl00_phG_tab_t3_PXGridVendorItems_lv0_vp_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                Location__VSiteID = new Selector("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLocation__VSiteID", "Warehouse", locator, null);
                Location__VSiteIDLabel = new Label(Location__VSiteID);
                Location__VSiteID.DataField = "Location__VSiteID";
                VendorLocationID = new Selector("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendorLocationID", "Location", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                AddLeadTimeDays = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edAddLeadTimeDays", "Add. Lead Time (Days)", locator, null);
                AddLeadTimeDaysLabel = new Label(AddLeadTimeDays);
                AddLeadTimeDays.DataField = "AddLeadTimeDays";
                Active = new CheckBox("ctl00_phG_tab_t3_PXGridVendorItems_lv0_vp_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                MinOrdFreq = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edMinOrdFreq", "Min. Order Freq.(Days)", locator, null);
                MinOrdFreqLabel = new Label(MinOrdFreq);
                MinOrdFreq.DataField = "MinOrdFreq";
                MinOrdQty = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edMinOrdQty", "Min. Order Qty.", locator, null);
                MinOrdQtyLabel = new Label(MinOrdQty);
                MinOrdQty.DataField = "MinOrdQty";
                MaxOrdQty = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edMaxOrdQty", "Max Order Qty.", locator, null);
                MaxOrdQtyLabel = new Label(MaxOrdQty);
                MaxOrdQty.DataField = "MaxOrdQty";
                LotSize = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLotSize", "Lot Size", locator, null);
                LotSizeLabel = new Label(LotSize);
                LotSize.DataField = "LotSize";
                ERQ = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edERQ", "EOQ", locator, null);
                ERQLabel = new Label(ERQ);
                ERQ.DataField = "ERQ";
                CuryID = new Selector("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edCuryID", "Currency ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                LastPrice = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLastPrice", "Last Vendor Price", locator, null);
                LastPriceLabel = new Label(LastPrice);
                LastPrice.DataField = "LastPrice";
                IsDefault = new CheckBox("ctl00_phG_tab_t3_PXGridVendorItems_lv0_chkIsDefault", "Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Vendor__AcctName = new PXTextEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendor__AcctName", "Vendor Name", locator, null);
                Vendor__AcctNameLabel = new Label(Vendor__AcctName);
                Vendor__AcctName.DataField = "Vendor__AcctName";
                Location__VLeadTime = new PXNumberEdit("ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLocation__VLeadTime", "Lead Time (Days)", locator, null);
                Location__VLeadTimeLabel = new Label(Location__VLeadTime);
                Location__VLeadTime.DataField = "Location__VLeadTime";
                Es = new Selector("ctl00_phG_tab_t3_PXGridVendorItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "VendorItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void VendorIDEdit()
            {
                Buttons.VendorIDEdit.Click();
            }
            
            public virtual void Location__VSiteIDEdit()
            {
                Buttons.Location__VSiteIDEdit.Click();
            }
            
            public virtual void VendorLocationIDEdit()
            {
                Buttons.VendorLocationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button VendorIDEdit { get; }
			public Button Location__VSiteIDEdit { get; }
			public Button VendorLocationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    VendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendorID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "VendorIDEdit", "ctl00_phG_tab_t3_PXGridVendorItems_lv0");
                    VendorIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    Location__VSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_PXGridVendorItems_lv0_edLocation__VSiteID\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "Location__VSiteIDEdit", "ctl00_phG_tab_t3_PXGridVendorItems_lv0");
                    Location__VSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VendorLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_PXGridVendorItems_lv0_edVendorLocationID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "VendorLocationIDEdit", "ctl00_phG_tab_t3_PXGridVendorItems_lv0");
                    VendorLocationIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_answers_pxgridanswers : Grid<c_answers_pxgridanswers.c_grid_row, c_answers_pxgridanswers.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_answers_pxgridanswers(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "Answers";
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridAnswers");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridAnswers");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridAnswers");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridAnswers");
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridAnswers");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridAnswers");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit AttributeID { get; }
			public CheckBox IsRequired { get; }
			public DropDown AttributeCategory { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit RefNoteID { get; }
                
                public c_grid_row(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new PXTextEdit("_ctl00_phG_tab_t6_PXGridAnswers_lv0_edParameterID", "Attribute", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    IsRequired = new CheckBox("ctl00_phG_tab_t6_PXGridAnswers", "Required", grid.Locator, "isRequired");
                    IsRequired.DataField = "isRequired";
                    AttributeCategory = new DropDown("_ctl00_phG_tab_t6_PXGridAnswers_lv0_ec", "Category", grid.Locator, "AttributeCategory");
                    AttributeCategory.DataField = "AttributeCategory";
                    AttributeCategory.Items.Add("A", "Attribute");
                    AttributeCategory.Items.Add("V", "Variant");
                    Value = new PXTextEdit("_ctl00_phG_tab_t6_PXGridAnswers_lv0_edAnswerValue", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t6_PXGridAnswers_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter AttributeID { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public DropDownColumnFilter AttributeCategory { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
                
                public c_grid_header(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new PXTextEditColumnFilter(grid.Row.AttributeID);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    AttributeCategory = new DropDownColumnFilter(grid.Row.AttributeCategory);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                }
            }
        }
        
        public class c_answers_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AttributeID { get; }
			public Label AttributeIDLabel { get; }
			public PXTextEdit Value { get; }
			public Label ValueLabel { get; }
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
                AttributeID = new PXTextEdit("ctl00_phG_tab_t6_PXGridAnswers_lv0_edParameterID", "Attribute", locator, null);
                AttributeIDLabel = new Label(AttributeID);
                AttributeID.DataField = "AttributeID";
                Value = new PXTextEdit("ctl00_phG_tab_t6_PXGridAnswers_lv0_edAnswerValue", "Value", locator, null);
                ValueLabel = new Label(Value);
                Value.DataField = "Value";
                Es = new Selector("ctl00_phG_tab_t6_PXGridAnswers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_PXGridAnswers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_PXGridAnswers_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t6_PXGridAnswers_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Answers";
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_category_pxgridcategory : Grid<c_category_pxgridcategory.c_grid_row, c_category_pxgridcategory.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_category_pxgridcategory(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_PXGridCategory");
                DataMemberName = "Category";
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
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridCategory_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridCategory_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridCategory_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridCategory_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    First = new Button("ctl00_phG_tab_t1_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridCategory");
                    Prev = new Button("ctl00_phG_tab_t1_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridCategory");
                    Next = new Button("ctl00_phG_tab_t1_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridCategory");
                    Last = new Button("ctl00_phG_tab_t1_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridCategory");
                    First1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridCategory");
                    Prev1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridCategory");
                    Next1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridCategory");
                    Last1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridCategory");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public TreeSelector CategoryID { get; }
			public Selector InventoryID { get; }
                
                public c_grid_row(c_category_pxgridcategory grid) : 
                        base(grid)
                {
                    CategoryID = new TreeSelector("_ctl00_phG_tab_t1_PXGridCategory_lv0_edParent", "Category ID", grid.Locator, "CategoryID");
                    CategoryID.DataField = "CategoryID";
                    InventoryID = new Selector("_ctl00_phG_tab_t1_PXGridCategory_lv0_es", "Template ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public TreeSelectorColumnFilter CategoryID { get; }
				public SelectorColumnFilter InventoryID { get; }
                
                public c_grid_header(c_category_pxgridcategory grid) : 
                        base(grid)
                {
                    CategoryID = new TreeSelectorColumnFilter(grid.Row.CategoryID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_category_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public TreeSelector CategoryID { get; }
			public Label CategoryIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_category_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CategoryID = new TreeSelector("ctl00_phG_tab_t1_PXGridCategory_lv0_edParent", "Category ID", locator, null);
                CategoryIDLabel = new Label(CategoryID);
                CategoryID.DataField = "CategoryID";
                Es = new Selector("ctl00_phG_tab_t1_PXGridCategory_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Category";
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
                    First = new Button("ctl00_phG_tab_t1_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                    Next = new Button("ctl00_phG_tab_t1_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                    Last = new Button("ctl00_phG_tab_t1_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                    First1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                    Next1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                    Last1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridCategory_lv0");
                }
            }
        }
        
        public class c_boxes_pxgridboxes : Grid<c_boxes_pxgridboxes.c_grid_row, c_boxes_pxgridboxes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_boxes_pxgridboxes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_PXGridBoxes");
                DataMemberName = "Boxes";
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
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridBoxes_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridBoxes_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridBoxes_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_PXGridBoxes_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    First = new Button("ctl00_phG_tab_t1_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridBoxes");
                    Prev = new Button("ctl00_phG_tab_t1_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridBoxes");
                    Next = new Button("ctl00_phG_tab_t1_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridBoxes");
                    Last = new Button("ctl00_phG_tab_t1_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridBoxes");
                    First1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridBoxes");
                    Prev1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridBoxes");
                    Next1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridBoxes");
                    Last1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridBoxes");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector BoxID { get; }
			public PXTextEdit Description { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit MaxWeight { get; }
			public PXNumberEdit MaxVolume { get; }
			public PXNumberEdit MaxQty { get; }
			public PXNumberEdit InventoryID { get; }
                
                public c_grid_row(c_boxes_pxgridboxes grid) : 
                        base(grid)
                {
                    BoxID = new Selector("_ctl00_phG_tab_t1_PXGridBoxes_lv0_edBoxID", "Box ID", grid.Locator, "BoxID");
                    BoxID.DataField = "BoxID";
                    Description = new PXTextEdit("ctl00_phG_tab_t1_PXGridBoxes_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    UOM = new Selector("_ctl00_phG_tab_t1_PXGridBoxes_lv0_edUOM_box", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t1_PXGridBoxes_lv0_edQty_box", "Qty.", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    MaxWeight = new PXNumberEdit("ctl00_phG_tab_t1_PXGridBoxes_en", "Max. Weight", grid.Locator, "MaxWeight");
                    MaxWeight.DataField = "MaxWeight";
                    MaxVolume = new PXNumberEdit("ctl00_phG_tab_t1_PXGridBoxes_en", "Max Volume", grid.Locator, "MaxVolume");
                    MaxVolume.DataField = "MaxVolume";
                    MaxQty = new PXNumberEdit("ctl00_phG_tab_t1_PXGridBoxes_en", "Max. Qty", grid.Locator, "MaxQty");
                    MaxQty.DataField = "MaxQty";
                    InventoryID = new PXNumberEdit("ctl00_phG_tab_t1_PXGridBoxes_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter BoxID { get; }
				public PXTextEditColumnFilter Description { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter MaxWeight { get; }
				public PXNumberEditColumnFilter MaxVolume { get; }
				public PXNumberEditColumnFilter MaxQty { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
                
                public c_grid_header(c_boxes_pxgridboxes grid) : 
                        base(grid)
                {
                    BoxID = new SelectorColumnFilter(grid.Row.BoxID);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    MaxWeight = new PXNumberEditColumnFilter(grid.Row.MaxWeight);
                    MaxVolume = new PXNumberEditColumnFilter(grid.Row.MaxVolume);
                    MaxQty = new PXNumberEditColumnFilter(grid.Row.MaxQty);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_boxes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BoxID { get; }
			public Label BoxIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_boxes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BoxID = new Selector("ctl00_phG_tab_t1_PXGridBoxes_lv0_edBoxID", "Box ID", locator, null);
                BoxIDLabel = new Label(BoxID);
                BoxID.DataField = "BoxID";
                UOM = new Selector("ctl00_phG_tab_t1_PXGridBoxes_lv0_edUOM_box", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t1_PXGridBoxes_lv0_edQty_box", "Qty.", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                Es = new Selector("ctl00_phG_tab_t1_PXGridBoxes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t1_PXGridBoxes_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t1_PXGridBoxes_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t1_PXGridBoxes_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Boxes";
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
                    First = new Button("ctl00_phG_tab_t1_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                    Next = new Button("ctl00_phG_tab_t1_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                    Last = new Button("ctl00_phG_tab_t1_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                    First1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfFirst0", "First", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfPrev0", "Prev", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                    Next1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfNext0", "Next", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                    Last1 = new Button("ctl00_phG_tab_t1_PXGridBoxes_lfLast0", "Last", "ctl00_phG_tab_t1_PXGridBoxes_lv0");
                }
            }
        }
        
        public class c_idgenerationrules_pxgrididgenerationrules : Grid<c_idgenerationrules_pxgrididgenerationrules.c_grid_row, c_idgenerationrules_pxgrididgenerationrules.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_idgenerationrules_pxgrididgenerationrules(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_PXGridIdGenerationRules");
                DataMemberName = "IdGenerationRules";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_PXGridIdGenerationRules_fe_gf", "FilterForm");
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
            
            public virtual void IdRowUp()
            {
                ToolBar.IdRowUp.Click();
            }
            
            public virtual void IdRowDown()
            {
                ToolBar.IdRowDown.Click();
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid IdRowUp { get; }
			public ToolBarButtonGrid IdRowDown { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    IdRowUp = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'IdRowUp\']", "IdRowUp", locator, null);
                    IdRowDown = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'IdRowDown\']", "IdRowDown", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'AdjustColumns\'" +
                            "]", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridIdGenerationRules_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridIdGenerationRules");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridIdGenerationRules");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridIdGenerationRules");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridIdGenerationRules");
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridIdGenerationRules");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridIdGenerationRules");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown SegmentType { get; }
			public Selector AttributeID { get; }
			public PXTextEdit Constant { get; }
			public Selector NumberingID { get; }
			public PXNumberEdit NumberOfCharacters { get; }
			public CheckBox UseSpaceAsSeparator { get; }
			public PXTextEdit Separator { get; }
			public PXNumberEdit TemplateID { get; }
			public DropDown Type { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit Sample { get; }
                
                public c_grid_row(c_idgenerationrules_pxgrididgenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDown("_ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0_ec", "Segment Type", grid.Locator, "SegmentType");
                    SegmentType.DataField = "SegmentType";
                    SegmentType.Items.Add("TI", "Template ID");
                    SegmentType.Items.Add("TD", "Template Description");
                    SegmentType.Items.Add("AC", "Attribute Caption");
                    SegmentType.Items.Add("AV", "Attribute Value");
                    SegmentType.Items.Add("CO", "Constant");
                    SegmentType.Items.Add("SP", "Space");
                    SegmentType.Items.Add("AN", "Auto Number");
                    AttributeID = new Selector("_ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0_es", "Attribute ID", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    Constant = new PXTextEdit("ctl00_phG_tab_t6_PXGridIdGenerationRules_ei", "Constant", grid.Locator, "Constant");
                    Constant.DataField = "Constant";
                    NumberingID = new Selector("_ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0_es", "Numbering ID", grid.Locator, "NumberingID");
                    NumberingID.DataField = "NumberingID";
                    NumberOfCharacters = new PXNumberEdit("ctl00_phG_tab_t6_PXGridIdGenerationRules_en", "Number of Characters", grid.Locator, "NumberOfCharacters");
                    NumberOfCharacters.DataField = "NumberOfCharacters";
                    UseSpaceAsSeparator = new CheckBox("ctl00_phG_tab_t6_PXGridIdGenerationRules_ef", "Use Space as Separator", grid.Locator, "UseSpaceAsSeparator");
                    UseSpaceAsSeparator.DataField = "UseSpaceAsSeparator";
                    Separator = new PXTextEdit("ctl00_phG_tab_t6_PXGridIdGenerationRules_ei", "Separator", grid.Locator, "Separator");
                    Separator.DataField = "Separator";
                    TemplateID = new PXNumberEdit("ctl00_phG_tab_t6_PXGridIdGenerationRules_en", "TemplateID", grid.Locator, "TemplateID");
                    TemplateID.DataField = "TemplateID";
                    Type = new DropDown("_ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0_ec", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("I", "ID");
                    Type.Items.Add("D", "Description");
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t6_PXGridIdGenerationRules_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    Sample = new PXTextEdit("ctl00_phG_tab_t6_PXGridIdGenerationRules_ei", "Sample", grid.Locator, "Sample");
                    Sample.DataField = "Sample";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter SegmentType { get; }
				public SelectorColumnFilter AttributeID { get; }
				public PXTextEditColumnFilter Constant { get; }
				public SelectorColumnFilter NumberingID { get; }
				public PXNumberEditColumnFilter NumberOfCharacters { get; }
				public CheckBoxColumnFilter UseSpaceAsSeparator { get; }
				public PXTextEditColumnFilter Separator { get; }
				public PXNumberEditColumnFilter TemplateID { get; }
				public DropDownColumnFilter Type { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter Sample { get; }
                
                public c_grid_header(c_idgenerationrules_pxgrididgenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDownColumnFilter(grid.Row.SegmentType);
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    Constant = new PXTextEditColumnFilter(grid.Row.Constant);
                    NumberingID = new SelectorColumnFilter(grid.Row.NumberingID);
                    NumberOfCharacters = new PXNumberEditColumnFilter(grid.Row.NumberOfCharacters);
                    UseSpaceAsSeparator = new CheckBoxColumnFilter(grid.Row.UseSpaceAsSeparator);
                    Separator = new PXTextEditColumnFilter(grid.Row.Separator);
                    TemplateID = new PXNumberEditColumnFilter(grid.Row.TemplateID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    Sample = new PXTextEditColumnFilter(grid.Row.Sample);
                }
            }
        }
        
        public class c_idgenerationrules_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_idgenerationrules_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0_ec", "Ec", locator, null);
                DataMemberName = "IdGenerationRules";
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0");
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridIdGenerationRules_lv0");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_descriptiongenerationrules_pxgriddescriptiongenerationrules : Grid<c_descriptiongenerationrules_pxgriddescriptiongenerationrules.c_grid_row, c_descriptiongenerationrules_pxgriddescriptiongenerationrules.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_descriptiongenerationrules_pxgriddescriptiongenerationrules(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules");
                DataMemberName = "DescriptionGenerationRules";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_fe_gf", "FilterForm");
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
            
            public virtual void DescriptionRowUp()
            {
                ToolBar.DescriptionRowUp.Click();
            }
            
            public virtual void DescriptionRowDown()
            {
                ToolBar.DescriptionRowDown.Click();
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid DescriptionRowUp { get; }
			public ToolBarButtonGrid DescriptionRowDown { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'Refre" +
                            "sh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'AddNe" +
                            "w\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'Delet" +
                            "e\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    DescriptionRowUp = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'Descr" +
                            "iptionRowUp\']", "DescriptionRowUp", locator, null);
                    DescriptionRowDown = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'Descr" +
                            "iptionRowDown\']", "DescriptionRowDown", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'Adjus" +
                            "tColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'Expor" +
                            "tExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ab_tlb div[data-cmd=\'PageF" +
                            "irst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ab_tlb div[data-cmd=\'PageP" +
                            "rev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ab_tlb div[data-cmd=\'PageN" +
                            "ext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ab_tlb div[data-cmd=\'PageL" +
                            "ast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules");
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown SegmentType { get; }
			public Selector AttributeID { get; }
			public PXTextEdit Constant { get; }
			public Selector NumberingID { get; }
			public PXNumberEdit NumberOfCharacters { get; }
			public CheckBox UseSpaceAsSeparator { get; }
			public PXTextEdit Separator { get; }
			public PXNumberEdit TemplateID { get; }
			public DropDown Type { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit Sample { get; }
                
                public c_grid_row(c_descriptiongenerationrules_pxgriddescriptiongenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDown("_ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0_ec", "Segment Type", grid.Locator, "SegmentType");
                    SegmentType.DataField = "SegmentType";
                    SegmentType.Items.Add("TI", "Template ID");
                    SegmentType.Items.Add("TD", "Template Description");
                    SegmentType.Items.Add("AC", "Attribute Caption");
                    SegmentType.Items.Add("AV", "Attribute Value");
                    SegmentType.Items.Add("CO", "Constant");
                    SegmentType.Items.Add("SP", "Space");
                    SegmentType.Items.Add("AN", "Auto Number");
                    AttributeID = new Selector("_ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0_es", "Attribute ID", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    Constant = new PXTextEdit("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ei", "Constant", grid.Locator, "Constant");
                    Constant.DataField = "Constant";
                    NumberingID = new Selector("_ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0_es", "Numbering ID", grid.Locator, "NumberingID");
                    NumberingID.DataField = "NumberingID";
                    NumberOfCharacters = new PXNumberEdit("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_en", "Number of Characters", grid.Locator, "NumberOfCharacters");
                    NumberOfCharacters.DataField = "NumberOfCharacters";
                    UseSpaceAsSeparator = new CheckBox("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ef", "Use Space as Separator", grid.Locator, "UseSpaceAsSeparator");
                    UseSpaceAsSeparator.DataField = "UseSpaceAsSeparator";
                    Separator = new PXTextEdit("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ei", "Separator", grid.Locator, "Separator");
                    Separator.DataField = "Separator";
                    TemplateID = new PXNumberEdit("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_en", "TemplateID", grid.Locator, "TemplateID");
                    TemplateID.DataField = "TemplateID";
                    Type = new DropDown("_ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0_ec", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("I", "ID");
                    Type.Items.Add("D", "Description");
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    Sample = new PXTextEdit("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_ei", "Sample", grid.Locator, "Sample");
                    Sample.DataField = "Sample";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter SegmentType { get; }
				public SelectorColumnFilter AttributeID { get; }
				public PXTextEditColumnFilter Constant { get; }
				public SelectorColumnFilter NumberingID { get; }
				public PXNumberEditColumnFilter NumberOfCharacters { get; }
				public CheckBoxColumnFilter UseSpaceAsSeparator { get; }
				public PXTextEditColumnFilter Separator { get; }
				public PXNumberEditColumnFilter TemplateID { get; }
				public DropDownColumnFilter Type { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter Sample { get; }
                
                public c_grid_header(c_descriptiongenerationrules_pxgriddescriptiongenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDownColumnFilter(grid.Row.SegmentType);
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    Constant = new PXTextEditColumnFilter(grid.Row.Constant);
                    NumberingID = new SelectorColumnFilter(grid.Row.NumberingID);
                    NumberOfCharacters = new PXNumberEditColumnFilter(grid.Row.NumberOfCharacters);
                    UseSpaceAsSeparator = new CheckBoxColumnFilter(grid.Row.UseSpaceAsSeparator);
                    Separator = new PXTextEditColumnFilter(grid.Row.Separator);
                    TemplateID = new PXNumberEditColumnFilter(grid.Row.TemplateID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    Sample = new PXTextEditColumnFilter(grid.Row.Sample);
                }
            }
        }
        
        public class c_descriptiongenerationrules_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_descriptiongenerationrules_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0_ec", "Ec", locator, null);
                DataMemberName = "DescriptionGenerationRules";
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0");
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultColumnMatrixAttributeID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_edDefaultRowMatrixAttributeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_tab_t6_PXGridDescriptionGenerationRules_lv0");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_inventoryfileurls_gridinventoryfileurls : Grid<c_inventoryfileurls_gridinventoryfileurls.c_grid_row, c_inventoryfileurls_gridinventoryfileurls.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_inventoryfileurls_gridinventoryfileurls(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_gridInventoryFileUrls");
                DataMemberName = "InventoryFileUrls";
                Buttons = new PxButtonCollection();
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
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
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_gridInventoryFileUrls_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_gridInventoryFileUrls_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_gridInventoryFileUrls_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_gridInventoryFileUrls_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfFirst0", "First", "ctl00_phG_tab_t9_gridInventoryFileUrls");
                    Prev = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfPrev0", "Prev", "ctl00_phG_tab_t9_gridInventoryFileUrls");
                    Next = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfNext0", "Next", "ctl00_phG_tab_t9_gridInventoryFileUrls");
                    Last = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfLast0", "Last", "ctl00_phG_tab_t9_gridInventoryFileUrls");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit FileURL { get; }
			public DropDown FileType { get; }
			public PXNumberEdit FileID { get; }
                
                public c_grid_row(c_inventoryfileurls_gridinventoryfileurls grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    FileURL = new PXTextEdit("ctl00_phG_tab_t9_gridInventoryFileUrls_ei", "URL", grid.Locator, "FileURL");
                    FileURL.DataField = "FileURL";
                    FileType = new DropDown("_ctl00_phG_tab_t9_gridInventoryFileUrls_lv0_ec", "Type", grid.Locator, "FileType");
                    FileType.DataField = "FileType";
                    FileType.Items.Add("I", "Image");
                    FileType.Items.Add("V", "Video");
                    FileID = new PXNumberEdit("ctl00_phG_tab_t9_gridInventoryFileUrls_en", "FileID", grid.Locator, "FileID");
                    FileID.DataField = "FileID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter FileURL { get; }
				public DropDownColumnFilter FileType { get; }
				public PXNumberEditColumnFilter FileID { get; }
                
                public c_grid_header(c_inventoryfileurls_gridinventoryfileurls grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    FileURL = new PXTextEditColumnFilter(grid.Row.FileURL);
                    FileType = new DropDownColumnFilter(grid.Row.FileType);
                    FileID = new PXNumberEditColumnFilter(grid.Row.FileID);
                }
            }
        }
        
        public class c_inventoryfileurls_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_inventoryfileurls_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t9_gridInventoryFileUrls_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t9_gridInventoryFileUrls_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t9_gridInventoryFileUrls_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t9_gridInventoryFileUrls_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "InventoryFileUrls";
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
                    First = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfFirst0", "First", "ctl00_phG_tab_t9_gridInventoryFileUrls_lv0");
                    Prev = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfPrev0", "Prev", "ctl00_phG_tab_t9_gridInventoryFileUrls_lv0");
                    Next = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfNext0", "Next", "ctl00_phG_tab_t9_gridInventoryFileUrls_lv0");
                    Last = new Button("ctl00_phG_tab_t9_gridInventoryFileUrls_lfLast0", "Last", "ctl00_phG_tab_t9_gridInventoryFileUrls_lv0");
                }
            }
        }
        
        public class c_vendorinventory_updateprice_formeffectivedate : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector PendingDate { get; }
			public Label PendingDateLabel { get; }
            
            public c_vendorinventory_updateprice_formeffectivedate(string locator, string name) : 
                    base(locator, name)
            {
                PendingDate = new DateSelector("ctl00_phG_pnlUpdatePrice_formEffectiveDate_edPendingDate", "Max. Pending Date", locator, null);
                PendingDateLabel = new Label(PendingDate);
                PendingDate.DataField = "PendingDate";
                DataMemberName = "VendorInventory$UpdatePrice";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Update()
            {
                Buttons.Update.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Update { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Update = new Button("ctl00_phG_pnlUpdatePrice_PXButton3", "Update", "ctl00_phG_pnlUpdatePrice_formEffectiveDate");
                    Cancel = new Button("ctl00_phG_pnlUpdatePrice_PXButton4", "Cancel", "ctl00_phG_pnlUpdatePrice_formEffectiveDate");
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
                CD = new Selector("ctl00_phF_pnlChangeID_formChangeID_edAcctCD", "Template ID", locator, null);
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
        
        public class c_matrixitems_grdmatrixitems : Grid<c_matrixitems_grdmatrixitems.c_grid_row, c_matrixitems_grdmatrixitems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_matrixitems_grdmatrixitems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_grdMatrixItems");
                DataMemberName = "MatrixItems";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t8_grdMatrixItems_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
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
            
            public virtual void Delete1()
            {
                ToolBar.Delete1.Click();
            }
            
            public virtual void Delete1(bool status, string message = null)
            {
                ToolBar.Delete1.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
                ToolBar.Delete1.Click();
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
			public ToolBarButtonGrid Delete1 { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Delete1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_at_tlb div[data-cmd=\'cmdDelete\']", "Delete", locator, null);
                    Delete1.WaitAction = Wait.WaitForLongOperationToComplete;
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_grdMatrixItems_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public Selector InventoryID { get; }
			public InputLocalizable Descr { get; }
			public Selector DfltSiteID { get; }
			public PXTextEdit AttributeValue0 { get; }
            public PXTextEdit AttributeValue1 { get; }
            public PXTextEdit AttributeValue2 { get; }
			public Selector ItemClassID { get; }
			public Selector TaxCategoryID { get; }
			public PXNumberEdit RecPrice { get; }
			public PXNumberEdit LastStdCost { get; }
			public PXNumberEdit BasePrice { get; }
			public CheckBox StkItem { get; }
			public Selector InventoryCD { get; }
                
                public c_grid_row(c_matrixitems_grdmatrixitems grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_tab_t8_grdMatrixItems_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    InventoryID = new Selector("_ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    Descr = new InputLocalizable("ctl00_phG_tab_t8_grdMatrixItems_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    DfltSiteID = new Selector("_ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsDfltSiteID", "Default Warehouse", grid.Locator, "DfltSiteID");
                    DfltSiteID.DataField = "DfltSiteID";
                    AttributeValue0 = new PXTextEdit("ctl00_phG_tab_t8_grdMatrixItems_ei", "Attribute Value 0", grid.Locator, "AttributeValue0");
                    AttributeValue0.DataField = "AttributeValue0";
                    AttributeValue1 = new PXTextEdit("ctl00_phG_tab_t8_grdMatrixItems_ei", "Attribute Value 1", grid.Locator, "AttributeValue1");
                    AttributeValue1.DataField = "AttributeValue1";
                    AttributeValue2 = new PXTextEdit("ctl00_phG_tab_t8_grdMatrixItems_ei", "Attribute Value 2", grid.Locator, "AttributeValue2");
                    AttributeValue2.DataField = "AttributeValue2";
                    ItemClassID = new Selector("_ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsItemClassID", "Item Class", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsTaxCategoryID", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    RecPrice = new PXNumberEdit("ctl00_phG_tab_t8_grdMatrixItems_en", "MSRP", grid.Locator, "RecPrice");
                    RecPrice.DataField = "RecPrice";
                    LastStdCost = new PXNumberEdit("ctl00_phG_tab_t8_grdMatrixItems_en", "Last Cost", grid.Locator, "LastStdCost");
                    LastStdCost.DataField = "LastStdCost";
                    BasePrice = new PXNumberEdit("ctl00_phG_tab_t8_grdMatrixItems_en", "Default Price", grid.Locator, "BasePrice");
                    BasePrice.DataField = "BasePrice";
                    StkItem = new CheckBox("ctl00_phG_tab_t8_grdMatrixItems", "Stock Item", grid.Locator, "StkItem");
                    StkItem.DataField = "StkItem";
                    InventoryCD = new Selector("_ctl00_phG_tab_t8_grdMatrixItems_lv0_es", "Inventory ID", grid.Locator, "InventoryCD");
                    InventoryCD.DataField = "InventoryCD";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter DfltSiteID { get; }
				public PXTextEditColumnFilter AttributeValue0 { get; }
				public SelectorColumnFilter ItemClassID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public PXNumberEditColumnFilter RecPrice { get; }
				public PXNumberEditColumnFilter LastStdCost { get; }
				public PXNumberEditColumnFilter BasePrice { get; }
				public CheckBoxColumnFilter StkItem { get; }
				public SelectorColumnFilter InventoryCD { get; }
                
                public c_grid_header(c_matrixitems_grdmatrixitems grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    DfltSiteID = new SelectorColumnFilter(grid.Row.DfltSiteID);
                    AttributeValue0 = new PXTextEditColumnFilter(grid.Row.AttributeValue0);
                    ItemClassID = new SelectorColumnFilter(grid.Row.ItemClassID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    RecPrice = new PXNumberEditColumnFilter(grid.Row.RecPrice);
                    LastStdCost = new PXNumberEditColumnFilter(grid.Row.LastStdCost);
                    BasePrice = new PXNumberEditColumnFilter(grid.Row.BasePrice);
                    StkItem = new CheckBoxColumnFilter(grid.Row.StkItem);
                    InventoryCD = new SelectorColumnFilter(grid.Row.InventoryCD);
                }
            }
        }
        
        public class c_matrixitems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector DfltSiteID { get; }
			public Label DfltSiteIDLabel { get; }
			public Selector ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_matrixitems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                DfltSiteID = new Selector("ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsDfltSiteID", "Default Warehouse", locator, null);
                DfltSiteIDLabel = new Label(DfltSiteID);
                DfltSiteID.DataField = "DfltSiteID";
                ItemClassID = new Selector("ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsItemClassID", "Item Class", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                TaxCategoryID = new Selector("ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                Es = new Selector("ctl00_phG_tab_t8_grdMatrixItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "MatrixItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DfltSiteIDEdit()
            {
                Buttons.DfltSiteIDEdit.Click();
            }
            
            public virtual void ItemClassIDEdit()
            {
                Buttons.ItemClassIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DfltSiteIDEdit { get; }
			public Button ItemClassIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DfltSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsDfltSiteID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "DfltSiteIDEdit", "ctl00_phG_tab_t8_grdMatrixItems_lv0");
                    DfltSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsItemClassID\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "ItemClassIDEdit", "ctl00_phG_tab_t8_grdMatrixItems_lv0");
                    ItemClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_grdMatrixItems_lv0_matrixItemsTaxCategoryID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_tab_t8_grdMatrixItems_lv0");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_header_pxformview1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ColAttributeID { get; }
			public Label ColAttributeIDLabel { get; }
			public Selector RowAttributeID { get; }
			public Label RowAttributeIDLabel { get; }
            
            public c_header_pxformview1(string locator, string name) : 
                    base(locator, name)
            {
                ColAttributeID = new Selector("ctl00_phG_tab_t7_PXFormView1_edColAttributeID", "Column Attribute ID", locator, null);
                ColAttributeIDLabel = new Label(ColAttributeID);
                ColAttributeID.DataField = "ColAttributeID";
                RowAttributeID = new Selector("ctl00_phG_tab_t7_PXFormView1_edRowAttributeID", "Row Attribute ID", locator, null);
                RowAttributeIDLabel = new Label(RowAttributeID);
                RowAttributeID.DataField = "RowAttributeID";
                DataMemberName = "Header";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Confirmation()
            {
                Buttons.Confirmation.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirmation { get; }
                
                public PxButtonCollection()
                {
                    Confirmation = new Button("ctl00_phG_tab_t7_popupCreate_btnCreateUpdate", "Confirmation", "ctl00_phG_tab_t7_PXFormView1");
                }
            }
        }
        
        public class c_additionalattributes_matrixattributes : Grid<c_additionalattributes_matrixattributes.c_grid_row, c_additionalattributes_matrixattributes.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_additionalattributes_matrixattributes(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "AdditionalAttributes";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_MatrixAttributes_fe_gf", "FilterForm");
            }
            
            public virtual void Confirmation()
            {
                Buttons.Confirmation.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirmation { get; }
                
                public PxButtonCollection()
                {
                    Confirmation = new Button("ctl00_phG_tab_t7_popupCreate_btnCreateUpdate", "Confirmation", "ctl00_phG_tab_t7_MatrixAttributes");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector Extra { get; }
                
                public c_grid_row(c_additionalattributes_matrixattributes grid) : 
                        base(grid)
                {
                    Extra = new Selector("_ctl00_phG_tab_t7_MatrixAttributes_lv0_es", "Template Item", grid.Locator, "Extra");
                    Extra.DataField = "Extra";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter Extra { get; }
                
                public c_grid_header(c_additionalattributes_matrixattributes grid) : 
                        base(grid)
                {
                    Extra = new SelectorColumnFilter(grid.Row.Extra);
                }
            }
        }
        
        public class c_additionalattributes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_additionalattributes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t7_MatrixAttributes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "AdditionalAttributes";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Confirmation()
            {
                Buttons.Confirmation.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirmation { get; }
                
                public PxButtonCollection()
                {
                    Confirmation = new Button("ctl00_phG_tab_t7_popupCreate_btnCreateUpdate", "Confirmation", "ctl00_phG_tab_t7_MatrixAttributes_lv0");
                }
            }
        }
        
        public class c_matrix_matrixmatrix : Grid<c_matrix_matrixmatrix.c_grid_row, c_matrix_matrixmatrix.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_matrix_matrixmatrix(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_MatrixMatrix");
                DataMemberName = "Matrix";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_MatrixMatrix_fe_gf", "FilterForm");
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
            
            public virtual void Confirmation()
            {
                Buttons.Confirmation.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_MatrixMatrix_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirmation { get; }
                
                public PxButtonCollection()
                {
                    Confirmation = new Button("ctl00_phG_tab_t7_popupCreate_btnCreateUpdate", "Confirmation", "ctl00_phG_tab_t7_MatrixMatrix");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit RowAttributeValueDescr { get; }
			public CheckBox Preliminary { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_matrix_matrixmatrix grid) : 
                        base(grid)
                {
                    RowAttributeValueDescr = new PXTextEdit("ctl00_phG_tab_t7_MatrixMatrix_ei", "Attribute Value", grid.Locator, "RowAttributeValueDescr");
                    RowAttributeValueDescr.DataField = "RowAttributeValueDescr";
                    Preliminary = new CheckBox("ctl00_phG_tab_t7_MatrixMatrix_ef", "Select Row", grid.Locator, "Preliminary");
                    Preliminary.DataField = "Preliminary";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t7_MatrixMatrix_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter RowAttributeValueDescr { get; }
				public CheckBoxColumnFilter Preliminary { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_matrix_matrixmatrix grid) : 
                        base(grid)
                {
                    RowAttributeValueDescr = new PXTextEditColumnFilter(grid.Row.RowAttributeValueDescr);
                    Preliminary = new CheckBoxColumnFilter(grid.Row.Preliminary);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_matrixitemsforcreation_grdcreate : Grid<c_matrixitemsforcreation_grdcreate.c_grid_row, c_matrixitemsforcreation_grdcreate.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            private Label _StatusBar = new Label("ctl00_phG_tab_t7_popupCreate_grdCreate_ab_tlb_ul", "Status Bar", "ctl00_phG_tab_t7_popupCreate_grdCreate", null);
            
			public c_grid_filter FilterForm { get; }
            
            public c_matrixitemsforcreation_grdcreate(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_popupCreate_grdCreate");
                DataMemberName = "MatrixItemsForCreation";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_popupCreate_grdCreate_fe_gf", "FilterForm");
            }
            
            public virtual Label StatusBar
            {
                get
                {
                    return _StatusBar;
                }
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
            
            public virtual void Confirmation()
            {
                Buttons.Confirmation.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_popupCreate_grdCreate_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirmation { get; }
                
                public PxButtonCollection()
                {
                    Confirmation = new Button("ctl00_phG_tab_t7_popupCreate_btnCreateUpdate", "Confirmation", "ctl00_phG_tab_t7_popupCreate_grdCreate");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public Selector InventoryCD { get; }
			public InputLocalizable Descr { get; }
			public CheckBox StkItem { get; }
			public Selector ItemClassID { get; }
			public DropDown ItemType { get; }
			public DropDown ValMethod { get; }
			public Selector LotSerClassID { get; }
			public Selector DfltSiteID { get; }
			public Selector TaxCategoryID { get; }
			public DropDown ItemStatus { get; }
			public DropDown TaxCalcMode { get; }
			public CheckBox WeightItem { get; }
			public Selector BaseUnit { get; }
			public Selector SalesUnit { get; }
			public Selector PurchaseUnit { get; }
			public CheckBox DecimalBaseUnit { get; }
			public CheckBox DecimalSalesUnit { get; }
			public CheckBox DecimalPurchaseUnit { get; }
			public CheckBox Commisionable { get; }
			public Selector ReasonCodeSubID { get; }
			public Selector SalesAcctID { get; }
			public Selector SalesSubID { get; }
			public Selector InvtAcctID { get; }
			public Selector InvtSubID { get; }
			public Selector COGSAcctID { get; }
			public Selector COGSSubID { get; }
			public Selector StdCstRevAcctID { get; }
			public Selector StdCstRevSubID { get; }
			public Selector StdCstVarAcctID { get; }
			public Selector StdCstVarSubID { get; }
			public Selector PPVAcctID { get; }
			public Selector PPVSubID { get; }
			public Selector POAccrualAcctID { get; }
			public Selector POAccrualSubID { get; }
			public Selector LCVarianceAcctID { get; }
			public Selector LCVarianceSubID { get; }
			public Selector DeferralAcctID { get; }
			public Selector DeferralSubID { get; }
			public PXNumberEdit LastStdCost { get; }
			public PXNumberEdit PendingStdCost { get; }
			public DateSelector PendingStdCostDate { get; }
			public PXNumberEdit StdCost { get; }
			public DateSelector StdCostDate { get; }
			public PXNumberEdit BaseVolume { get; }
			public PXNumberEdit BaseItemWeight { get; }
			public PXNumberEdit BaseItemVolume { get; }
			public Selector WeightUOM { get; }
			public Selector VolumeUOM { get; }
			public CheckBox PackSeparately { get; }
			public DropDown PackageOption { get; }
			public Selector PreferredVendorID { get; }
			public Selector PreferredVendorLocationID { get; }
			public CheckBox DefaultSubItemOnEntry { get; }
			public Selector DfltShipLocationID { get; }
			public Selector DfltReceiptLocationID { get; }
			public Selector ProductWorkgroupID { get; }
			public Selector ProductManagerID { get; }
			public Selector PriceWorkgroupID { get; }
			public Selector PriceManagerID { get; }
			public PXTextEdit LotSerNumberResult { get; }
			public PXTextEdit PostClassID { get; }
			public Selector DeferredCode { get; }
			public PXNumberEdit DefaultTerm { get; }
			public DropDown DefaultTermUOM { get; }
			public Selector PriceClassID { get; }
			public CheckBox IsSplitted { get; }
			public CheckBox UseParentSubID { get; }
			public PXNumberEdit TotalPercentage { get; }
			public CheckBox KitItem { get; }
			public PXNumberEdit MinGrossProfitPct { get; }
			public CheckBox NonStockReceipt { get; }
			public CheckBox NonStockShip { get; }
			public CheckBox AccrueCost { get; }
			public DropDown CostBasis { get; }
			public PXNumberEdit PercentOfSalesPrice { get; }
			public DropDown CompletePOLine { get; }
			public Selector ABCCodeID { get; }
			public CheckBox ABCCodeIsFixed { get; }
			public Selector MovementClassID { get; }
			public CheckBox MovementClassIsFixed { get; }
			public PXNumberEdit MarkupPct { get; }
			public PXNumberEdit RecPrice { get; }
			public PXTextEdit ImageUrl { get; }
			public PXTextEdit HSTariffCode { get; }
			public PXNumberEdit UndershipThreshold { get; }
			public PXNumberEdit OvershipThreshold { get; }
			public Selector CountryOfOrigin { get; }
			public Selector CreatedByID { get; }
			public DateSelector CreatedDateTime { get; }
			public Selector LastModifiedByID { get; }
			public DateSelector LastModifiedDateTime { get; }
			public Selector CycleID { get; }
			public CheckBox Included { get; }
			public InputLocalizable Body { get; }
			public Selector TemplateItemID { get; }
			public Selector DefaultRowMatrixAttributeID { get; }
			public Selector DefaultColumnMatrixAttributeID { get; }
			public DropDown Visibility { get; }
			public DropDown Availability { get; }
			public DropDown NotAvailMode { get; }
			public CheckBox New { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit BasePrice { get; }
			public PXTextEdit CustomURL { get; }
			public InputLocalizable PageTitle { get; }
			public InputLocalizable MetaDescription { get; }
			public InputLocalizable MetaKeywords { get; }
			public InputLocalizable SearchKeywords { get; }
			public InputLocalizable ShortDescription { get; }
			public PXTextEdit UsrCustom_1 { get; }
			public PXTextEdit UsrCustom_2 { get; }
			public PXTextEdit ReasonCodeSubID_Sub_description { get; }
			public PXTextEdit ReasonCodeSubID_description { get; }
			public PXTextEdit SalesAcctID_Account_description { get; }
			public PXTextEdit SalesAcctID_description { get; }
			public PXTextEdit SalesSubID_Sub_description { get; }
			public PXTextEdit SalesSubID_description { get; }
			public PXTextEdit InvtAcctID_Account_description { get; }
			public PXTextEdit InvtAcctID_description { get; }
			public PXTextEdit InvtSubID_Sub_description { get; }
			public PXTextEdit InvtSubID_description { get; }
			public PXTextEdit COGSAcctID_Account_description { get; }
			public PXTextEdit COGSAcctID_description { get; }
			public PXTextEdit COGSSubID_Sub_description { get; }
			public PXTextEdit COGSSubID_description { get; }
			public PXTextEdit StdCstRevAcctID_Account_description { get; }
			public PXTextEdit StdCstRevAcctID_description { get; }
			public PXTextEdit StdCstRevSubID_Sub_description { get; }
			public PXTextEdit StdCstRevSubID_description { get; }
			public PXTextEdit StdCstVarAcctID_Account_description { get; }
			public PXTextEdit StdCstVarAcctID_description { get; }
			public PXTextEdit StdCstVarSubID_Sub_description { get; }
			public PXTextEdit StdCstVarSubID_description { get; }
			public PXTextEdit PPVAcctID_Account_description { get; }
			public PXTextEdit PPVAcctID_description { get; }
			public PXTextEdit PPVSubID_Sub_description { get; }
			public PXTextEdit PPVSubID_description { get; }
			public PXTextEdit POAccrualAcctID_Account_description { get; }
			public PXTextEdit POAccrualAcctID_description { get; }
			public PXTextEdit POAccrualSubID_Sub_description { get; }
			public PXTextEdit POAccrualSubID_description { get; }
			public PXTextEdit LCVarianceAcctID_Account_description { get; }
			public PXTextEdit LCVarianceAcctID_description { get; }
			public PXTextEdit LCVarianceSubID_Sub_description { get; }
			public PXTextEdit LCVarianceSubID_description { get; }
			public PXTextEdit DeferralAcctID_Account_description { get; }
			public PXTextEdit DeferralAcctID_description { get; }
			public PXTextEdit DeferralSubID_Sub_description { get; }
			public PXTextEdit DeferralSubID_description { get; }
			public PXTextEdit PreferredVendorID_Vendor_acctName { get; }
			public PXTextEdit PreferredVendorID_description { get; }
			public PXTextEdit PreferredVendorID_BAccountR_acctName { get; }
			public PXTextEdit PreferredVendorLocationID_Location_descr { get; }
			public PXTextEdit PreferredVendorLocationID_description { get; }
			public PXTextEdit DfltSiteID_INSite_descr { get; }
			public PXTextEdit DfltSiteID_description { get; }
			public PXTextEdit DfltShipLocationID_INLocation_descr { get; }
			public PXTextEdit DfltShipLocationID_description { get; }
			public PXTextEdit DfltReceiptLocationID_INLocation_descr { get; }
			public PXTextEdit DfltReceiptLocationID_description { get; }
			public PXTextEdit ProductManagerID_Owner_displayName { get; }
			public PXTextEdit ProductManagerID_description { get; }
			public PXTextEdit PriceManagerID_Owner_displayName { get; }
			public PXTextEdit PriceManagerID_description { get; }
			public PXTextEdit LotSerClassID_INLotSerClass_descr { get; }
			public PXTextEdit LotSerClassID_description { get; }
			public PXTextEdit PriceClassID_INPriceClass_description { get; }
			public PXTextEdit PriceClassID_description { get; }
			public PXTextEdit ABCCodeID_INABCCode_descr { get; }
			public PXTextEdit ABCCodeID_description { get; }
			public PXTextEdit MovementClassID_INMovementClass_descr { get; }
			public PXTextEdit MovementClassID_description { get; }
			public PXTextEdit CountryOfOrigin_Country_description { get; }
			public PXTextEdit CountryOfOrigin_description { get; }
			public PXTextEdit CreatedByID_Creator_displayName { get; }
			public PXTextEdit CreatedByID_description { get; }
			public PXTextEdit CreatedByID_Creator_Username { get; }
			public PXTextEdit LastModifiedByID_Modifier_displayName { get; }
			public PXTextEdit LastModifiedByID_description { get; }
			public PXTextEdit LastModifiedByID_Modifier_Username { get; }
			public PXTextEdit CycleID_INPICycle_descr { get; }
			public PXTextEdit CycleID_description { get; }
			public PXTextEdit TemplateItemID_InventoryItem_descr { get; }
			public PXTextEdit TemplateItemID_description { get; }
			public PXTextEdit DefaultRowMatrixAttributeID_CSAttribute_description { get; }
			public PXTextEdit DefaultRowMatrixAttributeID_description { get; }
			public PXTextEdit DefaultColumnMatrixAttributeID_CSAttribute_description { get; }
			public PXTextEdit DefaultColumnMatrixAttributeID_description { get; }
			public PXTextEdit ItemClassID_INItemClass_descr { get; }
			public PXTextEdit ItemClassID_description { get; }
			public PXTextEdit TaxCategoryID_TaxCategory_descr { get; }
			public PXTextEdit TaxCategoryID_description { get; }
			public PXNumberEdit InventoryID { get; }
                
                public c_grid_row(c_matrixitemsforcreation_grdcreate grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    InventoryCD = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Inventory ID", grid.Locator, "InventoryCD");
                    InventoryCD.DataField = "InventoryCD";
                    Descr = new InputLocalizable("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    StkItem = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Stock Item", grid.Locator, "StkItem");
                    StkItem.DataField = "StkItem";
                    ItemClassID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Item Class", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    ItemType = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Type", grid.Locator, "ItemType");
                    ItemType.DataField = "ItemType";
                    ItemType.Items.Add("F", "Finished Good");
                    ItemType.Items.Add("M", "Component Part");
                    ItemType.Items.Add("A", "Subassembly");
                    ItemType.Items.Add("N", "Non-Stock Item");
                    ItemType.Items.Add("L", "Labor");
                    ItemType.Items.Add("S", "Service");
                    ItemType.Items.Add("C", "Charge");
                    ItemType.Items.Add("E", "Expense");
                    ValMethod = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Valuation Method", grid.Locator, "ValMethod");
                    ValMethod.DataField = "ValMethod";
                    ValMethod.Items.Add("T", "Standard");
                    ValMethod.Items.Add("A", "Average");
                    ValMethod.Items.Add("F", "FIFO");
                    ValMethod.Items.Add("S", "Specific");
                    LotSerClassID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Lot/Serial Class", grid.Locator, "LotSerClassID");
                    LotSerClassID.DataField = "LotSerClassID";
                    DfltSiteID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Default Warehouse", grid.Locator, "DfltSiteID");
                    DfltSiteID.DataField = "DfltSiteID";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    ItemStatus = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Item Status", grid.Locator, "ItemStatus");
                    ItemStatus.DataField = "ItemStatus";
                    ItemStatus.Items.Add("AC", "Active");
                    ItemStatus.Items.Add("NS", "No Sales");
                    ItemStatus.Items.Add("NP", "No Purchases");
                    ItemStatus.Items.Add("NR", "No Request");
                    ItemStatus.Items.Add("IN", "Inactive");
                    ItemStatus.Items.Add("DE", "Marked for Deletion");
                    TaxCalcMode = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Tax Calculation Mode", grid.Locator, "TaxCalcMode");
                    TaxCalcMode.DataField = "TaxCalcMode";
                    TaxCalcMode.Items.Add("T", "Tax Settings");
                    TaxCalcMode.Items.Add("G", "Gross");
                    TaxCalcMode.Items.Add("N", "Net");
                    WeightItem = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Weight Item", grid.Locator, "WeightItem");
                    WeightItem.DataField = "WeightItem";
                    BaseUnit = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Base Unit", grid.Locator, "BaseUnit");
                    BaseUnit.DataField = "BaseUnit";
                    SalesUnit = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Sales Unit", grid.Locator, "SalesUnit");
                    SalesUnit.DataField = "SalesUnit";
                    PurchaseUnit = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Purchase Unit", grid.Locator, "PurchaseUnit");
                    PurchaseUnit.DataField = "PurchaseUnit";
                    DecimalBaseUnit = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Divisible Unit", grid.Locator, "DecimalBaseUnit");
                    DecimalBaseUnit.DataField = "DecimalBaseUnit";
                    DecimalSalesUnit = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Divisible Unit", grid.Locator, "DecimalSalesUnit");
                    DecimalSalesUnit.DataField = "DecimalSalesUnit";
                    DecimalPurchaseUnit = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Divisible Unit", grid.Locator, "DecimalPurchaseUnit");
                    DecimalPurchaseUnit.DataField = "DecimalPurchaseUnit";
                    Commisionable = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Subject to Commission", grid.Locator, "Commisionable");
                    Commisionable.DataField = "Commisionable";
                    ReasonCodeSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Reason Code Sub.", grid.Locator, "ReasonCodeSubID");
                    ReasonCodeSubID.DataField = "ReasonCodeSubID";
                    SalesAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Sales Account", grid.Locator, "SalesAcctID");
                    SalesAcctID.DataField = "SalesAcctID";
                    SalesSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Sales Sub.", grid.Locator, "SalesSubID");
                    SalesSubID.DataField = "SalesSubID";
                    InvtAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Inventory Account", grid.Locator, "InvtAcctID");
                    InvtAcctID.DataField = "InvtAcctID";
                    InvtSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Inventory Sub.", grid.Locator, "InvtSubID");
                    InvtSubID.DataField = "InvtSubID";
                    COGSAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "COGS Account", grid.Locator, "COGSAcctID");
                    COGSAcctID.DataField = "COGSAcctID";
                    COGSSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "COGS Sub.", grid.Locator, "COGSSubID");
                    COGSSubID.DataField = "COGSSubID";
                    StdCstRevAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Standard Cost Revaluation Account", grid.Locator, "StdCstRevAcctID");
                    StdCstRevAcctID.DataField = "StdCstRevAcctID";
                    StdCstRevSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Standard Cost Revaluation Sub.", grid.Locator, "StdCstRevSubID");
                    StdCstRevSubID.DataField = "StdCstRevSubID";
                    StdCstVarAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Standard Cost Variance Account", grid.Locator, "StdCstVarAcctID");
                    StdCstVarAcctID.DataField = "StdCstVarAcctID";
                    StdCstVarSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Standard Cost Variance Sub.", grid.Locator, "StdCstVarSubID");
                    StdCstVarSubID.DataField = "StdCstVarSubID";
                    PPVAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Purchase Price Variance Account", grid.Locator, "PPVAcctID");
                    PPVAcctID.DataField = "PPVAcctID";
                    PPVSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Purchase Price Variance Sub.", grid.Locator, "PPVSubID");
                    PPVSubID.DataField = "PPVSubID";
                    POAccrualAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "PO Accrual Account", grid.Locator, "POAccrualAcctID");
                    POAccrualAcctID.DataField = "POAccrualAcctID";
                    POAccrualSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "PO Accrual Sub.", grid.Locator, "POAccrualSubID");
                    POAccrualSubID.DataField = "POAccrualSubID";
                    LCVarianceAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Landed Cost Variance Account", grid.Locator, "LCVarianceAcctID");
                    LCVarianceAcctID.DataField = "LCVarianceAcctID";
                    LCVarianceSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Landed Cost Variance Sub.", grid.Locator, "LCVarianceSubID");
                    LCVarianceSubID.DataField = "LCVarianceSubID";
                    DeferralAcctID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Deferral Account", grid.Locator, "DeferralAcctID");
                    DeferralAcctID.DataField = "DeferralAcctID";
                    DeferralSubID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Deferral Sub.", grid.Locator, "DeferralSubID");
                    DeferralSubID.DataField = "DeferralSubID";
                    LastStdCost = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Last Cost", grid.Locator, "LastStdCost");
                    LastStdCost.DataField = "LastStdCost";
                    PendingStdCost = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Pending Cost", grid.Locator, "PendingStdCost");
                    PendingStdCost.DataField = "PendingStdCost";
                    PendingStdCostDate = new DateSelector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ed41", "Pending Cost Date", grid.Locator, "PendingStdCostDate");
                    PendingStdCostDate.DataField = "PendingStdCostDate";
                    StdCost = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Current Cost", grid.Locator, "StdCost");
                    StdCost.DataField = "StdCost";
                    StdCostDate = new DateSelector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ed43", "Effective Date", grid.Locator, "StdCostDate");
                    StdCostDate.DataField = "StdCostDate";
                    BaseVolume = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Volume", grid.Locator, "BaseVolume");
                    BaseVolume.DataField = "BaseVolume";
                    BaseItemWeight = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Weight", grid.Locator, "BaseItemWeight");
                    BaseItemWeight.DataField = "BaseItemWeight";
                    BaseItemVolume = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Volume", grid.Locator, "BaseItemVolume");
                    BaseItemVolume.DataField = "BaseItemVolume";
                    WeightUOM = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Weight UOM", grid.Locator, "WeightUOM");
                    WeightUOM.DataField = "WeightUOM";
                    VolumeUOM = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Volume UOM", grid.Locator, "VolumeUOM");
                    VolumeUOM.DataField = "VolumeUOM";
                    PackSeparately = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Pack Separately", grid.Locator, "PackSeparately");
                    PackSeparately.DataField = "PackSeparately";
                    PackageOption = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Packaging Option", grid.Locator, "PackageOption");
                    PackageOption.DataField = "PackageOption";
                    PackageOption.Items.Add("N", "Manual");
                    PackageOption.Items.Add("W", "By Weight");
                    PackageOption.Items.Add("Q", "By Quantity");
                    PackageOption.Items.Add("V", "By Weight & Volume");
                    PreferredVendorID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Preferred Vendor", grid.Locator, "PreferredVendorID");
                    PreferredVendorID.DataField = "PreferredVendorID";
                    PreferredVendorLocationID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Preferred Location", grid.Locator, "PreferredVendorLocationID");
                    PreferredVendorLocationID.DataField = "PreferredVendorLocationID";
                    DefaultSubItemOnEntry = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Use On Entry", grid.Locator, "DefaultSubItemOnEntry");
                    DefaultSubItemOnEntry.DataField = "DefaultSubItemOnEntry";
                    DfltShipLocationID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Default Issue From", grid.Locator, "DfltShipLocationID");
                    DfltShipLocationID.DataField = "DfltShipLocationID";
                    DfltReceiptLocationID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Default Receipt To", grid.Locator, "DfltReceiptLocationID");
                    DfltReceiptLocationID.DataField = "DfltReceiptLocationID";
                    ProductWorkgroupID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Product Workgroup", grid.Locator, "ProductWorkgroupID");
                    ProductWorkgroupID.DataField = "ProductWorkgroupID";
                    ProductManagerID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Product Manager", grid.Locator, "ProductManagerID");
                    ProductManagerID.DataField = "ProductManagerID";
                    PriceWorkgroupID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Price Workgroup", grid.Locator, "PriceWorkgroupID");
                    PriceWorkgroupID.DataField = "PriceWorkgroupID";
                    PriceManagerID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Price Manager", grid.Locator, "PriceManagerID");
                    PriceManagerID.DataField = "PriceManagerID";
                    LotSerNumberResult = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Result of Generation Lot/Serial Number", grid.Locator, "LotSerNumberResult");
                    LotSerNumberResult.DataField = "LotSerNumberResult";
                    PostClassID = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_em", "Posting Class", grid.Locator, "PostClassID");
                    PostClassID.DataField = "PostClassID";
                    DeferredCode = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Deferral Code", grid.Locator, "DeferredCode");
                    DeferredCode.DataField = "DeferredCode";
                    DefaultTerm = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Default Term", grid.Locator, "DefaultTerm");
                    DefaultTerm.DataField = "DefaultTerm";
                    DefaultTermUOM = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Default Term UOM", grid.Locator, "DefaultTermUOM");
                    DefaultTermUOM.DataField = "DefaultTermUOM";
                    DefaultTermUOM.Items.Add("D", "day(s)");
                    DefaultTermUOM.Items.Add("W", "week(s)");
                    DefaultTermUOM.Items.Add("M", "month(s)");
                    DefaultTermUOM.Items.Add("Y", "year(s)");
                    PriceClassID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Price Class", grid.Locator, "PriceClassID");
                    PriceClassID.DataField = "PriceClassID";
                    IsSplitted = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Split into Components", grid.Locator, "IsSplitted");
                    IsSplitted.DataField = "IsSplitted";
                    UseParentSubID = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Use Component Subaccounts", grid.Locator, "UseParentSubID");
                    UseParentSubID.DataField = "UseParentSubID";
                    TotalPercentage = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Total Percentage", grid.Locator, "TotalPercentage");
                    TotalPercentage.DataField = "TotalPercentage";
                    KitItem = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Is a Kit", grid.Locator, "KitItem");
                    KitItem.DataField = "KitItem";
                    MinGrossProfitPct = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Min. Markup %", grid.Locator, "MinGrossProfitPct");
                    MinGrossProfitPct.DataField = "MinGrossProfitPct";
                    NonStockReceipt = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Require Receipt", grid.Locator, "NonStockReceipt");
                    NonStockReceipt.DataField = "NonStockReceipt";
                    NonStockShip = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Require Shipment", grid.Locator, "NonStockShip");
                    NonStockShip.DataField = "NonStockShip";
                    AccrueCost = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Accrue Cost", grid.Locator, "AccrueCost");
                    AccrueCost.DataField = "AccrueCost";
                    CostBasis = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Cost Based On", grid.Locator, "CostBasis");
                    CostBasis.DataField = "CostBasis";
                    CostBasis.Items.Add("S", "Standard Cost");
                    CostBasis.Items.Add("M", "Markup %");
                    CostBasis.Items.Add("P", "Percentage of Sales Price");
                    PercentOfSalesPrice = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Percent of Sales Price", grid.Locator, "PercentOfSalesPrice");
                    PercentOfSalesPrice.DataField = "PercentOfSalesPrice";
                    CompletePOLine = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Close PO Line", grid.Locator, "CompletePOLine");
                    CompletePOLine.DataField = "CompletePOLine";
                    CompletePOLine.Items.Add("A", "By Amount");
                    CompletePOLine.Items.Add("Q", "By Quantity");
                    ABCCodeID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "ABC Code", grid.Locator, "ABCCodeID");
                    ABCCodeID.DataField = "ABCCodeID";
                    ABCCodeIsFixed = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Fixed ABC Code", grid.Locator, "ABCCodeIsFixed");
                    ABCCodeIsFixed.DataField = "ABCCodeIsFixed";
                    MovementClassID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Movement Class", grid.Locator, "MovementClassID");
                    MovementClassID.DataField = "MovementClassID";
                    MovementClassIsFixed = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Fixed Movement Class", grid.Locator, "MovementClassIsFixed");
                    MovementClassIsFixed.DataField = "MovementClassIsFixed";
                    MarkupPct = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Markup %", grid.Locator, "MarkupPct");
                    MarkupPct.DataField = "MarkupPct";
                    RecPrice = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "MSRP", grid.Locator, "RecPrice");
                    RecPrice.DataField = "RecPrice";
                    ImageUrl = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Image", grid.Locator, "ImageUrl");
                    ImageUrl.DataField = "ImageUrl";
                    HSTariffCode = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Tariff Code", grid.Locator, "HSTariffCode");
                    HSTariffCode.DataField = "HSTariffCode";
                    UndershipThreshold = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Undership Threshold (%)", grid.Locator, "UndershipThreshold");
                    UndershipThreshold.DataField = "UndershipThreshold";
                    OvershipThreshold = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Overship Threshold (%)", grid.Locator, "OvershipThreshold");
                    OvershipThreshold.DataField = "OvershipThreshold";
                    CountryOfOrigin = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Country Of Origin", grid.Locator, "CountryOfOrigin");
                    CountryOfOrigin.DataField = "CountryOfOrigin";
                    CreatedByID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Created By", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ed89", "Created On", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    LastModifiedByID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Last Modified By", grid.Locator, "LastModifiedByID");
                    LastModifiedByID.DataField = "LastModifiedByID";
                    LastModifiedDateTime = new DateSelector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ed91", "Last Modified On", grid.Locator, "LastModifiedDateTime");
                    LastModifiedDateTime.DataField = "LastModifiedDateTime";
                    CycleID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "PI Cycle", grid.Locator, "CycleID");
                    CycleID.DataField = "CycleID";
                    Included = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Body = new InputLocalizable("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Content", grid.Locator, "Body");
                    Body.DataField = "Body";
                    TemplateItemID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Template ID", grid.Locator, "TemplateItemID");
                    TemplateItemID.DataField = "TemplateItemID";
                    DefaultRowMatrixAttributeID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Default Row Attribute ID", grid.Locator, "DefaultRowMatrixAttributeID");
                    DefaultRowMatrixAttributeID.DataField = "DefaultRowMatrixAttributeID";
                    DefaultColumnMatrixAttributeID = new Selector("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Default Column Attribute ID", grid.Locator, "DefaultColumnMatrixAttributeID");
                    DefaultColumnMatrixAttributeID.DataField = "DefaultColumnMatrixAttributeID";
                    Visibility = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Visibility", grid.Locator, "Visibility");
                    Visibility.DataField = "Visibility";
                    Visibility.Items.Add("V", "Visible");
                    Visibility.Items.Add("F", "Featured");
                    Visibility.Items.Add("I", "Invisible");
                    Availability = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Availability", grid.Locator, "Availability");
                    Availability.DataField = "Availability";
                    Availability.Items.Add("X", "Store Default");
                    Availability.Items.Add("T", "Available - Track Qty");
                    Availability.Items.Add("S", "Available - Don\'t Track Qty");
                    Availability.Items.Add("P", "Pre-Order");
                    Availability.Items.Add("D", "Disabled");
                    NotAvailMode = new DropDown("_ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "When Qty Unavailable", grid.Locator, "NotAvailMode");
                    NotAvailMode.DataField = "NotAvailMode";
                    NotAvailMode.Items.Add("X", "Store Default");
                    NotAvailMode.Items.Add("N", "Do Nothing");
                    NotAvailMode.Items.Add("D", "Set as Disabled");
                    NotAvailMode.Items.Add("P", "Set as Pre-Order");
                    New = new CheckBox("ctl00_phG_tab_t7_popupCreate_grdCreate", "New", grid.Locator, "New");
                    New.DataField = "New";
                    Qty = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    BasePrice = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "Default Price", grid.Locator, "BasePrice");
                    BasePrice.DataField = "BasePrice";
                    CustomURL = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Custom URL", grid.Locator, "CustomURL");
                    CustomURL.DataField = "CustomURL";
                    PageTitle = new InputLocalizable("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Page Title", grid.Locator, "PageTitle");
                    PageTitle.DataField = "PageTitle";
                    MetaDescription = new InputLocalizable("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Meta Description", grid.Locator, "MetaDescription");
                    MetaDescription.DataField = "MetaDescription";
                    MetaKeywords = new InputLocalizable("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Meta Keywords", grid.Locator, "MetaKeywords");
                    MetaKeywords.DataField = "MetaKeywords";
                    SearchKeywords = new InputLocalizable("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Search Keywords", grid.Locator, "SearchKeywords");
                    SearchKeywords.DataField = "SearchKeywords";
                    ShortDescription = new InputLocalizable("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Short Description", grid.Locator, "ShortDescription");
                    ShortDescription.DataField = "ShortDescription";
                    UsrCustom_1 = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Custom_1", grid.Locator, "UsrCustom_1");
                    UsrCustom_1.DataField = "UsrCustom_1";
                    UsrCustom_2 = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Custom_2", grid.Locator, "UsrCustom_2");
                    UsrCustom_2.DataField = "UsrCustom_2";
                    ReasonCodeSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "ReasonCodeSubID_Sub_description");
                    ReasonCodeSubID_Sub_description.DataField = "ReasonCodeSubID_Sub_description";
                    ReasonCodeSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "ReasonCodeSubID_description");
                    ReasonCodeSubID_description.DataField = "ReasonCodeSubID_description";
                    SalesAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "SalesAcctID_Account_description");
                    SalesAcctID_Account_description.DataField = "SalesAcctID_Account_description";
                    SalesAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "SalesAcctID_description");
                    SalesAcctID_description.DataField = "SalesAcctID_description";
                    SalesSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "SalesSubID_Sub_description");
                    SalesSubID_Sub_description.DataField = "SalesSubID_Sub_description";
                    SalesSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "SalesSubID_description");
                    SalesSubID_description.DataField = "SalesSubID_description";
                    InvtAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "InvtAcctID_Account_description");
                    InvtAcctID_Account_description.DataField = "InvtAcctID_Account_description";
                    InvtAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "InvtAcctID_description");
                    InvtAcctID_description.DataField = "InvtAcctID_description";
                    InvtSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "InvtSubID_Sub_description");
                    InvtSubID_Sub_description.DataField = "InvtSubID_Sub_description";
                    InvtSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "InvtSubID_description");
                    InvtSubID_description.DataField = "InvtSubID_description";
                    COGSAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "COGSAcctID_Account_description");
                    COGSAcctID_Account_description.DataField = "COGSAcctID_Account_description";
                    COGSAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "COGSAcctID_description");
                    COGSAcctID_description.DataField = "COGSAcctID_description";
                    COGSSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "COGSSubID_Sub_description");
                    COGSSubID_Sub_description.DataField = "COGSSubID_Sub_description";
                    COGSSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "COGSSubID_description");
                    COGSSubID_description.DataField = "COGSSubID_description";
                    StdCstRevAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstRevAcctID_Account_description");
                    StdCstRevAcctID_Account_description.DataField = "StdCstRevAcctID_Account_description";
                    StdCstRevAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstRevAcctID_description");
                    StdCstRevAcctID_description.DataField = "StdCstRevAcctID_description";
                    StdCstRevSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstRevSubID_Sub_description");
                    StdCstRevSubID_Sub_description.DataField = "StdCstRevSubID_Sub_description";
                    StdCstRevSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstRevSubID_description");
                    StdCstRevSubID_description.DataField = "StdCstRevSubID_description";
                    StdCstVarAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstVarAcctID_Account_description");
                    StdCstVarAcctID_Account_description.DataField = "StdCstVarAcctID_Account_description";
                    StdCstVarAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstVarAcctID_description");
                    StdCstVarAcctID_description.DataField = "StdCstVarAcctID_description";
                    StdCstVarSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstVarSubID_Sub_description");
                    StdCstVarSubID_Sub_description.DataField = "StdCstVarSubID_Sub_description";
                    StdCstVarSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "StdCstVarSubID_description");
                    StdCstVarSubID_description.DataField = "StdCstVarSubID_description";
                    PPVAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "PPVAcctID_Account_description");
                    PPVAcctID_Account_description.DataField = "PPVAcctID_Account_description";
                    PPVAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "PPVAcctID_description");
                    PPVAcctID_description.DataField = "PPVAcctID_description";
                    PPVSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "PPVSubID_Sub_description");
                    PPVSubID_Sub_description.DataField = "PPVSubID_Sub_description";
                    PPVSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "PPVSubID_description");
                    PPVSubID_description.DataField = "PPVSubID_description";
                    POAccrualAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "POAccrualAcctID_Account_description");
                    POAccrualAcctID_Account_description.DataField = "POAccrualAcctID_Account_description";
                    POAccrualAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "POAccrualAcctID_description");
                    POAccrualAcctID_description.DataField = "POAccrualAcctID_description";
                    POAccrualSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "POAccrualSubID_Sub_description");
                    POAccrualSubID_Sub_description.DataField = "POAccrualSubID_Sub_description";
                    POAccrualSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "POAccrualSubID_description");
                    POAccrualSubID_description.DataField = "POAccrualSubID_description";
                    LCVarianceAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "LCVarianceAcctID_Account_description");
                    LCVarianceAcctID_Account_description.DataField = "LCVarianceAcctID_Account_description";
                    LCVarianceAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "LCVarianceAcctID_description");
                    LCVarianceAcctID_description.DataField = "LCVarianceAcctID_description";
                    LCVarianceSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "LCVarianceSubID_Sub_description");
                    LCVarianceSubID_Sub_description.DataField = "LCVarianceSubID_Sub_description";
                    LCVarianceSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "LCVarianceSubID_description");
                    LCVarianceSubID_description.DataField = "LCVarianceSubID_description";
                    DeferralAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DeferralAcctID_Account_description");
                    DeferralAcctID_Account_description.DataField = "DeferralAcctID_Account_description";
                    DeferralAcctID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DeferralAcctID_description");
                    DeferralAcctID_description.DataField = "DeferralAcctID_description";
                    DeferralSubID_Sub_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DeferralSubID_Sub_description");
                    DeferralSubID_Sub_description.DataField = "DeferralSubID_Sub_description";
                    DeferralSubID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DeferralSubID_description");
                    DeferralSubID_description.DataField = "DeferralSubID_description";
                    PreferredVendorID_Vendor_acctName = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Vendor Name", grid.Locator, "PreferredVendorID_Vendor_acctName");
                    PreferredVendorID_Vendor_acctName.DataField = "PreferredVendorID_Vendor_acctName";
                    PreferredVendorID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Vendor Name", grid.Locator, "PreferredVendorID_description");
                    PreferredVendorID_description.DataField = "PreferredVendorID_description";
                    PreferredVendorID_BAccountR_acctName = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Vendor Name", grid.Locator, "PreferredVendorID_BAccountR_acctName");
                    PreferredVendorID_BAccountR_acctName.DataField = "PreferredVendorID_BAccountR_acctName";
                    PreferredVendorLocationID_Location_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Location Name", grid.Locator, "PreferredVendorLocationID_Location_descr");
                    PreferredVendorLocationID_Location_descr.DataField = "PreferredVendorLocationID_Location_descr";
                    PreferredVendorLocationID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Location Name", grid.Locator, "PreferredVendorLocationID_description");
                    PreferredVendorLocationID_description.DataField = "PreferredVendorLocationID_description";
                    DfltSiteID_INSite_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DfltSiteID_INSite_descr");
                    DfltSiteID_INSite_descr.DataField = "DfltSiteID_INSite_descr";
                    DfltSiteID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DfltSiteID_description");
                    DfltSiteID_description.DataField = "DfltSiteID_description";
                    DfltShipLocationID_INLocation_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DfltShipLocationID_INLocation_descr");
                    DfltShipLocationID_INLocation_descr.DataField = "DfltShipLocationID_INLocation_descr";
                    DfltShipLocationID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DfltShipLocationID_description");
                    DfltShipLocationID_description.DataField = "DfltShipLocationID_description";
                    DfltReceiptLocationID_INLocation_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DfltReceiptLocationID_INLocation_descr");
                    DfltReceiptLocationID_INLocation_descr.DataField = "DfltReceiptLocationID_INLocation_descr";
                    DfltReceiptLocationID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DfltReceiptLocationID_description");
                    DfltReceiptLocationID_description.DataField = "DfltReceiptLocationID_description";
                    ProductManagerID_Owner_displayName = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Contact", grid.Locator, "ProductManagerID_Owner_displayName");
                    ProductManagerID_Owner_displayName.DataField = "ProductManagerID_Owner_displayName";
                    ProductManagerID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Contact", grid.Locator, "ProductManagerID_description");
                    ProductManagerID_description.DataField = "ProductManagerID_description";
                    PriceManagerID_Owner_displayName = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Contact", grid.Locator, "PriceManagerID_Owner_displayName");
                    PriceManagerID_Owner_displayName.DataField = "PriceManagerID_Owner_displayName";
                    PriceManagerID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Contact", grid.Locator, "PriceManagerID_description");
                    PriceManagerID_description.DataField = "PriceManagerID_description";
                    LotSerClassID_INLotSerClass_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "LotSerClassID_INLotSerClass_descr");
                    LotSerClassID_INLotSerClass_descr.DataField = "LotSerClassID_INLotSerClass_descr";
                    LotSerClassID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "LotSerClassID_description");
                    LotSerClassID_description.DataField = "LotSerClassID_description";
                    PriceClassID_INPriceClass_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "PriceClassID_INPriceClass_description");
                    PriceClassID_INPriceClass_description.DataField = "PriceClassID_INPriceClass_description";
                    PriceClassID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "PriceClassID_description");
                    PriceClassID_description.DataField = "PriceClassID_description";
                    ABCCodeID_INABCCode_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "ABCCodeID_INABCCode_descr");
                    ABCCodeID_INABCCode_descr.DataField = "ABCCodeID_INABCCode_descr";
                    ABCCodeID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "ABCCodeID_description");
                    ABCCodeID_description.DataField = "ABCCodeID_description";
                    MovementClassID_INMovementClass_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "MovementClassID_INMovementClass_descr");
                    MovementClassID_INMovementClass_descr.DataField = "MovementClassID_INMovementClass_descr";
                    MovementClassID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "MovementClassID_description");
                    MovementClassID_description.DataField = "MovementClassID_description";
                    CountryOfOrigin_Country_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Country Name", grid.Locator, "CountryOfOrigin_Country_description");
                    CountryOfOrigin_Country_description.DataField = "CountryOfOrigin_Country_description";
                    CountryOfOrigin_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Country Name", grid.Locator, "CountryOfOrigin_description");
                    CountryOfOrigin_description.DataField = "CountryOfOrigin_description";
                    CreatedByID_Creator_displayName = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Created By", grid.Locator, "CreatedByID_Creator_displayName");
                    CreatedByID_Creator_displayName.DataField = "CreatedByID_Creator_displayName";
                    CreatedByID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Created By", grid.Locator, "CreatedByID_description");
                    CreatedByID_description.DataField = "CreatedByID_description";
                    CreatedByID_Creator_Username = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Created By", grid.Locator, "CreatedByID_Creator_Username");
                    CreatedByID_Creator_Username.DataField = "CreatedByID_Creator_Username";
                    LastModifiedByID_Modifier_displayName = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Last Modified By", grid.Locator, "LastModifiedByID_Modifier_displayName");
                    LastModifiedByID_Modifier_displayName.DataField = "LastModifiedByID_Modifier_displayName";
                    LastModifiedByID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Last Modified By", grid.Locator, "LastModifiedByID_description");
                    LastModifiedByID_description.DataField = "LastModifiedByID_description";
                    LastModifiedByID_Modifier_Username = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Last Modified By", grid.Locator, "LastModifiedByID_Modifier_Username");
                    LastModifiedByID_Modifier_Username.DataField = "LastModifiedByID_Modifier_Username";
                    CycleID_INPICycle_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "CycleID_INPICycle_descr");
                    CycleID_INPICycle_descr.DataField = "CycleID_INPICycle_descr";
                    CycleID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "CycleID_description");
                    CycleID_description.DataField = "CycleID_description";
                    TemplateItemID_InventoryItem_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "TemplateItemID_InventoryItem_descr");
                    TemplateItemID_InventoryItem_descr.DataField = "TemplateItemID_InventoryItem_descr";
                    TemplateItemID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "TemplateItemID_description");
                    TemplateItemID_description.DataField = "TemplateItemID_description";
                    DefaultRowMatrixAttributeID_CSAttribute_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DefaultRowMatrixAttributeID_CSAttribute_description");
                    DefaultRowMatrixAttributeID_CSAttribute_description.DataField = "DefaultRowMatrixAttributeID_CSAttribute_description";
                    DefaultRowMatrixAttributeID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DefaultRowMatrixAttributeID_description");
                    DefaultRowMatrixAttributeID_description.DataField = "DefaultRowMatrixAttributeID_description";
                    DefaultColumnMatrixAttributeID_CSAttribute_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DefaultColumnMatrixAttributeID_CSAttribute_description");
                    DefaultColumnMatrixAttributeID_CSAttribute_description.DataField = "DefaultColumnMatrixAttributeID_CSAttribute_description";
                    DefaultColumnMatrixAttributeID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "DefaultColumnMatrixAttributeID_description");
                    DefaultColumnMatrixAttributeID_description.DataField = "DefaultColumnMatrixAttributeID_description";
                    ItemClassID_INItemClass_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "ItemClassID_INItemClass_descr");
                    ItemClassID_INItemClass_descr.DataField = "ItemClassID_INItemClass_descr";
                    ItemClassID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "ItemClassID_description");
                    ItemClassID_description.DataField = "ItemClassID_description";
                    TaxCategoryID_TaxCategory_descr = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "TaxCategoryID_TaxCategory_descr");
                    TaxCategoryID_TaxCategory_descr.DataField = "TaxCategoryID_TaxCategory_descr";
                    TaxCategoryID_description = new PXTextEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_ei", "Description", grid.Locator, "TaxCategoryID_description");
                    TaxCategoryID_description.DataField = "TaxCategoryID_description";
                    InventoryID = new PXNumberEdit("ctl00_phG_tab_t7_popupCreate_grdCreate_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter InventoryCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter StkItem { get; }
				public SelectorColumnFilter ItemClassID { get; }
				public DropDownColumnFilter ItemType { get; }
				public DropDownColumnFilter ValMethod { get; }
				public SelectorColumnFilter LotSerClassID { get; }
				public SelectorColumnFilter DfltSiteID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public DropDownColumnFilter ItemStatus { get; }
				public DropDownColumnFilter TaxCalcMode { get; }
				public CheckBoxColumnFilter WeightItem { get; }
				public SelectorColumnFilter BaseUnit { get; }
				public SelectorColumnFilter SalesUnit { get; }
				public SelectorColumnFilter PurchaseUnit { get; }
				public CheckBoxColumnFilter DecimalBaseUnit { get; }
				public CheckBoxColumnFilter DecimalSalesUnit { get; }
				public CheckBoxColumnFilter DecimalPurchaseUnit { get; }
				public CheckBoxColumnFilter Commisionable { get; }
				public SelectorColumnFilter ReasonCodeSubID { get; }
				public SelectorColumnFilter SalesAcctID { get; }
				public SelectorColumnFilter SalesSubID { get; }
				public SelectorColumnFilter InvtAcctID { get; }
				public SelectorColumnFilter InvtSubID { get; }
				public SelectorColumnFilter COGSAcctID { get; }
				public SelectorColumnFilter COGSSubID { get; }
				public SelectorColumnFilter StdCstRevAcctID { get; }
				public SelectorColumnFilter StdCstRevSubID { get; }
				public SelectorColumnFilter StdCstVarAcctID { get; }
				public SelectorColumnFilter StdCstVarSubID { get; }
				public SelectorColumnFilter PPVAcctID { get; }
				public SelectorColumnFilter PPVSubID { get; }
				public SelectorColumnFilter POAccrualAcctID { get; }
				public SelectorColumnFilter POAccrualSubID { get; }
				public SelectorColumnFilter LCVarianceAcctID { get; }
				public SelectorColumnFilter LCVarianceSubID { get; }
				public SelectorColumnFilter DeferralAcctID { get; }
				public SelectorColumnFilter DeferralSubID { get; }
				public PXNumberEditColumnFilter LastStdCost { get; }
				public PXNumberEditColumnFilter PendingStdCost { get; }
				public DateSelectorColumnFilter PendingStdCostDate { get; }
				public PXNumberEditColumnFilter StdCost { get; }
				public DateSelectorColumnFilter StdCostDate { get; }
				public PXNumberEditColumnFilter BaseVolume { get; }
				public PXNumberEditColumnFilter BaseItemWeight { get; }
				public PXNumberEditColumnFilter BaseItemVolume { get; }
				public SelectorColumnFilter WeightUOM { get; }
				public SelectorColumnFilter VolumeUOM { get; }
				public CheckBoxColumnFilter PackSeparately { get; }
				public DropDownColumnFilter PackageOption { get; }
				public SelectorColumnFilter PreferredVendorID { get; }
				public SelectorColumnFilter PreferredVendorLocationID { get; }
				public CheckBoxColumnFilter DefaultSubItemOnEntry { get; }
				public SelectorColumnFilter DfltShipLocationID { get; }
				public SelectorColumnFilter DfltReceiptLocationID { get; }
				public SelectorColumnFilter ProductWorkgroupID { get; }
				public SelectorColumnFilter ProductManagerID { get; }
				public SelectorColumnFilter PriceWorkgroupID { get; }
				public SelectorColumnFilter PriceManagerID { get; }
				public PXTextEditColumnFilter LotSerNumberResult { get; }
				public PXTextEditColumnFilter PostClassID { get; }
				public SelectorColumnFilter DeferredCode { get; }
				public PXNumberEditColumnFilter DefaultTerm { get; }
				public DropDownColumnFilter DefaultTermUOM { get; }
				public SelectorColumnFilter PriceClassID { get; }
				public CheckBoxColumnFilter IsSplitted { get; }
				public CheckBoxColumnFilter UseParentSubID { get; }
				public PXNumberEditColumnFilter TotalPercentage { get; }
				public CheckBoxColumnFilter KitItem { get; }
				public PXNumberEditColumnFilter MinGrossProfitPct { get; }
				public CheckBoxColumnFilter NonStockReceipt { get; }
				public CheckBoxColumnFilter NonStockShip { get; }
				public CheckBoxColumnFilter AccrueCost { get; }
				public DropDownColumnFilter CostBasis { get; }
				public PXNumberEditColumnFilter PercentOfSalesPrice { get; }
				public DropDownColumnFilter CompletePOLine { get; }
				public SelectorColumnFilter ABCCodeID { get; }
				public CheckBoxColumnFilter ABCCodeIsFixed { get; }
				public SelectorColumnFilter MovementClassID { get; }
				public CheckBoxColumnFilter MovementClassIsFixed { get; }
				public PXNumberEditColumnFilter MarkupPct { get; }
				public PXNumberEditColumnFilter RecPrice { get; }
				public PXTextEditColumnFilter ImageUrl { get; }
				public PXTextEditColumnFilter HSTariffCode { get; }
				public PXNumberEditColumnFilter UndershipThreshold { get; }
				public PXNumberEditColumnFilter OvershipThreshold { get; }
				public SelectorColumnFilter CountryOfOrigin { get; }
				public SelectorColumnFilter CreatedByID { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public SelectorColumnFilter LastModifiedByID { get; }
				public DateSelectorColumnFilter LastModifiedDateTime { get; }
				public SelectorColumnFilter CycleID { get; }
				public CheckBoxColumnFilter Included { get; }
				public PXTextEditColumnFilter Body { get; }
				public SelectorColumnFilter TemplateItemID { get; }
				public SelectorColumnFilter DefaultRowMatrixAttributeID { get; }
				public SelectorColumnFilter DefaultColumnMatrixAttributeID { get; }
				public DropDownColumnFilter Visibility { get; }
				public DropDownColumnFilter Availability { get; }
				public DropDownColumnFilter NotAvailMode { get; }
				public CheckBoxColumnFilter New { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter BasePrice { get; }
				public PXTextEditColumnFilter CustomURL { get; }
				public PXTextEditColumnFilter PageTitle { get; }
				public PXTextEditColumnFilter MetaDescription { get; }
				public PXTextEditColumnFilter MetaKeywords { get; }
				public PXTextEditColumnFilter SearchKeywords { get; }
				public PXTextEditColumnFilter ShortDescription { get; }
				public PXTextEditColumnFilter UsrCustom_1 { get; }
				public PXTextEditColumnFilter UsrCustom_2 { get; }
				public PXTextEditColumnFilter ReasonCodeSubID_Sub_description { get; }
				public PXTextEditColumnFilter ReasonCodeSubID_description { get; }
				public PXTextEditColumnFilter SalesAcctID_Account_description { get; }
				public PXTextEditColumnFilter SalesAcctID_description { get; }
				public PXTextEditColumnFilter SalesSubID_Sub_description { get; }
				public PXTextEditColumnFilter SalesSubID_description { get; }
				public PXTextEditColumnFilter InvtAcctID_Account_description { get; }
				public PXTextEditColumnFilter InvtAcctID_description { get; }
				public PXTextEditColumnFilter InvtSubID_Sub_description { get; }
				public PXTextEditColumnFilter InvtSubID_description { get; }
				public PXTextEditColumnFilter COGSAcctID_Account_description { get; }
				public PXTextEditColumnFilter COGSAcctID_description { get; }
				public PXTextEditColumnFilter COGSSubID_Sub_description { get; }
				public PXTextEditColumnFilter COGSSubID_description { get; }
				public PXTextEditColumnFilter StdCstRevAcctID_Account_description { get; }
				public PXTextEditColumnFilter StdCstRevAcctID_description { get; }
				public PXTextEditColumnFilter StdCstRevSubID_Sub_description { get; }
				public PXTextEditColumnFilter StdCstRevSubID_description { get; }
				public PXTextEditColumnFilter StdCstVarAcctID_Account_description { get; }
				public PXTextEditColumnFilter StdCstVarAcctID_description { get; }
				public PXTextEditColumnFilter StdCstVarSubID_Sub_description { get; }
				public PXTextEditColumnFilter StdCstVarSubID_description { get; }
				public PXTextEditColumnFilter PPVAcctID_Account_description { get; }
				public PXTextEditColumnFilter PPVAcctID_description { get; }
				public PXTextEditColumnFilter PPVSubID_Sub_description { get; }
				public PXTextEditColumnFilter PPVSubID_description { get; }
				public PXTextEditColumnFilter POAccrualAcctID_Account_description { get; }
				public PXTextEditColumnFilter POAccrualAcctID_description { get; }
				public PXTextEditColumnFilter POAccrualSubID_Sub_description { get; }
				public PXTextEditColumnFilter POAccrualSubID_description { get; }
				public PXTextEditColumnFilter LCVarianceAcctID_Account_description { get; }
				public PXTextEditColumnFilter LCVarianceAcctID_description { get; }
				public PXTextEditColumnFilter LCVarianceSubID_Sub_description { get; }
				public PXTextEditColumnFilter LCVarianceSubID_description { get; }
				public PXTextEditColumnFilter DeferralAcctID_Account_description { get; }
				public PXTextEditColumnFilter DeferralAcctID_description { get; }
				public PXTextEditColumnFilter DeferralSubID_Sub_description { get; }
				public PXTextEditColumnFilter DeferralSubID_description { get; }
				public PXTextEditColumnFilter PreferredVendorID_Vendor_acctName { get; }
				public PXTextEditColumnFilter PreferredVendorID_description { get; }
				public PXTextEditColumnFilter PreferredVendorID_BAccountR_acctName { get; }
				public PXTextEditColumnFilter PreferredVendorLocationID_Location_descr { get; }
				public PXTextEditColumnFilter PreferredVendorLocationID_description { get; }
				public PXTextEditColumnFilter DfltSiteID_INSite_descr { get; }
				public PXTextEditColumnFilter DfltSiteID_description { get; }
				public PXTextEditColumnFilter DfltShipLocationID_INLocation_descr { get; }
				public PXTextEditColumnFilter DfltShipLocationID_description { get; }
				public PXTextEditColumnFilter DfltReceiptLocationID_INLocation_descr { get; }
				public PXTextEditColumnFilter DfltReceiptLocationID_description { get; }
				public PXTextEditColumnFilter ProductManagerID_Owner_displayName { get; }
				public PXTextEditColumnFilter ProductManagerID_description { get; }
				public PXTextEditColumnFilter PriceManagerID_Owner_displayName { get; }
				public PXTextEditColumnFilter PriceManagerID_description { get; }
				public PXTextEditColumnFilter LotSerClassID_INLotSerClass_descr { get; }
				public PXTextEditColumnFilter LotSerClassID_description { get; }
				public PXTextEditColumnFilter PriceClassID_INPriceClass_description { get; }
				public PXTextEditColumnFilter PriceClassID_description { get; }
				public PXTextEditColumnFilter ABCCodeID_INABCCode_descr { get; }
				public PXTextEditColumnFilter ABCCodeID_description { get; }
				public PXTextEditColumnFilter MovementClassID_INMovementClass_descr { get; }
				public PXTextEditColumnFilter MovementClassID_description { get; }
				public PXTextEditColumnFilter CountryOfOrigin_Country_description { get; }
				public PXTextEditColumnFilter CountryOfOrigin_description { get; }
				public PXTextEditColumnFilter CreatedByID_Creator_displayName { get; }
				public PXTextEditColumnFilter CreatedByID_description { get; }
				public PXTextEditColumnFilter CreatedByID_Creator_Username { get; }
				public PXTextEditColumnFilter LastModifiedByID_Modifier_displayName { get; }
				public PXTextEditColumnFilter LastModifiedByID_description { get; }
				public PXTextEditColumnFilter LastModifiedByID_Modifier_Username { get; }
				public PXTextEditColumnFilter CycleID_INPICycle_descr { get; }
				public PXTextEditColumnFilter CycleID_description { get; }
				public PXTextEditColumnFilter TemplateItemID_InventoryItem_descr { get; }
				public PXTextEditColumnFilter TemplateItemID_description { get; }
				public PXTextEditColumnFilter DefaultRowMatrixAttributeID_CSAttribute_description { get; }
				public PXTextEditColumnFilter DefaultRowMatrixAttributeID_description { get; }
				public PXTextEditColumnFilter DefaultColumnMatrixAttributeID_CSAttribute_description { get; }
				public PXTextEditColumnFilter DefaultColumnMatrixAttributeID_description { get; }
				public PXTextEditColumnFilter ItemClassID_INItemClass_descr { get; }
				public PXTextEditColumnFilter ItemClassID_description { get; }
				public PXTextEditColumnFilter TaxCategoryID_TaxCategory_descr { get; }
				public PXTextEditColumnFilter TaxCategoryID_description { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
                
                public c_grid_header(c_matrixitemsforcreation_grdcreate grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    InventoryCD = new SelectorColumnFilter(grid.Row.InventoryCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    StkItem = new CheckBoxColumnFilter(grid.Row.StkItem);
                    ItemClassID = new SelectorColumnFilter(grid.Row.ItemClassID);
                    ItemType = new DropDownColumnFilter(grid.Row.ItemType);
                    ValMethod = new DropDownColumnFilter(grid.Row.ValMethod);
                    LotSerClassID = new SelectorColumnFilter(grid.Row.LotSerClassID);
                    DfltSiteID = new SelectorColumnFilter(grid.Row.DfltSiteID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    ItemStatus = new DropDownColumnFilter(grid.Row.ItemStatus);
                    TaxCalcMode = new DropDownColumnFilter(grid.Row.TaxCalcMode);
                    WeightItem = new CheckBoxColumnFilter(grid.Row.WeightItem);
                    BaseUnit = new SelectorColumnFilter(grid.Row.BaseUnit);
                    SalesUnit = new SelectorColumnFilter(grid.Row.SalesUnit);
                    PurchaseUnit = new SelectorColumnFilter(grid.Row.PurchaseUnit);
                    DecimalBaseUnit = new CheckBoxColumnFilter(grid.Row.DecimalBaseUnit);
                    DecimalSalesUnit = new CheckBoxColumnFilter(grid.Row.DecimalSalesUnit);
                    DecimalPurchaseUnit = new CheckBoxColumnFilter(grid.Row.DecimalPurchaseUnit);
                    Commisionable = new CheckBoxColumnFilter(grid.Row.Commisionable);
                    ReasonCodeSubID = new SelectorColumnFilter(grid.Row.ReasonCodeSubID);
                    SalesAcctID = new SelectorColumnFilter(grid.Row.SalesAcctID);
                    SalesSubID = new SelectorColumnFilter(grid.Row.SalesSubID);
                    InvtAcctID = new SelectorColumnFilter(grid.Row.InvtAcctID);
                    InvtSubID = new SelectorColumnFilter(grid.Row.InvtSubID);
                    COGSAcctID = new SelectorColumnFilter(grid.Row.COGSAcctID);
                    COGSSubID = new SelectorColumnFilter(grid.Row.COGSSubID);
                    StdCstRevAcctID = new SelectorColumnFilter(grid.Row.StdCstRevAcctID);
                    StdCstRevSubID = new SelectorColumnFilter(grid.Row.StdCstRevSubID);
                    StdCstVarAcctID = new SelectorColumnFilter(grid.Row.StdCstVarAcctID);
                    StdCstVarSubID = new SelectorColumnFilter(grid.Row.StdCstVarSubID);
                    PPVAcctID = new SelectorColumnFilter(grid.Row.PPVAcctID);
                    PPVSubID = new SelectorColumnFilter(grid.Row.PPVSubID);
                    POAccrualAcctID = new SelectorColumnFilter(grid.Row.POAccrualAcctID);
                    POAccrualSubID = new SelectorColumnFilter(grid.Row.POAccrualSubID);
                    LCVarianceAcctID = new SelectorColumnFilter(grid.Row.LCVarianceAcctID);
                    LCVarianceSubID = new SelectorColumnFilter(grid.Row.LCVarianceSubID);
                    DeferralAcctID = new SelectorColumnFilter(grid.Row.DeferralAcctID);
                    DeferralSubID = new SelectorColumnFilter(grid.Row.DeferralSubID);
                    LastStdCost = new PXNumberEditColumnFilter(grid.Row.LastStdCost);
                    PendingStdCost = new PXNumberEditColumnFilter(grid.Row.PendingStdCost);
                    PendingStdCostDate = new DateSelectorColumnFilter(grid.Row.PendingStdCostDate);
                    StdCost = new PXNumberEditColumnFilter(grid.Row.StdCost);
                    StdCostDate = new DateSelectorColumnFilter(grid.Row.StdCostDate);
                    BaseVolume = new PXNumberEditColumnFilter(grid.Row.BaseVolume);
                    BaseItemWeight = new PXNumberEditColumnFilter(grid.Row.BaseItemWeight);
                    BaseItemVolume = new PXNumberEditColumnFilter(grid.Row.BaseItemVolume);
                    WeightUOM = new SelectorColumnFilter(grid.Row.WeightUOM);
                    VolumeUOM = new SelectorColumnFilter(grid.Row.VolumeUOM);
                    PackSeparately = new CheckBoxColumnFilter(grid.Row.PackSeparately);
                    PackageOption = new DropDownColumnFilter(grid.Row.PackageOption);
                    PreferredVendorID = new SelectorColumnFilter(grid.Row.PreferredVendorID);
                    PreferredVendorLocationID = new SelectorColumnFilter(grid.Row.PreferredVendorLocationID);
                    DefaultSubItemOnEntry = new CheckBoxColumnFilter(grid.Row.DefaultSubItemOnEntry);
                    DfltShipLocationID = new SelectorColumnFilter(grid.Row.DfltShipLocationID);
                    DfltReceiptLocationID = new SelectorColumnFilter(grid.Row.DfltReceiptLocationID);
                    ProductWorkgroupID = new SelectorColumnFilter(grid.Row.ProductWorkgroupID);
                    ProductManagerID = new SelectorColumnFilter(grid.Row.ProductManagerID);
                    PriceWorkgroupID = new SelectorColumnFilter(grid.Row.PriceWorkgroupID);
                    PriceManagerID = new SelectorColumnFilter(grid.Row.PriceManagerID);
                    LotSerNumberResult = new PXTextEditColumnFilter(grid.Row.LotSerNumberResult);
                    PostClassID = new PXTextEditColumnFilter(grid.Row.PostClassID);
                    DeferredCode = new SelectorColumnFilter(grid.Row.DeferredCode);
                    DefaultTerm = new PXNumberEditColumnFilter(grid.Row.DefaultTerm);
                    DefaultTermUOM = new DropDownColumnFilter(grid.Row.DefaultTermUOM);
                    PriceClassID = new SelectorColumnFilter(grid.Row.PriceClassID);
                    IsSplitted = new CheckBoxColumnFilter(grid.Row.IsSplitted);
                    UseParentSubID = new CheckBoxColumnFilter(grid.Row.UseParentSubID);
                    TotalPercentage = new PXNumberEditColumnFilter(grid.Row.TotalPercentage);
                    KitItem = new CheckBoxColumnFilter(grid.Row.KitItem);
                    MinGrossProfitPct = new PXNumberEditColumnFilter(grid.Row.MinGrossProfitPct);
                    NonStockReceipt = new CheckBoxColumnFilter(grid.Row.NonStockReceipt);
                    NonStockShip = new CheckBoxColumnFilter(grid.Row.NonStockShip);
                    AccrueCost = new CheckBoxColumnFilter(grid.Row.AccrueCost);
                    CostBasis = new DropDownColumnFilter(grid.Row.CostBasis);
                    PercentOfSalesPrice = new PXNumberEditColumnFilter(grid.Row.PercentOfSalesPrice);
                    CompletePOLine = new DropDownColumnFilter(grid.Row.CompletePOLine);
                    ABCCodeID = new SelectorColumnFilter(grid.Row.ABCCodeID);
                    ABCCodeIsFixed = new CheckBoxColumnFilter(grid.Row.ABCCodeIsFixed);
                    MovementClassID = new SelectorColumnFilter(grid.Row.MovementClassID);
                    MovementClassIsFixed = new CheckBoxColumnFilter(grid.Row.MovementClassIsFixed);
                    MarkupPct = new PXNumberEditColumnFilter(grid.Row.MarkupPct);
                    RecPrice = new PXNumberEditColumnFilter(grid.Row.RecPrice);
                    ImageUrl = new PXTextEditColumnFilter(grid.Row.ImageUrl);
                    HSTariffCode = new PXTextEditColumnFilter(grid.Row.HSTariffCode);
                    UndershipThreshold = new PXNumberEditColumnFilter(grid.Row.UndershipThreshold);
                    OvershipThreshold = new PXNumberEditColumnFilter(grid.Row.OvershipThreshold);
                    CountryOfOrigin = new SelectorColumnFilter(grid.Row.CountryOfOrigin);
                    CreatedByID = new SelectorColumnFilter(grid.Row.CreatedByID);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    LastModifiedByID = new SelectorColumnFilter(grid.Row.LastModifiedByID);
                    LastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.LastModifiedDateTime);
                    CycleID = new SelectorColumnFilter(grid.Row.CycleID);
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    Body = new PXTextEditColumnFilter(grid.Row.Body);
                    TemplateItemID = new SelectorColumnFilter(grid.Row.TemplateItemID);
                    DefaultRowMatrixAttributeID = new SelectorColumnFilter(grid.Row.DefaultRowMatrixAttributeID);
                    DefaultColumnMatrixAttributeID = new SelectorColumnFilter(grid.Row.DefaultColumnMatrixAttributeID);
                    Visibility = new DropDownColumnFilter(grid.Row.Visibility);
                    Availability = new DropDownColumnFilter(grid.Row.Availability);
                    NotAvailMode = new DropDownColumnFilter(grid.Row.NotAvailMode);
                    New = new CheckBoxColumnFilter(grid.Row.New);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    BasePrice = new PXNumberEditColumnFilter(grid.Row.BasePrice);
                    CustomURL = new PXTextEditColumnFilter(grid.Row.CustomURL);
                    PageTitle = new PXTextEditColumnFilter(grid.Row.PageTitle);
                    MetaDescription = new PXTextEditColumnFilter(grid.Row.MetaDescription);
                    MetaKeywords = new PXTextEditColumnFilter(grid.Row.MetaKeywords);
                    SearchKeywords = new PXTextEditColumnFilter(grid.Row.SearchKeywords);
                    ShortDescription = new PXTextEditColumnFilter(grid.Row.ShortDescription);
                    UsrCustom_1 = new PXTextEditColumnFilter(grid.Row.UsrCustom_1);
                    UsrCustom_2 = new PXTextEditColumnFilter(grid.Row.UsrCustom_2);
                    ReasonCodeSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.ReasonCodeSubID_Sub_description);
                    ReasonCodeSubID_description = new PXTextEditColumnFilter(grid.Row.ReasonCodeSubID_description);
                    SalesAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.SalesAcctID_Account_description);
                    SalesAcctID_description = new PXTextEditColumnFilter(grid.Row.SalesAcctID_description);
                    SalesSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.SalesSubID_Sub_description);
                    SalesSubID_description = new PXTextEditColumnFilter(grid.Row.SalesSubID_description);
                    InvtAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.InvtAcctID_Account_description);
                    InvtAcctID_description = new PXTextEditColumnFilter(grid.Row.InvtAcctID_description);
                    InvtSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.InvtSubID_Sub_description);
                    InvtSubID_description = new PXTextEditColumnFilter(grid.Row.InvtSubID_description);
                    COGSAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.COGSAcctID_Account_description);
                    COGSAcctID_description = new PXTextEditColumnFilter(grid.Row.COGSAcctID_description);
                    COGSSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.COGSSubID_Sub_description);
                    COGSSubID_description = new PXTextEditColumnFilter(grid.Row.COGSSubID_description);
                    StdCstRevAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.StdCstRevAcctID_Account_description);
                    StdCstRevAcctID_description = new PXTextEditColumnFilter(grid.Row.StdCstRevAcctID_description);
                    StdCstRevSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.StdCstRevSubID_Sub_description);
                    StdCstRevSubID_description = new PXTextEditColumnFilter(grid.Row.StdCstRevSubID_description);
                    StdCstVarAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.StdCstVarAcctID_Account_description);
                    StdCstVarAcctID_description = new PXTextEditColumnFilter(grid.Row.StdCstVarAcctID_description);
                    StdCstVarSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.StdCstVarSubID_Sub_description);
                    StdCstVarSubID_description = new PXTextEditColumnFilter(grid.Row.StdCstVarSubID_description);
                    PPVAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.PPVAcctID_Account_description);
                    PPVAcctID_description = new PXTextEditColumnFilter(grid.Row.PPVAcctID_description);
                    PPVSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.PPVSubID_Sub_description);
                    PPVSubID_description = new PXTextEditColumnFilter(grid.Row.PPVSubID_description);
                    POAccrualAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.POAccrualAcctID_Account_description);
                    POAccrualAcctID_description = new PXTextEditColumnFilter(grid.Row.POAccrualAcctID_description);
                    POAccrualSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.POAccrualSubID_Sub_description);
                    POAccrualSubID_description = new PXTextEditColumnFilter(grid.Row.POAccrualSubID_description);
                    LCVarianceAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.LCVarianceAcctID_Account_description);
                    LCVarianceAcctID_description = new PXTextEditColumnFilter(grid.Row.LCVarianceAcctID_description);
                    LCVarianceSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.LCVarianceSubID_Sub_description);
                    LCVarianceSubID_description = new PXTextEditColumnFilter(grid.Row.LCVarianceSubID_description);
                    DeferralAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.DeferralAcctID_Account_description);
                    DeferralAcctID_description = new PXTextEditColumnFilter(grid.Row.DeferralAcctID_description);
                    DeferralSubID_Sub_description = new PXTextEditColumnFilter(grid.Row.DeferralSubID_Sub_description);
                    DeferralSubID_description = new PXTextEditColumnFilter(grid.Row.DeferralSubID_description);
                    PreferredVendorID_Vendor_acctName = new PXTextEditColumnFilter(grid.Row.PreferredVendorID_Vendor_acctName);
                    PreferredVendorID_description = new PXTextEditColumnFilter(grid.Row.PreferredVendorID_description);
                    PreferredVendorID_BAccountR_acctName = new PXTextEditColumnFilter(grid.Row.PreferredVendorID_BAccountR_acctName);
                    PreferredVendorLocationID_Location_descr = new PXTextEditColumnFilter(grid.Row.PreferredVendorLocationID_Location_descr);
                    PreferredVendorLocationID_description = new PXTextEditColumnFilter(grid.Row.PreferredVendorLocationID_description);
                    DfltSiteID_INSite_descr = new PXTextEditColumnFilter(grid.Row.DfltSiteID_INSite_descr);
                    DfltSiteID_description = new PXTextEditColumnFilter(grid.Row.DfltSiteID_description);
                    DfltShipLocationID_INLocation_descr = new PXTextEditColumnFilter(grid.Row.DfltShipLocationID_INLocation_descr);
                    DfltShipLocationID_description = new PXTextEditColumnFilter(grid.Row.DfltShipLocationID_description);
                    DfltReceiptLocationID_INLocation_descr = new PXTextEditColumnFilter(grid.Row.DfltReceiptLocationID_INLocation_descr);
                    DfltReceiptLocationID_description = new PXTextEditColumnFilter(grid.Row.DfltReceiptLocationID_description);
                    ProductManagerID_Owner_displayName = new PXTextEditColumnFilter(grid.Row.ProductManagerID_Owner_displayName);
                    ProductManagerID_description = new PXTextEditColumnFilter(grid.Row.ProductManagerID_description);
                    PriceManagerID_Owner_displayName = new PXTextEditColumnFilter(grid.Row.PriceManagerID_Owner_displayName);
                    PriceManagerID_description = new PXTextEditColumnFilter(grid.Row.PriceManagerID_description);
                    LotSerClassID_INLotSerClass_descr = new PXTextEditColumnFilter(grid.Row.LotSerClassID_INLotSerClass_descr);
                    LotSerClassID_description = new PXTextEditColumnFilter(grid.Row.LotSerClassID_description);
                    PriceClassID_INPriceClass_description = new PXTextEditColumnFilter(grid.Row.PriceClassID_INPriceClass_description);
                    PriceClassID_description = new PXTextEditColumnFilter(grid.Row.PriceClassID_description);
                    ABCCodeID_INABCCode_descr = new PXTextEditColumnFilter(grid.Row.ABCCodeID_INABCCode_descr);
                    ABCCodeID_description = new PXTextEditColumnFilter(grid.Row.ABCCodeID_description);
                    MovementClassID_INMovementClass_descr = new PXTextEditColumnFilter(grid.Row.MovementClassID_INMovementClass_descr);
                    MovementClassID_description = new PXTextEditColumnFilter(grid.Row.MovementClassID_description);
                    CountryOfOrigin_Country_description = new PXTextEditColumnFilter(grid.Row.CountryOfOrigin_Country_description);
                    CountryOfOrigin_description = new PXTextEditColumnFilter(grid.Row.CountryOfOrigin_description);
                    CreatedByID_Creator_displayName = new PXTextEditColumnFilter(grid.Row.CreatedByID_Creator_displayName);
                    CreatedByID_description = new PXTextEditColumnFilter(grid.Row.CreatedByID_description);
                    CreatedByID_Creator_Username = new PXTextEditColumnFilter(grid.Row.CreatedByID_Creator_Username);
                    LastModifiedByID_Modifier_displayName = new PXTextEditColumnFilter(grid.Row.LastModifiedByID_Modifier_displayName);
                    LastModifiedByID_description = new PXTextEditColumnFilter(grid.Row.LastModifiedByID_description);
                    LastModifiedByID_Modifier_Username = new PXTextEditColumnFilter(grid.Row.LastModifiedByID_Modifier_Username);
                    CycleID_INPICycle_descr = new PXTextEditColumnFilter(grid.Row.CycleID_INPICycle_descr);
                    CycleID_description = new PXTextEditColumnFilter(grid.Row.CycleID_description);
                    TemplateItemID_InventoryItem_descr = new PXTextEditColumnFilter(grid.Row.TemplateItemID_InventoryItem_descr);
                    TemplateItemID_description = new PXTextEditColumnFilter(grid.Row.TemplateItemID_description);
                    DefaultRowMatrixAttributeID_CSAttribute_description = new PXTextEditColumnFilter(grid.Row.DefaultRowMatrixAttributeID_CSAttribute_description);
                    DefaultRowMatrixAttributeID_description = new PXTextEditColumnFilter(grid.Row.DefaultRowMatrixAttributeID_description);
                    DefaultColumnMatrixAttributeID_CSAttribute_description = new PXTextEditColumnFilter(grid.Row.DefaultColumnMatrixAttributeID_CSAttribute_description);
                    DefaultColumnMatrixAttributeID_description = new PXTextEditColumnFilter(grid.Row.DefaultColumnMatrixAttributeID_description);
                    ItemClassID_INItemClass_descr = new PXTextEditColumnFilter(grid.Row.ItemClassID_INItemClass_descr);
                    ItemClassID_description = new PXTextEditColumnFilter(grid.Row.ItemClassID_description);
                    TaxCategoryID_TaxCategory_descr = new PXTextEditColumnFilter(grid.Row.TaxCategoryID_TaxCategory_descr);
                    TaxCategoryID_description = new PXTextEditColumnFilter(grid.Row.TaxCategoryID_description);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_matrixitemsforcreation_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_matrixitemsforcreation_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t7_popupCreate_grdCreate_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "MatrixItemsForCreation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Confirmation()
            {
                Buttons.Confirmation.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirmation { get; }
                
                public PxButtonCollection()
                {
                    Confirmation = new Button("ctl00_phG_tab_t7_popupCreate_btnCreateUpdate", "Confirmation", "ctl00_phG_tab_t7_popupCreate_grdCreate_lv0");
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
        
        public class c_itemsettings_filesgrid : Grid<c_itemsettings_filesgrid.c_grid_row, c_itemsettings_filesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_itemsettings_filesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid");
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_at_tlb div[dat" +
                            "a-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_at_tlb div[dat" +
                            "a-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[dat" +
                            "a-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    UpBtn = new Button("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_attFileUp_upBtn", "upBtn", "ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Name { get; }
			public PXTextEdit Size { get; }
			public PXTextEdit Comment { get; }
                
                public c_grid_row(c_itemsettings_filesgrid grid) : 
                        base(grid)
                {
                    Name = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Size = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Size (kb)", grid.Locator, "Size");
                    Size.DataField = "Size";
                    Comment = new PXTextEdit("ctl00_phG_tab_t5_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Name { get; }
				public PXTextEditColumnFilter Size { get; }
				public PXTextEditColumnFilter Comment { get; }
                
                public c_grid_header(c_itemsettings_filesgrid grid) : 
                        base(grid)
                {
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    Size = new PXTextEditColumnFilter(grid.Row.Size);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                }
            }
        }
    }
}
