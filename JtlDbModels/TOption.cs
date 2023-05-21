using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOption
{
    public string CKey { get; set; } = null!;

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
