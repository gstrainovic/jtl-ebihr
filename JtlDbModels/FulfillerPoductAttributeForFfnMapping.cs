using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class FulfillerPoductAttributeForFfnMapping
{
    public int KAttribut { get; set; }

    public string CName { get; set; } = null!;

    public string? CGruppe { get; set; }

    public string Ffntyp { get; set; } = null!;
}
