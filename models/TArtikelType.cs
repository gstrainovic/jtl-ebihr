using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelType
{
    public int KArtikel { get; set; }

    public Guid UArtikelType { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
