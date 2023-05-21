using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPrei
{
    public int KPreis { get; set; }

    public int KArtikel { get; set; }

    public int KKundenGruppe { get; set; }

    public int KShop { get; set; }

    public int KKunde { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
