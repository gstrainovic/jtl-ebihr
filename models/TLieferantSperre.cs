using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLieferantSperre
{
    public int? KLieferant { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
