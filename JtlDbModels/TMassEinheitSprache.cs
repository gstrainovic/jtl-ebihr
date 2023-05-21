using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMassEinheitSprache
{
    public int KMassEinheit { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
