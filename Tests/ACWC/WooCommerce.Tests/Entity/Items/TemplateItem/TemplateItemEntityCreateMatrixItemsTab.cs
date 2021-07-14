using System.Collections.Generic;

namespace ACSC.Tests.Entity.Items.TemplateItem
{
    public class TemplateItemEntityCreateMatrixItemsTab
    {
        public TemplateItemEntityCreateMatrixItemsTab()
        {
            AdditionalAttributes = new List<AdditionalAttributes>();
            Matrices = new Matrix();
        }

        public string ColAttributeID { get; set; }
        public string RowAttributeID { get; set; }

        public List<AdditionalAttributes> AdditionalAttributes { get; set; }
        public Matrix Matrices { get; set; }
    }

    public class AdditionalAttributes
    {
        public string ColumnName { get; set; }
        public string AttributeValue { get; set; }
    }

    public class Matrix
    {
        public string AttributeValue { get; set; }
        public bool SelectRow { get; set; }
    }
}