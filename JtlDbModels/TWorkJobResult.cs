using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkJobResult
{
    public int KWorkJobResult { get; set; }

    public int KWorkJob { get; set; }

    public int KZustand { get; set; }

    public int? KArtikel { get; set; }

    public decimal FQuantity { get; set; }

    public decimal FRatio { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TWorkJob KWorkJobNavigation { get; set; } = null!;

    public virtual TZustand KZustandNavigation { get; set; } = null!;
}
