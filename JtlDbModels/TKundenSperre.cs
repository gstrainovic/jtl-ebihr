using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKundenSperre
{
    public int? KKunde { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
