using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TShopKundenGruppe
{
    public int KWebShop { get; set; }

    public int KKundenGruppe { get; set; }

    public byte? NStandard { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KShopKundengruppe { get; set; }

    public virtual TKundenGruppe KKundenGruppeNavigation { get; set; } = null!;

    public virtual TShop KWebShopNavigation { get; set; } = null!;
}
