using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelType
{
    public int KArtikel { get; set; }

    public Guid UArtikelType { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
