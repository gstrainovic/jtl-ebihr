using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEinheit
{
    public int KEinheit { get; set; }

    public byte NIstUnsichtbar { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
