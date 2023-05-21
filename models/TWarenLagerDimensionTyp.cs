using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenLagerDimensionTyp
{
    public int KWarenLagerDimensionTyp { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
