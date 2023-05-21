using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ReturnReason
{
    public int ReturnReasonId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
