using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonMappingVariationswerte
{
    public int KMappingVariationswerte { get; set; }

    public string CValue { get; set; } = null!;

    public string CAmazonValue { get; set; } = null!;

    public int? KGroup { get; set; }
}
