using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVerkaufskanalCategoryFeldWert
{
    public int KVerkaufskanalCategoryFeldWert { get; set; }

    public int KShopScx { get; set; }

    public int KCategory { get; set; }

    public string? CAttributeId { get; set; }

    public string CWert { get; set; } = null!;

    public string? CName { get; set; }

    public bool NIsDotLiquidValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NReferenzGruppe { get; set; }

    public int? Kfile { get; set; }

    public virtual TShopScx KShopScxNavigation { get; set; } = null!;

    public virtual TFile? KfileNavigation { get; set; }
}
