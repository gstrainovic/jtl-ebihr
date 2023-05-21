using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VKonfigItemPrei
{
    public int KKonfigitem { get; set; }

    public int KKundengruppe { get; set; }

    public int? KSteuerklasse { get; set; }

    public decimal FPreis { get; set; }

    public byte? NTyp { get; set; }

    public int KShop { get; set; }
}
