using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class ReturnReason
{
    public int ReturnReasonId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
