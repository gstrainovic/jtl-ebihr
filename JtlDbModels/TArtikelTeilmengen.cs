using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelTeilmengen
{
    public int KArtikel { get; set; }

    public int? NTeilmengenPuffer { get; set; }

    public int NReservierungsModus { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
