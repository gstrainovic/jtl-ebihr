using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragPositionTeilmengen
{
    public int KAuftragPosition { get; set; }

    public decimal FLagerFactor { get; set; }

    public int KDefinition { get; set; }

    public decimal FPreisFactor { get; set; }

    public virtual TAuftragPosition KAuftragPositionNavigation { get; set; } = null!;
}
