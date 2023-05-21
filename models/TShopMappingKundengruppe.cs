using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TShopMappingKundengruppe
{
    public int KKundengruppe { get; set; }

    public int KShop { get; set; }

    public string? CPkshop { get; set; }

    public string? CNameShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
