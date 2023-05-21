using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VWarehouseMerchant
{
    public int Pk { get; set; }

    public int WarehouseKey { get; set; }

    public string? MerchantId { get; set; }

    public int MerchantKey { get; set; }
}
