using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKonfigItemSprache
{
    public int KKonfigitem { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public int KShop { get; set; }
}
