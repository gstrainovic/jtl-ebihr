using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFailedEvent
{
    public int KFailedEvent { get; set; }

    public string CEventId { get; set; } = null!;

    public string CJson { get; set; } = null!;

    public byte NApiType { get; set; }

    public byte NCount { get; set; }
}
