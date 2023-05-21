using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLotSize
{
    public int KLotSize { get; set; }

    public int KArtikel { get; set; }

    public int NSize { get; set; }

    public long? NAverageTime { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProdItem KArtikelNavigation { get; set; } = null!;
}
