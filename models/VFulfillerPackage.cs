using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VFulfillerPackage
{
    public int KVersand { get; set; }

    public int KLieferschein { get; set; }

    public DateTime? DShippingDate { get; set; }

    public int? KVersandArt { get; set; }

    public string? CTrackingId { get; set; }

    public string? CShipmentId { get; set; }

    public string? CShipmentOrderId { get; set; }

    public string? CEnclosedReturnIdentCode { get; set; }

    public string? CNote { get; set; }

    public DateTime? DEstimatedDeliveryTime { get; set; }

    public decimal FWeight { get; set; }
}
