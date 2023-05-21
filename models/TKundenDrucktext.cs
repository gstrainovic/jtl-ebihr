using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TKundenDrucktext
{
    public int KKundenDrucktext { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
