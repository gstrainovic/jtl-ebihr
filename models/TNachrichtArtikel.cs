using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNachrichtArtikel
{
    public int KNachrichtArtikel { get; set; }

    public int KNachricht { get; set; }

    public int KArtikel { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
