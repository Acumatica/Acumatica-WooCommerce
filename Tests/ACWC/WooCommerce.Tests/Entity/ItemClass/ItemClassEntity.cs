using System.Collections.Generic;

namespace ACSC.Tests.Entity.ItemClass
{
    public class ItemClassEntity
    {
        public ItemClassEntity()
        {
            GeneralSettings = new ItemClassEntityGeneralSettings();
            Attributes = new List<ItemClassEntityAttributes>();
        }

        public string ClassID { get; set; }
        public string Description { get; set; }
        public ItemClassEntityGeneralSettings GeneralSettings { get; set; }
        public List<ItemClassEntityAttributes> Attributes { get; set; }
    }
}