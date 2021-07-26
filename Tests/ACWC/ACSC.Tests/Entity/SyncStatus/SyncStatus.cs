using System;
using System.Collections.Generic;
using System.Linq;

namespace ACSC.Tests.Entity.SyncStatus
{
    public class SyncStatus 
    {
        public SyncStatus()
        {
            DetailsViewFiler = new SyncStatusDetails();
            DetailsView = new List<SyncStatusDetails>();
        }

        public string Connector { get; set; }
        public string Store { get; set; }
        public string Entity { get; set; }
        public string View { get; set; }
        public string Status { get; set; }
        public SyncStatusDetails DetailsViewFiler { get; set; }
        public List<SyncStatusDetails> DetailsView { get; set; }
        public List<string> ExternalIds => DetailsView.Select(r => r.ExternalID).ToList();

        public string GetLocationIDByLocationName(string locationName)
        {
            return DetailsView.FirstOrDefault(r => r.LocalID.Contains(locationName))?.LocalID;
        }
    }

    public class SyncStatusDetails : ICloneable
    {
        public bool? Selected { get; set; }
        public string Connector { get; set; }
        public string Store { get; set; }
        public string Entity { get; set; }
        public string Status { get; set; }
        public bool? PendingSync { get; set; }
        public string LocalID { get; set; }
        public DateTime? LocallyModified { get; set; }
        public string ExternalID { get; set; }
        public DateTime? ExternallyModified { get; set; }
        public string ExternalHash { get; set; }
        public string LastOperation { get; set; }
        public string Error { get; set; }
        //public string LastAttempt { get; set; }
        public DateTime? LastAttempt { get; set; }
        public string AttemptCount { get; set; }
        

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}