using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRechnungPositionTeilmengen
{
    public int KRechnungPosition { get; set; }

    public decimal FLagerFactor { get; set; }

    public int KDefinition { get; set; }

    public decimal FPreisFactor { get; set; }

    public virtual TRechnungPosition KRechnungPositionNavigation { get; set; } = null!;
}
