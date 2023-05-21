using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMerkmalSprache
{
    public int KMerkmal { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
