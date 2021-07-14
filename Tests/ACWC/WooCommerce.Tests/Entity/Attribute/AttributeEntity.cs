using System.Collections.Generic;

namespace ACSC.Tests.Entity.Attribute
{
    public class AttributeEntity
    {
        public AttributeEntity()
        {
            Details = new List<AttributeEntityDetails>();
        }
        public string AttributeID { get; set; }
        public string Description { get; set; }
        public string ControlType { get; set; }
        public List<AttributeEntityDetails> Details { get; set; }
    }
}