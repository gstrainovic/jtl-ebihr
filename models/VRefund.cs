using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VRefund
{
    public int KOrderItemId { get; set; }

    public string CChannel { get; set; } = null!;

    public int KRefund { get; set; }

    public string CSellerId { get; set; } = null!;

    public string? COrderId { get; set; }

    public string COrderItemId { get; set; } = null!;

    public decimal NQuantity { get; set; }

    public string CReason { get; set; } = null!;

    public decimal FRefund { get; set; }

    public string? CRefundCurrency { get; set; }

    public bool NRefundUpload { get; set; }
}
