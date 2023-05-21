using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenLagerDimensionTyp
{
    public int KWarenLagerDimensionTyp { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
