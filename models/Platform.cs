using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Platform
{
    public int PlatformId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
