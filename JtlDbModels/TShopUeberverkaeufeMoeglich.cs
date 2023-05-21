using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShopUeberverkaeufeMoeglich
{
    public int KShopUeberverkaeufeMoeglich { get; set; }

    public int KArtikel { get; set; }

    public int NPlattform { get; set; }

    public int KShop { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TShop KShopNavigation { get; set; } = null!;

    public virtual TPlattform NPlattformNavigation { get; set; } = null!;
}
