using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMissedAcknowledge
{
    public int KMissedAcknowledge { get; set; }

    public string CEventId { get; set; } = null!;

    public byte NCount { get; set; }
}
