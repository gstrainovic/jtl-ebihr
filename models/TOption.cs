using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOption
{
    public string CKey { get; set; } = null!;

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
