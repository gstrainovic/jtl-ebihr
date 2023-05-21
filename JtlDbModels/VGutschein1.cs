using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VGutschein1
{
    public int KGutschein { get; set; }

    public int KInetKunde { get; set; }

    public decimal FWert { get; set; }

    public string? CGrund { get; set; }

    public int? KShop { get; set; }
}
