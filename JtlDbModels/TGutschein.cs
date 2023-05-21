using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TGutschein
{
    public int KGutschein { get; set; }

    public int? KKunde { get; set; }

    public int? KShop { get; set; }

    public decimal FWert { get; set; }

    public string? CGrund { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CInet { get; set; }

    public int? KInetKunde { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
