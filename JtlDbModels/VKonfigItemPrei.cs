using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKonfigItemPrei
{
    public int KKonfigitem { get; set; }

    public int KKundengruppe { get; set; }

    public int? KSteuerklasse { get; set; }

    public decimal FPreis { get; set; }

    public byte? NTyp { get; set; }

    public int KShop { get; set; }
}
