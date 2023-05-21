using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVariationMapping
{
    public int KVariationMapping { get; set; }

    public int KChannel { get; set; }

    public int? KCategory { get; set; }

    public string CWawiVariationName { get; set; } = null!;

    public string CScxVariationName { get; set; } = null!;
}
