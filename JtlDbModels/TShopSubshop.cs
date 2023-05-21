using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShopSubshop
{
    public int KShopSubshop { get; set; }

    public int KShop { get; set; }

    public string? CIdentifier { get; set; }

    public byte NGesperrt { get; set; }

    public string? CAuthToken { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public long NMaxLastChanged { get; set; }
}
