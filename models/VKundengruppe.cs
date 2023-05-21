using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VKundengruppe
{
    public int KKundengruppe { get; set; }

    public string? CName { get; set; }

    public decimal FRabatt { get; set; }

    public byte? NStandard { get; set; }

    public byte? NShopLogin { get; set; }

    public byte? NNettoPreise { get; set; }

    public int KShop { get; set; }
}
