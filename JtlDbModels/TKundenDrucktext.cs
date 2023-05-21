using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKundenDrucktext
{
    public int KKundenDrucktext { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
