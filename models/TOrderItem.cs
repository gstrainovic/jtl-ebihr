using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOrderItem
{
    public int KOrderItem { get; set; }

    public int KOrder { get; set; }

    public string COrderItemId { get; set; } = null!;

    public string CType { get; set; } = null!;

    public long? KOffer { get; set; }

    public DateTime? DEstimatedShippingDate { get; set; }

    public DateTime? DEstimatedDeliveryDate { get; set; }

    public string? CShippingGroup { get; set; }

    public int? KAuftragPosition { get; set; }

    public decimal FRemainingQuantity { get; set; }

    public string? CChannelOfferId { get; set; }

    public string? CItemStatus { get; set; }

    public bool NRefundUpload { get; set; }

    public byte NItemPaymentStatus { get; set; }

    public virtual TAuftragPosition? KAuftragPositionNavigation { get; set; }

    public virtual TOrder KOrderNavigation { get; set; } = null!;
}
