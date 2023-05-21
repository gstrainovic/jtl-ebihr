using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tsynch
{
    public string? CIp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
