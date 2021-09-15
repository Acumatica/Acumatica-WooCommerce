using PX.Commerce.Objects;
using PX.Data;
using PX.Data.BQL;

namespace PX.Commerce.WooCommerce.WC.DACExtensions
{
    public sealed class BCBindingExtExt : PXCacheExtension<BCBindingExt>
    {
        public static bool IsActive()
        {
            return true;
        }

        #region MaxRefundDays
        public abstract class maxRefundDays : BqlInt.Field<maxRefundDays> { }
        [PXDBInt]
        [PXUIField(DisplayName = "Maximum Refund Days")]
        [PXDefault(90, PersistingCheck = PXPersistingCheck.Nothing)]
        public int? MaxRefundDays { get; set; }
        #endregion

    }
}
