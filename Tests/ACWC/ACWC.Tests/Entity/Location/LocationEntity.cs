namespace ACSC.Tests.Entity.Location
{
    public class LocationEntity
    {
        public LocationEntity()
        {
            LocationContact = new LocationEntityContact();
            LocationAddress = new LocationEntityAddress();
            LocationSettings = new LocationEntitySettings();
        }

        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string LocationCD { get; set; }
        public string Descr { get; set; }

        public LocationEntityContact LocationContact { get; set; }
        public LocationEntityAddress LocationAddress { get; set; }
        public LocationEntitySettings LocationSettings { get; set; }
    }
}