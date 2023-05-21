using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAbgleichOption
{
    public string CKey { get; set; } = null!;

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
