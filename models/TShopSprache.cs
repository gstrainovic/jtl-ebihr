using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TShopSprache
{
    public int KWebShop { get; set; }

    public int KSprache { get; set; }

    public byte? NStandard { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
