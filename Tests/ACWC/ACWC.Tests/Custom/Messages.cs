namespace ACSC.Tests.Custom
{
    public static class Messages
    {
        public const string OrderWasntCreatedException = "Order wasn't created";
        public static string ValidateSyncStatusFor(string entity, string inventoryCD) => $"Validate SyncStatus for {entity} ({inventoryCD})";
        public static string ValidateEntity(string entity, string orderNbr) => $"Validate {entity} ({orderNbr})";
        public static string ValidatePriceList(string item, string currency) => $"Bulk pricing for the '{item}' with '{currency}' currency is valid";
        public const string RefundWasntCreatedException = "Refund wasn't created";
    }
}
