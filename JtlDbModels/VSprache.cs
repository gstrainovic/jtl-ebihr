using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VSprache
{
    public int KSprache { get; set; }

    public string? CNameEnglisch { get; set; }

    public string? CNameDeutsch { get; set; }

    public string? CIso { get; set; }

    public byte? NStandard { get; set; }

    public byte? NShopStandard { get; set; }

    public byte? NWawiStandard { get; set; }

    public int KShop { get; set; }
}
