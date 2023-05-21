using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKonfigGruppeSprache
{
    public int KKonfiggruppe { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public int KShop { get; set; }
}
