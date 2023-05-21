using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonDotLiquidMapping
{
    public int KDotLiquidMapping { get; set; }

    public int KGroup { get; set; }

    public string CKey { get; set; } = null!;

    public string CValue { get; set; } = null!;
}
