using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKundengruppeSprache
{
    public int KKundengruppe { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }
}
