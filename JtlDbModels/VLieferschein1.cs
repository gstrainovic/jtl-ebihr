using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VLieferschein1
{
    public int KLieferschein { get; set; }

    public int? KShopauftrag { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? CHinweis { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? NFulfillment { get; set; }

    public int? KShop { get; set; }

    public int KAuftrag { get; set; }
}
