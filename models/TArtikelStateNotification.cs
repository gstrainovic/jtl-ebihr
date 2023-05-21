using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelStateNotification
{
    public Guid UObserverId { get; set; }

    public int KArtikel { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
