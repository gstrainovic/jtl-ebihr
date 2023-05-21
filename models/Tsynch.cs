using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tsynch
{
    public string? CIp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
