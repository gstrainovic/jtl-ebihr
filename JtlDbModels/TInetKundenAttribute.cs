using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TInetKundenAttribute
{
    public int KInetKunde { get; set; }

    public int KShop { get; set; }

    public string? CName { get; set; }

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
