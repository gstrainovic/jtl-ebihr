using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelkosten
{
    public int KArtikelkosten { get; set; }

    public int KArtikel { get; set; }

    public decimal FArtikelkosten { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
