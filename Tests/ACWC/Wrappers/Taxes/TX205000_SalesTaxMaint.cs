using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
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
    
    
    public class TX205000_SalesTaxMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_tax_tab Tax_tab { get; } = new c_tax_tab("ctl00_phF_tab", "Tax_tab");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_currenttax_glaccountslocation CurrentTax_GLAccountsLocation { get; } = new c_currenttax_glaccountslocation("ctl00_phG_PXTab1_t3_GLAccountsLocation", "CurrentTax_GLAccountsLocation");
        protected c_taxforprintingparameterstab_edprintingparameters TaxForPrintingParametersTab_edPrintingParameters { get; } = new c_taxforprintingparameterstab_edprintingparameters("ctl00_phG_PXTab1_t4_edPrintingParameters", "TaxForPrintingParametersTab_edPrintingParameters");
        protected c_taxrevisions_grid1 TaxRevisions_grid1 { get; } = new c_taxrevisions_grid1("ctl00_phG_PXTab1_t0_grid1", "TaxRevisions_grid1");
        protected c_taxrevisions_lv0 TaxRevisions_lv0 { get; } = new c_taxrevisions_lv0("ctl00_phG_PXTab1_t0_grid1_lv0", "TaxRevisions_lv0");
        protected c_categories_grid2 Categories_grid2 { get; } = new c_categories_grid2("ctl00_phG_PXTab1_t1_grid2", "Categories_grid2");
        protected c_categories_lv0 Categories_lv0 { get; } = new c_categories_lv0("ctl00_phG_PXTab1_t1_grid2_lv0", "Categories_lv0");
        protected c_zones_grid3 Zones_grid3 { get; } = new c_zones_grid3("ctl00_phG_PXTab1_t2_grid3", "Zones_grid3");
        protected c_zones_lv0 Zones_lv0 { get; } = new c_zones_lv0("ctl00_phG_PXTab1_t2_grid3_lv0", "Zones_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public TX205000_SalesTaxMaint()
        {
            ScreenId = "TX205000";
            ScreenUrl = "/Pages/TX/TX205000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual TX205000_SalesTaxMaint ReadOne(Gate gate, string TaxID)
        {
            new BiObject<TX205000_SalesTaxMaint>(gate).ReadOne(this, TaxID);
            return this;
        }
        
        public virtual TX205000_SalesTaxMaint ReadOne(string TaxID)
        {
            return this.ReadOne(ApiConnection.Source, TaxID);
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
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'First\']", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Previous\']", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Next\']", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Last\']", "Go to Last Record", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_tax_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TaxID { get; }
			public Label TaxIDLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public DropDown TaxType { get; }
			public Label TaxTypeLabel { get; }
			public CheckBox DeductibleVAT { get; }
			public Label DeductibleVATLabel { get; }
			public CheckBox ReverseTax { get; }
			public Label ReverseTaxLabel { get; }
			public CheckBox PendingTax { get; }
			public Label PendingTaxLabel { get; }
			public CheckBox StatisticalTax { get; }
			public Label StatisticalTaxLabel { get; }
			public CheckBox DirectTax { get; }
			public Label DirectTaxLabel { get; }
			public CheckBox ExemptTax { get; }
			public Label ExemptTaxLabel { get; }
			public CheckBox IncludeInTaxable { get; }
			public Label IncludeInTaxableLabel { get; }
			public DropDown TaxCalcRule { get; }
			public Label TaxCalcRuleLabel { get; }
			public DropDown TaxApplyTermsDisc { get; }
			public Label TaxApplyTermsDiscLabel { get; }
			public CheckBox TaxCalcLevel2Exclude { get; }
			public Label TaxCalcLevel2ExcludeLabel { get; }
			public Selector TaxVendorID { get; }
			public Label TaxVendorIDLabel { get; }
			public DateSelector OutDate { get; }
			public Label OutDateLabel { get; }
			public Selector TaxUOM { get; }
			public Label TaxUOMLabel { get; }
            
            public c_tax_tab(string locator, string name) : 
                    base(locator, name)
            {
                TaxID = new Selector("ctl00_phF_tab_t0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                Descr = new InputLocalizable("ctl00_phF_tab_t0_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                TaxType = new DropDown("ctl00_phF_tab_t0_edTaxType", "Tax Type", locator, null);
                TaxTypeLabel = new Label(TaxType);
                TaxType.DataField = "TaxType";
                TaxType.Items.Add("S", "Sales");
                TaxType.Items.Add("P", "Use");
                TaxType.Items.Add("V", "VAT");
                TaxType.Items.Add("W", "Withholding");
                DeductibleVAT = new CheckBox("ctl00_phF_tab_t0_chkDeductible", "Partially Deductible VAT", locator, null);
                DeductibleVATLabel = new Label(DeductibleVAT);
                DeductibleVAT.DataField = "DeductibleVAT";
                ReverseTax = new CheckBox("ctl00_phF_tab_t0_chkReverseTax", "Reverse VAT", locator, null);
                ReverseTaxLabel = new Label(ReverseTax);
                ReverseTax.DataField = "ReverseTax";
                PendingTax = new CheckBox("ctl00_phF_tab_t0_chkPendingTax", "Pending VAT", locator, null);
                PendingTaxLabel = new Label(PendingTax);
                PendingTax.DataField = "PendingTax";
                StatisticalTax = new CheckBox("ctl00_phF_tab_t0_chkStatisticalTax", "Statistical VAT", locator, null);
                StatisticalTaxLabel = new Label(StatisticalTax);
                StatisticalTax.DataField = "StatisticalTax";
                DirectTax = new CheckBox("ctl00_phF_tab_t0_chkDirectTax", "Enter from Tax Bill", locator, null);
                DirectTaxLabel = new Label(DirectTax);
                DirectTax.DataField = "DirectTax";
                ExemptTax = new CheckBox("ctl00_phF_tab_t0_chkExemptTax", "Include in VAT Exempt Total", locator, null);
                ExemptTaxLabel = new Label(ExemptTax);
                ExemptTax.DataField = "ExemptTax";
                IncludeInTaxable = new CheckBox("ctl00_phF_tab_t0_edIncludeInTaxable", "Include in VAT Taxable Total", locator, null);
                IncludeInTaxableLabel = new Label(IncludeInTaxable);
                IncludeInTaxable.DataField = "IncludeInTaxable";
                TaxCalcRule = new DropDown("ctl00_phF_tab_t0_edTaxCalcRule", "Calculation Rule", locator, null);
                TaxCalcRuleLabel = new Label(TaxCalcRule);
                TaxCalcRule.DataField = "TaxCalcRule";
                TaxCalcRule.Items.Add("I0", "Inclusive Line-Level");
                TaxCalcRule.Items.Add("I1", "Exclusive Line-Level");
                TaxCalcRule.Items.Add("I2", "Compound Line-Level");
                TaxCalcRule.Items.Add("D0", "Inclusive Document-Level");
                TaxCalcRule.Items.Add("D1", "Exclusive Document-Level");
                TaxCalcRule.Items.Add("D2", "Compound Document-Level");
                TaxApplyTermsDisc = new DropDown("ctl00_phF_tab_t0_edTaxApplyTermsDisc", "Cash Discount", locator, null);
                TaxApplyTermsDiscLabel = new Label(TaxApplyTermsDisc);
                TaxApplyTermsDisc.DataField = "TaxApplyTermsDisc";
                TaxApplyTermsDisc.Items.Add("X", "Reduces Taxable Amount");
                TaxApplyTermsDisc.Items.Add("N", "Does Not Affect Taxable Amount");
                TaxCalcLevel2Exclude = new CheckBox("ctl00_phF_tab_t0_chkTaxCalcLevel2Exclude", "Exclude from Tax-on-Tax Calculation", locator, null);
                TaxCalcLevel2ExcludeLabel = new Label(TaxCalcLevel2Exclude);
                TaxCalcLevel2Exclude.DataField = "TaxCalcLevel2Exclude";
                TaxVendorID = new Selector("ctl00_phF_tab_t0_edTaxVendorID", "Tax Agency", locator, null);
                TaxVendorIDLabel = new Label(TaxVendorID);
                TaxVendorID.DataField = "TaxVendorID";
                OutDate = new DateSelector("ctl00_phF_tab_t0_OutDate", "Not Valid After", locator, null);
                OutDateLabel = new Label(OutDate);
                OutDate.DataField = "OutDate";
                TaxUOM = new Selector("ctl00_phF_tab_t0_edTaxUOM", "Tax UOM", locator, null);
                TaxUOMLabel = new Label(TaxUOM);
                TaxUOM.DataField = "TaxUOM";
                DataMemberName = "Tax";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TaxVendorIDEdit()
            {
                Buttons.TaxVendorIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxVendorIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxVendorIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edTaxVendorID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "TaxVendorIDEdit", "ctl00_phF_tab");
                    TaxVendorIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
        
        public class c_currenttax_glaccountslocation : Container
        {
            
			public DropDown PerUnitTaxPostMode { get; }
			public Label PerUnitTaxPostModeLabel { get; }
			public Selector SalesTaxAcctID { get; }
			public Label SalesTaxAcctIDLabel { get; }
			public Selector SalesTaxAcctIDOverride { get; }
			public Label SalesTaxAcctIDOverrideLabel { get; }
			public Selector SalesTaxSubID { get; }
			public Label SalesTaxSubIDLabel { get; }
			public Selector SalesTaxSubIDOverride { get; }
			public Label SalesTaxSubIDOverrideLabel { get; }
			public Selector PurchTaxAcctID { get; }
			public Label PurchTaxAcctIDLabel { get; }
			public Selector PurchTaxAcctIDOverride { get; }
			public Label PurchTaxAcctIDOverrideLabel { get; }
			public Selector PurchTaxSubID { get; }
			public Label PurchTaxSubIDLabel { get; }
			public Selector PurchTaxSubIDOverride { get; }
			public Label PurchTaxSubIDOverrideLabel { get; }
			public CheckBox ReportExpenseToSingleAccount { get; }
			public Label ReportExpenseToSingleAccountLabel { get; }
			public Selector ExpenseAccountID { get; }
			public Label ExpenseAccountIDLabel { get; }
			public Selector ExpenseSubID { get; }
			public Label ExpenseSubIDLabel { get; }
			public Selector PendingSalesTaxAcctID { get; }
			public Label PendingSalesTaxAcctIDLabel { get; }
			public Selector PendingSalesTaxSubID { get; }
			public Label PendingSalesTaxSubIDLabel { get; }
			public Selector PendingPurchTaxAcctID { get; }
			public Label PendingPurchTaxAcctIDLabel { get; }
			public Selector PendingPurchTaxSubID { get; }
			public Label PendingPurchTaxSubIDLabel { get; }
			public Selector RetainageTaxPayableAcctID { get; }
			public Label RetainageTaxPayableAcctIDLabel { get; }
			public Selector RetainageTaxPayableSubID { get; }
			public Label RetainageTaxPayableSubIDLabel { get; }
			public Selector RetainageTaxClaimableAcctID { get; }
			public Label RetainageTaxClaimableAcctIDLabel { get; }
			public Selector RetainageTaxClaimableSubID { get; }
			public Label RetainageTaxClaimableSubIDLabel { get; }
            
            public c_currenttax_glaccountslocation(string locator, string name) : 
                    base(locator, name)
            {
                PerUnitTaxPostMode = new DropDown("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPerUnitTaxPostMode", "Post To", locator, null);
                PerUnitTaxPostModeLabel = new Label(PerUnitTaxPostMode);
                PerUnitTaxPostMode.DataField = "PerUnitTaxPostMode";
                PerUnitTaxPostMode.Items.Add("L", "Line Account");
                PerUnitTaxPostMode.Items.Add("T", "Provisional Account");
                SalesTaxAcctID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edSalesTaxAcctID", "Tax Payable Account", locator, null);
                SalesTaxAcctIDLabel = new Label(SalesTaxAcctID);
                SalesTaxAcctID.DataField = "SalesTaxAcctID";
                SalesTaxAcctIDOverride = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edSalesTaxAcctIDOverride", "Account to Use on Sale", locator, null);
                SalesTaxAcctIDOverrideLabel = new Label(SalesTaxAcctIDOverride);
                SalesTaxAcctIDOverride.DataField = "SalesTaxAcctIDOverride";
                SalesTaxSubID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edSalesTaxSubID", "Tax Payable Subaccount", locator, null);
                SalesTaxSubIDLabel = new Label(SalesTaxSubID);
                SalesTaxSubID.DataField = "SalesTaxSubID";
                SalesTaxSubIDOverride = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edSalesTaxSubIDOverride", "Subaccount to Use on Sale", locator, null);
                SalesTaxSubIDOverrideLabel = new Label(SalesTaxSubIDOverride);
                SalesTaxSubIDOverride.DataField = "SalesTaxSubIDOverride";
                PurchTaxAcctID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPurchTaxAcctID", "Tax Claimable Account", locator, null);
                PurchTaxAcctIDLabel = new Label(PurchTaxAcctID);
                PurchTaxAcctID.DataField = "PurchTaxAcctID";
                PurchTaxAcctIDOverride = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPurchTaxAcctIDOverride", "Account to Use on Purchase", locator, null);
                PurchTaxAcctIDOverrideLabel = new Label(PurchTaxAcctIDOverride);
                PurchTaxAcctIDOverride.DataField = "PurchTaxAcctIDOverride";
                PurchTaxSubID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPurchTaxSubID", "Tax Claimable Subaccount", locator, null);
                PurchTaxSubIDLabel = new Label(PurchTaxSubID);
                PurchTaxSubID.DataField = "PurchTaxSubID";
                PurchTaxSubIDOverride = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPurchTaxSubIDOverride", "Subaccount to Use on Purchase", locator, null);
                PurchTaxSubIDOverrideLabel = new Label(PurchTaxSubIDOverride);
                PurchTaxSubIDOverride.DataField = "PurchTaxSubIDOverride";
                ReportExpenseToSingleAccount = new CheckBox("ctl00_phG_PXTab1_t3_GLAccountsLocation_chkExpenseReporting", "Use Tax Expense Account", locator, null);
                ReportExpenseToSingleAccountLabel = new Label(ReportExpenseToSingleAccount);
                ReportExpenseToSingleAccount.DataField = "ReportExpenseToSingleAccount";
                ExpenseAccountID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edExpenseAccountID", "Tax Expense Account", locator, null);
                ExpenseAccountIDLabel = new Label(ExpenseAccountID);
                ExpenseAccountID.DataField = "ExpenseAccountID";
                ExpenseSubID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edExpenseSubID", "Tax Expense Subaccount", locator, null);
                ExpenseSubIDLabel = new Label(ExpenseSubID);
                ExpenseSubID.DataField = "ExpenseSubID";
                PendingSalesTaxAcctID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPendingSalesTaxAcctID", "Pending Tax Payable Account", locator, null);
                PendingSalesTaxAcctIDLabel = new Label(PendingSalesTaxAcctID);
                PendingSalesTaxAcctID.DataField = "PendingSalesTaxAcctID";
                PendingSalesTaxSubID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPendingSalesTaxSubID", "Pending Tax Payable Subaccount", locator, null);
                PendingSalesTaxSubIDLabel = new Label(PendingSalesTaxSubID);
                PendingSalesTaxSubID.DataField = "PendingSalesTaxSubID";
                PendingPurchTaxAcctID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPendingPurchTaxAcctID", "Pending Tax Claimable Account", locator, null);
                PendingPurchTaxAcctIDLabel = new Label(PendingPurchTaxAcctID);
                PendingPurchTaxAcctID.DataField = "PendingPurchTaxAcctID";
                PendingPurchTaxSubID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edPendingPurchTaxSubID", "Pending Tax Claimable Subaccount", locator, null);
                PendingPurchTaxSubIDLabel = new Label(PendingPurchTaxSubID);
                PendingPurchTaxSubID.DataField = "PendingPurchTaxSubID";
                RetainageTaxPayableAcctID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edRetainageTaxPayableAcctID", "Retainage Tax Payable Account", locator, null);
                RetainageTaxPayableAcctIDLabel = new Label(RetainageTaxPayableAcctID);
                RetainageTaxPayableAcctID.DataField = "RetainageTaxPayableAcctID";
                RetainageTaxPayableSubID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edRetainageTaxPayableSubID", "Retainage Tax Payable Subaccount", locator, null);
                RetainageTaxPayableSubIDLabel = new Label(RetainageTaxPayableSubID);
                RetainageTaxPayableSubID.DataField = "RetainageTaxPayableSubID";
                RetainageTaxClaimableAcctID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edRetainageTaxClaimableAcctID", "Retainage Tax Claimable Account", locator, null);
                RetainageTaxClaimableAcctIDLabel = new Label(RetainageTaxClaimableAcctID);
                RetainageTaxClaimableAcctID.DataField = "RetainageTaxClaimableAcctID";
                RetainageTaxClaimableSubID = new Selector("ctl00_phG_PXTab1_t3_GLAccountsLocation_edRetainageTaxClaimableSubID", "Retainage Tax Claimable Subaccount", locator, null);
                RetainageTaxClaimableSubIDLabel = new Label(RetainageTaxClaimableSubID);
                RetainageTaxClaimableSubID.DataField = "RetainageTaxClaimableSubID";
                DataMemberName = "CurrentTax";
            }
        }
        
        public class c_taxforprintingparameterstab_edprintingparameters : Container
        {
            
			public PXTextEdit ShortPrintingLabel { get; }
			public Label ShortPrintingLabelLabel { get; }
			public InputLocalizable LongPrintingLabel { get; }
			public Label LongPrintingLabelLabel { get; }
			public PXTextEdit PrintingSequence { get; }
			public Label PrintingSequenceLabel { get; }
            
            public c_taxforprintingparameterstab_edprintingparameters(string locator, string name) : 
                    base(locator, name)
            {
                ShortPrintingLabel = new PXTextEdit("ctl00_phG_PXTab1_t4_edPrintingParameters_edShortPrintingLabel", "Short Printing Label", locator, null);
                ShortPrintingLabelLabel = new Label(ShortPrintingLabel);
                ShortPrintingLabel.DataField = "ShortPrintingLabel";
                LongPrintingLabel = new InputLocalizable("ctl00_phG_PXTab1_t4_edPrintingParameters_edLongPrintingLabel", "Long Printing Label", locator, null);
                LongPrintingLabelLabel = new Label(LongPrintingLabel);
                LongPrintingLabel.DataField = "LongPrintingLabel";
                PrintingSequence = new PXTextEdit("ctl00_phG_PXTab1_t4_edPrintingParameters_edPrintingSequence", "Printing Sequence", locator, null);
                PrintingSequenceLabel = new Label(PrintingSequence);
                PrintingSequence.DataField = "PrintingSequence";
                DataMemberName = "TaxForPrintingParametersTab";
            }
        }
        
        public class c_taxrevisions_grid1 : Grid<c_taxrevisions_grid1.c_grid_row, c_taxrevisions_grid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_taxrevisions_grid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXTab1_t0_grid1");
                DataMemberName = "TaxRevisions";
                FilterForm = new c_grid_filter("ctl00_phG_PXTab1_t0_grid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t0_grid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DateSelector StartDate { get; }
			public PXNumberEdit TaxRate { get; }
			public PXNumberEdit NonDeductibleTaxRate { get; }
			public PXNumberEdit TaxableMin { get; }
			public PXNumberEdit TaxableMax { get; }
			public PXNumberEdit TaxableMaxQty { get; }
			public DropDown TaxBucketID { get; }
			public DropDown TaxType { get; }
			public PXTextEdit TaxID { get; }
			public PXNumberEdit RevisionID { get; }
                
                public c_grid_row(c_taxrevisions_grid1 grid) : 
                        base(grid)
                {
                    StartDate = new DateSelector("_ctl00_phG_PXTab1_t0_grid1_lv0_edStartDate", "Start Date", grid.Locator, "StartDate");
                    StartDate.DataField = "StartDate";
                    TaxRate = new PXNumberEdit("_ctl00_phG_PXTab1_t0_grid1_lv0_edTaxRate", "Tax Rate", grid.Locator, "TaxRate");
                    TaxRate.DataField = "TaxRate";
                    NonDeductibleTaxRate = new PXNumberEdit("_ctl00_phG_PXTab1_t0_grid1_lv0_edNonDeductibleTaxRate", "Deductible Tax Rate", grid.Locator, "NonDeductibleTaxRate");
                    NonDeductibleTaxRate.DataField = "NonDeductibleTaxRate";
                    TaxableMin = new PXNumberEdit("_ctl00_phG_PXTab1_t0_grid1_lv0_edTaxableMin", "Min. Taxable Amount", grid.Locator, "TaxableMin");
                    TaxableMin.DataField = "TaxableMin";
                    TaxableMax = new PXNumberEdit("_ctl00_phG_PXTab1_t0_grid1_lv0_edTaxableMax", "Max. Taxable Amount", grid.Locator, "TaxableMax");
                    TaxableMax.DataField = "TaxableMax";
                    TaxableMaxQty = new PXNumberEdit("_ctl00_phG_PXTab1_t0_grid1_lv0_edTaxableMaxQty", "Max. Taxable Quantity", grid.Locator, "TaxableMaxQty");
                    TaxableMaxQty.DataField = "TaxableMaxQty";
                    TaxBucketID = new DropDown("_ctl00_phG_PXTab1_t0_grid1_lv0_edTaxBucketID", "Reporting Group", grid.Locator, "TaxBucketID");
                    TaxBucketID.DataField = "TaxBucketID";
                    TaxBucketID.Items.Add("-2", "Default Output Group");
                    TaxBucketID.Items.Add("-1", "Default Input Group");
                    TaxType = new DropDown("_ctl00_phG_PXTab1_t0_grid1_lv0_ec", "Group Type", grid.Locator, "TaxType");
                    TaxType.DataField = "TaxType";
                    TaxType.Items.Add("S", "Output");
                    TaxType.Items.Add("P", "Input");
                    TaxID = new PXTextEdit("ctl00_phG_PXTab1_t0_grid1_ei", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    RevisionID = new PXNumberEdit("ctl00_phG_PXTab1_t0_grid1_en", "RevisionID", grid.Locator, "RevisionID");
                    RevisionID.DataField = "RevisionID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DateSelectorColumnFilter StartDate { get; }
				public PXNumberEditColumnFilter TaxRate { get; }
				public PXNumberEditColumnFilter NonDeductibleTaxRate { get; }
				public PXNumberEditColumnFilter TaxableMin { get; }
				public PXNumberEditColumnFilter TaxableMax { get; }
				public PXNumberEditColumnFilter TaxableMaxQty { get; }
				public DropDownColumnFilter TaxBucketID { get; }
				public DropDownColumnFilter TaxType { get; }
				public PXTextEditColumnFilter TaxID { get; }
				public PXNumberEditColumnFilter RevisionID { get; }
                
                public c_grid_header(c_taxrevisions_grid1 grid) : 
                        base(grid)
                {
                    StartDate = new DateSelectorColumnFilter(grid.Row.StartDate);
                    TaxRate = new PXNumberEditColumnFilter(grid.Row.TaxRate);
                    NonDeductibleTaxRate = new PXNumberEditColumnFilter(grid.Row.NonDeductibleTaxRate);
                    TaxableMin = new PXNumberEditColumnFilter(grid.Row.TaxableMin);
                    TaxableMax = new PXNumberEditColumnFilter(grid.Row.TaxableMax);
                    TaxableMaxQty = new PXNumberEditColumnFilter(grid.Row.TaxableMaxQty);
                    TaxBucketID = new DropDownColumnFilter(grid.Row.TaxBucketID);
                    TaxType = new DropDownColumnFilter(grid.Row.TaxType);
                    TaxID = new PXTextEditColumnFilter(grid.Row.TaxID);
                    RevisionID = new PXNumberEditColumnFilter(grid.Row.RevisionID);
                }
            }
        }
        
        public class c_taxrevisions_lv0 : Container
        {
            
			public DateSelector StartDate { get; }
			public Label StartDateLabel { get; }
			public DropDown TaxBucketID { get; }
			public Label TaxBucketIDLabel { get; }
			public PXNumberEdit TaxRate { get; }
			public Label TaxRateLabel { get; }
			public PXNumberEdit NonDeductibleTaxRate { get; }
			public Label NonDeductibleTaxRateLabel { get; }
			public PXNumberEdit TaxableMin { get; }
			public Label TaxableMinLabel { get; }
			public PXNumberEdit TaxableMax { get; }
			public Label TaxableMaxLabel { get; }
			public PXNumberEdit TaxableMaxQty { get; }
			public Label TaxableMaxQtyLabel { get; }
			public CheckBox Outdated { get; }
			public Label OutdatedLabel { get; }
			public DropDown Ec { get; }
            
            public c_taxrevisions_lv0(string locator, string name) : 
                    base(locator, name)
            {
                StartDate = new DateSelector("ctl00_phG_PXTab1_t0_grid1_lv0_edStartDate", "Start Date", locator, null);
                StartDateLabel = new Label(StartDate);
                StartDate.DataField = "StartDate";
                TaxBucketID = new DropDown("ctl00_phG_PXTab1_t0_grid1_lv0_edTaxBucketID", "Reporting Group", locator, null);
                TaxBucketIDLabel = new Label(TaxBucketID);
                TaxBucketID.DataField = "TaxBucketID";
                TaxBucketID.Items.Add("-2", "Default Output Group");
                TaxBucketID.Items.Add("-1", "Default Input Group");
                TaxRate = new PXNumberEdit("ctl00_phG_PXTab1_t0_grid1_lv0_edTaxRate", "Tax Rate", locator, null);
                TaxRateLabel = new Label(TaxRate);
                TaxRate.DataField = "TaxRate";
                NonDeductibleTaxRate = new PXNumberEdit("ctl00_phG_PXTab1_t0_grid1_lv0_edNonDeductibleTaxRate", "Deductible Tax Rate", locator, null);
                NonDeductibleTaxRateLabel = new Label(NonDeductibleTaxRate);
                NonDeductibleTaxRate.DataField = "NonDeductibleTaxRate";
                TaxableMin = new PXNumberEdit("ctl00_phG_PXTab1_t0_grid1_lv0_edTaxableMin", "Min. Taxable Amount", locator, null);
                TaxableMinLabel = new Label(TaxableMin);
                TaxableMin.DataField = "TaxableMin";
                TaxableMax = new PXNumberEdit("ctl00_phG_PXTab1_t0_grid1_lv0_edTaxableMax", "Max. Taxable Amount", locator, null);
                TaxableMaxLabel = new Label(TaxableMax);
                TaxableMax.DataField = "TaxableMax";
                TaxableMaxQty = new PXNumberEdit("ctl00_phG_PXTab1_t0_grid1_lv0_edTaxableMaxQty", "Max. Taxable Quantity", locator, null);
                TaxableMaxQtyLabel = new Label(TaxableMaxQty);
                TaxableMaxQty.DataField = "TaxableMaxQty";
                Outdated = new CheckBox("ctl00_phG_PXTab1_t0_grid1_lv0_chkOutdated", "Not Valid", locator, null);
                OutdatedLabel = new Label(Outdated);
                Outdated.DataField = "Outdated";
                Ec = new DropDown("ctl00_phG_PXTab1_t0_grid1_lv0_ec", "Ec", locator, null);
                DataMemberName = "TaxRevisions";
            }
        }
        
        public class c_categories_grid2 : Grid<c_categories_grid2.c_grid_row, c_categories_grid2.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_categories_grid2(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXTab1_t1_grid2");
                DataMemberName = "Categories";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PXTab1_t1_grid2_fe_gf", "FilterForm");
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
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t1_grid2_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_PXTab1_t1_grid2_lv0_edTaxCategoryID\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_PXTab1_t1_grid2");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxCategoryID { get; }
			public CheckBox TaxCategory__TaxCatFlag { get; }
			public PXTextEdit TaxCategory__Descr { get; }
			public Selector TaxID { get; }
                
                public c_grid_row(c_categories_grid2 grid) : 
                        base(grid)
                {
                    TaxCategoryID = new Selector("_ctl00_phG_PXTab1_t1_grid2_lv0_edTaxCategoryID", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    TaxCategory__TaxCatFlag = new CheckBox("_ctl00_phG_PXTab1_t1_grid2_lv0_chkTaxCategory__TaxCatFlag", "Exclude Listed Taxes", grid.Locator, "TaxCategory__TaxCatFlag");
                    TaxCategory__TaxCatFlag.DataField = "TaxCategory__TaxCatFlag";
                    TaxCategory__Descr = new PXTextEdit("_ctl00_phG_PXTab1_t1_grid2_lv0_edTaxCategory__Descr", "Description", grid.Locator, "TaxCategory__Descr");
                    TaxCategory__Descr.DataField = "TaxCategory__Descr";
                    TaxID = new Selector("_ctl00_phG_PXTab1_t1_grid2_lv0_es", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxCategoryID { get; }
				public CheckBoxColumnFilter TaxCategory__TaxCatFlag { get; }
				public PXTextEditColumnFilter TaxCategory__Descr { get; }
				public SelectorColumnFilter TaxID { get; }
                
                public c_grid_header(c_categories_grid2 grid) : 
                        base(grid)
                {
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    TaxCategory__TaxCatFlag = new CheckBoxColumnFilter(grid.Row.TaxCategory__TaxCatFlag);
                    TaxCategory__Descr = new PXTextEditColumnFilter(grid.Row.TaxCategory__Descr);
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                }
            }
        }
        
        public class c_categories_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox TaxCategory__TaxCatFlag { get; }
			public Label TaxCategory__TaxCatFlagLabel { get; }
			public PXTextEdit TaxCategory__Descr { get; }
			public Label TaxCategory__DescrLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_categories_lv0(string locator, string name) : 
                    base(locator, name)
            {
                TaxCategory__TaxCatFlag = new CheckBox("ctl00_phG_PXTab1_t1_grid2_lv0_chkTaxCategory__TaxCatFlag", "Exclude Listed Taxes", locator, null);
                TaxCategory__TaxCatFlagLabel = new Label(TaxCategory__TaxCatFlag);
                TaxCategory__TaxCatFlag.DataField = "TaxCategory__TaxCatFlag";
                TaxCategory__Descr = new PXTextEdit("ctl00_phG_PXTab1_t1_grid2_lv0_edTaxCategory__Descr", "Description", locator, null);
                TaxCategory__DescrLabel = new Label(TaxCategory__Descr);
                TaxCategory__Descr.DataField = "TaxCategory__Descr";
                TaxCategoryID = new Selector("ctl00_phG_PXTab1_t1_grid2_lv0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                Es = new Selector("ctl00_phG_PXTab1_t1_grid2_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Categories";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_PXTab1_t1_grid2_lv0_edTaxCategoryID\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_PXTab1_t1_grid2_lv0");
                    TaxCategoryIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_zones_grid3 : Grid<c_zones_grid3.c_grid_row, c_zones_grid3.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_zones_grid3(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXTab1_t2_grid3");
                DataMemberName = "Zones";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PXTab1_t2_grid3_fe_gf", "FilterForm");
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
            
            public virtual void TaxZoneIDEdit()
            {
                Buttons.TaxZoneIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXTab1_t2_grid3_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxZoneIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "TaxZoneIDEdit", "ctl00_phG_PXTab1_t2_grid3");
                    TaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxZoneID { get; }
			public Selector TaxZone__DfltTaxCategoryID { get; }
			public PXTextEdit TaxZone__Descr { get; }
			public Selector TaxID { get; }
                
                public c_grid_row(c_zones_grid3 grid) : 
                        base(grid)
                {
                    TaxZoneID = new Selector("_ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZoneID", "Tax Zone ID", grid.Locator, "TaxZoneID");
                    TaxZoneID.DataField = "TaxZoneID";
                    TaxZone__DfltTaxCategoryID = new Selector("_ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZone__DfltTaxCategoryID", "Default Tax Category", grid.Locator, "TaxZone__DfltTaxCategoryID");
                    TaxZone__DfltTaxCategoryID.DataField = "TaxZone__DfltTaxCategoryID";
                    TaxZone__Descr = new PXTextEdit("_ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZone__Descr", "Description", grid.Locator, "TaxZone__Descr");
                    TaxZone__Descr.DataField = "TaxZone__Descr";
                    TaxID = new Selector("_ctl00_phG_PXTab1_t2_grid3_lv0_es", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxZoneID { get; }
				public SelectorColumnFilter TaxZone__DfltTaxCategoryID { get; }
				public PXTextEditColumnFilter TaxZone__Descr { get; }
				public SelectorColumnFilter TaxID { get; }
                
                public c_grid_header(c_zones_grid3 grid) : 
                        base(grid)
                {
                    TaxZoneID = new SelectorColumnFilter(grid.Row.TaxZoneID);
                    TaxZone__DfltTaxCategoryID = new SelectorColumnFilter(grid.Row.TaxZone__DfltTaxCategoryID);
                    TaxZone__Descr = new PXTextEditColumnFilter(grid.Row.TaxZone__Descr);
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                }
            }
        }
        
        public class c_zones_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TaxZone__DfltTaxCategoryID { get; }
			public Label TaxZone__DfltTaxCategoryIDLabel { get; }
			public PXTextEdit TaxZone__Descr { get; }
			public Label TaxZone__DescrLabel { get; }
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_zones_lv0(string locator, string name) : 
                    base(locator, name)
            {
                TaxZone__DfltTaxCategoryID = new Selector("ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZone__DfltTaxCategoryID", "Default Tax Category", locator, null);
                TaxZone__DfltTaxCategoryIDLabel = new Label(TaxZone__DfltTaxCategoryID);
                TaxZone__DfltTaxCategoryID.DataField = "TaxZone__DfltTaxCategoryID";
                TaxZone__Descr = new PXTextEdit("ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZone__Descr", "Description", locator, null);
                TaxZone__DescrLabel = new Label(TaxZone__Descr);
                TaxZone__Descr.DataField = "TaxZone__Descr";
                TaxZoneID = new Selector("ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZoneID", "Tax Zone ID", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                Es = new Selector("ctl00_phG_PXTab1_t2_grid3_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Zones";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TaxZoneIDEdit()
            {
                Buttons.TaxZoneIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxZoneIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_PXTab1_t2_grid3_lv0_edTaxZoneID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "TaxZoneIDEdit", "ctl00_phG_PXTab1_t2_grid3_lv0");
                    TaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
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
