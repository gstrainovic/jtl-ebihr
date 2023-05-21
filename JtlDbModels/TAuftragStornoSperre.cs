using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragStornoSperre
{
    public int KAuftragStornoSperre { get; set; }

    public int KAuftrag { get; set; }

    public Guid BGrund { get; set; }

    public string? CReferenz { get; set; }
}
