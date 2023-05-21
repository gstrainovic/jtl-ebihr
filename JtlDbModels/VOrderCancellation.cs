using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderCancellation
{
    public int KOrder { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public string? CExternalOrderId { get; set; }

    public string CCancelReason { get; set; } = null!;
}
