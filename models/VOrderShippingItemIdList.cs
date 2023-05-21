using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOrderShippingItemIdList
{
    public int KOrderItem { get; set; }

    public int KAuftragPosition { get; set; }

    public string COrderItemIdExternal { get; set; } = null!;

    public decimal FQuantity { get; set; }

    public int KOrder { get; set; }

    public int? KDeliveryNote { get; set; }
}
