using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Platform1
{
    public int InternalId { get; set; }

    public string? Name { get; set; }

    public int? Fallback { get; set; }

    public int ShopId { get; set; }

    public int Sort { get; set; }
}
