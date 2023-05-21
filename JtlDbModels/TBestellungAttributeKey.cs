using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBestellungAttributeKey
{
    public int KBestellungAttributeKey { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
