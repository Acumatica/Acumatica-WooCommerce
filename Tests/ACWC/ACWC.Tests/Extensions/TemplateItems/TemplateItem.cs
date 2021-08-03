using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.TemplateItem;
using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.TemplateItems
{
    public class TemplateItem : IN203000_TemplateInventoryItemMaint
    {
        public c_item_form Summary => Item_form;
        public c_itemsettings_tab ItemSettings => ItemSettings_tab;
        public c_vendoritems_pxgridvendoritems VendorDetails => VendorItems_PXGridVendorItems;
        public c_answers_pxgridanswers Attributes => Answers_PXGridAnswers;

        public c_idgenerationrules_pxgrididgenerationrules InventorySegmentSettings =>
            IdGenerationRules_PXGridIdGenerationRules;

        public c_descriptiongenerationrules_pxgriddescriptiongenerationrules DescriptionSegmentSettings =>
            DescriptionGenerationRules_PXGridDescriptionGenerationRules;

        public c_additionalattributes_matrixattributes CreateMatrixTab_AdditionalAttr =>
            AdditionalAttributes_MatrixAttributes;

        public c_matrix_matrixmatrix Matrix => Matrix_MatrixMatrix;
        public c_matrixitemsforcreation_grdcreate MatrixItemsForCreation => MatrixItemsForCreation_grdCreate;
        public c_matrixitems_grdmatrixitems MatrixItems => MatrixItems_grdMatrixItems;

        public TemplateItemEntity Get()
        {
            var visitor = VisitorsManager.GetSingle<ITemplateItemVisitor>(typeof(TemplateItemVisitor));
            return visitor.Get(this);
        }

        internal void Full(ITemplateItemVisitor visitor)
        {
            visitor.Full(this);
        }

    }
}