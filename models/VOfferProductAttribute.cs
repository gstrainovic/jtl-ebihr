using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOfferProductAttribute
{
    public int KShop { get; set; }

    public int KArtikel { get; set; }

    public int KShopScx { get; set; }

    public string? CAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public bool NIsDotLiquidValue { get; set; }

    public int NReferenzGruppe { get; set; }
}
