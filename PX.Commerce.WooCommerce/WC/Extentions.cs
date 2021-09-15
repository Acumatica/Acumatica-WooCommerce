using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using System;
using System.Linq;

namespace PX.Commerce.WooCommerce.WC
{
    public static class Extentions
    {
        public static decimal Abs(this decimal val)
        {
            return Math.Abs(val);
        }

        public static decimal? Abs(this decimal? val)
        {
            return val.HasValue ? Math.Abs(val.Value) : 0;
        }

        public static int Abs(this int val)
        {
            return Math.Abs(val);
        }

        public static int? Abs(this int? val)
        {
            return val.HasValue ? Math.Abs(val.Value) : 0;
        }

        public static bool IsAuthNetTrans(this OrdersTransactionData tran)
        {
            return tran.Metadata.Any(a => string.Equals(a.Key, "_wc_authorize_net_cim_credit_card_trans_id", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
