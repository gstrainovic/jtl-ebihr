using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWmsoptionen
{
    public string? CName { get; set; }

    public string? CWert { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
