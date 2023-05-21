using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayLeecherVariationMapping
{
    public int KEbayLeecherVariationMapping { get; set; }

    public string CIso1 { get; set; } = null!;

    public string CValue1 { get; set; } = null!;

    public string CIso2 { get; set; } = null!;

    public string CValue2 { get; set; } = null!;
}
