using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelLabel
{
    public int KArtikel { get; set; }

    public int KLabel { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TLabel KLabelNavigation { get; set; } = null!;
}
