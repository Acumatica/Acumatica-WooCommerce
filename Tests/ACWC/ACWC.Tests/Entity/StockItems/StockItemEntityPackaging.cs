namespace ACSC.Tests.Entity.StockItems
{
    public class StockItemEntityPackaging
    {
        public decimal Weight { get; set; }
        public string WeightUOM { get; set; }
        public decimal Volume  { get; set; }
        public string VolumeUOM { get; set; }
        public string PackagingOption { get; set; }
        public bool PackSeparately { get; set; }
        public string BoxID { get; set; }
    }
}
