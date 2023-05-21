using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEazyShippingVerpackQueue
{
    public int? KBestellung { get; set; }

    public DateTime? DTimeStamp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
