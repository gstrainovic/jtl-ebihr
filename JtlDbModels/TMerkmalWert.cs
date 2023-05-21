using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMerkmalWert
{
    public int KMerkmalWert { get; set; }

    public int? KMerkmal { get; set; }

    public int? NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
