using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tkonfigshop
{
    public int Kkonfiggruppe { get; set; }

    public int KShop { get; set; }

    public string? CInet { get; set; }

    public string? CDelInet { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TShop KShopNavigation { get; set; } = null!;
}
