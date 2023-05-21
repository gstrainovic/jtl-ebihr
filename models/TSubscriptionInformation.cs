using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSubscriptionInformation
{
    public int NShippingProduct { get; set; }

    public byte NValid { get; set; }

    public string CSubscription { get; set; } = null!;

    public DateTime DNextUpdate { get; set; }
}
