using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShopMappingKundengruppe
{
    public int KKundengruppe { get; set; }

    public int KShop { get; set; }

    public string? CPkshop { get; set; }

    public string? CNameShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
