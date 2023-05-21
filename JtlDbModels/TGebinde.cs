using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TGebinde
{
    public int KGebinde { get; set; }

    public int KArtikel { get; set; }

    public string? CName { get; set; }

    public decimal FAnzahl { get; set; }

    public string? CEan { get; set; }

    public string? CUpc { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
