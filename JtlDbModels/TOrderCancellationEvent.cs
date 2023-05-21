using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOrderCancellationEvent
{
    public int KOrderCancellationEvent { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public string COrderCancellationRequestId { get; set; } = null!;

    public string? CReason { get; set; }

    public byte NType { get; set; }

    public byte NCount { get; set; }
}
