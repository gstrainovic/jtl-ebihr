using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAdditionalResult
{
    public int KAdditionalResult { get; set; }

    public int KArtikel { get; set; }

    public int KArtikelComponent { get; set; }

    public decimal FQuantity { get; set; }

    public bool NQuantityFixed { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProdItem KArtikelNavigation { get; set; } = null!;
}
