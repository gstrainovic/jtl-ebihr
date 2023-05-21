using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAbgleichEventQueue
{
    public int KAbgleichEventQueue { get; set; }

    public byte NType { get; set; }

    public string? CMarketplaceId { get; set; }
}
