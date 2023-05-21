using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelAsin
{
    public int KArtikelAsin { get; set; }

    public int KArtikel { get; set; }

    public string CAsin { get; set; } = null!;

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
