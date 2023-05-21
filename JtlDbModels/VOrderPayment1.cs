using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderPayment1
{
    public int KOrder { get; set; }

    public string CSellerId { get; set; } = null!;

    public string? COrderIdExternal { get; set; }

    public bool? NPaymentComplete { get; set; }

    public DateTime? DPaymentDate { get; set; }

    public string CChannelId { get; set; } = null!;
}
