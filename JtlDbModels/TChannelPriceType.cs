using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TChannelPriceType
{
    public int KChannelPriceType { get; set; }

    public int KChannel { get; set; }

    public int KShop { get; set; }

    public string? CPriceTypeId { get; set; }

    public string? CDisplayName { get; set; }

    public string? CDescription { get; set; }

    public int? KKundenGruppe { get; set; }

    public virtual TChannel KChannelNavigation { get; set; } = null!;

    public virtual TShop KShopNavigation { get; set; } = null!;
}
