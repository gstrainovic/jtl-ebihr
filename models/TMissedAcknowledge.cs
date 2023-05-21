using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMissedAcknowledge
{
    public int KMissedAcknowledge { get; set; }

    public string CEventId { get; set; } = null!;

    public byte NCount { get; set; }
}
