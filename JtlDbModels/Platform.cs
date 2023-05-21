using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Platform
{
    public int PlatformId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
