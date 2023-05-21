using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProdCondition
{
    public int KArtikel { get; set; }

    public int KZustand { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public decimal? NRejectsRatio { get; set; }

    public bool NForDisassembly { get; set; }

    public virtual TProdItem KArtikelNavigation { get; set; } = null!;

    public virtual TZustand KZustandNavigation { get; set; } = null!;
}
