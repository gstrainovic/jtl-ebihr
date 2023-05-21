using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tversion
{
    public string? CVersion { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
